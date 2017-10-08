Public Class frmRegistroUsuarios
    Private Sub frmRegistroUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        txtIdUsuario.Text = ""
        txtNombre.Text = ""
        comandoGeneral.CommandText = "Select count(idUsuario) from usuarios"
        Dim n As Integer = comandoGeneral.ExecuteScalar
        If n > 0 Then
            comandoGeneral.CommandText = "Select idUsuario, nombre, tipo from usuarios"
            lectorGeneral = comandoGeneral.ExecuteReader
            dgUsuarios.Rows.Clear()

            While lectorGeneral.Read
                dgUsuarios.Rows.Add(lectorGeneral(0), lectorGeneral(1), lectorGeneral(2))
            End While
            lectorGeneral.Close()
        End If
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        btnN.Enabled = False
        btnSalir.Enabled = False

        btnCancelar.Enabled = True
        btnAceptar.Enabled = True
        txtNombre.Enabled = True
        cboTipo.Enabled = True
        txtContrasenia.Enabled = True
        comandoGeneral.CommandText = "Select count(idUsuario) from usuarios"
        Dim n As Integer = comandoGeneral.ExecuteScalar + 1

        txtIdUsuario.Text = n
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        btnN.Enabled = True
        btnSalir.Enabled = True

        btnCancelar.Enabled = False
        btnAceptar.Enabled = False
        txtNombre.Enabled = False
        cboTipo.Enabled = False
        txtContrasenia.Enabled = False

        comandoGeneral.CommandText = "Insert into usuarios values(" & CInt(txtIdUsuario.Text) & ", '" & txtNombre.Text & "', '" & txtContrasenia.Text & "', '" & cboTipo.Text & "')"
        comandoGeneral.ExecuteNonQuery()

        dgUsuarios.Rows.Add(txtIdUsuario.Text, txtNombre.Text, cboTipo.Text)

        txtIdUsuario.Text = ""
        txtNombre.Text = ""
        txtContrasenia.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnN.Enabled = True
        btnSalir.Enabled = True

        btnCancelar.Enabled = False
        btnAceptar.Enabled = False
        txtNombre.Enabled = False
        cboTipo.Enabled = False
        txtContrasenia.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Dispose()
    End Sub
End Class