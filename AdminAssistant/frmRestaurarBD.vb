Public Class frmRestaurarBD
    Private Sub frmRestaurarBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionMasterServidor.Open()
            cboNomBDCiclos.Items.Clear()
            comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
            lectorMasterServidor = comandoMasterServidor.ExecuteReader
            lectorMasterServidor.Read()

            If lectorMasterServidor(0) = Nothing Then
                lectorMasterServidor.Close()
                'RadioButton2.Visible = False
                conexionMasterServidor.Close()
            ElseIf lectorMasterServidor(0) = "MasterEA" Then
                lectorMasterServidor.Close()
                Conexion.Open()
                comandoGeneral.CommandText = "SELECT idCiclo, anio FROM ciclo"
                lectorGeneral = comandoGeneral.ExecuteReader
                While lectorGeneral.Read
                    cboNomBDCiclos.Items.Add(CStr(lectorGeneral(0)) + "-" + CStr(lectorGeneral(1)))
                End While
                lectorGeneral.Close()
                Conexion.Close()
                conexionMasterServidor.Close()
            End If
        Catch ex As Exception
            'conexionMasterServidor.Open()
            'MessageBox.Show("La base de datos MasterEA no existe")
            lectorMasterServidor.Close()
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de restauración de BD"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
            lectorMasterServidor.Close()
            'RadioButton2.Visible = False

            cboNomBDCiclos.Items.Clear()
            comandoMasterServidor.CommandText = "SELECT idCiclo, anio FROM ciclo"
            lectorMasterServidor = comandoMasterServidor.ExecuteReader
            While lectorMasterServidor.Read
                cboNomBDCiclos.Items.Add(CStr(lectorMasterServidor(0)) + "-" + CStr(lectorMasterServidor(1)))
            End While
            lectorMasterServidor.Close()

            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Conexion.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rutaRespaldo As String
        conexionMasterServidor.Open()
        Try
            If RadioButton1.Checked Then
                Try
                    OpenFileDialog1.DefaultExt = "bak"
                    OpenFileDialog1.ShowDialog()
                    rutaRespaldo = OpenFileDialog1.FileName
                    comandoMasterServidor.CommandText = "RESTORE DATABASE MasterEA FROM DISK='" & rutaRespaldo & "' WITH REPLACE"
                    comandoMasterServidor.ExecuteNonQuery()
                    MessageBox.Show("¡Restauración de base de datos realizada exitosamente!", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conexionMasterServidor.Close()
                Catch ex As Exception
                    MessageBox.Show("La base de datos no se restauró", "Error de restauración", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de restauración de BD"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    conexionMasterServidor.Close()
                End Try
            ElseIf RadioButton2.Checked Then
                Dim nomBD As String = CStr(cboNomBDCiclos.Text)
                Try
                    OpenFileDialog1.DefaultExt = "bak"
                    OpenFileDialog1.ShowDialog()
                    rutaRespaldo = OpenFileDialog1.FileName
                    comandoMasterServidor.CommandText = "RESTORE DATABASE [" & nomBD & "] FROM DISK='" & rutaRespaldo & "' WITH REPLACE"
                    comandoMasterServidor.ExecuteNonQuery()
                    MessageBox.Show("¡Restauración de base de datos realizada exitosamente!", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conexionMasterServidor.Close()
                Catch ex As Exception
                    MessageBox.Show("La base de datos no se restauró", "Error de restauración", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Dim st As New StackTrace(True)
                    'st = New StackTrace(ex, True)
                    'frame = Me.Name
                    'descripcion = "Falla de restauración de BD"
                    'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
                    'contFalla = comandoMasterServidor.ExecuteScalar + 1
                    'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
                    'comandoMasterServidor.ExecuteNonQuery()
                    conexionMasterServidor.Close()
                End Try
            End If
        Catch ex As Exception
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'frame = Me.Name
            'descripcion = "Falla de restauración de BD"
            'comandoMasterServidor.CommandText = "SELECT COUNT(noFalla) FROM bitacora"
            'contFalla = comandoMasterServidor.ExecuteScalar + 1
            'comandoMasterServidor.CommandText = "INSERT INTO bitacora values(" & contFalla & ",'" & ex.Message & "','" & descripcion & "','" & frame & "','" & st.GetFrame(5).GetFileLineNumber.ToString & "','" & Now.Date & "','" & Now.TimeOfDay.ToString & "')"
            'comandoMasterServidor.ExecuteNonQuery()
            conexionMasterServidor.Close()
        End Try
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        cboNomBDCiclos.Visible = False
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        cboNomBDCiclos.Visible = True
    End Sub
End Class