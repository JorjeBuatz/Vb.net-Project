<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentSearch
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
        Me.sclass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.dob = New System.Windows.Forms.TextBox()
        Me.last = New System.Windows.Forms.TextBox()
        Me.hall = New System.Windows.Forms.TextBox()
        Me.middle = New System.Windows.Forms.TextBox()
        Me.first = New System.Windows.Forms.TextBox()
        Me.course = New System.Windows.Forms.TextBox()
        Me.dept = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.StuID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StaffTableAdapter()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UpdateBtn)
        Me.GroupBox1.Controls.Add(Me.sclass)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.gender)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.last)
        Me.GroupBox1.Controls.Add(Me.hall)
        Me.GroupBox1.Controls.Add(Me.middle)
        Me.GroupBox1.Controls.Add(Me.first)
        Me.GroupBox1.Controls.Add(Me.course)
        Me.GroupBox1.Controls.Add(Me.dept)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(719, 350)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'sclass
        '
        Me.sclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sclass.Location = New System.Drawing.Point(463, 160)
        Me.sclass.Name = "sclass"
        Me.sclass.Size = New System.Drawing.Size(235, 22)
        Me.sclass.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(379, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Hall"
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(463, 243)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(235, 22)
        Me.gender.TabIndex = 19
        '
        'dob
        '
        Me.dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob.Location = New System.Drawing.Point(112, 234)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(235, 22)
        Me.dob.TabIndex = 18
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(112, 160)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(235, 22)
        Me.last.TabIndex = 16
        '
        'hall
        '
        Me.hall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hall.Location = New System.Drawing.Point(463, 99)
        Me.hall.Name = "hall"
        Me.hall.Size = New System.Drawing.Size(235, 22)
        Me.hall.TabIndex = 15
        '
        'middle
        '
        Me.middle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middle.Location = New System.Drawing.Point(112, 90)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(235, 22)
        Me.middle.TabIndex = 14
        '
        'first
        '
        Me.first.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first.Location = New System.Drawing.Point(112, 30)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(235, 22)
        Me.first.TabIndex = 13
        '
        'course
        '
        Me.course.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course.Location = New System.Drawing.Point(463, 39)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(235, 22)
        Me.course.TabIndex = 12
        '
        'dept
        '
        Me.dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dept.Location = New System.Drawing.Point(112, 299)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(235, 22)
        Me.dept.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(379, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(379, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Class"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Course"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Department"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "First Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchBtn)
        Me.GroupBox2.Controls.Add(Me.StuID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 69)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(357, 23)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(75, 23)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'StuID
        '
        Me.StuID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuID.Location = New System.Drawing.Point(90, 25)
        Me.StuID.Name = "StuID"
        Me.StuID.Size = New System.Drawing.Size(235, 22)
        Me.StuID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(553, 292)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(75, 29)
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
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 584)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentSearch"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Search Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sclass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gender As TextBox
    Friend WithEvents dob As TextBox
    Friend WithEvents last As TextBox
    Friend WithEvents hall As TextBox
    Friend WithEvents middle As TextBox
    Friend WithEvents first As TextBox
    Friend WithEvents course As TextBox
    Friend WithEvents dept As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents StuID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SchoolDatabaseDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As SchoolDatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents UpdateBtn As Button
End Class
