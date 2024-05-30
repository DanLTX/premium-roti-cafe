Public Class PaymentOption
    Private Sub Button_Card_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        DebitCreditCard.Show()
        Me.Hide()
        DebitCreditCard.cardnumBox.Clear()
        DebitCreditCard.expiryBox.Clear()
        DebitCreditCard.cvvBox.Clear()

        DebitCreditCard.lblGrandTotal.Text = "Grand Total: RM" & Format(Cart.grandTotal, "0.00")
        DebitCreditCard.lstCart.Items.Clear()
        DebitCreditCard.lstCart.Items.Add("Qty" & vbTab & "Item" & vbTab & vbTab & vbTab & "Price")
        'foods
        For i = 0 To 5
            If Foods.foodsNum(i) > 0 Then
                DebitCreditCard.lstCart.Items.Add(Foods.foodsNum(i) & vbTab & Foods.foodsName(i) & vbTab & vbTab & "RM " & Format((Foods.foodsPrice(i) * Foods.foodsNum(i)), "0.00"))
            End If
        Next

        'drinks
        For i = 0 To 5
            If Drinks.drinksNum(i) > 0 Then
                DebitCreditCard.lstCart.Items.Add(Drinks.drinksNum(i) & vbTab & Drinks.drinksName(i) & vbTab & vbTab & "RM " & Format((Drinks.drinksPrice(i) * Drinks.drinksNum(i)), "0.00"))
            End If
        Next

        'desserts
        For i = 0 To 5
            If Desserts.dessertsNum(i) > 0 Then
                DebitCreditCard.lstCart.Items.Add(Desserts.dessertsNum(i) & vbTab & Desserts.dessertsName(i) & vbTab & vbTab & "RM " & Format((Desserts.dessertsPrice(i) * Desserts.dessertsNum(i)), "0.00"))
            End If
        Next

        'roti
        For i = 0 To 5
            If Roti.rotiNum(i) > 0 Then
                DebitCreditCard.lstCart.Items.Add(Roti.rotiNum(i) & vbTab & Roti.rotiName(i) & vbTab & vbTab & "RM " & Format((Roti.rotiPrice(i) * Roti.rotiNum(i)), "0.00"))
            End If
        Next
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Cart.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Cash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        ThankYou.Show()
        Me.Hide()
    End Sub
End Class