Public Class Form1
    Private W As Integer
    Private f As Integer
    Private arg As Char

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        f = f * 10
        TextBox1.Text = f

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        W = 0
        f = 0
        arg = "\0"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        f = f * 10 + 1
        TextBox1.Text = f

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        f = f * 10 + 2
        TextBox1.Text = f

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        f = f * 10 + 3
        TextBox1.Text = f

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        f = f * 10 + 4
        TextBox1.Text = f

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        f = f * 10 + 5
        TextBox1.Text = f

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        f = f * 10 + 6
        TextBox1.Text = f

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        f = f * 10 + 7
        TextBox1.Text = f

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        f = f * 10 + 8
        TextBox1.Text = f

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        f = f * 10 + 9
        TextBox1.Text = f

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        f += 1
        TextBox1.Text = f
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        f -= 1
        TextBox1.Text = f

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        f = 0
        TextBox1.Text = f
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        f = Not f
        TextBox1.Text = f
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        W = 0
        f = 0
        arg = "\0"
        TextBox1.Text = f

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        f = f << 1
        TextBox1.Text = f
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        f = f >> 1
        TextBox1.Text = f

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        W = f
        f = 0
        arg = "+"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        W = f
        f = 0
        arg = "-"

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Select Case arg
            Case "+"
                W = W + f
            Case "-"
                W = W - f
            Case "&"
                W = W And f
            Case "|"
                W = W Or f
            Case "^"
                W = W Xor f
            Case "\0"
                W = f
        End Select
        TextBox1.Text = W
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        W = f
        f = 0
        arg = "&"

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        W = f
        f = 0
        arg = "|"

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        W = f
        f = 0
        arg = "^"

    End Sub
End Class
