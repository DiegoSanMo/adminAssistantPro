Imports System.Data.SqlClient
Public Class frmRespaldarBD
    Private Sub frmRespaldarBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rutaGuardar As String
        Conexion.Open()

        If rbtMasterEA.Checked Then
            Try
                comandoGeneral.CommandText = "BACKUP DATABASE MasterEA TO DISK='C:\Backups SQL\MasterEA.bak' WITH FORMAT"
                comandoGeneral.ExecuteNonQuery()
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
            End Try
        ElseIf rbtBDCiclo.Checked Then
            Dim nombBD As String = CStr(cboNomBDCiclos.Text)
            Try
                comandoGeneral.CommandText = "BACKUP DATABASE [" & nombBD & "] TO DISK='C:\Backups SQL\" & nombBD & ".bak' WITH FORMAT"
                comandoGeneral.ExecuteNonQuery()
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
            End Try
        End If
        Conexion.Close()
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