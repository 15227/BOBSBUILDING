Imports System.Drawing.Printing

Public Class frmRecipt
    Dim FullName As String = frmCollection.Firstname & " " & frmCollection.Surname
    Dim Recept As String
    Const BasePrice As Single = 65217.3913043 'Sets defualt price for an invoice.
    Dim ExcludGST As String = Val(frmCollection.FinalPrice).ToString + BasePrice
    Dim IncludGST As String = (ExcludGST * 1.15) '15% ontop of a value.
    Dim GST As String = IncludGST - ExcludGST '15% as Decimal.
    Dim FilePath As String = "\OrderHistory.txt"
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Call ReadingAndWriting()
        Application.Exit()
    End Sub
    Public Sub ReceptAssignment() 'Currently WIP, Doesn't display Sockets or Points.
        Recept = "Name: " & FullName & vbCrLf
        Recept += "Identification number: " & Hex(frmCollection.UniqueRndId) & "-" & Hex(frmCollection.CurrentNumber) & vbCrLf
        Recept += "Delivery Address: " & frmCollection.DelivAdd & vbCrLf

        If frmCollection.CusAdd.Length <> 0 Then
            Recept += "Customer Address: " & frmCollection.CusAdd & vbCrLf
        End If
        If frmCollection.TradeOrder = True Then
            Recept += "Order Type: Trade"
        ElseIf frmCollection.TradeOrder = False Then
            Recept += "Order Type: Retail"
        End If
        Recept += vbCrLf
        '
        ' BEGIN CHECKBOX FILLING
        '
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
        '
        ' BEGIN DROPDOWN FILLING
        '
        For i = 0 To 4
            If frmCollection.Subtotals(i, 1) <> 0 Then
                Recept += frmCollection.DisplayAssignments(4, 0, i) & " " & Val(frmCollection.Subtotals(i, 1)).ToString("C") & vbCrLf
            End If
            If frmCollection.Subtotals(i, 3) <> 0 Then
                Recept += frmCollection.DisplayAssignments(6, 0, i) & " " & Val(frmCollection.Subtotals(i, 3)).ToString("C") & vbCrLf
            End If
            If frmCollection.Subtotals(i, 2) <> 0 Then
                Recept += frmCollection.DisplayAssignments(5, 0, i) & " " & Val(frmCollection.Subtotals(i, 2)).ToString("C") & vbCrLf
            End If
        Next

        '
        'BEGIN PRICE FILLING
        '
        Recept += "PRICE EXCLUDING GST= " & Val(ExcludGST).ToString("C") & vbCrLf
        Recept += "GST = " & Val(GST).ToString("C") & vbCrLf
        Recept += "PRICE INCLUDING GST= " & Val(IncludGST).ToString("C") & vbCrLf
    End Sub
    Private Sub ReadingAndWriting()
        Dim objReader As New System.IO.StreamReader(FilePath) 'Prepares to read the text on a .txt file.
        Dim FileContents As String = objReader.ReadToEnd 'Sets a Variable to easily made alterations to that has the value of all the text in the txt file.
        objReader.Close() 'Stops the Reader code to prevent errors.

        FileContents += "-----------------------" & vbCrLf & Recept 'Adds a seperator to the top of each new order added to file.

        If System.IO.File.Exists(FilePath) = True Then 'Checks to see if the file exists.
            Dim objWriter As New System.IO.StreamWriter(FilePath) 'Prepares to add text to a .txt file.
            objWriter.Write(FileContents) 'Adds to the file the new recept that's ready to be written.
            objWriter.Close() 'Stops the writer code to prevent errors.
            MessageBox.Show("Text written to file")
        Else
            MessageBox.Show("File Does Not Exist")
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCollection.Hide()
        Call ReceptAssignment()
        lblFullName.Text = Recept
    End Sub
    'Printer Routines.
    Private Function PreparePrintDocument() As PrintDocument     'Make And return a PrintDocument object that's ready to print.
        Dim print_document As New PrintDocument        ' Make the PrintDocument object.
        AddHandler print_document.PrintPage, AddressOf Print_PrintPage        ' Install the PrintPage event handler.
        Return print_document        ' Return the object.
    End Function
    Private Sub Print_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)     ' Sets up page
        ' Draw a rectangle at the margins.
        'e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
        e.Graphics.DrawString(Recept, Font, Brushes.Black, e.MarginBounds.Left, 12)
        e.HasMorePages = False        ' There are no more pages.
    End Sub
    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click    ' Display a print preview.
        ' Make a PrintDocument and attach it to the PrintPreview dialog.
        dlgPrintPreview.Document = PreparePrintDocument()

        ' Preview.
        dlgPrintPreview.WindowState = FormWindowState.Maximized
        dlgPrintPreview.ShowDialog()
    End Sub
    Private Sub btnPrintWithDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintWithDialog.Click     ' Print with the print dialog.
        ' Make a PrintDocument and attach it to the Print dialog.
        dlgPrint.Document = PreparePrintDocument()

        ' Display the print dialog.
        dlgPrint.ShowDialog()
    End Sub
    Private Sub btnPrintNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintNow.Click        ' Print immediately.
        ' Make a PrintDocument object.
        Dim print_document As PrintDocument =
        PreparePrintDocument()

        ' Print immediately.
        print_document.Print()
    End Sub

End Class