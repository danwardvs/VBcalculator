Public Class Form1
    Dim number1, number2, answer As Long
    Dim numberInput As Boolean


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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        numberInput = True

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        answer = number1 + number2
        Label3.Text = answer
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

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
