<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.FileToolStripMenuItem, Me.StaffToolStripMenuItem, Me.RecordsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripMenuItem, Me.HallsToolStripMenuItem, Me.CoursesToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DepartmentToolStripMenuItem.Text = "Departments"
        '
        'HallsToolStripMenuItem
        '
        Me.HallsToolStripMenuItem.Name = "HallsToolStripMenuItem"
        Me.HallsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HallsToolStripMenuItem.Text = "Halls"
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CoursesToolStripMenuItem.Text = "Courses"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FileToolStripMenuItem.Text = "Student"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SearchToolStripMenuItem.Text = "Search & Update"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.DeleteToolStripMenuItem1, Me.SearchToolStripMenuItem1})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.SearchToolStripMenuItem1.Text = "Search & Update"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.StaffToolStripMenuItem1})
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StaffToolStripMenuItem1.Text = "Staff"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 500)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "School Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HallsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
End Class
