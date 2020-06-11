Public Class Course
    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.SchoolDatabaseDataSet.Course)

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Me.CourseTableAdapter.Update(Me.SchoolDatabaseDataSet.Course)
            MessageBox.Show("Record Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class