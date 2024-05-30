<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodReport
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuData = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RotiCafeDatabaseDataSet1 = New GroupProjectNew.RotiCafeDatabaseDataSet1()
        Me.MenuTableAdapter = New GroupProjectNew.RotiCafeDatabaseDataSet1TableAdapters.MenuTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLstOrder = New System.Windows.Forms.Button()
        Me.btnYReport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.MenuData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotiCafeDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuData
        '
        Me.MenuData.AutoGenerateColumns = False
        Me.MenuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.CaloriesDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn})
        Me.MenuData.DataSource = Me.MenuBindingSource
        Me.MenuData.Location = New System.Drawing.Point(148, 239)
        Me.MenuData.Name = "MenuData"
        Me.MenuData.RowHeadersWidth = 51
        Me.MenuData.RowTemplate.Height = 24
        Me.MenuData.Size = New System.Drawing.Size(1027, 233)
        Me.MenuData.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'FoodNameDataGridViewTextBoxColumn
        '
        Me.FoodNameDataGridViewTextBoxColumn.DataPropertyName = "Food Name"
        Me.FoodNameDataGridViewTextBoxColumn.HeaderText = "Food Name"
        Me.FoodNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FoodNameDataGridViewTextBoxColumn.Name = "FoodNameDataGridViewTextBoxColumn"
        Me.FoodNameDataGridViewTextBoxColumn.Width = 125
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 125
        '
        'CaloriesDataGridViewTextBoxColumn
        '
        Me.CaloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.HeaderText = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CaloriesDataGridViewTextBoxColumn.Name = "CaloriesDataGridViewTextBoxColumn"
        Me.CaloriesDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.Width = 125
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "Menu"
        Me.MenuBindingSource.DataSource = Me.RotiCafeDatabaseDataSet1
        '
        'RotiCafeDatabaseDataSet1
        '
        Me.RotiCafeDatabaseDataSet1.DataSetName = "RotiCafeDatabaseDataSet1"
        Me.RotiCafeDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Sienna
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(13, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 35)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLstOrder
        '
        Me.btnLstOrder.BackColor = System.Drawing.Color.Sienna
        Me.btnLstOrder.ForeColor = System.Drawing.Color.White
        Me.btnLstOrder.Location = New System.Drawing.Point(13, 239)
        Me.btnLstOrder.Name = "btnLstOrder"
        Me.btnLstOrder.Size = New System.Drawing.Size(108, 97)
        Me.btnLstOrder.TabIndex = 2
        Me.btnLstOrder.Text = "Last Order"
        Me.btnLstOrder.UseVisualStyleBackColor = False
        '
        'btnYReport
        '
        Me.btnYReport.BackColor = System.Drawing.Color.Sienna
        Me.btnYReport.ForeColor = System.Drawing.Color.White
        Me.btnYReport.Location = New System.Drawing.Point(12, 375)
        Me.btnYReport.Name = "btnYReport"
        Me.btnYReport.Size = New System.Drawing.Size(108, 97)
        Me.btnYReport.TabIndex = 3
        Me.btnYReport.Text = "Yearly Report"
        Me.btnYReport.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(433, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(365, 94)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Food Report"
        '
        'FoodReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProjectNew.My.Resources.Resources.photo_6133907576312676297_y
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 689)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnYReport)
        Me.Controls.Add(Me.btnLstOrder)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.MenuData)
        Me.Name = "FoodReport"
        Me.Text = "FoodReport"
        CType(Me.MenuData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotiCafeDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuData As DataGridView
    Friend WithEvents RotiCafeDatabaseDataSet1 As RotiCafeDatabaseDataSet1
    Friend WithEvents MenuBindingSource As BindingSource
    Friend WithEvents MenuTableAdapter As RotiCafeDatabaseDataSet1TableAdapters.MenuTableAdapter
    Friend WithEvents btnBack As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnLstOrder As Button
    Friend WithEvents btnYReport As Button
    Friend WithEvents Label3 As Label
End Class
