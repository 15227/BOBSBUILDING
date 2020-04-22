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
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintDia = New System.Windows.Forms.PrintDialog()
        Me.PrintPrev = New System.Windows.Forms.PrintPreviewDialog()
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
        'PrintDoc
        '
        '
        'PrintDia
        '
        Me.PrintDia.UseEXDialog = True
        '
        'PrintPrev
        '
        Me.PrintPrev.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPrev.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPrev.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPrev.Enabled = True
        Me.PrintPrev.Icon = CType(resources.GetObject("PrintPrev.Icon"), System.Drawing.Icon)
        Me.PrintPrev.Name = "PrintPrev"
        Me.PrintPrev.Visible = False
        '
        'frmRecipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 449)
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
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintDia As PrintDialog
    Friend WithEvents PrintPrev As PrintPreviewDialog
End Class
