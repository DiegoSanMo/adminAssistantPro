﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReportes
    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class