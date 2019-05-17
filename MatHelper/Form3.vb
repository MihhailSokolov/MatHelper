Public Class Form3
    Private Sub кл_сложения_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles кл_сложения.Click
        If IsNumeric(число1.Text) And IsNumeric(число2.Text) Then
            результат.Text = Val(число1.Text) + Val(число2.Text)
        Else
            MsgBox("Вы должны вводить только цифры.")
            Button1.PerformClick()
        End If
    End Sub
    Private Sub кл_вычитания_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles кл_вычитания.Click
        If IsNumeric(число1.Text) And IsNumeric(число2.Text) Then
            результат.Text = Val(число1.Text) - Val(число2.Text)
        Else
            MsgBox("Вы должны вводить только цифры.")
            Button1.PerformClick()
        End If
    End Sub
    Private Sub кл_умножения_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles кл_умножения.Click
        If IsNumeric(число1.Text) And IsNumeric(число2.Text) Then
            результат.Text = Val(число1.Text) * Val(число2.Text)
        Else
            MsgBox("Вы должны вводить только цифры.")
            Button1.PerformClick()
        End If
    End Sub
    Private Sub кл_деления_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles кл_деления.Click
        If IsNumeric(число1.Text) And IsNumeric(число2.Text) Then
            результат.Text = Val(число1.Text) / Val(число2.Text)
        Else
            MsgBox("Вы должны вводить только цифры.")
            Button1.PerformClick()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        число1.Text = ""
        число2.Text = ""
        результат.Text = ""
    End Sub
End Class