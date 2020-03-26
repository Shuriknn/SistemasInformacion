Public Class Form1

    Private mouseDowns As Boolean
    Private lastLocation As Point


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()

    End Sub

    Private Sub txtuser_Enter(sender As Object, e As EventArgs) Handles txtuser.Enter
        If (txtuser.Text = "Usuario") Then
            txtuser.Clear()
            txtuser.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtuser_Leave(sender As Object, e As EventArgs) Handles txtuser.Leave
        If (txtuser.Text = "") Then
            txtuser.Text = "Usuario"
            txtuser.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtpass_Enter(sender As Object, e As EventArgs) Handles txtpass.Enter
        If (txtpass.Text = "Contraseña") Then
            txtpass.Clear()
            txtpass.ForeColor = Color.LightGray
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        If (txtpass.Text = "") Then
            txtpass.Text = "Contraseña"
            txtpass.ForeColor = Color.DimGray
            txtpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        mouseDowns = True
        lastLocation = e.Location
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mouseDowns Then
            Me.Location = New Point(
                (Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)

            Me.Update()
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        mouseDowns = False
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        mouseDowns = True
        lastLocation = e.Location
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If mouseDowns Then
            Me.Location = New Point(
                (Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)

            Me.Update()
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        mouseDowns = False
    End Sub
End Class
