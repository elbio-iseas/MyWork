Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "English" Then
            Label2.ForeColor = Color.Indigo
            Label2.Text = "Hello"
        ElseIf ComboBox1.SelectedItem = "French" Then
            Label2.ForeColor = Color.Navy
            Label2.Text = "Salut à tous"
        ElseIf ComboBox1.SelectedItem = "German" Then
            Label2.ForeColor = Color.Orange
            Label2.Text = "Hallo!"
        ElseIf ComboBox1.SelectedItem = "Italian" Then
            Label2.ForeColor = Color.Green
            Label2.Text = "Ciao"
        ElseIf ComboBox1.SelectedItem = "Portuguese" Then
            Label2.ForeColor = Color.Yellow
            Label2.Text = "Oi lá"
        ElseIf ComboBox1.SelectedItem = "Russian" Then
            Label2.ForeColor = Color.Red
            Label2.Text = "Privet"
        ElseIf ComboBox1.SelectedItem = "Spanish" Then
            Label2.ForeColor = Color.Brown
            Label2.Text = "Hola"
        End If
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class