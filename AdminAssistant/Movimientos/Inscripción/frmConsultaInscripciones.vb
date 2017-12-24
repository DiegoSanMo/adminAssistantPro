Imports System.Data.SqlClient
Public Class frmConsultaInscripciones
    Private Sub frmConsultaInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()

        Dim idCiclo As Integer
        Dim anioC As String

        comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()

        idCiclo = lectorGeneral(0)
        anioC = lectorGeneral(1)
        lectorGeneral.Close()
        'asigna el nombre de la base de datos
        Name = CStr(idCiclo) + CStr("-") + CStr(anioC)
        Dim conexionBD2 As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & Name & "'; Integrated Security=true")
        'Dim conexionBD2 As New SqlConnection("Data source='PRO'; Initial Catalog='" & Name & "'; Integrated Security=true")
        Dim comandoBD2 As SqlCommand = conexionBD2.CreateCommand
        Dim lectorBD2 As SqlDataReader
        conexionBD2.Open()

        comandoBD2.CommandText = "Select idInscripcion, idAlumno, idGrupo, fecha From inscripcion"
        lectorBD2 = comandoBD2.ExecuteReader
        dgvConsultaInscripciones.Rows.Clear()
        While lectorBD2.Read
            dgvConsultaInscripciones.Rows.Add(lectorBD2(0), lectorBD2(1), lectorBD2(2), lectorBD2(3))
        End While
        lectorBD2.Close()
        conexionBD2.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Close()
    End Sub
End Class