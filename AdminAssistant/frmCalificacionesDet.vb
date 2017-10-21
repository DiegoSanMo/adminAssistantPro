Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmCalificacionesDet
    Dim idAlumno As Integer
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Conexion.Open()
        comandoGeneral.CommandText = "DELETE FROM detalleKardexAlumno"
        comandoGeneral.ExecuteNonQuery()

        comandoGeneral.CommandText = "Select idCiclo, anio from ciclo"
        lectorGeneral = comandoGeneral.ExecuteReader

        While lectorGeneral.Read

            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)

            'Using conexioBDRemota As New SqlConnection("Data source='PRO'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
            Using conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
                Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
                Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
                Dim lector2 As SqlDataReader
                Dim lectorBDRemota As SqlDataReader

                conexioBDRemota.Open()

                comandoBDRemota.CommandText = "SELECT inscripcion.idGrupo, inscripcion.fecha from [" & nomBD & "].dbo.inscripcion INNER JOIN grupo ON [" & nomBD & "].dbo.inscripcion.idGrupo = [" & nomBD & "].dbo.grupo.idGrupo where idAlumno = " & idAlumno & " AND grupo.nivel =" & CInt(cboNivel.Text) & ""
                lectorBDRemota = comandoBDRemota.ExecuteReader

                If lectorBDRemota.Read() = False Then
                    lectorBDRemota.Close()
                Else
                    Dim idGrupo As Integer = lectorBDRemota(0)
                    Dim fechaInscripcion As Date = lectorBDRemota(1)
                    lectorBDRemota.Close()

                    comandoBDRemota.CommandText = "select c.nombre, grupo.nivel, grupo.hLuIni, grupo.hLuFin, grupo.hMaIni, grupo.hMaFin, grupo.hMiIni, grupo.hMiFin, grupo.hJuIni, grupo.hJuFin, grupo.hViIni, grupo.hViFin, grupo.hSaIni, grupo.hSaFin from grupo inner join MasterEA.dbo.maestro c on grupo.idMaestro = c.idMaestro WHERE grupo.idGrupo = " & idGrupo & ""
                    lectorBDRemota = comandoBDRemota.ExecuteReader
                    lectorBDRemota.Read()

                    Dim nombM As String = lectorBDRemota(0)
                    Dim nivel As Integer = lectorBDRemota(1)
                    'horario del lunes
                    Dim hLunI As String = lectorBDRemota(2)
                    Dim hLunF As String = lectorBDRemota(3)
                    'horario del martes
                    Dim hMaI As String = lectorBDRemota(4)
                    Dim hMaF As String = lectorBDRemota(5)
                    'horario del miercoles
                    Dim hMiI As String = lectorBDRemota(6)
                    Dim hMiF As String = lectorBDRemota(7)
                    'horario del jueves
                    Dim hJuI As String = lectorBDRemota(8)
                    Dim hJuF As String = lectorBDRemota(9)
                    'horario del viernes
                    Dim hViI As String = lectorBDRemota(10)
                    Dim hViF As String = lectorBDRemota(11)
                    'Horario del sabado
                    Dim hSaI As String = lectorBDRemota(12)
                    Dim hSaf As String = lectorBDRemota(13)
                    lectorBDRemota.Close()

                    comando2.CommandText = "SELECT COLUMN_NAME FROM MasterEA.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME =  'kardex' and  MasterEA.INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME = 'n" & nivel & "';"
                    lector2 = comando2.ExecuteReader
                    lector2.Read()
                    Dim nomColumna As String = lector2(0)
                    lector2.Close()

                    'comando para obtener la calificacion del nivel correspondiente
                    comando2.CommandText = "SELECT " & nomColumna & " from MasterEA.dbo.kardex where idAlumno = " & idAlumno & ""
                    lector2 = comando2.ExecuteReader
                    lector2.Read()
                    Dim calNivel As Decimal = lector2(0)
                    lector2.Close()

                    'comando para insertar en la tabla auxiliar
                    comando2.CommandText = "INSERT INTO MasterEA.dbo.detalleKardexAlumno VALUES(" & idAlumno & " ,'" & nomBD & "', " & idGrupo & ", '" & nombM & "', " & nivel & ", " & calNivel & ", '" & fechaInscripcion & "', '" & hLunI & "', '" & hLunF & "', '" & hMaI & "', '" & hMaF & "', '" & hMiI & "', '" & hMiF & "', '" & hJuI & "', '" & hJuF & "', '" & hViI & "', '" & hViF & "', '" & hSaI & "', '" & hSaf & "')"
                    comando2.ExecuteNonQuery()

                    conexioBDRemota.Close()
                End If

            End Using
        End While
        lectorGeneral.Close()

        'Comienza area de Reporte
        Dim cmd As New SqlCommand("REPORTEKARDEXPORALUMNOPORNIVEL", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = Conexion
        adaptador.SelectCommand.CommandText = "REPORTEKARDEXPORALUMNOPORNIVEL"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@IDALUMNO", SqlDbType.Int)
        Dim param2 = New SqlParameter("@NIVEL", SqlDbType.Int)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param1.Value = idAlumno
        param2.Value = CInt(cboNivel.Text)
        adaptador.SelectCommand.Parameters.Add(param1)
        adaptador.SelectCommand.Parameters.Add(param2)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dataset.DataSetName = "DataSet1"
        Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
        datasource.Name = "DataSet1"
        datasource.Value = dataset.Tables(0)
        Dim p1 As New ReportParameter("P1", idAlumno)
        Dim p2 As New ReportParameter("P2", CInt(cboNivel.Text))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\AdminAssistant\Reportes\ReporteKardexPorAlumnoPorNivel.rdlc"
        'frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Diego\Documents\GitHub\adminAssistantPro\AdminAssistant\Reportes\ReporteNivelesCursados.rdlc"
        frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()

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

        cboNivel.Items.Clear()

        comandoGeneral.CommandText = "Select idCiclo, anio, estado From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read()
            Dim id As Integer = lectorGeneral(0)
            Dim anio As Integer = lectorGeneral(1)
            Dim nomBD As String = CStr(id) + "-" + CStr(anio)

            Dim conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
            Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
            Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
            Dim lector2 As SqlDataReader
            Dim lectorBDRemota As SqlDataReader
            conexioBDRemota.Open()
            comandoBDRemota.CommandText = "SELECT nivel - 1 FROM grupo INNER JOIN inscripcion ON grupo.idGrupo = inscripcion.idGrupo INNER JOIN MasterEA.dbo.alumno ON [" & nomBD & "].dbo.inscripcion.idAlumno = MasterEA.dbo.alumno.idAlumno WHERE MasterEA.dbo.alumno.idAlumno =" & idAlumno & ""
            lectorBDRemota = comandoBDRemota.ExecuteReader
            lectorBDRemota.Read()
            If lectorBDRemota(0) <> 0 Then
                cboNivel.Items.Add(lectorBDRemota(0))
                lectorBDRemota.Close()
            End If
        End While
        lectorGeneral.Close()
        Conexion.Close()
    End Sub

    Private Sub frmCalificacionesDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()

        comandoGeneral.CommandText = "SELECT nombre FROM alumno"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNombreAlumno.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
        Conexion.Close()
    End Sub
End Class