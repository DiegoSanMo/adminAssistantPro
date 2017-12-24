Imports System.Data.SqlClient
Public Class frmRespaldarBD
    Private Sub frmRespaldarBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionMasterServidor.Open()
            comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
            lectorMasterServidor = comandoMasterServidor.ExecuteReader
            lectorMasterServidor.Read()
            Try
                If lectorMasterServidor(0) = "MasterEA" Then
                    lectorMasterServidor.Close()
                    Conexion.Open()
                    cboNomBDCiclos.Items.Clear()
                    comandoGeneral.CommandText = "SELECT idCiclo, anio FROM ciclo"
                    lectorGeneral = comandoGeneral.ExecuteReader
                    While lectorGeneral.Read
                        cboNomBDCiclos.Items.Add(CStr(lectorGeneral(0)) + "-" + CStr(lectorGeneral(1)))
                    End While
                    lectorGeneral.Close()
                    Conexion.Close()
                Else
                    MessageBox.Show("La base de datos MasterEA no existe. Necesita restaurarla primero", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex2 As Exception
                rbtMasterEA.Visible = False
                MessageBox.Show("La base de datos MasterEA no existe. Si desea respaldarla, necesita restaurarla primero", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lectorMasterServidor.Close()
                'Dim st As New StackTrace(True)
                'st = New StackTrace(ex2, True)
                'frame = Me.Name
                'descripcion = "Falla de apertura de ciclo"
                'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                'contFalla = comandoMasterServidor.ExecuteScalar + 1
                'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex2.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                'comandoMasterServidor.ExecuteNonQuery()

                cboNomBDCiclos.Items.Clear()
                comandoMasterServidor.CommandText = "SELECT idCiclo, anio FROM ciclo"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                While lectorMasterServidor.Read
                    cboNomBDCiclos.Items.Add(CStr(lectorMasterServidor(0)) + "-" + CStr(lectorMasterServidor(1)))
                End While
                lectorMasterServidor.Close()

                conexionMasterServidor.Close()
            End Try
            conexionMasterServidor.Close()
        Catch ex As Exception
            'conexionMasterServidor.Close()
            'conexionMasterServidor.Open()
            lectorMasterServidor.Close()
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de respaldo de BD"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rutaGuardar As String
        Try
            conexionMasterServidor.Open()
            If rbtMasterEA.Checked Then
                Try
                    comandoMasterServidor.CommandText = "BACKUP DATABASE MasterEA TO DISK='C:\Backups SQL\MasterEA.bak' WITH FORMAT"
                    comandoMasterServidor.ExecuteNonQuery()
                    SaveFileDialog1.ShowDialog()
                    SaveFileDialog1.Title = "Escoja ruta para guardar el backup"
                    rutaGuardar = SaveFileDialog1.FileName
                    SaveFileDialog1.DefaultExt = ".bak"
                    SaveFileDialog1.FileName = "MasterEA"
                    My.Computer.FileSystem.MoveFile("C:\Backups SQL\MasterEA.bak", rutaGuardar)
                    MessageBox.Show("¡Respaldo de base de datos creado exitosamente!", "Respaldos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("El respaldo no se creó", "Error de respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    My.Computer.FileSystem.DeleteFile("C:\Backups SQL\MasterEA.bak")
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de respaldo de BD"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    conexionMasterServidor.Close()
                End Try
            ElseIf rbtBDCiclo.Checked Then
                Dim nombBD As String = CStr(cboNomBDCiclos.Text)
                Try
                    comandoMasterServidor.CommandText = "BACKUP DATABASE [" & nombBD & "] TO DISK='C:\Backups SQL\" & nombBD & ".bak' WITH FORMAT"
                    comandoMasterServidor.ExecuteNonQuery()
                    SaveFileDialog1.ShowDialog()
                    SaveFileDialog1.Title = "Escoja ruta para guardar el backup"
                    rutaGuardar = SaveFileDialog1.FileName
                    SaveFileDialog1.DefaultExt = ".bak"
                    SaveFileDialog1.FileName = nombBD
                    My.Computer.FileSystem.MoveFile("C:\Backups SQL\" & nombBD & ".bak", rutaGuardar)
                    MessageBox.Show("¡Respaldo de base de datos creado exitosamente!", "Respaldos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("El respaldo no se creó", "Error de respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    My.Computer.FileSystem.DeleteFile("C:\Backups SQL\" & nombBD & ".bak")
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de respaldo de BD"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    conexionMasterServidor.Close()
                End Try
            End If
            conexionMasterServidor.Close()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de respaldo de BD"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub rbtBDCiclo_Click(sender As Object, e As EventArgs) Handles rbtBDCiclo.Click
        cboNomBDCiclos.Visible = True
    End Sub

    Private Sub rbtMasterEA_Click(sender As Object, e As EventArgs) Handles rbtMasterEA.Click
        cboNomBDCiclos.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Conexion.Close()
    End Sub
End Class