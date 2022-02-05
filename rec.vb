Imports System.Data.SqlClient

Public Class rec
    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")
    Dim nsm As String
    Private Sub rec_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim insert As String
        insert = "select name_a from company_data where User_n='" & TextBox1.Text & "' "
        Dim command As New SqlCommand(insert, con)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text

        Label2.Text = command.ExecuteScalar()

        '=======================================
        Dim qu As String
        qu = "select task from task where usid='" & TextBox1.Text & "' "
        Dim com As New SqlCommand(qu, con)
        com.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        Label3.Text = com.ExecuteScalar()

        con.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        hpg.Show()
    End Sub
End Class