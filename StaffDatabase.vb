Public Class StaffDatabase
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RotiCafeDatabaseDataSet2.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.RotiCafeDatabaseDataSet2.Staff)

    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.StaffBindingSource.AddNew()
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RotiCafeDatabaseDataSet2)
        MessageBox.Show("Data Saved!")
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.StaffBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.RotiCafeDatabaseDataSet2)
        MessageBox.Show("Data has been removed")
    End Sub
End Class