<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffSearch
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.first = New System.Windows.Forms.TextBox()
        Me.middle = New System.Windows.Forms.TextBox()
        Me.last = New System.Windows.Forms.TextBox()
        Me.dob = New System.Windows.Forms.TextBox()
        Me.dept = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StaffTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UpdateBtn)
        Me.GroupBox1.Controls.Add(Me.gender)
        Me.GroupBox1.Controls.Add(Me.type)
        Me.GroupBox1.Controls.Add(Me.dept)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.last)
        Me.GroupBox1.Controls.Add(Me.middle)
        Me.GroupBox1.Controls.Add(Me.first)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 275)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchBtn)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 74)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Staff ID"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(91, 25)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(226, 22)
        Me.id.TabIndex = 1
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(352, 24)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(93, 23)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MiddleName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(362, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Department"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(362, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Staff Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(362, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Gender"
        '
        'first
        '
        Me.first.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first.Location = New System.Drawing.Point(104, 33)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(226, 22)
        Me.first.TabIndex = 3
        '
        'middle
        '
        Me.middle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middle.Location = New System.Drawing.Point(104, 93)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(226, 22)
        Me.middle.TabIndex = 10
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(104, 154)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(226, 22)
        Me.last.TabIndex = 11
        '
        'dob
        '
        Me.dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob.Location = New System.Drawing.Point(104, 215)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(226, 22)
        Me.dob.TabIndex = 12
        '
        'dept
        '
        Me.dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dept.Location = New System.Drawing.Point(447, 33)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(226, 22)
        Me.dept.TabIndex = 13
        '
        'type
        '
        Me.type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.Location = New System.Drawing.Point(447, 93)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(226, 22)
        Me.type.TabIndex = 14
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(447, 154)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(226, 22)
        Me.gender.TabIndex = 15
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(569, 221)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(93, 23)
        Me.UpdateBtn.TabIndex = 3
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'SchoolDatabaseDataSet
        '
        Me.SchoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet"
        Me.SchoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 519)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffSearch"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dob As TextBox
    Friend WithEvents last As TextBox
    Friend WithEvents middle As TextBox
    Friend WithEvents first As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents gender As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents dept As TextBox
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SchoolDatabaseDataSetTableAdapters.StaffTableAdapter
End Class
