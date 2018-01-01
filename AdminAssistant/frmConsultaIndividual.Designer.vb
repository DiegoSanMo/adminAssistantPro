<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIndividual
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
        Me.txtSituacion = New System.Windows.Forms.TextBox()
        Me.lblSit = New System.Windows.Forms.Label()
        Me.txtIDAlumno = New System.Windows.Forms.TextBox()
        Me.lblIDAlumnoN = New System.Windows.Forms.Label()
        Me.lblNombreID = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTelEme = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNivel12 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNivel10 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNivel8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNivel11 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNivel9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNivel7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNivel6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNivel4 = New System.Windows.Forms.TextBox()
        Me.txtNivel2 = New System.Windows.Forms.TextBox()
        Me.txtNivel5 = New System.Windows.Forms.TextBox()
        Me.txtNivel3 = New System.Windows.Forms.TextBox()
        Me.txtNivel1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSituacion
        '
        Me.txtSituacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtSituacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSituacion.Location = New System.Drawing.Point(598, 166)
        Me.txtSituacion.Name = "txtSituacion"
        Me.txtSituacion.ReadOnly = True
        Me.txtSituacion.Size = New System.Drawing.Size(146, 26)
        Me.txtSituacion.TabIndex = 68
        '
        'lblSit
        '
        Me.lblSit.AutoSize = True
        Me.lblSit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSit.Location = New System.Drawing.Point(495, 168)
        Me.lblSit.Name = "lblSit"
        Me.lblSit.Size = New System.Drawing.Size(84, 20)
        Me.lblSit.TabIndex = 67
        Me.lblSit.Text = "Situación"
        '
        'txtIDAlumno
        '
        Me.txtIDAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDAlumno.Location = New System.Drawing.Point(288, 165)
        Me.txtIDAlumno.Name = "txtIDAlumno"
        Me.txtIDAlumno.ReadOnly = True
        Me.txtIDAlumno.Size = New System.Drawing.Size(159, 26)
        Me.txtIDAlumno.TabIndex = 60
        '
        'lblIDAlumnoN
        '
        Me.lblIDAlumnoN.AutoSize = True
        Me.lblIDAlumnoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDAlumnoN.Location = New System.Drawing.Point(193, 167)
        Me.lblIDAlumnoN.Name = "lblIDAlumnoN"
        Me.lblIDAlumnoN.Size = New System.Drawing.Size(93, 20)
        Me.lblIDAlumnoN.TabIndex = 59
        Me.lblIDAlumnoN.Text = "ID Alumno"
        '
        'lblNombreID
        '
        Me.lblNombreID.AutoSize = True
        Me.lblNombreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreID.Location = New System.Drawing.Point(193, 88)
        Me.lblNombreID.Name = "lblNombreID"
        Me.lblNombreID.Size = New System.Drawing.Size(71, 20)
        Me.lblNombreID.TabIndex = 58
        Me.lblNombreID.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(288, 85)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(456, 26)
        Me.txtNombre.TabIndex = 57
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(76, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(744, 39)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(750, 85)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(125, 69)
        Me.btnBuscar.TabIndex = 69
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtTelEme)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtCiudad)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtNivel)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.txtDomicilio)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(863, 160)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos personales"
        '
        'txtCorreo
        '
        Me.txtCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(389, 117)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(458, 26)
        Me.txtCorreo.TabIndex = 84
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(320, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 20)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Correo"
        '
        'txtFecha
        '
        Me.txtFecha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(160, 117)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(146, 26)
        Me.txtFecha.TabIndex = 82
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 20)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "F. de nacimiento"
        '
        'txtTelEme
        '
        Me.txtTelEme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtTelEme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelEme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelEme.Location = New System.Drawing.Point(435, 75)
        Me.txtTelEme.Name = "txtTelEme"
        Me.txtTelEme.ReadOnly = True
        Me.txtTelEme.Size = New System.Drawing.Size(146, 26)
        Me.txtTelEme.TabIndex = 80
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(284, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(138, 20)
        Me.Label18.TabIndex = 79
        Me.Label18.Text = "Tel. Emergencia"
        '
        'txtCiudad
        '
        Me.txtCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(607, 30)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.ReadOnly = True
        Me.txtCiudad.Size = New System.Drawing.Size(240, 26)
        Me.txtCiudad.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(536, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 20)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Ciudad"
        '
        'txtNivel
        '
        Me.txtNivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(776, 75)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(72, 26)
        Me.txtNivel.TabIndex = 76
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(600, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 20)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "UL. nivel Acréditado"
        '
        'txtTel
        '
        Me.txtTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(115, 75)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(146, 26)
        Me.txtTel.TabIndex = 74
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(115, 30)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(403, 26)
        Me.txtDomicilio.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Teléfono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 20)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Domicilio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(264, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(225, 55)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Datos de"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminAssistant.My.Resources.Resources.users
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Teal
        Me.Label21.Location = New System.Drawing.Point(482, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(188, 55)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "alumno"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(193, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 20)
        Me.Label22.TabIndex = 75
        Me.Label22.Text = "Nombre"
        '
        'cboNombre
        '
        Me.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(288, 126)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(456, 28)
        Me.cboNombre.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nivel 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(529, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nivel 4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nivel 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(703, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nivel 5"
        '
        'txtNivel12
        '
        Me.txtNivel12.Location = New System.Drawing.Point(467, 93)
        Me.txtNivel12.Name = "txtNivel12"
        Me.txtNivel12.ReadOnly = True
        Me.txtNivel12.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel12.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nivel 6"
        '
        'txtNivel10
        '
        Me.txtNivel10.Location = New System.Drawing.Point(762, 58)
        Me.txtNivel10.Name = "txtNivel10"
        Me.txtNivel10.ReadOnly = True
        Me.txtNivel10.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel10.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nivel 7"
        '
        'txtNivel8
        '
        Me.txtNivel8.Location = New System.Drawing.Point(408, 58)
        Me.txtNivel8.Name = "txtNivel8"
        Me.txtNivel8.ReadOnly = True
        Me.txtNivel8.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel8.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(354, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Nivel 8"
        '
        'txtNivel11
        '
        Me.txtNivel11.Location = New System.Drawing.Point(288, 93)
        Me.txtNivel11.Name = "txtNivel11"
        Me.txtNivel11.ReadOnly = True
        Me.txtNivel11.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel11.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(529, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Nivel 9"
        '
        'txtNivel9
        '
        Me.txtNivel9.Location = New System.Drawing.Point(587, 58)
        Me.txtNivel9.Name = "txtNivel9"
        Me.txtNivel9.ReadOnly = True
        Me.txtNivel9.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel9.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(697, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Nivel 10"
        '
        'txtNivel7
        '
        Me.txtNivel7.Location = New System.Drawing.Point(233, 58)
        Me.txtNivel7.Name = "txtNivel7"
        Me.txtNivel7.ReadOnly = True
        Me.txtNivel7.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel7.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(220, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Nivel 11"
        '
        'txtNivel6
        '
        Me.txtNivel6.Location = New System.Drawing.Point(64, 58)
        Me.txtNivel6.Name = "txtNivel6"
        Me.txtNivel6.ReadOnly = True
        Me.txtNivel6.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel6.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(405, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Nivel 12"
        '
        'txtNivel4
        '
        Me.txtNivel4.Location = New System.Drawing.Point(587, 19)
        Me.txtNivel4.Name = "txtNivel4"
        Me.txtNivel4.ReadOnly = True
        Me.txtNivel4.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel4.TabIndex = 19
        '
        'txtNivel2
        '
        Me.txtNivel2.Location = New System.Drawing.Point(233, 19)
        Me.txtNivel2.Name = "txtNivel2"
        Me.txtNivel2.ReadOnly = True
        Me.txtNivel2.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel2.TabIndex = 18
        '
        'txtNivel5
        '
        Me.txtNivel5.Location = New System.Drawing.Point(759, 19)
        Me.txtNivel5.Name = "txtNivel5"
        Me.txtNivel5.ReadOnly = True
        Me.txtNivel5.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel5.TabIndex = 17
        '
        'txtNivel3
        '
        Me.txtNivel3.Location = New System.Drawing.Point(408, 19)
        Me.txtNivel3.Name = "txtNivel3"
        Me.txtNivel3.ReadOnly = True
        Me.txtNivel3.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel3.TabIndex = 4
        '
        'txtNivel1
        '
        Me.txtNivel1.Location = New System.Drawing.Point(64, 19)
        Me.txtNivel1.Name = "txtNivel1"
        Me.txtNivel1.ReadOnly = True
        Me.txtNivel1.Size = New System.Drawing.Size(95, 22)
        Me.txtNivel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nivel 1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNivel1)
        Me.GroupBox1.Controls.Add(Me.txtNivel3)
        Me.GroupBox1.Controls.Add(Me.txtNivel5)
        Me.GroupBox1.Controls.Add(Me.txtNivel2)
        Me.GroupBox1.Controls.Add(Me.txtNivel4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNivel6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtNivel7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNivel9)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNivel11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNivel8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNivel10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNivel12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(863, 127)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calificaciones en Kardex"
        '
        'frmConsultaIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 539)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboNombre)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtSituacion)
        Me.Controls.Add(Me.lblSit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIDAlumno)
        Me.Controls.Add(Me.lblIDAlumnoN)
        Me.Controls.Add(Me.lblNombreID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultaIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta individual de alumno"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSituacion As TextBox
    Friend WithEvents lblSit As Label
    Friend WithEvents txtIDAlumno As TextBox
    Friend WithEvents lblIDAlumnoN As Label
    Friend WithEvents lblNombreID As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTelEme As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cboNombre As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNivel12 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNivel10 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNivel8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNivel11 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNivel9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNivel7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNivel6 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNivel4 As TextBox
    Friend WithEvents txtNivel2 As TextBox
    Friend WithEvents txtNivel5 As TextBox
    Friend WithEvents txtNivel3 As TextBox
    Friend WithEvents txtNivel1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
