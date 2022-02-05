<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hpg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hpg))
        Me.slslbl = New System.Windows.Forms.Label()
        Me.prchzlbl = New System.Windows.Forms.Label()
        Me.cntcslbl = New System.Windows.Forms.Label()
        Me.ntslbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nts = New System.Windows.Forms.PictureBox()
        Me.cntcs = New System.Windows.Forms.PictureBox()
        Me.prchz = New System.Windows.Forms.PictureBox()
        Me.slsim = New System.Windows.Forms.PictureBox()
        Me.lgout = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkDueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cntcs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prchz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slsim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lgout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'slslbl
        '
        Me.slslbl.AutoSize = True
        Me.slslbl.BackColor = System.Drawing.Color.SteelBlue
        Me.slslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slslbl.Location = New System.Drawing.Point(36, 473)
        Me.slslbl.Name = "slslbl"
        Me.slslbl.Size = New System.Drawing.Size(96, 37)
        Me.slslbl.TabIndex = 1
        Me.slslbl.Text = "Sales"
        '
        'prchzlbl
        '
        Me.prchzlbl.AutoSize = True
        Me.prchzlbl.BackColor = System.Drawing.Color.SteelBlue
        Me.prchzlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prchzlbl.Location = New System.Drawing.Point(36, 684)
        Me.prchzlbl.Name = "prchzlbl"
        Me.prchzlbl.Size = New System.Drawing.Size(168, 37)
        Me.prchzlbl.TabIndex = 3
        Me.prchzlbl.Text = "Purchases"
        '
        'cntcslbl
        '
        Me.cntcslbl.AutoSize = True
        Me.cntcslbl.BackColor = System.Drawing.Color.SteelBlue
        Me.cntcslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cntcslbl.Location = New System.Drawing.Point(36, 895)
        Me.cntcslbl.Name = "cntcslbl"
        Me.cntcslbl.Size = New System.Drawing.Size(144, 37)
        Me.cntcslbl.TabIndex = 5
        Me.cntcslbl.Text = "Contacts"
        '
        'ntslbl
        '
        Me.ntslbl.AutoSize = True
        Me.ntslbl.BackColor = System.Drawing.Color.SteelBlue
        Me.ntslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntslbl.Location = New System.Drawing.Point(36, 1106)
        Me.ntslbl.Name = "ntslbl"
        Me.ntslbl.Size = New System.Drawing.Size(101, 37)
        Me.ntslbl.TabIndex = 8
        Me.ntslbl.Text = "Notes"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(240, 1421)
        Me.DataGridView1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Work Due"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'nts
        '
        Me.nts.BackColor = System.Drawing.Color.SteelBlue
        Me.nts.Image = CType(resources.GetObject("nts.Image"), System.Drawing.Image)
        Me.nts.Location = New System.Drawing.Point(45, 972)
        Me.nts.Name = "nts"
        Me.nts.Size = New System.Drawing.Size(95, 90)
        Me.nts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nts.TabIndex = 7
        Me.nts.TabStop = False
        '
        'cntcs
        '
        Me.cntcs.BackColor = System.Drawing.Color.SteelBlue
        Me.cntcs.Image = CType(resources.GetObject("cntcs.Image"), System.Drawing.Image)
        Me.cntcs.Location = New System.Drawing.Point(40, 760)
        Me.cntcs.Name = "cntcs"
        Me.cntcs.Size = New System.Drawing.Size(104, 90)
        Me.cntcs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cntcs.TabIndex = 4
        Me.cntcs.TabStop = False
        '
        'prchz
        '
        Me.prchz.BackColor = System.Drawing.Color.SteelBlue
        Me.prchz.Image = CType(resources.GetObject("prchz.Image"), System.Drawing.Image)
        Me.prchz.Location = New System.Drawing.Point(45, 548)
        Me.prchz.Name = "prchz"
        Me.prchz.Size = New System.Drawing.Size(95, 90)
        Me.prchz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.prchz.TabIndex = 2
        Me.prchz.TabStop = False
        '
        'slsim
        '
        Me.slsim.BackColor = System.Drawing.Color.SteelBlue
        Me.slsim.Image = CType(resources.GetObject("slsim.Image"), System.Drawing.Image)
        Me.slsim.Location = New System.Drawing.Point(45, 336)
        Me.slsim.Name = "slsim"
        Me.slsim.Size = New System.Drawing.Size(95, 90)
        Me.slsim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.slsim.TabIndex = 0
        Me.slsim.TabStop = False
        '
        'lgout
        '
        Me.lgout.BackColor = System.Drawing.Color.SteelBlue
        Me.lgout.Image = CType(resources.GetObject("lgout.Image"), System.Drawing.Image)
        Me.lgout.Location = New System.Drawing.Point(55, 1278)
        Me.lgout.Name = "lgout"
        Me.lgout.Size = New System.Drawing.Size(95, 89)
        Me.lgout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lgout.TabIndex = 10
        Me.lgout.TabStop = False
        Me.lgout.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2894, 33)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkDueToolStripMenuItem, Me.SalesToolStripMenuItem, Me.PurchasesToolStripMenuItem, Me.ContactsToolStripMenuItem, Me.NotesToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(118, 29)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'WorkDueToolStripMenuItem
        '
        Me.WorkDueToolStripMenuItem.Name = "WorkDueToolStripMenuItem"
        Me.WorkDueToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.WorkDueToolStripMenuItem.Size = New System.Drawing.Size(302, 34)
        Me.WorkDueToolStripMenuItem.Text = "Work Due"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(302, 34)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(302, 34)
        Me.PurchasesToolStripMenuItem.Text = "Purchases"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(302, 34)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'NotesToolStripMenuItem
        '
        Me.NotesToolStripMenuItem.Name = "NotesToolStripMenuItem"
        Me.NotesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.NotesToolStripMenuItem.Size = New System.Drawing.Size(302, 34)
        Me.NotesToolStripMenuItem.Text = "Notes"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(302, 34)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 64)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "About"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(852, 87)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Poultry Sales Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(238, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2656, 1385)
        Me.Panel1.TabIndex = 16
        '
        'hpg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1873, 993)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lgout)
        Me.Controls.Add(Me.ntslbl)
        Me.Controls.Add(Me.cntcslbl)
        Me.Controls.Add(Me.prchzlbl)
        Me.Controls.Add(Me.slslbl)
        Me.Controls.Add(Me.nts)
        Me.Controls.Add(Me.cntcs)
        Me.Controls.Add(Me.prchz)
        Me.Controls.Add(Me.slsim)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "hpg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poultry Sales Management (PSM)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cntcs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prchz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slsim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lgout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents slsim As PictureBox
    Friend WithEvents slslbl As Label
    Friend WithEvents prchz As PictureBox
    Friend WithEvents prchzlbl As Label
    Friend WithEvents cntcs As PictureBox
    Friend WithEvents cntcslbl As Label
    Friend WithEvents nts As PictureBox
    Friend WithEvents ntslbl As Label
    Friend WithEvents lgout As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkDueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
