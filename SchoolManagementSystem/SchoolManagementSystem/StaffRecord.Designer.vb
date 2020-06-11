<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffRecord
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
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.StaffTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StaffTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Record"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'SchoolDatabaseDataSet
        '
        Me.SchoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet"
        Me.SchoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.DepartmentNameDataGridViewTextBoxColumn, Me.StaffTypeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource1
        Me.DataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.DataGridView1.Location = New System.Drawing.Point(11, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(803, 305)
        Me.DataGridView1.TabIndex = 1
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'DepartmentNameDataGridViewTextBoxColumn
        '
        Me.DepartmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName"
        Me.DepartmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName"
        Me.DepartmentNameDataGridViewTextBoxColumn.Name = "DepartmentNameDataGridViewTextBoxColumn"
        '
        'StaffTypeDataGridViewTextBoxColumn
        '
        Me.StaffTypeDataGridViewTextBoxColumn.DataPropertyName = "StaffType"
        Me.StaffTypeDataGridViewTextBoxColumn.HeaderText = "StaffType"
        Me.StaffTypeDataGridViewTextBoxColumn.Name = "StaffTypeDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "Staff"
        Me.StaffBindingSource1.DataSource = Me.SchoolDatabaseDataSet
        '
        'StaffRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 493)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffRecord"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffRecord"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SchoolDatabaseDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffBindingSource1 As BindingSource
End Class
