<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentAddForm
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
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StuGender = New System.Windows.Forms.ComboBox()
        Me.StuClass = New System.Windows.Forms.ComboBox()
        Me.StuHall = New System.Windows.Forms.ComboBox()
        Me.HallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuCourse = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuDept = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuDob = New System.Windows.Forms.DateTimePicker()
        Me.StuLastName = New System.Windows.Forms.TextBox()
        Me.StuMiddleName = New System.Windows.Forms.TextBox()
        Me.StuFirstName = New System.Windows.Forms.TextBox()
        Me.StuId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DepartmentTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.DepartmentTableAdapter()
        Me.CourseTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.CourseTableAdapter()
        Me.HallTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.HallTableAdapter()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchoolDatabaseDataSet
        '
        Me.SchoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet"
        Me.SchoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CourseTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.HallTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StuGender)
        Me.GroupBox1.Controls.Add(Me.StuClass)
        Me.GroupBox1.Controls.Add(Me.StuHall)
        Me.GroupBox1.Controls.Add(Me.StuCourse)
        Me.GroupBox1.Controls.Add(Me.StuDept)
        Me.GroupBox1.Controls.Add(Me.StuDob)
        Me.GroupBox1.Controls.Add(Me.StuLastName)
        Me.GroupBox1.Controls.Add(Me.StuMiddleName)
        Me.GroupBox1.Controls.Add(Me.StuFirstName)
        Me.GroupBox1.Controls.Add(Me.StuId)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 352)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'StuGender
        '
        Me.StuGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuGender.FormattingEnabled = True
        Me.StuGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.StuGender.Location = New System.Drawing.Point(474, 280)
        Me.StuGender.Name = "StuGender"
        Me.StuGender.Size = New System.Drawing.Size(189, 24)
        Me.StuGender.TabIndex = 20
        '
        'StuClass
        '
        Me.StuClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuClass.FormattingEnabled = True
        Me.StuClass.Items.AddRange(New Object() {"Business 1", "Business 2", "Business 3", "Science 1", "Science 2", "Science 3", "Science 4", "Science 5", "General Art 1", "General Art 2", "General Art 3", "Visual Art 1", "Visual Art 2", "A. Science 1", "A. Science 2"})
        Me.StuClass.Location = New System.Drawing.Point(474, 210)
        Me.StuClass.Name = "StuClass"
        Me.StuClass.Size = New System.Drawing.Size(189, 24)
        Me.StuClass.TabIndex = 19
        '
        'StuHall
        '
        Me.StuHall.DataSource = Me.HallBindingSource
        Me.StuHall.DisplayMember = "HallName"
        Me.StuHall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuHall.FormattingEnabled = True
        Me.StuHall.Location = New System.Drawing.Point(474, 139)
        Me.StuHall.Name = "StuHall"
        Me.StuHall.Size = New System.Drawing.Size(189, 24)
        Me.StuHall.TabIndex = 18
        Me.StuHall.ValueMember = "HallName"
        '
        'HallBindingSource
        '
        Me.HallBindingSource.DataMember = "Hall"
        Me.HallBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'StuCourse
        '
        Me.StuCourse.DataSource = Me.CourseBindingSource
        Me.StuCourse.DisplayMember = "CourseName"
        Me.StuCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuCourse.FormattingEnabled = True
        Me.StuCourse.Location = New System.Drawing.Point(474, 75)
        Me.StuCourse.Name = "StuCourse"
        Me.StuCourse.Size = New System.Drawing.Size(189, 24)
        Me.StuCourse.TabIndex = 17
        Me.StuCourse.ValueMember = "CourseName"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'StuDept
        '
        Me.StuDept.DataSource = Me.DepartmentBindingSource
        Me.StuDept.DisplayMember = "DepartmentName"
        Me.StuDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuDept.FormattingEnabled = True
        Me.StuDept.Location = New System.Drawing.Point(474, 17)
        Me.StuDept.Name = "StuDept"
        Me.StuDept.Size = New System.Drawing.Size(189, 24)
        Me.StuDept.TabIndex = 16
        Me.StuDept.ValueMember = "DepartmentName"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'StuDob
        '
        Me.StuDob.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.StuDob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StuDob.Location = New System.Drawing.Point(127, 281)
        Me.StuDob.MinDate = New Date(1975, 3, 1, 0, 0, 0, 0)
        Me.StuDob.Name = "StuDob"
        Me.StuDob.Size = New System.Drawing.Size(200, 23)
        Me.StuDob.TabIndex = 15
        Me.StuDob.Value = New Date(1996, 2, 1, 0, 0, 0, 0)
        '
        'StuLastName
        '
        Me.StuLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuLastName.Location = New System.Drawing.Point(127, 212)
        Me.StuLastName.Name = "StuLastName"
        Me.StuLastName.Size = New System.Drawing.Size(206, 22)
        Me.StuLastName.TabIndex = 14
        '
        'StuMiddleName
        '
        Me.StuMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuMiddleName.Location = New System.Drawing.Point(127, 141)
        Me.StuMiddleName.Name = "StuMiddleName"
        Me.StuMiddleName.Size = New System.Drawing.Size(206, 22)
        Me.StuMiddleName.TabIndex = 13
        '
        'StuFirstName
        '
        Me.StuFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuFirstName.Location = New System.Drawing.Point(127, 80)
        Me.StuFirstName.Name = "StuFirstName"
        Me.StuFirstName.Size = New System.Drawing.Size(206, 22)
        Me.StuFirstName.TabIndex = 12
        '
        'StuId
        '
        Me.StuId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuId.Location = New System.Drawing.Point(127, 19)
        Me.StuId.Name = "StuId"
        Me.StuId.Size = New System.Drawing.Size(206, 22)
        Me.StuId.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(373, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(373, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Class"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(375, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Hall"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(375, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Course"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(375, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "MiddleName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.Black
        Me.AddBtn.Location = New System.Drawing.Point(294, 433)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(103, 39)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "ADD"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'HallTableAdapter
        '
        Me.HallTableAdapter.ClearBeforeFill = True
        '
        'StudentAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 516)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "StudentAddForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentAddForm"
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As SchoolDatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StuGender As ComboBox
    Friend WithEvents StuClass As ComboBox
    Friend WithEvents StuHall As ComboBox
    Friend WithEvents StuCourse As ComboBox
    Friend WithEvents StuDept As ComboBox
    Friend WithEvents StuDob As DateTimePicker
    Friend WithEvents StuLastName As TextBox
    Friend WithEvents StuMiddleName As TextBox
    Friend WithEvents StuFirstName As TextBox
    Friend WithEvents StuId As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SchoolDatabaseDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As SchoolDatabaseDataSetTableAdapters.CourseTableAdapter
    Friend WithEvents HallBindingSource As BindingSource
    Friend WithEvents HallTableAdapter As SchoolDatabaseDataSetTableAdapters.HallTableAdapter
End Class
