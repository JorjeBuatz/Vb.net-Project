Public Class StaffRecord
    Private Sub StaffRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.SchoolDatabaseDataSet.Staff)

    End Sub
End Class