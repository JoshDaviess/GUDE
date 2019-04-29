Public Class Caches
    Dim pagenum As Integer
    Function pageUpdate()
        PageLabel.Text = "Page" + Str(pagenum) + ":"
        If pagenum = 1 Then
            TopLeft.Text = "Collected"
            TopMiddle.Text = "Collected"
            TopRight.Text = "Collected"
        End If
        If pagenum <> 1 Then
            TopLeft.Text = "Uncollected"
            TopMiddle.Text = "Uncollected"
            TopRight.Text = "Uncollected"
        End If
        If pagenum = 5 Then
            showhide2.Show()
        ElseIf pagenum <> 5 Then
            showhide2.Hide()
        End If
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Caches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Distance")
        ComboBox1.Items.Add("Collected")
        ComboBox1.Items.Add("Trophy")
        pagenum = 1
        showorhide.Hide()
        showhide2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main_Screen.Show()
        Me.Hide()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If pagenum < 5 And CheckBox1.Checked = False Then
            pagenum += 1
        End If
        pageUpdate()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If pagenum <> 1 And CheckBox1.Checked = False Then
            pagenum -= 1
        End If
        pageUpdate()
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles PageLabel.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            showorhide.Show()
            pagenum = 1
            pageUpdate()
        ElseIf CheckBox1.Checked = False Then
            showorhide.Hide()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        VideoCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PhotoCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UncollectedCache.Show()
        Me.Hide()
    End Sub
End Class