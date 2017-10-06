Public Class frmKardexAlumno
    Private Sub frmKardexAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()

        comandoGeneral.CommandText = "Select idAlumno from kardex"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboIdAlumno.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub rbId_CheckedChanged(sender As Object, e As EventArgs) Handles rbId.CheckedChanged
        cboIdAlumno.Visible = True
        txtNombreId.Visible = True
        lblNombreID.Visible = True
        txtNombre.Visible = False


    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        cboIdAlumno.Visible = False
        txtNombreId.Visible = False
        lblNombreID.Visible = False

        txtNombre.Visible = True
    End Sub

    Private Sub cboIdAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdAlumno.SelectedIndexChanged
        comandoGeneral.CommandText = "Select nombre, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 from alumno inner join kardex on alumno.idAlumno = kardex.idAlumno where kardex.idAlumno = " & CInt(cboIdAlumno.Text) & ""
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            txtNombreId.Text = lectorGeneral(0)
            txtNivel1.Text = lectorGeneral(1)
            txtNivel2.Text = lectorGeneral(2)
            txtNivel3.Text = lectorGeneral(3)
            txtNivel4.Text = lectorGeneral(4)
            txtNivel5.Text = lectorGeneral(5)
            txtNivel6.Text = lectorGeneral(6)
            txtNivel7.Text = lectorGeneral(7)
            txtNivel8.Text = lectorGeneral(8)
            txtNivel9.Text = lectorGeneral(9)
            txtNivel10.Text = lectorGeneral(10)
            txtNivel11.Text = lectorGeneral(11)
            txtNivel12.Text = lectorGeneral(12)
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class