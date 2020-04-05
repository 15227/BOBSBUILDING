Public Class frmCollection
    Dim UniqueId As String = My.Settings.CustomerId 'Defines variable as stored value in program.
    Dim BasePrice As Integer = 75000
    Public FinalPrice As Integer = BasePrice
    Dim TradeOrder As Boolean 'True is Trade, False is Retail
    Dim Subtotals(4, 2) As Integer
    Public FinalArray(5, 2, 4) As String
    Dim SocketCount(5, 1) As Integer

    'Form Elements.
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRetail.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTrade.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDiscount.Hide()
        Call UniqueIdentification()
        Call FinalArrayAsign()
        Call NameAssignment()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Call ChkValidation()
        'Call AdditonalsCounter()
        Call FinalCaclulation()
        Call SubmitNickname() 'Updates Customer Number so that if they proceed to the next page they're offically an order.
        Form2.Show()
    End Sub


    'Socket authentication.
    Public Sub AdditonalsCounter() 'Counts all Sockets and Network Points To be called anytime a Socket Combobox is changed.
        'Assigns Selected Sockets for each room (ß, 0)
        SocketCount(0, 0) = Val(cmbRm0Sck.Text)
        SocketCount(1, 0) = Val(cmbRm1Sck.Text)
        SocketCount(2, 0) = Val(cmbRm2Sck.Text)
        SocketCount(3, 0) = Val(cmbRm3Sck.Text)
        SocketCount(4, 0) = Val(cmbRm4Sck.Text)

        'Counts total number of Sockets
        For i = 0 To 4
            SocketCount(5, 0) += SocketCount(i, 0)
        Next
        If SocketCount(5, 0) > 12 Then
            MessageBox.Show("Too Many Additional Sockets Selected.")
        End If


        'Assigns Selected Network Points (ß, 1
        SocketCount(0, 1) = Val(cmbRm0Pnt.Text)
        SocketCount(1, 1) = Val(cmbRm1Pnt.Text)
        SocketCount(2, 1) = Val(cmbRm2Pnt.Text)
        SocketCount(3, 1) = Val(cmbRm3Pnt.Text)
        SocketCount(4, 1) = Val(cmbRm4Pnt.Text)

        'Counts total number of Network Points
        For i = 0 To 4
            SocketCount(5, 1) += SocketCount(i, 1)
        Next
        If SocketCount(5, 1) > 12 Then
            MessageBox.Show("Too Many Additional Network Points Selected.")
        End If
    End Sub
    Private Sub ChkValidation() 'Validates Check boxes and Variables nessicary to proceed with order according to Layed out Critera.
        'Order type Check
        If rdoTrade.Checked = True Then 'Checks if Retail is checked then change varible to show retail else show it as Trade
            TradeOrder = True
        Else
            TradeOrder = False
        End If

        If TradeOrder = True Then
            lblDiscount.Show()
        Else
            lblDiscount.Hide()
        End If

        'Code checks for if the TV point in the Bedrooms is selected it makes the Accompanying Living Room Option selected also.
        If chk0Rm4.Checked = True Then 'TV point* *only available if the TV point and aerial option is selected
            chk0Rm2.Checked = True
        ElseIf chk1Rm4.Checked = True Then 'Satellite TV point** **only available if the TV point and satellite dish is selected. 
            chk1Rm2.Checked = True
        End If
        If chk0Rm3.Checked = True Then 'TV point* *only available if the TV point and aerial option is selected
            chk0Rm2.Checked = True
        ElseIf chk1Rm3.Checked = True Then 'Satellite TV point** **only available if the TV point and satellite dish is selected. 
            chk1Rm2.Checked = True
        End If


        'Netwrk Points*** ***Requires the addition of a loft mounted 8 port 10/100/1000 network switch. $100 
        'Additional electrical sockets (1G)# #2G sockets are an extra $10 Each.

        'Checkes for if the Checkboxes are Checked; if so then assgins the price to the Array so it may be added to the total price. 
        'Therefore leaving the final price 0 if Not checked so Not altering the final price..
        'Room 0 Selection Assignments (ß,2,0)
        If chk0Rm0.Checked = True Then
            FinalArray(0, 2, 0) = (FinalArray(0, 1, 0))
        Else
            FinalArray(0, 2, 0) = 0
        End If
        If chk1Rm0.Checked = True Then
            FinalArray(1, 2, 0) = FinalArray(1, 1, 0)
        Else
            FinalArray(1, 2, 0) = 0
        End If
        If chk2Rm0.Checked = True Then
            FinalArray(2, 2, 0) = FinalArray(2, 1, 0)
        Else
            FinalArray(2, 2, 0) = 0
        End If
        'Room 1 Selection Assignments (ß,2,1)
        If chk0Rm1.Checked = True Then
            FinalArray(0, 2, 1) = FinalArray(0, 1, 1)
        Else
            FinalArray(0, 2, 1) = 0
        End If
        If chk1Rm1.Checked = True Then
            FinalArray(1, 2, 1) = FinalArray(1, 1, 1)
        Else
            FinalArray(1, 2, 1) = 0
        End If
        If chk2Rm1.Checked = True Then
            FinalArray(2, 2, 1) = FinalArray(2, 1, 1)
        Else
            FinalArray(2, 2, 1) = 0
        End If
        If chk3Rm1.Checked = True Then
            FinalArray(3, 2, 1) = FinalArray(3, 1, 1)
        Else
            FinalArray(3, 2, 1) = 0
        End If
        'Room 2 Selection Assignments (ß,2, 2)
        If chk0Rm2.Checked = True Then
            FinalArray(0, 2, 2) = (FinalArray(0, 1, 2))
        Else
            FinalArray(0, 2, 2) = 0
        End If
        If chk1Rm2.Checked = True Then
            FinalArray(1, 2, 2) = FinalArray(1, 1, 2)
        Else
            FinalArray(1, 2, 2) = 0
        End If
        If chk2Rm2.Checked = True Then
            FinalArray(2, 2, 2) = FinalArray(2, 1, 2)
        Else
            FinalArray(2, 2, 2) = 0
        End If
        'Room 3 Selection Assignments (ß,2,3)
        If chk0Rm3.Checked = True Then
            FinalArray(0, 2, 3) = (FinalArray(0, 1, 3))
        Else
            FinalArray(0, 2, 3) = 0
        End If
        If chk1Rm3.Checked = True Then
            FinalArray(1, 2, 3) = FinalArray(1, 1, 3)
        Else
            FinalArray(1, 2, 3) = 0
        End If
        If chk2Rm3.Checked = True Then
            FinalArray(2, 2, 3) = FinalArray(2, 1, 3)
        Else
            FinalArray(2, 2, 3) = 0
        End If
        'Room 4 Selection Assignments (ß,2,4)
        If chk0Rm4.Checked = True Then
            FinalArray(0, 2, 4) = (FinalArray(0, 1, 4))
        Else
            FinalArray(0, 2, 4) = 0
        End If
        If chk1Rm4.Checked = True Then
            FinalArray(1, 2, 4) = FinalArray(1, 1, 4)
        Else
            FinalArray(1, 2, 4) = 0
        End If
        If chk2Rm4.Checked = True Then
            FinalArray(2, 2, 4) = FinalArray(2, 1, 4)
        Else
            FinalArray(2, 2, 4) = 0
        End If
    End Sub

    'Price caculations.
    Private Sub SubCacl()
        'Caculation for Checkboxes on Form1 (ß,0)
        For i = 0 To 4
            Subtotals(0, 0) += Val(FinalArray(i, 2, 0)) 'Final Price after if Statments.
            Subtotals(1, 0) += Val(FinalArray(i, 2, 1))
            Subtotals(2, 0) += Val(FinalArray(i, 2, 2))
            Subtotals(3, 0) += Val(FinalArray(i, 2, 3))
            Subtotals(4, 0) += Val(FinalArray(i, 2, 4))

        Next
        'Additional Socket Caclulation for every Room (ß, 1)
        For i = 0 To 4
            Subtotals(i, 1) = SocketCount(i, 0) * Val(FinalArray(4, 1, i)) 'Number of sockets multiplied by the price of corrisponding room's sockets.
        Next
        'Additional Points Caclulation for every Room (ß, 2)
        For i = 0 To 4
            Subtotals(i, 2) = SocketCount(i, 1) * Val(FinalArray(5, 1, i))
        Next
    End Sub
    Public Sub FinalCaclulation() 'Caclulates the sum of the subtotals and then Applies the potential Trade Discount
        Call SubCacl()
        Dim SubFinal As Integer
        For i = 0 To 4
            SubFinal += Subtotals(i, 0) + Subtotals(i, 1) + Subtotals(i, 2)
        Next


        FinalPrice += SubFinal
        Call TradeDiscount()

    End Sub
    Private Sub TradeDiscount()
        Dim Discount As Integer = 0.9 'This value should be the remainder of the main value.
        If TradeOrder = True Then
            FinalPrice *= Discount
        End If
        lblPrice.Text = FinalPrice.ToString
        If rdoTrade.Checked = True Then
            rdoRetail.Checked = False
        End If
    End Sub

    'Array and label assignments.
    Private Sub FinalArrayAsign()
        '
        'Room 0 Name Assignments (ß,0,0)
        FinalArray(0, 0, 0) = "Option A: Upgrades units and worktop"
        FinalArray(1, 0, 0) = "Option B: As A plus induction hob "
        FinalArray(2, 0, 0) = "Option C: A plus Deluxe appliance pack"
        FinalArray(3, 0, 0) = "Unspeicifed Kitchen Addon"
        FinalArray(4, 0, 0) = "Additional electrical sockets (1G)"
        FinalArray(5, 0, 0) = "Network points"
        '   Room 0 Price Assignments (ß,1,0)
        FinalArray(0, 1, 0) = 2000.0
        FinalArray(1, 1, 0) = 3500.0
        FinalArray(2, 1, 0) = 6000.0
        FinalArray(3, 1, 0) = 0
        FinalArray(4, 1, 0) = 40
        FinalArray(5, 1, 0) = 50

        '
        'Room 1 Name Assignments (ß,0,1)
        FinalArray(0, 0, 1) = "Spa bath"
        FinalArray(1, 0, 1) = "Shower "
        FinalArray(2, 0, 1) = "Tapware "
        FinalArray(3, 0, 1) = "Tiles"
        FinalArray(4, 0, 1) = "Additional electrical sockets (1G)"
        FinalArray(5, 0, 1) = "Network points"
        'Room 1 Price Assignments (ß,1,1)
        FinalArray(0, 1, 1) = 2500
        FinalArray(1, 1, 1) = 2500
        FinalArray(2, 1, 1) = 2500
        FinalArray(3, 1, 1) = 2500
        FinalArray(4, 1, 1) = 40
        FinalArray(5, 1, 1) = 50

        '
        'Room 2 Name Assignments
        FinalArray(0, 0, 2) = "TV point plus roof mounted aerial"
        FinalArray(1, 0, 2) = "TV point plus satellite dish"
        FinalArray(2, 0, 2) = "4.5 KW Heat pump   "
        FinalArray(3, 0, 2) = "Unspecified Living Room addon"
        FinalArray(4, 0, 2) = "Additional electrical sockets (1G)"
        FinalArray(5, 0, 2) = "Network points"
        'Room 2 Price Assignments
        FinalArray(0, 1, 2) = 250
        FinalArray(1, 1, 2) = 250
        FinalArray(2, 1, 2) = 2500
        FinalArray(3, 1, 2) = 0
        FinalArray(4, 1, 2) = 40
        FinalArray(5, 1, 2) = 50

        'Room 3 Name Assignments
        FinalArray(0, 0, 3) = "TV point"
        FinalArray(1, 0, 3) = "Satellite TV point"
        FinalArray(2, 0, 3) = "2.5 KW Heat pump"
        FinalArray(3, 0, 3) = "Unspecified Bedroom addon"
        FinalArray(4, 0, 3) = "Additional electrical sockets (1G)"
        FinalArray(5, 0, 3) = "Network points"
        'Room 3 Price Assignments
        FinalArray(0, 1, 3) = 50
        FinalArray(1, 1, 3) = 50
        FinalArray(2, 1, 3) = 1800
        FinalArray(3, 1, 3) = 0
        FinalArray(4, 1, 3) = 40
        FinalArray(5, 1, 3) = 50

        '
        'Room 4 Name Assignments
        FinalArray(0, 0, 4) = "TV point"
        FinalArray(1, 0, 4) = "Satellite TV point"
        FinalArray(2, 0, 4) = "2.5 KW Heat pump"
        FinalArray(3, 0, 4) = "Unspecified Bedroom addon"
        FinalArray(4, 0, 4) = "Additional electrical sockets (1G)"
        FinalArray(5, 0, 4) = "Network points"
        'Room 4 Price Assignments
        FinalArray(0, 1, 4) = 50
        FinalArray(1, 1, 4) = 50
        FinalArray(2, 1, 4) = 1800
        FinalArray(3, 1, 4) = 0
        FinalArray(4, 1, 4) = 40
        FinalArray(5, 1, 4) = 50

    End Sub
    Public Sub NameAssignment() 'Fully Operational
        chk0Rm0.Text = FinalArray(0, 0, 0)
        chk1Rm0.Text = FinalArray(1, 0, 0)
        chk2Rm0.Text = FinalArray(2, 0, 0)
        cmbRm0Sck.Text = FinalArray(4, 0, 0)
        cmbRm0Pnt.Text = FinalArray(5, 0, 0)
        chk0Rm1.Text = FinalArray(0, 0, 1)
        chk1Rm1.Text = FinalArray(1, 0, 1)
        chk2Rm1.Text = FinalArray(2, 0, 1)
        chk3Rm1.Text = FinalArray(3, 0, 1)
        cmbRm1Sck.Text = FinalArray(4, 0, 1)
        cmbRm1Pnt.Text = FinalArray(5, 0, 1)
        chk0Rm2.Text = FinalArray(0, 0, 2)
        chk1Rm2.Text = FinalArray(1, 0, 2)
        chk2Rm2.Text = FinalArray(2, 0, 2)
        cmbRm2Sck.Text = FinalArray(4, 0, 2)
        cmbRm2Pnt.Text = FinalArray(5, 0, 2)
        chk0Rm3.Text = FinalArray(0, 0, 3)
        chk1Rm3.Text = FinalArray(1, 0, 3)
        chk2Rm3.Text = FinalArray(2, 0, 3)
        cmbRm3Sck.Text = FinalArray(4, 0, 3)
        cmbRm3Pnt.Text = FinalArray(5, 0, 3)
        chk0Rm4.Text = FinalArray(0, 0, 4)
        chk1Rm4.Text = FinalArray(1, 0, 4)
        chk2Rm4.Text = FinalArray(2, 0, 4)
        cmbRm4Sck.Text = FinalArray(4, 0, 4)
        cmbRm4Pnt.Text = FinalArray(5, 0, 4)
        lblPrice.Text = BasePrice.ToString
    End Sub

    'Unique identification.
    Private Sub UniqueIdentification()
        Call UpdateNickname()
        UniqueId += 1 'Adds one to the current UniqueId variable.
        lblIdentification.Text = "Identification number: " & UniqueId 'Sets the label that shows the customers identification number calculated before.
    End Sub
    Public Sub SubmitNickname()
        My.Settings.CustomerId = UniqueId 'Sets the saved value in the program called CustomerId to the UniqueId Value.
    End Sub
    Private Sub UpdateNickname()
        UniqueId = My.Settings.CustomerId 'Sets the UniqueId Value to the saved value in the program called CustomerId.
    End Sub


End Class
