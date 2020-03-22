<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIdentification = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.txtDeliveryAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.ckbRetail = New System.Windows.Forms.CheckBox()
        Me.ckbTrade = New System.Windows.Forms.CheckBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblNameInput = New System.Windows.Forms.Label()
        Me.lblDeliveryAddress = New System.Windows.Forms.Label()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(163, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Information Collection"
        '
        'lblIdentification
        '
        Me.lblIdentification.AutoSize = True
        Me.lblIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblIdentification.ForeColor = System.Drawing.Color.Snow
        Me.lblIdentification.Location = New System.Drawing.Point(411, 10)
        Me.lblIdentification.Name = "lblIdentification"
        Me.lblIdentification.Size = New System.Drawing.Size(124, 15)
        Me.lblIdentification.TabIndex = 1
        Me.lblIdentification.Text = "Identification Number"
        '
        'pbxLogo
        '
        Me.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxLogo.Image = Global.BobsOrderingMenu.My.Resources.Resources.logo_transparent
        Me.pbxLogo.Location = New System.Drawing.Point(414, 28)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(121, 116)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(232, 162)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(110, 55)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(100, 20)
        Me.txtNameInput.TabIndex = 4
        '
        'txtDeliveryAddress
        '
        Me.txtDeliveryAddress.Location = New System.Drawing.Point(110, 81)
        Me.txtDeliveryAddress.Name = "txtDeliveryAddress"
        Me.txtDeliveryAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtDeliveryAddress.TabIndex = 5
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(110, 107)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerAddress.TabIndex = 6
        '
        'ckbRetail
        '
        Me.ckbRetail.AutoSize = True
        Me.ckbRetail.Location = New System.Drawing.Point(16, 168)
        Me.ckbRetail.Name = "ckbRetail"
        Me.ckbRetail.Size = New System.Drawing.Size(53, 17)
        Me.ckbRetail.TabIndex = 7
        Me.ckbRetail.Text = "Retail"
        Me.ckbRetail.UseVisualStyleBackColor = True
        '
        'ckbTrade
        '
        Me.ckbTrade.AutoSize = True
        Me.ckbTrade.Location = New System.Drawing.Point(16, 191)
        Me.ckbTrade.Name = "ckbTrade"
        Me.ckbTrade.Size = New System.Drawing.Size(54, 17)
        Me.ckbTrade.TabIndex = 8
        Me.ckbTrade.Text = "Trade"
        Me.ckbTrade.UseVisualStyleBackColor = True
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(76, 192)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(72, 13)
        Me.lblDiscount.TabIndex = 9
        Me.lblDiscount.Text = "10% Discount"
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(313, 162)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 10
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lblNameInput
        '
        Me.lblNameInput.AutoSize = True
        Me.lblNameInput.Location = New System.Drawing.Point(38, 58)
        Me.lblNameInput.Name = "lblNameInput"
        Me.lblNameInput.Size = New System.Drawing.Size(66, 13)
        Me.lblNameInput.TabIndex = 11
        Me.lblNameInput.Text = "Given Name"
        '
        'lblDeliveryAddress
        '
        Me.lblDeliveryAddress.AutoSize = True
        Me.lblDeliveryAddress.Location = New System.Drawing.Point(13, 84)
        Me.lblDeliveryAddress.Name = "lblDeliveryAddress"
        Me.lblDeliveryAddress.Size = New System.Drawing.Size(86, 13)
        Me.lblDeliveryAddress.TabIndex = 12
        Me.lblDeliveryAddress.Text = "Delivery Address"
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Location = New System.Drawing.Point(13, 110)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(92, 13)
        Me.lblCustomerAddress.TabIndex = 13
        Me.lblCustomerAddress.Text = "Customer Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Surname"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(288, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 410)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCustomerAddress)
        Me.Controls.Add(Me.lblDeliveryAddress)
        Me.Controls.Add(Me.lblNameInput)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.ckbTrade)
        Me.Controls.Add(Me.ckbRetail)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtDeliveryAddress)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.lblIdentification)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCollection"
        Me.Text = "Form1"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblIdentification As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents txtDeliveryAddress As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents ckbRetail As CheckBox
    Friend WithEvents ckbTrade As CheckBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblNameInput As Label
    Friend WithEvents lblDeliveryAddress As Label
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
