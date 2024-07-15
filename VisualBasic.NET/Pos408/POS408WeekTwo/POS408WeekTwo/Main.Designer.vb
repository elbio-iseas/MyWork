<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHomeAppliance = New System.Windows.Forms.Label()
        Me.txtCostPerKWHour = New System.Windows.Forms.TextBox()
        Me.lblCostPerKWH = New System.Windows.Forms.Label()
        Me.lblPowerRequired = New System.Windows.Forms.Label()
        Me.txtPowerInKW = New System.Windows.Forms.TextBox()
        Me.lblHoursPerDay = New System.Windows.Forms.Label()
        Me.txtHoursOfUsePerDay = New System.Windows.Forms.TextBox()
        Me.txtCostOfOperation = New System.Windows.Forms.TextBox()
        Me.lblCostOfOperation = New System.Windows.Forms.Label()
        Me.btnAnother = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ApplianceBox = New System.Windows.Forms.ComboBox()
        Me.btnCalcCostOfOperation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Decorated035 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(84, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(382, 22)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Home Utility Auditing"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeAppliance
        '
        Me.lblHomeAppliance.AutoSize = True
        Me.lblHomeAppliance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeAppliance.Location = New System.Drawing.Point(83, 71)
        Me.lblHomeAppliance.Name = "lblHomeAppliance"
        Me.lblHomeAppliance.Size = New System.Drawing.Size(134, 15)
        Me.lblHomeAppliance.TabIndex = 1
        Me.lblHomeAppliance.Text = "Cost per KW/Hour $"
        '
        'txtCostPerKWHour
        '
        Me.txtCostPerKWHour.Location = New System.Drawing.Point(223, 69)
        Me.txtCostPerKWHour.Name = "txtCostPerKWHour"
        Me.txtCostPerKWHour.Size = New System.Drawing.Size(98, 20)
        Me.txtCostPerKWHour.TabIndex = 2
        '
        'lblCostPerKWH
        '
        Me.lblCostPerKWH.AutoSize = True
        Me.lblCostPerKWH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerKWH.Location = New System.Drawing.Point(104, 106)
        Me.lblCostPerKWH.Name = "lblCostPerKWH"
        Me.lblCostPerKWH.Size = New System.Drawing.Size(113, 15)
        Me.lblCostPerKWH.TabIndex = 3
        Me.lblCostPerKWH.Text = "Home Appliance"
        '
        'lblPowerRequired
        '
        Me.lblPowerRequired.AutoSize = True
        Me.lblPowerRequired.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerRequired.Location = New System.Drawing.Point(75, 140)
        Me.lblPowerRequired.Name = "lblPowerRequired"
        Me.lblPowerRequired.Size = New System.Drawing.Size(142, 15)
        Me.lblPowerRequired.TabIndex = 5
        Me.lblPowerRequired.Text = "Power Needed in KW"
        '
        'txtPowerInKW
        '
        Me.txtPowerInKW.Location = New System.Drawing.Point(223, 138)
        Me.txtPowerInKW.Name = "txtPowerInKW"
        Me.txtPowerInKW.Size = New System.Drawing.Size(69, 20)
        Me.txtPowerInKW.TabIndex = 6
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursPerDay.Location = New System.Drawing.Point(77, 175)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(140, 16)
        Me.lblHoursPerDay.TabIndex = 7
        Me.lblHoursPerDay.Text = "Hours of Use per Day"
        '
        'txtHoursOfUsePerDay
        '
        Me.txtHoursOfUsePerDay.Location = New System.Drawing.Point(223, 174)
        Me.txtHoursOfUsePerDay.Name = "txtHoursOfUsePerDay"
        Me.txtHoursOfUsePerDay.Size = New System.Drawing.Size(69, 20)
        Me.txtHoursOfUsePerDay.TabIndex = 8
        '
        'txtCostOfOperation
        '
        Me.txtCostOfOperation.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostOfOperation.Enabled = False
        Me.txtCostOfOperation.Location = New System.Drawing.Point(223, 208)
        Me.txtCostOfOperation.Name = "txtCostOfOperation"
        Me.txtCostOfOperation.Size = New System.Drawing.Size(98, 20)
        Me.txtCostOfOperation.TabIndex = 9
        '
        'lblCostOfOperation
        '
        Me.lblCostOfOperation.AutoSize = True
        Me.lblCostOfOperation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfOperation.Location = New System.Drawing.Point(88, 209)
        Me.lblCostOfOperation.Name = "lblCostOfOperation"
        Me.lblCostOfOperation.Size = New System.Drawing.Size(129, 16)
        Me.lblCostOfOperation.TabIndex = 10
        Me.lblCostOfOperation.Text = "Cost of Operation $"
        '
        'btnAnother
        '
        Me.btnAnother.BackColor = System.Drawing.Color.SlateGray
        Me.btnAnother.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnother.Location = New System.Drawing.Point(212, 269)
        Me.btnAnother.Name = "btnAnother"
        Me.btnAnother.Size = New System.Drawing.Size(109, 29)
        Me.btnAnother.TabIndex = 11
        Me.btnAnother.Text = "Another"
        Me.btnAnother.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SlateGray
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(334, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 29)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ApplianceBox
        '
        Me.ApplianceBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplianceBox.FormattingEnabled = True
        Me.ApplianceBox.Items.AddRange(New Object() {"Big Screen TV", "Blender", "Blu Ray", "Central Air A/C", "Desktop Computer", "Dryer", "Hair Dryer", "Home Theater", "Iron", "Microwave Oven", "Refrigerator", "Stove Oven", "Stove Range Big", "Stove Range Small", "Washer Machine"})
        Me.ApplianceBox.Location = New System.Drawing.Point(223, 102)
        Me.ApplianceBox.Name = "ApplianceBox"
        Me.ApplianceBox.Size = New System.Drawing.Size(220, 24)
        Me.ApplianceBox.TabIndex = 13
        '
        'btnCalcCostOfOperation
        '
        Me.btnCalcCostOfOperation.BackColor = System.Drawing.Color.SlateGray
        Me.btnCalcCostOfOperation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCostOfOperation.Location = New System.Drawing.Point(86, 269)
        Me.btnCalcCostOfOperation.Name = "btnCalcCostOfOperation"
        Me.btnCalcCostOfOperation.Size = New System.Drawing.Size(109, 29)
        Me.btnCalcCostOfOperation.TabIndex = 14
        Me.btnCalcCostOfOperation.Text = "Calculate Cost"
        Me.btnCalcCostOfOperation.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(543, 311)
        Me.Controls.Add(Me.btnCalcCostOfOperation)
        Me.Controls.Add(Me.ApplianceBox)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAnother)
        Me.Controls.Add(Me.lblCostOfOperation)
        Me.Controls.Add(Me.txtCostOfOperation)
        Me.Controls.Add(Me.txtHoursOfUsePerDay)
        Me.Controls.Add(Me.lblHoursPerDay)
        Me.Controls.Add(Me.txtPowerInKW)
        Me.Controls.Add(Me.lblPowerRequired)
        Me.Controls.Add(Me.lblCostPerKWH)
        Me.Controls.Add(Me.txtCostPerKWHour)
        Me.Controls.Add(Me.lblHomeAppliance)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS408WeekTwo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblHomeAppliance As System.Windows.Forms.Label
    Friend WithEvents txtCostPerKWHour As System.Windows.Forms.TextBox
    Friend WithEvents lblCostPerKWH As System.Windows.Forms.Label
    Friend WithEvents lblPowerRequired As System.Windows.Forms.Label
    Friend WithEvents txtPowerInKW As System.Windows.Forms.TextBox
    Friend WithEvents lblHoursPerDay As System.Windows.Forms.Label
    Friend WithEvents txtHoursOfUsePerDay As System.Windows.Forms.TextBox
    Friend WithEvents txtCostOfOperation As System.Windows.Forms.TextBox
    Friend WithEvents lblCostOfOperation As System.Windows.Forms.Label
    Friend WithEvents btnAnother As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ApplianceBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalcCostOfOperation As System.Windows.Forms.Button

End Class
