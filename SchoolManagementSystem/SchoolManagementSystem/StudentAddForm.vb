Public Class StudentAddForm
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDatabaseDataSet)

    End Sub

    Private Sub StudentAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.SchoolDatabaseDataSet.Hall)
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.SchoolDatabaseDataSet.Course)
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Department)
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Student)

    End Sub

    Private Sub ClearFills()
        StuId.Clear()
        StuFirstName.Clear()
        StuMiddleName.Clear()
        StuLastName.Clear()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Dim result1 As DialogResult = MessageBox.Show("Do you want to save this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = DialogResult.Yes Then
                Dim StudentID = StuId.Text
                Dim StudentFirst = StuFirstName.Text
                Dim StudentMiddle = StuMiddleName.Text
                Dim StudentLast = StuLastName.Text
                Dim StudentDob = StuDob.Value.Date
                Dim StudentDepartment = StuDept.SelectedValue
                Dim StudentCourse = StuCourse.SelectedValue
                Dim StudentHall = StuHall.SelectedValue
                Dim StudentClass = StuClass.SelectedItem
                Dim StudentGender = StuGender.SelectedItem

                ClearFills()

                Me.StudentTableAdapter.InsertQuery(StudentID, StudentFirst, StudentMiddle, StudentLast, StudentDob, StudentDepartment, StudentCourse, StudentHall, StudentClass, StudentGender)
                Me.StudentBindingSource.ResetBindings(False)

                MessageBox.Show("Record Successfully Added")

            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class