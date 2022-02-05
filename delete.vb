Imports System.Data.SqlClient
Public Class delete
    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles U_name.Click

    End Subs

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim delete As String
        delete = "delete from company_data where User_n='" & TextBox1.Text & "'"
        Dim command As New SqlCommand(delete, con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Record Deleted Successfuly")
        'Admin.Controls.Clear()
        'InitializeComponent()
        'Admin.Hide()
        'Admin.Refresh()
        'Admin.Show()

        Me.Hide()
    End Sub
End Class