<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.DepartmentTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.DepartmentTableAdapter()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DepartmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departments"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DepartmentBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.DataGridView1.Location = New System.Drawing.Point(116, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(255, 327)
        Me.DataGridView1.TabIndex = 1
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'SchoolDatabaseDataSet
        '
        Me.SchoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet"
        Me.SchoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(205, 387)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 2
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'DepartmentNameDataGridViewTextBoxColumn
        '
        Me.DepartmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName"
        Me.DepartmentNameDataGridViewTextBoxColumn.HeaderText = "Department Name"
        Me.DepartmentNameDataGridViewTextBoxColumn.Name = "DepartmentNameDataGridViewTextBoxColumn"
        Me.DepartmentNameDataGridViewTextBoxColumn.Width = 250
        '
        'Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 443)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Department"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SchoolDatabaseDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DepartmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
