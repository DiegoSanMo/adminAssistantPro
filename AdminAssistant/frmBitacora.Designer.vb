<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacora
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvBitacora = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clmNoFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmErrorCorrida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFrameDelError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNoLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(958, 59)
        Me.Label2.TabIndex = 3
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvBitacora
        '
        Me.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoFalla, Me.clmErrorCorrida, Me.clmDescripcion, Me.clmFrameDelError, Me.clmNoLinea, Me.clmFecha, Me.clmHora})
        Me.dgvBitacora.Location = New System.Drawing.Point(3, 63)
        Me.dgvBitacora.Name = "dgvBitacora"
        Me.dgvBitacora.Size = New System.Drawing.Size(955, 188)
        Me.dgvBitacora.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(3, 257)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(955, 50)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "Aceptar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(377, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 56)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Bitácora"
        '
        'clmNoFalla
        '
        Me.clmNoFalla.HeaderText = "Número de falla"
        Me.clmNoFalla.Name = "clmNoFalla"
        '
        'clmErrorCorrida
        '
        Me.clmErrorCorrida.HeaderText = "Error de Corrida"
        Me.clmErrorCorrida.Name = "clmErrorCorrida"
        Me.clmErrorCorrida.Width = 200
        '
        'clmDescripcion
        '
        Me.clmDescripcion.HeaderText = "Descripción"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.Width = 200
        '
        'clmFrameDelError
        '
        Me.clmFrameDelError.HeaderText = "Frame del error"
        Me.clmFrameDelError.Name = "clmFrameDelError"
        '
        'clmNoLinea
        '
        Me.clmNoLinea.HeaderText = "Número de línea"
        Me.clmNoLinea.Name = "clmNoLinea"
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        '
        'clmHora
        '
        Me.clmHora.HeaderText = "Hora"
        Me.clmHora.Name = "clmHora"
        '
        'frmBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 317)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvBitacora)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBitacora"
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBitacora As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents clmNoFalla As DataGridViewTextBoxColumn
    Friend WithEvents clmErrorCorrida As DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents clmFrameDelError As DataGridViewTextBoxColumn
    Friend WithEvents clmNoLinea As DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As DataGridViewTextBoxColumn
    Friend WithEvents clmHora As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
