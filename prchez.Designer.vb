<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prchez
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
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet8 = New visualweb.ProjectDataSet8()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PurchaseTableAdapter = New visualweb.ProjectDataSet8TableAdapters.purchaseTableAdapter()
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PidDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.CarDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchaseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(626, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1260, 736)
        Me.DataGridView1.TabIndex = 53
        '
        'PurchaseBindingSource
        '
        Me.PurchaseBindingSource.DataMember = "purchase"
        Me.PurchaseBindingSource.DataSource = Me.ProjectDataSet8
        '
        'ProjectDataSet8
        '
        Me.ProjectDataSet8.DataSetName = "ProjectDataSet8"
        Me.ProjectDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(196, 435)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 26)
        Me.TextBox1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "&Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(196, 596)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 48)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Insert Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "&Product ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "&Product Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(196, 132)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(294, 26)
        Me.tb1.TabIndex = 47
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(196, 342)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(294, 26)
        Me.tb4.TabIndex = 46
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(196, 237)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(294, 26)
        Me.tb2.TabIndex = 45
        '
        'tb3
        '
        Me.tb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tb3.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb3.ForeColor = System.Drawing.Color.Black
        Me.tb3.Location = New System.Drawing.Point(31, 393)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(220, 23)
        Me.tb3.TabIndex = 43
        Me.tb3.Text = "&Price"
        Me.tb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(196, 542)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(294, 26)
        Me.TextBox2.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 23)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "&Car Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PurchaseTableAdapter
        '
        Me.PurchaseTableAdapter.ClearBeforeFill = True
        '
        'PidDataGridViewTextBoxColumn
        '
        Me.PidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PidDataGridViewTextBoxColumn.DataPropertyName = "p_id"
        Me.PidDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.PidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PidDataGridViewTextBoxColumn.Name = "PidDataGridViewTextBoxColumn"
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "p_name"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.PnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        '
        'CarDataGridViewTextBoxColumn
        '
        Me.CarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CarDataGridViewTextBoxColumn.DataPropertyName = "car#"
        Me.CarDataGridViewTextBoxColumn.HeaderText = "Car Number"
        Me.CarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CarDataGridViewTextBoxColumn.Name = "CarDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity Of Product"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price Of Product"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 48)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Delete Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(852, 87)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Poultry Sales Management"
        '
        'prchez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1898, 990)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "prchez"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "prchez"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ProjectDataSet8 As ProjectDataSet8
    Friend WithEvents PurchaseBindingSource As BindingSource
    Friend WithEvents PurchaseTableAdapter As ProjectDataSet8TableAdapters.purchaseTableAdapter
    Friend WithEvents PidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
