Imports System
Imports System.IO

Public Class frmMain

    ' Part of the idea for event handlers and validation was taken from the teacher's examples 
    ' in Validation Demo application
    ' The arraylist with structures taken from thenewboston tutorial 77

    Public Shared AListHomeApp As New ArrayList

    Public Shared isWasher As Boolean = False

    Public Const Washer As String = "Washer Machine"

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

        Dim dblTotal As Double

        objNHomeApp = objHA

        dblTotal = AListHomeApp.Count()

        If dblTotal > 0 Then

            Dim blnisThere As Boolean = False

            For intI As Integer = 0 To dblTotal - 1

                If AListHomeApp.Item(intI).HomeAppName = objNHomeApp.HomeAppName Then

                    'MsgBox(AListHomeApp.Item(intI).HomeAppName)

                    AListHomeApp.Item(intI) = objNHomeApp

                    blnisThere = True

                    Exit For

                End If

            Next

            If Not blnisThere Then

                AListHomeApp.Add(objNHomeApp)

            End If

        Else

            AListHomeApp.Add(objNHomeApp)

        End If

    End Sub

    Private Sub LoadHomeApp(ByVal homeApp As HomeAppliance)

    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ApplianceBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ApplianceBox.SelectedIndexChanged

        Me.ApplianceBox.Text = ApplianceBox.SelectedItem.ToString()

        Dim intIndex As Integer = ApplianceBox.SelectedIndex()

        Me.txtCostPerKWHour.Text = AListHomeApp.Item(intIndex).CostPerKWH.ToString
        Me.ApplianceBox.Text = AListHomeApp.Item(intIndex).HomeAppName
        Me.txtPowerInKW.Text = AListHomeApp.Item(intIndex).PowerNeeded.ToString
        Me.txtHoursOfUsePerDay.Text = AListHomeApp.Item(intIndex).HoursPerDay.ToString
        Me.txtGaUsedPerHour.Text = AListHomeApp.Item(intIndex).GaPerHour.ToString
        Me.txtCostPerGallon.Text = AListHomeApp.Item(intIndex).CostOfGallon.ToString
        Me.txtCostOfOperation.Text = AListHomeApp.Item(intIndex).CostOfOperation.ToString
        
        If Me.ApplianceBox.Text = Washer Then

            isWasher = True

            Me.txtGaUsedPerHour.Enabled = True

            Me.txtCostPerGallon.Enabled = True

        Else

            isWasher = False

            Me.txtGaUsedPerHour.Enabled = False

            Me.txtCostPerGallon.Enabled = False

        End If

    End Sub

    Private Sub txtCostPerKWHour_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCostPerKWHour.Validating

        Try

            ' It declares and converts the text entered to double
            Dim dblCostPerKWHour As Double = CDbl(txtCostPerKWHour.Text)

            ' It controls that the value entered is greater than to 0.0 and less than 6.0
            If dblCostPerKWHour > 0.0 And dblCostPerKWHour <= 6.0 Then

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
                Me.txtGaUsedPerHour.Text = "0.0"

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("Total gallons of water used per hour should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True
            Me.txtGaUsedPerHour.Text = "0.0"

        End Try

    End Sub

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
                Me.txtCostPerGallon.Text = "0.0"

            End If
        Catch ex As Exception

            ' It displays an error dialog with an error message due to incorrect input
            MsgBox("The cost of a gallon of water should be a decimal number.", MsgBoxStyle.Exclamation, "Error!")

            ' The value entered is not allowed and the event is set to be cancelled
            e.Cancel = True

            Me.txtCostPerGallon.Text = "0.0"

        End Try

    End Sub

    Private Sub btnReadDefaultValues_Click(sender As System.Object, e As System.EventArgs) Handles btnReadDefaultValues.Click

        Dim connexion As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim path As String = Directory.GetCurrentDirectory()
        Dim dbFile As String = "HomeAppliances.accdb"
        Dim dataSet As New DataSet
        Dim dataAdapter As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim haAux As HomeAppliance

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"

        dbSource = "Data Source = " & path & "\" & dbFile

        connexion.ConnectionString = dbProvider & dbSource

        connexion.Open()

        sql = "SELECT * FROM HAppliance"

        dataAdapter = New OleDb.OleDbDataAdapter(sql, connexion)

        dataAdapter.Fill(dataSet, "HAppliance")

        connexion.Close()

        AListHomeApp.Clear()

        For intI As Integer = 0 To 14

            haAux.CostPerKWH = dataSet.Tables("HAppliance").Rows(intI).Item(0)
            haAux.HomeAppName = dataSet.Tables("HAppliance").Rows(intI).Item(1)
            haAux.PowerNeeded = dataSet.Tables("HAppliance").Rows(intI).Item(2)
            haAux.HoursPerDay = dataSet.Tables("HAppliance").Rows(intI).Item(3)
            haAux.GaPerHour = dataSet.Tables("HAppliance").Rows(intI).Item(4)
            haAux.CostOfGallon = dataSet.Tables("HAppliance").Rows(intI).Item(5)
            haAux.CostOfOperation = dataSet.Tables("HAppliance").Rows(intI).Item(6)

            AListHomeApp.Add(haAux)

        Next

    End Sub

    Private Sub btnCalcCostOfOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcCostOfOperation.Click

        If (Len(txtCostPerKWHour.Text) > 0) And (Len(ApplianceBox.Text) > 0) And (Len(txtPowerInKW.Text) > 0) And (Len(txtHoursOfUsePerDay.Text) > 0) Then

            Dim dblCost, dblPower, dblHours, dblCostOfOperation As Double

            Dim dblGaPerHour, dblCostOfGallon As Double


            dblCost = CDbl(txtCostPerKWHour.Text)

            dblPower = CDbl(txtPowerInKW.Text)

            dblHours = CDbl(txtHoursOfUsePerDay.Text)

            dblCostOfOperation = dblCost * dblPower * dblHours

            If isWasher Then

                dblGaPerHour = CDbl(Me.txtGaUsedPerHour.Text)

                dblCostOfGallon = CDbl(Me.txtCostPerGallon.Text)

                dblCostOfOperation = (dblCost * dblPower * dblHours) + ((dblCostOfGallon * dblGaPerHour) * dblHours)

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


    Private Sub btnAnother_Click(sender As System.Object, e As System.EventArgs) Handles btnAnother.Click

        Me.txtCostPerKWHour.Text = ""
        Me.ApplianceBox.Text = ""
        Me.txtPowerInKW.Text = ""
        Me.txtHoursOfUsePerDay.Text = ""
        Me.txtCostOfOperation.Text = ""
        Me.txtGaUsedPerHour.Text = "0.0"
        Me.txtCostPerGallon.Text = "0.0"
        isWasher = False

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

    Private Sub btnSaveToFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveToFile.Click

        Dim connexion As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim path As String = Directory.GetCurrentDirectory()
        Dim dbFile As String = "HomeAppliances.accdb"
        Dim dataSet As New DataSet
        Dim dataAdapter As OleDb.OleDbDataAdapter
        Dim sql As String


        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"

        dbSource = "Data Source = " & path & "\" & dbFile

        connexion.ConnectionString = dbProvider & dbSource

        connexion.Open()

        sql = "SELECT * FROM HAppliance"

        dataAdapter = New OleDb.OleDbDataAdapter(sql, connexion)

        dataAdapter.SelectCommand = New OleDb.OleDbCommand(sql, connexion)

        Dim commMaker As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(dataAdapter)

        dataAdapter.Fill(dataSet, "HAppliance")

        For intI As Integer = 0 To 14

            dataSet.Tables("HAppliance").Rows(intI).Item(0) = AListHomeApp.Item(intI).CostPerKWH
            dataSet.Tables("HAppliance").Rows(intI).Item(1) = AListHomeApp.Item(intI).HomeAppName
            dataSet.Tables("HAppliance").Rows(intI).Item(2) = AListHomeApp.Item(intI).PowerNeeded
            dataSet.Tables("HAppliance").Rows(intI).Item(3) = AListHomeApp.Item(intI).HoursPerDay
            dataSet.Tables("HAppliance").Rows(intI).Item(4) = AListHomeApp.Item(intI).GaPerHour
            dataSet.Tables("HAppliance").Rows(intI).Item(5) = AListHomeApp.Item(intI).CostOfGallon
            dataSet.Tables("HAppliance").Rows(intI).Item(6) = AListHomeApp.Item(intI).CostOfOperation

        Next

        commMaker.GetUpdateCommand()

        dataAdapter.Update(dataSet, "HAppliance")

        connexion.Close()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
