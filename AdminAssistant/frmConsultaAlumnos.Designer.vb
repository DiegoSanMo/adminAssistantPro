<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAlumnos
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.EasyEnglishDataSetMani = New AdminAssistant.EasyEnglishDataSetMani()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnoTableAdapter = New AdminAssistant.EasyEnglishDataSetManiTableAdapters.alumnoTableAdapter()
        Me.IdAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoNivelAcreditadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasyEnglishDataSetMani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAlumnoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.SituacionDataGridViewTextBoxColumn, Me.UltimoNivelAcreditadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(776, 45)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(170, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consulta general"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alumnos"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.SlateBlue
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(650, 293)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 50)
        Me.btnSalir.TabIndex = 68
        Me.btnSalir.Text = "Aceptar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'EasyEnglishDataSetMani
        '
        Me.EasyEnglishDataSetMani.DataSetName = "EasyEnglishDataSetMani"
        Me.EasyEnglishDataSetMani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataMember = "alumno"
        Me.AlumnoBindingSource.DataSource = Me.EasyEnglishDataSetMani
        '
        'AlumnoTableAdapter
        '
        Me.AlumnoTableAdapter.ClearBeforeFill = True
        '
        'IdAlumnoDataGridViewTextBoxColumn
        '
        Me.IdAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.IdAlumnoDataGridViewTextBoxColumn.Name = "IdAlumnoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.Width = 150
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'SituacionDataGridViewTextBoxColumn
        '
        Me.SituacionDataGridViewTextBoxColumn.DataPropertyName = "situacion"
        Me.SituacionDataGridViewTextBoxColumn.HeaderText = "Situacion"
        Me.SituacionDataGridViewTextBoxColumn.Name = "SituacionDataGridViewTextBoxColumn"
        '
        'UltimoNivelAcreditadoDataGridViewTextBoxColumn
        '
        Me.UltimoNivelAcreditadoDataGridViewTextBoxColumn.DataPropertyName = "ultimoNivelAcreditado"
        Me.UltimoNivelAcreditadoDataGridViewTextBoxColumn.HeaderText = "UltimoNivelAcreditado"
        Me.UltimoNivelAcreditadoDataGridViewTextBoxColumn.Name = "UltimoNivelAcreditadoDataGridViewTextBoxColumn"
        '
        'frmConsultaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 355)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaAlumnos"
        Me.Text = "frmConsultaAlumnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasyEnglishDataSetMani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents EasyEnglishDataSetMani As EasyEnglishDataSetMani
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents AlumnoTableAdapter As EasyEnglishDataSetManiTableAdapters.alumnoTableAdapter
    Friend WithEvents IdAlumnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SituacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoNivelAcreditadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
