Imports System.Data.SqlClient

Public Class Login

    Dim con As New SqlConnection("Data Source=DESKTOP-IO2QDUM\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True")

    'Public Property FocusColour As Color
    'Public Sub New()
    '    InitializeComponent()
    '    FocusColour = Color.DodgerBlue
    'End Sub
    'Public Sub New(colour As Color)
    '    InitializeComponent()
    '    FocusColour = colour
    'End Sub
    'Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles Usertb.Enter
    '    Me.Usertb.BackColor = FocusColour
    'End Sub
    'Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles Usertb.Leave
    '    Me.Usertb.BackColor = SystemColors.Window
    'End Sub



    Private Sub theme(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.GhostWhite


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click



        Me.Close()
        reg.Close()


    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theme(Me)



    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles shpass.CheckedChanged

        With shpass


            If .Checked Then
                Passtb.UseSystemPasswordChar = False

            Else

                Passtb.UseSystemPasswordChar = True


            End If

        End With



    End Sub

    Private Sub Passtb_TextChanged(sender As Object, e As EventArgs) Handles Passtb.TextChanged

    End Sub

    Private Sub lgn_Click(sender As Object, e As EventArgs) Handles lgn.Click
        con.Open()
        Dim insert As String
        insert = "select * from company_data where User_n='" & Usertb.Text & "' and Pass='" & Passtb.Text & "' "
        Dim command As New SqlCommand(insert, con)


        command.Parameters.Add("@username", SqlDbType.VarChar).Value = Usertb.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Passtb.Text


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Recheck Username And Password ", "Error")
            Usertb.Clear()
            Passtb.Clear()
        Else
            MessageBox.Show("Welcome " & Usertb.Text, "Successful")
            hpg.Show()
            Me.Hide()
        End If

        con.Close()




    End Sub




    'Private Sub LoginForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    '    If Not  Then
    '        Dim result1 As DialogResult = MessageBox.Show("Do you want to close?",
    '                            "On FormClosing event",
    '                            MessageBoxButtons.YesNo)

    '        If result1 = Windows.Forms.DialogResult.No Then
    '            e.Cancel = True
    '            MsgBox("Form is NOT closing or exiting application")
    '        Else
    '            MsgBox("Logging Off Now")
    '            'LogOff() will be executed here
    '        End If
    '    End If

    'End Sub
    Private Sub Usertb_TextChanged(sender As Object, e As EventArgs) Handles Usertb.TextChanged

    End Sub

    Private Sub shpass1_CheckedChanged(sender As Object, e As EventArgs) Handles shpass1.CheckedChanged

    End Sub
End Class
