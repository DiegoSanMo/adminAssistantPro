Public Class frmLogin

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNada.Select()
        conexionMasterServidor.Open()
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
                comandoMasterServidor.CommandText = "Select tipo from usuarios where nombre = '" & txtUsuario.Text & "' and contrasenia = '" & txtContraseña.Text & "'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader

                If lectorMasterServidor.Read() = False Then
                    lectorMasterServidor.Close()
                    MessageBox.Show("Error, usuario no registrado", "Usuario no registrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    tipoAcceso = lectorMasterServidor(0)
                    'MsgBox(tipoAcceso)
                    If tipoAcceso = "DIRECTOR" Then
                        lectorMasterServidor.Close()
                        conexionMasterServidor.Close()
                        txtContraseña.Text = ""
                        txtUsuario.Text = ""

                        principal.ShowDialog()

                        Me.Close()
                    Else
                        If tipoAcceso = "MAESTRO" Then
                            txtContraseña.Text = ""
                            txtUsuario.Text = ""
                            lectorMasterServidor.Close()
                            conexionMasterServidor.Close()

                            principal.RegistroToolStripMenuItem.Enabled = False
                            principal.RegistroToolStripMenuItem1.Enabled = False
                            principal.RegistroToolStripMenuItem3.Enabled = False

                            principal.AbrirCicloToolStripMenuItem.Enabled = False
                            principal.AbrirGrupoToolStripMenuItem.Enabled = False
                            principal.InscipciónToolStripMenuItem.Enabled = False
                            principal.ClasificarListasToolStripMenuItem.Enabled = False
                            principal.CerrarCicloToolStripMenuItem.Enabled = False
                            principal.ReportesToolStripMenuItem.Enabled = False

                            principal.ShowDialog()
                            Me.Close()
                        Else
                            If tipoAcceso = "SECRETARIA" Then
                                txtContraseña.Text = ""
                                txtUsuario.Text = ""
                                lectorMasterServidor.Close()
                                conexionMasterServidor.Close()

                                principal.RegistroToolStripMenuItem.Enabled = False
                                principal.RegistroToolStripMenuItem1.Enabled = False
                                principal.RegistroToolStripMenuItem3.Enabled = False

                                principal.MovimientosToolStripMenuItem.Enabled = False

                                principal.ShowDialog()
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class