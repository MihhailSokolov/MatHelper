Public Class Form4

    Sub clear(ByVal clear1 As Boolean, ByVal clear2 As Boolean)
        If clear1 Then
            TextBox1.Clear()
        ElseIf clear2 Then
            TextBox2.Clear()
        End If
    End Sub
    Private Sub Form4_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(Pens.Black, 20, 40, 30, 40)
        g.DrawLine(Pens.Black, 30, 40, 45, 70)
        g.DrawLine(Pens.Black, 45, 70, 60, 30)
        g.DrawLine(Pens.Black, 60, 30, 120, 30)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Or TextBox1.Text = " " Then
            Button1.Enabled = False
            clear(False, True)
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Decimal
        Dim root As String = TextBox1.Text
        If IsNumeric(root) Then
            result = Math.Sqrt(Val(root))
            TextBox2.Text = result
        Else
            MsgBox("Введите число, квадратный корень которого вы хотите найти.")
            clear(True, True)
            Exit Sub
        End If
    End Sub
End Class