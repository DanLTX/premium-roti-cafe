Public Class Desserts
    Public dessertsName() As String = {"Ais Kacang ", "Cendol     ", "Apam Balik", "Pulut Hitam", "Karipap    ", "Pisang Goreng"}
    Public dessertsPrice() As Double = {7.2, 6.8, 6.3, 5.9, 6, 5.8}

    Public dessertsNum(5) As Integer
    Private Sub Button_Minus_Cendol(sender As Object, e As EventArgs) Handles btnMinusC.Click
        dessertsNum(1) -= 1
        If dessertsNum(1) >= 0 Then
            lblCendol.Text = dessertsNum(1)
        End If
    End Sub

    Private Sub Button_Plus_ApamBalik(sender As Object, e As EventArgs) Handles btnPlusAB.Click
        dessertsNum(2) += 1
        lblApamBalik.Text = dessertsNum(2)
    End Sub

    Private Sub Button_Minus_ApamBalik(sender As Object, e As EventArgs) Handles btnMinusAB.Click
        dessertsNum(2) -= 1
        If dessertsNum(2) >= 0 Then
            lblApamBalik.Text = dessertsNum(2)
        End If
    End Sub

    Private Sub Button_Plus_PulutHitam(sender As Object, e As EventArgs) Handles btnPlusPH.Click
        dessertsNum(3) += 1
        lblPulutHitam.Text = dessertsNum(3)
    End Sub

    Private Sub Button_Minus_PulutHitam(sender As Object, e As EventArgs) Handles btnMinusPH.Click
        dessertsNum(3) -= 1
        If dessertsNum(3) >= 0 Then
            lblPulutHitam.Text = dessertsNum(3)
        End If
    End Sub

    Private Sub Button_Plus_Karipap(sender As Object, e As EventArgs) Handles btnPlusK.Click
        dessertsNum(4) += 1
        lblKaripap.Text = dessertsNum(4)
    End Sub

    Private Sub Button_Minus_Karipap(sender As Object, e As EventArgs) Handles btnMinusK.Click
        dessertsNum(4) -= 1
        If dessertsNum(4) >= 0 Then
            lblKaripap.Text = dessertsNum(4)
        End If
    End Sub

    Private Sub Button_Plus_PisangGoreng(sender As Object, e As EventArgs) Handles btnPlusPG.Click
        dessertsNum(5) += 1
        lblPisangGoreng.Text = dessertsNum(5)
    End Sub

    Private Sub Button_Minus_PisangGoreng(sender As Object, e As EventArgs) Handles btnMinusPG.Click
        dessertsNum(5) -= 1
        If dessertsNum(5) >= 0 Then
            lblPisangGoreng.Text = dessertsNum(5)
        End If
    End Sub

    Private Sub Button_Plus_Cendol(sender As Object, e As EventArgs) Handles btnPlusC.Click
        dessertsNum(1) += 1
        lblCendol.Text = dessertsNum(1)
    End Sub

    Private Sub Button_Minus_AisKacang(sender As Object, e As EventArgs) Handles btnMinusAK.Click
        dessertsNum(0) -= 1
        If dessertsNum(0) >= 0 Then
            lblAisKacang.Text = dessertsNum(0)
        End If
    End Sub

    Private Sub Button_Plus_AisKacang(sender As Object, e As EventArgs) Handles btnPlusAK.Click
        dessertsNum(0) += 1
        lblAisKacang.Text = dessertsNum(0)
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