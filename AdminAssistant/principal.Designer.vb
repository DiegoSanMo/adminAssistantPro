﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPrincipal = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirCicloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscipciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasificarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturarCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCicloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(404, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.AutoSize = False
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        '
        'AlumnosToolStripMenuItem1
        '
        Me.AlumnosToolStripMenuItem1.Name = "AlumnosToolStripMenuItem1"
        Me.AlumnosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem1.Text = "Alumnos"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'CiclosToolStripMenuItem
        '
        Me.CiclosToolStripMenuItem.Name = "CiclosToolStripMenuItem"
        Me.CiclosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiclosToolStripMenuItem.Text = "Ciclos"
        '
        'msPrincipal
        '
        Me.msPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.msPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.msPrincipal.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.msPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msPrincipal.Name = "msPrincipal"
        Me.msPrincipal.Size = New System.Drawing.Size(232, 627)
        Me.msPrincipal.TabIndex = 2
        Me.msPrincipal.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem2, Me.MaestrosToolStripMenuItem1, Me.UsuariosToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'AlumnosToolStripMenuItem2
        '
        Me.AlumnosToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.AlumnosToolStripMenuItem2.Name = "AlumnosToolStripMenuItem2"
        Me.AlumnosToolStripMenuItem2.Size = New System.Drawing.Size(231, 44)
        Me.AlumnosToolStripMenuItem2.Text = "Alumnos"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(230, 44)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KardexToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(230, 44)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'MaestrosToolStripMenuItem1
        '
        Me.MaestrosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem1, Me.ConsultaToolStripMenuItem1})
        Me.MaestrosToolStripMenuItem1.Name = "MaestrosToolStripMenuItem1"
        Me.MaestrosToolStripMenuItem1.Size = New System.Drawing.Size(231, 44)
        Me.MaestrosToolStripMenuItem1.Text = "Maestros"
        '
        'RegistroToolStripMenuItem1
        '
        Me.RegistroToolStripMenuItem1.Name = "RegistroToolStripMenuItem1"
        Me.RegistroToolStripMenuItem1.Size = New System.Drawing.Size(230, 44)
        Me.RegistroToolStripMenuItem1.Text = "Registro"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(230, 44)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem3})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(231, 44)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'RegistroToolStripMenuItem3
        '
        Me.RegistroToolStripMenuItem3.Name = "RegistroToolStripMenuItem3"
        Me.RegistroToolStripMenuItem3.Size = New System.Drawing.Size(216, 44)
        Me.RegistroToolStripMenuItem3.Text = "Registro"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirCicloToolStripMenuItem, Me.AbrirGrupoToolStripMenuItem, Me.InscipciónToolStripMenuItem, Me.ClasificarListasToolStripMenuItem, Me.CapturarCalificacionesToolStripMenuItem, Me.CerrarCicloToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'AbrirCicloToolStripMenuItem
        '
        Me.AbrirCicloToolStripMenuItem.Name = "AbrirCicloToolStripMenuItem"
        Me.AbrirCicloToolStripMenuItem.Size = New System.Drawing.Size(600, 44)
        Me.AbrirCicloToolStripMenuItem.Text = "Abrir ciclo"
        '
        'AbrirGrupoToolStripMenuItem
        '
        Me.AbrirGrupoToolStripMenuItem.Name = "AbrirGrupoToolStripMenuItem"
        Me.AbrirGrupoToolStripMenuItem.Size = New System.Drawing.Size(600, 44)
        Me.AbrirGrupoToolStripMenuItem.Text = "Abrir grupo"
        '
        'InscipciónToolStripMenuItem
        '
        Me.InscipciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem2, Me.ConsultaToolStripMenuItem2})
        Me.InscipciónToolStripMenuItem.Name = "InscipciónToolStripMenuItem"
        Me.InscipciónToolStripMenuItem.Size = New System.Drawing.Size(600, 44)
        Me.InscipciónToolStripMenuItem.Text = "Inscripción"
        '
        'RegistroToolStripMenuItem2
        '
        Me.RegistroToolStripMenuItem2.Name = "RegistroToolStripMenuItem2"
        Me.RegistroToolStripMenuItem2.Size = New System.Drawing.Size(230, 44)
        Me.RegistroToolStripMenuItem2.Text = "Registro"
        '
        'ConsultaToolStripMenuItem2
        '
        Me.ConsultaToolStripMenuItem2.Name = "ConsultaToolStripMenuItem2"
        Me.ConsultaToolStripMenuItem2.Size = New System.Drawing.Size(230, 44)
        Me.ConsultaToolStripMenuItem2.Text = "Consulta"
        '
        'ClasificarListasToolStripMenuItem
        '
        Me.ClasificarListasToolStripMenuItem.Name = "ClasificarListasToolStripMenuItem"
        Me.ClasificarListasToolStripMenuItem.Size = New System.Drawing.Size(600, 44)
        Me.ClasificarListasToolStripMenuItem.Text = "Clasificar por listas"
        '
        'CapturarCalificacionesToolStripMenuItem
        '
        Me.CapturarCalificacionesToolStripMenuItem.Name = "CapturarCalificacionesToolStripMenuItem"
        Me.CapturarCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(600, 44)
        Me.CapturarCalificacionesToolStripMenuItem.Text = "Capturar Calificaciones En Listas"
        '
        'CerrarCicloToolStripMenuItem
        '
        Me.CerrarCicloToolStripMenuItem.Name = "CerrarCicloToolStripMenuItem"
        Me.CerrarCicloToolStripMenuItem.Size = New System.Drawing.Size(600, 44)
        Me.CerrarCicloToolStripMenuItem.Text = "Cerrar ciclo"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(203, 44)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1099, 627)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.msPrincipal)
        Me.MainMenuStrip = Me.msPrincipal
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msPrincipal.ResumeLayout(False)
        Me.msPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msPrincipal As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MaestrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscipciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirCicloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirGrupoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClasificarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarCicloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapturarCalificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RegistroToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents KardexToolStripMenuItem As ToolStripMenuItem
End Class
