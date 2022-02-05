<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminrec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TaskBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet14 = New visualweb.ProjectDataSet14()
        Me.TaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet13 = New visualweb.ProjectDataSet13()
        Me.TaskTableAdapter = New visualweb.ProjectDataSet13TableAdapters.taskTableAdapter()
        Me.lgn = New System.Windows.Forms.Button()
        Me.otb = New System.Windows.Forms.TextBox()
        Me.utb = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TaskTableAdapter1 = New visualweb.ProjectDataSet14TableAdapters.taskTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsidDataGridViewTextBoxColumn, Me.TaskDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TaskBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(373, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1241, 811)
        Me.DataGridView1.TabIndex = 9
        '
        'TaskBindingSource1
        '
        Me.TaskBindingSource1.DataMember = "task"
        Me.TaskBindingSource1.DataSource = Me.ProjectDataSet14
        '
        'ProjectDataSet14
        '
        Me.ProjectDataSet14.DataSetName = "ProjectDataSet14"
        Me.ProjectDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaskBindingSource
        '
        Me.TaskBindingSource.DataMember = "task"
        Me.TaskBindingSource.DataSource = Me.ProjectDataSet13
        '
        'ProjectDataSet13
        '
        Me.ProjectDataSet13.DataSetName = "ProjectDataSet13"
        Me.ProjectDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaskTableAdapter
        '
        Me.TaskTableAdapter.ClearBeforeFill = True
        '
        'lgn
        '
        Me.lgn.BackColor = System.Drawing.Color.Transparent
        Me.lgn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lgn.Location = New System.Drawing.Point(54, 200)
        Me.lgn.Name = "lgn"
        Me.lgn.Size = New System.Drawing.Size(163, 39)
        Me.lgn.TabIndex = 27
        Me.lgn.Text = "&Save Task"
        Me.lgn.UseVisualStyleBackColor = False
        '
        'otb
        '
        Me.otb.HideSelection = False
        Me.otb.Location = New System.Drawing.Point(28, 158)
        Me.otb.Name = "otb"
        Me.otb.Size = New System.Drawing.Size(216, 26)
        Me.otb.TabIndex = 30
        '
        'utb
        '
        Me.utb.Location = New System.Drawing.Point(24, 69)
        Me.utb.Name = "utb"
        Me.utb.Size = New System.Drawing.Size(220, 26)
        Me.utb.TabIndex = 25
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(24, 123)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 26
        Me.PasswordLabel.Text = "&Task"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(24, 33)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 24
        Me.UsernameLabel.Text = "&User"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TaskTableAdapter1
        '
        Me.TaskTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 35)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Delete Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsidDataGridViewTextBoxColumn
        '
        Me.UsidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsidDataGridViewTextBoxColumn.DataPropertyName = "usid"
        Me.UsidDataGridViewTextBoxColumn.DividerWidth = 20
        Me.UsidDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UsidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsidDataGridViewTextBoxColumn.Name = "UsidDataGridViewTextBoxColumn"
        '
        'TaskDataGridViewTextBoxColumn
        '
        Me.TaskDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TaskDataGridViewTextBoxColumn.DataPropertyName = "task"
        Me.TaskDataGridViewTextBoxColumn.HeaderText = "Task Given"
        Me.TaskDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TaskDataGridViewTextBoxColumn.Name = "TaskDataGridViewTextBoxColumn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(852, 87)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Poultry Sales Management"
        '
        'adminrec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1650, 1005)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lgn)
        Me.Controls.Add(Me.otb)
        Me.Controls.Add(Me.utb)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminrec"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDataSet13 As ProjectDataSet13
    Friend WithEvents TaskBindingSource As BindingSource
    Friend WithEvents TaskTableAdapter As ProjectDataSet13TableAdapters.taskTableAdapter
    Friend WithEvents lgn As Button
    Friend WithEvents otb As TextBox
    Friend WithEvents utb As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents ProjectDataSet14 As ProjectDataSet14
    Friend WithEvents TaskBindingSource1 As BindingSource
    Friend WithEvents TaskTableAdapter1 As ProjectDataSet14TableAdapters.taskTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents UsidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
