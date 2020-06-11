Public Class MainForm
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim Form As New StudentAddForm
        Form.MdiParent = Me
        Form.Show()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        Dim Form As New StudentRecord
        Form.MdiParent = Me
        Form.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Dim form As New StaffAddForm
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub StaffToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem1.Click
        Dim form As New StaffRecord
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        Dim form As New Department
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub HallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HallsToolStripMenuItem.Click
        Dim form As New HallsForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursesToolStripMenuItem.Click
        Dim form As New Course
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim form As New Delete
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Dim form As New StaffDelete
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim form As New StudentSearch
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        Dim form As New StaffSearch
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
