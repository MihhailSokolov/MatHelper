Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Length(16)
        Length(0) = "миллиметр"
        Length(1) = "сантиметр"
        Length(2) = "дециметр"
        Length(3) = "метр"
        Length(4) = "километр"
        Length(5) = "дюйм"
        Length(6) = "фут"
        Length(7) = "ярд"
        Length(8) = "миля"
        Length(9) = "морская миля"
        Length(10) = "лье"
        Length(11) = "аршин"
        Length(12) = "локоть"
        Length(13) = "сажень"
        Length(14) = "ладонь"
        Length(15) = "шаг"
        Length(16) = "пядь"
        Dim DecInput As Decimal
        Dim TxtInput As String = TextBox1.Text
        Dim DecResult As Decimal
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox2.Text
        Dim ConvertLengthFrom = ComboBox1.SelectedItem
        Dim ConvertLengthTo = ComboBox8.SelectedItem
        Try
            If IsNumeric(TxtInput) Then
                DecInput = CDec(TxtInput)
                Select Case ConvertLengthFrom
                    Case Length(0)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput / 1
                            Case Length(1)
                                DecResult = DecInput / 10
                            Case Length(2)
                                DecResult = DecInput / 100
                            Case Length(3)
                                DecResult = DecInput / 1000
                            Case Length(4)
                                DecResult = DecInput / 1000000
                            Case Length(5)
                                DecResult = DecInput * 0.03937
                            Case Length(6)
                                DecResult = DecInput / 304.8
                            Case Length(7)
                                DecResult = DecInput * 0.00109361
                            Case Length(8)
                                DecResult = DecInput * 0.00000062137
                            Case Length(9)
                                DecResult = DecInput * 0.00000053996
                            Case Length(10)
                                DecResult = DecInput * 0.00000020712
                            Case Length(11)
                                DecResult = DecInput / 711.2
                            Case Length(12)
                                DecResult = DecInput / 450
                            Case Length(13)
                                DecResult = DecInput / 2133.6
                            Case Length(14)
                                DecResult = DecInput / 101.6
                            Case Length(15)
                                DecResult = DecInput / 710
                            Case Length(16)
                                DecResult = DecInput / 177.8
                        End Select
                    Case Length(1)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 10
                            Case Length(1)
                                DecResult = DecInput * 1
                            Case Length(2)
                                DecResult = DecInput / 10
                            Case Length(3)
                                DecResult = DecInput / 100
                            Case Length(4)
                                DecResult = DecInput / 100000

                            Case Length(5)
                                DecResult = DecInput * 0.3937
                            Case Length(6)
                                DecResult = DecInput / 30.48
                            Case Length(7)
                                DecResult = DecInput * 0.0109361
                            Case Length(8)
                                DecResult = DecInput * 0.0000062137
                            Case Length(9)
                                DecResult = DecInput * 0.0000053996
                            Case Length(10)
                                DecResult = DecInput * 0.0000020712
                            Case Length(11)
                                DecResult = DecInput / 71.12
                            Case Length(12)
                                DecResult = DecInput / 45
                            Case Length(13)
                                DecResult = DecInput / 213.36
                            Case Length(14)
                                DecResult = DecInput / 10.16
                            Case Length(15)
                                DecResult = DecInput / 71
                            Case Length(16)
                                DecResult = DecInput / 17.78
                        End Select
                    Case Length(2)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 100
                            Case Length(1)
                                DecResult = DecInput * 10
                            Case Length(2)
                                DecResult = DecInput * 1
                            Case Length(3)
                                DecResult = DecInput / 10
                            Case Length(4)
                                DecResult = DecInput / 10000

                            Case Length(5)
                                DecResult = DecInput * 3.937
                            Case Length(6)
                                DecResult = DecInput / 3.048
                            Case Length(7)
                                DecResult = DecInput * 0.109361
                            Case Length(8)
                                DecResult = DecInput * 0.000062137
                            Case Length(9)
                                DecResult = DecInput * 0.000053996
                            Case Length(10)
                                DecResult = DecInput * 0.000020712
                            Case Length(11)
                                DecResult = DecInput / 7.112
                            Case Length(12)
                                DecResult = DecInput / 4.5
                            Case Length(13)
                                DecResult = DecInput / 21.336
                            Case Length(14)
                                DecResult = DecInput / 1.016
                            Case Length(15)
                                DecResult = DecInput / 7.1
                            Case Length(16)
                                DecResult = DecInput / 1.778
                        End Select
                    Case Length(3)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 1000
                            Case Length(1)
                                DecResult = DecInput * 100
                            Case Length(2)
                                DecResult = DecInput * 10
                            Case Length(3)
                                DecResult = DecInput * 1
                            Case Length(4)
                                DecResult = DecInput / 1000
                            Case Length(5)
                                DecResult = DecInput * 39.37
                            Case Length(6)
                                DecResult = DecInput / 0.3048
                            Case Length(7)
                                DecResult = DecInput * 1.09361
                            Case Length(8)
                                DecResult = DecInput * 0.00062137
                            Case Length(9)
                                DecResult = DecInput * 0.00053996
                            Case Length(10)
                                DecResult = DecInput * 0.00020712
                            Case Length(11)
                                DecResult = DecInput / 0.7112
                            Case Length(12)
                                DecResult = DecInput / 0.0045
                            Case Length(13)
                                DecResult = DecInput / 2.1336
                            Case Length(14)
                                DecResult = DecInput / 0.1016
                            Case Length(15)
                                DecResult = DecInput / 0.71
                            Case Length(16)
                                DecResult = DecInput / 0.1718
                        End Select
                    Case Length(4)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 1000000
                            Case Length(1)
                                DecResult = DecInput * 100000
                            Case Length(2)
                                DecResult = DecInput * 1000
                            Case Length(3)
                                DecResult = DecInput * 10
                            Case Length(4)
                                DecResult = DecInput * 1
                            Case Length(5)
                                DecResult = DecInput * 39370
                            Case Length(6)
                                DecResult = DecInput / 0.0003048
                            Case Length(7)
                                DecResult = DecInput * 1093.6133
                            Case Length(8)
                                DecResult = DecInput * 0.62137
                            Case Length(9)
                                DecResult = DecInput * 0.53996
                            Case Length(10)
                                DecResult = DecInput * 0.20712
                            Case Length(11)
                                DecResult = DecInput / 0.0007112
                            Case Length(12)
                                DecResult = DecInput / 0.00045
                            Case Length(13)
                                DecResult = DecInput / 0.0021336
                            Case Length(14)
                                DecResult = DecInput / 0.0001016
                            Case Length(15)
                                DecResult = DecInput / 0.00071
                            Case Length(16)
                                DecResult = DecInput / 0.0001718
                        End Select
                    Case Length(5)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput / 0.03937
                            Case Length(1)
                                DecResult = DecInput / 0.3937
                            Case Length(2)
                                DecResult = DecInput / 3.937
                            Case Length(3)
                                DecResult = DecInput / 39.37
                            Case Length(4)
                                DecResult = DecInput / 39370
                            Case Length(5)
                                DecResult = DecInput * 1
                            Case Length(6)
                                DecResult = (DecInput / 0.3937) / 30.48
                            Case Length(7)
                                DecResult = (DecInput / 0.3937) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput / 0.3937) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput / 0.3937) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput / 0.3937) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput / 0.3937) / 71.12
                            Case Length(12)
                                DecResult = (DecInput / 0.3937) / 45
                            Case Length(13)
                                DecResult = (DecInput / 0.3937) / 213.36
                            Case Length(14)
                                DecResult = (DecInput / 0.3937) / 10.16
                            Case Length(15)
                                DecResult = (DecInput / 0.3937) / 71
                            Case Length(16)
                                DecResult = (DecInput / 0.3937) / 17.78
                        End Select
                    Case Length(6)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 304.8
                            Case Length(1)
                                DecResult = DecInput * 30.48
                            Case Length(2)
                                DecResult = DecInput * 3.048
                            Case Length(3)
                                DecResult = DecInput * 0.3048
                            Case Length(4)
                                DecResult = DecInput * 0.0003048
                            Case Length(5)
                                DecResult = (DecInput * 30.48) * 0.3937
                            Case Length(6)
                                DecResult = DecInput * 1
                            Case Length(7)
                                DecResult = (DecInput * 30.48) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 30.48) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 30.48) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 30.48) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput * 30.48) / 71.12
                            Case Length(12)
                                DecResult = (DecInput * 30.48) / 45
                            Case Length(13)
                                DecResult = (DecInput * 30.48) / 213.36
                            Case Length(14)
                                DecResult = (DecInput * 30.48) / 10.16
                            Case Length(15)
                                DecResult = (DecInput * 30.48) / 71
                            Case Length(16)
                                DecResult = (DecInput * 30.48) / 17.78
                        End Select
                    Case Length(7)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput / 0.00109361
                            Case Length(1)
                                DecResult = DecInput / 0.0109361
                            Case Length(2)
                                DecResult = DecInput / 0.109361
                            Case Length(3)
                                DecResult = DecInput / 1.09361
                            Case Length(4)
                                DecResult = DecInput / 1093.6133
                            Case Length(5)
                                DecResult = (DecInput / 0.0109361) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput / 0.0109361) / 30.48
                            Case Length(7)
                                DecResult = DecInput * 1
                            Case Length(8)
                                DecResult = (DecInput / 0.0109361) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput / 0.0109361) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput / 0.0109361) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput / 0.0109361) / 71.12
                            Case Length(12)
                                DecResult = (DecInput / 0.0109361) / 45
                            Case Length(13)
                                DecResult = (DecInput / 0.0109361) / 213.36
                            Case Length(14)
                                DecResult = (DecInput / 0.0109361) / 10.16
                            Case Length(15)
                                DecResult = (DecInput / 0.0109361) / 71
                            Case Length(16)
                                DecResult = (DecInput / 0.0109361) / 17.78
                        End Select
                    Case Length(8)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput / 0.00000062137
                            Case Length(1)
                                DecResult = DecInput / 0.0000062137
                            Case Length(2)
                                DecResult = DecInput / 0.000062137
                            Case Length(3)
                                DecResult = DecInput / 0.00062137
                            Case Length(4)
                                DecResult = DecInput / 0.62137
                            Case Length(5)
                                DecResult = (DecInput / 0.0000062137) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput / 0.0000062137) / 30.48
                            Case Length(7)
                                DecResult = (DecInput / 0.0000062137) * 0.0109361
                            Case Length(8)
                                DecResult = DecInput * 1
                            Case Length(9)
                                DecResult = (DecInput / 0.0000062137) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput / 0.0000062137) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput / 0.0000062137) / 71.12
                            Case Length(12)
                                DecResult = (DecInput / 0.0000062137) / 45
                            Case Length(13)
                                DecResult = (DecInput / 0.0000062137) / 213.36
                            Case Length(14)
                                DecResult = (DecInput / 0.0000062137) / 10.16
                            Case Length(15)
                                DecResult = (DecInput / 0.0000062137) / 71
                            Case Length(16)
                                DecResult = (DecInput / 0.0000062137) / 17.78
                        End Select
                    Case Length(9)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput / 0.00000053996
                            Case Length(1)
                                DecResult = DecInput / 0.0000053996
                            Case Length(2)
                                DecResult = DecInput / 0.000053996
                            Case Length(3)
                                DecResult = DecInput / 0.00053996
                            Case Length(4)
                                DecResult = DecInput / 0.53996
                            Case Length(5)
                                DecResult = (DecInput / 0.0000053996) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput / 0.0000053996) / 30.48
                            Case Length(7)
                                DecResult = (DecInput / 0.0000053996) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput / 0.0000053996) * 0.0000062137
                            Case Length(9)
                                DecResult = DecInput * 1
                            Case Length(10)
                                DecResult = (DecInput / 0.0000053996) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput / 0.0000053996) / 71.12
                            Case Length(12)
                                DecResult = (DecInput / 0.0000053996) / 45
                            Case Length(13)
                                DecResult = (DecInput / 0.0000053996) / 213.36
                            Case Length(14)
                                DecResult = (DecInput / 0.0000053996) / 10.16
                            Case Length(15)
                                DecResult = (DecInput / 0.0000053996) / 71
                            Case Length(16)
                                DecResult = (DecInput / 0.0000053996) / 17.78
                        End Select
                    Case Length(10)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput / 0.00000020712
                            Case Length(1)
                                DecResult = DecInput / 0.0000020712
                            Case Length(2)
                                DecResult = DecInput / 0.000020712
                            Case Length(3)
                                DecResult = DecInput / 0.00020712
                            Case Length(4)
                                DecResult = DecInput / 0.20712
                            Case Length(5)
                                DecInput = (DecInput / 0.0000020712) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput / 0.0000020712) / 30.48
                            Case Length(7)
                                DecResult = (DecInput / 0.0000020712) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput / 0.0000020712) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput / 0.0000020712) * 0.0000053996
                            Case Length(10)
                                DecResult = DecInput * 1
                            Case Length(11)
                                DecResult = (DecInput / 0.0000020712) / 71.12
                            Case Length(12)
                                DecResult = (DecInput / 0.0000020712) / 45
                            Case Length(13)
                                DecResult = (DecInput / 0.0000020712) / 213.36
                            Case Length(14)
                                DecResult = (DecInput / 0.0000020712) / 10.16
                            Case Length(15)
                                DecResult = (DecInput / 0.0000020712) / 71
                            Case Length(16)
                                DecResult = (DecInput / 0.0000020712) / 17.78
                        End Select
                    Case Length(11)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 711.2
                            Case Length(1)
                                DecResult = DecInput * 71.12
                            Case Length(2)
                                DecResult = DecInput * 7.112
                            Case Length(3)
                                DecResult = DecInput * 0.7112
                            Case Length(4)
                                DecResult = DecInput * 0.0007112
                            Case Length(5)
                                DecResult = (DecInput * 71.12) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput * 71.12) / 30.48
                            Case Length(7)
                                DecResult = (DecInput * 71.12) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 71.12) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 71.12) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 71.12) * 0.0000020712
                            Case Length(11)
                                DecResult = DecInput * 1
                            Case Length(12)
                                DecResult = (DecInput * 71.12) / 45
                            Case Length(13)
                                DecResult = (DecInput * 71.12) / 213.36
                            Case Length(14)
                                DecResult = (DecInput * 71.12) / 10.16
                            Case Length(15)
                                DecResult = (DecInput * 71.12) / 71
                            Case Length(16)
                                DecResult = (DecInput * 71.12) / 17.78
                        End Select
                    Case Length(12)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 450
                            Case Length(1)
                                DecResult = DecInput * 45
                            Case Length(2)
                                DecResult = DecInput * 4.5
                            Case Length(3)
                                DecResult = DecInput * 0.0045
                            Case Length(4)
                                DecResult = DecInput * 0.00045
                            Case Length(5)
                                DecResult = (DecInput * 45) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput * 45) / 30.48
                            Case Length(7)
                                DecResult = (DecInput * 45) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 45) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 45) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 45) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput * 45) / 71.12
                            Case Length(12)
                                DecResult = DecInput * 1
                            Case Length(13)
                                DecResult = (DecInput * 45) / 213.36
                            Case Length(14)
                                DecResult = (DecInput * 45) / 10.16
                            Case Length(15)
                                DecResult = (DecInput * 45) / 71
                            Case Length(16)
                                DecResult = (DecInput * 45) / 17.78
                        End Select
                    Case Length(13)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 2133.6
                            Case Length(1)
                                DecResult = DecInput * 213.36
                            Case Length(2)
                                DecResult = DecInput * 21.336
                            Case Length(3)
                                DecResult = DecInput * 2.1336
                            Case Length(4)
                                DecResult = DecInput * 0.0021336
                            Case Length(5)
                                DecResult = (DecInput * 213.36) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput * 213.36) / 30.48
                            Case Length(7)
                                DecResult = (DecInput * 213.36) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 213.36) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 213.36) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 213.36) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput * 213.36) / 71.12
                            Case Length(12)
                                DecResult = (DecInput * 213.36) / 45
                            Case Length(13)
                                DecResult = DecInput * 1
                            Case Length(14)
                                DecResult = (DecInput * 213.36) / 10.16
                            Case Length(15)
                                DecResult = (DecInput * 213.36) / 71
                            Case Length(16)
                                DecResult = (DecInput * 213.36) / 17.78
                        End Select
                    Case Length(14)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 101.6
                            Case Length(1)
                                DecResult = DecInput * 10.16
                            Case Length(2)
                                DecResult = DecInput * 1.016
                            Case Length(3)
                                DecResult = DecInput * 0.1016
                            Case Length(4)
                                DecResult = DecInput * 0.0001016
                            Case Length(5)
                                DecResult = (DecInput * 10.16) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput * 10.16) / 30.48
                            Case Length(7)
                                DecResult = (DecInput * 10.16) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 10.16) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 10.16) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 10.16) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput * 10.16) / 71.12
                            Case Length(12)
                                DecResult = (DecInput * 10.16) / 45
                            Case Length(13)
                                DecResult = (DecInput * 10.16) / 213.36
                            Case Length(14)
                                DecResult = DecInput * 1
                            Case Length(15)
                                DecResult = (DecInput * 10.16) / 71
                            Case Length(16)
                                DecResult = (DecInput * 10.16) / 17.78
                        End Select
                    Case Length(15)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 710
                            Case Length(1)
                                DecResult = DecInput * 71
                            Case Length(2)
                                DecResult = DecInput * 7.1
                            Case Length(3)
                                DecResult = DecInput * 0.71
                            Case Length(4)
                                DecResult = DecInput * 0.00071
                            Case Length(5)
                                DecResult = (DecInput * 71) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput * 71) / 30.48
                            Case Length(7)
                                DecResult = (DecInput * 71) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 71) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 71) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 71) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput * 71) / 71.12
                            Case Length(12)
                                DecResult = (DecInput * 71) / 45
                            Case Length(13)
                                DecResult = (DecInput * 71) / 213.36
                            Case Length(14)
                                DecResult = (DecInput * 71) / 10.16
                            Case Length(15)
                                DecResult = DecInput * 1
                            Case Length(16)
                                DecResult = (DecInput * 71) / 17.78
                        End Select
                    Case Length(16)
                        Select Case ConvertLengthTo
                            Case Length(0)
                                DecResult = DecInput * 177.8
                            Case Length(1)
                                DecResult = DecInput * 17.78
                            Case Length(2)
                                DecResult = DecInput * 1.778
                            Case Length(3)
                                DecResult = DecInput * 0.1778
                            Case Length(4)
                                DecResult = DecInput * 0.0001718
                            Case Length(5)
                                DecResult = (DecInput * 17.78) * 0.3937
                            Case Length(6)
                                DecResult = (DecInput * 17.78) / 30.48
                            Case Length(7)
                                DecResult = (DecInput * 17.78) * 0.0109361
                            Case Length(8)
                                DecResult = (DecInput * 17.78) * 0.0000062137
                            Case Length(9)
                                DecResult = (DecInput * 17.78) * 0.0000053996
                            Case Length(10)
                                DecResult = (DecInput * 17.78) * 0.0000020712
                            Case Length(11)
                                DecResult = (DecInput * 17.78) / 71.12
                            Case Length(12)
                                DecResult = (DecInput * 17.78) / 45
                            Case Length(13)
                                DecResult = (DecInput * 17.78) / 213.36
                            Case Length(14)
                                DecResult = (DecInput * 17.78) / 10.16
                            Case Length(15)
                                DecResult = (DecInput * 17.78) / 71
                            Case Length(16)
                                DecResult = DecInput * 1
                        End Select
                End Select
                ConvertionResult = CStr(DecResult)
                TextBox2.Text = ConvertionResult
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка. Возможно, вы ввели слишком большое число.")
            Exit Sub
        End Try
        If TextBox1.Text = "" Then TextBox2.Text = ""
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim Volume(12)
        Volume(0) = "кубический миллиметр"
        Volume(1) = "кубический сантиметр"
        Volume(2) = "кубический дециметр"
        Volume(3) = "кубический метр"
        Volume(4) = "кубический километр"
        Volume(5) = "литр"
        Volume(6) = "баррель"
        Volume(7) = "жидкая унция"
        Volume(8) = "пинта"
        Volume(9) = "галлон"
        Volume(10) = "кубический фут"
        Volume(11) = "кубический дюйм"
        Volume(12) = "кубический ярд"
        Dim DecInput As Double
        Dim TxtInput As String = TextBox4.Text
        Dim DecResult As Double
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox3.Text
        Dim ConvertVolumeFrom = ComboBox3.SelectedItem
        Dim ConvertVolumeTo = ComboBox2.SelectedItem
        Try
            If IsNumeric(TxtInput) Then
                DecInput = CDec(TxtInput)
                Select Case ConvertVolumeFrom
                    Case Volume(0)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 1
                            Case Volume(1)
                                DecResult = DecInput / 1000
                            Case Volume(2)
                                DecResult = DecInput / 1000000
                            Case Volume(3)
                                DecResult = DecInput / 1000000000
                            Case Volume(4)
                                DecResult = DecInput / 1.0E+18
                            Case Volume(5)
                                DecResult = DecInput / 1000000
                            Case Volume(6)
                                DecResult = DecInput / 163639338.897071
                            Case Volume(7)
                                DecResult = DecInput / 28409.0909090909
                            Case Volume(8)
                                DecResult = DecInput / 568181.818181818
                            Case Volume(9)
                                DecResult = DecInput / 4545454.54545454
                            Case Volume(10)
                                DecResult = DecInput / 28320589.0682526
                            Case Volume(11)
                                DecResult = DecInput / 16388.0694854146
                            Case Volume(12)
                                DecResult = DecInput / 764525993.883792
                        End Select
                    Case Volume(1)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 1000
                            Case Volume(1)
                                DecResult = DecInput * 1
                            Case Volume(2)
                                DecResult = DecInput / 1000
                            Case Volume(3)
                                DecResult = DecInput / 1000000
                            Case Volume(4)
                                DecResult = DecInput / 1000000000000000
                            Case Volume(5)
                                DecResult = DecInput / 1000
                            Case Volume(6)
                                DecResult = DecInput / 163639.33889707091
                            Case Volume(7)
                                DecResult = DecInput / 28.4090909090909
                            Case Volume(8)
                                DecResult = DecInput / 568.181818181818
                            Case Volume(9)
                                DecResult = DecInput / 4545.45454545455
                            Case Volume(10)
                                DecResult = DecInput / 28320.5890682526
                            Case Volume(11)
                                DecResult = DecInput / 16.3880694854146
                            Case Volume(12)
                                DecResult = DecInput / 764525.993883792
                        End Select
                    Case Volume(2)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 1000000
                            Case Volume(1)
                                DecResult = DecInput * 1000
                            Case Volume(2)
                                DecResult = DecInput / 1
                            Case Volume(3)
                                DecResult = DecInput / 1000
                            Case Volume(4)
                                DecResult = DecInput / 1000000000000
                            Case Volume(5)
                                DecResult = DecInput / 1
                            Case Volume(6)
                                DecResult = DecInput / 163.639338897071
                            Case Volume(7)
                                DecResult = DecInput / 0.0284090909090909
                            Case Volume(8)
                                DecResult = DecInput / 0.568181818181818
                            Case Volume(9)
                                DecResult = DecInput / 4.54545454545455
                            Case Volume(10)
                                DecResult = DecInput / 28.3205890682526
                            Case Volume(11)
                                DecResult = DecInput / 0.0163880694854146
                            Case Volume(12)
                                DecResult = DecInput / 764.525993883792
                        End Select
                    Case Volume(3)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 1000000000
                            Case Volume(1)
                                DecResult = DecInput * 1000000
                            Case Volume(2)
                                DecResult = DecInput * 1000
                            Case Volume(3)
                                DecResult = DecInput / 1
                            Case Volume(4)
                                DecResult = DecInput / 1000000000
                            Case Volume(5)
                                DecResult = DecInput / 0.001
                            Case Volume(6)
                                DecResult = DecInput / 0.163639338897071
                            Case Volume(7)
                                DecResult = DecInput / 0.0000284090909090909
                            Case Volume(8)
                                DecResult = DecInput / 0.000568181818181818
                            Case Volume(9)
                                DecResult = DecInput / 0.00454545454545455
                            Case Volume(10)
                                DecResult = DecInput / 0.0283205890682526
                            Case Volume(11)
                                DecResult = DecInput / 0.0000163880694854146
                            Case Volume(12)
                                DecResult = DecInput / 0.764525993883792
                        End Select
                    Case Volume(4)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 1.0E+18
                            Case Volume(1)
                                DecResult = DecInput * 1000000000000000
                            Case Volume(2)
                                DecResult = DecInput * 1000000000000
                            Case Volume(3)
                                DecResult = DecInput * 1000000000
                            Case Volume(4)
                                DecResult = DecInput * 1
                            Case Volume(5)
                                DecResult = DecInput / 0.000000000001
                            Case Volume(6)
                                DecResult = DecInput / 0.000000000163639338897071
                            Case Volume(7)
                                DecResult = DecInput / 0.0000000000000284090909090909
                            Case Volume(8)
                                DecResult = DecInput / 0.000000000000568181818181818
                            Case Volume(9)
                                DecResult = DecInput / 0.00000000000454545454545455
                            Case Volume(10)
                                DecResult = DecInput / 0.0000000000283205890682526
                            Case Volume(11)
                                DecResult = DecInput / 0.0000000000000163880694854146
                            Case Volume(12)
                                DecResult = DecInput / 0.000000000764525993883792
                        End Select
                    Case Volume(5)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 1000000
                            Case Volume(1)
                                DecResult = DecInput * 1000
                            Case Volume(2)
                                DecResult = DecInput * 1
                            Case Volume(3)
                                DecResult = DecInput / 1000
                            Case Volume(4)
                                DecResult = DecInput / 1000000000000
                            Case Volume(5)
                                DecResult = DecInput * 1
                            Case Volume(6)
                                DecResult = DecInput / 163.639338897071
                            Case Volume(7)
                                DecResult = DecInput / 0.0284090909090909
                            Case Volume(8)
                                DecResult = DecInput / 0.568181818181818
                            Case Volume(9)
                                DecResult = DecInput / 4.54545454545455
                            Case Volume(10)
                                DecResult = DecInput / 28.3205890682526
                            Case Volume(11)
                                DecResult = DecInput / 0.0163880694854146
                            Case Volume(12)
                                DecResult = DecInput / 764.525993883792
                        End Select
                    Case Volume(6)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 163600000
                            Case Volume(1)
                                DecResult = DecInput * 163600
                            Case Volume(2)
                                DecResult = DecInput * 163.6
                            Case Volume(3)
                                DecResult = DecInput / 6.11246943765281
                            Case Volume(4)
                                DecResult = DecInput / 6112469437.65281
                            Case Volume(5)
                                DecResult = DecInput * 163.6
                            Case Volume(6)
                                DecResult = DecInput * 1
                            Case Volume(7)
                                DecResult = DecInput * 5760
                            Case Volume(8)
                                DecResult = DecInput * 288
                            Case Volume(9)
                                DecResult = DecInput * 36
                            Case Volume(10)
                                DecResult = DecInput * 5.779
                            Case Volume(11)
                                DecResult = DecInput * 9987
                            Case Volume(12)
                                DecResult = DecInput / 4.67289719626168
                        End Select
                    Case Volume(7)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 28410
                            Case Volume(1)
                                DecResult = DecInput * 28.41
                            Case Volume(2)
                                DecResult = DecInput / 35.1988736360436
                            Case Volume(3)
                                DecResult = DecInput / 35198.8736360436
                            Case Volume(4)
                                DecResult = DecInput / 35198873636043.6
                            Case Volume(5)
                                DecResult = DecInput * 35.1988736360436
                            Case Volume(6)
                                DecResult = DecInput / 5760.36866359447
                            Case Volume(7)
                                DecResult = DecInput * 1
                            Case Volume(8)
                                DecResult = DecInput / 20
                            Case Volume(9)
                                DecResult = DecInput / 160
                            Case Volume(10)
                                DecResult = DecInput / 997.008973080758
                            Case Volume(11)
                                DecResult = DecInput / 0.576701268742791
                            Case Volume(12)
                                DecResult = DecInput / 26910.6566200215
                        End Select
                    Case Volume(8)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 568300
                            Case Volume(1)
                                DecResult = DecInput * 568.3
                            Case Volume(2)
                                DecResult = DecInput / 1.75963399612881
                            Case Volume(3)
                                DecResult = DecInput / 1759.63399612881
                            Case Volume(4)
                                DecResult = DecInput / 1759633996128.81
                            Case Volume(5)
                                DecResult = DecInput / 1.75963399612881
                            Case Volume(6)
                                DecResult = DecInput / 288.018433179724
                            Case Volume(7)
                                DecResult = DecInput * 20
                            Case Volume(8)
                                DecResult = DecInput * 1
                            Case Volume(9)
                                DecResult = DecInput * 8
                            Case Volume(10)
                                DecResult = DecInput / 49.825610363727
                            Case Volume(11)
                                DecResult = DecInput * 34.68
                            Case Volume(12)
                                DecResult = DecInput / 1345.35180949818
                        End Select
                    Case Volume(9)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 4546000
                            Case Volume(1)
                                DecResult = DecInput * 4546
                            Case Volume(2)
                                DecResult = DecInput * 4.546
                            Case Volume(3)
                                DecResult = DecInput / 219.97360316762
                            Case Volume(4)
                                DecResult = DecInput / 219973603167.62
                            Case Volume(5)
                                DecResult = DecInput * 4.546
                            Case Volume(6)
                                DecResult = DecInput / 35.9971202303816
                            Case Volume(7)
                                DecResult = DecInput * 160
                            Case Volume(8)
                                DecResult = DecInput * 8
                            Case Volume(9)
                                DecResult = DecInput * 1
                            Case Volume(10)
                                DecResult = DecInput / 6.23052959501558
                            Case Volume(11)
                                DecResult = DecInput * 277.4
                            Case Volume(12)
                                DecResult = DecInput / 168.180289270098
                        End Select
                    Case Volume(10)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 28320000
                            Case Volume(1)
                                DecResult = DecInput * 28320
                            Case Volume(2)
                                DecResult = DecInput * 28.32
                            Case Volume(3)
                                DecResult = DecInput / 35.3107344632768
                            Case Volume(4)
                                DecResult = DecInput / 35310734463.2768
                            Case Volume(5)
                                DecResult = DecInput * 28.32
                            Case Volume(6)
                                DecResult = DecInput / 5.78034682080925
                            Case Volume(7)
                                DecResult = DecInput * 996.6
                            Case Volume(8)
                                DecResult = DecInput * 49.83
                            Case Volume(9)
                                DecResult = DecInput * 6.229
                            Case Volume(10)
                                DecResult = DecInput * 1
                            Case Volume(11)
                                DecResult = DecInput * 1728
                            Case Volume(12)
                                DecResult = DecInput / 26.9978401727862
                        End Select
                    Case Volume(11)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 16390
                            Case Volume(1)
                                DecResult = DecInput * 16.39
                            Case Volume(2)
                                DecResult = DecInput / 61.012812690665
                            Case Volume(3)
                                DecResult = DecInput / 61012.812690665
                            Case Volume(4)
                                DecResult = DecInput / 61012812690665
                            Case Volume(5)
                                DecResult = DecInput / 61.012812690665
                            Case Volume(6)
                                DecResult = DecInput / 9990.00999000999
                            Case Volume(7)
                                DecResult = DecInput / 1.73400381480839
                            Case Volume(8)
                                DecResult = DecInput / 34.6740638002774
                            Case Volume(9)
                                DecResult = DecInput / 277.392510402219
                            Case Volume(10)
                                DecResult = DecInput / 1728.01105927078
                            Case Volume(11)
                                DecResult = DecInput * 1
                            Case Volume(12)
                                DecResult = DecInput / 46663.5557629491
                        End Select
                    Case Volume(12)
                        Select Case ConvertVolumeTo
                            Case Volume(0)
                                DecResult = DecInput * 764600000
                            Case Volume(1)
                                DecResult = DecInput * 764600
                            Case Volume(2)
                                DecResult = DecInput * 764.6
                            Case Volume(3)
                                DecResult = DecInput / 1.30787339785509
                            Case Volume(4)
                                DecResult = DecInput / 1307873397.85509
                            Case Volume(5)
                                DecResult = DecInput * 764.6
                            Case Volume(6)
                                DecResult = DecInput * 4.672
                            Case Volume(7)
                                DecResult = DecInput * 26910
                            Case Volume(8)
                                DecResult = DecInput * 1345
                            Case Volume(9)
                                DecResult = DecInput * 168.2
                            Case Volume(10)
                                DecResult = DecInput * 27
                            Case Volume(11)
                                DecResult = DecInput * 46660
                            Case Volume(12)
                                DecResult = DecInput * 1
                        End Select
                End Select
                ConvertionResult = CStr(DecResult)
                TextBox3.Text = ConvertionResult
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка. Возможно, вы ввели слишком большое число.")
            Exit Sub
        End Try
        
        If TextBox4.Text = "" Then TextBox3.Text = ""
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim Weight(8)
        Weight(0) = "миллиграмм"
        Weight(1) = "грамм"
        Weight(2) = "килограмм"
        Weight(3) = "центнер"
        Weight(4) = "тоннa"
        Weight(5) = "килотонна"
        Weight(6) = "карат"
        Weight(7) = "фунт"
        Weight(8) = "унция"
        Dim DecInput As Double
        Dim TxtInput As String = TextBox6.Text
        Dim DecResult As Double
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox5.Text
        Dim ConvertWeightFrom = ComboBox4.SelectedItem
        Dim ConvertWeightTo = ComboBox9.SelectedItem
        Try
            If IsNumeric(TxtInput) Then
                DecInput = CDec(TxtInput)
                Select Case ConvertWeightFrom
                    Case Weight(0)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 1
                            Case Weight(1)
                                DecResult = DecInput / 1000
                            Case Weight(2)
                                DecResult = DecInput / 1000000
                            Case Weight(3)
                                DecResult = DecInput / 100000000
                            Case Weight(4)
                                DecResult = DecInput / 1000000000
                            Case Weight(5)
                                DecResult = DecInput / 1000000000000
                            Case Weight(6)
                                DecResult = DecInput / 200
                            Case Weight(7)
                                DecResult = DecInput / 453514.739229025
                            Case Weight(8)
                                DecResult = DecInput / 28352.7076835838
                        End Select
                    Case Weight(1)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 1000
                            Case Weight(1)
                                DecResult = DecInput * 1
                            Case Weight(2)
                                DecResult = DecInput / 1000
                            Case Weight(3)
                                DecResult = DecInput / 100000
                            Case Weight(4)
                                DecResult = DecInput / 1000000
                            Case Weight(5)
                                DecResult = DecInput / 1000000000
                            Case Weight(6)
                                DecResult = DecInput * 5
                            Case Weight(7)
                                DecResult = DecInput / 453.514739229025
                            Case Weight(8)
                                DecResult = DecInput / 28.3527076835838
                        End Select
                    Case Weight(2)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 1000000
                            Case Weight(1)
                                DecResult = DecInput * 1000
                            Case Weight(2)
                                DecResult = DecInput * 1
                            Case Weight(3)
                                DecResult = DecInput / 100
                            Case Weight(4)
                                DecResult = DecInput / 1000
                            Case Weight(5)
                                DecResult = DecInput / 1000000
                            Case Weight(6)
                                DecResult = DecInput * 5000
                            Case Weight(7)
                                DecResult = DecInput * 2.205
                            Case Weight(8)
                                DecResult = DecInput * 35.27
                        End Select
                    Case Weight(3)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 100000000
                            Case Weight(1)
                                DecResult = DecInput * 100000
                            Case Weight(2)
                                DecResult = DecInput * 100
                            Case Weight(3)
                                DecResult = DecInput * 1
                            Case Weight(4)
                                DecResult = DecInput / 10
                            Case Weight(5)
                                DecResult = DecInput / 10000
                            Case Weight(6)
                                DecResult = DecInput * 500000
                            Case Weight(7)
                                DecResult = DecInput * 220.5
                            Case Weight(8)
                                DecResult = DecInput * 3527
                        End Select
                    Case Weight(4)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 1000000000
                            Case Weight(1)
                                DecResult = DecInput * 1000000
                            Case Weight(2)
                                DecResult = DecInput * 1000
                            Case Weight(3)
                                DecResult = DecInput * 10
                            Case Weight(4)
                                DecResult = DecInput * 1
                            Case Weight(5)
                                DecResult = DecInput / 1000
                            Case Weight(6)
                                DecResult = DecInput * 5000000
                            Case Weight(7)
                                DecResult = DecInput * 2205
                            Case Weight(8)
                                DecResult = DecInput * 35270
                        End Select
                    Case Weight(5)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 1000000000000
                            Case Weight(1)
                                DecResult = DecInput * 1000000000
                            Case Weight(2)
                                DecResult = DecInput * 1000000
                            Case Weight(3)
                                DecResult = DecInput * 10000
                            Case Weight(4)
                                DecResult = DecInput * 1000
                            Case Weight(5)
                                DecResult = DecInput * 1
                            Case Weight(6)
                                DecResult = DecInput * 5000000000
                            Case Weight(7)
                                DecResult = DecInput * 2205000
                            Case Weight(8)
                                DecResult = DecInput * 35270000
                        End Select
                    Case Weight(6)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 200
                            Case Weight(1)
                                DecResult = DecInput / 5
                            Case Weight(2)
                                DecResult = DecInput / 5000
                            Case Weight(3)
                                DecResult = DecInput / 500000
                            Case Weight(4)
                                DecResult = DecInput / 5000000
                            Case Weight(5)
                                DecResult = DecInput / 5000000000
                            Case Weight(6)
                                DecResult = DecInput * 1
                            Case Weight(7)
                                DecResult = DecInput / 2268.08800181447
                            Case Weight(8)
                                DecResult = DecInput / 141.743444365698
                        End Select
                    Case Weight(7)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 453600
                            Case Weight(1)
                                DecResult = DecInput * 453.6
                            Case Weight(2)
                                DecResult = DecInput / 2.20458553791887
                            Case Weight(3)
                                DecResult = DecInput / 220.458553791887
                            Case Weight(4)
                                DecResult = DecInput / 2204.58553791887
                            Case Weight(5)
                                DecResult = DecInput / 2204585.53791887
                            Case Weight(6)
                                DecResult = DecInput * 2268
                            Case Weight(7)
                                DecResult = DecInput * 1
                            Case Weight(8)
                                DecResult = DecInput * 16
                        End Select
                    Case Weight(8)
                        Select Case ConvertWeightTo
                            Case Weight(0)
                                DecResult = DecInput * 28350
                            Case Weight(1)
                                DecResult = DecInput * 28.35
                            Case Weight(2)
                                DecResult = DecInput / 35.2733686067019
                            Case Weight(3)
                                DecResult = DecInput / 3527.33686067019
                            Case Weight(4)
                                DecResult = DecInput / 35273.3686067019
                            Case Weight(5)
                                DecResult = DecInput / 35273368.6067019
                            Case Weight(6)
                                DecResult = DecInput * 141.7
                            Case Weight(7)
                                DecResult = DecInput / 16
                            Case Weight(8)
                                DecResult = DecInput * 1
                        End Select
                End Select
                ConvertionResult = CStr(DecResult)
                TextBox5.Text = ConvertionResult
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка. Возможно, вы ввели слишком большое число.")
            Exit Sub
        End Try
        If TextBox6.Text = "" Then TextBox5.Text = ""
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim Speed(11)
        Speed(0) = "километр в секунду"
        Speed(1) = "метр в секунду"
        Speed(2) = "километр в час"
        Speed(3) = "метр в минуту"
        Speed(4) = "миля в секунду"
        Speed(5) = "миля в час"
        Speed(6) = "фут в секунду"
        Speed(7) = "фут в минуту"
        Speed(8) = "узел"
        Speed(9) = "морская миля в час"
        Speed(10) = "скорость звука в воздухе"
        Speed(11) = "скорость света в вакууме"
        Dim DecInput As Double
        Dim TxtInput As String = TextBox8.Text
        Dim DecResult As Double
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox7.Text
        Dim ConvertSpeedFrom = ComboBox6.SelectedItem
        Dim ConvertSpeedTo = ComboBox5.SelectedItem
        Try
            If IsNumeric(TxtInput) Then
                DecInput = CDec(TxtInput)
                Select Case ConvertSpeedFrom
                    Case Speed(0)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput * 1
                            Case Speed(1)
                                DecResult = DecInput * 1000
                            Case Speed(2)
                                DecResult = DecInput * 3600
                            Case Speed(3)
                                DecResult = DecInput * 60000
                            Case Speed(4)
                                DecResult = DecInput / 1.60926939169617
                            Case Speed(5)
                                DecResult = DecInput * 2237
                            Case Speed(6)
                                DecResult = DecInput * 3281
                            Case Speed(7)
                                DecResult = DecInput * 196900
                            Case Speed(8)
                                DecResult = DecInput * 1944
                            Case Speed(9)
                                DecResult = DecInput * 1944
                            Case Speed(10)
                                DecResult = DecInput * 2.941
                            Case Speed(11)
                                DecResult = DecInput / 299760.191846523
                        End Select
                    Case Speed(1)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 1000
                            Case Speed(1)
                                DecResult = DecInput * 1
                            Case Speed(2)
                                DecResult = DecInput * 3.6
                            Case Speed(3)
                                DecResult = DecInput * 60
                            Case Speed(4)
                                DecResult = DecInput / 1609.26939169617
                            Case Speed(5)
                                DecResult = DecInput * 2.237
                            Case Speed(6)
                                DecResult = DecInput * 3.281
                            Case Speed(7)
                                DecResult = DecInput * 196.9
                            Case Speed(8)
                                DecResult = DecInput * 1.944
                            Case Speed(9)
                                DecResult = DecInput * 1.944
                            Case Speed(10)
                                DecResult = DecInput / 340.020401224073
                            Case Speed(11)
                                DecResult = DecInput / 299760191.846523
                        End Select
                    Case Speed(2)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 3599.71202303816
                            Case Speed(1)
                                DecResult = DecInput / 3.59971202303816
                            Case Speed(2)
                                DecResult = DecInput * 1
                            Case Speed(3)
                                DecResult = DecInput * 16.67
                            Case Speed(4)
                                DecResult = DecInput / 5793.74275782155
                            Case Speed(5)
                                DecResult = DecInput / 1.60926939169617
                            Case Speed(6)
                                DecResult = DecInput / 1.09733347964446
                            Case Speed(7)
                                DecResult = DecInput * 54.68
                            Case Speed(8)
                                DecResult = DecInput * 0.54
                            Case Speed(9)
                                DecResult = DecInput * 0.54
                            Case Speed(10)
                                DecResult = DecInput / 1223.99020807834
                            Case Speed(11)
                                DecResult = DecInput / 1079214331.96633
                        End Select
                    Case Speed(3)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 59988.0023995201
                            Case Speed(1)
                                DecResult = DecInput / 59.9880023995201
                            Case Speed(2)
                                DecResult = DecInput / 16.6666666666667
                            Case Speed(3)
                                DecResult = DecInput * 1
                            Case Speed(4)
                                DecResult = DecInput / 96525.0965250965
                            Case Speed(5)
                                DecResult = DecInput / 26.8240343347639
                            Case Speed(6)
                                DecResult = DecInput / 18.2882223847842
                            Case Speed(7)
                                DecResult = DecInput * 3.281
                            Case Speed(8)
                                DecResult = DecInput / 30.8641975308642
                            Case Speed(9)
                                DecResult = DecInput / 30.8641975308642
                            Case Speed(10)
                                DecResult = DecInput / 20399.8368013056
                            Case Speed(11)
                                DecResult = DecInput / 17988846914.9128
                        End Select
                    Case Speed(4)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput * 1.609
                            Case Speed(1)
                                DecResult = DecInput * 1609
                            Case Speed(2)
                                DecResult = DecInput * 5794
                            Case Speed(3)
                                DecResult = DecInput * 96560
                            Case Speed(4)
                                DecResult = DecInput * 1
                            Case Speed(5)
                                DecResult = DecInput * 3600
                            Case Speed(6)
                                DecResult = DecInput * 5280
                            Case Speed(7)
                                DecResult = DecInput * 316800
                            Case Speed(8)
                                DecResult = DecInput * 3128
                            Case Speed(9)
                                DecResult = DecInput * 3128
                            Case Speed(10)
                                DecResult = DecInput * 4.733
                            Case Speed(11)
                                DecResult = DecInput / 186289.12071535
                        End Select
                    Case Speed(5)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 2237.13646532438
                            Case Speed(1)
                                DecResult = DecInput / 2.23713646532438
                            Case Speed(2)
                                DecResult = DecInput * 1.609
                            Case Speed(3)
                                DecResult = DecInput * 26.82
                            Case Speed(4)
                                DecResult = DecInput / 3599.71202303816
                            Case Speed(5)
                                DecResult = DecInput * 1
                            Case Speed(6)
                                DecResult = DecInput * 1.467
                            Case Speed(7)
                                DecResult = DecInput * 88
                            Case Speed(8)
                                DecResult = DecInput / 1.15074798619102
                            Case Speed(9)
                                DecResult = DecInput / 1.15074798619102
                            Case Speed(10)
                                DecResult = DecInput / 760.456273764259
                            Case Speed(11)
                                DecResult = DecInput / 670690811.535882
                        End Select
                    Case Speed(6)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 3280.83989501312
                            Case Speed(1)
                                DecResult = DecInput / 3.28083989501312
                            Case Speed(2)
                                DecResult = DecInput * 1.097
                            Case Speed(3)
                                DecResult = DecInput * 18.29
                            Case Speed(4)
                                DecResult = DecInput / 5279.83104540655
                            Case Speed(5)
                                DecResult = DecInput / 1.46670577882077
                            Case Speed(6)
                                DecResult = DecInput * 1
                            Case Speed(7)
                                DecResult = DecInput * 60
                            Case Speed(8)
                                DecResult = DecInput / 1.68776371308017
                            Case Speed(9)
                                DecResult = DecInput / 1.68776371308017
                            Case Speed(10)
                                DecResult = DecInput / 1115.4489682097
                            Case Speed(11)
                                DecResult = DecInput / 983284169.124877
                        End Select
                    Case Speed(7)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 196850.393700787
                            Case Speed(1)
                                DecResult = DecInput / 196.850393700787
                            Case Speed(2)
                                DecResult = DecInput / 54.6746856205577
                            Case Speed(3)
                                DecResult = DecInput / 3.28083989501312
                            Case Speed(4)
                                DecResult = DecInput / 316756.41431739
                            Case Speed(5)
                                DecResult = DecInput / 88.0281690140845
                            Case Speed(6)
                                DecResult = DecInput / 59.9880023995201
                            Case Speed(7)
                                DecResult = DecInput * 1
                            Case Speed(8)
                                DecResult = DecInput / 101.26582278481
                            Case Speed(9)
                                DecResult = DecInput / 101.26582278481
                            Case Speed(10)
                                DecResult = DecInput / 66934.4042838019
                            Case Speed(11)
                                DecResult = DecInput / 58997050147.4926
                        End Select
                    Case Speed(8)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 1944.01244167963
                            Case Speed(1)
                                DecResult = DecInput / 1.94401244167963
                            Case Speed(2)
                                DecResult = DecInput * 1.852
                            Case Speed(3)
                                DecResult = DecInput * 30.87
                            Case Speed(4)
                                DecResult = DecInput / 3127.93243665937
                            Case Speed(5)
                                DecResult = DecInput * 1.151
                            Case Speed(6)
                                DecResult = DecInput * 1.688
                            Case Speed(7)
                                DecResult = DecInput * 101.3
                            Case Speed(8)
                                DecResult = DecInput * 1
                            Case Speed(9)
                                DecResult = DecInput * 1
                            Case Speed(10)
                                DecResult = DecInput / 660.938532716457
                            Case Speed(11)
                                DecResult = DecInput / 582750582.750583
                        End Select
                    Case Speed(9)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 1944.01244167963
                            Case Speed(1)
                                DecResult = DecInput / 1.94401244167963
                            Case Speed(2)
                                DecResult = DecInput * 1.852
                            Case Speed(3)
                                DecResult = DecInput * 30.87
                            Case Speed(4)
                                DecResult = DecInput / 3127.93243665937
                            Case Speed(5)
                                DecResult = DecInput * 1.151
                            Case Speed(6)
                                DecResult = DecInput * 1.688
                            Case Speed(7)
                                DecResult = DecInput * 101.3
                            Case Speed(8)
                                DecResult = DecInput * 1
                            Case Speed(9)
                                DecResult = DecInput * 1
                            Case Speed(10)
                                DecResult = DecInput / 660.938532716457
                            Case Speed(11)
                                DecResult = DecInput / 582750582.750583
                        End Select
                    Case Speed(10)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput / 2.94117647058824
                            Case Speed(1)
                                DecResult = DecInput * 340
                            Case Speed(2)
                                DecResult = DecInput * 1224
                            Case Speed(3)
                                DecResult = DecInput * 20400
                            Case Speed(4)
                                DecResult = DecInput / 4.73260766682442
                            Case Speed(5)
                                DecResult = DecInput * 760.6
                            Case Speed(6)
                                DecResult = DecInput * 1115
                            Case Speed(7)
                                DecResult = DecInput * 66930
                            Case Speed(8)
                                DecResult = DecInput * 660.9
                            Case Speed(9)
                                DecResult = DecInput * 660.9
                            Case Speed(10)
                                DecResult = DecInput * 1
                            Case Speed(11)
                                DecResult = DecInput / 881834.215167548
                        End Select
                    Case Speed(11)
                        Select Case ConvertSpeedTo
                            Case Speed(0)
                                DecResult = DecInput * 299800
                            Case Speed(1)
                                DecResult = DecInput * 299800000
                            Case Speed(2)
                                DecResult = DecInput * 1079000000
                            Case Speed(3)
                                DecResult = DecInput * 17990000000
                            Case Speed(4)
                                DecResult = DecInput * 186300
                            Case Speed(5)
                                DecResult = DecInput * 670600000
                            Case Speed(6)
                                DecResult = DecInput * 983600000
                            Case Speed(7)
                                DecResult = DecInput * 59010000000
                            Case Speed(8)
                                DecResult = DecInput * 582700000
                            Case Speed(9)
                                DecResult = DecInput * 582700000
                            Case Speed(10)
                                DecResult = DecInput * 881700
                            Case Speed(11)
                                DecResult = DecInput * 1
                        End Select
                End Select
                ConvertionResult = CStr(DecResult)
                TextBox7.Text = ConvertionResult
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка. Возможно, вы ввели слишком большое число.")
            Exit Sub
        End Try
        If TextBox8.Text = "" Then TextBox7.Text = ""
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Dim Temperature(4)
        Temperature(0) = "градус Цельсия"
        Temperature(1) = "градус Фаренгейта"
        Temperature(2) = "кельвин"
        Temperature(3) = "градус Реомюра"
        Temperature(4) = "плансковская температура"
        Dim DecInput As Double
        Dim TxtInput As String = TextBox10.Text
        Dim DecResult As Double
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox9.Text
        Dim ConvertTemperatureFrom = ComboBox10.SelectedItem
        Dim ConvertTemperatureTo = ComboBox7.SelectedItem
        Try

        Catch ex As Exception

        End Try
        If IsNumeric(TxtInput) Then
            DecInput = CDec(TxtInput)
            Select Case ConvertTemperatureFrom
                Case Temperature(0)
                    Select Case ConvertTemperatureTo
                        Case Temperature(0)
                            DecResult = DecInput * 1
                        Case Temperature(1)
                            DecResult = DecInput * 33.8
                        Case Temperature(2)
                            DecResult = DecInput * 274.1
                        Case Temperature(3)
                            DecResult = DecInput / 1.25
                        Case Temperature(4)
                            DecResult = DecInput / 5.16795865633075E+29
                    End Select
                Case Temperature(1)
                    Select Case ConvertTemperatureTo
                        Case Temperature(0)
                            DecResult = DecInput * -17.22
                        Case Temperature(1)
                            DecResult = DecInput * 1
                        Case Temperature(2)
                            DecResult = DecInput * 255.9
                        Case Temperature(3)
                            DecResult = DecInput * -13.78
                        Case Temperature(4)
                            DecResult = DecInput / 5.53709856035437E+29
                    End Select
                Case Temperature(2)
                    Select Case ConvertTemperatureTo
                        Case Temperature(0)
                            DecResult = DecInput * -272.1
                        Case Temperature(1)
                            DecResult = DecInput * -457.9
                        Case Temperature(2)
                            DecResult = DecInput * 1
                        Case Temperature(3)
                            DecResult = DecInput * -217.7
                        Case Temperature(4)
                            DecResult = DecInput / 1.4168319637291E+32
                    End Select
                Case Temperature(3)
                    Select Case ConvertTemperatureTo
                        Case Temperature(0)
                            DecResult = DecInput * 1.25
                        Case Temperature(1)
                            DecResult = DecInput * 34.25
                        Case Temperature(2)
                            DecResult = DecInput * 274.4
                        Case Temperature(3)
                            DecResult = DecInput * 1
                        Case Temperature(4)
                            DecResult = DecInput / 5.16262261228704E+29
                    End Select
                Case Temperature(4)
                    Select Case ConvertTemperatureTo
                        Case Temperature(0)
                            DecResult = DecInput * 1.417E+32
                        Case Temperature(1)
                            DecResult = DecInput * 2.55E+32
                        Case Temperature(2)
                            DecResult = DecInput * 1.417E+32
                        Case Temperature(3)
                            DecResult = DecInput * 1.133E+32
                        Case Temperature(4)
                            DecResult = DecInput * 1
                    End Select
            End Select
            ConvertionResult = CStr(DecResult)
            TextBox9.Text = ConvertionResult
        End If
        If TextBox10.Text = "" Then TextBox9.Text = ""
    End Sub
    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Dim Area(10)
        Area(0) = "квадратный миллиметр"
        Area(1) = "квадратный сантиметр"
        Area(2) = "квадратный дециметр"
        Area(3) = "квадратный метр"
        Area(4) = "квадратный километр"
        Area(5) = "гектар"
        Area(6) = "квадратный дюйм"
        Area(7) = "квадратный фут"
        Area(8) = "квадратный ярд"
        Area(9) = "квадратная миля"
        Area(10) = "акр"
        Dim DecInput As Double
        Dim TxtInput As String = TextBox12.Text
        Dim DecResult As Double
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox11.Text
        Dim ConvertAreaFrom = ComboBox12.SelectedItem
        Dim ConvertAreaTo = ComboBox11.SelectedItem
        Try
            If IsNumeric(TxtInput) Then
                DecInput = CDec(TxtInput)
                Select Case ConvertAreaFrom
                    Case Area(0)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 1
                            Case Area(1)
                                DecResult = DecInput / 100
                            Case Area(2)
                                DecResult = DecInput / 10000
                            Case Area(3)
                                DecResult = DecInput / 1000000
                            Case Area(4)
                                DecResult = DecInput / 1000000000000
                            Case Area(5)
                                DecResult = DecInput / 1000000000
                            Case Area(6)
                                DecResult = DecInput / 645.161290322581
                            Case Area(7)
                                DecResult = DecInput / 92936.8029739777
                            Case Area(8)
                                DecResult = DecInput / 836120.401337793
                            Case Area(9)
                                DecResult = DecInput / 2590002590002.59
                            Case Area(10)
                                DecResult = DecInput / 4046944556.85957
                        End Select
                    Case Area(1)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 100
                            Case Area(1)
                                DecResult = DecInput * 1
                            Case Area(2)
                                DecResult = DecInput / 100
                            Case Area(3)
                                DecResult = DecInput / 10000
                            Case Area(4)
                                DecResult = DecInput / 10000000000
                            Case Area(5)
                                DecResult = DecInput / 100000000
                            Case Area(6)
                                DecResult = DecInput / 6.45161290322581
                            Case Area(7)
                                DecResult = DecInput / 929.368029739777
                            Case Area(8)
                                DecResult = DecInput / 8361.20401337793
                            Case Area(9)
                                DecResult = DecInput / 25900025900.0259
                            Case Area(10)
                                DecResult = DecInput / 40469445.5685957
                        End Select
                    Case Area(2)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 10000
                            Case Area(1)
                                DecResult = DecInput * 100
                            Case Area(2)
                                DecResult = DecInput * 1
                            Case Area(3)
                                DecResult = DecInput / 100
                            Case Area(4)
                                DecResult = DecInput / 100000000
                            Case Area(5)
                                DecResult = DecInput / 1000000
                            Case Area(6)
                                DecResult = DecInput * 15.5
                            Case Area(7)
                                DecResult = DecInput / 9.29368029739777
                            Case Area(8)
                                DecResult = DecInput / 83.6120401337793
                            Case Area(9)
                                DecResult = DecInput / 259000259.000259
                            Case Area(10)
                                DecResult = DecInput / 404694.455685957
                        End Select
                    Case Area(3)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 1000000
                            Case Area(1)
                                DecResult = DecInput * 10000
                            Case Area(2)
                                DecResult = DecInput * 100
                            Case Area(3)
                                DecResult = DecInput * 1
                            Case Area(4)
                                DecResult = DecInput / 1000000
                            Case Area(5)
                                DecResult = DecInput / 10000
                            Case Area(6)
                                DecResult = DecInput * 1550
                            Case Area(7)
                                DecResult = DecInput * 10.76
                            Case Area(8)
                                DecResult = DecInput * 1.196
                            Case Area(9)
                                DecResult = DecInput / 2590002.59000259
                            Case Area(10)
                                DecResult = DecInput / 4046.94455685957
                        End Select
                    Case Area(4)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 1000000000000
                            Case Area(1)
                                DecResult = DecInput * 10000000000
                            Case Area(2)
                                DecResult = DecInput * 100000000
                            Case Area(3)
                                DecResult = DecInput * 1000000
                            Case Area(4)
                                DecResult = DecInput * 1
                            Case Area(5)
                                DecResult = DecInput * 100
                            Case Area(6)
                                DecResult = DecInput * 1550000000
                            Case Area(7)
                                DecResult = DecInput * 10760000
                            Case Area(8)
                                DecResult = DecInput * 1196000
                            Case Area(9)
                                DecResult = DecInput / 2.59000259000259
                            Case Area(10)
                                DecResult = DecInput * 247.1
                        End Select
                    Case Area(5)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 10000000000
                            Case Area(1)
                                DecResult = DecInput * 100000000
                            Case Area(2)
                                DecResult = DecInput * 1000000
                            Case Area(3)
                                DecResult = DecInput * 10000
                            Case Area(4)
                                DecResult = DecInput / 100
                            Case Area(5)
                                DecResult = DecInput * 1
                            Case Area(6)
                                DecResult = DecInput * 15500000
                            Case Area(7)
                                DecResult = DecInput * 107600
                            Case Area(8)
                                DecResult = DecInput * 11960
                            Case Area(9)
                                DecResult = DecInput / 259.000259000259
                            Case Area(10)
                                DecResult = DecInput * 2.471
                        End Select
                    Case Area(6)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 645.2
                            Case Area(1)
                                DecResult = DecInput * 6.452
                            Case Area(2)
                                DecResult = DecInput / 15.4990700557967
                            Case Area(3)
                                DecResult = DecInput / 1549.90700557967
                            Case Area(4)
                                DecResult = DecInput / 1549907005.57967
                            Case Area(5)
                                DecResult = DecInput / 15499070.0557967
                            Case Area(6)
                                DecResult = DecInput * 1
                            Case Area(7)
                                DecResult = DecInput / 144.009216589862
                            Case Area(8)
                                DecResult = DecInput / 1296.00829445308
                            Case Area(9)
                                DecResult = DecInput / 4014452027.29827
                            Case Area(10)
                                DecResult = DecInput / 6273525.72145546
                        End Select
                    Case Area(7)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 92900
                            Case Area(1)
                                DecResult = DecInput * 929
                            Case Area(2)
                                DecResult = DecInput * 9.29
                            Case Area(3)
                                DecResult = DecInput / 10.7642626480086
                            Case Area(4)
                                DecResult = DecInput / 10764262.6480086
                            Case Area(5)
                                DecResult = DecInput / 107642.626480086
                            Case Area(6)
                                DecResult = DecInput * 144
                            Case Area(7)
                                DecResult = DecInput * 1
                            Case Area(8)
                                DecResult = DecInput / 9.000900090009
                            Case Area(9)
                                DecResult = DecInput / 27878449.9581823
                            Case Area(10)
                                DecResult = DecInput / 43554.0069686411
                        End Select
                    Case Area(8)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 836100
                            Case Area(1)
                                DecResult = DecInput * 8361
                            Case Area(2)
                                DecResult = DecInput * 83.61
                            Case Area(3)
                                DecResult = DecInput / 1.19602918311207
                            Case Area(4)
                                DecResult = DecInput / 1196029.18311207
                            Case Area(5)
                                DecResult = DecInput / 11960.2918311207
                            Case Area(6)
                                DecResult = DecInput * 1296
                            Case Area(7)
                                DecResult = DecInput * 9
                            Case Area(8)
                                DecResult = DecInput * 1
                            Case Area(9)
                                DecResult = DecInput / 3097893.43246592
                            Case Area(10)
                                DecResult = DecInput / 4840.27105517909
                        End Select
                    Case Area(9)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 2590000000000
                            Case Area(1)
                                DecResult = DecInput * 25900000000
                            Case Area(2)
                                DecResult = DecInput * 259000000
                            Case Area(3)
                                DecResult = DecInput * 2590000
                            Case Area(4)
                                DecResult = DecInput * 2.59
                            Case Area(5)
                                DecResult = DecInput * 259
                            Case Area(6)
                                DecResult = DecInput * 4014000000
                            Case Area(7)
                                DecResult = DecInput * 27880000
                            Case Area(8)
                                DecResult = DecInput * 3098000
                            Case Area(9)
                                DecResult = DecInput * 1
                            Case Area(10)
                                DecResult = DecInput * 640
                        End Select
                    Case Area(10)
                        Select Case ConvertAreaTo
                            Case Area(0)
                                DecResult = DecInput * 4047000000
                            Case Area(1)
                                DecResult = DecInput * 40470000
                            Case Area(2)
                                DecResult = DecInput * 404700
                            Case Area(3)
                                DecResult = DecInput * 4047
                            Case Area(4)
                                DecResult = DecInput / 247.096614776378
                            Case Area(5)
                                DecResult = DecInput / 2.47096614776378
                            Case Area(6)
                                DecResult = DecInput * 6273000
                            Case Area(7)
                                DecResult = DecInput * 43560
                            Case Area(8)
                                DecResult = DecInput * 4840
                            Case Area(9)
                                DecResult = DecInput / 639.795265515035
                            Case Area(10)
                                DecResult = DecInput * 1
                        End Select
                End Select
                ConvertionResult = CStr(DecResult)
                TextBox11.Text = ConvertionResult
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка. Возможно, вы ввели слишком большое число.")
            Exit Sub
        End Try
        If TextBox12.Text = "" Then TextBox11.Text = ""
    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Dim Time(8)
        Time(1) = "век"
        Time(2) = "год"
        Time(3) = "месяц"
        Time(4) = "неделя"
        Time(5) = "сутки"
        Time(6) = "час"
        Time(7) = "минута"
        Time(8) = "секунда"
        Dim DecInput As Double
        Dim TxtInput As String = TextBox14.Text
        Dim DecResult As Double
        Dim ConvertionResult As String
        Dim TxtOutput As String = TextBox13.Text
        Dim ConvertTimeFrom = ComboBox14.SelectedItem
        Dim ConvertTimeTo = ComboBox13.SelectedItem
        Try
            If IsNumeric(TxtInput) Then
                DecInput = CDec(TxtInput)
                Select Case ConvertTimeFrom
                    Case Time(1)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput * 1
                            Case Time(2)
                                DecResult = DecInput * 100
                            Case Time(3)
                                DecResult = DecInput * 1200
                            Case Time(4)
                                DecResult = DecInput * 5218
                            Case Time(5)
                                DecResult = DecInput * 36520
                            Case Time(6)
                                DecResult = DecInput * 876600
                            Case Time(7)
                                DecResult = DecInput * 52590000
                            Case Time(8)
                                DecResult = DecInput * 3156000000
                        End Select
                    Case Time(2)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 100
                            Case Time(2)
                                DecResult = DecInput * 1
                            Case Time(3)
                                DecResult = DecInput * 12
                            Case Time(4)
                                DecResult = DecInput * 52.18
                            Case Time(5)
                                DecResult = DecInput * 365.2
                            Case Time(6)
                                DecResult = DecInput * 8766
                            Case Time(7)
                                DecResult = DecInput * 525900
                            Case Time(8)
                                DecResult = DecInput * 31560000
                        End Select
                    Case Time(3)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 1200.04800192008
                            Case Time(2)
                                DecResult = DecInput / 12.0004800192008
                            Case Time(3)
                                DecResult = DecInput * 1
                            Case Time(4)
                                DecResult = DecInput * 4.348
                            Case Time(5)
                                DecResult = DecInput * 30.44
                            Case Time(6)
                                DecResult = DecInput * 730.5
                            Case Time(7)
                                DecResult = DecInput * 43830
                            Case Time(8)
                                DecResult = DecInput * 2630000
                        End Select
                    Case Time(4)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 5216.48408972353
                            Case Time(2)
                                DecResult = DecInput / 52.1648408972353
                            Case Time(3)
                                DecResult = DecInput / 4.34782608695652
                            Case Time(4)
                                DecResult = DecInput * 1
                            Case Time(5)
                                DecResult = DecInput * 7
                            Case Time(6)
                                DecResult = DecInput * 168
                            Case Time(7)
                                DecResult = DecInput * 10080
                            Case Time(8)
                                DecResult = DecInput * 604800
                        End Select
                    Case Time(5)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 36523.0094959825
                            Case Time(2)
                                DecResult = DecInput / 365.230094959825
                            Case Time(3)
                                DecResult = DecInput / 30.441400304414
                            Case Time(4)
                                DecResult = DecInput / 6.99790062981106
                            Case Time(5)
                                DecResult = DecInput * 1
                            Case Time(6)
                                DecResult = DecInput * 24
                            Case Time(7)
                                DecResult = DecInput * 1440
                            Case Time(8)
                                DecResult = DecInput * 86400
                        End Select
                    Case Time(6)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 876424.189307625
                            Case Time(2)
                                DecResult = DecInput / 8764.24189307625
                            Case Time(3)
                                DecResult = DecInput / 730.460189919649
                            Case Time(4)
                                DecResult = DecInput / 168.010752688172
                            Case Time(5)
                                DecResult = DecInput / 23.9980801535877
                            Case Time(6)
                                DecResult = DecInput * 1
                            Case Time(7)
                                DecResult = DecInput * 60
                            Case Time(8)
                                DecResult = DecInput * 3600
                        End Select
                    Case Time(7)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 52603892.6880589
                            Case Time(2)
                                DecResult = DecInput / 526038.926880589
                            Case Time(3)
                                DecResult = DecInput / 43821.2094653812
                            Case Time(4)
                                DecResult = DecInput / 10079.6290696502
                            Case Time(5)
                                DecResult = DecInput / 1440.09216589862
                            Case Time(6)
                                DecResult = DecInput / 59.9880023995201
                            Case Time(7)
                                DecResult = DecInput * 1
                            Case Time(8)
                                DecResult = DecInput * 60
                        End Select
                    Case Time(8)
                        Select Case ConvertTimeTo
                            Case Time(1)
                                DecResult = DecInput / 3155569580.30925
                            Case Time(2)
                                DecResult = DecInput / 31555695.8030925
                            Case Time(3)
                                DecResult = DecInput / 2629503.02392848
                            Case Time(4)
                                DecResult = DecInput / 604960.677555959
                            Case Time(5)
                                DecResult = DecInput / 86430.4235090752
                            Case Time(6)
                                DecResult = DecInput / 3600
                            Case Time(7)
                                DecResult = DecInput / 60
                            Case Time(8)
                                DecResult = DecInput * 1
                        End Select
                End Select
                ConvertionResult = CStr(DecResult)
                TextBox13.Text = ConvertionResult
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка. Возможно, вы ввели слишком большое число.")
            Exit Sub
        End Try
        If TextBox14.Text = "" Then TextBox13.Text = ""
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/944052062.jpg")
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/603455256.jpg")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/60321043.jpg")
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/725776542.jpg")
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/60321043.jpg")
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/60321043.jpg")
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/831769034.jpg")
    End Sub
    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/60321043.jpg")
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/2/362742844.jpg")
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/285075156.jpg")
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/811877832.jpg")
    End Sub
    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        System.Diagnostics.Process.Start("http://sigmasoft.ucoz.com/_ph/1/265287183.jpg")
    End Sub
    Dim Links(16)
    Dim SelectedIndex As Integer
    Sub GoLinkValue(ByVal index As Integer)
        System.Diagnostics.Process.Start(Links(index))
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SelectedIndex = ComboBox1.SelectedIndex
        LinkLabel8.Visible = True
        SelectedIndex = ComboBox1.SelectedIndex
        Links(0) = "http://sigmasoft.ucoz.com/_ph/1/289862246.png"
        Links(1) = "http://sigmasoft.ucoz.com/_ph/1/547628911.jpg"
        Links(2) = "http://sigmasoft.ucoz.com/_ph/1/145998103.jpg"
        Links(3) = "http://sigmasoft.ucoz.com/_ph/1/199073768.png"
        Links(4) = "http://sigmasoft.ucoz.com/_ph/1/2/224222561.jpg"
        Links(5) = "http://sigmasoft.ucoz.com/_ph/1/2/710305066.png"
        Links(6) = "http://sigmasoft.ucoz.com/_ph/1/2/936045935.png"
        Links(7) = "http://sigmasoft.ucoz.com/_ph/1/2/997024362.jpg"
        Links(8) = "http://sigmasoft.ucoz.com/_ph/1/257761599.jpg"
        Links(9) = "http://sigmasoft.ucoz.com/_ph/1/257761599.jpg"
        Links(10) = "http://sigmasoft.ucoz.com/_ph/1/2/729388168.png"
        Links(11) = "http://sigmasoft.ucoz.com/_ph/1/2/697058171.gif"
        Links(12) = "http://sigmasoft.ucoz.com/_ph/1/950616565.jpg"
        Links(13) = "http://sigmasoft.ucoz.com/_ph/1/778162744.jpg"
        Links(14) = "http://sigmasoft.ucoz.com/_ph/1/732675635.jpg"
        Links(15) = "http://sigmasoft.ucoz.com/_ph/1/505615191.jpg"
        Links(16) = "http://sigmasoft.ucoz.com/_ph/1/2/327346663.jpg"
        LinkLabel8.Text = "показать изображение единиц измерения длины" & " '" & ComboBox1.SelectedItem & "'"
    End Sub
    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        SelectedIndex = ComboBox1.SelectedIndex
        GoLinkValue(SelectedIndex)
    End Sub
    Private Sub ВозведениеВСтепеньToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВозведениеВСтепеньToolStripMenuItem.Click
        Form2.Visible = True
    End Sub
    Sub Нахождение_Среднего_Арифметического()
        Dim a, o, n, s, i As Decimal
        Dim o1, n1, defValue As String
        defValue = "0"
        s = 0
        n1 = InputBox("Введите количество чисел, среди которых вы хотите вычислить среднее арифметическое", "Среднее арфметическое", defValue)
        If n1 Is "" Then n1 = defValue : Exit Sub
        If IsNumeric(n1) = True Then
            n = CDbl(n1)
            For i = 1 To n
                o1 = InputBox("Введите оценку", "Average", defValue)
                If o1 Is "" Then o1 = defValue : Exit Sub
                If IsNumeric(o1) = True Then
                    o = CDbl(o1)
                    s = s + o
                Else
                    MsgBox("Вы должны вводить только цифры.")
                    Exit Sub
                End If
            Next i
        Else
            MsgBox("Вы должны вводить только цифры.")
            Exit Sub
        End If
        a = s / n
        MsgBox("Среднее арфметическое равно " & a, MsgBoxStyle.OkOnly, "Среднее арфметическое")
    End Sub
    Private Sub НахождениеСреднегоАрифметическогоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НахождениеСреднегоАрифметическогоToolStripMenuItem.Click
        Нахождение_Среднего_Арифметического()
    End Sub
    Private Sub ПомощьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПомощьToolStripMenuItem.Click
        MsgBox("При наличии проблем с использованием программы, вы можете обращаться к Михаилу Соколову, также вы можете отправить e-mail на адрес mihhail1998@gmail.com или на sigmasoft8@gmail.com, подробно описав проблему.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1, "Помощь")
    End Sub
    Private Sub ОПрограммеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        MsgBox("Программа была создана Михаилом Соколовым в качестве практической работы за 8-ой класс.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1, "Информация о программе")
    End Sub
    Private Sub КонтактныеДанныеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КонтактныеДанныеToolStripMenuItem.Click
        MsgBox("Имя: Михаил Соколов                                                                            Номер телефона: +37253015496                                                                     Рабочий e-mail: sigmasoft8@gmail.com                                                      Личный e-mail: mihhail1998@gmail.com", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1, "Контактные данные")
    End Sub
    Private Sub КалькуляторToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КалькуляторToolStripMenuItem.Click
        Form3.Visible = True
    End Sub
    Private Sub Form9_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        Dim SelectedIndex As Integer = ComboBox8.SelectedIndex
        LinkLabel8.Visible = True
        SelectedIndex = ComboBox8.SelectedIndex
        Links(0) = "http://sigmasoft.ucoz.com/_ph/1/289862246.png"
        Links(1) = "http://sigmasoft.ucoz.com/_ph/1/547628911.jpg"
        Links(2) = "http://sigmasoft.ucoz.com/_ph/1/145998103.jpg"
        Links(3) = "http://sigmasoft.ucoz.com/_ph/1/199073768.png"
        Links(4) = "http://sigmasoft.ucoz.com/_ph/1/2/224222561.jpg"
        Links(5) = "http://sigmasoft.ucoz.com/_ph/1/2/710305066.png"
        Links(6) = "http://sigmasoft.ucoz.com/_ph/1/2/936045935.png"
        Links(7) = "http://sigmasoft.ucoz.com/_ph/1/2/997024362.jpg"
        Links(8) = "http://sigmasoft.ucoz.com/_ph/1/257761599.jpg"
        Links(9) = "http://sigmasoft.ucoz.com/_ph/1/257761599.jpg"
        Links(10) = "http://sigmasoft.ucoz.com/_ph/1/2/729388168.png"
        Links(11) = "http://sigmasoft.ucoz.com/_ph/1/2/697058171.gif"
        Links(12) = "http://sigmasoft.ucoz.com/_ph/1/950616565.jpg"
        Links(13) = "http://sigmasoft.ucoz.com/_ph/1/778162744.jpg"
        Links(14) = "http://sigmasoft.ucoz.com/_ph/1/732675635.jpg"
        Links(15) = "http://sigmasoft.ucoz.com/_ph/1/505615191.jpg"
        Links(16) = "http://sigmasoft.ucoz.com/_ph/1/2/327346663.jpg"
        LinkLabel8.Text = "показать изображение единиц измерения длины" & " '" & ComboBox8.SelectedItem & "'"
    End Sub
    Private Sub НахождениеКвадратногоКорняToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НахождениеКвадратногоКорняToolStripMenuItem.Click
        Form4.Visible = True
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ComboBox1.Text = ComboBox1.Items(0)
        ComboBox8.Text = ComboBox8.Items(1)
        ComboBox3.Text = ComboBox3.Items(0)
        ComboBox2.Text = ComboBox2.Items(1)
        ComboBox4.Text = ComboBox4.Items(0)
        ComboBox9.Text = ComboBox9.Items(1)
        ComboBox6.Text = ComboBox6.Items(0)
        ComboBox5.Text = ComboBox5.Items(1)
        ComboBox10.Text = ComboBox10.Items(0)
        ComboBox7.Text = ComboBox7.Items(1)
        ComboBox12.Text = ComboBox12.Items(0)
        ComboBox11.Text = ComboBox11.Items(1)
        ComboBox14.Text = ComboBox14.Items(0)
        ComboBox13.Text = ComboBox13.Items(1)
    End Sub
End Class