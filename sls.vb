Imports System.Data.SqlClient
Public Class sls
    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")
    Private Sub sls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet7.sale' table. You can move, or remove it, as needed.
        Me.SaleTableAdapter3.Fill(Me.ProjectDataSet7.sale)
        'TODO: This line of code loads data into the 'ProjectDataSet6.sale' table. You can move, or remove it, as needed.
        Me.SaleTableAdapter2.Fill(Me.ProjectDataSet6.sale)
        'TODO: This line of code loads data into the 'ProjectDataSet5.sale' table. You can move, or remove it, as needed.
        Me.SaleTableAdapter1.Fill(Me.ProjectDataSet5.sale)
        'TODO: This line of code loads data into the 'ProjectDataSet3.sale' table. You can move, or remove it, as needed.
        Me.SaleTableAdapter.Fill(Me.ProjectDataSet3.sale)
        tb1.TabIndex = 1
        tb2.TabIndex = 2
        tb4.TabIndex = 3
        TextBox1.TabIndex = 4
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tb1.Text = "" Or tb2.Text = "" Or tb4.Text = "" Then
            MessageBox.Show("requires all the fields fill")
        Else
            con.Open()
            Dim command As SqlCommand
            Dim insert As String
            insert = "insert into sale values('" & tb1.Text & "','" & tb2.Text & "','" & TextBox1.Text & "','" & tb4.Text & "')"
            command = New SqlCommand(insert, con)
            command.ExecuteReader()
            con.Close()
            MsgBox("data inserted")
            tb1.Clear()
            tb2.Clear()
            tb4.Clear()
            TextBox1.Clear()
            DataGridView1.Refresh()
        End If


    End Sub

    Private Sub urtb_TextChanged(sender As Object, e As EventArgs) Handles tb4.TextChanged

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        hpg.Show()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        con.Open()

        Dim com As String = "Select * from company_data"

        Dim Adpt As New SqlDataAdapter(com, con)

        Dim ds As New DataSet()

        Adpt.Fill(ds, "company_data")

        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub delrec_Click(sender As Object, e As EventArgs) Handles delrec.Click
        If tb1.Text = "" Then
            MessageBox.Show("Fill Product ID Please ")

        Else
            con.Open()
            Dim delete As String
            delete = "delete from sale where p_id='" & tb1.Text & "'"
            Dim command As New SqlCommand(delete, con)
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record Deleted Successfuly")
            tb1.Controls.Clear()
            'tb2.Controls.Clear()
            'tb4.Controls.Clear()
            'TextBox1.Controls.Clear()
            InitializeComponent()
            con.Open()
            'Dim delete As String
            'delete = "delete from sale where p_id='" & tb1.Text & "'"
            'Dim command As New SqlCommand(delete, con)
            'command.ExecuteNonQuery()
            'con.Close()
            'MessageBox.Show("Record Deleted Successfuly")





        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        hpg.Show()
    End Sub
End Class