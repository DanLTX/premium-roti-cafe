Public Class MenuOption
    Private Sub Button_Foods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        Foods.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Cart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Cart.Show()
        Me.Hide()
        Cart.cartUpdate()
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Drinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        Drinks.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Desserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        Desserts.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Roti_Click(sender As Object, e As EventArgs) Handles btnRoti.Click
        Roti.Show()
        Me.Hide()
    End Sub
End Class