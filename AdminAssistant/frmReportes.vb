Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReportes
    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)
    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class