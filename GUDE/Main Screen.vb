Public Class Main_Screen
    Private IsDragging As Boolean = False
    Private StartPoint As Point

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        StartPoint = PictureBox1.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If IsDragging Then
            Dim EndPoint As Point = PictureBox1.PointToScreen(New Point(e.X, e.Y))
            PictureBox1.Left += (EndPoint.X - StartPoint.X)
            PictureBox1.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        IsDragging = False
    End Sub

    Private Sub Main_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()
        Welcome.Text = Login.Username
    End Sub
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Login.Show()
        Me.Hide()
        Login.Username = ""
    End Sub

    Private Sub UserProfile_Click(sender As Object, e As EventArgs) Handles UserProfile.Click
        Profile.Show()
        Me.Hide()
    End Sub
End Class