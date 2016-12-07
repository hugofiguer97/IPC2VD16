Public Class Form1

    Dim x, y, z As Double
    Dim result As Double
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        x = txtX.Text
        y = txtY.Text
        z = txtZ.Text

        result = x * y * z

        MsgBox("Resultado: " + result.ToString)

    End Sub
	
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        x = txtX.Text
        y = txtY.Text
        z = txtZ.Text

        result = y + (y * z) - x

        MsgBox("Resultado: " + result.ToString)
    End Sub

End Class
