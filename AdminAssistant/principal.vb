Imports System.Data.SqlClient
Public Class principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub RegistroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem1.Click
        frmRegistroMaestro.Show()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        frmRegistroAlumno.Show()
    End Sub

    Private Sub RegistroToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem2.Click
        frmRegistroCiclo.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmConsultaAlumnos.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        frmConsultaCiclo.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        frmConsultaMaestros.Show()
    End Sub

    Private Sub InscipciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscipciónToolStripMenuItem.Click
        frmInscripciones.Show()
    End Sub

    Private Sub AbrirCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCicloToolStripMenuItem.Click
        conexionsql.Open()
        'Obtiene la fecha actual del sistema
        Dim fecha As Date = System.DateTime.Today
        'Cuenta los registros en la tabla. Asigna ese número a la variable n y lo eleva en uno
        Dim contReg As Integer
        comando.CommandText = "Select count(*) From ciclo"
        contReg = comando.ExecuteScalar
        Dim n As Integer
        comando.CommandText = "Select count (*) From ciclo"
        n = comando.ExecuteScalar + 1

        Dim nombre As String = Str(n) + "-" + Year(fecha)
        Dim estado As String = "Abierto"

        'Inicia la transacción
        transaccion = conexionsql.BeginTransaction("TransaccionEasyEnglish")
        'Asigna el objeto de la transacción y la conexión
        'a un objeto comando para una transacción local pendiente
        comando.Connection = conexionsql
        comando.Transaction = transaccion

        'Checa si hay registros en la tabla "ciclo" y manda un mensaje para ver si sí se quiere
        'registrar un nuevo ciclo
        If contReg = 0 Then
            Try
                comando.CommandText = "Insert into ciclo(idCiclo, año, estado) values(" & n & ",'" & fecha & "','" & estado & "')"
                comando.ExecuteNonQuery()

                'Crea la base de datos nueva
                comando.CommandText = "Create database '" & nombre & "';"
                comando.ExecuteNonQuery()
                If MessageBox.Show("¿Desea abrir un nuevo ciclo?", "Abrir nuevo ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    'comando.CommandText = "Insert into ciclo(idCiclo, año, estado) values(" & n & ",'" & fecha & "','" & estado & "')"
                    'comando.ExecuteNonQuery()

                    ''Crea la base de datos nueva
                    'comando.CommandText = "Create database '" & nombre & "';"
                    'comando.ExecuteNonQuery()
                    'transaccion.Commit()
                    transaccion.Commit()
                    MessageBox.Show("El ciclo fue abierto exitosamente", "Apertura de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    transaccion.Rollback()
                    MessageBox.Show("No se abrirá el ciclo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Commit Exception Type: {0}No se pudo insertar por error")
                Try
                    transaccion.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show("Error Rollback")
                End Try
            End Try
        Else
            Try
                comando.CommandText = "Select TOP 1 * From ciclo ORDER BY idCiclo DESC"
                lector = comando.ExecuteReader

                'Verifica el estado del último registro de la tabla
                If lector(2) = "Cerrado" Then
                    'Registra el ciclo en la tabla de ciclo
                    comando.CommandText = "Insert into ciclo(idCiclo, año, estado) values(" & n & ",'" & fecha & "','" & estado & "')"
                    comando.ExecuteNonQuery()
                    'Crea la base de datos nueva
                    comando.CommandText = "Create database '" & nombre & "';"
                    comando.ExecuteNonQuery()
                Else
                    MessageBox.Show("No se puede abrir un ciclo nuevo. Se tiene que cerrar el ciclo anterior", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If MessageBox.Show("¿Desea abrir un nuevo ciclo?", "Abrir nuevo ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    'Ordena los registros de la tabla en forma descendente, lo cual obtiene el último registro de la tabla
                    'comando.CommandText = "Select TOP 1 * From ciclo ORDER BY idCiclo DESC"
                    'lector = comando.ExecuteReader

                    ''Verifica el estado del último registro de la tabla
                    'If lector(2) = "Cerrado" Then
                    '    'Registra el ciclo en la tabla de ciclo
                    '    comando.CommandText = "Insert into ciclo(idCiclo, año, estado) values(" & n & ",'" & fecha & "','" & estado & "')"
                    '    comando.ExecuteNonQuery()
                    'Else
                    '    MessageBox.Show("No se puede abrir un ciclo nuevo. Se tiene que cerrar el ciclo anterior", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End If
                    ''Crea la base de datos nueva
                    'comando.CommandText = "Create database '" & nombre & "';"
                    'comando.ExecuteNonQuery()
                    'Se intenta ejecutar la transacción
                    transaccion.Commit()
                    MessageBox.Show("El ciclo fue abierto exitosamente", "Apertura de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    transaccion.Rollback()
                    MessageBox.Show("No se abrirá el ciclo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Commit Exception Type: {0}No se pudo insertar por error")
                Try
                    transaccion.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show("Error Rollback")
                End Try
            End Try
        End If
        conexionsql.Close()
    End Sub
End Class