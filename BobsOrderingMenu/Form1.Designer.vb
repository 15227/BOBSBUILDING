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
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblNameInput = New System.Windows.Forms.Label()
        Me.lblDeliveryAddress = New System.Windows.Forms.Label()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk0Rm0 = New System.Windows.Forms.CheckBox()
        Me.chk1Rm0 = New System.Windows.Forms.CheckBox()
        Me.chk2Rm0 = New System.Windows.Forms.CheckBox()
        Me.cmbRm0Sck = New System.Windows.Forms.ComboBox()
        Me.cmbRm0Pnt = New System.Windows.Forms.ComboBox()
        Me.cmbRm1Pnt = New System.Windows.Forms.ComboBox()
        Me.cmbRm1Sck = New System.Windows.Forms.ComboBox()
        Me.chk3Rm1 = New System.Windows.Forms.CheckBox()
        Me.chk2Rm1 = New System.Windows.Forms.CheckBox()
        Me.chk1Rm1 = New System.Windows.Forms.CheckBox()
        Me.cmbRm2Pnt = New System.Windows.Forms.ComboBox()
        Me.cmbRm2Sck = New System.Windows.Forms.ComboBox()
        Me.chk0Rm1 = New System.Windows.Forms.CheckBox()
        Me.chk2Rm2 = New System.Windows.Forms.CheckBox()
        Me.chk1Rm2 = New System.Windows.Forms.CheckBox()
        Me.cmbRm3Pnt = New System.Windows.Forms.ComboBox()
        Me.cmbRm3Sck = New System.Windows.Forms.ComboBox()
        Me.chk0Rm2 = New System.Windows.Forms.CheckBox()
        Me.chk2Rm3 = New System.Windows.Forms.CheckBox()
        Me.chk1Rm3 = New System.Windows.Forms.CheckBox()
        Me.cmbRm4Pnt = New System.Windows.Forms.ComboBox()
        Me.cmbRm4Sck = New System.Windows.Forms.ComboBox()
        Me.chk0Rm3 = New System.Windows.Forms.CheckBox()
        Me.chk2Rm4 = New System.Windows.Forms.CheckBox()
        Me.chk1Rm4 = New System.Windows.Forms.CheckBox()
        Me.chk0Rm4 = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.rdoRetail = New System.Windows.Forms.RadioButton()
        Me.rdoTrade = New System.Windows.Forms.RadioButton()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(338, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(163, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Information Collection"
        '
        'lblIdentification
        '
        Me.lblIdentification.AutoSize = True
        Me.lblIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentification.ForeColor = System.Drawing.Color.Snow
        Me.lblIdentification.Location = New System.Drawing.Point(9, 15)
        Me.lblIdentification.Name = "lblIdentification"
        Me.lblIdentification.Size = New System.Drawing.Size(146, 18)
        Me.lblIdentification.TabIndex = 10000
        Me.lblIdentification.Text = "Identification Number"
        '
        'pbxLogo
        '
        Me.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxLogo.Image = Global.BobsOrderingMenu.My.Resources.Resources.logo_transparent
        Me.pbxLogo.Location = New System.Drawing.Point(12, 57)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(312, 168)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(140, 472)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(304, 55)
        Me.btnNext.TabIndex = 300
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtNameInput
        '
        Me.txtNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameInput.Location = New System.Drawing.Point(448, 59)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(100, 22)
        Me.txtNameInput.TabIndex = 1
        '
        'txtDeliveryAddress
        '
        Me.txtDeliveryAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryAddress.Location = New System.Drawing.Point(448, 93)
        Me.txtDeliveryAddress.Name = "txtDeliveryAddress"
        Me.txtDeliveryAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtDeliveryAddress.TabIndex = 3
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress.Location = New System.Drawing.Point(727, 93)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerAddress.TabIndex = 4
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(633, 171)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(108, 20)
        Me.lblDiscount.TabIndex = 900
        Me.lblDiscount.Text = "10% Discount"
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(706, 472)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(321, 55)
        Me.btnRestart.TabIndex = 1000
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lblNameInput
        '
        Me.lblNameInput.AutoSize = True
        Me.lblNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameInput.Location = New System.Drawing.Point(350, 62)
        Me.lblNameInput.Name = "lblNameInput"
        Me.lblNameInput.Size = New System.Drawing.Size(83, 16)
        Me.lblNameInput.TabIndex = 1100
        Me.lblNameInput.Text = "Given Name"
        '
        'lblDeliveryAddress
        '
        Me.lblDeliveryAddress.AutoSize = True
        Me.lblDeliveryAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryAddress.Location = New System.Drawing.Point(330, 96)
        Me.lblDeliveryAddress.Name = "lblDeliveryAddress"
        Me.lblDeliveryAddress.Size = New System.Drawing.Size(112, 16)
        Me.lblDeliveryAddress.TabIndex = 1200
        Me.lblDeliveryAddress.Text = "Delivery Address"
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerAddress.Location = New System.Drawing.Point(602, 96)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(119, 16)
        Me.lblCustomerAddress.TabIndex = 1300
        Me.lblCustomerAddress.Text = "Customer Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1500
        Me.Label1.Text = "Surname"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(727, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1600
        Me.Label2.Text = "Kitchen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(350, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 1700
        Me.Label3.Text = "Bathroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(517, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 1800
        Me.Label4.Text = " Living Room"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(703, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 1900
        Me.Label5.Text = "Bedroom 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(912, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 2000
        Me.Label6.Text = "Bedroom 2"
        '
        'chk0Rm0
        '
        Me.chk0Rm0.AutoSize = True
        Me.chk0Rm0.Location = New System.Drawing.Point(140, 344)
        Me.chk0Rm0.Name = "chk0Rm0"
        Me.chk0Rm0.Size = New System.Drawing.Size(29, 17)
        Me.chk0Rm0.TabIndex = 7
        Me.chk0Rm0.Text = " "
        Me.chk0Rm0.UseVisualStyleBackColor = True
        '
        'chk1Rm0
        '
        Me.chk1Rm0.AutoSize = True
        Me.chk1Rm0.Location = New System.Drawing.Point(140, 369)
        Me.chk1Rm0.Name = "chk1Rm0"
        Me.chk1Rm0.Size = New System.Drawing.Size(29, 17)
        Me.chk1Rm0.TabIndex = 8
        Me.chk1Rm0.Text = " "
        Me.chk1Rm0.UseVisualStyleBackColor = True
        '
        'chk2Rm0
        '
        Me.chk2Rm0.AutoSize = True
        Me.chk2Rm0.Location = New System.Drawing.Point(140, 395)
        Me.chk2Rm0.Name = "chk2Rm0"
        Me.chk2Rm0.Size = New System.Drawing.Size(29, 17)
        Me.chk2Rm0.TabIndex = 9
        Me.chk2Rm0.Text = " "
        Me.chk2Rm0.UseVisualStyleBackColor = True
        '
        'cmbRm0Sck
        '
        Me.cmbRm0Sck.FormattingEnabled = True
        Me.cmbRm0Sck.Items.AddRange(New Object() {"-", "1(2G)", "2(2G)", "3(2G)", "4(2G)", "1 (1G)", "2 (1G)", "3 (1G)", "4 (1G)"})
        Me.cmbRm0Sck.Location = New System.Drawing.Point(140, 418)
        Me.cmbRm0Sck.Name = "cmbRm0Sck"
        Me.cmbRm0Sck.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm0Sck.TabIndex = 10
        Me.cmbRm0Sck.Text = " "
        '
        'cmbRm0Pnt
        '
        Me.cmbRm0Pnt.FormattingEnabled = True
        Me.cmbRm0Pnt.Location = New System.Drawing.Point(140, 445)
        Me.cmbRm0Pnt.Name = "cmbRm0Pnt"
        Me.cmbRm0Pnt.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm0Pnt.TabIndex = 11
        '
        'cmbRm1Pnt
        '
        Me.cmbRm1Pnt.FormattingEnabled = True
        Me.cmbRm1Pnt.Location = New System.Drawing.Point(353, 445)
        Me.cmbRm1Pnt.Name = "cmbRm1Pnt"
        Me.cmbRm1Pnt.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm1Pnt.TabIndex = 17
        '
        'cmbRm1Sck
        '
        Me.cmbRm1Sck.FormattingEnabled = True
        Me.cmbRm1Sck.Items.AddRange(New Object() {"-", "1(2G)", "2(2G)", "3(2G)", "4(2G)", "1 (1G)", "2 (1G)", "3 (1G)", "4 (1G)"})
        Me.cmbRm1Sck.Location = New System.Drawing.Point(353, 418)
        Me.cmbRm1Sck.Name = "cmbRm1Sck"
        Me.cmbRm1Sck.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm1Sck.TabIndex = 16
        '
        'chk3Rm1
        '
        Me.chk3Rm1.AutoSize = True
        Me.chk3Rm1.Location = New System.Drawing.Point(353, 397)
        Me.chk3Rm1.Name = "chk3Rm1"
        Me.chk3Rm1.Size = New System.Drawing.Size(29, 17)
        Me.chk3Rm1.TabIndex = 15
        Me.chk3Rm1.Text = " "
        Me.chk3Rm1.UseVisualStyleBackColor = True
        '
        'chk2Rm1
        '
        Me.chk2Rm1.AutoSize = True
        Me.chk2Rm1.Location = New System.Drawing.Point(353, 374)
        Me.chk2Rm1.Name = "chk2Rm1"
        Me.chk2Rm1.Size = New System.Drawing.Size(29, 17)
        Me.chk2Rm1.TabIndex = 14
        Me.chk2Rm1.Text = " "
        Me.chk2Rm1.UseVisualStyleBackColor = True
        '
        'chk1Rm1
        '
        Me.chk1Rm1.AutoSize = True
        Me.chk1Rm1.Location = New System.Drawing.Point(353, 351)
        Me.chk1Rm1.Name = "chk1Rm1"
        Me.chk1Rm1.Size = New System.Drawing.Size(29, 17)
        Me.chk1Rm1.TabIndex = 13
        Me.chk1Rm1.Text = " "
        Me.chk1Rm1.UseVisualStyleBackColor = True
        '
        'cmbRm2Pnt
        '
        Me.cmbRm2Pnt.FormattingEnabled = True
        Me.cmbRm2Pnt.Location = New System.Drawing.Point(520, 443)
        Me.cmbRm2Pnt.Name = "cmbRm2Pnt"
        Me.cmbRm2Pnt.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm2Pnt.TabIndex = 22
        '
        'cmbRm2Sck
        '
        Me.cmbRm2Sck.FormattingEnabled = True
        Me.cmbRm2Sck.Items.AddRange(New Object() {"-", "1(2G)", "2(2G)", "3(2G)", "4(2G)", "1 (1G)", "2 (1G)", "3 (1G)", "4 (1G)"})
        Me.cmbRm2Sck.Location = New System.Drawing.Point(520, 416)
        Me.cmbRm2Sck.Name = "cmbRm2Sck"
        Me.cmbRm2Sck.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm2Sck.TabIndex = 21
        '
        'chk0Rm1
        '
        Me.chk0Rm1.AutoSize = True
        Me.chk0Rm1.Location = New System.Drawing.Point(353, 327)
        Me.chk0Rm1.Name = "chk0Rm1"
        Me.chk0Rm1.Size = New System.Drawing.Size(29, 17)
        Me.chk0Rm1.TabIndex = 12
        Me.chk0Rm1.Text = " "
        Me.chk0Rm1.UseVisualStyleBackColor = True
        '
        'chk2Rm2
        '
        Me.chk2Rm2.AutoSize = True
        Me.chk2Rm2.Location = New System.Drawing.Point(520, 396)
        Me.chk2Rm2.Name = "chk2Rm2"
        Me.chk2Rm2.Size = New System.Drawing.Size(29, 17)
        Me.chk2Rm2.TabIndex = 20
        Me.chk2Rm2.Text = " "
        Me.chk2Rm2.UseVisualStyleBackColor = True
        '
        'chk1Rm2
        '
        Me.chk1Rm2.AutoSize = True
        Me.chk1Rm2.Location = New System.Drawing.Point(521, 373)
        Me.chk1Rm2.Name = "chk1Rm2"
        Me.chk1Rm2.Size = New System.Drawing.Size(29, 17)
        Me.chk1Rm2.TabIndex = 19
        Me.chk1Rm2.Text = " "
        Me.chk1Rm2.UseVisualStyleBackColor = True
        '
        'cmbRm3Pnt
        '
        Me.cmbRm3Pnt.FormattingEnabled = True
        Me.cmbRm3Pnt.Location = New System.Drawing.Point(706, 444)
        Me.cmbRm3Pnt.Name = "cmbRm3Pnt"
        Me.cmbRm3Pnt.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm3Pnt.TabIndex = 27
        '
        'cmbRm3Sck
        '
        Me.cmbRm3Sck.FormattingEnabled = True
        Me.cmbRm3Sck.Items.AddRange(New Object() {"-", "1(2G)", "2(2G)", "3(2G)", "4(2G)", "1 (1G)", "2 (1G)", "3 (1G)", "4 (1G)"})
        Me.cmbRm3Sck.Location = New System.Drawing.Point(706, 417)
        Me.cmbRm3Sck.Name = "cmbRm3Sck"
        Me.cmbRm3Sck.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm3Sck.TabIndex = 26
        '
        'chk0Rm2
        '
        Me.chk0Rm2.AutoSize = True
        Me.chk0Rm2.Location = New System.Drawing.Point(521, 350)
        Me.chk0Rm2.Name = "chk0Rm2"
        Me.chk0Rm2.Size = New System.Drawing.Size(29, 17)
        Me.chk0Rm2.TabIndex = 18
        Me.chk0Rm2.Text = " "
        Me.chk0Rm2.UseVisualStyleBackColor = True
        '
        'chk2Rm3
        '
        Me.chk2Rm3.AutoSize = True
        Me.chk2Rm3.Location = New System.Drawing.Point(706, 394)
        Me.chk2Rm3.Name = "chk2Rm3"
        Me.chk2Rm3.Size = New System.Drawing.Size(29, 17)
        Me.chk2Rm3.TabIndex = 25
        Me.chk2Rm3.Text = " "
        Me.chk2Rm3.UseVisualStyleBackColor = True
        '
        'chk1Rm3
        '
        Me.chk1Rm3.AutoSize = True
        Me.chk1Rm3.Location = New System.Drawing.Point(706, 373)
        Me.chk1Rm3.Name = "chk1Rm3"
        Me.chk1Rm3.Size = New System.Drawing.Size(29, 17)
        Me.chk1Rm3.TabIndex = 24
        Me.chk1Rm3.Text = " "
        Me.chk1Rm3.UseVisualStyleBackColor = True
        '
        'cmbRm4Pnt
        '
        Me.cmbRm4Pnt.FormattingEnabled = True
        Me.cmbRm4Pnt.Location = New System.Drawing.Point(906, 444)
        Me.cmbRm4Pnt.Name = "cmbRm4Pnt"
        Me.cmbRm4Pnt.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm4Pnt.TabIndex = 32
        '
        'cmbRm4Sck
        '
        Me.cmbRm4Sck.FormattingEnabled = True
        Me.cmbRm4Sck.Items.AddRange(New Object() {"-", "1(2G)", "2(2G)", "3(2G)", "4(2G)", "1 (1G)", "2 (1G)", "3 (1G)", "4 (1G)"})
        Me.cmbRm4Sck.Location = New System.Drawing.Point(906, 417)
        Me.cmbRm4Sck.Name = "cmbRm4Sck"
        Me.cmbRm4Sck.Size = New System.Drawing.Size(121, 21)
        Me.cmbRm4Sck.TabIndex = 31
        '
        'chk0Rm3
        '
        Me.chk0Rm3.AutoSize = True
        Me.chk0Rm3.Location = New System.Drawing.Point(706, 350)
        Me.chk0Rm3.Name = "chk0Rm3"
        Me.chk0Rm3.Size = New System.Drawing.Size(29, 17)
        Me.chk0Rm3.TabIndex = 23
        Me.chk0Rm3.Text = " "
        Me.chk0Rm3.UseVisualStyleBackColor = True
        '
        'chk2Rm4
        '
        Me.chk2Rm4.AutoSize = True
        Me.chk2Rm4.Location = New System.Drawing.Point(915, 394)
        Me.chk2Rm4.Name = "chk2Rm4"
        Me.chk2Rm4.Size = New System.Drawing.Size(29, 17)
        Me.chk2Rm4.TabIndex = 30
        Me.chk2Rm4.Text = " "
        Me.chk2Rm4.UseVisualStyleBackColor = True
        '
        'chk1Rm4
        '
        Me.chk1Rm4.AutoSize = True
        Me.chk1Rm4.Location = New System.Drawing.Point(915, 373)
        Me.chk1Rm4.Name = "chk1Rm4"
        Me.chk1Rm4.Size = New System.Drawing.Size(29, 17)
        Me.chk1Rm4.TabIndex = 29
        Me.chk1Rm4.Text = " "
        Me.chk1Rm4.UseVisualStyleBackColor = True
        '
        'chk0Rm4
        '
        Me.chk0Rm4.AutoSize = True
        Me.chk0Rm4.Location = New System.Drawing.Point(915, 350)
        Me.chk0Rm4.Name = "chk0Rm4"
        Me.chk0Rm4.Size = New System.Drawing.Size(29, 17)
        Me.chk0Rm4.TabIndex = 28
        Me.chk0Rm4.Text = " "
        Me.chk0Rm4.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPrice.Location = New System.Drawing.Point(534, 480)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(96, 36)
        Me.lblPrice.TabIndex = 10001
        Me.lblPrice.Text = "Price"
        '
        'rdoRetail
        '
        Me.rdoRetail.AutoSize = True
        Me.rdoRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRetail.Location = New System.Drawing.Point(559, 146)
        Me.rdoRetail.Name = "rdoRetail"
        Me.rdoRetail.Size = New System.Drawing.Size(68, 24)
        Me.rdoRetail.TabIndex = 5
        Me.rdoRetail.Text = "Retail"
        Me.rdoRetail.UseVisualStyleBackColor = True
        '
        'rdoTrade
        '
        Me.rdoTrade.AutoSize = True
        Me.rdoTrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTrade.Location = New System.Drawing.Point(559, 169)
        Me.rdoTrade.Name = "rdoTrade"
        Me.rdoTrade.Size = New System.Drawing.Size(68, 24)
        Me.rdoTrade.TabIndex = 6
        Me.rdoTrade.Text = "Trade"
        Me.rdoTrade.UseVisualStyleBackColor = True
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 625)
        Me.Controls.Add(Me.rdoTrade)
        Me.Controls.Add(Me.rdoRetail)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.chk0Rm4)
        Me.Controls.Add(Me.cmbRm4Pnt)
        Me.Controls.Add(Me.cmbRm4Sck)
        Me.Controls.Add(Me.chk0Rm3)
        Me.Controls.Add(Me.chk2Rm4)
        Me.Controls.Add(Me.chk1Rm4)
        Me.Controls.Add(Me.cmbRm3Pnt)
        Me.Controls.Add(Me.cmbRm3Sck)
        Me.Controls.Add(Me.chk0Rm2)
        Me.Controls.Add(Me.chk2Rm3)
        Me.Controls.Add(Me.chk1Rm3)
        Me.Controls.Add(Me.cmbRm2Pnt)
        Me.Controls.Add(Me.cmbRm2Sck)
        Me.Controls.Add(Me.chk0Rm1)
        Me.Controls.Add(Me.chk2Rm2)
        Me.Controls.Add(Me.chk1Rm2)
        Me.Controls.Add(Me.cmbRm1Pnt)
        Me.Controls.Add(Me.cmbRm1Sck)
        Me.Controls.Add(Me.chk3Rm1)
        Me.Controls.Add(Me.chk2Rm1)
        Me.Controls.Add(Me.chk1Rm1)
        Me.Controls.Add(Me.cmbRm0Pnt)
        Me.Controls.Add(Me.cmbRm0Sck)
        Me.Controls.Add(Me.chk2Rm0)
        Me.Controls.Add(Me.chk1Rm0)
        Me.Controls.Add(Me.chk0Rm0)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCustomerAddress)
        Me.Controls.Add(Me.lblDeliveryAddress)
        Me.Controls.Add(Me.lblNameInput)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblDiscount)
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
    Friend WithEvents lblDiscount As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblNameInput As Label
    Friend WithEvents lblDeliveryAddress As Label
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chk0Rm0 As CheckBox
    Friend WithEvents chk1Rm0 As CheckBox
    Friend WithEvents chk2Rm0 As CheckBox
    Friend WithEvents cmbRm0Sck As ComboBox
    Friend WithEvents cmbRm0Pnt As ComboBox
    Friend WithEvents cmbRm1Pnt As ComboBox
    Friend WithEvents cmbRm1Sck As ComboBox
    Friend WithEvents chk3Rm1 As CheckBox
    Friend WithEvents chk2Rm1 As CheckBox
    Friend WithEvents chk1Rm1 As CheckBox
    Friend WithEvents cmbRm2Pnt As ComboBox
    Friend WithEvents cmbRm2Sck As ComboBox
    Friend WithEvents chk0Rm1 As CheckBox
    Friend WithEvents chk2Rm2 As CheckBox
    Friend WithEvents chk1Rm2 As CheckBox
    Friend WithEvents cmbRm3Pnt As ComboBox
    Friend WithEvents cmbRm3Sck As ComboBox
    Friend WithEvents chk0Rm2 As CheckBox
    Friend WithEvents chk2Rm3 As CheckBox
    Friend WithEvents chk1Rm3 As CheckBox
    Friend WithEvents cmbRm4Pnt As ComboBox
    Friend WithEvents cmbRm4Sck As ComboBox
    Friend WithEvents chk0Rm3 As CheckBox
    Friend WithEvents chk2Rm4 As CheckBox
    Friend WithEvents chk1Rm4 As CheckBox
    Friend WithEvents chk0Rm4 As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents rdoRetail As RadioButton
    Friend WithEvents rdoTrade As RadioButton
End Class
