Imports System.Data.SqlClient

Public Class frmRegistroMaestro
    Private Sub frmRegistroMaestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MasterEADataSetDiego.maestro' Puede moverla o quitarla según sea necesario.
        ' Me.MaestroTableAdapter1.Fill(Me.MasterEADataSetDiego.maestro)
        'TODO: esta línea de código carga datos en la tabla 'MasterEADataSet.maestro' Puede moverla o quitarla según sea necesario.
        Me.MaestroTableAdapter.Fill(Me.MasterEADataSet.maestro)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = MaestroBindingSource.Count + 1
        MaestroBindingSource.AddNew()
        txtClave.Text = n

        'activar textbox y botones
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtTel.Enabled = True
        txtCorreo.Enabled = True
        cboNivel.Enabled = True
        txtCertificado.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        'bloquear botones
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MaestroBindingSource.EndEdit()
        SqlDataAdapter1.Update(MasterEADataSet.maestro)
        MasterEADataSet.Clear()
        MaestroTableAdapter.Update(MasterEADataSet.maestro)
        SqlDataAdapter1.Fill(MasterEADataSet.maestro)
        MaestroTableAdapter.Fill(MasterEADataSet.maestro)

        'activar textbox y botones
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtTel.Enabled = False
        txtCorreo.Enabled = False
        cboNivel.Enabled = False
        txtCertificado.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        'bloquear botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'activar textbox y botones
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtTel.Enabled = True
        txtCorreo.Enabled = True
        cboNivel.Enabled = True
        txtCertificado.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        'bloquear botones
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'activar textbox y botones
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtTel.Enabled = False
        txtCorreo.Enabled = False
        cboNivel.Enabled = False
        txtCertificado.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        'bloquear botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'activar textbox y botones
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtTel.Enabled = False
        txtCorreo.Enabled = False
        cboNivel.Enabled = False
        txtCertificado.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        'bloquear botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True

        Me.Dispose()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        MaestroBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        MaestroBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        MaestroBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        MaestroBindingSource.MoveLast()
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