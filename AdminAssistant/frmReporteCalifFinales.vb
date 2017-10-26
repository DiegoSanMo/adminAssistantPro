Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReporteCalifFinales
    Dim idAlumno As Integer
    Dim fechaR As Date = System.DateTime.Today

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If constancia = True Then
            Conexion.Open()
            comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
            lectorGeneral = comandoGeneral.ExecuteReader
            lectorGeneral.Read()

            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)

            lectorGeneral.Close()
            Using conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                Dim lectorBDRemota As SqlDataReader

                conexioBDRemota.Open()

                comandoBDRemota.CommandText = "SELECT inscripcion.idAlumno, alumno.nombre, grupo.nivel FROM inscripcion INNER JOIN grupo ON inscripcion.idGrupo = grupo.idGrupo INNER JOIN MasterEA.dbo.alumno ON inscripcion.idAlumno = MasterEA.dbo.alumno.idAlumno Where inscripcion.idAlumno = " & idAlumno & ""
                lectorBDRemota = comandoBDRemota.ExecuteReader
                lectorBDRemota.Read()

                comandoGeneral.CommandText = "INSERT INTO auxConstancia values(" & lectorBDRemota(0) & ",'" & lectorBDRemota(1) & "'," & lectorBDRemota(2) & ")"
                comandoGeneral.ExecuteNonQuery()

                Dim cmd As New SqlCommand("CONSTANCIANIVELACTUAL", Conexion)
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = Conexion
                adaptador.SelectCommand.CommandText = "CONSTANCIANIVELACTUAL"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@IDALUMNO", SqlDbType.Int)
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
                Dim p2 As New ReportParameter("P2", fechaR)
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteConstanciaNivel.rdlc"
                'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteKardexPorAlumno.rdlc"
                frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                frmReportes.ReportViewer1.RefreshReport()
                frmReportes.ShowDialog()
                Conexion.Close()
            End Using
            constancia = False
        ElseIf constanciaNivAct = True Then
            Conexion.Open()
            Dim comandoAux As SqlCommand = Conexion.CreateCommand
            Dim comandoAux2 As SqlCommand = Conexion.CreateCommand
            Dim lectorAux As SqlDataReader
            comandoGeneral.CommandText = "DELETE FROM constanciaCalifActuales"
            comandoGeneral.ExecuteNonQuery()
            For x = 1 To 12
                comandoGeneral.CommandText = "SELECT COLUMN_NAME FROM MasterEA.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'kardex' and  MasterEA.INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME = 'n" & x & "'"
                lectorGeneral = comandoGeneral.ExecuteReader
                lectorGeneral.Read()
                Dim nomColumna As String = lectorGeneral(0)
                MsgBox(nomColumna)
                comandoAux.CommandText = "SELECT " & nomColumna & " FROM kardex WHERE " & nomColumna & " != 0 AND idAlumno=" & idAlumno & ";"
                lectorAux = comandoAux.ExecuteReader
                lectorAux.Read()
                MsgBox(lectorAux(0))
                If lectorAux(0) <> 0 Then
                    MsgBox("Mensaje Culiao")
                    comandoAux2.CommandText = "INSERT INTO constanciaCalifActuales(nivel" & x & ") values(" & lectorAux(0) & ")"
                    comandoAux2.ExecuteNonQuery()
                    lectorAux.Close()
                Else
                    lectorGeneral.Close()
                    lectorAux.Close()
                End If
                lectorGeneral.Close()
            Next
            Dim cmd As New SqlCommand("CONSTANCIACALIFACTUAL", Conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = Conexion
            adaptador.SelectCommand.CommandText = "CONSTANCIACALIFACTUAL"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@IDALUMNO", SqlDbType.Int)
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
            Dim p2 As New ReportParameter("P2", fechaR)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteCalifActuales.rdlc"
            'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteKardexPorAlumno.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            constanciaNivAct = False
            Conexion.Close()
        Else
            Conexion.Open()
            Dim cmd As New SqlCommand("REPORTECALIFFINALES", Conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = Conexion
            adaptador.SelectCommand.CommandText = "REPORTECALIFFINALES"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@IDALUMNO", SqlDbType.Int)
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
            Dim p2 As New ReportParameter("P2", fechaR)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteConstanciaFinal.rdlc"
            'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteKardexPorAlumno.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            Conexion.Close()
        End If
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

    Private Sub frmReporteCalifFinales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        If constancia = True Then
            comandoGeneral.CommandText = "SELECT nombre FROM alumno"
            lectorGeneral = comandoGeneral.ExecuteReader
            While lectorGeneral.Read
                cboNombreAlumno.Items.Add(lectorGeneral(0))
            End While
            lectorGeneral.Close()
            Conexion.Close()
        ElseIf constanciaNivAct = True Then
            comandoGeneral.CommandText = "SELECT nombre FROM alumno"
            lectorGeneral = comandoGeneral.ExecuteReader
            While lectorGeneral.Read
                cboNombreAlumno.Items.Add(lectorGeneral(0))
            End While
            lectorGeneral.Close()
            Conexion.Close()
        Else
            Dim situacion As String = "FINALIZADO"
            comandoGeneral.CommandText = "SELECT nombre FROM alumno WHERE situacion='" & situacion & "'"
            lectorGeneral = comandoGeneral.ExecuteReader
            While lectorGeneral.Read
                cboNombreAlumno.Items.Add(lectorGeneral(0))
            End While
            lectorGeneral.Close()
            Conexion.Close()
        End If

    End Sub
End Class