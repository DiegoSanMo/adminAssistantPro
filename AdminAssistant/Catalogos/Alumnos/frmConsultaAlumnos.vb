Public Class frmConsultaAlumnos
    Private Sub frmConsultaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        comandoGeneral.CommandText = "Select idAlumno, nombre, domicilio, telefono, situacion, ultimoNivelAcreditado from alumno"
        lectorGeneral = comandoGeneral.ExecuteReader

        dgConsultaG.Rows.Clear()
        While lectorGeneral.Read
            dgConsultaG.Rows.Add(lectorGeneral(0), lectorGeneral(1), lectorGeneral(2), lectorGeneral(3), lectorGeneral(4), lectorGeneral(5))
        End While
        lectorGeneral.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()

        Me.Dispose()
    End Sub

End Class