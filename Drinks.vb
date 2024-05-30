Public Class Drinks
    Public drinksName() As String = {"Teh Tarik ", "Air Bandung", "Sirap Selasih", "Milo Dinosaur", "Kopi Ais    ", "Teh Limau"}
    Public drinksPrice() As Double = {5, 5.3, 5.5, 6.8, 4.8, 5.2}

    Public drinksNum(5) As Integer

    Private Sub Button_Minus_AirBandung(sender As Object, e As EventArgs) Handles btnMinusAB.Click
        drinksNum(1) -= 1
        If drinksNum(1) >= 0 Then
            lblAirBandung.Text = drinksNum(1)
        End If
    End Sub

    Private Sub Button_Plus_SirapSelasih(sender As Object, e As EventArgs) Handles btnPlusSS.Click
        drinksNum(2) += 1
        lblSirapSelasih.Text = drinksNum(2)
    End Sub

    Private Sub Button_Minus_SirapSelasih(sender As Object, e As EventArgs) Handles btnMinusSS.Click
        drinksNum(2) -= 1
        If drinksNum(2) >= 0 Then
            lblSirapSelasih.Text = drinksNum(2)
        End If
    End Sub

    Private Sub Button_Plus_MiloDino(sender As Object, e As EventArgs) Handles btnPlusMD.Click
        drinksNum(3) += 1
        lblMiloDinosaur.Text = drinksNum(3)
    End Sub

    Private Sub Button_Minus_MiloDino(sender As Object, e As EventArgs) Handles btnMinusMD.Click
        drinksNum(3) -= 1
        If drinksNum(3) >= 0 Then
            lblMiloDinosaur.Text = drinksNum(3)
        End If
    End Sub

    Private Sub Button_Plus_KopiAis(sender As Object, e As EventArgs) Handles btnPlusKA.Click
        drinksNum(4) += 1
        lblKopiAis.Text = drinksNum(4)
    End Sub

    Private Sub Button_Minus_KopiAis(sender As Object, e As EventArgs) Handles btnMinusKA.Click
        drinksNum(4) -= 1
        If drinksNum(4) >= 0 Then
            lblKopiAis.Text = drinksNum(4)
        End If
    End Sub

    Private Sub Button_Plus_TehLimau(sender As Object, e As EventArgs) Handles btnPlusTL.Click
        drinksNum(5) += 1
        lblTehLimau.Text = drinksNum(5)
    End Sub

    Private Sub Button_Minus_TehLimau(sender As Object, e As EventArgs) Handles btnMinusTL.Click
        drinksNum(5) -= 1
        If drinksNum(5) >= 0 Then
            lblTehLimau.Text = drinksNum(5)
        End If
    End Sub

    Private Sub Button_Plus_AirBandung(sender As Object, e As EventArgs) Handles btnPlusAB.Click
        drinksNum(1) += 1
        lblAirBandung.Text = drinksNum(1)
    End Sub

    Private Sub Button_Minus_TehTarik(sender As Object, e As EventArgs) Handles btnMinusTT.Click
        drinksNum(0) -= 1
        If drinksNum(0) >= 0 Then
            lblTehTarik.Text = drinksNum(0)
        End If
    End Sub

    Private Sub Button_Plus_TehTarik(sender As Object, e As EventArgs) Handles btnPlusTT.Click
        drinksNum(0) += 1
        lblTehTarik.Text = drinksNum(0)
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuOption.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Cart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Cart.Show()
        Me.Hide()
        Cart.cartUpdate()
    End Sub
End Class