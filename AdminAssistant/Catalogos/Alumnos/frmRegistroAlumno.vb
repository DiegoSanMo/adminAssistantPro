Imports System.Data.SqlClient
Public Class frmRegistroAlumno
    Dim ubicacion As String
    Dim contFallas As Integer
    Dim banModificar As Boolean = False
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtEstado.Enabled = False
        txtCorreo.Enabled = False
        txtTel.Enabled = False
        txtTelEmergencia.Enabled = False
        txtCiudad.Enabled = False
        txtUNA.Enabled = False
        cboSituacion.Enabled = False
        dtpFechaNa.Enabled = False
        btnBuscarF.Enabled = False
    End Sub

    Private Sub frmRegistroAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'MasterEADataSetDiego.alumno' Puede moverla o quitarla según sea necesario.
            'Me.AlumnoTableAdapter1.Fill(Me.MasterEADataSetDiego.alumno)
            'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSetMani.alumno' Puede moverla o quitarla según sea necesario.
            Me.AlumnoTableAdapter.Fill(Me.MasterEADataSet.alumno)

            btnPrimero.Enabled = True
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = True
            btnUltimo.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexionsql.Open()
        Try
            If banModificar = False Then
                comando.CommandText = "Insert into kardex(idAlumno, n1, n2, n3, n4, n5, n6, n7,	n8, n9, n10, n11, n12) values(" & CInt(txtNoControl.Text) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & "," & CDec(0) & ")"
                comando.ExecuteNonQuery()
                conexionsql.Close()
                AlumnoBindingSource.EndEdit()
                AlumnoBindingSource.Current(9) = ubicacion
                SqlDataAdapter1.Update(MasterEADataSet.alumno)

                MasterEADataSet.Clear()
                AlumnoTableAdapter.Update(MasterEADataSet.alumno)
                SqlDataAdapter1.Fill(MasterEADataSet.alumno)
                AlumnoTableAdapter.Fill(MasterEADataSet.alumno)
            Else
                conexionsql.Close()
                AlumnoBindingSource.EndEdit()
                AlumnoBindingSource.Current(9) = ubicacion
                SqlDataAdapter1.Update(MasterEADataSet.alumno)

                MasterEADataSet.Clear()
                AlumnoTableAdapter.Update(MasterEADataSet.alumno)
                SqlDataAdapter1.Fill(MasterEADataSet.alumno)
                AlumnoTableAdapter.Fill(MasterEADataSet.alumno)
            End If
        Catch ex2 As Exception
            MsgBox(ex2.Message)
        End Try
        'Se bloquean los controles principales
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtEstado.Enabled = False
        txtCorreo.Enabled = False
        txtTel.Enabled = False
        txtTelEmergencia.Enabled = False
        txtCiudad.Enabled = False
        txtUNA.Enabled = False
        cboSituacion.Enabled = False
        dtpFechaNa.Enabled = False
        btnBuscarF.Enabled = False
        banModificar = False

        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = AlumnoBindingSource.Count + 1
        AlumnoBindingSource.AddNew()
        txtNoControl.Text = n

        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtEstado.Enabled = True
        txtCorreo.Enabled = True
        txtTel.Enabled = True
        txtTelEmergencia.Enabled = True
        txtCiudad.Enabled = True
        txtUNA.Enabled = True
        cboSituacion.Enabled = True
        dtpFechaNa.Enabled = True
        btnBuscarF.Enabled = True

        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtEstado.Enabled = True
        txtCorreo.Enabled = True
        txtTel.Enabled = True
        txtTelEmergencia.Enabled = True
        txtCiudad.Enabled = True
        txtUNA.Enabled = True
        cboSituacion.Enabled = True
        dtpFechaNa.Enabled = True
        btnBuscarF.Enabled = True
        banModificar = True

        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        AlumnoBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        AlumnoBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        AlumnoBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        AlumnoBindingSource.MoveLast()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtEstado.Enabled = False
        txtCorreo.Enabled = False
        txtTel.Enabled = False
        txtTelEmergencia.Enabled = False
        txtCiudad.Enabled = False
        txtUNA.Enabled = False
        cboSituacion.Enabled = False
        dtpFechaNa.Enabled = False
        btnBuscarF.Enabled = False

        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
    End Sub

    Private Sub btnBuscarF_Click(sender As Object, e As EventArgs) Handles btnBuscarF.Click
        OpenFileDialog1.ShowDialog()
        Dim ruta As String
        ruta = OpenFileDialog1.FileName
        ptbFoto.Image = Image.FromFile(ruta)
        ubicacion = ruta
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("nombre", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub
End Class