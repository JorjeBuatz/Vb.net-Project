Public Class StaffAddForm
    Private Sub StaffAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.SchoolDatabaseDataSet.Staff)
        'TODO: This line of code loads data into the 'SchoolDatabaseDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.SchoolDatabaseDataSet.Department)

    End Sub

    Private Sub clearFills()
        StaId.Clear()
        StaFirst.Clear()
        StaMiddle.Clear()
        StaLast.Clear()


    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim Result1 As DialogResult = MessageBox.Show("Do you want to save this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If Result1 = DialogResult.Yes Then
                Dim StaffID = StaId.Text
                Dim StaffFirstName = StaFirst.Text
                Dim StaMiddleName = StaMiddle.Text
                Dim StaLastName = StaLast.Text
                Dim DOB = StaDob.Value.Date
                Dim StaffDepartment = StaDept.SelectedValue
                Dim StaffType = StaType.SelectedItem
                Dim StaffGender = StaGender.SelectedItem

                Me.StaffTableAdapter.InsertQuery(StaffID, StaffFirstName, StaMiddleName, StaLastName, DOB, StaffDepartment, StaffType, StaffGender)
                Me.StaffBindingSource.ResetBindings(False)
                clearFills()

                MessageBox.Show("Recored Added Successfully")

            Else

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class