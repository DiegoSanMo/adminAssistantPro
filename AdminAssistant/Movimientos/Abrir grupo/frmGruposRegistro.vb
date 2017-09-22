Imports System.Data.SqlClient
Public Class frmGruposRegistro
    Private Sub frmGruposRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Conexion general
        Conexion.Open()
        comandoGeneral.CommandText = "Select nombre from maestro"
        lectorGeneral = comandoGeneral.ExecuteReader

        While lectorGeneral.Read
            cboMaestros.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()


        Dim idCiclo As Integer
        Dim anioC As String

        comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()

        idCiclo = lectorGeneral(0)
        anioC = lectorGeneral(1)
        lectorGeneral.Close()
        'asigna el nombre de la base de datos
        Name = CStr(idCiclo) + CStr("-") + CStr(anioC)


        comandoGeneral.CommandText = "select idGrupo, nombre, nivel, cantAlumnos, hLu, hMa, hMi, hJu, hVi, hSa from [" & Name & "].dbo.grupo c join MasterEA.dbo.maestro m on c.idMaestro = m.idMaestro"
        lectorGeneral = comandoGeneral.ExecuteReader
        dgHorario.Rows.Clear()

        While lectorGeneral.Read
            dgHorario.Rows.Add(lectorGeneral(0), lectorGeneral(1), lectorGeneral(2), lectorGeneral(3), lectorGeneral(4), lectorGeneral(5), lectorGeneral(6), lectorGeneral(7), lectorGeneral(8), lectorGeneral(9))
        End While
        lectorGeneral.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        btnNuevo.Enabled = False
        btnSalir.Enabled = False

        cboMaestros.Enabled = True


        txtMaxAlumnos.Enabled = True
        cboNivel.Enabled = True

        dtpLunesI.Enabled = True
        dtpLunesF.Enabled = True

        dtpMartesI.Enabled = True
        dtpMartesF.Enabled = True

        dtpMiercolesI.Enabled = True
        dtpMiercolesF.Enabled = True

        dtpJuevesI.Enabled = True
        dtpJuevesF.Enabled = True

        dtpViernesI.Enabled = True
        dtpViernesF.Enabled = True

        dtpSabadoI.Enabled = True
        dtpSabadoF.Enabled = True





        Using conexionRemota As New SqlConnection("Data source = 'PRO'; Initial Catalog='" & Name & "'; integrated security = true")
            Dim comandoRemoto As SqlCommand = conexionRemota.CreateCommand
            Dim lectorRemoto As SqlDataReader

            conexionRemota.Open()


            comandoRemoto.CommandText = "SELECT DB_NAME() AS [Current Database]"
            lectorRemoto = comandoRemoto.ExecuteReader
            lectorRemoto.Read()

            MsgBox(lectorRemoto(0))
            lectorRemoto.Close()

            comandoRemoto.CommandText = "Select count(idGrupo) from grupo"
            Dim n As Integer = comandoRemoto.ExecuteScalar + 1
            txtClave.Text = n

            conexionRemota.Close()

        End Using


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If IsNumeric(txtIdMaestro.Text) Then

            If IsNumeric(txtMaxAlumnos.Text) Then

                If CInt(txtMaxAlumnos.Text) <= 12 Then

                    If cboNivel.SelectedItem = "" Then
                        MsgBox("No se ha seleccionado nivel, favor de ingresarlo")
                        cboNivel.Focus()
                        MsgBox(cboNivel.SelectedValue)
                    Else

                        Dim horarioL As String = dtpLunesI.Value.ToLongTimeString + CStr("/") + dtpLunesF.Value.ToLongTimeString
                        Dim horarioMa As String = dtpMartesI.Value.ToLongTimeString + CStr("/") + dtpMartesF.Value.ToLongTimeString
                        Dim horarioMi As String = dtpMiercolesI.Value.ToLongTimeString + CStr("/") + dtpMiercolesF.Value.ToLongTimeString
                        Dim horarioJu As String = dtpJuevesI.Value.ToLongTimeString + CStr("/") + dtpJuevesF.Value.ToLongTimeString
                        Dim horarioVi As String = dtpViernesI.Value.ToLongTimeString + CStr("/") + dtpViernesF.Value.ToLongTimeString
                        Dim horarioSa As String = dtpSabadoI.Value.ToLongTimeString + CStr("/") + dtpSabadoF.Value.ToLongTimeString

                        MsgBox(horarioL)
                        MsgBox(cboNivel.SelectedItem)

                        Using conexionRemota As New SqlConnection("Data source = 'PRO'; Initial Catalog='" & Name & "'; integrated security = true")
                            Dim comandoRemoto As SqlCommand = conexionRemota.CreateCommand

                            conexionRemota.Open()
                            Dim trans As SqlTransaction
                            trans = conexionRemota.BeginTransaction("InsertarGrupo")
                            comandoRemoto.Connection = conexionRemota
                            comandoRemoto.Transaction = trans

                            Try
                                comandoRemoto.CommandText = "Insert into grupo(idGrupo, idMaestro,  cantAlumnos, hLu, hMa, hMi, hJu, hVi, hSa, nivel) values(" & CInt(txtClave.Text) & ", " & CInt(txtIdMaestro.Text) & ", " & CInt(txtMaxAlumnos.Text) & ", '" & horarioL & "', '" & horarioMa & "', '" & horarioMi & "', '" & horarioJu & "', '" & horarioVi & "', '" & horarioSa & "', " & CInt(cboNivel.SelectedItem) & ")"
                                comandoRemoto.ExecuteNonQuery()
                                If MessageBox.Show("¿Desea registrar el nuevo horario?", "Registro de horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    trans.Commit()
                                    MessageBox.Show("Grupo registrado con éxito", "Registro de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    conexionRemota.Close()
                                Else
                                    transaccion.Rollback()
                                    MessageBox.Show("El registro de grupo ha sido cancelado", "Cancelación de grupo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            Catch ex As Exception
                                MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                                MsgBox(ex.Message)
                                Try
                                    transaccion.Rollback()
                                Catch ex2 As Exception
                                    MessageBox.Show("Error de grupo")
                                End Try
                            End Try




                            conexionRemota.Close()
                        End Using







                        'Control de comandos
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False

                        btnNuevo.Enabled = True
                        btnSalir.Enabled = True

                        cboMaestros.Enabled = False

                        txtMaxAlumnos.Enabled = False
                        cboNivel.Enabled = False

                        dtpLunesI.Enabled = False
                        dtpLunesF.Enabled = False

                        dtpMartesI.Enabled = False
                        dtpMartesF.Enabled = False

                        dtpMiercolesI.Enabled = False
                        dtpMiercolesF.Enabled = False

                        dtpJuevesI.Enabled = False
                        dtpJuevesF.Enabled = False

                        dtpViernesI.Enabled = False
                        dtpViernesF.Enabled = False

                        dtpSabadoI.Enabled = False
                        dtpSabadoF.Enabled = False

                    End If
                Else
                    MsgBox("La cantidad de alumnos no es permitida, ingresar un valor entre [1-12]")
                    txtMaxAlumnos.Focus()
                End If
            Else
                MsgBox("Tipo de dato no valido, valores permitidos del [1-12]")
                txtMaxAlumnos.Focus()
            End If

        Else
            MsgBox("No se ha asignado maestro, favor de ingresar maestro")
            cboMaestros.Focus()

        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        cboMaestros.Enabled = False

        dtpLunesI.Enabled = False
        dtpLunesF.Enabled = False

        dtpMartesI.Enabled = False
        dtpMartesF.Enabled = False

        dtpMiercolesI.Enabled = False
        dtpMiercolesF.Enabled = False

        dtpJuevesI.Enabled = False
        dtpJuevesF.Enabled = False

        dtpViernesI.Enabled = False
        dtpViernesF.Enabled = False

        dtpSabadoI.Enabled = False
        dtpSabadoF.Enabled = False



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()

        Me.Dispose()
    End Sub

    Private Sub cboMaestros_TextChanged(sender As Object, e As EventArgs) Handles cboMaestros.TextChanged

        comandoGeneral.CommandText = "Select nombre from maestro where nombre like  '%" & cboMaestros.Text & "%'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboMaestros.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()


    End Sub

    Private Sub cboMaestros_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMaestros.SelectedValueChanged

        comandoGeneral.CommandText = "Select idMaestro, correo, telefono from maestro where nombre = '" & cboMaestros.Text & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()
        txtIdMaestro.Text = lectorGeneral(0)
        txtCorreo.Text = lectorGeneral(1)
        txtTel.Text = lectorGeneral(2)
        lectorGeneral.Close()



    End Sub

    Private Sub cboMaestros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaestros.SelectedIndexChanged

    End Sub


End Class