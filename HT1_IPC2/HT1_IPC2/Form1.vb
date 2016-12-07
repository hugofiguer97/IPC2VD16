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
	
	Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        x = txtX.Text
        y = txtY.Text
        z = txtZ.Text

        result = Math.Sqrt(x * y) + z

        MsgBox("Resultado: " + result.ToString)
    End Sub
	
	Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        x = txtX.Text
        y = txtY.Text
        z = txtZ.Text

        result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2))

        MsgBox("Resultado: " + result.ToString)
    End Sub

End Class
