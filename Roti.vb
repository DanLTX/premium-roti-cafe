Public Class Roti
    Public rotiName() As String = {"Roti Canai", "Roti Telur    ", "Roti Tisu   ", "Murtabak    ", "Roti Kaya   ", "Sarang Burung"}
    Public rotiPrice() As Double = {4, 5.2, 5.5, 5.8, 4.5, 5.9}

    Public rotiNum(5) As Integer

    Private Sub Button_Minus_RotiTelur(sender As Object, e As EventArgs) Handles btnMinusRT.Click
        rotiNum(1) -= 1
        If rotiNum(1) >= 0 Then
            lblRotiTelur.Text = rotiNum(1)
        End If
    End Sub

    Private Sub Button_Plus_RotiTisu(sender As Object, e As EventArgs) Handles btnPlusRTS.Click
        rotiNum(2) += 1
        lblRotiTisu.Text = rotiNum(2)
    End Sub

    Private Sub Button_Minus_RotiTisu(sender As Object, e As EventArgs) Handles btnMinusRTS.Click
        rotiNum(2) -= 1
        If rotiNum(2) >= 0 Then
            lblRotiTisu.Text = rotiNum(2)
        End If
    End Sub

    Private Sub Button_Plus_Murtabak(sender As Object, e As EventArgs) Handles btnPlusM.Click
        rotiNum(3) += 1
        lblMurtabak.Text = rotiNum(3)
    End Sub

    Private Sub Button_Minus_Murtabak(sender As Object, e As EventArgs) Handles btnMinusM.Click
        rotiNum(3) -= 1
        If rotiNum(3) >= 0 Then
            lblMurtabak.Text = rotiNum(3)
        End If
    End Sub

    Private Sub Button_Plus_RotiKaya(sender As Object, e As EventArgs) Handles btnPlusRK.Click
        rotiNum(4) += 1
        lblRotiKaya.Text = rotiNum(4)
    End Sub

    Private Sub Button_Minus_RotiKaya(sender As Object, e As EventArgs) Handles btnMinusRK.Click
        rotiNum(4) -= 1
        If rotiNum(4) >= 0 Then
            lblRotiKaya.Text = rotiNum(4)
        End If
    End Sub

    Private Sub Button_Plus_SarangBurung(sender As Object, e As EventArgs) Handles btnPlusSB.Click
        rotiNum(5) += 1
        lblSarangBurung.Text = rotiNum(5)
    End Sub

    Private Sub Button_Minus_SarangBurung(sender As Object, e As EventArgs) Handles btnMinusSB.Click
        rotiNum(5) -= 1
        If rotiNum(5) >= 0 Then
            lblSarangBurung.Text = rotiNum(5)
        End If
    End Sub

    Private Sub Button_Plus_RotiTelur(sender As Object, e As EventArgs) Handles btnPlusRT.Click
        rotiNum(1) += 1
        lblRotiTelur.Text = rotiNum(1)
    End Sub

    Private Sub Button_Minus_RotiCanai(sender As Object, e As EventArgs) Handles btnMinusRC.Click
        rotiNum(0) -= 1
        If rotiNum(0) >= 0 Then
            lblRotiCanai.Text = rotiNum(0)
        End If
    End Sub

    Private Sub Button_Plus_RotiCanai(sender As Object, e As EventArgs) Handles btnPlusRC.Click
        rotiNum(0) += 1
        lblRotiCanai.Text = rotiNum(0)
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