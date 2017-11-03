Public Class frmRestaurarBD
    Private Sub frmRestaurarBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        cboNomBDCiclos.Items.Clear()
        comandoGeneral.CommandText = "SELECT idCiclo, anio FROM ciclo"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNomBDCiclos.Items.Add(CStr(lectorGeneral(0)) + "-" + CStr(lectorGeneral(1)))
        End While
        lectorGeneral.Close()
        Conexion.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Conexion.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rutaRespaldo As String
        Conexion.Open()
        If RadioButton1.Checked Then
            Try
                OpenFileDialog1.DefaultExt = "bak"
                OpenFileDialog1.ShowDialog()
                rutaRespaldo = OpenFileDialog1.FileName
                comandoGeneral.CommandText = "RESTORE DATABASE MasterEA FROM DISK='" & rutaRespaldo & "' WITH REPLACE"
                comandoGeneral.ExecuteNonQuery()
                MessageBox.Show("¡Restauración de base de datos realizada exitosamente!", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("La base de datos no se restauró", "Error de restauración", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf RadioButton2.Checked Then
            Dim nomBD As String = CStr(cboNomBDCiclos.Text)
            Try
                OpenFileDialog1.DefaultExt = "bak"
                OpenFileDialog1.ShowDialog()
                rutaRespaldo = OpenFileDialog1.FileName
                comandoGeneral.CommandText = "RESTORE DATABASE [" & nomBD & "] FROM DISK='" & rutaRespaldo & "' WITH REPLACE"
                comandoGeneral.ExecuteNonQuery()
                MessageBox.Show("¡Restauración de base de datos realizada exitosamente!", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("La base de datos no se restauró", "Error de restauración", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        cboNomBDCiclos.Visible = False
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        cboNomBDCiclos.Visible = True
    End Sub
End Class