<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRecord
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
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.StudentTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.DepartmentNameDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.HallNameDataGridViewTextBoxColumn, Me.ClassNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.DataGridView1.Location = New System.Drawing.Point(22, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1005, 386)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentNameDataGridViewTextBoxColumn
        '
        Me.DepartmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName"
        Me.DepartmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName"
        Me.DepartmentNameDataGridViewTextBoxColumn.Name = "DepartmentNameDataGridViewTextBoxColumn"
        Me.DepartmentNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HallNameDataGridViewTextBoxColumn
        '
        Me.HallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName"
        Me.HallNameDataGridViewTextBoxColumn.HeaderText = "HallName"
        Me.HallNameDataGridViewTextBoxColumn.Name = "HallNameDataGridViewTextBoxColumn"
        Me.HallNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassNameDataGridViewTextBoxColumn
        '
        Me.ClassNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName"
        Me.ClassNameDataGridViewTextBoxColumn.HeaderText = "ClassName"
        Me.ClassNameDataGridViewTextBoxColumn.Name = "ClassNameDataGridViewTextBoxColumn"
        Me.ClassNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'SchoolDatabaseDataSet
        '
        Me.SchoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet"
        Me.SchoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Record"
        '
        'StudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 439)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "StudentRecord"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Record"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As SchoolDatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HallNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
