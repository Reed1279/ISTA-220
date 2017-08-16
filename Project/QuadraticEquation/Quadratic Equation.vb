Public Class Form1
    Private Sub buCompute_Click(sender As Object, e As EventArgs) Handles buCompute.Click
        Dim a As Single
        Dim b As Single
        Dim c As Single
        Dim x1 As Single
        Dim x2 As Single
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)
        x1 = (-b + Math.Sqrt(Math.Abs(b ^ 2 - 4 * a * c))) / (2 * a)
        x2 = (-b - Math.Sqrt(Math.Abs(b ^ 2 - 4 * a * c))) / (2 * a)
        lblr.Text = "The value of x is " & x1 & " or " & x2


    End Sub
End Class
