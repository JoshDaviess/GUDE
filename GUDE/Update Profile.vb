Public Class UpdateProfile
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        MsgBox("Profile Updated.", 0, "Success!")
        Profile.Show()
        Me.Hide()
    End Sub
End Class