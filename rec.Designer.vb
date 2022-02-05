<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rec
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
        Me.ProjectDataSet11 = New visualweb.ProjectDataSet11()
        Me.TaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaskTableAdapter = New visualweb.ProjectDataSet11TableAdapters.taskTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CompanydataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet12 = New visualweb.ProjectDataSet12()
        Me.Company_dataTableAdapter = New visualweb.ProjectDataSet12TableAdapters.company_dataTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ProjectDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanydataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDataSet11
        '
        Me.ProjectDataSet11.DataSetName = "ProjectDataSet11"
        Me.ProjectDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaskBindingSource
        '
        Me.TaskBindingSource.DataMember = "task"
        Me.TaskBindingSource.DataSource = Me.ProjectDataSet11
        '
        'TaskTableAdapter
        '
        Me.TaskTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(708, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CompanydataBindingSource
        '
        Me.CompanydataBindingSource.DataMember = "company_data"
        Me.CompanydataBindingSource.DataSource = Me.ProjectDataSet12
        '
        'ProjectDataSet12
        '
        Me.ProjectDataSet12.DataSetName = "ProjectDataSet12"
        Me.ProjectDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_dataTableAdapter
        '
        Me.Company_dataTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(370, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 39)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(370, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 39)
        Me.Label3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Task:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(405, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(852, 87)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Poultry Sales Management"
        '
        'rec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1394, 566)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rec"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProjectDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanydataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectDataSet11 As ProjectDataSet11
    Friend WithEvents TaskBindingSource As BindingSource
    Friend WithEvents TaskTableAdapter As ProjectDataSet11TableAdapters.taskTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ProjectDataSet12 As ProjectDataSet12
    Friend WithEvents CompanydataBindingSource As BindingSource
    Friend WithEvents Company_dataTableAdapter As ProjectDataSet12TableAdapters.company_dataTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
