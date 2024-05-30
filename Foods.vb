Public Class Foods
    Public foodsName() As String = {"Nasi Lemak", "Nasi Goreng", "Nasi Kerabu", "Char Kway Teow", "Laksa Penang", "Mee Bandung"}
    Public foodsPrice() As Double = {9.3, 8.5, 9.8, 9, 10.3, 10.5}

    Public foodsNum(5) As Integer

    Private Sub Button_Plus_NasiGoreng(sender As Object, e As EventArgs) Handles btnPlusNG.Click
        foodsNum(1) += 1
        lblNasiGoreng.Text = foodsNum(1)
    End Sub

    Private Sub Button_Plus_NasiKerabu(sender As Object, e As EventArgs) Handles btnPlusNK.Click
        foodsNum(2) += 1
        lblNasiKerabu.Text = foodsNum(2)
    End Sub

    Private Sub Button_Minus_NasiKerabu(sender As Object, e As EventArgs) Handles btnMinusNK.Click
        foodsNum(2) -= 1
        If foodsNum(2) >= 0 Then
            lblNasiKerabu.Text = foodsNum(2)
        End If
    End Sub

    Private Sub Button6_Plus_CharKwayTeow(sender As Object, e As EventArgs) Handles btnPlusCKT.Click
        foodsNum(3) += 1
        lblCharKwayTeow.Text = foodsNum(3)
    End Sub

    Private Sub Button_Minus_CharKwayTeow(sender As Object, e As EventArgs) Handles btnMinusCKT.Click
        foodsNum(3) -= 1
        If foodsNum(3) >= 0 Then
            lblCharKwayTeow.Text = foodsNum(3)
        End If
    End Sub

    Private Sub Button_Plus_LaksaPenang(sender As Object, e As EventArgs) Handles btnPlusLP.Click
        foodsNum(4) += 1
        lblLaksaPenang.Text = foodsNum(4)
    End Sub

    Private Sub Button_Minus_LaksaPenang(sender As Object, e As EventArgs) Handles btnMinusLP.Click
        foodsNum(4) -= 1
        If foodsNum(4) >= 0 Then
            lblLaksaPenang.Text = foodsNum(4)
        End If
    End Sub

    Private Sub Button_Plus_MeeBandung(sender As Object, e As EventArgs) Handles btnPlusMB.Click
        foodsNum(5) += 1
        lblMeeBandung.Text = foodsNum(5)
    End Sub

    Private Sub Button_Minus_MeeBandung(sender As Object, e As EventArgs) Handles btnMinusMB.Click
        foodsNum(5) -= 1
        If foodsNum(5) >= 0 Then
            lblMeeBandung.Text = foodsNum(5)
        End If
    End Sub

    Private Sub Button_Minus_NasiGoreng(sender As Object, e As EventArgs) Handles btnMinusNG.Click
        foodsNum(1) -= 1
        If foodsNum(1) >= 0 Then
            lblNasiGoreng.Text = foodsNum(1)
        End If
    End Sub

    Private Sub Button_Cart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Cart.Show()
        Me.Hide()
        Cart.cartUpdate()
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuOption.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Plus_NasiLemak(sender As Object, e As EventArgs) Handles btnPlusNL.Click
        foodsNum(0) += 1
        lblNasiLemak.Text = foodsNum(0)
    End Sub

    Private Sub Button_Minus_NasiLemak(sender As Object, e As EventArgs) Handles btnMinusNL.Click
        foodsNum(0) -= 1
        If foodsNum(0) >= 0 Then
            lblNasiLemak.Text = foodsNum(0)
        End If
    End Sub
End Class