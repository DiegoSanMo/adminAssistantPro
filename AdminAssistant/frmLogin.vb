Public Class frmLogin

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNada.Select()
        Conexion.Open()
        txtContraseña.UseSystemPasswordChar = True
        tipoAcceso = ""

    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click
        txtUsuario.Text = ""
    End Sub

    Private Sub txtContraseña_Click(sender As Object, e As EventArgs) Handles txtContraseña.Click
        txtContraseña.Text = ""
        txtContraseña.UseSystemPasswordChar = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If IsNothing(txtUsuario.Text) Then
            MessageBox.Show("Error, no se ha ingresado nombre de usuario", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Focus()

        Else

            If IsNothing(txtContraseña.Text) Then
                MessageBox.Show("Error, no se ha ingresado contraseña", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContraseña.Focus()

            Else
                comandoGeneral.CommandText = "Select tipo from usuarios where nombre = '" & txtUsuario.Text & "' and contrasenia = '" & txtContraseña.Text & "'"
                lectorGeneral = comandoGeneral.ExecuteReader
                lectorGeneral.Read()
                tipoAcceso = lectorGeneral(0)
                If IsNothing(tipoAcceso) Then
                    lectorGeneral.Close()
                    MessageBox.Show("Error, usuario no registrado", "Usuario no registrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If tipoAcceso = "ADMINISTRADOR" Then

                        MsgBox("sdfsdf")
                        lectorGeneral.Close()
                        Conexion.Close()

                        txtContraseña.Text = ""
                        txtUsuario.Text = ""


                        principal.MovimientosToolStripMenuItem.Enabled = False

                        principal.ShowDialog()

                        Me.Dispose()
                        'If tipoAcceso = "USUARIO" Then


                        'End If
                    End If


                End If
            End If

        End If

    End Sub
End Class