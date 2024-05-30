Public Class RegisterLogin
    Private Sub RegisterLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RotiCafeDatabaseDataSet3.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.RotiCafeDatabaseDataSet3.Login)

    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.LoginBindingSource.AddNew()
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RotiCafeDatabaseDataSet3)
        MessageBox.Show("Data Saved!")
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.LoginBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.RotiCafeDatabaseDataSet3)
        MessageBox.Show("Data has been removed")
    End Sub

End Class