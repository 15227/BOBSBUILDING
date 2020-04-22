Imports System.Drawing.Printing

Public Class frmRecipt
    Dim FullName As String = frmCollection.Firstname & " " & frmCollection.Surname
    Dim Recept As String
    Dim ExcludGST As String = Val(frmCollection.FinalPrice).ToString("C")
    Dim IncludGST As String = ExcludGST * 1.15 '15% ontop of a value.
    Dim GST As String = 0.15 '15% as Decimal.

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click


        Application.Exit()
    End Sub
    Public Sub ReceptAssignment() 'Currently WIP
        For i = 0 To 3
            Recept += frmCollection.DisplayAssignments(i, 0, 0) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 0) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 1) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 1) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 2) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 2) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 3) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 3) & vbCrLf
            Recept += frmCollection.DisplayAssignments(i, 0, 4) & " " & "$" & frmCollection.DisplayAssignments(i, 2, 4) & vbCrLf
            Recept += "GST = " & Val(GST).ToString("C") & vbCrLf
            Recept += "PRICE EXCLUDING GST= " & Val(ExcludGST).ToString("C" & vbCrLf
            Recept += "PRICE INCLUDING GST= " & Val(IncludGST).ToString("C") & vbCrLf
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCollection.Hide()
        Call ReceptAssignment()

        lblFullName.Text = "Name: " & FullName & vbCrLf & Recept
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

    End Sub
End Class