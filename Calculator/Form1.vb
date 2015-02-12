Public Class Form1
    'The two numbers to be calculated and the answer
    Dim number1, number2, answer As Double
    ' Tells the program to go the next input box, false is number1, true is number2
    Dim numberInput As Boolean
    ' 1 is add, 2 is subtract, 3 is multiply, 4 is divide
    Dim operatorIdentifier As Single
    ' False is degrees, true is radians
    Dim angleMode As Boolean





    'Buttons 1-9
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 1
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 1
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 2
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 2
            TextBox1.Text = number2
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 3
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 3
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 4
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 4
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 5
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 5
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 6
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 6
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 7
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 7
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 8
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 8
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 9
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 9
            TextBox1.Text = number2
        End If


    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If numberInput = False Then
            number1 = number1 * 10
            TextBox1.Text = number1

        End If

        If numberInput = True Then
            number2 = number2 * 10
            TextBox1.Text = number2
        End If

    End Sub

    'Equals Button. Runs an operator based on the "operatorIdentifier" value
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If operatorIdentifier = 1 Then
            answer = number1 + number2
            number1 = answer
            number2 = 0
            numberInput = False
            TextBox1.Text = number1
        End If

        If operatorIdentifier = 2 Then
            answer = number1 - number2
            number1 = answer
            number2 = 0
            numberInput = False
            TextBox1.Text = number1
        End If

        If operatorIdentifier = 3 Then
            answer = number1 * number2
            number1 = answer
            number2 = 0
            numberInput = False
            TextBox1.Text = number1
        End If

        If operatorIdentifier = 4 Then
            answer = number1 / number2
            number1 = answer
            number2 = 0
            numberInput = False
            TextBox1.Text = number1
        End If

        If operatorIdentifier = 5 Then
            answer = number1 ^ number2
            number1 = answer
            number2 = 0
            numberInput = False
            TextBox1.Text = number1
        End If
        If operatorIdentifier = 6 Then
            answer = number1 ^ (1 / number2)
            number1 = answer
            number2 = 0
            numberInput = False
            TextBox1.Text = number1


        End If


    End Sub
    'Add, Subtract, Multiply, Subtract buttons
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        numberInput = True
        operatorIdentifier = 1
        TextBox1.Text = 0

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        numberInput = True
        operatorIdentifier = 2
        TextBox1.Text = 0
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        numberInput = True
        operatorIdentifier = 3
        TextBox1.Text = 0
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        numberInput = True
        operatorIdentifier = 4
        TextBox1.Text = 0
    End Sub
    'Clears the labels and input variables
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        number1 = 0
        number2 = 0
        answer = 0
        numberInput = False
        TextBox1.Text = 0



    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        numberInput = True
        operatorIdentifier = 5
        TextBox1.Text = 0
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If numberInput = False Then
            answer = number1 ^ 2
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = number2 ^ 2
            TextBox1.Text = answer
        End If


    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If numberInput = False Then
            answer = number1 ^ 3
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = number2 ^ 3
            TextBox1.Text = answer
        End If

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If numberInput = False Then
            answer = Math.Sin(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Sin(number2)
            TextBox1.Text = answer
        End If

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If numberInput = False Then
            answer = Math.Tan(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Tan(number2)
            TextBox1.Text = answer
        End If

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If numberInput = False Then
            answer = Math.Cos(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Cos(number2)
            TextBox1.Text = answer
        End If


    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If numberInput = False Then
            number1 = Val(TextBox1.Text)

        End If
        If numberInput = True Then
            number2 = Val(TextBox1.Text)

        End If

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If numberInput = False Then
            answer = number1 * (-1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = number2 * (-1)
            TextBox1.Text = answer
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If numberInput = False Then
            answer = Math.Asin(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Asin(number2)
            TextBox1.Text = answer
        End If
    End Sub

    Private Sub Button22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If numberInput = False Then
            answer = Math.Acos(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Acos(number2)
            TextBox1.Text = answer
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If numberInput = False Then
            answer = Math.Atan(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Atan(number2)
            TextBox1.Text = answer
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Val(TextBox1.Text) = Int(Val(TextBox1.Text)) Then
            If numberInput = False Then

                TextBox1.Text = number1 + "."
            End If

            If numberInput = True Then
                TextBox1.Text = number2 + "."
            End If
        End If



    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click

        numberInput = True
        operatorIdentifier = 6
        TextBox1.Text = 0

    End Sub

    Private Sub Button27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If numberInput = False Then
            answer = Math.Sqrt(number1)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = Math.Sqrt(number2)
            TextBox1.Text = answer
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If numberInput = False Then
            answer = number1 ^ (1 / 3)
            TextBox1.Text = answer
        End If

        If numberInput = True Then
            answer = number2 ^ (1 / 3)
            TextBox1.Text = answer
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If numberInput = False Then
            number1 = 3.14159265359
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = 3.14159265359
            TextBox1.Text = number2
        End If
    End Sub

    Private Sub radioButtonDegrees_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonDegrees.CheckedChanged
        If radioButtonDegrees.Checked = True Then
            angleMode = False
        End If

        If radioButtonDegrees.Checked = False Then
            angleMode = True
        End If
    End Sub

    Private Sub radioButtonRadians_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonRadians.CheckedChanged
        If radioButtonRadians.Checked = True Then
            angleMode = True
        End If

        If radioButtonRadians.Checked = False Then
            angleMode = False
        End If
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If numberInput = False Then
            number1 = 1 / number1
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = 1 / number2
            TextBox1.Text = number2
        End If
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click

        If numberInput = False Then
            number1 = 0
            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = 0
            TextBox1.Text = number2
        End If
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If numberInput = False Then

            number1 = (5 / 9) * (number1 - 32)

            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = (5 / 9) * (number2 - 32)
            TextBox1.Text = number2
        End If


    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        If numberInput = False Then

            number1 = (1.8 * number1) + 32

            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number1 = (1.8 * number1) + 32

            TextBox1.Text = number1
        End If


    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If numberInput = False Then

            number1 = number1 * 12

            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 * 12
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If numberInput = False Then

            number1 = number1 / 12

            TextBox1.Text = number1
        End If

        If numberInput = True Then
            number2 = number2 / 12
            TextBox1.Text = number2
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(370, 470)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Size = New System.Drawing.Size(370, 470)
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Size = New System.Drawing.Size(500, 470)
    End Sub

    Private Sub ConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversionToolStripMenuItem.Click
        Me.Size = New System.Drawing.Size(625, 470)
    End Sub
End Class
