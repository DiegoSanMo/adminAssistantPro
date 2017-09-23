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

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmConsultaAlumnos.Show()
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
        Dim n As Integer
        comando.CommandText = "Select count (*) From ciclo"
        n = comando.ExecuteScalar + 1

        Dim nombre As String = CStr(n) + "-" + CStr(Year(fecha))
        Dim estado As String = "Abierto"

        Dim ban As Boolean

        If n <= 1 Then
            transaccion = conexionsql.BeginTransaction("TransaccionCiclo")
            comando.Connection = conexionsql
            comando.Transaction = transaccion
            Try
                comando.CommandText = "Insert into ciclo(idCiclo, anio, estado) values(" & n & "," & Year(fecha) & ",'" & estado & "')"
                comando.ExecuteNonQuery()

                If MessageBox.Show("¿Desea abrir un nuevo ciclo?", "Apertura de ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    transaccion.Commit()
                    MessageBox.Show("El ciclo se creó exitosamente", "Apertura de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    comando.CommandText = "Create database""" & nombre & """;"
                    comando.ExecuteNonQuery()

                    'Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nombre & "'; Integrated Security=true")
                    Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & nombre & "'; Integrated Security=true")
                    Dim comando2 As SqlCommand = conexionsql2.CreateCommand
                    conexionsql2.Open()
                    comando2.CommandText = "Create table grupo(idGrupo int primary Key, idMaestro int, maxAlumnos int, cantInscritos int, nivel int, hLuIni varchar(20), hLuFin varchar(20),  hMaIni varchar(20), hMaFin varchar(20),  hMiIni varchar(20), hMiFin varchar(20),  hJuIni varchar(20), hJuFin varchar(20),  hViIni varchar(20), hViFin varchar(20),  hSaIni varchar(20), hSaFin varchar(20))"
                    comando2.ExecuteNonQuery()
                    comando2.CommandText = "Create table inscripcion(idInscripcion int primary key, idAlumno int, idGrupo int, fecha date);"
                    comando2.ExecuteNonQuery()


                    conexionsql2.Close()
                Else
                    transaccion.Rollback()
                    MessageBox.Show("La creación del ciclo fue cancelada", "Cancelación de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")

                Try
                    transaccion.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show("Error de ciclo")
                End Try
            End Try
        Else
            comando.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lector = comando.ExecuteReader
            lector.Read()
            If lector(0) = "Cerrado" Then
                lector.Close()
                transaccion = conexionsql.BeginTransaction("TransaccionCiclo")
                comando.Connection = conexionsql
                comando.Transaction = transaccion
                Try
                    comando.CommandText = "Insert into ciclo(idCiclo, anio, estado) values(" & n & "," & Year(fecha) & ",'" & estado & "')"
                    comando.ExecuteNonQuery()

                    If MessageBox.Show("¿Desea abrir un nuevo ciclo?", "Apertura de ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        transaccion.Commit()
                        MessageBox.Show("El ciclo se creó exitosamente", "Apertura de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        comando.CommandText = "Create database""" & nombre & """;"
                        comando.ExecuteNonQuery()


                        'Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nombre & "'; Integrated Security=true")
                        Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & nombre & "'; Integrated Security=true")
                        Dim comando2 As SqlCommand = conexionsql2.CreateCommand
                        conexionsql2.Open()
                        comando2.CommandText = "Create table grupo(idGrupo int primary Key, idMaestro int, maxAlumnos int, cantInscritos int, nivel int, hLuIni varchar(20), hLuFin varchar(20),  hMaIni varchar(20), hMaFin varchar(20),  hMiIni varchar(20), hMiFin varchar(20),  hJuIni varchar(20), hJuFin varchar(20),  hViIni varchar(20), hViFin varchar(20),  hSaIni varchar(20), hSaFin varchar(20))"
                        comando2.ExecuteNonQuery()
                        comando2.CommandText = "Create table inscripcion(idInscripcion int primary key, idAlumno int, idGrupo int, fecha date);"
                        comando2.ExecuteNonQuery()

                        conexionsql2.Close()
                    Else
                        ban = True
                        transaccion.Rollback()
                        MessageBox.Show("La creación del ciclo fue cancelada", "Cancelación de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")

                    Try
                        transaccion.Rollback()
                    Catch ex2 As Exception
                        MessageBox.Show("Error de ciclo")
                    End Try
                End Try
            ElseIf lector(0) = "Abierto" Then
                lector.Close()

                MessageBox.Show("No se puede abrir un nuevo ciclo. Tiene que cerrar el ciclo anterior.", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        conexionsql.Close()
    End Sub

    Private Sub AbrirGrupoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirGrupoToolStripMenuItem.Click
        Conexion.Open()

        Dim n As Integer

        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        n = comandoGeneral.ExecuteScalar

        If n = 0 Then
            Conexion.Close()
            MessageBox.Show("ERROR, NO SE HA ABIERTO CICLO", "ERROR DE CICLO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lectorGeneral = comandoGeneral.ExecuteReader
            lectorGeneral.Read()

            If lectorGeneral(0) = "Cerrado" Then
                lectorGeneral.Close()
                Conexion.Close()
                MessageBox.Show("ERROR, CICLO CERRADO", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lectorGeneral.Close()
                Conexion.Close()
                frmGruposRegistro.Show()
            End If
        End If
    End Sub
End Class