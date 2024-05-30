Public Class Cart
    Public grandTotal, total, tax As Double
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuOption.Show()
        Me.Hide()
    End Sub

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cartUpdate()
    End Sub

    Private Sub FontMenu_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        lstCart.Font = FontDialog1.Font
        lblTotal.Font = FontDialog1.Font
        lblTax.Font = FontDialog1.Font
        lblGrandTotal.Font = FontDialog1.Font
    End Sub

    Private Sub ColourMenu_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        lstCart.ForeColor = ColorDialog1.Color
        lblTotal.ForeColor = ColorDialog1.Color
        lblTax.ForeColor = ColorDialog1.Color
        lblGrandTotal.ForeColor = ColorDialog1.Color
    End Sub

    'sub function definition
    Public Sub cartUpdate()
        total = 0.0
        tax = 0.0
        grandTotal = 0.0

        lstCart.Items.Clear()
        lstCart.Items.Add("Qty" & vbTab & "Item" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "Price")

        'foods
        For i = 0 To 5
            If Foods.foodsNum(i) > 0 Then
                lstCart.Items.Add(Foods.foodsNum(i) & vbTab & Foods.foodsName(i) & vbTab & vbTab & vbTab & vbTab & vbTab & "RM " & Format((Foods.foodsPrice(i) * Foods.foodsNum(i)), "0.00"))
                total += Foods.foodsPrice(i) * Foods.foodsNum(i)
            End If
        Next

        'drinks
        For i = 0 To 5
            If Drinks.drinksNum(i) > 0 Then
                lstCart.Items.Add(Drinks.drinksNum(i) & vbTab & Drinks.drinksName(i) & vbTab & vbTab & vbTab & vbTab & vbTab & "RM " & Format((Drinks.drinksPrice(i) * Drinks.drinksNum(i)), "0.00"))
                total += Drinks.drinksPrice(i) * Drinks.drinksNum(i)
            End If
        Next

        'desserts
        For i = 0 To 5
            If Desserts.dessertsNum(i) > 0 Then
                lstCart.Items.Add(Desserts.dessertsNum(i) & vbTab & Desserts.dessertsName(i) & vbTab & vbTab & vbTab & vbTab & vbTab & "RM " & Format((Desserts.dessertsPrice(i) * Desserts.dessertsNum(i)), "0.00"))
                total += Desserts.dessertsPrice(i) * Desserts.dessertsNum(i)
            End If
        Next

        'roti
        For i = 0 To 5
            If Roti.rotiNum(i) > 0 Then
                lstCart.Items.Add(Roti.rotiNum(i) & vbTab & Roti.rotiName(i) & vbTab & vbTab & vbTab & vbTab & vbTab & "RM " & Format((Roti.rotiPrice(i) * Roti.rotiNum(i)), "0.00"))
                total += Roti.rotiPrice(i) * Roti.rotiNum(i)
            End If
        Next



        lblTotal.Text = "Total: RM" & Format(total, "0.00")
        tax = calcTax(total)
        lblTax.Text = "Tax: RM" & Format(tax, "0.00")
        grandTotal = calcGrandTotal(total, tax)
        lblGrandTotal.Text = "Grand Total: RM" & Format(grandTotal, "0.00")
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If lstCart.Items.Count = 1 Then
            MsgBox("CART IS EMPTY!!!", vbExclamation, "ERROR")
        Else
            PaymentOption.Show()
            Me.Hide()
        End If

    End Sub

    Private Function calcTax(ByVal total As Double) As Double
        Dim tax As Double

        tax = total * 0.06

        Return tax
    End Function

    Private Function calcGrandTotal(ByVal total As Double, ByVal tax As Double)
        Dim grand As Double

        grand = total + tax

        Return grand
    End Function
End Class