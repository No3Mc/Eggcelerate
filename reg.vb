
Imports System.Data.SqlClient
Public Class reg
    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub


    Private Sub theme(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.Chocolate


        Dim dgp As New Drawing2D.GraphicsPath
        dgp.StartFigure()
        'top left corner
        dgp.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        dgp.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        dgp.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        dgp.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        dgp.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        dgp.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        dgp.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        dgp.CloseFigure()

        obj.Region = New Region(dgp)


    End Sub
    Private Sub reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet2.company_data' table. You can move, or remove it, as needed.
        Me.Company_dataTableAdapter.Fill(Me.ProjectDataSet2.company_data)
        theme(Me)
        urtb.TabIndex = 1
        pstb.TabIndex = 2
        nmtb.TabIndex = 3
        cmtb.TabIndex = 4
        Button3.TabIndex = 5
        Button2.TabIndex = 6
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
        hpg.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hpg.Show()
        Me.Hide()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs)
        If urtb.Text = "" Or cmtb.Text = "" Or urtb.Text = "" Or pstb.Text = "" Then
            MessageBox.Show("requires all the fields fill")
        Else
            con.Open()
            Dim command As SqlCommand
            Dim insert As String
            insert = "insert into company_data values('" & cmtb.Text & "','" & nmtb.Text & "','" & urtb.Text & "','" & pstb.Text & "')"
            command = New SqlCommand(insert, con)
            command.ExecuteReader()
            con.Close()
            MsgBox("data inserted")
            cmtb.Clear()
            nmtb.Clear()
            urtb.Clear()
            pstb.Clear()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub pstb_TextChanged(sender As Object, e As EventArgs) Handles pstb.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles shpass.CheckedChanged

        With shpass


            If .Checked Then
                pstb.UseSystemPasswordChar = False

            Else

                pstb.UseSystemPasswordChar = True


            End If

        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If urtb.Text = "" Or cmtb.Text = "" Or urtb.Text = "" Or pstb.Text = "" Then
            MessageBox.Show("requires all the fields fill")
        Else
            con.Open()
            Dim command As SqlCommand
            Dim insert As String
            insert = "insert into company_data values('" & cmtb.Text & "','" & nmtb.Text & "','" & urtb.Text & "','" & pstb.Text & "')"
            command = New SqlCommand(insert, con)
            command.ExecuteReader()
            con.Close()
            MsgBox("data inserted")
            cmtb.Clear()
            nmtb.Clear()
            urtb.Clear()
            pstb.Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        delete.Show()
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

    Private Sub cmtb_TextChanged(sender As Object, e As EventArgs) Handles cmtb.TextChanged

    End Sub



    Private Sub cmtb_MouseHover(sender As Object, e As EventArgs) Handles cmtb.MouseHover
        cmtb.BackColor = Color.LightGray
    End Sub
    Private Sub cmtb_MouseLeave(sender As Object, e As EventArgs) Handles cmtb.MouseLeave
        cmtb.BackColor = Color.White
    End Sub
    Private Sub cmtb_MouseEnter(sender As Object, e As EventArgs) Handles cmtb.MouseEnter
        cmtb.BackColor = Color.LightGray
    End Sub




    Private Sub nmtb_MouseHover(sender As Object, e As EventArgs) Handles nmtb.MouseHover
        nmtb.BackColor = Color.LightGray
    End Sub
    Private Sub nmtb_MouseLeave(sender As Object, e As EventArgs) Handles nmtb.MouseLeave
        nmtb.BackColor = Color.White
    End Sub
    Private Sub nmtb_MouseEnter(sender As Object, e As EventArgs) Handles nmtb.MouseEnter
        nmtb.BackColor = Color.LightGray
    End Sub


    Private Sub urtb_MouseHover(sender As Object, e As EventArgs) Handles urtb.MouseHover
        urtb.BackColor = Color.LightGray
    End Sub
    Private Sub urtb_MouseLeave(sender As Object, e As EventArgs) Handles urtb.MouseLeave
        urtb.BackColor = Color.White
    End Sub
    Private Sub urtb_MouseEnter(sender As Object, e As EventArgs) Handles urtb.MouseEnter
        urtb.BackColor = Color.LightGray
    End Sub



    Private Sub pstb_MouseHover(sender As Object, e As EventArgs) Handles pstb.MouseHover
        pstb.BackColor = Color.LightGray
    End Sub
    Private Sub pstb_MouseLeave(sender As Object, e As EventArgs) Handles pstb.MouseLeave
        pstb.BackColor = Color.White
    End Sub
    Private Sub pstb_MouseEnter(sender As Object, e As EventArgs) Handles pstb.MouseEnter
        pstb.BackColor = Color.LightGray
    End Sub


End Class