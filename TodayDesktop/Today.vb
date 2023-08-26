Public Class frmToday
    Private Sub btnPressMe_Click(sender As Object, e As EventArgs) Handles btnPressMe.Click
        txtToday.Text = "Today is ... " & DateTime.Now.DayOfWeek.ToString
    End Sub

    Private Sub btnPressMe_DoubleClick(sender As Object, e As EventArgs) Handles btnPressMe.DoubleClick

    End Sub

    Private Sub txtToday_Enter(sender As Object, e As EventArgs) Handles txtToday.Enter
        txtToday.Text = "Coffee Time"
    End Sub
End Class
