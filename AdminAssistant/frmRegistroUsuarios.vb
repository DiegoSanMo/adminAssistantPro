Public Class frmRegistroUsuarios
    Private Sub frmRegistroUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionMasterServidor.Open()
        txtIdUsuario.Text = ""
        txtNombre.Text = ""
        comandoMasterServidor.CommandText = "Select count(idUsuario) from usuarios"
        Dim n As Integer = comandoMasterServidor.ExecuteScalar
        If n > 0 Then
            comandoMasterServidor.CommandText = "Select idUsuario, nombre, tipo from usuarios"
            lectorMasterServidor = comandoMasterServidor.ExecuteReader
            dgUsuarios.Rows.Clear()

            While lectorMasterServidor.Read
                dgUsuarios.Rows.Add(lectorMasterServidor(0), lectorMasterServidor(1), lectorMasterServidor(2))
            End While
            lectorMasterServidor.Close()
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
        comandoMasterServidor.CommandText = "Select count(idUsuario) from usuarios"
        Dim n As Integer = comandoMasterServidor.ExecuteScalar + 1

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

        comandoMasterServidor.CommandText = "Insert into usuarios values(" & CInt(txtIdUsuario.Text) & ", '" & txtNombre.Text & "', '" & txtContrasenia.Text & "', '" & cboTipo.Text & "')"
        comandoMasterServidor.ExecuteNonQuery()

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
        conexionMasterServidor.Close()
        Me.Dispose()
    End Sub
End Class