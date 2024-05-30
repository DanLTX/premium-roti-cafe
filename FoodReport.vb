Imports System.IO

Public Class FoodReport
    Private Sub FoodReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RotiCafeDatabaseDataSet1.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.RotiCafeDatabaseDataSet1.Menu)

    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button_LastOrder_Click(sender As Object, e As EventArgs) Handles btnLstOrder.Click
        Dim foodFile As StreamWriter
        Try
            foodFile = File.CreateText("FoodReport.txt")
            foodFile.WriteLine("[LAST ORDER]")
            For count = 0 To Cart.lstCart.Items.Count - 1
                foodFile.WriteLine(Cart.lstCart.Items(count))
            Next
            foodFile.WriteLine("SUBTOTAL: RM" & Format(Cart.total, "0.00"))
            foodFile.WriteLine("TAX: RM" & Format(Cart.tax, "0.00"))
            foodFile.WriteLine("GRAND TOTAL: RM" & Format(Cart.grandTotal, "0.00"))

            foodFile.Close()
        Catch ex As Exception
            MessageBox.Show("The file cannot be created!!")

        End Try
    End Sub

    Private Sub Button_YearReport_Click(sender As Object, e As EventArgs) Handles btnYReport.Click
        Dim inputYearFile As StreamReader
        Dim yearReportFile As StreamWriter
        Dim line, data() As String
        Dim average, total, totalAll As Double
        Dim highest As Double = 0
        Dim lowest As Double = 999999999
        Dim count As Integer = 0
        Try
            yearReportFile = File.CreateText("YearlyReport.txt")
            yearReportFile.WriteLine("Year" & vbTab & "Gross Profit" & vbTab & "Expenses" & vbTab & "Net Profit")

            If File.Exists("yearlyProfit.txt") = False Then
            End If

            If File.Exists("yearlyProfit.txt") = True Then
                inputYearFile = File.OpenText("yearlyProfit.txt")
                Do Until inputYearFile.EndOfStream
                    line = inputYearFile.ReadLine()
                    data = line.Split(";")
                    total = data(1) - data(2)
                    yearReportFile.WriteLine(data(0) & vbTab & data(1) & vbTab & vbTab & data(2) & vbTab & vbTab & total)
                    If total > highest Then
                        highest = total
                    End If
                    If total < lowest Then
                        lowest = total
                    End If
                    count = count + 1
                    totalAll = totalAll + total
                Loop
                average = totalAll / count
                yearReportFile.WriteLine(vbNewLine & "Total All Net Profit:" & vbTab & "RM" & Format(totalAll, "0.00"))
                yearReportFile.WriteLine("The Highest Net Profit:" & vbTab & "RM" & Format(highest, "0.00"))
                yearReportFile.WriteLine("The Lowest Net Profit:" & vbTab & "RM" & Format(lowest, "0.00"))
                yearReportFile.WriteLine("Average Net Profit:" & vbTab & "RM" & Format(average, "0.00"))
            End If
            yearReportFile.Close()
            inputYearFile.Close()
        Catch ex As Exception
            MessageBox.Show("The file cannot be created!!")
        End Try
    End Sub
End Class