Public Class StudentRecord
    Private Sub StudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Student)

    End Sub
End Class