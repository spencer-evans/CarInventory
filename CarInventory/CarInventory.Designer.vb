<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.ckNew = New System.Windows.Forms.CheckBox()
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(30, 19)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(47, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Ma&ke:"
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(26, 51)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(51, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Mo&del:"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(97, 49)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(158, 22)
        Me.txtModel.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtModel, "Input car model")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(34, 83)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(43, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(32, 115)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(45, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(97, 113)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(158, 22)
        Me.txtPrice.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtPrice, "Input price of car")
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(37, 147)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(40, 23)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New:"
        '
        'ckNew
        '
        Me.ckNew.AutoSize = True
        Me.ckNew.Location = New System.Drawing.Point(97, 148)
        Me.ckNew.Name = "ckNew"
        Me.ckNew.Size = New System.Drawing.Size(18, 17)
        Me.ckNew.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ckNew, "Check if car is new")
        Me.ckNew.UseVisualStyleBackColor = True
        '
        'lvInventory
        '
        Me.lvInventory.CheckBoxes = True
        Me.lvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvInventory.FullRowSelect = True
        Me.lvInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvInventory.HideSelection = False
        Me.lvInventory.Location = New System.Drawing.Point(14, 184)
        Me.lvInventory.MultiSelect = False
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(607, 227)
        Me.lvInventory.TabIndex = 10
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        Me.lvInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 48
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 45
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 120
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 115
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 68
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 94
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(97, 80)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(158, 24)
        Me.cbYear.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cbYear, "Select year made from list")
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Chevrolet", "Honda", "Hyundai", "Mazda", "Toyota", "Volkswagen"})
        Me.cbMake.Location = New System.Drawing.Point(97, 16)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(158, 24)
        Me.cbMake.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbMake, "Select manufacturer from list")
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(14, 423)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(607, 92)
        Me.lblOutput.TabIndex = 11
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(333, 530)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(87, 32)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Input entered data")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(431, 530)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 32)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Clear form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(529, 530)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 32)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Close application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(633, 574)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.lvInventory)
        Me.Controls.Add(Me.ckNew)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblNew As Label
    Friend WithEvents ckNew As CheckBox
    Friend WithEvents lvInventory As ListView
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
