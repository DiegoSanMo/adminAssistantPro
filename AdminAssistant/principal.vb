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

    Private Sub RegistroToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem2.Click
        frmRegistroCiclo.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmConsultaAlumnos.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        frmConsultaCiclo.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        frmConsultaMaestros.ShowDialog()
    End Sub
End Class