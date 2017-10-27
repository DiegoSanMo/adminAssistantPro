Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReporteSituacion
    Dim situacion As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conexion.Open()

        situacion = cboSituación.Text
        Dim fecha As String = System.DateTime.Today

        Dim cmd As New SqlCommand("REPORTEALUMNOSPORSITUACION", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = Conexion
        adaptador.SelectCommand.CommandText = "REPORTEALUMNOSPORSITUACION"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@SITUACION", SqlDbType.NVarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = situacion
        adaptador.SelectCommand.Parameters.Add(param1)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dataset.DataSetName = "DataSet1"
        Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
        datasource.Name = "DataSet1"
        datasource.Value = dataset.Tables(0)
        Dim p1 As New ReportParameter("P1", situacion)
        Dim p2 As New ReportParameter("P2", fecha)
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteSituacionAlumnos.rdlc"
        'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteSituacionAlumnos.rdlc"
        frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        frmReportes.ReportViewer1.RefreshReport()

        frmReportes.ShowDialog()
        Conexion.Close()



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Conexion.Close()
        Me.Dispose()
    End Sub
End Class