Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
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

                    Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nombre & "'; Integrated Security=true")
                    'Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & nombre & "'; Integrated Security=true")
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

                        Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nombre & "'; Integrated Security=true")
                        'Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & nombre & "'; Integrated Security=true")
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

    Private Sub RegistroToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem2.Click
        Conexion.Open()
        comandoGeneral.CommandText = "Select count(idCiclo) From ciclo"
        Dim n As Integer = comandoGeneral.ExecuteScalar
        Dim idCiclo As Integer
        Dim anioC As String

        comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()

        idCiclo = lectorGeneral(0)
        anioC = lectorGeneral(1)

        Name = CStr(idCiclo) + CStr("-") + CStr(anioC)
        lectorGeneral.Close()
        Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=true")
        'Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=true")
        Dim comando2 As SqlCommand = conexionsql2.CreateCommand

        If n = 0 Then
            MessageBox.Show("Error. No se ha registrado ningún ciclo", "Error de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                Dim contGrupos As Integer
                conexionsql2.Open()
                comando2.CommandText = "Select count(idGrupo) From grupo"
                contGrupos = comando2.ExecuteScalar

                If contGrupos = 0 Then
                    MessageBox.Show("Error, no hay ningún grupo registrado", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                    lectorGeneral = comandoGeneral.ExecuteReader
                    lectorGeneral.Read()

                    If lectorGeneral(0) = "Cerrado" Then
                        lectorGeneral.Close()
                        Conexion.Close()
                        MessageBox.Show("ERROR, NO HAY NINGÚN CICLO ABIERTO", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        lectorGeneral.Close()
                        Conexion.Close()
                        frmInscripciones.Show()
                    End If
                End If
            End If
        End If
        conexionsql2.Close()
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        frmConsultaInscripciones.Show()
    End Sub

    Private Sub ClasificarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificarListasToolStripMenuItem.Click
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
                Dim idCiclo As Integer
                Dim anioC As String

                comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                lectorGeneral = comandoGeneral.ExecuteReader
                lectorGeneral.Read()

                idCiclo = lectorGeneral(0)
                anioC = lectorGeneral(1)

                Name = CStr(idCiclo) + CStr("-") + CStr(anioC)
                lectorGeneral.Close()
                Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=true")
                'Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=true")
                Dim comando2 As SqlCommand = conexionsql2.CreateCommand

                conexionsql2.Open()
                Dim contGrupos As Integer
                Dim contInscritos As Integer
                comando2.CommandText = "Select count(idGrupo) From grupo"
                contGrupos = comando2.ExecuteScalar
                comando2.CommandText = "Select count(idAlumno) From inscripcion"
                contInscritos = comando2.ExecuteScalar
                If contGrupos = 0 Then
                    MessageBox.Show("Error. No hay ningún grupo registrado", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If contInscritos = 0 Then
                        MessageBox.Show("Error. No hay ningún alumno inscrito", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim contListas As Integer
                        For i = 1 To contGrupos
                            comando2.CommandText = "Select count(*)from INFORMATION_SCHEMA.TABLES Where TABLE_NAME = 'lista" & i & "';"
                            contListas = contListas + comando2.ExecuteScalar()
                        Next
                        MessageBox.Show(contListas)
                        If contListas = 0 Then
                            transaccion2 = conexionsql2.BeginTransaction("TransaccionClasificarPorListas")
                            comando2.Connection = conexionsql2
                            comando2.Transaction = transaccion2

                            Try
                                If MessageBox.Show("¿Desea crear y clasificar listas?", "Creación y clasificación de listas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    For j = 1 To contGrupos
                                        comando2.CommandText = "Select c.idAlumno, nombre Into lista" & j & " From [" & Name & "].dbo.inscripcion c LEFT JOIN MasterEA.dbo.alumno m On c.idAlumno = m.idAlumno Where idGrupo =" & j & ""
                                        comando2.ExecuteNonQuery()
                                        comando2.CommandText = "alter table lista" & j & " Add calificacion decimal Not Null Default 0 With values;"
                                        comando2.ExecuteNonQuery()
                                    Next
                                    transaccion2.Commit()
                                    MessageBox.Show("Creación y clasificación de listas exitosa", "Creación y clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    transaccion2.Rollback()
                                    MessageBox.Show("Creación y clasificación de listas cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Catch ex As Exception
                                Dim mistake As String = ex.ToString
                                MessageBox.Show(mistake)
                                MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                Try
                                    transaccion.Rollback()
                                Catch ex2 As Exception
                                    MessageBox.Show("Error de listas")
                                End Try
                            End Try
                        ElseIf contListas < contGrupos Then
                            transaccion2 = conexionsql2.BeginTransaction("TransaccionClasificarPorListas")
                            comando2.Connection = conexionsql2
                            comando2.Transaction = transaccion2

                            Try
                                If MessageBox.Show("¿Desea crear y clasificar listas?", "Creación y clasificación de listas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    For j = contListas + 1 To contGrupos
                                        comando2.CommandText = "Select c.idAlumno, nombre Into lista" & j & " From [" & Name & "].dbo.inscripcion c LEFT JOIN MasterEA.dbo.alumno m On c.idAlumno = m.idAlumno Where idGrupo =" & j & ""
                                        comando2.ExecuteNonQuery()
                                        comando2.CommandText = "alter table lista" & j & " Add calificacion decimal Not Null Default 0 With values;"
                                        comando2.ExecuteNonQuery()
                                    Next
                                    transaccion2.Commit()
                                    MessageBox.Show("Creación y clasificación de listas exitosa", "Creación y clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    transaccion2.Rollback()
                                    MessageBox.Show("Creación y clasificación de listas cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Catch ex As Exception
                                Dim mistake As String = ex.ToString
                                MessageBox.Show(mistake)
                                MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                Try
                                    transaccion.Rollback()
                                Catch ex2 As Exception
                                    MessageBox.Show("Error de listas")
                                End Try
                            End Try
                        End If
                    End If
                End If
                conexionsql2.Close()
                Conexion.Close()
            End If
        End If
    End Sub

    Private Sub CapturarCalificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturarCalificacionesToolStripMenuItem.Click
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
                Dim idCiclo As Integer
                Dim anioC As String

                comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                lectorGeneral = comandoGeneral.ExecuteReader
                lectorGeneral.Read()

                idCiclo = lectorGeneral(0)
                anioC = lectorGeneral(1)

                Name = CStr(idCiclo) + CStr("-") + CStr(anioC)
                lectorGeneral.Close()
                'Dim conexionCiclo As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=true")
                Dim conexionCiclo As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=true")
                Dim comandoCiclo As SqlCommand = conexionCiclo.CreateCommand

                conexionCiclo.Open()


                comandoCiclo.CommandText = "Select count(idGrupo) From grupo"
                Dim contGrupos As Integer = comandoCiclo.ExecuteScalar
                comandoCiclo.CommandText = "Select count(idAlumno) From inscripcion"
                Dim contInscritos As Integer = comandoCiclo.ExecuteScalar
                If contGrupos = 0 Then
                    MessageBox.Show("Error. No hay ningún grupo registrado", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If contInscritos = 0 Then
                        MessageBox.Show("Error. No hay ningún alumno inscrito", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        comandoCiclo.CommandText = "SELECT Count(*) FROM information_schema.tables"
                        canListas = comandoCiclo.ExecuteScalar - 2
                        If canListas = 0 Then
                            MessageBox.Show("ERROR, NO SE HAN CLASIFICADO LISTAS", "FALTA DE LISTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            conexionCiclo.Close()
                        Else
                            Conexion.Close()
                            conexionCiclo.Close()
                            nombreBDCilo = Name
                            frmAsignarCalificacion.ShowDialog()
                        End If

                    End If
                End If
                conexionCiclo.Close()
                Conexion.Close()
            End If
        End If

    End Sub

    Private Sub CerrarCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCicloToolStripMenuItem.Click
        Conexion.Open()

        Dim n As Integer
        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        n = comandoGeneral.ExecuteScalar
        If n = 0 Then
            MessageBox.Show("No hay ningún ciclo registrado", "Error de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                Dim idCiclo As Integer
                Dim anioC As String

                comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                lectorGeneral = comandoGeneral.ExecuteReader
                lectorGeneral.Read()

                idCiclo = lectorGeneral(0)
                anioC = lectorGeneral(1)

                Name = CStr(idCiclo) + CStr("-") + CStr(anioC)
                lectorGeneral.Close()
                Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=True")
                'Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=True")
                Dim comando2 As SqlCommand = conexionsql2.CreateCommand
                Dim comando3 As SqlCommand = conexionsql2.CreateCommand
                Dim lector2 As SqlDataReader
                Dim lector3 As SqlDataReader

                conexionsql2.Open()
                Dim contGrupos As Integer
                comando2.CommandText = "Select count(idGrupo) From grupo"
                contGrupos = comando2.ExecuteScalar

                Dim contListas As Integer
                For i = 1 To contGrupos
                    comando2.CommandText = "Select count(*)from INFORMATION_SCHEMA.TABLES Where TABLE_NAME = 'lista" & i & "';"
                    contListas = contListas + comando2.ExecuteScalar()
                Next

                If contListas = 0 Then
                    MessageBox.Show("Error. No hay ninguna lista creada", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    transaccion = Conexion.BeginTransaction("TransaccionCerrarCiclo")
                    comandoGeneral.Connection = Conexion
                    comandoGeneral.Transaction = transaccion
                    Try
                        For i = 1 To contListas
                            comando2.CommandText = "Select nivel From grupo Where idGrupo=" & i & ""
                            lector2 = comando2.ExecuteReader
                            lector2.Read()
                            Dim nivel As Integer = lector2(0)
                            lector2.Close()
                            comando2.CommandText = "Select idAlumno From lista" & i & ""
                            lector2 = comando2.ExecuteReader

                            While lector2.Read
                                Dim sit As String = "EN ESPERA"
                                Dim sitFin As String = "FINALIZADO"
                                comando3.CommandText = "Select calificacion From lista" & i & " Where idAlumno=" & lector2(0) & ""
                                lector3 = comando3.ExecuteReader
                                lector3.Read()
                                Dim calif As Decimal = lector3(0)
                                lector3.Close()
                                Dim est As String = "Cerrado"
                                If calif >= 80 Then
                                    If nivel = 12 Then
                                        comandoGeneral.CommandText = "Update kardex Set n" & nivel & "=" & calif & " Where idAlumno=" & lector2(0) & ""
                                        comandoGeneral.ExecuteNonQuery()
                                        comandoGeneral.CommandText = "Update alumno Set situacion='" & sitFin & "', ultimoNivelAcreditado=" & nivel & " Where idAlumno=" & lector2(0) & ""
                                        comandoGeneral.ExecuteNonQuery()
                                        comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                        comandoGeneral.ExecuteNonQuery()
                                    Else
                                        comandoGeneral.CommandText = "Update kardex Set n" & nivel & "=" & calif & " Where idAlumno=" & lector2(0) & ""
                                        comandoGeneral.ExecuteNonQuery()
                                        comandoGeneral.CommandText = "Update alumno Set situacion='" & sit & "', ultimoNivelAcreditado=" & nivel & " Where idAlumno=" & lector2(0) & ""
                                        comandoGeneral.ExecuteNonQuery()
                                        comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                        comandoGeneral.ExecuteNonQuery()
                                    End If
                                Else
                                    comandoGeneral.CommandText = "Update alumno Set situacion='" & sit & "' Where idAlumno=" & lector2(0) & ""
                                    comandoGeneral.ExecuteNonQuery()
                                    comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                    comandoGeneral.ExecuteNonQuery()
                                End If
                            End While
                            lector2.Close()
                        Next
                        If MessageBox.Show("¿Desea cerrar el ciclo?", "Cerrar ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            transaccion.Commit()
                            MessageBox.Show("El ciclo fue cerrado exitosamente", "Cerrar ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            transaccion.Rollback()
                            MessageBox.Show("El cerrado del ciclo fue cancelado", "Cancelación de cerrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        Dim mistake As String = ex.ToString
                        MessageBox.Show(mistake)
                        MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                        Try
                            transaccion.Rollback()
                        Catch ex2 As Exception
                            MessageBox.Show("Error de listas")
                        End Try
                    End Try
                End If
                conexionsql2.Close()
            End If
        End If
        Conexion.Close()
    End Sub

    Private Sub RegistroToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem3.Click
        frmRegistroUsuarios.showDialog()
    End Sub

    Private Sub KardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexToolStripMenuItem.Click
        Conexion.Open()

        comandoGeneral.CommandText = "Select count(idAlumno) from Kardex"
        Dim n As Integer = comandoGeneral.ExecuteScalar

        If n = 0 Then
            MessageBox.Show("NO HAY ALUMNOS REGISTRADOS", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Conexion.Close()
        Else
            Conexion.Close()
            frmKardexAlumno.ShowDialog()
        End If

    End Sub

    Private Sub ReporteDeAlumnosInscritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAlumnosInscritosToolStripMenuItem.Click
        Conexion.Open()
        comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()
        If lectorGeneral(0) = "Cerrado" Then
            MessageBox.Show("No se puede mostrar el reporte porque el ciclo está cerrado y no hay alumnos inscritos", "Error de reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lectorGeneral.Close()
            Conexion.Close()
        Else
            lectorGeneral.Close()
            Dim cmd As New SqlCommand("REPORTEALUMNOSINSCRITOS", Conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador1 As New SqlDataAdapter(cmd)
            Dim data1 As New DataSet
            adaptador1.Fill(data1)
            data1.DataSetName = "DataSet1"
            Dim reportes As New ReportDataSource("DataSet1", data1.Tables(0))
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteAlumnosInscritos.rdlc"
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            'lectorGeneral.Close()
            Conexion.Close()
        End If
    End Sub

    Private Sub ReporteDeMaestrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeMaestrosToolStripMenuItem.Click
        Dim cmd As New SqlCommand("REPORTEMAESTROS", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteMaestros.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        Conexion.Close()
    End Sub

    Private Sub ReporteDeGruposPorCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeGruposPorCicloToolStripMenuItem.Click
        Conexion.Open()

        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        Dim n As Integer = comandoGeneral.ExecuteScalar()

        If n > 0 Then
            comandoGeneral.CommandText = "DELETE FROM auxHorario"
            comandoGeneral.ExecuteNonQuery()

            comandoGeneral.CommandText = "Select idCiclo, anio from ciclo"
            lectorGeneral = comandoGeneral.ExecuteReader


            While lectorGeneral.Read

                Dim id As Integer = lectorGeneral(0)
                Dim anio As Integer = lectorGeneral(1)
                Dim nomBD As String = CStr(id) + "-" + CStr(anio)


                Using conexioBDRemota As New SqlConnection("Data source='PRO'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")

                    Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                    Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                    Dim lector2 As SqlDataReader
                    Dim lectorBDRemota As SqlDataReader

                    conexioBDRemota.Open()

                    comandoBDRemota.CommandText = "SELECT  G.idGrupo, M.nombre, M.correo, M.telefono, G.nivel, G.cantInscritos, G.maxAlumnos, 
		G.hLuIni, G.hLuFin, G.hMaIni, G.hMaFin, G.hMiIni, G.hMiFin, G.hJuIni, G.hJuFin, G.hViIni, G.hViFin, G.hSaIni, G.hSaFin  FROM MasterEA.dbo.maestro M LEFT JOIN  [" & nomBD & "].dbo.grupo G ON m.idMaestro = G.idMaestro where G.idGrupo <> 0"
                    lectorBDRemota = comandoBDRemota.ExecuteReader

                    While lectorBDRemota.Read
                        comando2.CommandText = "Insert into MasterEA.dbo.auxHorario values('" & nomBD & "'," & lectorBDRemota(0) & ",'" & lectorBDRemota(1) & "','" & lectorBDRemota(2) & "','" & lectorBDRemota(3) & "', " & lectorBDRemota(4) & ", " & lectorBDRemota(5) & "," & lectorBDRemota(6) & ",'" & lectorBDRemota(7) & "','" & lectorBDRemota(8) & "','" & lectorBDRemota(9) & "','" & lectorBDRemota(10) & "','" & lectorBDRemota(11) & "','" & lectorBDRemota(12) & "','" & lectorBDRemota(13) & "','" & lectorBDRemota(14) & "','" & lectorBDRemota(15) & "','" & lectorBDRemota(16) & "','" & lectorBDRemota(17) & "','" & lectorBDRemota(18) & "')"
                        comando2.ExecuteNonQuery()
                    End While
                    lectorBDRemota.Close()
                    conexioBDRemota.Close()
                End Using


            End While
            lectorGeneral.Close()
        End If


        Dim cmd As New SqlCommand("REPORTEGRUPOSGENERAL", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteGruposGeneral.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        Conexion.Close()
    End Sub

    Private Sub ReporteDeGruposPorCicloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteDeGruposPorCicloToolStripMenuItem1.Click

        Conexion.Open()

        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        Dim n As Integer = comandoGeneral.ExecuteScalar()

        If n > 0 Then
            comandoGeneral.CommandText = "DELETE FROM auxHorario"
            comandoGeneral.ExecuteNonQuery()
            'Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)
            comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lectorGeneral = comandoGeneral.ExecuteReader
            lectorGeneral.Read()


            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)


            If lectorGeneral(2) = "Abierto" Then
                lectorGeneral.Close()

                Using conexioBDRemota As New SqlConnection("Data source='PRO'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                'Using conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                    Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                    Dim lectorBDRemota As SqlDataReader

                    conexioBDRemota.Open()

                    comandoBDRemota.CommandText = "SELECT  G.idGrupo, M.nombre, M.correo, M.telefono, G.nivel, G.cantInscritos, G.maxAlumnos, 
		G.hLuIni, G.hLuFin, G.hMaIni, G.hMaFin, G.hMiIni, G.hMiFin, G.hJuIni, G.hJuFin, G.hViIni, G.hViFin, G.hSaIni, G.hSaFin  FROM MasterEA.dbo.maestro M LEFT JOIN  [" & nomBD & "].dbo.grupo G ON m.idMaestro = G.idMaestro where G.idGrupo <> 0"
                    lectorBDRemota = comandoBDRemota.ExecuteReader

                    While lectorBDRemota.Read
                        comando2.CommandText = "Insert into MasterEA.dbo.auxHorario values('" & nomBD & "'," & lectorBDRemota(0) & ",'" & lectorBDRemota(1) & "','" & lectorBDRemota(2) & "','" & lectorBDRemota(3) & "', " & lectorBDRemota(4) & ", " & lectorBDRemota(5) & "," & lectorBDRemota(6) & ",'" & lectorBDRemota(7) & "','" & lectorBDRemota(8) & "','" & lectorBDRemota(9) & "','" & lectorBDRemota(10) & "','" & lectorBDRemota(11) & "','" & lectorBDRemota(12) & "','" & lectorBDRemota(13) & "','" & lectorBDRemota(14) & "','" & lectorBDRemota(15) & "','" & lectorBDRemota(16) & "','" & lectorBDRemota(17) & "','" & lectorBDRemota(18) & "')"
                        comando2.ExecuteNonQuery()
                    End While
                    lectorBDRemota.Close()
                    conexioBDRemota.Close()
                End Using


                Dim cmd As New SqlCommand("REPORTEGRUPOSGENERAL", Conexion)
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(cmd)
                Dim data As New DataSet
                adaptador.Fill(data)
                data.DataSetName = "DataSet1"
                Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteGrupoCicloAbierto.rdlc"
                frmReportes.ReportViewer1.RefreshReport()
                frmReportes.ShowDialog()
                Conexion.Close()
            Else
                Conexion.Close()
                MessageBox.Show("ERROR, NO HAY CICLO ABIERTO PARA REALIZAR EL REPORTE", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub ReporteDeKardexPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeKardexPorAlumnoToolStripMenuItem.Click
        frmReporteKardex.ShowDialog()
    End Sub

    Private Sub ReporteDeListasPorCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeListasPorCicloToolStripMenuItem.Click
        frmReporteListas.ShowDialog()
    End Sub

    Private Sub ReporteDeAlumnosPorSituaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAlumnosPorSituaciónToolStripMenuItem.Click
        ReporteSituacion.ShowDialog()
    End Sub

    Private Sub ReporteDetalladoDeCalificacionesPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDetalladoDeCalificacionesPorAlumnoToolStripMenuItem.Click
        kardexDetallado = True
        frmReporteKardex.ShowDialog()
    End Sub

    Private Sub ReporteDetalladoDeCalificacionesPorAlumnoPorNivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDetalladoDeCalificacionesPorAlumnoPorNivelToolStripMenuItem.Click
        frmCalificacionesDet.ShowDialog()
    End Sub

    Private Sub ReporteDeCalificacionesFinalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCalificacionesFinalesToolStripMenuItem.Click
        frmReporteCalifFinales.ShowDialog()
    End Sub

    Private Sub ConstanciaDeNivelActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstanciaDeNivelActualToolStripMenuItem.Click
        Conexion.Open()
        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        Dim n As Integer = comandoGeneral.ExecuteScalar()

        If n > 0 Then
            comandoGeneral.CommandText = "DELETE FROM auxConstancia"
            comandoGeneral.ExecuteNonQuery()
            comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lectorGeneral = comandoGeneral.ExecuteReader
            lectorGeneral.Read()


            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)

            If lectorGeneral(2) = "Abierto" Then
                constancia = True
                lectorGeneral.Close()
                Conexion.Close()
                frmReporteCalifFinales.ShowDialog()
            Else
                constancia = False
                MessageBox.Show("ERROR. No hay ningún ciclo registrado", "Error de constancia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lectorGeneral.Close()
                Conexion.Close()
            End If
        Else
            constancia = False
            MessageBox.Show("ERROR. No hay ningún ciclo registrado", "Error de constancia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conexion.Close()
        End If
    End Sub
End Class