Imports System.Data.SqlClient
Public Class frmAsignarCalificacion
    'Dim conexionCiclo As New SqlConnection("Data source='PRO'; Initial Catalog='" & nombreBDCilo & "'; Integrated Security=true; MultipleActiveResultSets=true")
    Dim conexionCiclo As New SqlConnection("Data source='DESKTOP-B3IP6AD\MANI'; Initial Catalog='" & nombreBDCilo & "'; Integrated Security=true; MultipleActiveResultSets=true")
    Dim comandoCiclo As SqlCommand = conexionCiclo.CreateCommand
    Dim lectorCiclo As SqlDataReader

    Private Sub frmAsignarCalificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 1 To canListas
            cboLista.Items.Add(x)
        Next
        'conexionCiclo.Open()
    End Sub

    Private Sub cboLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLista.SelectedIndexChanged

        Dim nombreTabla As String = "lista" + CStr(cboLista.Text)

        conexionCiclo.Open()
        comandoCiclo.CommandText = "Select m.nivel, m.cantInscritos, t.nombre, m.hLuIni, m.hLuFin, m.hMaIni, m.hMaFin, m.hMiIni, m.hMiFin, m.hJuIni, m.hJuFin, m.hViIni, m.hViFin, m.hSaIni, m.hSaFin  From  [" & nombreBDCilo & "].dbo.inscripcion c JOIN  [" & nombreBDCilo & "].dbo.grupo m  On c.idGrupo = m.idGrupo join [" & nombreBDCilo & "].dbo." & nombreTabla & " l on l.idAlumno = c.idAlumno join MasterEA.dbo.maestro t on m.idMaestro = t.idMaestro where m.idGrupo = c.idGrupo"
        lectorCiclo = comandoCiclo.ExecuteReader
        lectorCiclo.Read()

        txtNivel.Text = lectorCiclo(0)
        txtCantAlumnos.Text = lectorCiclo(1)
        txtNombre.Text = lectorCiclo(2)
        txtHLunes.Text = lectorCiclo(3) + "/" + lectorCiclo(4)
        txtHMartes.Text = lectorCiclo(5) + "/" + lectorCiclo(6)
        txtHMiercoles.Text = lectorCiclo(7) + "/" + lectorCiclo(8)
        txtHJueves.Text = lectorCiclo(9) + "/" + lectorCiclo(10)
        txtHViernes.Text = lectorCiclo(11) + "/" + lectorCiclo(12)
        txtHSabado.Text = lectorCiclo(13) + "/" + lectorCiclo(14)

        lectorCiclo.Close()

        Dim query As String = "Select idAlumno, nombre, calificacion from " & nombreTabla & ""
        Dim selectCMD As SqlCommand = New SqlCommand(query, conexionCiclo)
        Dim custDA As SqlDataAdapter = New SqlDataAdapter
        Dim custDS As DataSet = New DataSet()
        custDA.SelectCommand = selectCMD

        custDA.Fill(custDS, nombreTabla)
        dgLista.DataSource = custDS.Tables(0)

        dgLista.Columns(0).Width = 150
        dgLista.Columns(1).Width = 450
        dgLista.Columns(2).Width = 80
        dgLista.Columns(0).ReadOnly = True
        dgLista.Columns(1).ReadOnly = True
        conexionCiclo.Close()
    End Sub

    Private Sub dgLista_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista.CellValueChanged
        If e.ColumnIndex = 2 Then
            Dim val As String = dgLista.CurrentRow.Cells(2).Value.ToString
            If val = " " Then
            Else
                If val > 100 Then
                    MsgBox("Calificación fuera de rango, rango permitido [1-100]")
                Else
                    If IsNumeric(val) Then

                        conexionCiclo.Open()
                        Dim nombreTabla As String = "lista" + CStr(cboLista.Text)
                        comandoCiclo.CommandText = "UPDATE " & nombreTabla & " SET calificacion = '" & CDec(dgLista.CurrentRow.Cells(2).Value) & "' WHERE idAlumno = '" & CInt(dgLista.CurrentRow.Cells(0).Value) & "'"
                        comandoCiclo.ExecuteNonQuery()

                        conexionCiclo.Close()
                    Else
                        MsgBox("Favor de ingresar solo números")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Dispose()
    End Sub
End Class