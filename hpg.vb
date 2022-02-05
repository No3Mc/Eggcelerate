


Public Class hpg




    Private Sub hpg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''oval form(custom)
        'Dim ovl As New Drawing2D.GraphicsPath
        'ovl.AddEllipse(-17, -17, 65, 65)

        ''buttons changed to custom

        'slsim.Region = New Region(ovl)
        'prchz.Region = New Region(ovl)
        'cntcs.Region = New Region(ovl)
        ''notes.Region = New Region(ovl)
        ' theme(Me)


    End Sub

    Private Sub hpg_TCP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.Close()
        'MessageBox.Show("Do you want to close this PSM?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'If DialogResult.Yes Then
        '    Application.Exit()
        'End If
        'If DialogResult.No Then

        'End If








        If (MessageBox.Show("Are you sure you want to close", "Exit?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then

            e.Cancel = True






            'Return
            'Application.Exit()
            'Environment.Exit(exitCode:=0)
            'Application.Exit()
            'Me.Close()
        ElseIf DialogResult.Yes Then
            'e.Cancel = True
            Application.Exit()
        End If






        'Select Case MsgBox("Your Message", MsgBoxStyle.YesNo, "caption")
        '    Case MsgBoxResult.Yes
        '        MessageBox.Show("Yes button")
        '    'Case MsgBoxResult.Cancel
        '    '    MessageBox.Show("Cancel button")
        '    Case MsgBoxResult.No
        '        'MessageBox.Show("NO button")
        '        MsgBox.close()




        '    Me.Show()
        'End If








    End Sub




    'sales
    Private Sub slsim_Click(sender As Object, e As EventArgs) Handles slsim.Click
        adminrec.Hide()
        rec.Hide()
        prchez.Hide()
        Dim sls As New sls()
        sls.TopLevel = False
        sls.TopMost = True
        Panel1.Controls.Add(sls)
        sls.Show()
        ''oval form(custom)
        'Dim reovl As New Drawing2D.GraphicsPath
        ''(-14, -14, 75, 75) better view
        'reovl.AddEllipse(-14, -14, 75, 75)
        'slsim.Region = New Region(reovl)


    End Sub

    'clicks


    Private Sub slslbl_Click(sender As Object, e As EventArgs) Handles slslbl.Click




    End Sub

    Private Sub prchz_Click(sender As Object, e As EventArgs) Handles prchz.Click
        adminrec.Close()
        rec.Hide()
        sls.Hide()
        Dim pr As New prchez()
        pr.TopLevel = False
        pr.TopMost = True
        Panel1.Controls.Add(pr)
        pr.Show()

    End Sub




    Private Sub cntcs_Click(sender As Object, e As EventArgs) Handles cntcs.Click
        'it doesn't work as it does in sales one(sls)
        ''oval form(custom)
        'Dim reovlp As New Drawing2D.GraphicsPath
        ''(-14, -14, 75, 75) better view
        'reovlp.AddEllipse(-14, -14, 75, 75)
        'cntcs.Region = New Region(reovlp)
        pass.Show()

    End Sub



    Private Sub nts_Click(sender As Object, e As EventArgs) Handles nts.Click
        rec.Hide()
        sls.Hide()
        prchez.Hide()
        Dim ar As New adminrec()
        ar.TopLevel = False
        ar.TopMost = True
        Panel1.Controls.Add(ar)
        ar.Show()

    End Sub

    Private Sub hme_Click(sender As Object, e As EventArgs)
        'hom.Show()
        'hpg.Show()
    End Sub

    Private Sub lgout_Click(sender As Object, e As EventArgs) Handles lgout.Click

        Me.Close()
        Login.Close()
        reg.Close()


    End Sub





    'images
    'abt sales image
    Private Sub slsim_MouseHover(sender As Object, e As EventArgs) Handles slsim.MouseHover
        With slsim
            slsim.BackColor = Color.LightSeaGreen
        End With
    End Sub
    Private Sub slsim_MouseLeave(sender As Object, e As EventArgs) Handles slsim.MouseLeave
        slsim.BackColor = Color.SteelBlue
    End Sub
    Private Sub slsim_MouseEnter(sender As Object, e As EventArgs) Handles slsim.MouseEnter
        slsim.BackColor = Color.LightSeaGreen
    End Sub





    'abt purchases
    Private Sub prchz_MouseHover(sender As Object, e As EventArgs) Handles prchz.MouseHover
        prchz.BackColor = Color.LightSeaGreen
    End Sub
    Private Sub prchz_MouseLeave(sender As Object, e As EventArgs) Handles prchz.MouseLeave
        prchz.BackColor = Color.SteelBlue
    End Sub
    Private Sub prchz_MouseEnter(sender As Object, e As EventArgs) Handles prchz.MouseEnter
        prchz.BackColor = Color.LightSeaGreen
    End Sub




    'about contacts
    Private Sub cntcs_MouseHover(sender As Object, e As EventArgs) Handles cntcs.MouseHover
        cntcs.BackColor = Color.LightSeaGreen
    End Sub
    Private Sub cntcs_MouseLeave(sender As Object, e As EventArgs) Handles cntcs.MouseLeave
        cntcs.BackColor = Color.SteelBlue
    End Sub
    Private Sub cntcs_MouseEnter(sender As Object, e As EventArgs) Handles cntcs.MouseEnter
        cntcs.BackColor = Color.LightSeaGreen
    End Sub



    'about notes

    Private Sub nts_mousehover(sender As Object, e As EventArgs) Handles nts.MouseHover
        nts.BackColor = Color.LightSeaGreen
    End Sub
    Private Sub nts_mouseleave(sender As Object, e As EventArgs) Handles nts.MouseLeave
        nts.BackColor = Color.SteelBlue
    End Sub
    Private Sub nts_mouseenter(sender As Object, e As EventArgs) Handles nts.MouseEnter
        nts.BackColor = Color.LightSeaGreen
    End Sub

    'abt logout

    Private Sub lgout_MouseHover(sender As Object, e As EventArgs) Handles lgout.MouseHover
        With lgout
            lgout.BackColor = Color.Red
        End With
    End Sub
    Private Sub lgout_MouseLeave(sender As Object, e As EventArgs) Handles lgout.MouseLeave
        lgout.BackColor = Color.SteelBlue
    End Sub
    Private Sub lgout_MouseEnter(sender As Object, e As EventArgs) Handles lgout.MouseEnter
        lgout.BackColor = Color.Red
    End Sub

    'abt close



    'abt home

    'Private Sub hme_mousehover(sender As Object, e As EventArgs)
    '    hme.BackColor = Color.MidnightBlue
    'End Sub
    'Private Sub hme_mouseleave(sender As Object, e As EventArgs)
    '    hme.BackColor = Color.DimGray
    'End Sub
    'Private Sub hme_mouseenter(sender As Object, e As EventArgs)
    '    hme.BackColor = Color.MidnightBlue
    'End Sub


    'labels
    'sales

    Private Sub slslbl_mousehover(sender As Object, e As EventArgs) Handles slslbl.MouseHover
        slslbl.BackColor = Color.IndianRed
    End Sub
    Private Sub slslbl_mouseleave(sender As Object, e As EventArgs) Handles slslbl.MouseLeave
        slslbl.BackColor = Color.SteelBlue
    End Sub
    Private Sub slslbl_mouseenter(sender As Object, e As EventArgs) Handles slslbl.MouseEnter
        slslbl.BackColor = Color.IndianRed
    End Sub



    Private Sub prchzlbl_mousehover(sender As Object, e As EventArgs) Handles prchzlbl.MouseHover
        prchzlbl.BackColor = Color.IndianRed
    End Sub
    Private Sub prchzlbl_mouseleave(sender As Object, e As EventArgs) Handles prchzlbl.MouseLeave
        prchzlbl.BackColor = Color.SteelBlue
    End Sub
    Private Sub prchzlbl_mouseenter(sender As Object, e As EventArgs) Handles prchzlbl.MouseEnter
        prchzlbl.BackColor = Color.IndianRed
    End Sub




    Private Sub cntcslbl_mousehover(sender As Object, e As EventArgs) Handles cntcslbl.MouseHover
        cntcslbl.BackColor = Color.IndianRed
    End Sub
    Private Sub cntcslbl_mouseleave(sender As Object, e As EventArgs) Handles cntcslbl.MouseLeave
        cntcslbl.BackColor = Color.SteelBlue
    End Sub
    Private Sub cntcslbl_mouseenter(sender As Object, e As EventArgs) Handles cntcslbl.MouseEnter
        cntcslbl.BackColor = Color.IndianRed
    End Sub



    Private Sub ntslbl_mousehover(sender As Object, e As EventArgs) Handles ntslbl.MouseHover
        ntslbl.BackColor = Color.IndianRed
    End Sub
    Private Sub ntslbl_mouseleave(sender As Object, e As EventArgs) Handles ntslbl.MouseLeave
        ntslbl.BackColor = Color.SteelBlue
    End Sub
    Private Sub ntslbl_mouseenter(sender As Object, e As EventArgs) Handles ntslbl.MouseEnter
        ntslbl.BackColor = Color.IndianRed
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        adminrec.Hide()
        sls.Hide()
        'cntcs.Hide()
        prchez.Hide()
        Dim rec As New rec()
        rec.TopLevel = False
        rec.TopMost = True
        Panel1.Controls.Add(rec)
        rec.Show()
    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        With slsim
            PictureBox1.BackColor = Color.LightSeaGreen
        End With
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.SteelBlue
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub prchzlbl_Click(sender As Object, e As EventArgs) Handles prchzlbl.Click

    End Sub

    Private Sub cntcslbl_Click(sender As Object, e As EventArgs) Handles cntcslbl.Click
        pass.Show()
    End Sub

    Private Sub ntslbl_Click(sender As Object, e As EventArgs) Handles ntslbl.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub WorkDueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkDueToolStripMenuItem.Click
        adminrec.Hide()
        sls.Hide()
        'cntcs.Hide()
        prchez.Hide()
        Dim rec As New rec()
        rec.TopLevel = False
        rec.TopMost = True
        Panel1.Controls.Add(rec)
        rec.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        adminrec.Hide()
        rec.Hide()
        prchez.Hide()
        Dim sls As New sls()
        sls.TopLevel = False
        sls.TopMost = True
        Panel1.Controls.Add(sls)
        sls.Show()
        ''oval form(custom)
        'Dim reovl As New Drawing2D.GraphicsPath
        ''(-14, -14, 75, 75) better view
        'reovl.AddEllipse(-14, -14, 75, 75)
        'slsim.Region = New Region(reovl)
    End Sub

    Private Sub PurchasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem.Click
        adminrec.Close()
        rec.Hide()
        sls.Hide()
        Dim pr As New prchez()
        pr.TopLevel = False
        pr.TopMost = True
        Panel1.Controls.Add(pr)
        pr.Show()
    End Sub

    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem.Click
        pass.Show()
    End Sub

    Private Sub NotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotesToolStripMenuItem.Click
        rec.Hide()
        sls.Hide()
        prchez.Hide()
        Dim ar As New adminrec()
        ar.TopLevel = False
        ar.TopMost = True
        Panel1.Controls.Add(ar)
        ar.Show()
    End Sub




    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Show()
    End Sub


End Class