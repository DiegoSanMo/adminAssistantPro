Imports System.Data.SqlClient
Public Class frmBitacora
    Private Sub frmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionMasterServidor.Open()
        comandoMasterServidor.CommandText = "SELECT * FROM bitacora"
        lectorMasterServidor = comandoMasterServidor.ExecuteReader

        dgvBitacora.Rows.Clear()
        While lectorMasterServidor.Read
            dgvBitacora.Rows.Add(lectorMasterServidor(0), lectorMasterServidor(1), lectorMasterServidor(2), lectorMasterServidor(3), lectorMasterServidor(4), lectorMasterServidor(5), lectorMasterServidor(6))
        End While
        lectorMasterServidor.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionMasterServidor.Close()
        Me.Close()
    End Sub
End Class