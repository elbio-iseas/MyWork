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
        Me.ApplianceBox = New System.Windows.Forms.ComboBox()
        Me.lblCostPerKWH = New System.Windows.Forms.Label()
        Me.txtCostPerKWHour = New System.Windows.Forms.TextBox()
        Me.lblHomeAppliance = New System.Windows.Forms.Label()
        Me.txtHoursOfUsePerDay = New System.Windows.Forms.TextBox()
        Me.lblHoursPerDay = New System.Windows.Forms.Label()
        Me.txtPowerInKW = New System.Windows.Forms.TextBox()
        Me.lblPowerRequired = New System.Windows.Forms.Label()
        Me.txtGaUsedPerHour = New System.Windows.Forms.TextBox()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.lblCostPerGallon = New System.Windows.Forms.Label()
        Me.lblGallonsPerHour = New System.Windows.Forms.Label()
        Me.lblCostOfOperation = New System.Windows.Forms.Label()
        Me.txtCostOfOperation = New System.Windows.Forms.TextBox()
        Me.btnReadDefaultValues = New System.Windows.Forms.Button()
        Me.btnCostList = New System.Windows.Forms.Button()
        Me.btnCalcCostOfOperation = New System.Windows.Forms.Button()
        Me.btnAnother = New System.Windows.Forms.Button()
        Me.btnSaveToFile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Decorated035 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(122, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(382, 22)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Home Utility Auditing"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ApplianceBox
        '
        Me.ApplianceBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ApplianceBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplianceBox.FormattingEnabled = True
        Me.ApplianceBox.Items.AddRange(New Object() {"Big Screen TV", "Blender", "Blu Ray", "Central Air A/C", "Desktop Computer", "Dryer", "Hair Dryer", "Home Theater", "Iron", "Microwave Oven", "Refrigerator", "Stove Oven", "Stove Range Big", "Stove Range Small", "Washer Machine"})
        Me.ApplianceBox.Location = New System.Drawing.Point(218, 63)
        Me.ApplianceBox.Name = "ApplianceBox"
        Me.ApplianceBox.Size = New System.Drawing.Size(220, 24)
        Me.ApplianceBox.TabIndex = 15
        '
        'lblCostPerKWH
        '
        Me.lblCostPerKWH.AutoSize = True
        Me.lblCostPerKWH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerKWH.ForeColor = System.Drawing.Color.Gold
        Me.lblCostPerKWH.Location = New System.Drawing.Point(90, 72)
        Me.lblCostPerKWH.Name = "lblCostPerKWH"
        Me.lblCostPerKWH.Size = New System.Drawing.Size(113, 15)
        Me.lblCostPerKWH.TabIndex = 14
        Me.lblCostPerKWH.Text = "Home Appliance"
        '
        'txtCostPerKWHour
        '
        Me.txtCostPerKWHour.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCostPerKWHour.Location = New System.Drawing.Point(218, 105)
        Me.txtCostPerKWHour.Name = "txtCostPerKWHour"
        Me.txtCostPerKWHour.Size = New System.Drawing.Size(98, 20)
        Me.txtCostPerKWHour.TabIndex = 17
        '
        'lblHomeAppliance
        '
        Me.lblHomeAppliance.AutoSize = True
        Me.lblHomeAppliance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeAppliance.ForeColor = System.Drawing.Color.Gold
        Me.lblHomeAppliance.Location = New System.Drawing.Point(69, 110)
        Me.lblHomeAppliance.Name = "lblHomeAppliance"
        Me.lblHomeAppliance.Size = New System.Drawing.Size(134, 15)
        Me.lblHomeAppliance.TabIndex = 16
        Me.lblHomeAppliance.Text = "Cost per KW/Hour $"
        '
        'txtHoursOfUsePerDay
        '
        Me.txtHoursOfUsePerDay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtHoursOfUsePerDay.Location = New System.Drawing.Point(218, 185)
        Me.txtHoursOfUsePerDay.Name = "txtHoursOfUsePerDay"
        Me.txtHoursOfUsePerDay.Size = New System.Drawing.Size(69, 20)
        Me.txtHoursOfUsePerDay.TabIndex = 21
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursPerDay.ForeColor = System.Drawing.Color.Gold
        Me.lblHoursPerDay.Location = New System.Drawing.Point(63, 185)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(142, 15)
        Me.lblHoursPerDay.TabIndex = 20
        Me.lblHoursPerDay.Text = "Hours of Use per Day"
        '
        'txtPowerInKW
        '
        Me.txtPowerInKW.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPowerInKW.Location = New System.Drawing.Point(218, 144)
        Me.txtPowerInKW.Name = "txtPowerInKW"
        Me.txtPowerInKW.Size = New System.Drawing.Size(69, 20)
        Me.txtPowerInKW.TabIndex = 19
        '
        'lblPowerRequired
        '
        Me.lblPowerRequired.AutoSize = True
        Me.lblPowerRequired.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerRequired.ForeColor = System.Drawing.Color.Gold
        Me.lblPowerRequired.Location = New System.Drawing.Point(61, 149)
        Me.lblPowerRequired.Name = "lblPowerRequired"
        Me.lblPowerRequired.Size = New System.Drawing.Size(142, 15)
        Me.lblPowerRequired.TabIndex = 18
        Me.lblPowerRequired.Text = "Power Needed in KW"
        '
        'txtGaUsedPerHour
        '
        Me.txtGaUsedPerHour.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtGaUsedPerHour.Location = New System.Drawing.Point(218, 220)
        Me.txtGaUsedPerHour.Name = "txtGaUsedPerHour"
        Me.txtGaUsedPerHour.Size = New System.Drawing.Size(69, 20)
        Me.txtGaUsedPerHour.TabIndex = 25
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCostPerGallon.Location = New System.Drawing.Point(218, 259)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(98, 20)
        Me.txtCostPerGallon.TabIndex = 24
        Me.txtCostPerGallon.Text = "  "
        '
        'lblCostPerGallon
        '
        Me.lblCostPerGallon.AutoSize = True
        Me.lblCostPerGallon.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerGallon.ForeColor = System.Drawing.Color.Gold
        Me.lblCostPerGallon.Location = New System.Drawing.Point(86, 260)
        Me.lblCostPerGallon.Name = "lblCostPerGallon"
        Me.lblCostPerGallon.Size = New System.Drawing.Size(118, 15)
        Me.lblCostPerGallon.TabIndex = 23
        Me.lblCostPerGallon.Text = "Cost per Gallon $"
        '
        'lblGallonsPerHour
        '
        Me.lblGallonsPerHour.AutoSize = True
        Me.lblGallonsPerHour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallonsPerHour.ForeColor = System.Drawing.Color.Gold
        Me.lblGallonsPerHour.Location = New System.Drawing.Point(51, 222)
        Me.lblGallonsPerHour.Name = "lblGallonsPerHour"
        Me.lblGallonsPerHour.Size = New System.Drawing.Size(152, 15)
        Me.lblGallonsPerHour.TabIndex = 22
        Me.lblGallonsPerHour.Text = "Gallons Used per Hour"
        '
        'lblCostOfOperation
        '
        Me.lblCostOfOperation.AutoSize = True
        Me.lblCostOfOperation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfOperation.ForeColor = System.Drawing.Color.Gold
        Me.lblCostOfOperation.Location = New System.Drawing.Point(74, 295)
        Me.lblCostOfOperation.Name = "lblCostOfOperation"
        Me.lblCostOfOperation.Size = New System.Drawing.Size(131, 15)
        Me.lblCostOfOperation.TabIndex = 27
        Me.lblCostOfOperation.Text = "Cost of Operation $"
        '
        'txtCostOfOperation
        '
        Me.txtCostOfOperation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCostOfOperation.Enabled = False
        Me.txtCostOfOperation.Location = New System.Drawing.Point(218, 295)
        Me.txtCostOfOperation.Name = "txtCostOfOperation"
        Me.txtCostOfOperation.Size = New System.Drawing.Size(98, 20)
        Me.txtCostOfOperation.TabIndex = 26
        '
        'btnReadDefaultValues
        '
        Me.btnReadDefaultValues.BackColor = System.Drawing.Color.SlateGray
        Me.btnReadDefaultValues.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadDefaultValues.ForeColor = System.Drawing.Color.Gold
        Me.btnReadDefaultValues.Location = New System.Drawing.Point(466, 53)
        Me.btnReadDefaultValues.Name = "btnReadDefaultValues"
        Me.btnReadDefaultValues.Padding = New System.Windows.Forms.Padding(1)
        Me.btnReadDefaultValues.Size = New System.Drawing.Size(151, 42)
        Me.btnReadDefaultValues.TabIndex = 28
        Me.btnReadDefaultValues.Text = "Read Default Values"
        Me.btnReadDefaultValues.UseVisualStyleBackColor = False
        '
        'btnCostList
        '
        Me.btnCostList.BackColor = System.Drawing.Color.SlateGray
        Me.btnCostList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCostList.ForeColor = System.Drawing.Color.Gold
        Me.btnCostList.Location = New System.Drawing.Point(466, 196)
        Me.btnCostList.Name = "btnCostList"
        Me.btnCostList.Padding = New System.Windows.Forms.Padding(1)
        Me.btnCostList.Size = New System.Drawing.Size(151, 42)
        Me.btnCostList.TabIndex = 31
        Me.btnCostList.Text = "Cost List"
        Me.btnCostList.UseVisualStyleBackColor = False
        '
        'btnCalcCostOfOperation
        '
        Me.btnCalcCostOfOperation.BackColor = System.Drawing.Color.SlateGray
        Me.btnCalcCostOfOperation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCostOfOperation.ForeColor = System.Drawing.Color.Gold
        Me.btnCalcCostOfOperation.Location = New System.Drawing.Point(466, 101)
        Me.btnCalcCostOfOperation.Name = "btnCalcCostOfOperation"
        Me.btnCalcCostOfOperation.Padding = New System.Windows.Forms.Padding(1)
        Me.btnCalcCostOfOperation.Size = New System.Drawing.Size(151, 42)
        Me.btnCalcCostOfOperation.TabIndex = 30
        Me.btnCalcCostOfOperation.Text = "Calculate Cost"
        Me.btnCalcCostOfOperation.UseVisualStyleBackColor = False
        '
        'btnAnother
        '
        Me.btnAnother.BackColor = System.Drawing.Color.SlateGray
        Me.btnAnother.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnother.ForeColor = System.Drawing.Color.Gold
        Me.btnAnother.Location = New System.Drawing.Point(466, 149)
        Me.btnAnother.Name = "btnAnother"
        Me.btnAnother.Padding = New System.Windows.Forms.Padding(1)
        Me.btnAnother.Size = New System.Drawing.Size(151, 42)
        Me.btnAnother.TabIndex = 29
        Me.btnAnother.Text = "Another"
        Me.btnAnother.UseVisualStyleBackColor = False
        '
        'btnSaveToFile
        '
        Me.btnSaveToFile.BackColor = System.Drawing.Color.SlateGray
        Me.btnSaveToFile.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToFile.ForeColor = System.Drawing.Color.Gold
        Me.btnSaveToFile.Location = New System.Drawing.Point(466, 242)
        Me.btnSaveToFile.Name = "btnSaveToFile"
        Me.btnSaveToFile.Padding = New System.Windows.Forms.Padding(1)
        Me.btnSaveToFile.Size = New System.Drawing.Size(151, 42)
        Me.btnSaveToFile.TabIndex = 32
        Me.btnSaveToFile.Text = "Save to File"
        Me.btnSaveToFile.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SlateGray
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(466, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(1)
        Me.btnExit.Size = New System.Drawing.Size(151, 42)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(629, 341)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveToFile)
        Me.Controls.Add(Me.btnCostList)
        Me.Controls.Add(Me.btnCalcCostOfOperation)
        Me.Controls.Add(Me.btnAnother)
        Me.Controls.Add(Me.btnReadDefaultValues)
        Me.Controls.Add(Me.lblCostOfOperation)
        Me.Controls.Add(Me.txtCostOfOperation)
        Me.Controls.Add(Me.txtGaUsedPerHour)
        Me.Controls.Add(Me.txtCostPerGallon)
        Me.Controls.Add(Me.lblCostPerGallon)
        Me.Controls.Add(Me.lblGallonsPerHour)
        Me.Controls.Add(Me.txtHoursOfUsePerDay)
        Me.Controls.Add(Me.lblHoursPerDay)
        Me.Controls.Add(Me.txtPowerInKW)
        Me.Controls.Add(Me.lblPowerRequired)
        Me.Controls.Add(Me.txtCostPerKWHour)
        Me.Controls.Add(Me.lblHomeAppliance)
        Me.Controls.Add(Me.ApplianceBox)
        Me.Controls.Add(Me.lblCostPerKWH)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POSWeekFour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ApplianceBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblCostPerKWH As System.Windows.Forms.Label
    Friend WithEvents txtCostPerKWHour As System.Windows.Forms.TextBox
    Friend WithEvents lblHomeAppliance As System.Windows.Forms.Label
    Friend WithEvents txtHoursOfUsePerDay As System.Windows.Forms.TextBox
    Friend WithEvents lblHoursPerDay As System.Windows.Forms.Label
    Friend WithEvents txtPowerInKW As System.Windows.Forms.TextBox
    Friend WithEvents lblPowerRequired As System.Windows.Forms.Label
    Friend WithEvents txtGaUsedPerHour As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerGallon As System.Windows.Forms.TextBox
    Friend WithEvents lblCostPerGallon As System.Windows.Forms.Label
    Friend WithEvents lblGallonsPerHour As System.Windows.Forms.Label
    Friend WithEvents lblCostOfOperation As System.Windows.Forms.Label
    Friend WithEvents txtCostOfOperation As System.Windows.Forms.TextBox
    Friend WithEvents btnReadDefaultValues As System.Windows.Forms.Button
    Friend WithEvents btnCostList As System.Windows.Forms.Button
    Friend WithEvents btnCalcCostOfOperation As System.Windows.Forms.Button
    Friend WithEvents btnAnother As System.Windows.Forms.Button
    Friend WithEvents btnSaveToFile As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
