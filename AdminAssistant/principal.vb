Public Class principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub RegistroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem1.Click
        frmRegistroMaestro.ShowDialog()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        frmRegistroAlumno.ShowDialog()
    End Sub
End Class