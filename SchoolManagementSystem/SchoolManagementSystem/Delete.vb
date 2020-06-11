Public Class Delete
    Dim datable As SchoolDatabaseDataSetTableAdapters.StudentTableAdapter = New SchoolDatabaseDataSetTableAdapters.StudentTableAdapter()
    Dim dsTable As SchoolDatabaseDataSet = New SchoolDatabaseDataSet()
    Dim row As SchoolDatabaseDataSet.StudentRow
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete a record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If Me.SchoolDatabaseDataSet.Student.Rows.Count = 0 Then
                    MessageBox.Show("No Record found")
                Else
                    row = Me.SchoolDatabaseDataSet.Student.Rows(0)
                    Me.StudentTableAdapter.DeleteQuery(stuid.Text)
                    stuid.Clear()
                    MessageBox.Show("Record deleted")
                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Student)

    End Sub
End Class