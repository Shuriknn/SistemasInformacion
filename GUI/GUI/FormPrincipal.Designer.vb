<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.TimOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnOcultar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOcultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(800, 450)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.White
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(200, 29)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(600, 421)
        Me.PanelFormularios.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.PictureBox3)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 29)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 421)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(0, 253)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 45)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(0, 202)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 45)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FRIDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BALCÓN DE"
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.SystemColors.ControlText
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnOcultar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(800, 29)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'TimOcultarMenu
        '
        Me.TimOcultarMenu.Interval = 1
        '
        'TimMostrarMenu
        '
        Me.TimMostrarMenu.Interval = 1
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.GUI.My.Resources.Resources.menu
        Me.btnMenu.Location = New System.Drawing.Point(146, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(54, 42)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GUI.My.Resources.Resources.Imagen1
        Me.PictureBox3.Location = New System.Drawing.Point(0, 77)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 68)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.GUI.My.Resources.Resources.warehouse
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Inventario"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.GUI.My.Resources.Resources.currency_usd
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ventas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GUI.My.Resources.Resources.silverware
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ordenes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.GUI.My.Resources.Resources.window_restore
        Me.btnMinimizar.Location = New System.Drawing.Point(730, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(32, 26)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = Global.GUI.My.Resources.Resources.window_maximize
        Me.btnMaximizar.Location = New System.Drawing.Point(730, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(32, 26)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnOcultar
        '
        Me.btnOcultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultar.Image = Global.GUI.My.Resources.Resources.window_minimize
        Me.btnOcultar.Location = New System.Drawing.Point(692, 0)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(32, 26)
        Me.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnOcultar.TabIndex = 0
        Me.btnOcultar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = Global.GUI.My.Resources.Resources.close_thick
        Me.btnCerrar.Location = New System.Drawing.Point(768, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "FormPrincipal"
        Me.Opacity = 0.93R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOcultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnOcultar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents TimOcultarMenu As Timer
    Friend WithEvents TimMostrarMenu As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
