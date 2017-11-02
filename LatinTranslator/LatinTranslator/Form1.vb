Public Class latinTraslator

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        MessageBox.Show("Left")
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        MessageBox.Show("Right")
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        MessageBox.Show("Center")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
