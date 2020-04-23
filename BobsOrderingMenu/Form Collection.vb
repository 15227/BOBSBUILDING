Imports BobsOrderingMenu.My

Public Class frmCollection
    'Defines variable as stored value in program.
    Public UniqueRndId As Single  'Sets the Unique ID to be used by Reading and Writing to file.
    Public CurrentNumber As Integer
    Const BasePrice As Integer = 75000 'Sets defualt price for an invoice.
    Public TradeOrder As Boolean 'True is Trade, False is Retail
    Public Subtotals(4, 3) As Integer 'Sets an Array for the Subtotals of the Form
    Public DisplayAssignments(6, 2, 4) As String 'Creates array for any price, name and indicator for purchase.
    Public AdditionsCount(5, 2) As Integer 'Sets array for Sockets and Network Points
    Public FinalPrice As Integer = BasePrice 'adds the basic price into the Final Price from the beginning.
    Dim FoundErrors As Integer = 0 'Sets up for the end of the form to stop it proceeding with errors   
    Dim Loft As Boolean 'Prepars for the introduction of additional ntwrk pnts
    Public Firstname As String
    Public Surname As String
    Public DelivAdd As String
    Public CusAdd As String
    'Form checkbox interations.
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRetail.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTrade.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm0Pnt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Pnt.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm1Pnt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm1Pnt.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm2Pnt_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call ChkValidation()
    End Sub
    Private Sub cmbRm3Pnt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm3Pnt.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm4Pnt_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call ChkValidation()
    End Sub
    Private Sub cmbRm0Sck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Sck0.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm1Sck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Sck0.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm2Sck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Sck0.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm3Sck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Sck0.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm4Sck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Sck0.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub cmbRm5Sck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRm0Sck0.SelectedIndexChanged
        Call ChkValidation()
    End Sub
    Private Sub chk0Rm0_CheckedChanged(sender As Object, e As EventArgs) Handles chk0Rm0.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub chk1Rm0_CheckedChanged(sender As Object, e As EventArgs) Handles chk1Rm0.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub chk2Rm0_CheckedChanged(sender As Object, e As EventArgs) Handles chk2Rm0.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub chk0Rm3_CheckedChanged(sender As Object, e As EventArgs) Handles chk0Rm3.CheckedChanged
        Call TVPoints()
        Call ChkValidation()
    End Sub
    Private Sub chk1Rm3_CheckedChanged(sender As Object, e As EventArgs) Handles chk1Rm3.CheckedChanged
        Call ChkValidation()
        Call TVPoints()
    End Sub
    Private Sub chk2Rm3_CheckedChanged(sender As Object, e As EventArgs) Handles chk2Rm3.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub chk0Rm4_CheckedChanged(sender As Object, e As EventArgs) Handles chk0Rm4.CheckedChanged
        Call TVPoints()
        Call ChkValidation()
    End Sub
    Private Sub chk1Rm4_CheckedChanged(sender As Object, e As EventArgs) Handles chk1Rm4.CheckedChanged
        Call TVPoints()
        Call ChkValidation()
    End Sub
    Private Sub chk2Rm4_CheckedChanged(sender As Object, e As EventArgs) Handles chk2Rm4.CheckedChanged
        Call ChkValidation()
    End Sub
    Private Sub chk0Rm2_CheckedChanged(sender As Object, e As EventArgs) Handles chk0Rm2.CheckedChanged
        Call TVPoints()
    End Sub
    Private Sub chk1Rm2_CheckedChanged(sender As Object, e As EventArgs) Handles chk1Rm2.CheckedChanged
        Call TVPoints()
    End Sub

    'Alternate form module interactions.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.Close()
    End Sub
    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetId()
        lblDiscount.Hide()
        Call HexId()
        Call FormAssignment()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Call AdditonalsCounter()
        Call ChkValidation()
        Call TextChecking()
        Call ErrorMessageShowing()
    End Sub
    Public Sub ErrorMessageShowing()
        If FoundErrors = 1 Then
            MessageBox.Show("Enter a VALID given name please.")
        ElseIf FoundErrors = 2 Then
            MessageBox.Show("Enter a VALID surname please.")
        ElseIf FoundErrors = 3 Then
            MessageBox.Show("Enter a VALID delivery address please.")
        ElseIf FoundErrors = 4 Then
            MessageBox.Show("Too Many Additional Sockets Selected.")
        ElseIf FoundErrors = 5 Then
            MessageBox.Show("Too Many Additional Network Points Selected.")
        ElseIf FoundErrors = 6 Then
            MessageBox.Show("Falied to find Order Type.")
        ElseIf FoundErrors = 7 Then
            MessageBox.Show("Enter a VALID customer address please")
        ElseIf FoundErrors = 10 Then
            MessageBox.Show("Please remove Line Breaks from addresses.")
        Else
            Call FullPriceCaclulation()
            Call SubmitIDNum() 'Updates Customer Number so that if they proceed to the next page they're offically an order.
            frmRecipt.Show()
        End If
    End Sub
    'Authentications
    Private Sub TextChecking()
        Surname = Trim(txtSurnameInput.Text) 'Takes the leading or following spaces away.
        Firstname = Trim(txtNameInput.Text)
        DelivAdd = Trim(txtDeliveryAddress.Text)
        CusAdd = Trim(txtCustomerAddress.Text)

        If Firstname.Length = 0 Then 'If there's nothing in the box.
            FoundErrors = 1
        ElseIf IsNumeric(Firstname) Then 'Checks to see if numbers are involved.
            FoundErrors = 1
        ElseIf Firstname.Contains(" ") Then 'Checks to see if spaces are entered if so due to trimming two names might be entered.
            FoundErrors = 1
        End If

        If Surname.Length = 0 Then
            FoundErrors = 2
        ElseIf IsNumeric(Surname) Then
            FoundErrors = 2
        End If

        If DelivAdd.Length = 0 Then
            FoundErrors = 3
        ElseIf DelivAdd.Contains(vbCrLf) Then
            FoundErrors = 10
        End If
        If TradeOrder = True Then
            If DelivAdd.Length = 0 Then
                FoundErrors = 7
            ElseIf CusAdd.Contains(vbCrLf) Then
                FoundErrors = 10
            End If
        End If

    End Sub
    Public Sub AdditonalsCounter() 'Counts all Sockets and Network Points.
        'Assigns Selected Sockets for each room (ß, 0) to array
        'Checks for blank or selected null assigns quanity to Zero if blank or Null else first number so to exclude the Gang counter.
        If cmbRm0Sck0.Text = "-" Then
            AdditionsCount(0, 0) = 0
        ElseIf cmbRm0Sck0.Text = "" Then
            AdditionsCount(0, 0) = 0
        Else
            AdditionsCount(0, 0) = Val(cmbRm0Sck0.Text.Chars(0))
        End If
        If cmbRm1Sck0.Text = "-" Then
            AdditionsCount(1, 0) = 0
        ElseIf cmbRm1Sck0.Text = "" Then
            AdditionsCount(1, 0) = 0
        Else
            AdditionsCount(1, 0) = Val(cmbRm1Sck0.Text.Chars(0))
        End If
        If cmbRm2Sck0.Text = "-" Then
            AdditionsCount(2, 0) = 0
        ElseIf cmbRm2Sck0.Text = "" Then
            AdditionsCount(2, 0) = 0
        Else
            AdditionsCount(2, 0) = Val(cmbRm2Sck0.Text.Chars(0))
        End If
        If cmbRm3Sck0.Text = "-" Then
            AdditionsCount(3, 0) = 0
        ElseIf cmbRm3Sck0.Text = "" Then
            AdditionsCount(3, 0) = 0
        Else
            AdditionsCount(3, 0) = Val(cmbRm3Sck0.Text.Chars(0))
        End If
        If cmbRm4Sck0.Text = "-" Then
            AdditionsCount(4, 0) = 0
        ElseIf cmbRm4Sck0.Text = "" Then
            AdditionsCount(4, 0) = 0
        Else
            AdditionsCount(4, 0) = Val(cmbRm4Sck0.Text.Chars(0))
        End If

        'Counts total number of 2G Sockets

        For i = 0 To 4
            AdditionsCount(5, 0) += AdditionsCount(i, 0)
        Next

        If AdditionsCount(5, 0) > 12 Then 'Checks to see if the total of the sockets are greater than 12 if it is it pushes a messagebox and flags to the program an issue
            FoundErrors = 4
            AdditionsCount(5, 0) = 0
        Else
            FoundErrors = 0
        End If

        'Checks for blank or selected null assigns quanity to Zero if blank or Null else first number so to exclude the Gang counter.
        If cmbRm0Sck1.Text = "-" Then
            AdditionsCount(0, 2) = 0
        ElseIf cmbRm0Sck1.Text = "" Then
            AdditionsCount(0, 2) = 0
        Else
            AdditionsCount(0, 2) = Val(cmbRm0Sck1.Text.Chars(0))
        End If
        If cmbRm1Sck1.Text = "-" Then
            AdditionsCount(1, 2) = 0
        ElseIf cmbRm1Sck1.Text = "" Then
            AdditionsCount(1, 2) = 0
        Else
            AdditionsCount(1, 2) = Val(cmbRm1Sck1.Text.Chars(0))
        End If
        If cmbRm2Sck1.Text = "-" Then
            AdditionsCount(2, 2) = 0
        ElseIf cmbRm2Sck1.Text = "" Then
            AdditionsCount(2, 2) = 0
        Else
            AdditionsCount(2, 2) = Val(cmbRm2Sck1.Text.Chars(0))
        End If
        If cmbRm3Sck1.Text = "-" Then
            AdditionsCount(3, 2) = 0
        ElseIf cmbRm3Sck1.Text = "" Then
            AdditionsCount(3, 2) = 0
        Else
            AdditionsCount(3, 2) = Val(cmbRm3Sck1.Text.Chars(0))
        End If
        If cmbRm4Sck1.Text = "-" Then
            AdditionsCount(4, 2) = 0
        ElseIf cmbRm4Sck1.Text = "" Then
            AdditionsCount(4, 2) = 0
        Else
            AdditionsCount(4, 2) = Val(cmbRm4Sck1.Text.Chars(0))
        End If

        'Counts total number of 1G Sockets
        For i = 0 To 4
            AdditionsCount(5, 2) += AdditionsCount(i, 2)
        Next

        If AdditionsCount(5, 2) > 12 Then 'Checks to see if the total of the sockets are greater than 12 if it is it pushes a messagebox and flags to the program an issue
            FoundErrors = 4
            AdditionsCount(5, 2) = 0
        Else
            FoundErrors = 0
        End If

        'Assigns Selected Network Points (ß, 1) to array
        If cmbRm0Pnt.Text = "-" Then
            AdditionsCount(0, 1) = 0
        ElseIf cmbRm0Pnt.Text = "" Then
            AdditionsCount(0, 1) = 0
        Else
            AdditionsCount(0, 1) = Val(cmbRm0Pnt.Text)
        End If
        If cmbRm1Pnt.Text = "-" Then
            AdditionsCount(1, 1) = 0
        ElseIf cmbRm1Pnt.Text = "" Then
            AdditionsCount(1, 1) = 0
        Else
            AdditionsCount(1, 1) = Val(cmbRm1Pnt.Text)
        End If
        If cmbRm2Pnt.Text = "-" Then
            AdditionsCount(2, 1) = 0
        ElseIf cmbRm2Pnt.Text = "" Then
            AdditionsCount(2, 1) = 0
        Else
            AdditionsCount(2, 1) = Val(cmbRm2Pnt.Text)
        End If
        If cmbRm3Pnt.Text = "-" Then
            AdditionsCount(3, 1) = 0
        ElseIf cmbRm3Pnt.Text = "" Then
            AdditionsCount(3, 1) = 0
        Else
            AdditionsCount(3, 1) = Val(cmbRm3Pnt.Text)
        End If
        If cmbRm4Pnt.Text = "-" Then
            AdditionsCount(4, 1) = 0
        ElseIf cmbRm4Pnt.Text = "" Then
            AdditionsCount(4, 1) = 0
        Else
            AdditionsCount(4, 1) = Val(cmbRm4Pnt.Text)
        End If
        'Counts total number of Network Points
        For i = 0 To 4
            AdditionsCount(5, 1) += AdditionsCount(i, 1)
        Next
        If AdditionsCount(5, 1) > 12 Then
            FoundErrors = 5
            AdditionsCount(5, 1) = 0
        End If
    End Sub
    Private Sub ChkValidation() 'Validates elements nessicary to proceed with order according to Layed out Critera.
        Call OrderTyping()
        Call TVPoints()

        If rdoRetail.Checked = False And rdoTrade.Checked = False Then
            FoundErrors = 6
        End If

        'Network Points*** ***Requires the addition of a loft mounted 8 port 10/100/1000 network switch. $100 
        If cmbRm0Pnt.Text.Length <> 0 Then
            Loft = True
        End If
        If cmbRm1Pnt.Text.Length <> 0 Then
            Loft = True
        End If
        If cmbRm2Pnt.Text.Length <> 0 Then
            Loft = True
        End If
        If cmbRm3Pnt.Text.Length <> 0 Then
            Loft = True
        End If
        If cmbRm4Pnt.Text.Length <> 0 Then
            Loft = True
        End If



        'Checks for Conflicting Checked Boxes.
        If chk0Rm0.Checked = True Then
            chk0Rm0.Checked = True
            chk1Rm0.Checked = False
            chk2Rm0.Checked = False
        End If
        If chk1Rm0.Checked = True Then
            chk0Rm0.Checked = False
            chk1Rm0.Checked = True
            chk2Rm0.Checked = False
        End If
        If chk2Rm0.Checked = True Then
            chk0Rm0.Checked = False
            chk1Rm0.Checked = False
            chk2Rm0.Checked = True
        End If

        'Checkes for if the Checkboxes are Checked; if so then copys the price to the Second Column so it may be added to the total price. 
        'Therefore leaving the addition to the final price 0 if Not checked so Not altering the final price.
        'Room 0 Selection Assignments (ß,ß,0)
        If chk0Rm0.Checked = True Then
            DisplayAssignments(0, 2, 0) = (DisplayAssignments(0, 1, 0))
        Else
            DisplayAssignments(0, 2, 0) = 0.ToString
        End If
        If chk1Rm0.Checked = True Then
            DisplayAssignments(1, 2, 0) = DisplayAssignments(1, 1, 0)
        Else
            DisplayAssignments(1, 2, 0) = 0.ToString
        End If
        If chk2Rm0.Checked = True Then
            DisplayAssignments(2, 2, 0) = DisplayAssignments(2, 1, 0)
        Else
            DisplayAssignments(2, 2, 0) = 0.ToString
        End If
        'Room 1 Selection Assignments (ß,ß,1)
        If chk0Rm1.Checked = True Then
            DisplayAssignments(0, 2, 1) = DisplayAssignments(0, 1, 1)
            DisplayAssignments(1, 2, 1) = DisplayAssignments(1, 1, 1)
            DisplayAssignments(2, 2, 1) = DisplayAssignments(2, 1, 1)
            DisplayAssignments(3, 2, 1) = DisplayAssignments(3, 1, 1)
        Else
            DisplayAssignments(0, 2, 1) = 0.ToString
            DisplayAssignments(1, 2, 1) = 0.ToString
            DisplayAssignments(2, 2, 1) = 0.ToString
            DisplayAssignments(3, 2, 1) = 0.ToString
        End If
        'Room 2 Selection Assignments (ß,ß, 2)
        If chk0Rm2.Checked = True Then
            DisplayAssignments(0, 2, 2) = (DisplayAssignments(0, 1, 2))
        Else
            DisplayAssignments(0, 2, 2) = 0.ToString
        End If
        If chk1Rm2.Checked = True Then
            DisplayAssignments(1, 2, 2) = DisplayAssignments(1, 1, 2)
        Else
            DisplayAssignments(1, 2, 2) = 0.ToString
        End If
        If chk2Rm2.Checked = True Then
            DisplayAssignments(2, 2, 2) = DisplayAssignments(2, 1, 2)
        Else
            DisplayAssignments(2, 2, 2) = 0.ToString
        End If
        'Room 3 Selection Assignments (ß,ß,3)
        If chk0Rm3.Checked = True Then
            DisplayAssignments(0, 2, 3) = (DisplayAssignments(0, 1, 3))
        Else
            DisplayAssignments(0, 2, 3) = 0.ToString
        End If
        If chk1Rm3.Checked = True Then
            DisplayAssignments(1, 2, 3) = DisplayAssignments(1, 1, 3)
        Else
            DisplayAssignments(1, 2, 3) = 0.ToString
        End If
        If chk2Rm3.Checked = True Then
            DisplayAssignments(2, 2, 3) = DisplayAssignments(2, 1, 3)
        Else
            DisplayAssignments(2, 2, 3) = 0.ToString
        End If
        'Room 4 Selection Assignments (ß,ß,4)
        If chk0Rm4.Checked = True Then
            DisplayAssignments(0, 2, 4) = (DisplayAssignments(0, 1, 4))
        Else
            DisplayAssignments(0, 2, 4) = 0.ToString
        End If
        If chk1Rm4.Checked = True Then
            DisplayAssignments(1, 2, 4) = DisplayAssignments(1, 1, 4)
        Else
            DisplayAssignments(1, 2, 4) = 0.ToString
        End If
        If chk2Rm4.Checked = True Then
            DisplayAssignments(2, 2, 4) = DisplayAssignments(2, 1, 4)
        Else
            DisplayAssignments(2, 2, 4) = 0.ToString
        End If
    End Sub

    'Price caculations.
    Private Sub OrderTyping()
        'Order type Check
        If rdoTrade.Checked = True Then 'Checks if Retail is checked then change varible to show retail else show it as Trade
            TradeOrder = True
        ElseIf rdoTrade.Checked = False Then
            TradeOrder = False
        End If
        'Shows or hides the label that states about a discount.
        If TradeOrder = True Then
            lblDiscount.Show()
        Else
            lblDiscount.Hide()
        End If
    End Sub
    Private Sub TVPoints() 'Checks for if the TV point in the Bedrooms is selected it makes the Accompanying Living Room Option selected also.
        If chk0Rm4.Checked = True Then 'TV point* *only available if the TV point and aerial option is selected
            chk0Rm4.Checked = True
            chk0Rm2.Checked = True
        ElseIf chk1Rm4.Checked = True Then 'Satellite TV point** **only available if the TV point and satellite dish is selected. 
            chk1Rm4.Checked = True
            chk1Rm2.Checked = True
        End If
        If chk0Rm3.Checked = True Then 'TV point* *only available if the TV point and aerial option is selected
            chk0Rm3.Checked = True
            chk0Rm2.Checked = True
        ElseIf chk1Rm3.Checked = True Then 'Satellite TV point** **only available if the TV point and satellite dish is selected. 
            chk1Rm3.Checked = True
            chk1Rm2.Checked = True
        End If
    End Sub
    Private Sub SubCacl()
        'Caculation for Checkboxes on Rm 0 through 4 (ß,0)
        For i = 0 To 4
            Subtotals(0, 0) += Val(DisplayAssignments(i, 2, 0))
            Subtotals(1, 0) += Val(DisplayAssignments(i, 2, 1))
            Subtotals(2, 0) += Val(DisplayAssignments(i, 2, 2))
            Subtotals(3, 0) += Val(DisplayAssignments(i, 2, 3))
            Subtotals(4, 0) += Val(DisplayAssignments(i, 2, 4))

        Next
        Call AdditonalsCounter()
        'Dim SubtotalAdditionals(2) As Integer
        'Additional 2G Socket Caclulation for every Room (ß, 0)
        For i = 0 To 4
            Subtotals(i, 1) = AdditionsCount(i, 0) * Val(DisplayAssignments(4, 1, i)) 'Number of Points multiplied by the price of corrisponding room's socket Price.
        Next
        'Additional 1G Socket Caclulation for every Room (ß, 2)
        For i = 0 To 4
            Subtotals(i, 3) = AdditionsCount(i, 2) * Val(DisplayAssignments(6, 1, i)) 'Number of sockets multiplied by the price of corrisponding room's 2G sockets.
        Next
        'Additional Points Caclulation for every Room (ß, 1)
        For i = 0 To 4
            Subtotals(i, 2) = AdditionsCount(i, 1) * Val(DisplayAssignments(5, 1, i)) 'Number of sockets multiplied by the price of corrisponding room's 1G sockets.
        Next
    End Sub
    Public Sub FullPriceCaclulation() 'Caclulates the sum of the subtotals and then Applies the potential Trade Discount
        Call SubCacl()
        Dim SubFinal As Integer
        For i = 0 To 4
            SubFinal += Subtotals(i, 0) + Subtotals(i, 1) + Subtotals(i, 2) + Subtotals(i, 3)
        Next
        If Loft = True Then
            FinalPrice += 100
        End If
        FinalPrice += SubFinal
        Call TradeDiscount()
    End Sub
    Private Sub TradeDiscount()
        Dim Discount As Integer = 0.9 'This value should be the remainder of the main value.
        If TradeOrder = True Then 'Checks Boolean for the Order type
            FinalPrice *= Discount 'If the order is a TRADE order it assigns the Discount Integer
        End If
        'lblPrice.Text = FinalPrice.ToString("C") 'Sets the Lable on the form to the Final Price.
    End Sub

    'Array and label assignments.
    Private Sub DisplayArrayAssignments()
        '
        'Room 0 Name Assignments (ß,0,0)
        DisplayAssignments(0, 0, 0) = "Option A: Upgrades units and worktop"
        DisplayAssignments(1, 0, 0) = "Option B: As A plus induction hob "
        DisplayAssignments(2, 0, 0) = "Option C: A plus Deluxe appliance pack"
        DisplayAssignments(3, 0, 0) = ""
        DisplayAssignments(4, 0, 0) = "Additional Electrical sockets 2G Room 0"
        DisplayAssignments(5, 0, 0) = "Network points Room 0"
        DisplayAssignments(6, 0, 0) = "Additional Electrical sockets 1G Room 0"
        'Room 0 Price Assignments (ß,1,0)
        DisplayAssignments(0, 1, 0) = 2000.0
        DisplayAssignments(1, 1, 0) = 3500.0
        DisplayAssignments(2, 1, 0) = 6000.0
        DisplayAssignments(3, 1, 0) = 0
        DisplayAssignments(4, 1, 0) = 50
        DisplayAssignments(5, 1, 0) = 50
        DisplayAssignments(6, 1, 0) = 40

        '
        'Room 1 Name Assignments (ß,0,1)
        DisplayAssignments(0, 0, 1) = "Spa bath"
        DisplayAssignments(1, 0, 1) = "Shower "
        DisplayAssignments(2, 0, 1) = "Tapware "
        DisplayAssignments(3, 0, 1) = "Tiles"
        DisplayAssignments(4, 0, 1) = "Additional Electrical sockets 2G Room 1"
        DisplayAssignments(5, 0, 1) = "Network points Room 1"
        DisplayAssignments(6, 0, 1) = "Additional Electrical sockets 1G Room 1"
        'Room 1 Price Assignments (ß,1,1)
        DisplayAssignments(0, 1, 1) = 2500
        DisplayAssignments(1, 1, 1) = 2500
        DisplayAssignments(2, 1, 1) = 2500
        DisplayAssignments(3, 1, 1) = 2500
        DisplayAssignments(4, 1, 1) = 50
        DisplayAssignments(5, 1, 1) = 50
        DisplayAssignments(6, 1, 1) = 40


        '
        'Room 2 Name Assignments
        DisplayAssignments(0, 0, 2) = "TV point plus roof mounted aerial"
        DisplayAssignments(1, 0, 2) = "TV point plus satellite dish"
        DisplayAssignments(2, 0, 2) = "4.5 KW Heat pump"
        DisplayAssignments(3, 0, 2) = ""
        DisplayAssignments(4, 0, 2) = "Additional Electrical sockets 2G Room 2"
        DisplayAssignments(5, 0, 2) = "Network points Room 2"
        DisplayAssignments(6, 0, 2) = "Additional Electrical sockets 1G Room 2"
        'Room 2 Price Assignments
        DisplayAssignments(0, 1, 2) = 250
        DisplayAssignments(1, 1, 2) = 250
        DisplayAssignments(2, 1, 2) = 2500
        DisplayAssignments(3, 1, 2) = 0
        DisplayAssignments(4, 1, 2) = 50
        DisplayAssignments(5, 1, 2) = 50
        DisplayAssignments(6, 1, 2) = 40

        'Room 3 Name Assignments
        DisplayAssignments(0, 0, 3) = "TV point"
        DisplayAssignments(1, 0, 3) = "Satellite TV point"
        DisplayAssignments(2, 0, 3) = "2.5 KW Heat pump"
        DisplayAssignments(3, 0, 3) = ""
        DisplayAssignments(4, 0, 3) = "Additional Electrical sockets 2G Room 3"
        DisplayAssignments(5, 0, 3) = "Network points Room 3"
        DisplayAssignments(6, 0, 3) = "Additional Electrical sockets 1G Room 3"
        'Room 3 Price Assignments
        DisplayAssignments(0, 1, 3) = 50
        DisplayAssignments(1, 1, 3) = 50
        DisplayAssignments(2, 1, 3) = 1800
        DisplayAssignments(3, 1, 3) = 0
        DisplayAssignments(4, 1, 3) = 50
        DisplayAssignments(5, 1, 3) = 50
        DisplayAssignments(6, 1, 3) = 40

        '
        'Room 4 Name Assignments
        DisplayAssignments(0, 0, 4) = "TV point"
        DisplayAssignments(1, 0, 4) = "Satellite TV point"
        DisplayAssignments(2, 0, 4) = "2.5 KW Heat pump"
        DisplayAssignments(3, 0, 4) = ""
        DisplayAssignments(4, 0, 4) = "Additional Electrical sockets 2G Room 4"
        DisplayAssignments(5, 0, 4) = "Network points Room 4"
        DisplayAssignments(6, 0, 4) = "Additional Electrical sockets 1G Room 4"
        'Room 4 Price Assignments
        DisplayAssignments(0, 1, 4) = 50
        DisplayAssignments(1, 1, 4) = 50
        DisplayAssignments(2, 1, 4) = 1800
        DisplayAssignments(3, 1, 4) = 0
        DisplayAssignments(4, 1, 4) = 50
        DisplayAssignments(5, 1, 4) = 50
        DisplayAssignments(6, 1, 4) = 40

    End Sub
    Public Sub FormAssignment() 'Sets the values and text for the Checkboxes and Dropdowns
        Call DisplayArrayAssignments()
        chk0Rm0.Text = DisplayAssignments(0, 0, 0)
        chk1Rm0.Text = DisplayAssignments(1, 0, 0)
        chk2Rm0.Text = DisplayAssignments(2, 0, 0)
        cmbRm0Sck1.Text = DisplayAssignments(3, 0, 0)
        cmbRm0Sck0.Text = DisplayAssignments(4, 0, 0)
        cmbRm0Pnt.Text = DisplayAssignments(5, 0, 0)
        chk0Rm1.Text = "Upgrade"
        cmbRm1Sck0.Text = DisplayAssignments(4, 0, 1)
        cmbRm1Pnt.Text = DisplayAssignments(5, 0, 1)
        chk0Rm2.Text = DisplayAssignments(0, 0, 2)
        chk1Rm2.Text = DisplayAssignments(1, 0, 2)
        chk2Rm2.Text = DisplayAssignments(2, 0, 2)
        cmbRm2Sck0.Text = DisplayAssignments(4, 0, 2)
        cmbRm2Pnt.Text = DisplayAssignments(5, 0, 2)
        chk0Rm3.Text = DisplayAssignments(0, 0, 3)
        chk1Rm3.Text = DisplayAssignments(1, 0, 3)
        chk2Rm3.Text = DisplayAssignments(2, 0, 3)
        cmbRm3Sck0.Text = DisplayAssignments(4, 0, 3)
        cmbRm3Pnt.Text = DisplayAssignments(5, 0, 3)
        chk0Rm4.Text = DisplayAssignments(0, 0, 4)
        chk1Rm4.Text = DisplayAssignments(1, 0, 4)
        chk2Rm4.Text = DisplayAssignments(2, 0, 4)
        cmbRm4Sck0.Text = DisplayAssignments(4, 0, 4)
        cmbRm4Pnt.Text = DisplayAssignments(5, 0, 4)
        'lblPrice.Text = FinalPrice.ToString("C")
    End Sub

    'Unique identification.
    Private Sub GetId()
        CurrentNumber = Settings.CustomerId + 1
    End Sub
    Public Sub SubmitIDNum()
        Settings.CustomerId = CurrentNumber
    End Sub
    Private Sub HexId() 'Creates 6 Digit Hexadecimal System generating a number upto 1048576 only showing 6 Charcters.
        Randomize()
        UniqueRndId = CInt(Math.Floor(((16 ^ 6) - 0 + 1) * Rnd())) + 1 'Generates a Random number in Base 16. The Power is the number of letters for a Hexadecimal numeral.

        lblIdentification.Text = "Identification number: " & Hex(UniqueRndId) & "-" & Hex(CurrentNumber) 'Shows the randomised UniqueID as a Hex for displaying and a following number that counts up also in Hex.
    End Sub
End Class