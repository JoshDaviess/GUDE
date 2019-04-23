Public Class Trophy
    Public locations As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Trophies.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        locations = "Trophy"
        FriendProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        locations = "Trophy"
        FriendProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        locations = "Trophy"
        FriendProfile.Show()
        Me.Hide()
    End Sub
End Class