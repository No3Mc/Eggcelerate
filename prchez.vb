Imports System.Data.SqlClient
Public Class prchez
    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")
    Private Sub prchez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet8.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.ProjectDataSet8.purchase)

        tb1.TabIndex = 1
        tb2.TabIndex = 2
        tb4.TabIndex = 3
        TextBox1.TabIndex = 4
        TextBox2.TabIndex = 5
        Button1.TabIndex = 7

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tb1.Text = "" Or tb2.Text = "" Or tb4.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("requires all the fields fill")
        Else
            con.Open()
            Dim command As SqlCommand
            Dim insert As String
            insert = "insert into purchase values('" & tb1.Text & "','" & tb2.Text & "','" & tb4.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')"
            command = New SqlCommand(insert, con)
            command.ExecuteReader()
            con.Close()
            MsgBox("data inserted")
            tb4.Clear()
            tb1.Clear()
            tb2.Clear()
            TextBox2.Clear()
            TextBox1.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb1.Text = "" Then

            'Or tb2.Text = "" Or tb4.Text = "" Or TextBox1.Text = ""
            MessageBox.Show("requires all the fields fill")
        Else
            con.Open()
        Dim delete As String
        delete = "delete from purchase where p_id='" & tb1.Text & "'"
        Dim command As New SqlCommand(delete, con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Record Deleted Successfuly")
            'tb1.Controls.Clear()
            'tb2.Controls.Clear()
            'tb4.Controls.Clear()
            'TextBox1.Controls.Clear()
            InitializeComponent()

        '.Refresh()


        End If






    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        hpg.Show()
    End Sub
End Class