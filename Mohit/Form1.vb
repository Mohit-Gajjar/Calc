Public Class Form1
    Dim a, b As Double
    Dim op As Char
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        output.AppendText("5")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        output.AppendText(".")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        output.AppendText("3")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        output.AppendText("4")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        output.AppendText("6")
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button5.Click
        output.AppendText("1")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        output.AppendText("2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        output.AppendText("7")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        output.AppendText("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        output.AppendText("9")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        output.AppendText("0")
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        output.AppendText("+")
        a = Val(output.Text)
        op = "+"

    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        output.AppendText("-")
        a = Val(output.Text)
        op = "-"

    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        output.AppendText("*")
        a = Val(output.Text)
        op = "*"

    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        output.AppendText("/")
        a = Val(output.Text)
        op = "/"

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        output.AppendText("%")
        a = Val(output.Text)
        op = "%"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If (op = "+") Then
            output2.Text = a + output.Text
        ElseIf (op = "-") Then
            output2.Text = a - output.Text
        ElseIf (op = "*") Then
            output2.Text = a * output.Text
        ElseIf (op = "/") Then
            output2.Text = a / output.Text
        ElseIf (op = "%") Then
            output2.Text = a Mod output.Text
        ElseIf (op = "^") Then
            output2.Text = a ^ output.Text
        End If


    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles output2.TextChanged

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        output.Clear()
        output2.Clear()
    End Sub
End Class
