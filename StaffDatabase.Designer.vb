<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDatabase
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
        Dim Staff_IDLabel As System.Windows.Forms.Label
        Dim Staff_NameLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim Hire_of_DateLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HireOfDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RotiCafeDatabaseDataSet2 = New GroupProjectNew.RotiCafeDatabaseDataSet2()
        Me.StaffTableAdapter = New GroupProjectNew.RotiCafeDatabaseDataSet2TableAdapters.StaffTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New GroupProjectNew.RotiCafeDatabaseDataSet2TableAdapters.TableAdapterManager()
        Me.Staff_IDLabel1 = New System.Windows.Forms.Label()
        Me.Staff_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Hire_of_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Staff_IDLabel = New System.Windows.Forms.Label()
        Staff_NameLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Hire_of_DateLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotiCafeDatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_IDLabel
        '
        Staff_IDLabel.AutoSize = True
        Staff_IDLabel.BackColor = System.Drawing.Color.Transparent
        Staff_IDLabel.ForeColor = System.Drawing.Color.White
        Staff_IDLabel.Location = New System.Drawing.Point(209, 120)
        Staff_IDLabel.Name = "Staff_IDLabel"
        Staff_IDLabel.Size = New System.Drawing.Size(52, 16)
        Staff_IDLabel.TabIndex = 2
        Staff_IDLabel.Text = "Staff ID:"
        '
        'Staff_NameLabel
        '
        Staff_NameLabel.AutoSize = True
        Staff_NameLabel.BackColor = System.Drawing.Color.Transparent
        Staff_NameLabel.ForeColor = System.Drawing.Color.White
        Staff_NameLabel.Location = New System.Drawing.Point(209, 149)
        Staff_NameLabel.Name = "Staff_NameLabel"
        Staff_NameLabel.Size = New System.Drawing.Size(76, 16)
        Staff_NameLabel.TabIndex = 4
        Staff_NameLabel.Text = "Staff Name:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.BackColor = System.Drawing.Color.Transparent
        PositionLabel.ForeColor = System.Drawing.Color.White
        PositionLabel.Location = New System.Drawing.Point(209, 177)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(58, 16)
        PositionLabel.TabIndex = 6
        PositionLabel.Text = "Position:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.BackColor = System.Drawing.Color.Transparent
        Phone_NumberLabel.ForeColor = System.Drawing.Color.White
        Phone_NumberLabel.Location = New System.Drawing.Point(209, 205)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(100, 16)
        Phone_NumberLabel.TabIndex = 8
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.BackColor = System.Drawing.Color.Transparent
        SalaryLabel.ForeColor = System.Drawing.Color.White
        SalaryLabel.Location = New System.Drawing.Point(209, 233)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(49, 16)
        SalaryLabel.TabIndex = 10
        SalaryLabel.Text = "Salary:"
        '
        'Hire_of_DateLabel
        '
        Hire_of_DateLabel.AutoSize = True
        Hire_of_DateLabel.BackColor = System.Drawing.Color.Transparent
        Hire_of_DateLabel.ForeColor = System.Drawing.Color.White
        Hire_of_DateLabel.Location = New System.Drawing.Point(209, 262)
        Hire_of_DateLabel.Name = "Hire_of_DateLabel"
        Hire_of_DateLabel.Size = New System.Drawing.Size(81, 16)
        Hire_of_DateLabel.TabIndex = 12
        Hire_of_DateLabel.Text = "Hire of Date:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.HireOfDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 305)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1067, 176)
        Me.DataGridView1.TabIndex = 0
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.Width = 125
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        Me.StaffNameDataGridViewTextBoxColumn.Width = 125
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 125
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.Width = 125
        '
        'HireOfDateDataGridViewTextBoxColumn
        '
        Me.HireOfDateDataGridViewTextBoxColumn.DataPropertyName = "Hire of Date"
        Me.HireOfDateDataGridViewTextBoxColumn.HeaderText = "Hire of Date"
        Me.HireOfDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HireOfDateDataGridViewTextBoxColumn.Name = "HireOfDateDataGridViewTextBoxColumn"
        Me.HireOfDateDataGridViewTextBoxColumn.Width = 125
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.RotiCafeDatabaseDataSet2
        '
        'RotiCafeDatabaseDataSet2
        '
        Me.RotiCafeDatabaseDataSet2.DataSetName = "RotiCafeDatabaseDataSet2"
        Me.RotiCafeDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Sienna
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(26, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 40)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = GroupProjectNew.RotiCafeDatabaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Staff_IDLabel1
        '
        Me.Staff_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff ID", True))
        Me.Staff_IDLabel1.Location = New System.Drawing.Point(315, 120)
        Me.Staff_IDLabel1.Name = "Staff_IDLabel1"
        Me.Staff_IDLabel1.Size = New System.Drawing.Size(480, 23)
        Me.Staff_IDLabel1.TabIndex = 3
        '
        'Staff_NameTextBox
        '
        Me.Staff_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Name", True))
        Me.Staff_NameTextBox.Location = New System.Drawing.Point(315, 146)
        Me.Staff_NameTextBox.Name = "Staff_NameTextBox"
        Me.Staff_NameTextBox.Size = New System.Drawing.Size(480, 22)
        Me.Staff_NameTextBox.TabIndex = 5
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(315, 174)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(480, 22)
        Me.PositionTextBox.TabIndex = 7
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(315, 202)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(480, 22)
        Me.Phone_NumberTextBox.TabIndex = 9
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(315, 230)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(480, 22)
        Me.SalaryTextBox.TabIndex = 11
        '
        'Hire_of_DateDateTimePicker
        '
        Me.Hire_of_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Hire of Date", True))
        Me.Hire_of_DateDateTimePicker.Location = New System.Drawing.Point(315, 258)
        Me.Hire_of_DateDateTimePicker.Name = "Hire_of_DateDateTimePicker"
        Me.Hire_of_DateDateTimePicker.Size = New System.Drawing.Size(480, 22)
        Me.Hire_of_DateDateTimePicker.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Sienna
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(841, 141)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 37)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Sienna
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(841, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 37)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Sienna
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(841, 233)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 37)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(365, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 94)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Staff Database"
        '
        'StaffDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProjectNew.My.Resources.Resources.photo_6133907576312676297_y
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1117, 613)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Staff_IDLabel)
        Me.Controls.Add(Me.Staff_IDLabel1)
        Me.Controls.Add(Staff_NameLabel)
        Me.Controls.Add(Me.Staff_NameTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Hire_of_DateLabel)
        Me.Controls.Add(Me.Hire_of_DateDateTimePicker)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "StaffDatabase"
        Me.Text = "StaffDatabase"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotiCafeDatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RotiCafeDatabaseDataSet2 As RotiCafeDatabaseDataSet2
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As RotiCafeDatabaseDataSet2TableAdapters.StaffTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HireOfDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents TableAdapterManager As RotiCafeDatabaseDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Staff_IDLabel1 As Label
    Friend WithEvents Staff_NameTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents Hire_of_DateDateTimePicker As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label3 As Label
End Class
