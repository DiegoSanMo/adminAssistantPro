Public Class frmConsultaAlumnos
    Private Sub frmConsultaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSetMani.alumno' Puede moverla o quitarla según sea necesario.
        Me.AlumnoTableAdapter.Fill(Me.EasyEnglishDataSetMani.alumno)
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSet.alumno' Puede moverla o quitarla según sea necesario.
        'Me.AlumnoTableAdapter.Fill(Me.EasyEnglishDataSet.alumno)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class