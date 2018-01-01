Public Class frmConsultaIndividual
    Private Sub frmConsultaIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        comando.CommandText = "Select nombre from alumno WHERE nombre LIKE '%" & txtNombre.Text & "%'"
        lector = comando.ExecuteReader
        cboNombre.Items.Clear()
        While lector.Read
            cboNombre.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        Dim foto As String

        comando.CommandText = "Select alumno.idAlumno, alumno.situacion, alumno.domicilio, alumno.ciudad, alumno.telefono, alumno.telefonoEmergencia, alumno.ultimoNivelAcreditado, alumno.fechaDeNacimiento, alumno.correo, kardex.n1, kardex.n2, kardex.n3, kardex.n4, kardex.n5, kardex.n6, kardex.n7, kardex.n8, kardex.n9, kardex.n10, kardex.n11, kardex.n12, alumno.foto from alumno inner join kardex on alumno.idAlumno = kardex.idAlumno where alumno.nombre = '" & cboNombre.Text & "'"
        lector = comando.ExecuteReader
        While lector.Read
            txtIDAlumno.Text = lector(0)
            txtSituacion.Text = lector(1)
            txtDomicilio.Text = lector(2)
            txtCiudad.Text = lector(3)
            txtTel.Text = lector(4)
            txtTelEme.Text = lector(5)
            txtNivel.Text = lector(6)
            txtFecha.Text = lector(7)
            txtCorreo.Text = lector(8)

            MsgBox(lector(9))

            txtNivel1.Text = lector(9)
            txtNivel2.Text = lector(10)
            txtNivel3.Text = lector(11)
            txtNivel4.Text = lector(12)
            txtNivel5.Text = lector(13)
            txtNivel6.Text = lector(14)
            txtNivel7.Text = lector(15)
            txtNivel8.Text = lector(16)
            txtNivel9.Text = lector(17)
            txtNivel10.Text = lector(18)
            txtNivel11.Text = lector(19)
            txtNivel12.Text = lector(20)
            foto = lector(21)
            PictureBox1.Image = Image.FromFile(foto)

        End While
        lector.Close()

        conexionsql.Close()
    End Sub
End Class