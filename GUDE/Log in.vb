Public Class Login
    Public Username As String
    Private Sub Sign_In_Click(sender As Object, e As EventArgs) Handles Sign_In.Click
        If UsernameText.Text <> "" And password.Text <> "" Then
            Username = UsernameText.Text
            Main_Screen.Show()
            Me.Hide()
        End If
        If UsernameText.Text = "" Then
            MsgBox("Please enter a username and password.", 0, "Error!")
        End If
        If password.Text = "" Then
            MsgBox("Please enter a password.", 0, "Error!")
        End If
    End Sub

    Private Sub FB_Sign_Click(sender As Object, e As EventArgs) Handles FB_Sign.Click
        Main_Screen.Show()
        Me.Hide()
    End Sub

    Private Sub Goog_Sign_Click(sender As Object, e As EventArgs) Handles Goog_Sign.Click
        Main_Screen.Show()
        Me.Hide()
    End Sub
End Class