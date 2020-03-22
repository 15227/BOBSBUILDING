Public Class frmCollection
    Dim UniqueId As String = My.Settings.CustomerId 'Defines variable as stored value in program.
    Dim Finalprice As Integer
    Dim Subtotals(4) As Integer
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
