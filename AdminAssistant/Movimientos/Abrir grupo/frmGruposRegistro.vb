Imports System.Data.SqlClient
Public Class frmGruposRegistro
    Private Sub frmGruposRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Conexion general
        Conexion.Open()
        comandoGeneral.CommandText = "Select nombre from maestro"
        lectorGeneral = comandoGeneral.ExecuteReader

        While lectorGeneral.Read
            cboMaestros.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()


        Dim idCiclo As Integer
        Dim anioC As String

        comandoGeneral.CommandText = "Select idCiclo, anio From ciclo Where idCiclo=(Select max(idCiclo) From ciclo)"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()

        idCiclo = lectorGeneral(0)
        anioC = lectorGeneral(1)
        nombreBaseRemota = CStr(idCiclo) + CStr("-") + CStr(anioC)
        lectorGeneral.Close()
        Conexion.Close()

        conexionRemota.Open()
        comandoRemoto.CommandText = "SELECT DB_NAME() AS [Current Database];"
        lectorRemoto = comandoRemoto.ExecuteReader
        lectorRemoto.Read()
        MsgBox(lectorRemoto(0))



    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        btnNuevo.Enabled = False
        btnSalir.Enabled = False

        cboMaestros.Enabled = True

        mskLunes.Enabled = True
        mskMartes.Enabled = True
        mskMiercoles.Enabled = True
        mskJueves.Enabled = True
        mskViernes.Enabled = True
        mskSabado.Enabled = True
        txtMaxAlumnos.Enabled = True
        cboNivel.Enabled = True

        Dim n As Integer
        comandoRemoto.CommandText = "Select count(idGrupo) from grupo"
        n = comandoRemoto.ExecuteScalar + 1



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        cboMaestros.Enabled = False

        mskLunes.Enabled = False
        mskMartes.Enabled = False
        mskMiercoles.Enabled = False
        mskJueves.Enabled = False
        mskViernes.Enabled = False
        mskSabado.Enabled = False
        txtMaxAlumnos.Enabled = False
        cboNivel.Enabled = False

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        cboMaestros.Enabled = False

        mskLunes.Enabled = False
        mskMartes.Enabled = False
        mskMiercoles.Enabled = False
        mskJueves.Enabled = False
        mskViernes.Enabled = False
        mskSabado.Enabled = False
        txtMaxAlumnos.Enabled = False
        cboNivel.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Dispose()
    End Sub

End Class