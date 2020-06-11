Public Class StudentSearch
    Dim datable As SchoolDatabaseDataSetTableAdapters.StudentTableAdapter = New SchoolDatabaseDataSetTableAdapters.StudentTableAdapter()
    Dim dsTable As SchoolDatabaseDataSet = New SchoolDatabaseDataSet()
    Dim row As SchoolDatabaseDataSet.StudentRow

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Me.StudentTableAdapter.FillBy(Me.SchoolDatabaseDataSet.Student, StuID.Text)
            If Me.SchoolDatabaseDataSet.Student.Rows.Count > 0 Then
                row = Me.SchoolDatabaseDataSet.Student.Rows(0)
                first.Text = row.FirstName
                middle.Text = row.MiddleName
                last.Text = row.LastName
                dob.Text = row.DOB
                dept.Text = row.DepartmentName
                course.Text = row.CourseName
                hall.Text = row.HallName
                sclass.Text = row.ClassName
                gender.Text = row.Gender

            Else
                MessageBox.Show("Record Not Found")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub StudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Student)

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            Dim result1 As DialogResult = MessageBox.Show("Do you want to save update?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result1 = DialogResult.Yes Then
                Me.StudentTableAdapter.UpdateQuery(StuID.Text, first.Text, middle.Text, last.Text, dob.Text, dept.Text, course.Text, hall.Text, sclass.Text, gender.Text, StuID.Text)
                MessageBox.Show("This record has been updated")
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class