<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscripciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInscripciones))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDatosAlumno = New System.Windows.Forms.GroupBox()
        Me.cboNoControl = New System.Windows.Forms.ComboBox()
        Me.txtSituacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        Me.txtUNA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdInscripcion = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHLunes = New System.Windows.Forms.TextBox()
        Me.txtHMiercoles = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHSabado = New System.Windows.Forms.TextBox()
        Me.txtHViernes = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtHJueves = New System.Windows.Forms.TextBox()
        Me.txtHMartes = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNombreM = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdMaestro = New System.Windows.Forms.TextBox()
        Me.cboIdGrupo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAlumno.SuspendLayout()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosGrupo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 85)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 189)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(107, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(521, 22)
        Me.txtNombre.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Fecha de inscripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(8, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "No. control"
        '
        'gbDatosAlumno
        '
        Me.gbDatosAlumno.Controls.Add(Me.cboNoControl)
        Me.gbDatosAlumno.Controls.Add(Me.txtSituacion)
        Me.gbDatosAlumno.Controls.Add(Me.Label10)
        Me.gbDatosAlumno.Controls.Add(Me.txtTelefono)
        Me.gbDatosAlumno.Controls.Add(Me.Label8)
        Me.gbDatosAlumno.Controls.Add(Me.txtDomicilio)
        Me.gbDatosAlumno.Controls.Add(Me.Label7)
        Me.gbDatosAlumno.Controls.Add(Me.ptbFoto)
        Me.gbDatosAlumno.Controls.Add(Me.txtUNA)
        Me.gbDatosAlumno.Controls.Add(Me.Label6)
        Me.gbDatosAlumno.Controls.Add(Me.Label5)
        Me.gbDatosAlumno.Controls.Add(Me.txtNombre)
        Me.gbDatosAlumno.Controls.Add(Me.Label4)
        Me.gbDatosAlumno.Enabled = False
        Me.gbDatosAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosAlumno.Location = New System.Drawing.Point(179, 97)
        Me.gbDatosAlumno.Name = "gbDatosAlumno"
        Me.gbDatosAlumno.Size = New System.Drawing.Size(796, 187)
        Me.gbDatosAlumno.TabIndex = 25
        Me.gbDatosAlumno.TabStop = False
        Me.gbDatosAlumno.Text = "Datos del alumno"
        '
        'cboNoControl
        '
        Me.cboNoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNoControl.FormattingEnabled = True
        Me.cboNoControl.Location = New System.Drawing.Point(107, 20)
        Me.cboNoControl.Name = "cboNoControl"
        Me.cboNoControl.Size = New System.Drawing.Size(174, 26)
        Me.cboNoControl.TabIndex = 34
        '
        'txtSituacion
        '
        Me.txtSituacion.Enabled = False
        Me.txtSituacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSituacion.Location = New System.Drawing.Point(492, 155)
        Me.txtSituacion.Name = "txtSituacion"
        Me.txtSituacion.Size = New System.Drawing.Size(136, 22)
        Me.txtSituacion.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(489, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Situación"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(264, 155)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(171, 22)
        Me.txtTelefono.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(261, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Teléfono"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(107, 98)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(521, 22)
        Me.txtDomicilio.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(6, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Domicilio"
        '
        'ptbFoto
        '
        Me.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbFoto.Location = New System.Drawing.Point(634, 20)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(149, 157)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFoto.TabIndex = 27
        Me.ptbFoto.TabStop = False
        '
        'txtUNA
        '
        Me.txtUNA.Enabled = False
        Me.txtUNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUNA.Location = New System.Drawing.Point(6, 155)
        Me.txtUNA.Name = "txtUNA"
        Me.txtUNA.Size = New System.Drawing.Size(222, 22)
        Me.txtUNA.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Último nivel acréditado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(681, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 24)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "ID Inscripción"
        '
        'txtIdInscripcion
        '
        Me.txtIdInscripcion.Enabled = False
        Me.txtIdInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtIdInscripcion.Location = New System.Drawing.Point(824, 69)
        Me.txtIdInscripcion.Name = "txtIdInscripcion"
        Me.txtIdInscripcion.Size = New System.Drawing.Size(152, 26)
        Me.txtIdInscripcion.TabIndex = 32
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(6, 519)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(171, 50)
        Me.btnNuevo.TabIndex = 42
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(805, 519)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(171, 50)
        Me.btnSalir.TabIndex = 45
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(564, 519)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(171, 50)
        Me.btnCancelar.TabIndex = 44
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "ID Grupo"
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.Controls.Add(Me.GroupBox1)
        Me.gbDatosGrupo.Controls.Add(Me.txtNombreM)
        Me.gbDatosGrupo.Controls.Add(Me.Label20)
        Me.gbDatosGrupo.Controls.Add(Me.Label11)
        Me.gbDatosGrupo.Controls.Add(Me.txtIdMaestro)
        Me.gbDatosGrupo.Controls.Add(Me.cboIdGrupo)
        Me.gbDatosGrupo.Controls.Add(Me.Label12)
        Me.gbDatosGrupo.Controls.Add(Me.txtNivel)
        Me.gbDatosGrupo.Controls.Add(Me.Label15)
        Me.gbDatosGrupo.Enabled = False
        Me.gbDatosGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGrupo.Location = New System.Drawing.Point(6, 290)
        Me.gbDatosGrupo.Name = "gbDatosGrupo"
        Me.gbDatosGrupo.Size = New System.Drawing.Size(969, 223)
        Me.gbDatosGrupo.TabIndex = 46
        Me.gbDatosGrupo.TabStop = False
        Me.gbDatosGrupo.Text = "Datos del grupo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtHLunes)
        Me.GroupBox1.Controls.Add(Me.txtHMiercoles)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtHSabado)
        Me.GroupBox1.Controls.Add(Me.txtHViernes)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtHJueves)
        Me.GroupBox1.Controls.Add(Me.txtHMartes)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(558, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 201)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 18)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Lunes"
        '
        'txtHLunes
        '
        Me.txtHLunes.Enabled = False
        Me.txtHLunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHLunes.Location = New System.Drawing.Point(9, 39)
        Me.txtHLunes.Name = "txtHLunes"
        Me.txtHLunes.Size = New System.Drawing.Size(170, 26)
        Me.txtHLunes.TabIndex = 52
        '
        'txtHMiercoles
        '
        Me.txtHMiercoles.Enabled = False
        Me.txtHMiercoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHMiercoles.Location = New System.Drawing.Point(9, 103)
        Me.txtHMiercoles.Name = "txtHMiercoles"
        Me.txtHMiercoles.Size = New System.Drawing.Size(170, 26)
        Me.txtHMiercoles.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(221, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 18)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Sábado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 18)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Miércoles"
        '
        'txtHSabado
        '
        Me.txtHSabado.Enabled = False
        Me.txtHSabado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHSabado.Location = New System.Drawing.Point(221, 166)
        Me.txtHSabado.Name = "txtHSabado"
        Me.txtHSabado.Size = New System.Drawing.Size(171, 26)
        Me.txtHSabado.TabIndex = 62
        '
        'txtHViernes
        '
        Me.txtHViernes.Enabled = False
        Me.txtHViernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHViernes.Location = New System.Drawing.Point(9, 166)
        Me.txtHViernes.Name = "txtHViernes"
        Me.txtHViernes.Size = New System.Drawing.Size(170, 26)
        Me.txtHViernes.TabIndex = 56
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(221, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 18)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Jueves"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 145)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 18)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Viernes"
        '
        'txtHJueves
        '
        Me.txtHJueves.Enabled = False
        Me.txtHJueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHJueves.Location = New System.Drawing.Point(221, 103)
        Me.txtHJueves.Name = "txtHJueves"
        Me.txtHJueves.Size = New System.Drawing.Size(170, 26)
        Me.txtHJueves.TabIndex = 60
        '
        'txtHMartes
        '
        Me.txtHMartes.Enabled = False
        Me.txtHMartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHMartes.Location = New System.Drawing.Point(221, 39)
        Me.txtHMartes.Name = "txtHMartes"
        Me.txtHMartes.Size = New System.Drawing.Size(170, 26)
        Me.txtHMartes.TabIndex = 58
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(221, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 18)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Martes"
        '
        'txtNombreM
        '
        Me.txtNombreM.Enabled = False
        Me.txtNombreM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombreM.Location = New System.Drawing.Point(6, 108)
        Me.txtNombreM.Name = "txtNombreM"
        Me.txtNombreM.Size = New System.Drawing.Size(371, 26)
        Me.txtNombreM.TabIndex = 65
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 82)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Maestro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(404, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "IdMaestro"
        '
        'txtIdMaestro
        '
        Me.txtIdMaestro.Enabled = False
        Me.txtIdMaestro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtIdMaestro.Location = New System.Drawing.Point(407, 108)
        Me.txtIdMaestro.Name = "txtIdMaestro"
        Me.txtIdMaestro.Size = New System.Drawing.Size(115, 26)
        Me.txtIdMaestro.TabIndex = 50
        '
        'cboIdGrupo
        '
        Me.cboIdGrupo.FormattingEnabled = True
        Me.cboIdGrupo.Location = New System.Drawing.Point(9, 46)
        Me.cboIdGrupo.Name = "cboIdGrupo"
        Me.cboIdGrupo.Size = New System.Drawing.Size(121, 24)
        Me.cboIdGrupo.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(242, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Nivel"
        '
        'txtNivel
        '
        Me.txtNivel.Enabled = False
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNivel.Location = New System.Drawing.Point(242, 43)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(135, 26)
        Me.txtNivel.TabIndex = 27
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(251, 519)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(171, 50)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(978, 62)
        Me.Label22.TabIndex = 65
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(378, 71)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(180, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 58)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Inscripción de"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(529, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 56)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Alumnos"
        '
        'frmInscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 582)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbDatosGrupo)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIdInscripcion)
        Me.Controls.Add(Me.gbDatosAlumno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmInscripciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInscripciones"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAlumno.ResumeLayout(False)
        Me.gbDatosAlumno.PerformLayout()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.gbDatosGrupo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbDatosAlumno As GroupBox
    Friend WithEvents txtUNA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSituacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdInscripcion As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents gbDatosGrupo As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents cboNoControl As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHLunes As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdMaestro As TextBox
    Friend WithEvents cboIdGrupo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtHMartes As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtHViernes As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtHMiercoles As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtHSabado As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtHJueves As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreM As TextBox
    Friend WithEvents Label20 As Label
End Class
