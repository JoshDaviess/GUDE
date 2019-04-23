Public Class FriendProfile
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        If Trophy.locations = "Trophy" Then
            Trophy.Show()
            Me.Hide()
            Trophy.locations = ""
        End If
        If Trophy.locations = "Friends" Then
            Friendsapp.Show()
            Me.Hide()
            Trophy.locations = ""
        End If
    End Sub
End Class