Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class ThankYou
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("==================================================", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, 0, 0)
        e.Graphics.DrawString("PREMIUM ROTI CAFE", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, 230, 30)
        e.Graphics.DrawString("==================================================", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, 0, 50)
        e.Graphics.DrawString("NO. 45, GROUND FLOOR, ONE SEGAMAT,", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 200, 90)
        e.Graphics.DrawString("JALAN KOLAM AIR, KAMPUNG GUBAH", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 200, 110)
        e.Graphics.DrawString("85000 SEGAMAT, JOHOR,", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 280, 130)
        e.Graphics.DrawString("MALAYSIA", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 340, 150)
        e.Graphics.DrawString("==================================================", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, 0, 170)

        Dim startY = 210
        For count = 0 To Cart.lstCart.Items.Count - 1
            e.Graphics.DrawString(Cart.lstCart.Items(count), New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 50, startY)
            startY += 30
        Next

        e.Graphics.DrawString(vbTab & "SUBTOTAL:" & vbTab & vbTab & vbTab & vbTab & vbTab & "RM" & Format(Cart.total, "0.00"), New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 50, startY + 30)
        e.Graphics.DrawString(vbTab & "TAX:" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "RM" & Format(Cart.tax, "0.00"), New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 50, startY + 60)
        e.Graphics.DrawString(vbTab & "GRAND TOTAL:" & vbTab & vbTab & vbTab & vbTab & vbTab & "RM" & Format(Cart.grandTotal, "0.00"), New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 50, startY + 90)
        e.Graphics.DrawString("==================================================", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, 0, startY + 110)
        e.Graphics.DrawString("THANK YOU FOR DINING WITH US", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 230, startY + 130)

    End Sub

    Private Sub Button_Repeat_Click(sender As Object, e As EventArgs) Handles btnRepeat.Click
        MenuOption.Show()
        Me.Hide()
        resetOrder()
    End Sub

    Private Sub Button_MainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Public Sub resetOrder()
        Cart.lstCart.Items.Clear()
        Cart.total = 0.0
        Cart.tax = 0.0
        Cart.grandTotal = 0.0
        For i = 0 To 5
            Foods.foodsNum(i) = 0
        Next
        For i = 0 To 5
            Drinks.drinksNum(i) = 0
        Next
        For i = 0 To 5
            Desserts.dessertsNum(i) = 0
        Next
        For i = 0 To 5
            Roti.rotiNum(i) = 0
        Next
        Foods.lblNasiLemak.Text = 0
        Foods.lblNasiKerabu.Text = 0
        Foods.lblNasiGoreng.Text = 0
        Foods.lblLaksaPenang.Text = 0
        Foods.lblCharKwayTeow.Text = 0
        Foods.lblMeeBandung.Text = 0

        Drinks.lblAirBandung.Text = 0
        Drinks.lblKopiAis.Text = 0
        Drinks.lblMiloDinosaur.Text = 0
        Drinks.lblSirapSelasih.Text = 0
        Drinks.lblTehLimau.Text = 0
        Drinks.lblTehTarik.Text = 0

        Desserts.lblAisKacang.Text = 0
        Desserts.lblApamBalik.Text = 0
        Desserts.lblCendol.Text = 0
        Desserts.lblKaripap.Text = 0
        Desserts.lblPisangGoreng.Text = 0
        Desserts.lblPulutHitam.Text = 0

        Roti.lblMurtabak.Text = 0
        Roti.lblRotiCanai.Text = 0
        Roti.lblRotiKaya.Text = 0
        Roti.lblRotiTelur.Text = 0
        Roti.lblRotiTisu.Text = 0
        Roti.lblSarangBurung.Text = 0
    End Sub

    Private Sub Menu_Preview_Click(sender As Object, e As EventArgs) Handles menuPreview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Menu_Print_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub Menu_End_Click(sender As Object, e As EventArgs) Handles menuEnd.Click
        End
    End Sub
End Class