Public Class frmConsultaCiclo
    Private Sub frmConsultaCiclo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSetMani.ciclo' Puede moverla o quitarla según sea necesario.
        Me.CicloTableAdapter.Fill(Me.EasyEnglishDataSetMani.ciclo)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class