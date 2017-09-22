<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGruposRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGruposRegistro))
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdMaestro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboMaestros = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgHorario = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpSabadoF = New System.Windows.Forms.DateTimePicker()
        Me.dtpSabadoI = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpViernesF = New System.Windows.Forms.DateTimePicker()
        Me.dtpViernesI = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpJuevesF = New System.Windows.Forms.DateTimePicker()
        Me.dtpJuevesI = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpMiercolesF = New System.Windows.Forms.DateTimePicker()
        Me.dtpMiercolesI = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpMartesF = New System.Windows.Forms.DateTimePicker()
        Me.dtpMartesI = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpLunesF = New System.Windows.Forms.DateTimePicker()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.dtpLunesI = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtMaxAlumnos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtClave
        '
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtClave.Location = New System.Drawing.Point(677, 77)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(154, 26)
        Me.txtClave.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(558, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 18)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Clave del grupo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(116, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(225, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 41)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Registro de "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(425, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 41)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "grupos"
        '
        'txtIdMaestro
        '
        Me.txtIdMaestro.Enabled = False
        Me.txtIdMaestro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMaestro.Location = New System.Drawing.Point(10, 100)
        Me.txtIdMaestro.Name = "txtIdMaestro"
        Me.txtIdMaestro.Size = New System.Drawing.Size(109, 24)
        Me.txtIdMaestro.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "ID Maestro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nombre "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMaestros)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtIdMaestro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1114, 140)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del asesor"
        '
        'cboMaestros
        '
        Me.cboMaestros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMaestros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaestros.Enabled = False
        Me.cboMaestros.FormattingEnabled = True
        Me.cboMaestros.Location = New System.Drawing.Point(10, 47)
        Me.cboMaestros.Name = "cboMaestros"
        Me.cboMaestros.Size = New System.Drawing.Size(527, 23)
        Me.cboMaestros.TabIndex = 1
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(606, 100)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(224, 24)
        Me.txtTel.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(606, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Teléfono"
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(606, 45)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(479, 24)
        Me.txtCorreo.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(606, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Correo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgHorario)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 457)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 181)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupos registrados"
        '
        'dgHorario
        '
        Me.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgHorario.Location = New System.Drawing.Point(20, 25)
        Me.dgHorario.Name = "dgHorario"
        Me.dgHorario.Size = New System.Drawing.Size(916, 150)
        Me.dgHorario.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "IdGrupo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Maestro"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Horario Lunes"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Horario Martes"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Horario Miercoles"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Horario Jueves"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Horario Viernes"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Horario Sábado"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(30, 644)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(161, 39)
        Me.btnNuevo.TabIndex = 59
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(805, 644)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(161, 39)
        Me.btnSalir.TabIndex = 62
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(304, 644)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(161, 39)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(541, 644)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(161, 39)
        Me.btnCancelar.TabIndex = 61
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpSabadoF)
        Me.GroupBox3.Controls.Add(Me.dtpSabadoI)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.dtpViernesF)
        Me.GroupBox3.Controls.Add(Me.dtpViernesI)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.dtpJuevesF)
        Me.GroupBox3.Controls.Add(Me.dtpJuevesI)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.dtpMiercolesF)
        Me.GroupBox3.Controls.Add(Me.dtpMiercolesI)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.dtpMartesF)
        Me.GroupBox3.Controls.Add(Me.dtpMartesI)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtpLunesF)
        Me.GroupBox3.Controls.Add(Me.cboNivel)
        Me.GroupBox3.Controls.Add(Me.dtpLunesI)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.txtMaxAlumnos)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1157, 191)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Horario de clases"
        '
        'dtpSabadoF
        '
        Me.dtpSabadoF.CustomFormat = "HH:mm"
        Me.dtpSabadoF.Enabled = False
        Me.dtpSabadoF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSabadoF.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSabadoF.Location = New System.Drawing.Point(1005, 99)
        Me.dtpSabadoF.Name = "dtpSabadoF"
        Me.dtpSabadoF.ShowUpDown = True
        Me.dtpSabadoF.Size = New System.Drawing.Size(114, 23)
        Me.dtpSabadoF.TabIndex = 13
        Me.dtpSabadoF.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'dtpSabadoI
        '
        Me.dtpSabadoI.CustomFormat = "HH:mm"
        Me.dtpSabadoI.Enabled = False
        Me.dtpSabadoI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSabadoI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSabadoI.Location = New System.Drawing.Point(879, 99)
        Me.dtpSabadoI.Name = "dtpSabadoI"
        Me.dtpSabadoI.ShowUpDown = True
        Me.dtpSabadoI.Size = New System.Drawing.Size(114, 23)
        Me.dtpSabadoI.TabIndex = 12
        Me.dtpSabadoI.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1002, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 16)
        Me.Label24.TabIndex = 122
        Me.Label24.Text = "Fin"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(876, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 16)
        Me.Label25.TabIndex = 121
        Me.Label25.Text = "Inicio"
        '
        'dtpViernesF
        '
        Me.dtpViernesF.CustomFormat = "HH:mm"
        Me.dtpViernesF.Enabled = False
        Me.dtpViernesF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpViernesF.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpViernesF.Location = New System.Drawing.Point(1005, 43)
        Me.dtpViernesF.Name = "dtpViernesF"
        Me.dtpViernesF.ShowUpDown = True
        Me.dtpViernesF.Size = New System.Drawing.Size(114, 23)
        Me.dtpViernesF.TabIndex = 11
        Me.dtpViernesF.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'dtpViernesI
        '
        Me.dtpViernesI.CustomFormat = "HH:mm"
        Me.dtpViernesI.Enabled = False
        Me.dtpViernesI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpViernesI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpViernesI.Location = New System.Drawing.Point(879, 43)
        Me.dtpViernesI.Name = "dtpViernesI"
        Me.dtpViernesI.ShowUpDown = True
        Me.dtpViernesI.Size = New System.Drawing.Size(114, 23)
        Me.dtpViernesI.TabIndex = 10
        Me.dtpViernesI.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1002, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 16)
        Me.Label22.TabIndex = 118
        Me.Label22.Text = "Fin"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(876, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 16)
        Me.Label23.TabIndex = 117
        Me.Label23.Text = "Inicio"
        '
        'dtpJuevesF
        '
        Me.dtpJuevesF.CustomFormat = "HH:mm"
        Me.dtpJuevesF.Enabled = False
        Me.dtpJuevesF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJuevesF.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpJuevesF.Location = New System.Drawing.Point(617, 99)
        Me.dtpJuevesF.Name = "dtpJuevesF"
        Me.dtpJuevesF.ShowUpDown = True
        Me.dtpJuevesF.Size = New System.Drawing.Size(114, 23)
        Me.dtpJuevesF.TabIndex = 9
        Me.dtpJuevesF.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'dtpJuevesI
        '
        Me.dtpJuevesI.CustomFormat = "HH:mm"
        Me.dtpJuevesI.Enabled = False
        Me.dtpJuevesI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJuevesI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpJuevesI.Location = New System.Drawing.Point(491, 99)
        Me.dtpJuevesI.Name = "dtpJuevesI"
        Me.dtpJuevesI.ShowUpDown = True
        Me.dtpJuevesI.Size = New System.Drawing.Size(114, 23)
        Me.dtpJuevesI.TabIndex = 8
        Me.dtpJuevesI.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(614, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 16)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "Fin"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(488, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 16)
        Me.Label21.TabIndex = 113
        Me.Label21.Text = "Inicio"
        '
        'dtpMiercolesF
        '
        Me.dtpMiercolesF.CustomFormat = "HH:mm"
        Me.dtpMiercolesF.Enabled = False
        Me.dtpMiercolesF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMiercolesF.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMiercolesF.Location = New System.Drawing.Point(617, 43)
        Me.dtpMiercolesF.Name = "dtpMiercolesF"
        Me.dtpMiercolesF.ShowUpDown = True
        Me.dtpMiercolesF.Size = New System.Drawing.Size(114, 23)
        Me.dtpMiercolesF.TabIndex = 7
        Me.dtpMiercolesF.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'dtpMiercolesI
        '
        Me.dtpMiercolesI.CustomFormat = "HH:mm"
        Me.dtpMiercolesI.Enabled = False
        Me.dtpMiercolesI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMiercolesI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMiercolesI.Location = New System.Drawing.Point(491, 43)
        Me.dtpMiercolesI.Name = "dtpMiercolesI"
        Me.dtpMiercolesI.ShowUpDown = True
        Me.dtpMiercolesI.Size = New System.Drawing.Size(114, 23)
        Me.dtpMiercolesI.TabIndex = 6
        Me.dtpMiercolesI.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(614, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 16)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Fin"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(488, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 16)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Inicio"
        '
        'dtpMartesF
        '
        Me.dtpMartesF.CustomFormat = "HH:mm"
        Me.dtpMartesF.Enabled = False
        Me.dtpMartesF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMartesF.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMartesF.Location = New System.Drawing.Point(230, 99)
        Me.dtpMartesF.Name = "dtpMartesF"
        Me.dtpMartesF.ShowUpDown = True
        Me.dtpMartesF.Size = New System.Drawing.Size(114, 23)
        Me.dtpMartesF.TabIndex = 5
        Me.dtpMartesF.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'dtpMartesI
        '
        Me.dtpMartesI.CustomFormat = "HH:mm"
        Me.dtpMartesI.Enabled = False
        Me.dtpMartesI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMartesI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMartesI.Location = New System.Drawing.Point(104, 99)
        Me.dtpMartesI.Name = "dtpMartesI"
        Me.dtpMartesI.ShowUpDown = True
        Me.dtpMartesI.Size = New System.Drawing.Size(114, 23)
        Me.dtpMartesI.TabIndex = 4
        Me.dtpMartesI.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(227, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 16)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Fin"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(101, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = "Inicio"
        '
        'dtpLunesF
        '
        Me.dtpLunesF.CustomFormat = "HH:mm"
        Me.dtpLunesF.Enabled = False
        Me.dtpLunesF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLunesF.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpLunesF.Location = New System.Drawing.Point(230, 43)
        Me.dtpLunesF.Name = "dtpLunesF"
        Me.dtpLunesF.ShowUpDown = True
        Me.dtpLunesF.Size = New System.Drawing.Size(114, 23)
        Me.dtpLunesF.TabIndex = 3
        Me.dtpLunesF.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.Enabled = False
        Me.cboNivel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboNivel.Location = New System.Drawing.Point(587, 156)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(123, 25)
        Me.cboNivel.TabIndex = 15
        '
        'dtpLunesI
        '
        Me.dtpLunesI.CustomFormat = "HH:mm"
        Me.dtpLunesI.Enabled = False
        Me.dtpLunesI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLunesI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpLunesI.Location = New System.Drawing.Point(104, 43)
        Me.dtpLunesI.Name = "dtpLunesI"
        Me.dtpLunesI.ShowUpDown = True
        Me.dtpLunesI.Size = New System.Drawing.Size(114, 23)
        Me.dtpLunesI.TabIndex = 2
        Me.dtpLunesI.Value = New Date(2017, 9, 21, 12, 0, 0, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(516, 153)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 24)
        Me.Label27.TabIndex = 102
        Me.Label27.Text = "Nivel"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(148, 156)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(181, 24)
        Me.Label26.TabIndex = 101
        Me.Label26.Text = "Máximo de alumnos"
        '
        'txtMaxAlumnos
        '
        Me.txtMaxAlumnos.Enabled = False
        Me.txtMaxAlumnos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxAlumnos.Location = New System.Drawing.Point(344, 156)
        Me.txtMaxAlumnos.Name = "txtMaxAlumnos"
        Me.txtMaxAlumnos.Size = New System.Drawing.Size(83, 23)
        Me.txtMaxAlumnos.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(227, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 16)
        Me.Label19.TabIndex = 93
        Me.Label19.Text = "Fin"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(101, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 16)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "Inicio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(798, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 24)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Sábado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(798, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 24)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Viernes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(393, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 24)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Jueves"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 24)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Míercoles"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 24)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Martes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Lunes"
        '
        'frmGruposRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 705)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGruposRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGruposRegistro"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdMaestro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cboMaestros As ComboBox
    Friend WithEvents dgHorario As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboNivel As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtMaxAlumnos As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents dtpLunesI As DateTimePicker
    Friend WithEvents dtpSabadoF As DateTimePicker
    Friend WithEvents dtpSabadoI As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents dtpViernesF As DateTimePicker
    Friend WithEvents dtpViernesI As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dtpJuevesF As DateTimePicker
    Friend WithEvents dtpJuevesI As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpMiercolesF As DateTimePicker
    Friend WithEvents dtpMiercolesI As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpMartesF As DateTimePicker
    Friend WithEvents dtpMartesI As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpLunesF As DateTimePicker
End Class
