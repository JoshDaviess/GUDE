Public Class Profile
    Dim Warning
    Private Sub AccDelete_Click(sender As Object, e As EventArgs) Handles AccDelete.Click
        Warning = MsgBox("Are you sure you want to delete your account?", 4, "Delete Account")
        If Warning = vbYes Then
            MsgBox("Account Deleted.", 0, "Success!")
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Main_Screen.Show()
        Me.Hide()
    End Sub
End Class