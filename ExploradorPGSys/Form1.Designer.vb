<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class explorador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(explorador))
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.MenuPestanas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbPermitidos = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesactivarModoProtegidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdministrarSitiosPermitidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfiguraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercadeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barraestado = New System.Windows.Forms.StatusStrip()
        Me.bpcarga = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Menubrowser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirEnUnaNuevaPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnIr = New System.Windows.Forms.Button()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.MenuPestanas.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.barraestado.SuspendLayout()
        Me.Menubrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcTabs
        '
        Me.tcTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcTabs.ContextMenuStrip = Me.MenuPestanas
        Me.tcTabs.Location = New System.Drawing.Point(0, 43)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(1009, 666)
        Me.tcTabs.TabIndex = 7
        '
        'MenuPestanas
        '
        Me.MenuPestanas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPestañaToolStripMenuItem, Me.EliminarPestañaToolStripMenuItem, Me.ActualizarToolStripMenuItem})
        Me.MenuPestanas.Name = "MenuPestanas"
        Me.MenuPestanas.Size = New System.Drawing.Size(153, 70)
        '
        'NuevaPestañaToolStripMenuItem
        '
        Me.NuevaPestañaToolStripMenuItem.Name = "NuevaPestañaToolStripMenuItem"
        Me.NuevaPestañaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña"
        '
        'EliminarPestañaToolStripMenuItem
        '
        Me.EliminarPestañaToolStripMenuItem.Name = "EliminarPestañaToolStripMenuItem"
        Me.EliminarPestañaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarPestañaToolStripMenuItem.Text = "Cerrar Pestaña"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'cbPermitidos
        '
        Me.cbPermitidos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbPermitidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPermitidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPermitidos.FormattingEnabled = True
        Me.cbPermitidos.Location = New System.Drawing.Point(820, 8)
        Me.cbPermitidos.MaxDropDownItems = 20
        Me.cbPermitidos.Name = "cbPermitidos"
        Me.cbPermitidos.Size = New System.Drawing.Size(179, 28)
        Me.cbPermitidos.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(140, 40)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator3, Me.ExportarToolStripMenuItem, Me.ImportarToolStripMenuItem, Me.ToolStripSeparator4, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ArchivoToolStripMenuItem.Image = CType(resources.GetObject("ArchivoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArchivoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(44, 36)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        Me.ArchivoToolStripMenuItem.ToolTipText = "Archivo"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(126, 6)
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = CType(resources.GetObject("ExportarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar..."
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Image = CType(resources.GetObject("ImportarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(126, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.AutoToolTip = True
        Me.ConfiguraciónToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesactivarModoProtegidoToolStripMenuItem, Me.ToolStripSeparator1, Me.AdministrarSitiosPermitidosToolStripMenuItem, Me.ToolStripSeparator2, Me.ConfiguraciónToolStripMenuItem1})
        Me.ConfiguraciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ConfiguraciónToolStripMenuItem.Image = CType(resources.GetObject("ConfiguraciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfiguraciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(44, 36)
        Me.ConfiguraciónToolStripMenuItem.ToolTipText = "Configuración"
        '
        'DesactivarModoProtegidoToolStripMenuItem
        '
        Me.DesactivarModoProtegidoToolStripMenuItem.Image = CType(resources.GetObject("DesactivarModoProtegidoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DesactivarModoProtegidoToolStripMenuItem.Name = "DesactivarModoProtegidoToolStripMenuItem"
        Me.DesactivarModoProtegidoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DesactivarModoProtegidoToolStripMenuItem.Text = "Desactivar modo protegido"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(224, 6)
        '
        'AdministrarSitiosPermitidosToolStripMenuItem
        '
        Me.AdministrarSitiosPermitidosToolStripMenuItem.Image = CType(resources.GetObject("AdministrarSitiosPermitidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdministrarSitiosPermitidosToolStripMenuItem.Name = "AdministrarSitiosPermitidosToolStripMenuItem"
        Me.AdministrarSitiosPermitidosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdministrarSitiosPermitidosToolStripMenuItem.Text = "Administrar Sitios Permitidos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'ConfiguraciónToolStripMenuItem1
        '
        Me.ConfiguraciónToolStripMenuItem1.Image = CType(resources.GetObject("ConfiguraciónToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ConfiguraciónToolStripMenuItem1.Name = "ConfiguraciónToolStripMenuItem1"
        Me.ConfiguraciónToolStripMenuItem1.Size = New System.Drawing.Size(227, 22)
        Me.ConfiguraciónToolStripMenuItem1.Text = "Configuración"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactarToolStripMenuItem1, Me.toolStripSeparator11, Me.AcercadeToolStripMenuItem2})
        Me.AyudaToolStripMenuItem1.Image = CType(resources.GetObject("AyudaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(44, 36)
        '
        'ContactarToolStripMenuItem1
        '
        Me.ContactarToolStripMenuItem1.Image = CType(resources.GetObject("ContactarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ContactarToolStripMenuItem1.Name = "ContactarToolStripMenuItem1"
        Me.ContactarToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ContactarToolStripMenuItem1.Text = "Contactar con PGSys"
        '
        'toolStripSeparator11
        '
        Me.toolStripSeparator11.Name = "toolStripSeparator11"
        Me.toolStripSeparator11.Size = New System.Drawing.Size(181, 6)
        '
        'AcercadeToolStripMenuItem2
        '
        Me.AcercadeToolStripMenuItem2.Name = "AcercadeToolStripMenuItem2"
        Me.AcercadeToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.AcercadeToolStripMenuItem2.Text = "&Acerca de..."
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(756, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sitios"
        '
        'barraestado
        '
        Me.barraestado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bpcarga, Me.ToolStripStatusLabel1})
        Me.barraestado.Location = New System.Drawing.Point(0, 708)
        Me.barraestado.Name = "barraestado"
        Me.barraestado.Size = New System.Drawing.Size(1008, 22)
        Me.barraestado.TabIndex = 17
        Me.barraestado.Text = "StatusStrip1"
        '
        'bpcarga
        '
        Me.bpcarga.Name = "bpcarga"
        Me.bpcarga.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Menubrowser
        '
        Me.Menubrowser.BackColor = System.Drawing.Color.Gainsboro
        Me.Menubrowser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirEnUnaNuevaPestañaToolStripMenuItem, Me.AbrirEnUnaNuevaVentanaToolStripMenuItem})
        Me.Menubrowser.Name = "Menubrowser"
        Me.Menubrowser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menubrowser.Size = New System.Drawing.Size(220, 48)
        '
        'AbrirEnUnaNuevaPestañaToolStripMenuItem
        '
        Me.AbrirEnUnaNuevaPestañaToolStripMenuItem.Name = "AbrirEnUnaNuevaPestañaToolStripMenuItem"
        Me.AbrirEnUnaNuevaPestañaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AbrirEnUnaNuevaPestañaToolStripMenuItem.Text = "Abrir en una nueva pestaña"
        '
        'AbrirEnUnaNuevaVentanaToolStripMenuItem
        '
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Name = "AbrirEnUnaNuevaVentanaToolStripMenuItem"
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Text = "Abrir en una nueva ventana"
        '
        'btnHome
        '
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(311, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(47, 26)
        Me.btnHome.TabIndex = 23
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(258, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(47, 26)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSiguiente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(200, 5)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(47, 26)
        Me.btnSiguiente.TabIndex = 21
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(147, 5)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(47, 26)
        Me.btnAtras.TabIndex = 20
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnIr
        '
        Me.btnIr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIr.ForeColor = System.Drawing.Color.Black
        Me.btnIr.Image = CType(resources.GetObject("btnIr.Image"), System.Drawing.Image)
        Me.btnIr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIr.Location = New System.Drawing.Point(687, 5)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(52, 26)
        Me.btnIr.TabIndex = 19
        Me.btnIr.Text = "Ir"
        Me.btnIr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIr.UseVisualStyleBackColor = True
        '
        'tbDireccion
        '
        Me.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(364, 7)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(317, 22)
        Me.tbDireccion.TabIndex = 18
        Me.tbDireccion.Text = "http://"
        '
        'bwCargar
        '
        '
        'explorador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnIr)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.barraestado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPermitidos)
        Me.Controls.Add(Me.tcTabs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "explorador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navegador Asa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuPestanas.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.barraestado.ResumeLayout(False)
        Me.barraestado.PerformLayout()
        Me.Menubrowser.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcTabs As System.Windows.Forms.TabControl
    Friend WithEvents cbPermitidos As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DesactivarModoProtegidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarSitiosPermitidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barraestado As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bpcarga As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Menubrowser As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirEnUnaNuevaPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirEnUnaNuevaVentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPestanas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnIr As System.Windows.Forms.Button
    Friend WithEvents tbDireccion As System.Windows.Forms.TextBox
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercadeToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker

End Class
