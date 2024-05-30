Public Class DebitCreditCard
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        PaymentOption.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim cardnum, expiry, cvv As String
        cardnum = cardnumBox.Text
        expiry = expiryBox.Text
        cvv = cvvBox.Text
        If cardnumBox.Text.Any And expiryBox.Text.Any And cvvBox.Text.Any Then
            If IsNumeric(cardnum) And IsNumeric(cvv) Then
                If cardnum.Length = 16 Then
                    If cvv.Length = 3 Then
                        ThankYou.Show()
                        Me.Hide()
                    Else
                        MsgBox("WRONG CVV NUMBER!!!", vbExclamation, "ERROR")
                    End If

                Else
                    MsgBox("WRONG CREDIT/DEBIT NUMBER!!!", vbExclamation, "ERROR")
                End If

            Else
                    MsgBox("INCORRECT INPUT FORMAT!!!", vbExclamation, "ERROR")
            End If

        Else
            MsgBox("PLEASE FILL IN CREDIT/DEBIT CARD DETAILS!!!", vbExclamation, "ERROR")
        End If
    End Sub
End Class