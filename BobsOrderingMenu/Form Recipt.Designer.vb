<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecipt))
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.dlgPrint = New System.Windows.Forms.PrintDialog()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrintWithDialog = New System.Windows.Forms.Button()
        Me.btnPrintNow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(505, 382)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(141, 55)
        Me.btnRestart.TabIndex = 10003
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.Location = New System.Drawing.Point(337, 382)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(141, 55)
        Me.btnProceed.TabIndex = 10004
        Me.btnProceed.Text = "Done"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Location = New System.Drawing.Point(12, 9)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(56, 15)
        Me.lblFullName.TabIndex = 10005
        Me.lblFullName.Text = "Full Name"
        '
        'dlgPrint
        '
        Me.dlgPrint.UseEXDialog = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(526, 103)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(119, 23)
        Me.btnPrintPreview.TabIndex = 10006
        Me.btnPrintPreview.Text = "btnPrintPreview"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.Visible = False
        '
        'btnPrintWithDialog
        '
        Me.btnPrintWithDialog.Location = New System.Drawing.Point(526, 132)
        Me.btnPrintWithDialog.Name = "btnPrintWithDialog"
        Me.btnPrintWithDialog.Size = New System.Drawing.Size(119, 23)
        Me.btnPrintWithDialog.TabIndex = 10007
        Me.btnPrintWithDialog.Text = "btnPrintWithDialog"
        Me.btnPrintWithDialog.UseVisualStyleBackColor = True
        '
        'btnPrintNow
        '
        Me.btnPrintNow.Location = New System.Drawing.Point(526, 161)
        Me.btnPrintNow.Name = "btnPrintNow"
        Me.btnPrintNow.Size = New System.Drawing.Size(119, 23)
        Me.btnPrintNow.TabIndex = 10008
        Me.btnPrintNow.Text = "btnPrintNow"
        Me.btnPrintNow.UseVisualStyleBackColor = True
        '
        'frmRecipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 449)
        Me.Controls.Add(Me.btnPrintNow)
        Me.Controls.Add(Me.btnPrintWithDialog)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnRestart)
        Me.Name = "frmRecipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents dlgPrint As PrintDialog
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
    Friend WithEvents btnPrintWithDialog As Button
    Friend WithEvents btnPrintNow As Button
End Class
