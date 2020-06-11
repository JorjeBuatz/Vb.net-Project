Public Class HallsForm
    Private Sub HallsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.SchoolDatabaseDataSet.Hall)

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Me.HallTableAdapter.Update(Me.SchoolDatabaseDataSet.Hall)
            MessageBox.Show("Record Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class