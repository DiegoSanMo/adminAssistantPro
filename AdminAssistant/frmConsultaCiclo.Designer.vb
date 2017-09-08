<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCiclo
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EasyEnglishDataSetMani = New AdminAssistant.EasyEnglishDataSetMani()
        Me.CicloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CicloTableAdapter = New AdminAssistant.EasyEnglishDataSetManiTableAdapters.cicloTableAdapter()
        Me.IdCicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasyEnglishDataSetMani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CicloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(373, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 41)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ciclos"
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
        Me.btnSalir.Location = New System.Drawing.Point(250, 226)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 50)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "Aceptar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCicloDataGridViewTextBoxColumn, Me.AñoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CicloBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 150)
        Me.DataGridView1.TabIndex = 70
        '
        'EasyEnglishDataSetMani
        '
        Me.EasyEnglishDataSetMani.DataSetName = "EasyEnglishDataSetMani"
        Me.EasyEnglishDataSetMani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CicloBindingSource
        '
        Me.CicloBindingSource.DataMember = "ciclo"
        Me.CicloBindingSource.DataSource = Me.EasyEnglishDataSetMani
        '
        'CicloTableAdapter
        '
        Me.CicloTableAdapter.ClearBeforeFill = True
        '
        'IdCicloDataGridViewTextBoxColumn
        '
        Me.IdCicloDataGridViewTextBoxColumn.DataPropertyName = "idCiclo"
        Me.IdCicloDataGridViewTextBoxColumn.HeaderText = "idCiclo"
        Me.IdCicloDataGridViewTextBoxColumn.Name = "IdCicloDataGridViewTextBoxColumn"
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'frmConsultaCiclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 292)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaCiclo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaCiclo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasyEnglishDataSetMani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CicloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EasyEnglishDataSetMani As EasyEnglishDataSetMani
    Friend WithEvents CicloBindingSource As BindingSource
    Friend WithEvents CicloTableAdapter As EasyEnglishDataSetManiTableAdapters.cicloTableAdapter
    Friend WithEvents IdCicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
