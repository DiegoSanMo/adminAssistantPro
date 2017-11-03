<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRespaldarBD
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
        Me.rbtMasterEA = New System.Windows.Forms.RadioButton()
        Me.rbtBDCiclo = New System.Windows.Forms.RadioButton()
        Me.cboNomBDCiclos = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'rbtMasterEA
        '
        Me.rbtMasterEA.AutoSize = True
        Me.rbtMasterEA.Location = New System.Drawing.Point(12, 12)
        Me.rbtMasterEA.Name = "rbtMasterEA"
        Me.rbtMasterEA.Size = New System.Drawing.Size(204, 17)
        Me.rbtMasterEA.TabIndex = 0
        Me.rbtMasterEA.TabStop = True
        Me.rbtMasterEA.Text = "Respaldo de base de datos MasterEA"
        Me.rbtMasterEA.UseVisualStyleBackColor = True
        '
        'rbtBDCiclo
        '
        Me.rbtBDCiclo.AutoSize = True
        Me.rbtBDCiclo.Location = New System.Drawing.Point(12, 50)
        Me.rbtBDCiclo.Name = "rbtBDCiclo"
        Me.rbtBDCiclo.Size = New System.Drawing.Size(183, 17)
        Me.rbtBDCiclo.TabIndex = 1
        Me.rbtBDCiclo.TabStop = True
        Me.rbtBDCiclo.Text = "Respaldo base de datos de ciclo:"
        Me.rbtBDCiclo.UseVisualStyleBackColor = True
        '
        'cboNomBDCiclos
        '
        Me.cboNomBDCiclos.FormattingEnabled = True
        Me.cboNomBDCiclos.Location = New System.Drawing.Point(202, 50)
        Me.cboNomBDCiclos.Name = "cboNomBDCiclos"
        Me.cboNomBDCiclos.Size = New System.Drawing.Size(170, 21)
        Me.cboNomBDCiclos.TabIndex = 2
        Me.cboNomBDCiclos.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(79, 93)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(297, 93)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRespaldarBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 128)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cboNomBDCiclos)
        Me.Controls.Add(Me.rbtBDCiclo)
        Me.Controls.Add(Me.rbtMasterEA)
        Me.Name = "frmRespaldarBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respaldar Base De Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtMasterEA As RadioButton
    Friend WithEvents rbtBDCiclo As RadioButton
    Friend WithEvents cboNomBDCiclos As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
