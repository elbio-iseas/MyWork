<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCostList = New System.Windows.Forms.Button()
        Me.lblGallonsPerHour = New System.Windows.Forms.Label()
        Me.lblCostPerGallon = New System.Windows.Forms.Label()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.txtGaUsedPerHour = New System.Windows.Forms.TextBox()
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
        Me.lblHomeAppliance.Location = New System.Drawing.Point(55, 72)
        Me.lblHomeAppliance.Name = "lblHomeAppliance"
        Me.lblHomeAppliance.Size = New System.Drawing.Size(134, 15)
        Me.lblHomeAppliance.TabIndex = 1
        Me.lblHomeAppliance.Text = "Cost per KW/Hour $"
        '
        'txtCostPerKWHour
        '
        Me.txtCostPerKWHour.Location = New System.Drawing.Point(195, 70)
        Me.txtCostPerKWHour.Name = "txtCostPerKWHour"
        Me.txtCostPerKWHour.Size = New System.Drawing.Size(98, 20)
        Me.txtCostPerKWHour.TabIndex = 2
        '
        'lblCostPerKWH
        '
        Me.lblCostPerKWH.AutoSize = True
        Me.lblCostPerKWH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerKWH.Location = New System.Drawing.Point(76, 107)
        Me.lblCostPerKWH.Name = "lblCostPerKWH"
        Me.lblCostPerKWH.Size = New System.Drawing.Size(113, 15)
        Me.lblCostPerKWH.TabIndex = 3
        Me.lblCostPerKWH.Text = "Home Appliance"
        '
        'lblPowerRequired
        '
        Me.lblPowerRequired.AutoSize = True
        Me.lblPowerRequired.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerRequired.Location = New System.Drawing.Point(47, 141)
        Me.lblPowerRequired.Name = "lblPowerRequired"
        Me.lblPowerRequired.Size = New System.Drawing.Size(142, 15)
        Me.lblPowerRequired.TabIndex = 5
        Me.lblPowerRequired.Text = "Power Needed in KW"
        '
        'txtPowerInKW
        '
        Me.txtPowerInKW.Location = New System.Drawing.Point(195, 139)
        Me.txtPowerInKW.Name = "txtPowerInKW"
        Me.txtPowerInKW.Size = New System.Drawing.Size(69, 20)
        Me.txtPowerInKW.TabIndex = 6
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursPerDay.Location = New System.Drawing.Point(49, 176)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(140, 16)
        Me.lblHoursPerDay.TabIndex = 7
        Me.lblHoursPerDay.Text = "Hours of Use per Day"
        '
        'txtHoursOfUsePerDay
        '
        Me.txtHoursOfUsePerDay.Location = New System.Drawing.Point(195, 175)
        Me.txtHoursOfUsePerDay.Name = "txtHoursOfUsePerDay"
        Me.txtHoursOfUsePerDay.Size = New System.Drawing.Size(69, 20)
        Me.txtHoursOfUsePerDay.TabIndex = 8
        '
        'txtCostOfOperation
        '
        Me.txtCostOfOperation.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostOfOperation.Enabled = False
        Me.txtCostOfOperation.Location = New System.Drawing.Point(195, 209)
        Me.txtCostOfOperation.Name = "txtCostOfOperation"
        Me.txtCostOfOperation.Size = New System.Drawing.Size(98, 20)
        Me.txtCostOfOperation.TabIndex = 9
        '
        'lblCostOfOperation
        '
        Me.lblCostOfOperation.AutoSize = True
        Me.lblCostOfOperation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfOperation.Location = New System.Drawing.Point(60, 210)
        Me.lblCostOfOperation.Name = "lblCostOfOperation"
        Me.lblCostOfOperation.Size = New System.Drawing.Size(129, 16)
        Me.lblCostOfOperation.TabIndex = 10
        Me.lblCostOfOperation.Text = "Cost of Operation $"
        '
        'btnAnother
        '
        Me.btnAnother.BackColor = System.Drawing.Color.SlateGray
        Me.btnAnother.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnother.Location = New System.Drawing.Point(155, 270)
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
        Me.btnExit.Location = New System.Drawing.Point(404, 270)
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
        Me.ApplianceBox.Location = New System.Drawing.Point(195, 103)
        Me.ApplianceBox.Name = "ApplianceBox"
        Me.ApplianceBox.Size = New System.Drawing.Size(220, 24)
        Me.ApplianceBox.TabIndex = 13
        '
        'btnCalcCostOfOperation
        '
        Me.btnCalcCostOfOperation.BackColor = System.Drawing.Color.SlateGray
        Me.btnCalcCostOfOperation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCostOfOperation.Location = New System.Drawing.Point(30, 270)
        Me.btnCalcCostOfOperation.Name = "btnCalcCostOfOperation"
        Me.btnCalcCostOfOperation.Size = New System.Drawing.Size(109, 29)
        Me.btnCalcCostOfOperation.TabIndex = 14
        Me.btnCalcCostOfOperation.Text = "Calculate Cost"
        Me.btnCalcCostOfOperation.UseVisualStyleBackColor = False
        '
        'btnCostList
        '
        Me.btnCostList.BackColor = System.Drawing.Color.SlateGray
        Me.btnCostList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCostList.Location = New System.Drawing.Point(280, 270)
        Me.btnCostList.Name = "btnCostList"
        Me.btnCostList.Size = New System.Drawing.Size(109, 29)
        Me.btnCostList.TabIndex = 15
        Me.btnCostList.Text = "Cost List"
        Me.btnCostList.UseVisualStyleBackColor = False
        '
        'lblGallonsPerHour
        '
        Me.lblGallonsPerHour.AutoSize = True
        Me.lblGallonsPerHour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallonsPerHour.Location = New System.Drawing.Point(270, 141)
        Me.lblGallonsPerHour.Name = "lblGallonsPerHour"
        Me.lblGallonsPerHour.Size = New System.Drawing.Size(152, 15)
        Me.lblGallonsPerHour.TabIndex = 16
        Me.lblGallonsPerHour.Text = "Gallons Used per Hour"
        '
        'lblCostPerGallon
        '
        Me.lblCostPerGallon.AutoSize = True
        Me.lblCostPerGallon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerGallon.Location = New System.Drawing.Point(305, 175)
        Me.lblCostPerGallon.Name = "lblCostPerGallon"
        Me.lblCostPerGallon.Size = New System.Drawing.Size(117, 16)
        Me.lblCostPerGallon.TabIndex = 17
        Me.lblCostPerGallon.Text = "Cost per Gallon $"
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostPerGallon.Enabled = False
        Me.txtCostPerGallon.Location = New System.Drawing.Point(428, 175)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(98, 20)
        Me.txtCostPerGallon.TabIndex = 18
        Me.txtCostPerGallon.Text = "  "
        '
        'txtGaUsedPerHour
        '
        Me.txtGaUsedPerHour.Location = New System.Drawing.Point(428, 139)
        Me.txtGaUsedPerHour.Name = "txtGaUsedPerHour"
        Me.txtGaUsedPerHour.Size = New System.Drawing.Size(69, 20)
        Me.txtGaUsedPerHour.TabIndex = 19
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(543, 311)
        Me.Controls.Add(Me.txtGaUsedPerHour)
        Me.Controls.Add(Me.txtCostPerGallon)
        Me.Controls.Add(Me.lblCostPerGallon)
        Me.Controls.Add(Me.lblGallonsPerHour)
        Me.Controls.Add(Me.btnCostList)
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
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS408WeekThree"
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
    Friend WithEvents btnCostList As System.Windows.Forms.Button
    Friend WithEvents lblGallonsPerHour As System.Windows.Forms.Label
    Friend WithEvents lblCostPerGallon As System.Windows.Forms.Label
    Friend WithEvents txtCostPerGallon As System.Windows.Forms.TextBox
    Friend WithEvents txtGaUsedPerHour As System.Windows.Forms.TextBox

End Class
