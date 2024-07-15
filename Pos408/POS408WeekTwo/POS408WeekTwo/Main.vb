Public Class Main
    ' Part of the idea for event handlers and validation was taken from the teacher's examples 
    ' in Validation Demo application

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
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
    Private Sub txtPowerInKw_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPowerInKW.Validating
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
    Private Sub txtHoursOfUsePerDay_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
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

    Private Sub lblTitle_Click(sender As System.Object, e As System.EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnExit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAnother_Click(sender As System.Object, e As System.EventArgs) Handles btnAnother.Click
        Me.txtCostPerKWHour.Text = ""
        Me.ApplianceBox.Text = ""
        Me.txtPowerInKW.Text = ""
        Me.txtHoursOfUsePerDay.Text = ""
        Me.txtCostOfOperation.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ApplianceBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ApplianceBox.SelectedIndexChanged
        Me.ApplianceBox.Text = ApplianceBox.SelectedItem.ToString()
    End Sub

    Private Sub btnCalcCostOfOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcCostOfOperation.Click

        If (Len(txtCostPerKWHour.Text) > 0) And (Len(ApplianceBox.Text) > 0) And (Len(txtPowerInKW.Text) > 0) And (Len(txtHoursOfUsePerDay.Text) > 0) Then

            Dim dblCost, dblPower, dblHours, dblCostOfOperation As Double

            dblCost = CDbl(txtCostPerKWHour.Text)
            dblPower = CDbl(txtPowerInKW.Text)
            dblHours = CDbl(txtHoursOfUsePerDay.Text)
            dblCostOfOperation = dblCost * dblPower * dblHours

            txtCostOfOperation.Text = dblCostOfOperation.ToString
        Else
            MsgBox("Complete all fields, and click Calculate Cost button again.")
        End If
    End Sub
End Class
