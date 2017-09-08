<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaMaestros
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaestroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EasyEnglishDataSetMani = New AdminAssistant.EasyEnglishDataSetMani()
        Me.MaestroTableAdapter = New AdminAssistant.EasyEnglishDataSetManiTableAdapters.maestroTableAdapter()
        Me.IdMaestroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelInglesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaestroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasyEnglishDataSetMani, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(909, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 41)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Maestros"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaestroDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CertificadoDataGridViewTextBoxColumn, Me.NivelInglesDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MaestroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(895, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'MaestroBindingSource
        '
        Me.MaestroBindingSource.DataMember = "maestro"
        Me.MaestroBindingSource.DataSource = Me.EasyEnglishDataSetMani
        '
        'EasyEnglishDataSetMani
        '
        Me.EasyEnglishDataSetMani.DataSetName = "EasyEnglishDataSetMani"
        Me.EasyEnglishDataSetMani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaestroTableAdapter
        '
        Me.MaestroTableAdapter.ClearBeforeFill = True
        '
        'IdMaestroDataGridViewTextBoxColumn
        '
        Me.IdMaestroDataGridViewTextBoxColumn.DataPropertyName = "idMaestro"
        Me.IdMaestroDataGridViewTextBoxColumn.HeaderText = "ClaveMaestro"
        Me.IdMaestroDataGridViewTextBoxColumn.Name = "IdMaestroDataGridViewTextBoxColumn"
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
        'CertificadoDataGridViewTextBoxColumn
        '
        Me.CertificadoDataGridViewTextBoxColumn.DataPropertyName = "certificado"
        Me.CertificadoDataGridViewTextBoxColumn.HeaderText = "Certificado"
        Me.CertificadoDataGridViewTextBoxColumn.Name = "CertificadoDataGridViewTextBoxColumn"
        '
        'NivelInglesDataGridViewTextBoxColumn
        '
        Me.NivelInglesDataGridViewTextBoxColumn.DataPropertyName = "nivelIngles"
        Me.NivelInglesDataGridViewTextBoxColumn.HeaderText = "NivelIngles"
        Me.NivelInglesDataGridViewTextBoxColumn.Name = "NivelInglesDataGridViewTextBoxColumn"
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 150
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
        Me.btnSalir.Location = New System.Drawing.Point(790, 204)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 50)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "Aceptar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmConsultaMaestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 262)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaMaestros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaMaestros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaestroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasyEnglishDataSetMani, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EasyEnglishDataSetMani As EasyEnglishDataSetMani
    Friend WithEvents MaestroBindingSource As BindingSource
    Friend WithEvents MaestroTableAdapter As EasyEnglishDataSetManiTableAdapters.maestroTableAdapter
    Friend WithEvents IdMaestroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertificadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NivelInglesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
End Class
