Imports System.Data.SqlClient
Public Class frmGruposRegistro
    Private Sub frmGruposRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dgHorario.AutoGenerateColumns = True
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

        comandoGeneral.CommandText = "select idGrupo, nombre, nivel, maxAlumnos, hLuIni,  hLuFin, hMaIni, hMaFin, hMiIni, hMiFin, hJuIni, hJuFin, hViIni, hViFin, hSaIni, hSaFin from [" & Name & "].dbo.grupo c join MasterEA.dbo.maestro m on c.idMaestro = m.idMaestro"
        lectorGeneral = comandoGeneral.ExecuteReader
        dgHorario.Rows.Clear()
        While lectorGeneral.Read
            dgHorario.Rows.Add(lectorGeneral(0), lectorGeneral(1), lectorGeneral(2), lectorGeneral(3), lectorGeneral(4), lectorGeneral(5), lectorGeneral(6), lectorGeneral(7), lectorGeneral(8), lectorGeneral(9), lectorGeneral(10), lectorGeneral(11), lectorGeneral(12), lectorGeneral(13), lectorGeneral(14), lectorGeneral(15))
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
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

        dtpLunesI.Text = CDate("00:00")
        dtpLunesF.Text = CDate("00:00")

        dtpMartesI.Text = CDate("00:00")
        dtpMartesF.Text = CDate("00:00")

        dtpMiercolesI.Text = CDate("00:00")
        dtpMiercolesF.Text = CDate("00:00")

        dtpJuevesI.Text = CDate("00:00")
        dtpJuevesF.Text = CDate("00:00")

        dtpViernesI.Text = CDate("00:00")
        dtpViernesF.Text = CDate("00:00")

        dtpSabadoI.Text = CDate("00:00")
        dtpSabadoF.Text = CDate("00:00")

        Using conexionRemota As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; integrated security = true")
            'Using conexionRemota As New SqlConnection("Data source = 'PRO'; Initial Catalog='" & Name & "'; integrated security = true")
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

                If CInt(txtMaxAlumnos.Text) <= 14 Then

                    If cboNivel.SelectedItem = "" Then
                        MsgBox("No se ha seleccionado nivel, favor de ingresarlo")
                        cboNivel.Focus()
                        MsgBox(cboNivel.SelectedValue)
                    Else
                        Using conexionRemota As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; integrated security = true")
                            'Using conexionRemota As New SqlConnection("Data source = 'PRO'; Initial Catalog='" & Name & "'; integrated security = true")
                            Dim comandoRemoto As SqlCommand = conexionRemota.CreateCommand
                            Dim lectorRemoto As SqlDataReader

                            conexionRemota.Open()

                            Dim horarioL As String = CStr(dtpLunesI.Value.ToShortTimeString)
                            Dim horarioLF As String = CStr(dtpLunesF.Value.ToShortTimeString)
                            Dim horarioMa As String = CStr(dtpMartesI.Value.ToShortTimeString)
                            Dim horarioMaF As String = CStr(dtpMartesF.Value.ToShortTimeString)
                            Dim horarioMi As String = CStr(dtpMiercolesI.Value.ToShortTimeString)
                            Dim horarioMiF As String = CStr(dtpMiercolesF.Value.ToShortTimeString)
                            Dim horarioJu As String = CStr(dtpJuevesI.Value.ToShortTimeString)
                            Dim horarioJuF As String = CStr(dtpJuevesF.Value.ToShortTimeString)
                            Dim horarioVi As String = CStr(dtpViernesI.Value.ToShortTimeString)
                            Dim horarioViF As String = CStr(dtpViernesF.Value.ToShortTimeString)
                            Dim horarioSa As String = CStr(dtpSabadoI.Value.ToShortTimeString)
                            Dim horarioSaF As String = CStr(dtpSabadoF.Value.ToShortTimeString)

                            If horarioL = CDate("00:00") Then
                                horarioL = "-"
                            End If
                            If horarioLF = CDate("00:00") Then
                                horarioLF = "-"
                            End If
                            If horarioMa = CDate("00:00") Then
                                horarioMa = "-"
                            End If
                            If horarioMaF = CDate("00:00") Then
                                horarioMaF = "-"
                            End If
                            If horarioMi = CDate("00:00") Then
                                horarioMi = "-"
                            End If
                            If horarioMiF = CDate("00:00") Then
                                horarioMiF = "-"
                            End If
                            If horarioJu = CDate("00:00") Then
                                horarioJu = "-"
                            End If
                            If horarioJuF = CDate("00:00") Then
                                horarioJuF = "-"
                            End If
                            If horarioVi = CDate("00:00") Then
                                horarioVi = "-"
                            End If
                            If horarioViF = CDate("00:00") Then
                                horarioViF = "-"
                            End If
                            If horarioSa = CDate("00:00") Then
                                horarioSa = "-"
                            End If
                            If horarioSaF = CDate("00:00") Then
                                horarioSaF = "-"
                            End If

                            '               MsgBox(dgHorario.RowCount)

                            If dgHorario.RowCount = 0 Then
                                Try
                                    Dim trans As SqlTransaction
                                    trans = conexionRemota.BeginTransaction("InsertarGrupo")
                                    comandoRemoto.Connection = conexionRemota
                                    comandoRemoto.Transaction = trans

                                    comandoRemoto.CommandText = "Insert into grupo values(" & CInt(txtClave.Text) & ", " & CInt(txtIdMaestro.Text) & ", " & CInt(txtMaxAlumnos.Text) & ", " & 0 & ", " & CInt(cboNivel.SelectedItem) & ", '" & horarioL & "', '" & horarioLF & "', '" & horarioMa & "', '" & horarioMaF & "', '" & horarioMi & "', '" & horarioMiF & "', '" & horarioJu & "', '" & horarioJuF & "', '" & horarioVi & "', '" & horarioViF & "', '" & horarioSa & "', '" & horarioSaF & "')"
                                    comandoRemoto.ExecuteNonQuery()
                                    If MessageBox.Show("¿Desea registrar el nuevo horario?", "Registro de horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                        trans.Commit()
                                        For i = dgHorario.Rows.Count To dgHorario.Rows.Count
                                            dgHorario.Rows.Add(txtClave.Text, cboMaestros.Text, cboNivel.Text, txtMaxAlumnos.Text, horarioL, horarioLF, horarioMa, horarioMaF, horarioMi, horarioMiF, horarioJu, horarioJuF, horarioVi, horarioViF, horarioSa, horarioSaF)
                                        Next
                                        MessageBox.Show("Grupo registrado con éxito", "Registro de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        'Control de comandos
                                        btnGuardar.Enabled = False
                                        btnCancelar.Enabled = False

                                        btnNuevo.Enabled = True
                                        btnModificar.Enabled = True
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

                                        txtMaxAlumnos.Text = ""
                                        txtIdMaestro.Text = ""
                                        txtClave.Text = ""
                                        txtCorreo.Text = ""
                                        cboMaestros.Text = ""
                                        txtTel.Text = ""
                                        cboNivel.Enabled = False

                                        dtpLunesI.Text = CDate("00:00")
                                        dtpLunesF.Text = CDate("00:00")

                                        dtpMartesI.Text = CDate("00:00")
                                        dtpMartesF.Text = CDate("00:00")

                                        dtpMiercolesI.Text = CDate("00:00")
                                        dtpMiercolesF.Text = CDate("00:00")

                                        dtpJuevesI.Text = CDate("00:00")
                                        dtpJuevesF.Text = CDate("00:00")

                                        dtpViernesI.Text = CDate("00:00")
                                        dtpViernesF.Text = CDate("00:00")

                                        dtpSabadoI.Text = CDate("00:00")
                                        dtpSabadoF.Text = CDate("00:00")

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
                                        MsgBox(ex2.Message)
                                    End Try
                                End Try
                                conexionRemota.Close()
                            Else
                                Dim ban As Boolean = False

                                For x = 0 To dgHorario.RowCount - 1
                                    If dgHorario.Rows(x).Cells(4).Value = horarioL And dgHorario.Rows(x).Cells(5).Value = horarioLF And dgHorario.Rows(x).Cells(6).Value = horarioMa And dgHorario.Rows(x).Cells(7).Value = horarioMaF And dgHorario.Rows(x).Cells(8).Value = horarioMi And dgHorario.Rows(x).Cells(9).Value = horarioMiF And dgHorario.Rows(x).Cells(10).Value = horarioJu And dgHorario.Rows(x).Cells(11).Value = horarioJuF And dgHorario.Rows(x).Cells(12).Value = horarioVi And dgHorario.Rows(x).Cells(13).Value = horarioViF And dgHorario.Rows(x).Cells(14).Value = horarioSa And dgHorario.Rows(x).Cells(15).Value = horarioSaF Then
                                        ban = True
                                    End If
                                Next

                                If ban Then
                                    MsgBox("Horario ya ingresado, favor de ingresar otro horario")
                                Else

                                    Try
                                        Dim trans As SqlTransaction
                                        trans = conexionRemota.BeginTransaction("InsertarGrupo")
                                        comandoRemoto.Connection = conexionRemota
                                        comandoRemoto.Transaction = trans

                                        comandoRemoto.CommandText = "Insert into grupo values(" & CInt(txtClave.Text) & ", " & CInt(txtIdMaestro.Text) & ", " & CInt(txtMaxAlumnos.Text) & ", " & 0 & ", " & CInt(cboNivel.SelectedItem) & ", '" & horarioL & "', '" & horarioLF & "', '" & horarioMa & "', '" & horarioMaF & "', '" & horarioMi & "', '" & horarioMiF & "', '" & horarioJu & "', '" & horarioJuF & "', '" & horarioVi & "', '" & horarioViF & "', '" & horarioSa & "', '" & horarioSaF & "')"
                                        comandoRemoto.ExecuteNonQuery()
                                        If MessageBox.Show("¿Desea registrar el nuevo horario?", "Registro de horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                            trans.Commit()
                                            For i = dgHorario.Rows.Count To dgHorario.Rows.Count
                                                dgHorario.Rows.Add(txtClave.Text, cboMaestros.Text, cboNivel.Text, txtMaxAlumnos.Text, horarioL, horarioLF, horarioMa, horarioMaF, horarioMi, horarioMiF, horarioJu, horarioJuF, horarioVi, horarioViF, horarioSa, horarioSaF)
                                            Next
                                            MessageBox.Show("Grupo registrado con éxito", "Registro de ciclo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                            'Control de comandos
                                            btnGuardar.Enabled = False
                                            btnCancelar.Enabled = False

                                            btnNuevo.Enabled = True
                                            btnModificar.Enabled = True
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

                                            txtMaxAlumnos.Text = ""
                                            txtIdMaestro.Text = ""
                                            txtClave.Text = ""
                                            txtCorreo.Text = ""
                                            txtTel.Text = ""
                                            cboMaestros.Text = ""
                                            cboNivel.Enabled = False

                                            dtpLunesI.Text = CDate("00:00")
                                            dtpLunesF.Text = CDate("00:00")

                                            dtpMartesI.Text = CDate("00:00")
                                            dtpMartesF.Text = CDate("00:00")

                                            dtpMiercolesI.Text = CDate("00:00")
                                            dtpMiercolesF.Text = CDate("00:00")

                                            dtpJuevesI.Text = CDate("00:00")
                                            dtpJuevesF.Text = CDate("00:00")

                                            dtpViernesI.Text = CDate("00:00")
                                            dtpViernesF.Text = CDate("00:00")

                                            dtpSabadoI.Text = CDate("00:00")
                                            dtpSabadoF.Text = CDate("00:00")
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
                                            MsgBox(ex2.Message)
                                        End Try
                                    End Try
                                    conexionRemota.Close()
                                End If
                            End If
                        End Using
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
        btnModificar.Enabled = True

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
        Me.Close()
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgHorario.RowCount > 0 Then

            btnGuardar.Enabled = True
            btnCancelar.Enabled = True

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
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

        Else
            MessageBox.Show("No se pueden realizar modificaciones por falta de informacion", "Error de modificaicon", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cboMaestros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaestros.SelectedIndexChanged

    End Sub
End Class