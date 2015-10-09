Public Class Form1
    Dim a As String
    Dim b As Integer
    
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        a = 2
        b = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        a = 1
        b = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Select Case Me.a
            Case 1
                TextBox1.Text = Convert.ToString(Me.b - Convert.ToString(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.b + Convert.ToString(TextBox1.Text))
        End Select

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = Nothing
    End Sub
End Class
