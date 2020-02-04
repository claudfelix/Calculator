Public Class Form1

    Dim firstValue, secondValue, result As Double
    Dim op As String
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles buttonZero.Click, buttonTwo.Click, buttonThree.Click, buttonSeven.Click, buttonPoint.Click, buttonOne.Click, buttonNine.Click, buttonFour.Click, buttonFive.Click, buttonEight.Click, button6.Click
        Dim b As Button = sender

        If (displayScreen.Text = "0") Then
            displayScreen.Text = ""
            displayScreen.Text = b.Text
            displayScreen.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not displayScreen.Text.Contains(".")) Then
                displayScreen.Text = displayScreen.Text + b.Text
            End If

        Else
            displayScreen.Text = displayScreen.Text + b.Text
        End If
    End Sub

    Private Sub buttonEquals_Click(sender As Object, e As EventArgs) Handles buttonEquals.Click
        secondValue = displayScreen.Text

        If op = "+" Then
            result = firstValue + secondValue
            displayScreen.Text = result

        ElseIf op = "-" Then
            result = firstValue - secondValue
            displayScreen.Text = result

        ElseIf op = "*" Then
            result = firstValue - secondValue
            displayScreen.Text = result

        ElseIf op = "/" Then
            result = firstValue - secondValue
            displayScreen.Text = result
        End If
    End Sub

    Private Sub buttonPlusMinus_Click(sender As Object, e As EventArgs) Handles buttonPlusMinus.Click
        If (displayScreen.Text.Contains("-")) Then
            displayScreen.Text = displayScreen.Text.Remove(0, 1)
        Else
            displayScreen.Text = "-" + displayScreen.Text
        End If
    End Sub

    Private Sub buttonC_Click(sender As Object, e As EventArgs) Handles buttonC.Click
        displayScreen.Text = "0"
    End Sub

    Private Sub buttonCE_Click(sender As Object, e As EventArgs) Handles buttonCE.Click
        displayScreen.Text = "0"
    End Sub

    Private Sub buttonBackspace_Click(sender As Object, e As EventArgs) Handles buttonBackspace.Click
        If (displayScreen.Text.Length > 0) Then
            displayScreen.Text = displayScreen.Text.Remove(displayScreen.Text.Length - 1, 1)
        End If
        If (displayScreen.Text = "") Then
            displayScreen.Text = "0"
        End If
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles buttonPlus.Click, buttonMultiply.Click, buttonMinus.Click, buttonDivide.Click
        Dim b As Button = sender

        firstValue = displayScreen.Text
        op = b.Text
        displayScreen.Text = ""
    End Sub
End Class
