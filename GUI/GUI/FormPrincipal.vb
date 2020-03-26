Public Class FormPrincipal
#Region "Funciones del formulario"
    Private mouseDowns As Boolean
    Private lastLocation As Point
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                    >= (Me.ClientSize.Width - cGrip)) _
                    AndAlso (pos.Y _
                    >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.White)
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    Private Sub PanelBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseDown
        mouseDowns = True
        lastLocation = e.Location
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        If mouseDowns Then
            Me.Location = New Point(
                (Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)

            Me.Update()
        End If
    End Sub

    Private Sub PanelBarraTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseUp
        mouseDowns = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

        btnMaximizar.Visible = False
        btnMinimizar.Visible = True

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnMinimizar.Visible = False

    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TimOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TimOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.TimOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub TimMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TimMostrarMenu.Tick
        If PanelMenu.Width >= 200 Then
            Me.TimMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 200 Then
            TimOcultarMenu.Enabled = True
        Else
            TimMostrarMenu.Enabled = True
        End If

    End Sub
#End Region
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Of Form1)()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Of Form2)()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(Of Form3)()

    End Sub
End Class
