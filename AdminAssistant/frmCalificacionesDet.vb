Imports System.Data.SqlClient
Imports Microsoft.Reporting
Public Class frmCalificacionesDet
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Close()
    End Sub

    Private Sub frmCalificacionesDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()

        comandoGeneral.CommandText = "SELECT nombre FROM alumno"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNombreAlumno.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()

        'Dim conexioBDRemota As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nomBD & "'; Integrated Security=true; MultipleActiveResultSets = True")
        'Dim comandoBDRemota As SqlCommand = conexioBDRemota.CreateCommand
        'Dim comando2 As SqlCommand = conexioBDRemota.CreateCommand
        'Dim lector2 As SqlDataReader
        'Dim lectorBDRemota As SqlDataReader
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
            'comandoBDRemota.CommandText = "SELECT nivel FROM grupo INNER JOIN inscripcion ON grupo.idGrupo = inscripcion.idGrupo INNER JOIN MasterEA.dbo.alumno ON "2-2017".dbo.inscripcion.idAlumno = MasterEA.dbo.alumno.idAlumno WHERE MasterEA.dbo.alumno.idAlumno = 1;"
        End While
        Conexion.Close()
    End Sub
End Class