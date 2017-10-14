Public Class frmKardexAlumno
    Private Sub frmKardexAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()

        comandoGeneral.CommandText = "Select idAlumno from kardex"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboIdAlumno.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()

        cboNombre.Items.Clear()
        comandoGeneral.CommandText = "Select nombre from alumno where  nombre like '%" & cboNombre.Text & "%' "
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNombre.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub rbId_CheckedChanged(sender As Object, e As EventArgs) Handles rbId.CheckedChanged
        cboIdAlumno.Visible = True
        txtNombreId.Visible = True
        txtSituaciónID.Visible = True
        lblSituacionID.Visible = True
        lblNombreID.Visible = True

        cboNombre.Visible = False
        lblIDAlumnoN.Visible = False
        txtIDAlumno.Visible = False

        lblSit.Visible = False
        txtSitN.Visible = False

        txtNivel1.Text = ""
        txtNivel2.Text = ""
        txtNivel3.Text = ""
        txtNivel4.Text = ""
        txtNivel5.Text = ""
        txtNivel6.Text = ""
        txtNivel7.Text = ""
        txtNivel8.Text = ""
        txtNivel9.Text = ""
        txtNivel10.Text = ""
        txtNivel11.Text = ""
        txtNivel12.Text = ""
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        cboIdAlumno.Visible = False
        txtNombreId.Visible = False
        lblNombreID.Visible = False
        lblSituacionID.Visible = False
        txtSituaciónID.Visible = False

        cboNombre.Visible = True
        lblIDAlumnoN.Visible = True
        txtIDAlumno.Visible = True

        lblSit.Visible = True
        txtSitN.Visible = True

        txtNivel1.Text = ""
        txtNivel2.Text = ""
        txtNivel3.Text = ""
        txtNivel4.Text = ""
        txtNivel5.Text = ""
        txtNivel6.Text = ""
        txtNivel7.Text = ""
        txtNivel8.Text = ""
        txtNivel9.Text = ""
        txtNivel10.Text = ""
        txtNivel11.Text = ""
        txtNivel12.Text = ""
    End Sub

    Private Sub cboIdAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdAlumno.SelectedIndexChanged
        comandoGeneral.CommandText = "Select nombre, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, situacion from alumno inner join kardex on alumno.idAlumno = kardex.idAlumno where kardex.idAlumno = " & CInt(cboIdAlumno.Text) & ""
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
            txtSituaciónID.Text = lectorGeneral(13)
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        comandoGeneral.CommandText = "Select alumno.idAlumno, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, situacion from alumno inner join kardex on alumno.idAlumno = kardex.idAlumno where alumno.nombre = '" & cboNombre.Text & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            txtIDAlumno.Text = lectorGeneral(0)
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
            txtSitN.Text = lectorGeneral(13)
        End While
        lectorGeneral.Close()
    End Sub
End Class