Public Class frmRecipt
    Dim FullName As String = frmCollection.Firstname & " " & frmCollection.Surname
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCollection.Hide()
        lblPrice.Text = Val(frmCollection.FinalPrice).ToString()
        lblFullName.Text = FullName
    End Sub
End Class