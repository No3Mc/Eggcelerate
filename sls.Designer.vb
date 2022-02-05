<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sls
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.tb3 = New System.Windows.Forms.Label()
        Me.ProjectDataSet3 = New visualweb.ProjectDataSet3()
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleTableAdapter = New visualweb.ProjectDataSet3TableAdapters.saleTableAdapter()
        Me.ProjectDataSet5 = New visualweb.ProjectDataSet5()
        Me.SaleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleTableAdapter1 = New visualweb.ProjectDataSet5TableAdapters.saleTableAdapter()
        Me.ProjectDataSet6 = New visualweb.ProjectDataSet6()
        Me.SaleBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleTableAdapter2 = New visualweb.ProjectDataSet6TableAdapters.saleTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuentityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet7 = New visualweb.ProjectDataSet7()
        Me.SaleTableAdapter3 = New visualweb.ProjectDataSet7TableAdapters.saleTableAdapter()
        Me.delrec = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ProjectDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(119, 508)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 48)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Insert Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "&Product ID (Date)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(115, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "&Product Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(119, 253)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(294, 26)
        Me.tb1.TabIndex = 34
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(119, 374)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(294, 26)
        Me.tb4.TabIndex = 33
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(119, 319)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(294, 26)
        Me.tb2.TabIndex = 31
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(119, 585)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(115, 46)
        Me.Cancel.TabIndex = 30
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.Visible = False
        '
        'tb3
        '
        Me.tb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tb3.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb3.ForeColor = System.Drawing.Color.Black
        Me.tb3.Location = New System.Drawing.Point(119, 348)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(220, 23)
        Me.tb3.TabIndex = 28
        Me.tb3.Text = "&Price"
        Me.tb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProjectDataSet3
        '
        Me.ProjectDataSet3.DataSetName = "ProjectDataSet3"
        Me.ProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataMember = "sale"
        Me.SaleBindingSource.DataSource = Me.ProjectDataSet3
        '
        'SaleTableAdapter
        '
        Me.SaleTableAdapter.ClearBeforeFill = True
        '
        'ProjectDataSet5
        '
        Me.ProjectDataSet5.DataSetName = "ProjectDataSet5"
        Me.ProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleBindingSource1
        '
        Me.SaleBindingSource1.DataMember = "sale"
        Me.SaleBindingSource1.DataSource = Me.ProjectDataSet5
        '
        'SaleTableAdapter1
        '
        Me.SaleTableAdapter1.ClearBeforeFill = True
        '
        'ProjectDataSet6
        '
        Me.ProjectDataSet6.DataSetName = "ProjectDataSet6"
        Me.ProjectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleBindingSource2
        '
        Me.SaleBindingSource2.DataMember = "sale"
        Me.SaleBindingSource2.DataSource = Me.ProjectDataSet6
        '
        'SaleTableAdapter2
        '
        Me.SaleTableAdapter2.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 438)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 26)
        Me.TextBox1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(123, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "&Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PidDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.QuentityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SaleBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(519, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1092, 511)
        Me.DataGridView1.TabIndex = 42
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
        'QuentityDataGridViewTextBoxColumn
        '
        Me.QuentityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuentityDataGridViewTextBoxColumn.DataPropertyName = "Quentity"
        Me.QuentityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuentityDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.QuentityDataGridViewTextBoxColumn.Name = "QuentityDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price Of Product"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'SaleBindingSource3
        '
        Me.SaleBindingSource3.DataMember = "sale"
        Me.SaleBindingSource3.DataSource = Me.ProjectDataSet7
        '
        'ProjectDataSet7
        '
        Me.ProjectDataSet7.DataSetName = "ProjectDataSet7"
        Me.ProjectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleTableAdapter3
        '
        Me.SaleTableAdapter3.ClearBeforeFill = True
        '
        'delrec
        '
        Me.delrec.Location = New System.Drawing.Point(282, 508)
        Me.delrec.Name = "delrec"
        Me.delrec.Size = New System.Drawing.Size(131, 48)
        Me.delrec.TabIndex = 43
        Me.delrec.Text = "Delete Record"
        Me.delrec.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(852, 87)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Poultry Sales Management"
        '
        'sls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1617, 703)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.delrec)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.tb3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sls"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProjectDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents tb3 As Label
    Friend WithEvents ProjectDataSet3 As ProjectDataSet3
    Friend WithEvents SaleBindingSource As BindingSource
    Friend WithEvents SaleTableAdapter As ProjectDataSet3TableAdapters.saleTableAdapter
    Friend WithEvents ProjectDataSet5 As ProjectDataSet5
    Friend WithEvents SaleBindingSource1 As BindingSource
    Friend WithEvents SaleTableAdapter1 As ProjectDataSet5TableAdapters.saleTableAdapter
    Friend WithEvents ProjectDataSet6 As ProjectDataSet6
    Friend WithEvents SaleBindingSource2 As BindingSource
    Friend WithEvents SaleTableAdapter2 As ProjectDataSet6TableAdapters.saleTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDataSet7 As ProjectDataSet7
    Friend WithEvents SaleBindingSource3 As BindingSource
    Friend WithEvents SaleTableAdapter3 As ProjectDataSet7TableAdapters.saleTableAdapter
    Friend WithEvents PidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuentityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents delrec As Button
    Friend WithEvents Label4 As Label
End Class
