Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReporteListas
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Conexion.Open()

        comandoGeneral.CommandText = "Select count(idCiclo) from ciclo"
        Dim n As Integer = comandoGeneral.ExecuteScalar()

        If n > 0 Then
            comandoGeneral.CommandText = "DELETE FROM auxListas"
            comandoGeneral.ExecuteNonQuery()
            'Select estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)
            comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lectorGeneral = comandoGeneral.ExecuteReader
            lectorGeneral.Read()


            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)


            If lectorGeneral(2) = "Abierto" Then
                lectorGeneral.Close()

                'Using conexioBDRemota As New SqlConnection("Data source='PRO'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                Using conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                        Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                        Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                        Dim lectorBDRemota As SqlDataReader

                        conexioBDRemota.Open()

                        comandoBDRemota.CommandText = "SELECT * FROM lista" & CInt(cboNumLista.Text) & ""
                        lectorBDRemota = comandoBDRemota.ExecuteReader

                        While lectorBDRemota.Read
                            comando2.CommandText = "Insert into MasterEA.dbo.auxListas values(" & lectorBDRemota(0) & ",'" & lectorBDRemota(1) & "'," & CDec(lectorBDRemota(2)) & ")"
                            comando2.ExecuteNonQuery()
                        End While
                        lectorBDRemota.Close()
                        conexioBDRemota.Close()
                    End Using

                Dim cmd As New SqlCommand("REPORTELISTASPORCICLO", Conexion)
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(cmd)
                Dim data As New DataSet
                adaptador.Fill(data)
                data.DataSetName = "DataSet1"
                Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteListasPorCiclo.rdlc"
                'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteListasPorCiclo.rdlc"
                frmReportes.ReportViewer1.RefreshReport()
                frmReportes.ShowDialog()
                Conexion.Close()
            Else
                Conexion.Close()
                MessageBox.Show("ERROR, NO HAY CICLO ABIERTO PARA REALIZAR EL REPORTE", "CICLO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub frmReporteListas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()

        Dim id As Integer = lectorGeneral(0)
        Dim anio As Integer = lectorGeneral(1)
        Dim nomBD As String = CStr(id) + "-" + CStr(anio)

        If lectorGeneral(2) = "Abierto" Then
            lectorGeneral.Close()
            Dim contListas As Integer
            'Using conexioBDRemota As New SqlConnection("Data source='PRO'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
            Using conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                    Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                    Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                    Dim lectorBDRemota As SqlDataReader

                    conexioBDRemota.Open()

                    comandoBDRemota.CommandText = "SELECT count(*) - 2 FROM INFORMATION_SCHEMA.TABLES"
                    contListas = comandoBDRemota.ExecuteScalar()

                    For i = 1 To contListas
                        cboNumLista.Items.Add(i)
                    Next
                    conexioBDRemota.Close()
                End Using
        End If
        Conexion.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Conexion.Close()
    End Sub
End Class