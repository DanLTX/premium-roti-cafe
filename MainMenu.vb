Public Class MainMenu
    Private Sub Button_Order_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        MenuOption.Show()
        Me.Hide()
        ThankYou.resetOrder()
    End Sub

    Private Sub Button_FoodReport_Click(sender As Object, e As EventArgs) Handles btnFDReport.Click
        FoodReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Staff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        StaffDatabase.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Me.Hide()
        Login.txtPassword.Clear()
        Login.txtUsername.Clear()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RegisterLogin.Show()
        Me.Hide()
    End Sub
End Class