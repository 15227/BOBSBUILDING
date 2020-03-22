Public Class frmCollection
    Dim UniqueId As String = My.Settings.CustomerId 'Defines variable as stored value in program.
    Dim OrderType As Boolean = 0
    Dim Subtotals(4, 2) As Integer
    Public FinalArray(5, 2, 4) As String
    Public FinalPrice As Integer
    Dim SocketCount(5, 1) As Integer

    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SubtotalPopultaion()
        Call UniqueIdentification()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Call ChangeNickname() 'Updates Customer Number so that if they proceed to the next page they're offically an order.
        Call PriceCaclulation() 'Adds the subtotals of all prices
        MessageBox.Show(Finalprice)
    End Sub


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
    End Sub


    Private Sub Checkboxes() 'tests for checkbox's being cicked by providing a true or false
        If ckbRetail.Checked = True Then MessageBox.Show("Discount not applicible")
        If ckbTrade.Checked = True Then MessageBox.Show("Congratultaions on 10% Discount")
    End Sub
    Private Sub UniqueIdentification()
        Call UpdateNickname()
        UniqueId += 1 'Adds one to the current UniqueId variable.
        lblIdentification.Text = "Your unique identification number is: " & UniqueId 'Sets the label that shows the customers identification number calculated before.
    End Sub
    Public Sub ChangeNickname()
        My.Settings.CustomerId = UniqueId 'Sets the saved value in the program called CustomerId to the UniqueId Value.
    End Sub
    Private Sub UpdateNickname()
        UniqueId = My.Settings.CustomerId 'Sets the UniqueId Value to the saved value in the program called CustomerId.
    End Sub
    Private Sub PriceCaclulation()
        For i = 0 To 4
            Finalprice += Subtotals(i) 'Adds each subtotal to the prvious to get the prices.
        Next

        If ckbTrade.Checked = True Then
            Finalprice *= 0.9 'Asigns a 10% discount if the trade checkbox is checked.
        End If
    End Sub

    Private Sub SubtotalPopultaion()
        Subtotals(0) = 10
        Subtotals(1) = 20
        Subtotals(2) = 30
        Subtotals(3) = 40
        Subtotals(4) = 50
    End Sub
End Class
