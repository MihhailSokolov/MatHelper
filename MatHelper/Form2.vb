Public Class Form2
    Dim num1, num2, result As Double
    Dim strNum1, strNum2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strNum1 = TextBox1.Text
        strNum2 = TextBox2.Text
        If IsNumeric(TextBox1.Text) = True And IsNumeric(TextBox2.Text) = True Then
            num1 = CDbl(TextBox1.Text)
            num2 = CDbl(TextBox2.Text)
            result = num1 ^ num2
            TextBox3.Text = result
        ElseIf IsNumeric(TextBox1.Text) And TextBox2.Text = "" Then
            MsgBox("Второе поле не заполнено")
        ElseIf TextBox1.Text = "" And IsNumeric(TextBox2.Text) Then
            MsgBox("Первое поле не заполнено")
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Оба поля не заполнены")
        ElseIf IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            If IsNumeric(TextBox1.Text) = False Then
                TextBox1.Text = ""
            End If
            If IsNumeric(TextBox2.Text) = False Then
                TextBox2.Text = ""
            End If
            MsgBox("Вы должны вводить только числа")
            If TextBox1.Text = "" And TextBox2.Text = "" Then TextBox3.Text = ""
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then TextBox3.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" And TextBox2.Text = "" Then TextBox3.Text = ""
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text = "" And TextBox2.Text = "" Then TextBox3.Text = ""
    End Sub
End Class