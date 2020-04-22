Imports System.Drawing.Printing

Public Class frmRecipt
    Dim FullName As String = frmCollection.Firstname & " " & frmCollection.Surname
    Dim Recept As String
    Dim ExcludGST As String = Val(frmCollection.FinalPrice).ToString
    Dim IncludGST As String = ExcludGST * 1.15 '15% ontop of a value.
    Dim GST As String = ExcludGST * 0.15 '15% as Decimal.

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'Eventually will add Saving to a file and printing using this Recept Array.

        Application.Exit()
    End Sub
    Public Sub ReceptAssignment() 'Currently WIP
        Recept = "Name: " & FullName & vbCrLf
        Recept += "Identification number: " & Hex(frmCollection.UniqueRndId) & "-" & Hex(frmCollection.CurrentNumber) & vbCrLf
        Recept += "Delivery Address: " & frmCollection.DelivAdd & vbCrLf

        If frmCollection.CusAdd.Length > 0 Then
            Recept += "Customer Address" & frmCollection.CusAdd & vbCrLf
        End If

        For i = 0 To 3
            If Val(frmCollection.DisplayAssignments(i, 2, 0)) <> 0 Then
                Recept += frmCollection.DisplayAssignments(i, 0, 0) & " " & Val(frmCollection.DisplayAssignments(i, 2, 0)).ToString("C") & vbCrLf
            End If
        Next
        For i = 0 To 3
            If Val(frmCollection.DisplayAssignments(i, 2, 1)) <> 0 Then
                Recept += frmCollection.DisplayAssignments(i, 0, 1) & " " & Val(frmCollection.DisplayAssignments(i, 2, 1)).ToString("C") & vbCrLf
            End If
        Next
        For i = 0 To 3
            If Val(frmCollection.DisplayAssignments(i, 2, 2)) <> 0 Then
                Recept += frmCollection.DisplayAssignments(i, 0, 2) & " " & Val(frmCollection.DisplayAssignments(i, 2, 2)).ToString("C") & vbCrLf
            End If
        Next
        For i = 0 To 3
            If Val(frmCollection.DisplayAssignments(i, 2, 3)) <> 0 Then
                Recept += frmCollection.DisplayAssignments(i, 0, 3) & " " & Val(frmCollection.DisplayAssignments(i, 2, 3)).ToString("C") & vbCrLf
            End If
        Next
        For i = 0 To 3
            If Val(frmCollection.DisplayAssignments(i, 2, 4)) <> 0 Then
                Recept += frmCollection.DisplayAssignments(i, 0, 4) & " " & Val(frmCollection.DisplayAssignments(i, 2, 4)).ToString("C") & vbCrLf
            End If
        Next

        Recept += "PRICE EXCLUDING GST= " & Val(ExcludGST).ToString("C") & vbCrLf
        Recept += "GST = " & Val(GST).ToString("C") & vbCrLf
        Recept += "PRICE INCLUDING GST= " & Val(IncludGST).ToString("C") & vbCrLf
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCollection.Hide()
        Call ReceptAssignment()
        lblFullName.Text = Recept
    End Sub

End Class