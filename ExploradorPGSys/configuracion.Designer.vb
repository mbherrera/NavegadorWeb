<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configuracion))
        Me.tcConfiguracion = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbPagina = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New System.Windows.Forms.Button()
        Me.tbpassconf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mt4 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mt3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mt2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mt1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbHabilitar = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tcConfiguracion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcConfiguracion
        '
        Me.tcConfiguracion.Controls.Add(Me.TabPage1)
        Me.tcConfiguracion.Location = New System.Drawing.Point(2, 12)
        Me.tcConfiguracion.Name = "tcConfiguracion"
        Me.tcConfiguracion.SelectedIndex = 0
        Me.tcConfiguracion.Size = New System.Drawing.Size(528, 360)
        Me.tcConfiguracion.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tbPagina)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnGuardar1)
        Me.TabPage1.Controls.Add(Me.tbpassconf)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.tbpass)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(520, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configuración del programa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbPagina
        '
        Me.tbPagina.Location = New System.Drawing.Point(202, 238)
        Me.tbPagina.Name = "tbPagina"
        Me.tbPagina.Size = New System.Drawing.Size(187, 20)
        Me.tbPagina.TabIndex = 7
        Me.tbPagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(113, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Página de Inicio"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar1.Location = New System.Drawing.Point(177, 276)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(139, 35)
        Me.btnGuardar1.TabIndex = 8
        Me.btnGuardar1.Text = "Guardar Cambios"
        Me.btnGuardar1.UseVisualStyleBackColor = True
        '
        'tbpassconf
        '
        Me.tbpassconf.Location = New System.Drawing.Point(260, 189)
        Me.tbpassconf.Name = "tbpassconf"
        Me.tbpassconf.Size = New System.Drawing.Size(129, 20)
        Me.tbpassconf.TabIndex = 6
        Me.tbpassconf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbpassconf.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Confirmar contraseña"
        '
        'tbpass
        '
        Me.tbpass.Location = New System.Drawing.Point(260, 163)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.Size = New System.Drawing.Size(129, 20)
        Me.tbpass.TabIndex = 5
        Me.tbpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbpass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contraseña de administrador"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.mt4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mt3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mt2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mt1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbHabilitar)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 137)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bloqueo personalizado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "(*)Solo ingresar la hora."
        '
        'mt4
        '
        Me.mt4.Location = New System.Drawing.Point(271, 85)
        Me.mt4.Mask = "90"
        Me.mt4.Name = "mt4"
        Me.mt4.Size = New System.Drawing.Size(28, 20)
        Me.mt4.TabIndex = 4
        Me.mt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Salida"
        '
        'mt3
        '
        Me.mt3.Location = New System.Drawing.Point(130, 85)
        Me.mt3.Mask = "90"
        Me.mt3.Name = "mt3"
        Me.mt3.Size = New System.Drawing.Size(28, 20)
        Me.mt3.TabIndex = 3
        Me.mt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Entrada colación"
        '
        'mt2
        '
        Me.mt2.Location = New System.Drawing.Point(271, 56)
        Me.mt2.Mask = "90"
        Me.mt2.Name = "mt2"
        Me.mt2.Size = New System.Drawing.Size(28, 20)
        Me.mt2.TabIndex = 2
        Me.mt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Salida colación"
        '
        'mt1
        '
        Me.mt1.Location = New System.Drawing.Point(130, 56)
        Me.mt1.Mask = "90"
        Me.mt1.Name = "mt1"
        Me.mt1.Size = New System.Drawing.Size(28, 20)
        Me.mt1.TabIndex = 1
        Me.mt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Entrada"
        '
        'cbHabilitar
        '
        Me.cbHabilitar.AutoSize = True
        Me.cbHabilitar.Location = New System.Drawing.Point(148, 19)
        Me.cbHabilitar.Name = "cbHabilitar"
        Me.cbHabilitar.Size = New System.Drawing.Size(64, 17)
        Me.cbHabilitar.TabIndex = 0
        Me.cbHabilitar.Text = "Habilitar"
        Me.cbHabilitar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(368, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 35)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(532, 425)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.tcConfiguracion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(548, 464)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(548, 464)
        Me.Name = "configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.tcConfiguracion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcConfiguracion As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mt4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mt3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mt2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mt1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbHabilitar As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents tbpassconf As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbpass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbPagina As System.Windows.Forms.TextBox
End Class
