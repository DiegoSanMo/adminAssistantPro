Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReporteKardex
    Dim idAlumno As Integer
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Conexion.Open()

        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        Dim n As Integer = comandoGeneral.ExecuteScalar()

        If n > 0 Then
            comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lectorGeneral = comandoGeneral.ExecuteReader
            lectorGeneral.Read()


            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)

            If lectorGeneral(2) = "Abierto" Then
                lectorGeneral.Close()
                'Dim nomAlumno As String
                'nomAlumno = CStr(cboNombreAlumno.Text)
                Dim cmd As New SqlCommand("REPORTEKARDEXPORALUMNO", Conexion)
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = Conexion
                adaptador.SelectCommand.CommandText = "REPORTEKARDEXPORALUMNO"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@IDALUMNO", SqlDbType.NVarChar)
                param1.Direction = ParameterDirection.Input
                param1.Value = idAlumno
                adaptador.SelectCommand.Parameters.Add(param1)
                Dim dataset As New DataSet
                adaptador.Fill(dataset)
                dataset.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataset.Tables(0)
                Dim p1 As New ReportParameter("P1", idAlumno)
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteKardexPorAlumno.rdlc"
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteKardexPorAlumno.rdlc"
                frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                frmReportes.ReportViewer1.RefreshReport()
                frmReportes.ShowDialog()
                Conexion.Close()
            Else
                MessageBox.Show("Error. No hay ciclos abiertos", "No hay ciclos abiertos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lectorGeneral.Close()
                Conexion.Close()
            End If
        Else
            MessageBox.Show("Error. No hay ningún ciclo registrado", "No hay ciclos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conexion.Close()
        End If
    End Sub

    Private Sub frmReporteKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()

        comandoGeneral.CommandText = "SELECT nombre FROM alumno"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNombreAlumno.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
        Conexion.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Close()
    End Sub

    Private Sub cboNombreAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreAlumno.SelectedIndexChanged
        Conexion.Open()
        comandoGeneral.CommandText = "SELECT idAlumno FROM alumno WHERE nombre = '" & CStr(cboNombreAlumno.Text) & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()
        idAlumno = lectorGeneral(0)
        lectorGeneral.Close()
        Conexion.Close()
    End Sub
End Class