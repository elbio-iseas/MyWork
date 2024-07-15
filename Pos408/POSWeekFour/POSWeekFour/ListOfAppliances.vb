Public Class ListOfAppliances

    Private Sub ListOfAppliances_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim dblTotalCost As Double = 0

        For Each obj In frmMain.AListHomeApp

            DataGridView1.Rows.Add(obj.HomeAppName, obj.HoursPerDay, obj.CostOfOperation)

            dblTotalCost = dblTotalCost + obj.CostOfOperation

        Next

        DataGridView1.Rows.Add("Total Cost of Home Appliances", " ", dblTotalCost)

        DataGridView1.Show()

    End Sub

    Private Sub btnMainMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMainMenu.Click
        Close()
    End Sub

End Class