Public Class frmRecipt
    Dim FullName As String = frmCollection.Firstname & " " & frmCollection.Surname
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        MessageBox.Show("Well Done, You've pressed many buttons.")
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCollection.Hide()
        lblPrice.Text = Val(frmCollection.FinalPrice).ToString()


        lblFullName.Text = FullName & vbCrLf &

        For i = 0 To 
    End Sub
End Class