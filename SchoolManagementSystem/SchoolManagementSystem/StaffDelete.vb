Public Class StaffDelete
    Dim datable As SchoolDatabaseDataSetTableAdapters.StaffTableAdapter = New SchoolDatabaseDataSetTableAdapters.StaffTableAdapter()
    Dim dsTable As SchoolDatabaseDataSet = New SchoolDatabaseDataSet()
    Dim row As SchoolDatabaseDataSet.StaffRow

    Private Sub StaffDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.SchoolDatabaseDataSet.Staff)

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = DialogResult.Yes Then
                If Me.SchoolDatabaseDataSet.Staff.Rows.Count = 0 Then
                    MessageBox.Show("No Record found")
                Else
                    row = Me.SchoolDatabaseDataSet.Staff.Rows(0)
                    Me.StaffTableAdapter.DeleteQuery(staffid.Text)
                    staffid.Clear()
                    MessageBox.Show("Record deleted")
                End If


            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class