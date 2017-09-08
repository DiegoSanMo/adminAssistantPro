Imports System.Data.SqlClient

Public Class frmRegistroCiclo
    Private Sub frmRegistroCiclo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSet.ciclo' Puede moverla o quitarla según sea necesario.
        Me.CicloTableAdapter.Fill(Me.EasyEnglishDataSet.ciclo)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = CicloBindingSource.Count + 1
        CicloBindingSource.AddNew()
        txtClave.Text = n

        'Activar textbox y botones
        dtpAnio.Enabled = True
        cboEstado.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        'desactivar botones
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CicloBindingSource.EndEdit()
        SqlDataAdapter1.Update(EasyEnglishDataSet.ciclo)
        EasyEnglishDataSet.Clear()
        CicloTableAdapter.Fill(EasyEnglishDataSet.ciclo)

        'activar botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True

        'desactivar textbox y botones
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        dtpAnio.Enabled = False
        cboEstado.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Activar textbox y botones
        dtpAnio.Enabled = True
        cboEstado.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True

        'desactivar botones
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'limpiar controles
        txtClave.Clear()
        cboEstado.Text = ""

        'Activar botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True

        'Desactiva botones y controles
        dtpAnio.Enabled = False
        cboEstado.Enabled = False
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        CicloBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        CicloBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        CicloBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        CicloBindingSource.MoveLast()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("ID", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("ID", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub
End Class