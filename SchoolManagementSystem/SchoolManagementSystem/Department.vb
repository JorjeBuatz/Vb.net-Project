Public Class Department
    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Department)

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Me.DepartmentTableAdapter.Update(Me.SchoolDatabaseDataSet.Department)
            MessageBox.Show("REcord Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class