Public Class Form1

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblAnswer.Text = "18 + 64 = 82 "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
