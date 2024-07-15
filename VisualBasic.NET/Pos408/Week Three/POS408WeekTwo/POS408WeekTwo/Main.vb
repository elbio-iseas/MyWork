Public Class frmMain

    ' Part of the idea for event handlers and validation was taken from the teacher's examples 
    ' in Validation Demo application
    ' The arraylist with structures taken from thenewboston tutorial 77
    Public Shared AListHomeApp As New ArrayList

    Private Structure HomeAppliance

        Public CostPerKWH As Double
        Public HomeAppName As String
        Public PowerNeeded As Double
        Public HoursPerDay As Double
        Public GaPerHour As Double
        Public CostOfGallon As Double
        Public CostOfOperation As Double

    End Structure

    Private objHomeApp, objAuxHomeApp As HomeAppliance

    Private Sub AddHomeApp(ByVal objHA As HomeAppliance)

        Dim objNHomeApp As HomeAppliance

        objNHomeApp = objHA
        
        AListHomeApp.Add(objNHomeApp)

    End Sub

    Private Sub LoadHomeApp(ByVal homeApp As HomeAppliance)

    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblGallonsPerHour.Hide()
        txtGaUsedPerHour.Hide()
        lblCostPerGallon.Hide()
        txtCostPerGallon.Hide()

    End Sub

    Private Sub lblCostPerKWH_Click(sender As System.Object, e As System.EventArgs) Handles lblCostPerKWH.Click

    End Sub
    Private Sub txtCostPerKWHour_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCostPerKWHour.Validating
        Try

            ' It declares and converts the text entered to double
            Dim dblCostPerKWHour As Double = CDbl(txtCostPerKWHour.Text)

            ' It controls that the value entered is greater than to 0.0 and less than 6.0
            If dblCostPerKWHour > 0.0 And dblCostPerKWHour < 6.0 Then

                ' The value entered is in the range allowed and it sets the variable to False for avoiding cancelling the event
                e.Cancel = False

            Else

                ' The value entered is not in the range allowed, then it returns an error dialog 
                MsgBox("The cost of a KW/Hour is from $0.0 to $6.0.", MsgBoxStyle.Exclamation, "Error!")
                ' The value entered is not allowed and the event is set to be cancelled
                e.Cancel = True
                Me.txtCostPerKWHour.Text = ""

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("The cost per KW/Hour should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True
            Me.txtCostPerKWHour.Text = ""

        End Try
    End Sub
    Private Sub txtPowerInKW_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPowerInKW.Validating
        Try

            ' It declares and converts the text entered to double
            Dim dblPowerInKW As Double = CDbl(txtPowerInKW.Text)

            ' It controls that the value entered is greater than to 0.0 and less than 6.0
            If dblPowerInKW > 0.0 And dblPowerInKW <= 6.0 Then

                ' The value entered is in the range allowed and it sets the variable to False for avoiding cancelling the event
                e.Cancel = False

            Else

                ' The value entered is not in the range allowed, then it returns an error dialog 
                MsgBox("The power needed in KW is from $0.0 to $6.0.", MsgBoxStyle.Exclamation, "Error!")
                ' The value entered is not allowed and the event is set to be cancelled
                e.Cancel = True
                Me.txtPowerInKW.Text = ""

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("The power needed in KW should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True
            Me.txtPowerInKW.Text = ""

        End Try
    End Sub
    Private Sub txtHoursOfUsePerDay_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHoursOfUsePerDay.Validating

        Try

            ' It declares and converts the text entered to double
            Dim dblHoursOfUsePerDay As Double = CDbl(txtHoursOfUsePerDay.Text)

            ' It controls that the value entered is greater than to 0.0 and less than 6.0
            If dblHoursOfUsePerDay > 0.0 And dblHoursOfUsePerDay <= 24.0 Then

                ' The value entered is in the range allowed and it sets the variable to False for avoiding cancelling the event
                e.Cancel = False

            Else

                ' The value entered is not in the range allowed, then it returns an error dialog 
                MsgBox("The hours of use per day are from 0.0 to 24.0.", MsgBoxStyle.Exclamation, "Error!")
                ' The value entered is not allowed and the event is set to be cancelled
                e.Cancel = True
                Me.txtHoursOfUsePerDay.Text = ""

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("The hours of use per day should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True
            Me.txtHoursOfUsePerDay.Text = ""

        End Try
    End Sub
    '=====================================================================================================================================================
    Private Sub txtGaUsedPerHour_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGaUsedPerHour.Validating
        Try

            ' It declares and converts the text entered to double
            Dim dblGaUsedPerHour As Double = CDbl(txtGaUsedPerHour.Text)

            ' It controls that the value entered is greater or equal to 25.0 and less or equal to 57.0
            If dblGaUsedPerHour >= 25.0 And dblGaUsedPerHour <= 57.0 Then

                ' The value entered is in the range allowed and it sets the variable to False for avoiding cancelling the event
                e.Cancel = False

            Else

                ' The value entered is not in the range allowed, then it returns an error dialog 
                MsgBox("Total gallons of water used per hour should range from 25 to 57", MsgBoxStyle.Exclamation, "Error!")
                ' The value entered is not allowed and the event is set to be cancelled
                e.Cancel = True
                Me.txtGaUsedPerHour.Text = ""

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("Total gallons of water used per hour should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True
            Me.txtGaUsedPerHour.Text = ""

        End Try
    End Sub
    '=====================================================================================================================================================
    Private Sub txtCostPerGallon_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCostPerGallon.Validating
        Try

            ' It declares and converts the text entered to double
            Dim dblCostPerGallon As Double = CDbl(txtCostPerGallon.Text)

            ' It controls that the value entered is greater or equal to 0.10 and less or equal to 0.25
            If dblCostPerGallon >= 0.1 And dblCostPerGallon <= 0.25 Then

                ' The value entered is in the range allowed and it sets the variable to False for avoiding cancelling the event
                e.Cancel = False

            Else

                ' The value entered is not in the range allowed, then it returns an error dialog 
                MsgBox("The cost of a gallon of water should range from 0.10 to 0.25", MsgBoxStyle.Exclamation, "Error!")
                ' The value entered is not allowed and the event is set to be cancelled
                e.Cancel = True
                Me.txtCostPerGallon.Text = ""

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("The cost of a gallon of water should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True
            Me.txtCostPerGallon.Text = ""

        End Try
    End Sub

    Private Sub lblTitle_Click(sender As System.Object, e As System.EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnExit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnAnother_Click(sender As System.Object, e As System.EventArgs) Handles btnAnother.Click

        lblGallonsPerHour.Hide()
        txtGaUsedPerHour.Hide()
        lblCostPerGallon.Hide()
        txtCostPerGallon.Hide()

        Me.txtCostPerKWHour.Text = ""
        Me.ApplianceBox.Text = ""
        Me.txtPowerInKW.Text = ""
        Me.txtHoursOfUsePerDay.Text = ""
        Me.txtCostOfOperation.Text = ""
        Me.txtGaUsedPerHour.Text = ""
        Me.txtCostPerGallon.Text = ""

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ApplianceBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ApplianceBox.SelectedIndexChanged

        Me.ApplianceBox.Text = ApplianceBox.SelectedItem.ToString()

    End Sub

    Private Sub btnCalcCostOfOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcCostOfOperation.Click

        If (Len(txtCostPerKWHour.Text) > 0) And (Len(ApplianceBox.Text) > 0) And (Len(txtPowerInKW.Text) > 0) And (Len(txtHoursOfUsePerDay.Text) > 0) Then

            Dim dblCost, dblPower, dblHours, dblCostOfOperation As Double
            Dim dblGaPerHour, dblCostOfGallon As Double

            dblCost = CDbl(txtCostPerKWHour.Text)
            dblPower = CDbl(txtPowerInKW.Text)
            dblHours = CDbl(txtHoursOfUsePerDay.Text)

            If ApplianceBox.Text = "Washer Machine" Then

                Me.lblGallonsPerHour.Show()
                Me.txtGaUsedPerHour.Show()
                Me.lblCostPerGallon.Show()
                Me.txtCostPerGallon.Show()

                dblCostOfGallon = CDbl(Me.txtCostPerGallon.Text)
                dblGaPerHour = CDbl(Me.txtGaUsedPerHour.Text)

                dblCostOfOperation = (dblCost * dblPower * dblHours) + ((dblCostOfGallon * dblGaPerHour) * dblHours)

            Else

                dblCostOfOperation = dblCost * dblPower * dblHours

            End If

            objAuxHomeApp.CostPerKWH = dblCost
            objAuxHomeApp.HomeAppName = ApplianceBox.Text
            objAuxHomeApp.PowerNeeded = dblPower
            objAuxHomeApp.HoursPerDay = dblHours
            objAuxHomeApp.GaPerHour = dblGaPerHour
            objAuxHomeApp.CostOfGallon = dblCostOfGallon
            objAuxHomeApp.CostOfOperation = dblCostOfOperation

            txtCostOfOperation.Text = dblCostOfOperation.ToString

            AddHomeApp(objAuxHomeApp)

        Else
            MsgBox("Complete all fields, and click Calculate Cost button again.")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnCostList_Click(sender As System.Object, e As System.EventArgs) Handles btnCostList.Click
        Dim dblTotal As Double
        dblTotal = AListHomeApp.Count()
        If dblTotal > 0 Then
            ListOfAppliances.Show()
        Else
            MsgBox("There are no Home Appliances to display!")
        End If
    End Sub
End Class
