<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentOption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Sienna
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 548)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 43)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCard
        '
        Me.btnCard.BackgroundImage = Global.GroupProjectNew.My.Resources.Resources.photo_6133907576312676299_x
        Me.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCard.Font = New System.Drawing.Font("Franklin Gothic Demi", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnCard.Location = New System.Drawing.Point(514, 185)
        Me.btnCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(260, 258)
        Me.btnCard.TabIndex = 4
        Me.btnCard.Text = "CREDIT/DEBIT CARD"
        Me.btnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCard.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.BackgroundImage = Global.GroupProjectNew.My.Resources.Resources.photo_6133907576312676298_x
        Me.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCash.Font = New System.Drawing.Font("Franklin Gothic Demi", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnCash.Location = New System.Drawing.Point(160, 185)
        Me.btnCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(260, 258)
        Me.btnCash.TabIndex = 3
        Me.btnCash.Text = "CASH"
        Me.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(244, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(455, 94)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Payment Option"
        '
        'PaymentOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProjectNew.My.Resources.Resources.photo_6133907576312676297_y
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 602)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnCash)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PaymentOption"
        Me.Text = "PaymentOption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnCard As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents Label3 As Label
End Class
