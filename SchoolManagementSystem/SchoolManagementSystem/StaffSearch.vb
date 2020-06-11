Public Class StaffSearch
    Dim datable As SchoolDatabaseDataSetTableAdapters.StaffTableAdapter = New SchoolDatabaseDataSetTableAdapters.StaffTableAdapter()
    Dim dsTable As SchoolDatabaseDataSet = New SchoolDatabaseDataSet()
    Dim row As SchoolDatabaseDataSet.StaffRow
    Private Sub StaffSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.SchoolDatabaseDataSet.Staff)

    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Me.StaffTableAdapter.FillBy(Me.SchoolDatabaseDataSet.Staff, id.Text)
            If Me.SchoolDatabaseDataSet.Staff.Rows.Count > 0 Then
                row = Me.SchoolDatabaseDataSet.Staff.Rows(0)
                first.Text = row.FirstName
                middle.Text = row.MiddleName
                last.Text = row.LastName
                dob.Text = row.DOB
                dept.Text = row.DepartmentName
                type.Text = row.StaffType
                gender.Text = row.Gender

            Else
                MessageBox.Show("Record Not Found")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            Dim result1 As DialogResult = MessageBox.Show("Do you want to save update?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result1 = DialogResult.Yes Then
                Me.StaffTableAdapter.UpdateQuery(id.Text, first.Text, middle.Text, last.Text, dob.Text, dept.Text, type.Text, gender.Text)
                MessageBox.Show("This record has been updated")
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class