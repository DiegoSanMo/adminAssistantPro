Public Class Form1
    Private Sub lblCatalogos_MouseEnter(sender As Object, e As EventArgs) Handles lblCatalogos.MouseEnter
        Me.lblCatalogos.BackColor = ColorTranslator.FromHtml("#004F7A")
        lblCatalogos.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub lblCatalogos_MouseLeave(sender As Object, e As EventArgs) Handles lblCatalogos.MouseLeave
        Me.lblCatalogos.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        lblCatalogos.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub lblMovimientos_MouseEnter(sender As Object, e As EventArgs) Handles lblMovimientos.MouseEnter
        Me.lblMovimientos.BackColor = ColorTranslator.FromHtml("#C20114")
        lblMovimientos.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub lblMovimientos_MouseLeave(sender As Object, e As EventArgs) Handles lblMovimientos.MouseLeave
        Me.lblMovimientos.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        lblMovimientos.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub lblSalir_MouseEnter(sender As Object, e As EventArgs) Handles lblSalir.MouseEnter
        Me.lblSalir.BackColor = ColorTranslator.FromHtml("#004F7A")
        lblSalir.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub lblSalir_MouseLeave(sender As Object, e As EventArgs) Handles lblSalir.MouseLeave
        Me.lblSalir.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        lblSalir.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.Close()
    End Sub

    Private Sub lblCatalogos_Click(sender As Object, e As EventArgs) Handles lblCatalogos.Click
        frmRegistroAlumno.ShowDialog()
    End Sub
End Class
