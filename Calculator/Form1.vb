Public Class Form1
    'The two numbers to be calculated and the answer
    Dim number1, number2, answer As Long
    ' Tells the program to go the next input box
    Dim numberInput As Boolean
    ' 1 is add, 2 is subtract, 3 is multiply, 4 is divide
    Dim operatorIdentifier As Single




    'Buttons 1-9
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 1
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 1
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 2
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 2
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 3
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 3
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 4
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 4
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 5
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 5
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 6
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 6
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 7
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 7
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 8
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 8
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If numberInput = False Then
            number1 = number1 * 10
            number1 = number1 + 9
        End If

        If numberInput = True Then
            number2 = number2 * 10
            number2 = number2 + 9
        End If

        Label2.Text = number1
        Label1.Text = number2
    End Sub
    'Equals Button. Runs an operator based on the "operatorIdentifier" value
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If operatorIdentifier = 1 Then
            answer = number1 + number2
        End If

        If operatorIdentifier = 2 Then
            answer = number1 - number2
        End If

        If operatorIdentifier = 3 Then
            answer = number1 * number2
        End If

        If operatorIdentifier = 4 Then
            answer = number1 / number2
        End If

        Label3.Text = answer
    End Sub
    'Add, Subtract, Multiply, Subtract buttons
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        numberInput = True
        operatorIdentifier = 1

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        numberInput = True
        operatorIdentifier = 2
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        numberInput = True
        operatorIdentifier = 3
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        numberInput = True
        operatorIdentifier = 4
    End Sub
    'Clears the labels and input variables
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        number1 = 0
        number2 = 0
        answer = 0
        numberInput = False
        Label3.Text = answer
        Label2.Text = number1
        Label1.Text = number2


    End Sub


End Class
