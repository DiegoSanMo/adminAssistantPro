

Imports System.Data.SqlClient

Public Class frmRegistroAlumno
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
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSet.alumno' Puede moverla o quitarla según sea necesario.
        Me.AlumnoTableAdapter.Fill(Me.EasyEnglishDataSet.alumno)

        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        AlumnoBindingSource.EndEdit()
        'AlumnoTableAdapter.Update(EasyEnglishDataSet.alumno)
        SqlDataAdapter1.Update(EasyEnglishDataSet.alumno)
        EasyEnglishDataSet.Clear()
        AlumnoTableAdapter.Fill(EasyEnglishDataSet.alumno)

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


        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("nombre", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
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

    End Sub
End Class