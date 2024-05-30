Imports System.Data.OleDb
'"C:\Users\drago\OneDrive\Documents\RotiCafeDatabase.accdb"
Public Class Login
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\RotiCafeDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT * FROM Login WHERE Username='" & txtUsername.Text &
                                    "' and Password='" & txtPassword.Text & "'", conn)
        Dim user As String = " "
        Dim pass As String = " "
        conn.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If sdr.Read() = True Then
            user = sdr("Username")
            pass = sdr("Password")
            MessageBox.Show("Login Successfully!")
            MainMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password!")
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RotiCafeDatabaseDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.RotiCafeDatabaseDataSet.Login)

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub
End Class
