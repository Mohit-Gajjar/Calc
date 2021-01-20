Public Class Form1
    Dim a, b, q As Double
    Dim opration As String
    Dim assign_inp As Double = 0
    Dim find_exp As Boolean = False
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button11.Click, Button10.Click, Button1.Click
        Dim x As Button = sender
        If ((output.Text = "0") Or (find_exp)) Then
            output.Clear()
            output.Text = x.Text
            find_exp = False
        ElseIf (x.Text = ".") Then
            If (Not output.Text.Contains(".")) Then
                output.Text = output.Text + x.Text
            End If
        Else
            output.Text = output.Text + x.Text
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        output.Text = "0"
        Label1.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button22.Click, Button21.Click, Button20.Click, Button19.Click
        Dim x As Button = sender
        If (assign_inp <> 0) Then
            Button25.PerformClick()
            find_exp = True
            opration = x.Text
            Label1.Text = assign_inp & "    " & opration
        Else
            opration = x.Text
            assign_inp = Double.Parse(output.Text)
            find_exp = True
            Label1.Text = assign_inp & "    " & opration
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Label1.Text = ""
        Select Case opration
            Case "+"
                output.Text = (assign_inp + Double.Parse(output.Text)).ToString
            Case "-"
                output.Text = (assign_inp - Double.Parse(output.Text)).ToString
            Case "*"
                output.Text = (assign_inp * Double.Parse(output.Text)).ToString
            Case "/"
                output.Text = (assign_inp / Double.Parse(output.Text)).ToString
                'Case "%"
                '    output.Text = (assign_inp Mod Double.Parse(output.Text)).ToString
                'Case "^"
                '    output.Text = (assign_inp ^ Double.Parse(output.Text)).ToString
        End Select
        assign_inp = Double.Parse(output.Text)
        opration = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim y As Double
        y = Convert.ToDouble(output.Text) / Convert.ToDouble(100)
        output.Text = System.Convert.ToString(y)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If (output.Text.Length > 0) Then
            output.Text = output.Text.Remove(output.Text.Length - 1, 1)
        End If
        If (output.Text = "") Then
            output.Text = "0"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub




End Class
