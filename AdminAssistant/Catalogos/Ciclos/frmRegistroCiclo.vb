Imports System.Data.SqlClient
Public Class frmRegistroCiclo
    Private Sub frmRegistroCiclo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EasyEnglishDataSetMani.ciclo' Puede moverla o quitarla según sea necesario.
        Me.CicloTableAdapter.Fill(Me.EasyEnglishDataSetMani.ciclo)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Asigna un Id autoincremental
        Dim n As Integer
        n = CicloBindingSource.Count + 1
        CicloBindingSource.AddNew()
        txtClaveCiclo.Text = n

        'Desactiva botones
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False

        'activa botones y controles
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        dtpAnio.Enabled = True
        cboEstado.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        dtpAnio.Enabled = False
        cboEstado.Enabled = False
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Antes de guardar, se mueve al registro anterior de la base de datos.
        'Como el MovePrevious está primero, significa que el apuntador del Current estará un registro antes del último registro
        'Si el estado del ciclo anterior es "Abierto", no deja guardar el ciclo y lanza un mensaje.
        'Si está cerrado, sí deja guardar el ciclo.
        CicloBindingSource.MovePrevious()
        If CicloBindingSource.Current(2) = "Abierto" Then
            MessageBox.Show("No se puede abrir un nuevo ciclo hasta que se cierre el anterior", "Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            CicloBindingSource.EndEdit()
            SqlDataAdapter1.Update(EasyEnglishDataSetMani.ciclo)
            EasyEnglishDataSetMani.Clear()
            CicloTableAdapter.Update(EasyEnglishDataSetMani.ciclo)
            SqlDataAdapter1.Fill(EasyEnglishDataSetMani.ciclo)
            CicloTableAdapter.Fill(EasyEnglishDataSetMani.ciclo)
        End If

        'Se bloquean los botones y controles
        dtpAnio.Enabled = False
        cboEstado.Enabled = False
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnPrimero.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False

        'Se activan botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Se bloquean botones
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False

        'se activan controles y botones
        dtpAnio.Enabled = True
        cboEstado.Enabled = True
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Se bloquean los botones y controles
        dtpAnio.Enabled = False
        cboEstado.Enabled = False
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnPrimero.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False

        'Se activan botones
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("estado", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("estado", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
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
End Class