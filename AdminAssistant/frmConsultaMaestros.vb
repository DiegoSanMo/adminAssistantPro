Public Class frmConsultaMaestros
    Private Sub frmConsultaMaestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSetMani.maestro' Puede moverla o quitarla según sea necesario.
        Me.MaestroTableAdapter.Fill(Me.EasyEnglishDataSetMani.maestro)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class