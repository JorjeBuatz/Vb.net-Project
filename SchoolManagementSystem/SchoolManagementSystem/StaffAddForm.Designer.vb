<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAddForm
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
        Me.StaGender = New System.Windows.Forms.ComboBox()
        Me.StaType = New System.Windows.Forms.ComboBox()
        Me.StaDept = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.StaDob = New System.Windows.Forms.DateTimePicker()
        Me.StaLast = New System.Windows.Forms.TextBox()
        Me.StaMiddle = New System.Windows.Forms.TextBox()
        Me.StaFirst = New System.Windows.Forms.TextBox()
        Me.StaId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DepartmentTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.DepartmentTableAdapter()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.StaffTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(295, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF FORM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StaGender)
        Me.GroupBox1.Controls.Add(Me.StaType)
        Me.GroupBox1.Controls.Add(Me.StaDept)
        Me.GroupBox1.Controls.Add(Me.StaDob)
        Me.GroupBox1.Controls.Add(Me.StaLast)
        Me.GroupBox1.Controls.Add(Me.StaMiddle)
        Me.GroupBox1.Controls.Add(Me.StaFirst)
        Me.GroupBox1.Controls.Add(Me.StaId)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 283)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'StaGender
        '
        Me.StaGender.FormattingEnabled = True
        Me.StaGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.StaGender.Location = New System.Drawing.Point(468, 207)
        Me.StaGender.Name = "StaGender"
        Me.StaGender.Size = New System.Drawing.Size(190, 24)
        Me.StaGender.TabIndex = 15
        '
        'StaType
        '
        Me.StaType.FormattingEnabled = True
        Me.StaType.Items.AddRange(New Object() {"HOD", "Teacher", "Teaching Assistant", "Others"})
        Me.StaType.Location = New System.Drawing.Point(468, 148)
        Me.StaType.Name = "StaType"
        Me.StaType.Size = New System.Drawing.Size(190, 24)
        Me.StaType.TabIndex = 14
        '
        'StaDept
        '
        Me.StaDept.DataSource = Me.DepartmentBindingSource
        Me.StaDept.DisplayMember = "DepartmentName"
        Me.StaDept.FormattingEnabled = True
        Me.StaDept.Location = New System.Drawing.Point(468, 85)
        Me.StaDept.Name = "StaDept"
        Me.StaDept.Size = New System.Drawing.Size(190, 24)
        Me.StaDept.TabIndex = 13
        Me.StaDept.ValueMember = "DepartmentName"
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
        'StaDob
        '
        Me.StaDob.Location = New System.Drawing.Point(468, 25)
        Me.StaDob.Name = "StaDob"
        Me.StaDob.Size = New System.Drawing.Size(190, 22)
        Me.StaDob.TabIndex = 12
        '
        'StaLast
        '
        Me.StaLast.Location = New System.Drawing.Point(119, 209)
        Me.StaLast.Name = "StaLast"
        Me.StaLast.Size = New System.Drawing.Size(200, 22)
        Me.StaLast.TabIndex = 11
        '
        'StaMiddle
        '
        Me.StaMiddle.Location = New System.Drawing.Point(119, 150)
        Me.StaMiddle.Name = "StaMiddle"
        Me.StaMiddle.Size = New System.Drawing.Size(200, 22)
        Me.StaMiddle.TabIndex = 10
        '
        'StaFirst
        '
        Me.StaFirst.Location = New System.Drawing.Point(119, 85)
        Me.StaFirst.Name = "StaFirst"
        Me.StaFirst.Size = New System.Drawing.Size(200, 22)
        Me.StaFirst.TabIndex = 9
        '
        'StaId
        '
        Me.StaId.Location = New System.Drawing.Point(119, 26)
        Me.StaId.Name = "StaId"
        Me.StaId.Size = New System.Drawing.Size(200, 22)
        Me.StaId.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(355, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Staff Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Staff ID"
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(329, 374)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(117, 30)
        Me.SaveBtn.TabIndex = 2
        Me.SaveBtn.Text = "ADD"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
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
        'StaffAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 437)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffAddForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffAddForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StaGender As ComboBox
    Friend WithEvents StaType As ComboBox
    Friend WithEvents StaDept As ComboBox
    Friend WithEvents StaDob As DateTimePicker
    Friend WithEvents StaLast As TextBox
    Friend WithEvents StaMiddle As TextBox
    Friend WithEvents StaFirst As TextBox
    Friend WithEvents StaId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SchoolDatabaseDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SchoolDatabaseDataSetTableAdapters.StaffTableAdapter
End Class
