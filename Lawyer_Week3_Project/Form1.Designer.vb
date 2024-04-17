<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudioRevenue
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
        Me.lblGroupName = New System.Windows.Forms.Label()
        Me.lblTimeUsed = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.txtTimeUsed = New System.Windows.Forms.TextBox()
        Me.lblAmountCharged = New System.Windows.Forms.Label()
        Me.btnCalculateAmountCharged = New System.Windows.Forms.Button()
        Me.lblTotalCharged = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblNumGroupsCalculated = New System.Windows.Forms.Label()
        Me.lblAvgChargeCalculated = New System.Windows.Forms.Label()
        Me.lblTotalChargesCalculated = New System.Windows.Forms.Label()
        Me.lblNumberOfGroups = New System.Windows.Forms.Label()
        Me.lblAvgChargeAllGroups = New System.Windows.Forms.Label()
        Me.lblTotalChargesAllGroups = New System.Windows.Forms.Label()
        Me.btnClearData = New System.Windows.Forms.Button()
        Me.btnClearAllData = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsDateTimeGrp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsProgrammerName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpSummary.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGroupName
        '
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupName.Location = New System.Drawing.Point(100, 20)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(108, 20)
        Me.lblGroupName.TabIndex = 0
        Me.lblGroupName.Text = "Group Name: "
        Me.lblGroupName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTimeUsed
        '
        Me.lblTimeUsed.AutoSize = True
        Me.lblTimeUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeUsed.Location = New System.Drawing.Point(115, 53)
        Me.lblTimeUsed.Name = "lblTimeUsed"
        Me.lblTimeUsed.Size = New System.Drawing.Size(93, 20)
        Me.lblTimeUsed.TabIndex = 1
        Me.lblTimeUsed.Text = "Time Used: "
        Me.lblTimeUsed.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(244, 22)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(146, 20)
        Me.txtGroupName.TabIndex = 2
        '
        'txtTimeUsed
        '
        Me.txtTimeUsed.Location = New System.Drawing.Point(244, 55)
        Me.txtTimeUsed.Name = "txtTimeUsed"
        Me.txtTimeUsed.Size = New System.Drawing.Size(146, 20)
        Me.txtTimeUsed.TabIndex = 3
        '
        'lblAmountCharged
        '
        Me.lblAmountCharged.AutoSize = True
        Me.lblAmountCharged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountCharged.Location = New System.Drawing.Point(532, 53)
        Me.lblAmountCharged.Name = "lblAmountCharged"
        Me.lblAmountCharged.Size = New System.Drawing.Size(49, 20)
        Me.lblAmountCharged.TabIndex = 4
        Me.lblAmountCharged.Text = "$0.00"
        '
        'btnCalculateAmountCharged
        '
        Me.btnCalculateAmountCharged.Location = New System.Drawing.Point(212, 93)
        Me.btnCalculateAmountCharged.Name = "btnCalculateAmountCharged"
        Me.btnCalculateAmountCharged.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateAmountCharged.TabIndex = 5
        Me.btnCalculateAmountCharged.Text = "Calculate"
        Me.btnCalculateAmountCharged.UseVisualStyleBackColor = True
        '
        'lblTotalCharged
        '
        Me.lblTotalCharged.AutoSize = True
        Me.lblTotalCharged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharged.Location = New System.Drawing.Point(470, 20)
        Me.lblTotalCharged.Name = "lblTotalCharged"
        Me.lblTotalCharged.Size = New System.Drawing.Size(169, 20)
        Me.lblTotalCharged.TabIndex = 6
        Me.lblTotalCharged.Text = "Total Amount Charged"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(697, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 28)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.lblNumGroupsCalculated)
        Me.grpSummary.Controls.Add(Me.lblAvgChargeCalculated)
        Me.grpSummary.Controls.Add(Me.lblTotalChargesCalculated)
        Me.grpSummary.Controls.Add(Me.lblNumberOfGroups)
        Me.grpSummary.Controls.Add(Me.lblAvgChargeAllGroups)
        Me.grpSummary.Controls.Add(Me.lblTotalChargesAllGroups)
        Me.grpSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSummary.Location = New System.Drawing.Point(143, 149)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(354, 226)
        Me.grpSummary.TabIndex = 10
        Me.grpSummary.TabStop = False
        '
        'lblNumGroupsCalculated
        '
        Me.lblNumGroupsCalculated.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumGroupsCalculated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumGroupsCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGroupsCalculated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNumGroupsCalculated.Location = New System.Drawing.Point(178, 150)
        Me.lblNumGroupsCalculated.Name = "lblNumGroupsCalculated"
        Me.lblNumGroupsCalculated.Size = New System.Drawing.Size(173, 67)
        Me.lblNumGroupsCalculated.TabIndex = 32
        Me.lblNumGroupsCalculated.Text = "0"
        Me.lblNumGroupsCalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvgChargeCalculated
        '
        Me.lblAvgChargeCalculated.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAvgChargeCalculated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgChargeCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgChargeCalculated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAvgChargeCalculated.Location = New System.Drawing.Point(178, 83)
        Me.lblAvgChargeCalculated.Name = "lblAvgChargeCalculated"
        Me.lblAvgChargeCalculated.Size = New System.Drawing.Size(173, 67)
        Me.lblAvgChargeCalculated.TabIndex = 31
        Me.lblAvgChargeCalculated.Text = "$0.00"
        Me.lblAvgChargeCalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalChargesCalculated
        '
        Me.lblTotalChargesCalculated.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalChargesCalculated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalChargesCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalChargesCalculated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalChargesCalculated.Location = New System.Drawing.Point(178, 16)
        Me.lblTotalChargesCalculated.Name = "lblTotalChargesCalculated"
        Me.lblTotalChargesCalculated.Size = New System.Drawing.Size(173, 67)
        Me.lblTotalChargesCalculated.TabIndex = 30
        Me.lblTotalChargesCalculated.Text = "$0.00"
        Me.lblTotalChargesCalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberOfGroups
        '
        Me.lblNumberOfGroups.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNumberOfGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumberOfGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumberOfGroups.Location = New System.Drawing.Point(0, 150)
        Me.lblNumberOfGroups.Name = "lblNumberOfGroups"
        Me.lblNumberOfGroups.Size = New System.Drawing.Size(181, 67)
        Me.lblNumberOfGroups.TabIndex = 27
        Me.lblNumberOfGroups.Text = "Number of Groups"
        Me.lblNumberOfGroups.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAvgChargeAllGroups
        '
        Me.lblAvgChargeAllGroups.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAvgChargeAllGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgChargeAllGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgChargeAllGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAvgChargeAllGroups.Location = New System.Drawing.Point(0, 83)
        Me.lblAvgChargeAllGroups.Name = "lblAvgChargeAllGroups"
        Me.lblAvgChargeAllGroups.Size = New System.Drawing.Size(181, 67)
        Me.lblAvgChargeAllGroups.TabIndex = 29
        Me.lblAvgChargeAllGroups.Text = "Average Charge for All Groups"
        Me.lblAvgChargeAllGroups.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalChargesAllGroups
        '
        Me.lblTotalChargesAllGroups.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalChargesAllGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalChargesAllGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalChargesAllGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalChargesAllGroups.Location = New System.Drawing.Point(0, 16)
        Me.lblTotalChargesAllGroups.Name = "lblTotalChargesAllGroups"
        Me.lblTotalChargesAllGroups.Size = New System.Drawing.Size(181, 67)
        Me.lblTotalChargesAllGroups.TabIndex = 28
        Me.lblTotalChargesAllGroups.Text = "Total Charges for All Groups"
        Me.lblTotalChargesAllGroups.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClearData
        '
        Me.btnClearData.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearData.Location = New System.Drawing.Point(328, 93)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(75, 23)
        Me.btnClearData.TabIndex = 9
        Me.btnClearData.Text = "Clear"
        Me.btnClearData.UseVisualStyleBackColor = True
        '
        'btnClearAllData
        '
        Me.btnClearAllData.Location = New System.Drawing.Point(265, 386)
        Me.btnClearAllData.Name = "btnClearAllData"
        Me.btnClearAllData.Size = New System.Drawing.Size(112, 23)
        Me.btnClearAllData.TabIndex = 11
        Me.btnClearAllData.Text = "Clear &All Data"
        Me.btnClearAllData.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsDateTimeGrp, Me.stsProgrammerName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsDateTimeGrp
        '
        Me.stsDateTimeGrp.Name = "stsDateTimeGrp"
        Me.stsDateTimeGrp.Size = New System.Drawing.Size(62, 17)
        Me.stsDateTimeGrp.Text = "DateString"
        '
        'stsProgrammerName
        '
        Me.stsProgrammerName.Name = "stsProgrammerName"
        Me.stsProgrammerName.Size = New System.Drawing.Size(75, 17)
        Me.stsProgrammerName.Text = "Craig Lawyer"
        '
        'frmStudioRevenue
        '
        Me.AcceptButton = Me.btnCalculateAmountCharged
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.btnClearData
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnClearAllData)
        Me.Controls.Add(Me.btnClearData)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalCharged)
        Me.Controls.Add(Me.btnCalculateAmountCharged)
        Me.Controls.Add(Me.lblAmountCharged)
        Me.Controls.Add(Me.txtTimeUsed)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.lblTimeUsed)
        Me.Controls.Add(Me.lblGroupName)
        Me.Name = "frmStudioRevenue"
        Me.Text = "Studio Revenue"
        Me.grpSummary.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGroupName As Label
    Friend WithEvents lblTimeUsed As Label
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents txtTimeUsed As TextBox
    Friend WithEvents lblAmountCharged As Label
    Friend WithEvents btnCalculateAmountCharged As Button
    Friend WithEvents lblTotalCharged As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents btnClearData As Button
    Friend WithEvents btnClearAllData As Button
    Friend WithEvents lblAvgChargeAllGroups As Label
    Friend WithEvents lblTotalChargesAllGroups As Label
    Friend WithEvents lblNumberOfGroups As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stsProgrammerName As ToolStripStatusLabel
    Friend WithEvents stsDateTimeGrp As ToolStripStatusLabel
    Friend WithEvents lblTotalChargesCalculated As Label
    Friend WithEvents lblNumGroupsCalculated As Label
    Friend WithEvents lblAvgChargeCalculated As Label
End Class
