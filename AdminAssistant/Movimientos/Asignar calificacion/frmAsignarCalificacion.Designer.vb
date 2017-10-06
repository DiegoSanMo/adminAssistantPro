<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAsignarCalificacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboLista = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgLista = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantAlumnos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboLista
        '
        Me.cboLista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboLista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLista.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLista.FormattingEnabled = True
        Me.cboLista.Location = New System.Drawing.Point(229, 83)
        Me.cboLista.Name = "cboLista"
        Me.cboLista.Size = New System.Drawing.Size(84, 28)
        Me.cboLista.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(147, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No. Lista"
        '
        'dgLista
        '
        Me.dgLista.AllowUserToAddRows = False
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Location = New System.Drawing.Point(6, 326)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.Size = New System.Drawing.Size(735, 247)
        Me.dgLista.TabIndex = 8
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
        Me.btnSalir.Location = New System.Drawing.Point(290, 579)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(171, 50)
        Me.btnSalir.TabIndex = 46
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(750, 76)
        Me.Label22.TabIndex = 71
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(48, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 58)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Captura de "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(341, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(360, 56)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Calificaciones"
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 126)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 18)
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
        Me.txtHMiercoles.Location = New System.Drawing.Point(374, 39)
        Me.txtHMiercoles.Name = "txtHMiercoles"
        Me.txtHMiercoles.Size = New System.Drawing.Size(170, 26)
        Me.txtHMiercoles.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(374, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 18)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Sábado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(374, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 18)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Miércoles"
        '
        'txtHSabado
        '
        Me.txtHSabado.Enabled = False
        Me.txtHSabado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHSabado.Location = New System.Drawing.Point(374, 89)
        Me.txtHSabado.Name = "txtHSabado"
        Me.txtHSabado.Size = New System.Drawing.Size(171, 26)
        Me.txtHSabado.TabIndex = 62
        '
        'txtHViernes
        '
        Me.txtHViernes.Enabled = False
        Me.txtHViernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHViernes.Location = New System.Drawing.Point(186, 89)
        Me.txtHViernes.Name = "txtHViernes"
        Me.txtHViernes.Size = New System.Drawing.Size(170, 26)
        Me.txtHViernes.TabIndex = 56
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(558, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 18)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Jueves"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(186, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 18)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Viernes"
        '
        'txtHJueves
        '
        Me.txtHJueves.Enabled = False
        Me.txtHJueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHJueves.Location = New System.Drawing.Point(558, 39)
        Me.txtHJueves.Name = "txtHJueves"
        Me.txtHJueves.Size = New System.Drawing.Size(170, 26)
        Me.txtHJueves.TabIndex = 60
        '
        'txtHMartes
        '
        Me.txtHMartes.Enabled = False
        Me.txtHMartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHMartes.Location = New System.Drawing.Point(186, 39)
        Me.txtHMartes.Name = "txtHMartes"
        Me.txtHMartes.Size = New System.Drawing.Size(170, 26)
        Me.txtHMartes.TabIndex = 58
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(186, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 18)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Martes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCantAlumnos)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtNivel)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(138, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 78)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del grupo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Cant. alumnos"
        '
        'txtCantAlumnos
        '
        Me.txtCantAlumnos.Enabled = False
        Me.txtCantAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCantAlumnos.Location = New System.Drawing.Point(9, 39)
        Me.txtCantAlumnos.Name = "txtCantAlumnos"
        Me.txtCantAlumnos.Size = New System.Drawing.Size(117, 26)
        Me.txtCantAlumnos.TabIndex = 52
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(213, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(379, 26)
        Me.txtNombre.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(213, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Maestro"
        '
        'txtNivel
        '
        Me.txtNivel.Enabled = False
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNivel.Location = New System.Drawing.Point(148, 39)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(45, 26)
        Me.txtNivel.TabIndex = 58
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(148, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 18)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Nivel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.AdminAssistant.My.Resources.Resources.test
        Me.PictureBox1.Location = New System.Drawing.Point(6, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'frmAsignarCalificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 637)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgLista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLista)
        Me.Name = "frmAsignarCalificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAsignarCalificacion"
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboLista As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgLista As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHLunes As TextBox
    Friend WithEvents txtHMiercoles As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtHSabado As TextBox
    Friend WithEvents txtHViernes As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtHJueves As TextBox
    Friend WithEvents txtHMartes As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCantAlumnos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
