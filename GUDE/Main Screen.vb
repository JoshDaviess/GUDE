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
            Dim newX As Integer
            Dim newY As Integer

            newX = PictureBox1.Left + (EndPoint.X - StartPoint.X)
            newY = PictureBox1.Top + (EndPoint.Y - StartPoint.Y)

            Dim minimumX As Integer
            Dim minimumY As Integer
            minimumX -= PictureBox1.Width - Me.Width + 340
            minimumY -= PictureBox1.Height - Me.Height

            If newX > 0 Then
                PictureBox1.Left = 0
            ElseIf newX < minimumX Then
                PictureBox1.Left = minimumX
            Else
                PictureBox1.Left = newX
            End If

            If newY > 0 Then
                PictureBox1.Top = 0
            ElseIf newY < minimumY Then
                PictureBox1.Top = minimumY
            Else
                PictureBox1.Top = newY
            End If

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

    Private Sub Friends_Click(sender As Object, e As EventArgs) Handles Friends.Click
        Friendsapp.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Trophies.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Caches.Show()
        Me.Hide()
    End Sub
End Class