Public Class pass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" Then
            reg.Show()
            Me.Hide()
        End If
        TextBox1.Clear()

    End Sub
End Class