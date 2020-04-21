Public Class frmRecipt
    Dim FullName As String = frmCollection.Firstname & " " & frmCollection.Surname
    Dim Recept As String
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        MessageBox.Show("Well Done, You've pressed many buttons.")
        Application.Exit()
    End Sub
    Public Sub ReceptAssignment() 'Currently WIP
        For i = 0 To 3
            Recept += frmCollection.DisplayAssignments(i, 0, 0) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 0) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 1) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 1) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 2) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 2) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 3) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 3) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 4) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 4) & vbCrLf
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCollection.Hide()
        lblPrice.Text = Val(frmCollection.FinalPrice).ToString("C")
        Call ReceptAssignment()



        lblFullName.Text = "Name: " & FullName & vbCrLf & Recept


    End Sub
End Class