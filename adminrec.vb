Imports System.Data.SqlClient
Public Class adminrec
    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")
    Private Sub adminrec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet14.task' table. You can move, or remove it, as needed.
        Me.TaskTableAdapter1.Fill(Me.ProjectDataSet14.task)
        utb.TabIndex = 1
        otb.TabIndex = 2
        lgn.TabIndex = 3
        Button1.TabIndex = 4
    End Sub

    Private Sub lgn_Click(sender As Object, e As EventArgs) Handles lgn.Click
        If utb.Text = "" Or otb.Text = "" Then
            MessageBox.Show("requires all the fields fill")
        Else
            con.Open()
            Dim command As SqlCommand
            Dim insert As String
            insert = "insert into task values('" & utb.Text & "','" & otb.Text & "')"
            command = New SqlCommand(insert, con)
            command.ExecuteReader()
            con.Close()
            MsgBox("data inserted")
            utb.Clear()
            otb.Clear()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If utb.Text = "" Then

            'Or tb2.Text = "" Or tb4.Text = "" Or TextBox1.Text = ""
            MessageBox.Show("Requires User Field Please")
        Else


            con.Open()
            Dim delete As String
            delete = "delete from task where usid='" & utb.Text & "'"
            Dim command As New SqlCommand(delete, con)
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Tasks Were Deleted Successfuly")

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        hpg.Show()
    End Sub
End Class