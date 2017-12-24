Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub RegistroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem1.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    frmRegistroMaestro.Show()
                Else
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de maestro"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de maestro"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Dim ban As Boolean = False
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    ban = True
                End If
                lectorMasterServidor.Close()
                If ban Then
                    conexionMasterServidor.Close()
                    frmRegistroAlumno.Show()
                Else
                    conexionMasterServidor.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de alumno"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de alumno"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    frmConsultaAlumnos.Show()
                Else
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de consulta de alumnos"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de consulta de alumnos"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    frmConsultaMaestros.Show()
                Else
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de consulta de maestros"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'conexionMasterServidor.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de consulta de maestros"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub AbrirCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCicloToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                conexionsql.Open()
                Try
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

                        transaccionMasterServidor = conexionMasterServidor.BeginTransaction("TransaccionCicloAuxiliar")
                        comandoMasterServidor.Connection = conexionMasterServidor
                        comandoMasterServidor.Transaction = transaccionMasterServidor
                        Try
                            comando.CommandText = "Insert into ciclo(idCiclo, anio, estado) values(" & n & "," & Year(fecha) & ",'" & estado & "')"
                            comando.ExecuteNonQuery()

                            comandoMasterServidor.CommandText = "Insert into ciclo(idCiclo, anio, estado) values(" & n & "," & Year(fecha) & ",'" & estado & "')"
                            comandoMasterServidor.ExecuteNonQuery()

                            If MessageBox.Show("¿Desea abrir un nuevo ciclo?", "Apertura de ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                transaccion.Commit()
                                transaccionMasterServidor.Commit()
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
                                transaccionMasterServidor.Rollback()
                                MessageBox.Show("La creación del ciclo fue cancelada", "Cancelación de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                            'Dim st As New StackTrace(True)
                            'st = New StackTrace(ex, True)
                            'frame = Me.Name
                            'descripcion = "Falla de apertura de ciclo"
                            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                            'contFalla = comandoMasterServidor.ExecuteScalar + 1
                            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                            'comandoMasterServidor.ExecuteNonQuery()
                            'conexionMasterServidor.Close()
                            Try
                                transaccion.Rollback()
                                transaccionMasterServidor.Rollback()
                            Catch ex2 As Exception
                                MessageBox.Show("Error de ciclo")

                                'Dim st2 As New StackTrace(True)
                                'st2 = New StackTrace(ex, True)
                                'frame = Me.Name
                                'descripcion = "Falla de apertura de ciclo"
                                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st2.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                'comandoMasterServidor.ExecuteNonQuery()
                                'conexionMasterServidor.Close()
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

                            transaccionMasterServidor = conexionMasterServidor.BeginTransaction("TransaccionCicloAuxiliar")
                            comandoMasterServidor.Connection = conexionMasterServidor
                            comandoMasterServidor.Transaction = transaccionMasterServidor
                            Try
                                comando.CommandText = "Insert into ciclo(idCiclo, anio, estado) values(" & n & "," & Year(fecha) & ",'" & estado & "')"
                                comando.ExecuteNonQuery()

                                comandoMasterServidor.CommandText = "Insert into ciclo(idCiclo, anio, estado) values(" & n & "," & Year(fecha) & ",'" & estado & "')"
                                comandoMasterServidor.ExecuteNonQuery()

                                If MessageBox.Show("¿Desea abrir un nuevo ciclo?", "Apertura de ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    transaccion.Commit()
                                    transaccionMasterServidor.Commit()
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
                                    transaccionMasterServidor.Rollback()
                                    MessageBox.Show("La creación del ciclo fue cancelada", "Cancelación de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            Catch ex As Exception
                                MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                'Dim st As New StackTrace(True)
                                'st = New StackTrace(ex, True)
                                'frame = Me.Name
                                'descripcion = "Falla de apertura de ciclo"
                                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                'comandoMasterServidor.ExecuteNonQuery()
                                'conexionMasterServidor.Close()

                                Try
                                    transaccionMasterServidor.Rollback()
                                Catch ex2 As Exception
                                    MessageBox.Show("Error de ciclo")
                                    'Dim st2 As New StackTrace(True)
                                    'st2 = New StackTrace(ex2, True)
                                    'frame = Me.Name
                                    'descripcion = "Falla de apertura de ciclo"
                                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st2.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                    'comandoMasterServidor.ExecuteNonQuery()
                                    'conexionMasterServidor.Close()
                                End Try
                            End Try
                        ElseIf lector(0) = "Abierto" Then
                            lector.Close()

                            MessageBox.Show("No se puede abrir un nuevo ciclo. Tiene que cerrar el ciclo anterior.", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    conexionsql.Close()
                Catch ex As Exception

                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de apertura de ciclo"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de apertura de ciclo"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub AbrirGrupoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirGrupoToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
                    Dim n As Integer
                    comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
                    n = comandoGeneral.ExecuteScalar

                    If n = 0 Then
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        MessageBox.Show("ERROR, NO SE HA ABIERTO CICLO", "ERROR DE CICLO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                        lectorGeneral = comandoGeneral.ExecuteReader
                        lectorGeneral.Read()

                        If lectorGeneral(0) = "Cerrado" Then
                            lectorGeneral.Close()
                            Conexion.Close()
                            conexionMasterServidor.Close()
                            MessageBox.Show("ERROR, CICLO CERRADO", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            lectorGeneral.Close()
                            Conexion.Close()
                            conexionMasterServidor.Close()
                            frmGruposRegistro.Show()
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de apertura de grupo"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()

                    ''CIERRE DE CONEXIONES
                    'conexionMasterServidor.Close()
                    'Conexion.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de apertura de grupo"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()

                ''CIERRE DE CONEXIONES
                'conexionMasterServidor.Close()
                'Conexion.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de apertura de grupo"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()

            ''CIERRE DE CONEXIONES
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub RegistroToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem2.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
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
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()

                        MessageBox.Show("Error. No se ha registrado ningún ciclo", "Error de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                        lectorGeneral = comandoGeneral.ExecuteReader
                        lectorGeneral.Read()

                        If lectorGeneral(0) = "Cerrado" Then
                            lectorGeneral.Close()

                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()

                            MessageBox.Show("ERROR, CICLO CERRADO", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            lectorGeneral.Close()
                            Dim contGrupos As Integer

                            'SE HA ABIERTO UNA CONEXION
                            conexionsql2.Open()
                            '//////////////////////////
                            comando2.CommandText = "Select count(idGrupo) From grupo"
                            contGrupos = comando2.ExecuteScalar

                            If contGrupos = 0 Then
                                'CIERRE DE CONEXIONES
                                Conexion.Close()
                                conexionMasterServidor.Close()
                                conexionsql2.Close()
                                'TERMINA SECCION DE CONEXIONES

                                MessageBox.Show("Error, no hay ningún grupo registrado", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                                lectorGeneral = comandoGeneral.ExecuteReader
                                lectorGeneral.Read()

                                If lectorGeneral(0) = "Cerrado" Then
                                    lectorGeneral.Close()

                                    'CIERRE DE CONEXIONES
                                    conexionsql2.Close()
                                    Conexion.Close()
                                    conexionMasterServidor.Close()
                                    'TERMINA SECCIÓN DE CIERRE DE CONEXIONES

                                    MessageBox.Show("ERROR, NO HAY NINGÚN CICLO ABIERTO", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    lectorGeneral.Close()
                                    'CIERRE DE CONEXIONES
                                    conexionsql2.Close()
                                    Conexion.Close()
                                    conexionMasterServidor.Close()
                                    'TERMINA SECCIÓN DE CIERRE DE CONEXIONES
                                    frmInscripciones.Show()
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de inscripciones"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    ''CIERRE DE CONEXIONES
                    'conexionMasterServidor.Close()
                    'Conexion.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de inscripciones"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()

                ''CIERRE DE CONEXIONES
                'conexionMasterServidor.Close()
                'Conexion.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de inscripciones"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()

            ''CIERRE DE CONEXIONES
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    lectorMasterServidor.Close()
                    'CIERRE DE CONEXIONES
                    conexionMasterServidor.Close()
                    'TERMINA SECCIÓN DE CONEXIONES
                    frmConsultaInscripciones.Show()
                Else
                    'CIERRE DE CONEXIONES
                    conexionMasterServidor.Close()
                    'TERMINA SECCIÓN DE CONEXIONES
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de consulta de inscripciones"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                ''CIERRE DE CONEXIONES
                'conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de consulta de inscripciones"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            ''CIERRE DE CONEXIONES
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ClasificarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificarListasToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
                    Dim n As Integer
                    comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
                    n = comandoGeneral.ExecuteScalar

                    If n = 0 Then
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        'TERMINA SECCION DE CONEXIONES
                        MessageBox.Show("ERROR, NO SE HA ABIERTO CICLO", "ERROR DE CICLO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                        lectorGeneral = comandoGeneral.ExecuteReader
                        lectorGeneral.Read()

                        If lectorGeneral(0) = "Cerrado" Then
                            lectorGeneral.Close()
                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()
                            'TERMINA SECCION DE CONEXIONES
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

                            'DECLARACION Y APERTURA DE UNA NUEVA CONEXIÓN
                            conexionsql2.Open()
                            'TERMINA SECCION DE CONEXIONES
                            Dim contGrupos As Integer
                            Dim contInscritos As Integer
                            comando2.CommandText = "Select count(idGrupo) From grupo"
                            contGrupos = comando2.ExecuteScalar
                            comando2.CommandText = "Select count(idAlumno) From inscripcion"
                            contInscritos = comando2.ExecuteScalar
                            If contGrupos = 0 Then
                                'CIERRE DE CONEXIONES
                                conexionsql2.Close()
                                Conexion.Close()
                                conexionMasterServidor.Close()
                                'TERMINA SECCION DE CONEXIONES
                                MessageBox.Show("Error. No hay ningún grupo registrado", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                If contInscritos = 0 Then
                                    'CIERRE DE CONEXIONES
                                    conexionsql2.Close()
                                    Conexion.Close()
                                    conexionMasterServidor.Close()
                                    'TERMINA SECCION DE CONEXIONES
                                    MessageBox.Show("Error. No hay ningún alumno inscrito", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    Dim contListas As Integer
                                    For i = 1 To contGrupos
                                        comando2.CommandText = "Select count(*)from INFORMATION_SCHEMA.TABLES Where TABLE_NAME = 'lista" & i & "';"
                                        contListas = contListas + comando2.ExecuteScalar()
                                    Next

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
                                                Conexion.Close()
                                                conexionMasterServidor.Close()
                                                MessageBox.Show("Creación y clasificación de listas exitosa", "Creación y clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Else
                                                transaccion2.Rollback()
                                                MessageBox.Show("Creación y clasificación de listas cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            End If
                                        Catch ex As Exception
                                            'Dim mistake As String = ex.ToString
                                            'MessageBox.Show(mistake)
                                            MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                            'MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            'Dim st As New StackTrace(True)
                                            'st = New StackTrace(ex, True)
                                            'frame = Me.Name
                                            'descripcion = "Falla de creación de listas"
                                            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                            'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                            'comandoMasterServidor.ExecuteNonQuery()
                                            ''CIERRE DE CONEXIONES
                                            'conexionsql2.Close()
                                            'Conexion.Close()
                                            'conexionMasterServidor.Close()
                                            'TERMINA SECCION DE CONEXIONES
                                            Try
                                                transaccion.Rollback()
                                            Catch ex2 As Exception
                                                MessageBox.Show("Error de listas")
                                                'MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                'Dim st2 As New StackTrace(True)
                                                'st2 = New StackTrace(ex, True)
                                                'frame = Me.Name
                                                'descripcion = "Falla de creación de listas"
                                                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st2.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                                'comandoMasterServidor.ExecuteNonQuery()
                                                ''CIERRE DE CONEXIONES
                                                'conexionsql2.Close()
                                                'Conexion.Close()
                                                'conexionMasterServidor.Close()
                                                'TERMINA SECCION DE CONEXIONES
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
                                                'CIERRE DE CONEXIONES
                                                conexionsql2.Close()
                                                Conexion.Close()
                                                conexionMasterServidor.Close()
                                                'TERMINA SECCION DE CONEXIONES
                                            Else
                                                transaccion2.Rollback()
                                                MessageBox.Show("Creación y clasificación de listas cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                'CIERRE DE CONEXIONES
                                                conexionsql2.Close()
                                                Conexion.Close()
                                                conexionMasterServidor.Close()
                                                'TERMINA SECCION DE CONEXIONES
                                            End If
                                        Catch ex As Exception
                                            'Dim mistake As String = ex.ToString
                                            'MessageBox.Show(mistake)
                                            MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                            'MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            'Dim st As New StackTrace(True)
                                            'st = New StackTrace(ex, True)
                                            'frame = Me.Name
                                            'descripcion = "Falla de creación de listas"
                                            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                            'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                            'comandoMasterServidor.ExecuteNonQuery()
                                            ''CIERRE DE CONEXIONES
                                            'conexionsql2.Close()
                                            'Conexion.Close()
                                            'conexionMasterServidor.Close()
                                            ''TERMINA SECCION DE CONEXIONES
                                            Try
                                                transaccion.Rollback()
                                            Catch ex2 As Exception
                                                MessageBox.Show("Error de listas")
                                                'MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                'Dim st2 As New StackTrace(True)
                                                'st2 = New StackTrace(ex, True)
                                                'frame = Me.Name
                                                'descripcion = "Falla de creación de listas"
                                                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st2.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                                'comandoMasterServidor.ExecuteNonQuery()
                                                ''CIERRE DE CONEXIONES
                                                'conexionsql2.Close()
                                                'Conexion.Close()
                                                'conexionMasterServidor.Close()
                                                ''TERMINA SECCION DE CONEXIONES
                                            End Try
                                        End Try
                                    End If
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de apertura de clasificación de listas"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de apertura de clasificación de listas"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                ''CIERRE DE CONEXIONES
                'Conexion.Close()
                'conexionMasterServidor.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de apertura de clasificación de listas"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub CapturarCalificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturarCalificacionesToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
                    Dim n As Integer
                    comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
                    n = comandoGeneral.ExecuteScalar
                    If n = 0 Then
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        'TERMINA SECCION DE CONEXIONES
                        MessageBox.Show("ERROR, NO SE HA ABIERTO CICLO", "ERROR DE CICLO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                        lectorGeneral = comandoGeneral.ExecuteReader
                        lectorGeneral.Read()

                        If lectorGeneral(0) = "Cerrado" Then
                            lectorGeneral.Close()
                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()
                            'TERMINA SECCION DE CONEXIONES
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

                            'SE ABRE OTRA CONEXION
                            conexionCiclo.Open()
                            'TERMINA SECCION DE CONEXIONES

                            comandoCiclo.CommandText = "Select count(idGrupo) From grupo"
                            Dim contGrupos As Integer = comandoCiclo.ExecuteScalar
                            comandoCiclo.CommandText = "Select count(idAlumno) From inscripcion"
                            Dim contInscritos As Integer = comandoCiclo.ExecuteScalar
                            If contGrupos = 0 Then
                                'CIERRE DE CONEXIONES
                                conexionCiclo.Close()
                                Conexion.Close()
                                conexionMasterServidor.Close()
                                'TERMINA SECCION DE CONEXIONES

                                MessageBox.Show("Error. No hay ningún grupo registrado", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                If contInscritos = 0 Then
                                    'CIERRE DE CONEXIONES
                                    conexionCiclo.Close()
                                    Conexion.Close()
                                    conexionMasterServidor.Close()
                                    'TERMINA SECCION DE CONEXIONES
                                    MessageBox.Show("Error. No hay ningún alumno inscrito", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else

                                    comandoCiclo.CommandText = "SELECT Count(*) FROM information_schema.tables"
                                    canListas = comandoCiclo.ExecuteScalar - 2
                                    If canListas = 0 Then
                                        'CIERRE DE CONEXIONES
                                        conexionCiclo.Close()
                                        Conexion.Close()
                                        conexionMasterServidor.Close()
                                        'TERMINA SECCION DE CONEXIONES
                                        MessageBox.Show("ERROR, NO SE HAN CLASIFICADO LISTAS", "FALTA DE LISTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Else
                                        'CIERRE DE CONEXIONES
                                        conexionCiclo.Close()
                                        Conexion.Close()
                                        conexionMasterServidor.Close()
                                        'TERMINA SECCION DE CONEXIONES
                                        nombreBDCilo = Name
                                        frmAsignarCalificacion.ShowDialog()
                                    End If

                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de captura de calificaciones"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    ''CIERRE DE CONEXIONES
                    'Conexion.Close()
                    'conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de captura de calificaciones"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                ''CIERRE DE CONEXIONES
                'Conexion.Close()
                'conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de captura de calificaciones"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub CerrarCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCicloToolStripMenuItem.Click
        Try
            'Try para intentar acceder a la conexion con el servidor sql
            conexionMasterServidor.Open()
            Try
                'Try PARA INTENTAR ACCEDER A LA CONEXION CON EL LA BASE DE DATOS MASTEREA
                Conexion.Open()
                Try
                    'Try PARA INTENTAR CERRAR EL CICLO
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

                            'cerrando conexiones
                            Conexion.Close()
                            conexionMasterServidor.Close()
                            'termina seccion de cerrar conexiones

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
                                'cerrando conexiones
                                Conexion.Close()
                                conexionMasterServidor.Close()
                                conexionsql2.Close()
                                'termina seccion de cerrar conexiones

                                MessageBox.Show("Error. No hay ninguna lista creada", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                transaccion = Conexion.BeginTransaction("TransaccionCerrarCiclo")
                                comandoGeneral.Connection = Conexion
                                comandoGeneral.Transaction = transaccion

                                transaccionMasterServidor = conexionMasterServidor.BeginTransaction("TransaccionCicloAuxiliar")
                                comandoMasterServidor.Connection = conexionMasterServidor
                                comandoMasterServidor.Transaction = transaccionMasterServidor
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
                                                    comandoMasterServidor.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                                    comandoMasterServidor.ExecuteNonQuery()
                                                Else
                                                    comandoGeneral.CommandText = "Update kardex Set n" & nivel & "=" & calif & " Where idAlumno=" & lector2(0) & ""
                                                    comandoGeneral.ExecuteNonQuery()
                                                    comandoGeneral.CommandText = "Update alumno Set situacion='" & sit & "', ultimoNivelAcreditado=" & nivel & " Where idAlumno=" & lector2(0) & ""
                                                    comandoGeneral.ExecuteNonQuery()
                                                    comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                                    comandoGeneral.ExecuteNonQuery()
                                                    comandoMasterServidor.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                                    comandoMasterServidor.ExecuteNonQuery()
                                                End If
                                            Else
                                                comandoGeneral.CommandText = "Update alumno Set situacion='" & sit & "' Where idAlumno=" & lector2(0) & ""
                                                comandoGeneral.ExecuteNonQuery()
                                                comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                                comandoGeneral.ExecuteNonQuery()
                                                comandoMasterServidor.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
                                                comandoMasterServidor.ExecuteNonQuery()
                                            End If
                                        End While
                                        lector2.Close()
                                    Next
                                    If MessageBox.Show("¿Desea cerrar el ciclo?", "Cerrar ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                        transaccion.Commit()
                                        transaccionMasterServidor.Commit()
                                        MessageBox.Show("El ciclo fue cerrado exitosamente", "Cerrar ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        'cerrando conexiones
                                        conexionsql2.Close()
                                        Conexion.Close()
                                        conexionMasterServidor.Close()
                                        'termina seccion de cerrar conexiones
                                    Else
                                        transaccion.Rollback()
                                        transaccionMasterServidor.Rollback()
                                        MessageBox.Show("El cerrado del ciclo fue cancelado", "Cancelación de cerrado", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                        'cerrando conexiones
                                        conexionsql2.Close()
                                        Conexion.Close()
                                        conexionMasterServidor.Close()
                                        'termina seccion de cerrar conexiones
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                    ''MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    'Dim st As New StackTrace(True)
                                    'st = New StackTrace(ex, True)
                                    'frame = Me.Name
                                    'descripcion = "Falla de cierre de ciclo"
                                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                    'comandoMasterServidor.ExecuteNonQuery()
                                    conexionMasterServidor.Close()
                                    Try
                                        transaccion.Rollback()
                                        transaccionMasterServidor.Rollback()
                                    Catch ex2 As Exception
                                        MessageBox.Show("Error de listas")
                                        'MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        'Dim st2 As New StackTrace(True)
                                        'st2 = New StackTrace(ex, True)
                                        'frame = Me.Name
                                        'descripcion = "Falla de cierre de ciclo"
                                        'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                                        'contFalla = comandoMasterServidor.ExecuteScalar + 1
                                        'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st2.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                                        'comandoMasterServidor.ExecuteNonQuery()
                                        conexionMasterServidor.Close()
                                    End Try
                                End Try
                            End If
                            conexionsql2.Close()
                        End If
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    MessageBox.Show("NO SE PUDO ACCEDER CERRAR EL CICLO", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de cierre de ciclo"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("NO SE PUDO ACCEDER A LA BASE DE DATOS MASTEREA", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de cierre de ciclo"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                comandoMasterServidor.ExecuteNonQuery()
                Conexion.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR SQL", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de cierre de ciclo"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
        'Try
        '    conexionMasterServidor.Open()
        '    Conexion.Open()

        '    Dim n As Integer
        '    comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        '    n = comandoGeneral.ExecuteScalar
        '    If n = 0 Then
        '        MessageBox.Show("No hay ningún ciclo registrado", "Error de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        '        lectorGeneral = comandoGeneral.ExecuteReader
        '        lectorGeneral.Read()

        '        If lectorGeneral(0) = "Cerrado" Then
        '            lectorGeneral.Close()
        '            Conexion.Close()
        '            MessageBox.Show("ERROR, CICLO CERRADO", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Else
        '            lectorGeneral.Close()
        '            Dim idCiclo As Integer
        '            Dim anioC As String

        '            comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        '            lectorGeneral = comandoGeneral.ExecuteReader
        '            lectorGeneral.Read()

        '            idCiclo = lectorGeneral(0)
        '            anioC = lectorGeneral(1)

        '            Name = CStr(idCiclo) + CStr("-") + CStr(anioC)
        '            lectorGeneral.Close()
        '            Dim conexionsql2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=True")
        '            'Dim conexionsql2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true; MultipleActiveResultSets=True")
        '            Dim comando2 As SqlCommand = conexionsql2.CreateCommand
        '            Dim comando3 As SqlCommand = conexionsql2.CreateCommand
        '            Dim lector2 As SqlDataReader
        '            Dim lector3 As SqlDataReader

        '            conexionsql2.Open()
        '            Dim contGrupos As Integer
        '            comando2.CommandText = "Select count(idGrupo) From grupo"
        '            contGrupos = comando2.ExecuteScalar

        '            Dim contListas As Integer
        '            For i = 1 To contGrupos
        '                comando2.CommandText = "Select count(*)from INFORMATION_SCHEMA.TABLES Where TABLE_NAME = 'lista" & i & "';"
        '                contListas = contListas + comando2.ExecuteScalar()
        '            Next

        '            If contListas = 0 Then
        '                MessageBox.Show("Error. No hay ninguna lista creada", "Error de listas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Else
        '                transaccion = Conexion.BeginTransaction("TransaccionCerrarCiclo")
        '                comandoGeneral.Connection = Conexion
        '                comandoGeneral.Transaction = transaccion

        '                transaccionMasterServidor = conexionMasterServidor.BeginTransaction("TransaccionCicloAuxiliar")
        '                comandoMasterServidor.Connection = conexionMasterServidor
        '                comandoMasterServidor.Transaction = transaccionMasterServidor
        '                Try
        '                    For i = 1 To contListas
        '                        comando2.CommandText = "Select nivel From grupo Where idGrupo=" & i & ""
        '                        lector2 = comando2.ExecuteReader
        '                        lector2.Read()
        '                        Dim nivel As Integer = lector2(0)
        '                        lector2.Close()
        '                        comando2.CommandText = "Select idAlumno From lista" & i & ""
        '                        lector2 = comando2.ExecuteReader

        '                        While lector2.Read
        '                            Dim sit As String = "EN ESPERA"
        '                            Dim sitFin As String = "FINALIZADO"
        '                            comando3.CommandText = "Select calificacion From lista" & i & " Where idAlumno=" & lector2(0) & ""
        '                            lector3 = comando3.ExecuteReader
        '                            lector3.Read()
        '                            Dim calif As Decimal = lector3(0)
        '                            lector3.Close()
        '                            Dim est As String = "Cerrado"
        '                            If calif >= 80 Then
        '                                If nivel = 12 Then
        '                                    comandoGeneral.CommandText = "Update kardex Set n" & nivel & "=" & calif & " Where idAlumno=" & lector2(0) & ""
        '                                    comandoGeneral.ExecuteNonQuery()
        '                                    comandoGeneral.CommandText = "Update alumno Set situacion='" & sitFin & "', ultimoNivelAcreditado=" & nivel & " Where idAlumno=" & lector2(0) & ""
        '                                    comandoGeneral.ExecuteNonQuery()
        '                                    comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
        '                                    comandoGeneral.ExecuteNonQuery()
        '                                    comandoMasterServidor.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
        '                                    comandoMasterServidor.ExecuteNonQuery()
        '                                Else
        '                                    comandoGeneral.CommandText = "Update kardex Set n" & nivel & "=" & calif & " Where idAlumno=" & lector2(0) & ""
        '                                    comandoGeneral.ExecuteNonQuery()
        '                                    comandoGeneral.CommandText = "Update alumno Set situacion='" & sit & "', ultimoNivelAcreditado=" & nivel & " Where idAlumno=" & lector2(0) & ""
        '                                    comandoGeneral.ExecuteNonQuery()
        '                                    comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
        '                                    comandoGeneral.ExecuteNonQuery()
        '                                    comandoMasterServidor.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
        '                                    comandoMasterServidor.ExecuteNonQuery()
        '                                End If
        '                            Else
        '                                comandoGeneral.CommandText = "Update alumno Set situacion='" & sit & "' Where idAlumno=" & lector2(0) & ""
        '                                comandoGeneral.ExecuteNonQuery()
        '                                comandoGeneral.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
        '                                comandoGeneral.ExecuteNonQuery()
        '                                comandoMasterServidor.CommandText = "Update ciclo Set estado='" & est & "' Where idCiclo=" & idCiclo & ""
        '                                comandoMasterServidor.ExecuteNonQuery()
        '                            End If
        '                        End While
        '                        lector2.Close()
        '                    Next
        '                    If MessageBox.Show("¿Desea cerrar el ciclo?", "Cerrar ciclo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '                        transaccion.Commit()
        '                        transaccionMasterServidor.Commit()
        '                        MessageBox.Show("El ciclo fue cerrado exitosamente", "Cerrar ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                    Else
        '                        transaccion.Rollback()
        '                        transaccionMasterServidor.Rollback()
        '                        MessageBox.Show("El cerrado del ciclo fue cancelado", "Cancelación de cerrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    End If
        '                Catch ex As Exception
        '                    MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
        '                    'MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    Dim st As New StackTrace(True)
        '                    st = New StackTrace(ex, True)
        '                    frame = Me.Name
        '                    descripcion = "Falla de cierre de ciclo"
        '                    comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
        '                    contFalla = comandoMasterServidor.ExecuteScalar + 1
        '                    comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
        '                    comandoMasterServidor.ExecuteNonQuery()
        '                    conexionMasterServidor.Close()
        '                    Try
        '                        transaccion.Rollback()
        '                        transaccionMasterServidor.Rollback()
        '                    Catch ex2 As Exception
        '                        MessageBox.Show("Error de listas")
        '                        MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                        Dim st2 As New StackTrace(True)
        '                        st2 = New StackTrace(ex, True)
        '                        frame = Me.Name
        '                        descripcion = "Falla de cierre de ciclo"
        '                        comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
        '                        contFalla = comandoMasterServidor.ExecuteScalar + 1
        '                        comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st2.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
        '                        comandoMasterServidor.ExecuteNonQuery()
        '                        conexionMasterServidor.Close()
        '                    End Try
        '                End Try
        '            End If
        '            conexionsql2.Close()
        '        End If
        '    End If
        '    Conexion.Close()
        'Catch ex As Exception

        '    MessageBox.Show("No existe la base de datos MasterEA. Tiene que restaurarla primero", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Dim st As New StackTrace(True)
        '    st = New StackTrace(ex, True)
        '    frame = Me.Name
        '    descripcion = "Falla de cierre de ciclo"
        '    comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
        '    contFalla = comandoMasterServidor.ExecuteScalar + 1
        '    comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
        '    comandoMasterServidor.ExecuteNonQuery()
        '    conexionMasterServidor.Close()
        'End Try
    End Sub

    Private Sub RegistroToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem3.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    frmRegistroUsuarios.ShowDialog()
                Else
                    conexionMasterServidor.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE LOCALIZAR LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de usuarios"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'CIERRE DE CONEXIONES
                conexionMasterServidor.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de usuarios"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'CIERRE DE CONEXIONES
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub KardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
                    comandoGeneral.CommandText = "Select count(idAlumno) from Kardex"
                    Dim n As Integer = comandoGeneral.ExecuteScalar

                    If n = 0 Then
                        MessageBox.Show("NO HAY ALUMNOS REGISTRADOS", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        'TERMINA SECCION DE CONEXIONES
                    Else
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        'TERMINA SECCION DE CONEXIONES
                        frmKardexAlumno.ShowDialog()
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A KARDEX", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de registro de usuarios"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS MASTER EA (PRINCIPAL)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de usuarios"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                ''CIERRE DE CONEXIONES
                Conexion.Close()
                conexionMasterServidor.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de usuarios"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'CIERRE DE CONEXIONES
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeAlumnosInscritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAlumnosInscritosToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
                    comandoGeneral.CommandText = "Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
                    lectorGeneral = comandoGeneral.ExecuteReader
                    lectorGeneral.Read()
                    If lectorGeneral(0) = "Cerrado" Then
                        lectorGeneral.Close()
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        'TERMINA SECCION DE CONEXIONES
                        MessageBox.Show("No se puede mostrar el reporte porque el ciclo está cerrado y no hay alumnos inscritos", "Error de reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteAlumnosInscritos.rdlc"
                        frmReportes.ReportViewer1.RefreshReport()
                        frmReportes.ShowDialog()
                        'lectorGeneral.Close()

                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                        'TERMINA SECCION DE CONEXIONES
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR, NO SE PUEDO ACCEDER AL REPORTE DE ALUMNOS INSCRITOS", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de registro de usuarios"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS MASTER EA (PRINCIPAL)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de usuarios"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                ''CIERRE DE CONEXIONES
                Conexion.Close()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de usuarios"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'CIERRE DE CONEXIONES
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeMaestrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeMaestrosToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
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
                    'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteMaestros.rdlc"
                    frmReportes.ReportViewer1.RefreshReport()
                    frmReportes.ShowDialog()
                    Conexion.Close()
                Catch ex As Exception
                    MessageBox.Show("ERROR, NO SE PUEDO ACCEDER AL REPORTE DE MAESTROS", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim st As New StackTrace(True)
                    st = New StackTrace(ex, True)
                    frame = Me.Name
                    descripcion = "Falla de registro de usuarios"
                    comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    contFalla = comandoMasterServidor.ExecuteScalar + 1
                    comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    comandoMasterServidor.ExecuteNonQuery()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS MASTER EA (PRINCIPAL)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de usuarios"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'CIERRE DE CONEXIONES
                Conexion.Close()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de usuarios"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'CIERRE DE CONEXIONES
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeGruposPorCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeGruposPorCicloToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
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
                                'Using conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                                Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                                Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                                Dim lector2 As SqlDataReader
                                Dim lectorBDRemota As SqlDataReader

                                'SE ABRIO OTRA CONEXION
                                conexioBDRemota.Open()
                                'TERMINA SECCION DE CONEXIONES
                                comandoBDRemota.CommandText = "SELECT  G.idGrupo, M.nombre, M.correo, M.telefono, G.nivel, G.cantInscritos, G.maxAlumnos, 
		                    G.hLuIni, G.hLuFin, G.hMaIni, G.hMaFin, G.hMiIni, G.hMiFin, G.hJuIni, G.hJuFin, G.hViIni, G.hViFin, G.hSaIni, G.hSaFin  FROM MasterEA.dbo.maestro M LEFT JOIN  [" & nomBD & "].dbo.grupo G ON m.idMaestro = G.idMaestro where G.idGrupo <> 0"
                                lectorBDRemota = comandoBDRemota.ExecuteReader

                                While lectorBDRemota.Read
                                    comando2.CommandText = "Insert into MasterEA.dbo.auxHorario values('" & nomBD & "'," & lectorBDRemota(0) & ",'" & lectorBDRemota(1) & "','" & lectorBDRemota(2) & "','" & lectorBDRemota(3) & "', " & lectorBDRemota(4) & ", " & lectorBDRemota(5) & "," & lectorBDRemota(6) & ",'" & lectorBDRemota(7) & "','" & lectorBDRemota(8) & "','" & lectorBDRemota(9) & "','" & lectorBDRemota(10) & "','" & lectorBDRemota(11) & "','" & lectorBDRemota(12) & "','" & lectorBDRemota(13) & "','" & lectorBDRemota(14) & "','" & lectorBDRemota(15) & "','" & lectorBDRemota(16) & "','" & lectorBDRemota(17) & "','" & lectorBDRemota(18) & "')"
                                    comando2.ExecuteNonQuery()
                                End While
                                lectorBDRemota.Close()
                                'CIERRE DE CONEXION
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
                    'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteGruposGeneral.rdlc"
                    frmReportes.ReportViewer1.RefreshReport()
                    frmReportes.ShowDialog()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                Catch ex As Exception
                    MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A AL REPORTE", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de registro de usuarios"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS MASTER EA (PRINCIPAL)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de usuarios"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'CIERRE DE CONEXIONES
                Conexion.Close()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de usuarios"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'CIERRE DE CONEXIONES
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeGruposPorCicloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteDeGruposPorCicloToolStripMenuItem1.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
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
                                'CIERRE DE CONEXIONES
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
                            'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteGrupoCicloAbierto.rdlc"
                            frmReportes.ReportViewer1.RefreshReport()
                            frmReportes.ShowDialog()
                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()
                        Else
                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()

                            MessageBox.Show("ERROR, NO HAY CICLO ABIERTO PARA REALIZAR EL REPORTE", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR, NO SE PUEDO ACCEDER REPORTE)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de registro de usuarios"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS MASTER EA(PRINCIPAL)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de registro de usuarios"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'CIERRE DE CONEXIONES
                Conexion.Close()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCEDER A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de registro de usuarios"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            'CIERRE DE CONEXIONES
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeKardexPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeKardexPorAlumnoToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    frmReporteKardex.ShowDialog()
                Else
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                End If

            Catch ex As Exception
                lectorMasterServidor.Close()
                MessageBox.Show("NO SE PUDO HACER REFERENCIA A LA BASE DE DATOS PRINCIPAL", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de kardex"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO ACCEDER A LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de reporte de kardex"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeListasPorCicloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeListasPorCicloToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    frmReporteListas.ShowDialog()
                Else
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUDO HACER REFERENCIA A LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de listas"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            lectorMasterServidor.Close()
            MessageBox.Show("ERROR, NO SE PUDO ACCEDER A LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de reporte de listas"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeAlumnosPorSituaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAlumnosPorSituaciónToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    ReporteSituacion.ShowDialog()
                Else
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO HACER REFERENCIA A LA BASE DE  DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de alumnos por situación"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCESAR A LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de reporte de alumnos por situación"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDetalladoDeCalificacionesPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDetalladoDeCalificacionesPorAlumnoToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    kardexDetallado = True
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    frmReporteKardex.ShowDialog()
                Else
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO HACER REFERENCIA A LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de calificaciones por alumno"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                conexionMasterServidor.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO ACCESAR A LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de reporte de calificaciones por alumno"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDetalladoDeCalificacionesPorAlumnoPorNivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDetalladoDeCalificacionesPorAlumnoPorNivelToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    frmCalificacionesDet.ShowDialog()
                Else
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                End If
            Catch ex As Exception
                MessageBox.Show("NO SE PUEDO REFERENCIAL A LA BASE DE DATOS PRINCIPAL DEL SISTEMA", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de calificaciones de alumnos"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                conexionMasterServidor.Close()
            End Try

        Catch ex As Exception

            MessageBox.Show("NO SE PUEDO CONECTAR A LA BASE DE DATOSP PRINCIPAL DEL SISTEMA", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            frame = Me.Name
            descripcion = "Falla de reporte de calificaciones de alumnos"
            comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            contFalla = comandoMasterServidor.ExecuteScalar + 1
            comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ReporteDeCalificacionesFinalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCalificacionesFinalesToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                    frmReporteCalifFinales.ShowDialog()
                Else
                    'CIERRE DE CONEXIONES
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    'TERMINA SECCION DE CONEXIONES
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO HACER REFERENCIA A LA BASE DE DATOS DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de calificaciones finales"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO HACER CONEXION CON LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de reporte de calificaciones finales"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ConstanciaDeNivelActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstanciaDeNivelActualToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Conexion.Open()
                Try
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
                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()
                            'TERMINA LA SECCION DE CONEXIONES
                            frmReporteCalifFinales.ShowDialog()
                        Else
                            constancia = False
                            MessageBox.Show("ERROR. No hay ningún ciclo abierto", "Error de constancia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            lectorGeneral.Close()
                            'CIERRE DE CONEXIONES
                            Conexion.Close()
                            conexionMasterServidor.Close()
                        End If
                    Else
                        constancia = False
                        MessageBox.Show("ERROR. No hay ningún ciclo registrado", "Error de constancia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'CIERRE DE CONEXIONES
                        Conexion.Close()
                        conexionMasterServidor.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR, NO SE PUDO REALIZAR LA CONSULTA", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de reporte de calificaciones finales"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    'CIERRE DE CONEXIONES
                    Conexion.Close()
                    conexionMasterServidor.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("ERROR, NO SE PUEDO HACER CONEXION CON LA BASE DE DATOS MASTER EA(PRINCIPAL)", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex, True)
                'frame = Me.Name
                'descripcion = "Falla de reporte de calificaciones finales"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()
                'CIERRE DE CONEXIONES
                Conexion.Close()
                conexionMasterServidor.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("ERROR, NO SE PUEDO HACER CONEXION CON LA BASE DE DATOS PRINCIPAL DEL SERVIDOR", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de reporte de calificaciones finales"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub ConstanciaDeCalificacionesActualesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        constanciaNivAct = True
        frmReporteCalifFinales.ShowDialog()
    End Sub

    Private Sub RespaldarBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarBaseDeDatosToolStripMenuItem.Click
        frmRespaldarBD.ShowDialog()
    End Sub

    Private Sub RestaurarBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarBDToolStripMenuItem.Click
        frmRestaurarBD.ShowDialog()
    End Sub

    Private Sub BitácoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitácoraToolStripMenuItem.Click
        frmBitacora.ShowDialog()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        'System.Diagnostics.Process.Start("C:\Users\Diego\Documents\GitHub\adminAssistantPro\Help.chm")
        System.Diagnostics.Process.Start("C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\Ayuda.chm")
    End Sub

    Private Sub principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            'System.Diagnostics.Process.Start("C:\Users\Diego\Documents\GitHub\adminAssistantPro\Help.chm")
            System.Diagnostics.Process.Start("C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\Ayuda.chm")
        End If
    End Sub
End Class