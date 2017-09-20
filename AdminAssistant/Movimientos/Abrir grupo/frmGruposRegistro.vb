Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmGruposRegistro
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

    Private Sub frmGruposRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using Conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)



        End Using




    End Sub
End Class