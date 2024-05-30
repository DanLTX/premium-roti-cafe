<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebitCreditCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.cvvBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.expiryBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cardnumBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 16
        Me.lstCart.Location = New System.Drawing.Point(268, 301)
        Me.lstCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(357, 164)
        Me.lstCart.TabIndex = 21
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblGrandTotal.Location = New System.Drawing.Point(210, 125)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(172, 25)
        Me.lblGrandTotal.TabIndex = 20
        Me.lblGrandTotal.Text = "GRAND TOTAL:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Sienna
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 544)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 47)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Sienna
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(797, 544)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 47)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'cvvBox
        '
        Me.cvvBox.Location = New System.Drawing.Point(380, 240)
        Me.cvvBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cvvBox.MaxLength = 3
        Me.cvvBox.Name = "cvvBox"
        Me.cvvBox.Size = New System.Drawing.Size(100, 22)
        Me.cvvBox.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(337, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CVV:"
        '
        'expiryBox
        '
        Me.expiryBox.Location = New System.Drawing.Point(380, 212)
        Me.expiryBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.expiryBox.MaxLength = 5
        Me.expiryBox.Name = "expiryBox"
        Me.expiryBox.Size = New System.Drawing.Size(100, 22)
        Me.expiryBox.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(294, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Expiry Date:"
        '
        'cardnumBox
        '
        Me.cardnumBox.Location = New System.Drawing.Point(380, 179)
        Me.cardnumBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cardnumBox.MaxLength = 16
        Me.cardnumBox.Name = "cardnumBox"
        Me.cardnumBox.Size = New System.Drawing.Size(193, 22)
        Me.cardnumBox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(264, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CARD NUMBER:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 51)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CREDIT/DEBIT CARD"
        '
        'DebitCreditCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProjectNew.My.Resources.Resources.photo_6133907576312676297_y
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 602)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cvvBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.expiryBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cardnumBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DebitCreditCard"
        Me.Text = "DebitCreditCard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCart As ListBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents cvvBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents expiryBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cardnumBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
