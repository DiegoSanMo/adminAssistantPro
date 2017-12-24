Imports System.Data.SqlClient
Public Class frmInscripciones
    Private Sub frmInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        comandoGeneral.CommandText = "Select idAlumno From alumno"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNoControl.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()

        Dim idCiclo As Integer
        Dim anioC As Integer

        comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()

        idCiclo = lectorGeneral(0)
        anioC = lectorGeneral(1)
        lectorGeneral.Close()

        Name = CStr(idCiclo) + "-" + CStr(anioC)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        gbDatosAlumno.Enabled = True
        gbDatosGrupo.Enabled = True

        Dim conexionBD2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true")
        'Dim conexionBD2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true")
        Dim comandoBD2 As SqlCommand = conexionBD2.CreateCommand
        conexionBD2.Open()

        Dim fecha As String = CStr(System.DateTime.Today)
        Dim n As Integer
        comandoBD2.CommandText = "Select count(idInscripcion) From inscripcion"
        n = comandoBD2.ExecuteScalar + 1
        txtIdInscripcion.Text = n
        txtFecha.Text = fecha

        conexionBD2.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        gbDatosAlumno.Enabled = False
        gbDatosGrupo.Enabled = False

        txtFecha.Text = ""
        txtIdInscripcion.Text = ""
        cboNoControl.Text = ""
        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtUNA.Text = ""
        txtTelefono.Text = ""
        txtSituacion.Text = ""
        cboIdGrupo.Text = ""
        txtIdMaestro.Text = ""
        txtNivel.Text = ""
        txtHLunes.Text = ""
        txtHMartes.Text = ""
        txtHMiercoles.Text = ""
        txtHJueves.Text = ""
        txtHViernes.Text = ""
        txtHSabado.Text = ""
        ptbFoto.Image = Nothing
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text = "" Then
            MessageBox.Show("No se ha seleccionado alumno", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txtSituacion.Text = "ACTIVO" Then
                MessageBox.Show("ALUMNO YA INSCRITO", "INSCRIPCIÓN YA REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim conexionBD2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true")
                'Dim conexionBD2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true")
                Dim comandoBD2 As SqlCommand = conexionBD2.CreateCommand
                Dim lectorBD2 As SqlDataReader
                Dim nuevaSituacion As String = "ACTIVO"
                conexionBD2.Open()
                transaccion = Conexion.BeginTransaction("TransaccionInscripcion")
                comandoGeneral.Connection = Conexion
                comandoGeneral.Transaction = transaccion

                transaccion2 = conexionBD2.BeginTransaction("TransaccionDeActualizacion")
                comandoBD2.Connection = conexionBD2
                comandoBD2.Transaction = transaccion2
                Try
                    comandoBD2.CommandText = "Select cantInscritos From grupo Where idGrupo=" & cboIdGrupo.Text & ""
                    lectorBD2 = comandoBD2.ExecuteReader
                    lectorBD2.Read()
                    Dim cantInscritos As Integer = lectorBD2(0)
                    lectorBD2.Close()
                    If cantInscritos = 14 Then
                        MessageBox.Show("No se puede inscribir a este grupo. Escoja otro.", "Cantidad máxima de alumnos alcanzada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        comandoBD2.CommandText = "Insert into inscripcion values(" & CInt(txtIdInscripcion.Text) & "," & CInt(cboNoControl.Text) & "," & CInt(cboIdGrupo.Text) & ",'" & txtFecha.Text & "')"
                        comandoBD2.ExecuteNonQuery()

                        comandoGeneral.CommandText = "Update alumno Set situacion='" & nuevaSituacion & "' Where idAlumno=" & cboNoControl.Text & ""
                        comandoGeneral.ExecuteNonQuery()

                        comandoBD2.CommandText = "Update grupo Set cantInscritos=" & cantInscritos + 1 & " Where idGrupo=" & cboIdGrupo.Text & ""
                        comandoBD2.ExecuteNonQuery()
                        If MessageBox.Show("¿Desea registrar la inscripción?", "Registro de inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                            transaccion.Commit()
                            transaccion2.Commit()
                            conexionBD2.Close()

                            MessageBox.Show("Registro de inscripción exitosa", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            btnNuevo.Enabled = True
                            btnSalir.Enabled = True
                            btnGuardar.Enabled = False
                            btnCancelar.Enabled = False

                            gbDatosAlumno.Enabled = False
                            gbDatosGrupo.Enabled = False

                            txtFecha.Text = ""
                            txtIdInscripcion.Text = ""
                            cboNoControl.Text = ""
                            txtNombre.Text = ""
                            txtDomicilio.Text = ""
                            txtUNA.Text = ""
                            txtTelefono.Text = ""
                            txtSituacion.Text = ""
                            cboIdGrupo.Text = ""
                            txtIdMaestro.Text = ""
                            txtNivel.Text = ""
                            txtHLunes.Text = ""
                            txtHMartes.Text = ""
                            txtHMiercoles.Text = ""
                            txtHJueves.Text = ""
                            txtHViernes.Text = ""
                            txtHSabado.Text = ""
                            ptbFoto.Image = Nothing
                        Else
                            transaccion.Rollback()
                            transaccion2.Rollback()
                            MessageBox.Show("Se ha cancelado la inscripción", "Cancelación de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Commit Exception Type: {0} No se pudo insertar por error")
                    Try
                        transaccion.Rollback()
                        transaccion2.Rollback()
                    Catch ex2 As Exception
                        MessageBox.Show("Error de inscripción")
                    End Try
                End Try
            End If
        End If
    End Sub

    Private Sub cboIdGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdGrupo.SelectedIndexChanged
        Dim conexionBD2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true")
        'Dim conexionBD2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true")
        Dim comandoBD2 As SqlCommand = conexionBD2.CreateCommand
        Dim lectorBD2 As SqlDataReader

        conexionBD2.Open()
        comandoBD2.CommandText = "Select grupo.idMaestro, nivel, nombre, hLuIni, hLuFin, hMaIni, hMaFin, hMiIni, hMiFin, hJuIni, hJuFin, hViIni, hViFin, hSaIni, hSaFin From grupo inner join MasterEA.dbo.maestro on grupo.idMaestro = maestro.idMaestro Where grupo.idGrupo=" & cboIdGrupo.Text & ""
        lectorBD2 = comandoBD2.ExecuteReader
        lectorBD2.Read()
        txtIdMaestro.Text = lectorBD2(0)
        txtNivel.Text = lectorBD2(1)
        txtNombreM.Text = lectorBD2(2)
        txtHLunes.Text = lectorBD2(3).ToString + "-" + lectorBD2(4).ToString
        txtHMartes.Text = lectorBD2(5).ToString + "-" + lectorBD2(6).ToString
        txtHMiercoles.Text = lectorBD2(7).ToString + "-" + lectorBD2(8).ToString
        txtHJueves.Text = lectorBD2(9).ToString + "-" + lectorBD2(10).ToString
        txtHViernes.Text = lectorBD2(11).ToString + "-" + lectorBD2(12).ToString
        txtHSabado.Text = lectorBD2(13).ToString + "-" + lectorBD2(14).ToString

        lectorBD2.Close()
        conexionBD2.Close()
    End Sub

    Private Sub cboNoControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNoControl.SelectedIndexChanged
        comandoGeneral.CommandText = "Select nombre, domicilio, ultimoNivelAcreditado, telefono, situacion, foto From alumno Where idAlumno=" & cboNoControl.Text & ""
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()
        If lectorGeneral(4) = "ACTIVO" Then
            MessageBox.Show("El alumno ya está inscrito", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lectorGeneral.Close()
        Else
            txtNombre.Text = lectorGeneral(0)
            txtDomicilio.Text = lectorGeneral(1)
            txtUNA.Text = lectorGeneral(2)
            txtTelefono.Text = lectorGeneral(3)
            txtSituacion.Text = lectorGeneral(4)
            ptbFoto.Image = Image.FromFile(lectorGeneral(5))

            Dim conexionBD2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true")
            'Dim conexionBD2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true")
            Dim comandoBD2 As SqlCommand = conexionBD2.CreateCommand
            Dim lectorBD2 As SqlDataReader

            conexionBD2.Open()
            comandoBD2.CommandText = "Select idGrupo From grupo Where nivel=" & lectorGeneral(2) + 1 & ""
            lectorBD2 = comandoBD2.ExecuteReader
            While lectorBD2.Read
                cboIdGrupo.Items.Add(lectorBD2(0))
            End While
            lectorBD2.Close()
            conexionBD2.Close()
            lectorGeneral.Close()
        End If
    End Sub
End Class