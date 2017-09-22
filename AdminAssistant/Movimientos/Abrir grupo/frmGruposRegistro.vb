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
        lectorGeneral.Close()
        'asigna el nombre de la base de datos
        Name = CStr(idCiclo) + CStr("-") + CStr(anioC)










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





        Using conexionRemota As New SqlConnection("Data source = 'PRO'; Initial Catalog='" & Name & "'; integrated security = true")
            Dim comandoRemoto As SqlCommand = conexionRemota.CreateCommand
            Dim lectorRemoto As SqlDataReader

            conexionRemota.Open()


            comandoRemoto.CommandText = "SELECT DB_NAME() AS [Current Database]"
            lectorRemoto = comandoRemoto.ExecuteReader
            lectorRemoto.Read()

            MsgBox(lectorRemoto(0))
            lectorRemoto.Close()

            comandoRemoto.CommandText = "Select count(idGrupo) from grupo"
            Dim n As Integer = comandoRemoto.ExecuteScalar + 1
            txtClave.Text = n

            conexionRemota.Close()

        End Using


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

    Private Sub cboMaestros_TextChanged(sender As Object, e As EventArgs) Handles cboMaestros.TextChanged

        comandoGeneral.CommandText = "Select nombre from maestro where nombre like  '%" & cboMaestros.Text & "%'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboMaestros.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()


    End Sub

    Private Sub cboMaestros_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMaestros.SelectedValueChanged

        comandoGeneral.CommandText = "Select idMaestro, correo, telefono from maestro where nombre = '" & cboMaestros.Text & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()
        txtIdMaestro.Text = lectorGeneral(0)
        txtCorreo.Text = lectorGeneral(1)
        txtTel.Text = lectorGeneral(2)
        lectorGeneral.Close()



    End Sub

    Private Sub cboMaestros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaestros.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class