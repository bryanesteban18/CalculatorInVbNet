Public Class Calculator
    Dim Number1 As Double
    Dim Number2 As Double
    Dim Results As Double
    Dim OPE As Double
    Dim Num As String
    Dim Num2 As String
    Dim memory As Double
    Dim strMessage As String

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TextBoxInput.Clear()
        TextBoxEquation.Clear()
        TextBoxMemory.Clear()
        TextBoxResults.Clear()
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        OPE = 1
        Number1 = Val(TextBoxInput.Text)
        Num = Val(TextBoxInput.Text)
        If TextBoxInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(TextBoxInput.Text) Then
            strMessage = "Please enter a numeric value"
        End If
        TextBoxInput.Clear()

    End Sub

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click

        
        Number2 = Val(TextBoxInput.Text)
        Num2 = Val(TextBoxInput.Text)
        If TextBoxInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(TextBoxInput.Text) Then
            strMessage = "Please enter a numeric value"
        End If
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
            strMessage = ""
        ElseIf OPE = 1 Then
            Results = Number1 + Number2
            TextBoxResults.Text = Results
            TextBoxEquation.Text = Num + " + " + Num2
            TextBoxMemory.Text = memory
        ElseIf OPE = 2 Then
            Results = Number1 - Number2
            TextBoxResults.Text = Results
            TextBoxEquation.Text = Num + " - " + Num2
            TextBoxMemory.Text = memory
        ElseIf OPE = 3 Then
            Results = Number1 * Number2
            TextBoxResults.Text = Results
            TextBoxEquation.Text = Num + " * " + Num2
            TextBoxMemory.Text = memory
        ElseIf OPE = 4 And Number2 <> 0 Then
            Results = Number1 / Number2
            TextBoxResults.Text = Results
            TextBoxEquation.Text = Num + " / " + Num2
            TextBoxMemory.Text = memory
        ElseIf OPE = 5 Then
            Results = Number1 ^ Number2
            TextBoxResults.Text = Results
            TextBoxEquation.Text = Num + " ^ " + Num2
            TextBoxMemory.Text = memory
        ElseIf OPE = 4 And Number2 = 0 Then
            MessageBox.Show("Cant divide by zero")

        End If


    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click
        OPE = 2
        Number1 = Val(TextBoxInput.Text)
        Num = Val(TextBoxInput.Text)
        If TextBoxInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(TextBoxInput.Text) Then
            strMessage = "Please enter a numeric value"
        End If
        TextBoxInput.Clear()
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        OPE = 3
        Number1 = Val(TextBoxInput.Text)
        Num = Val(TextBoxInput.Text)
        If TextBoxInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(TextBoxInput.Text) Then
            strMessage = "Please enter a numeric value"
        End If
        TextBoxInput.Clear()
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        OPE = 4
        Number1 = Val(TextBoxInput.Text)
        Num = Val(TextBoxInput.Text)
        If TextBoxInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(TextBoxInput.Text) Then
            strMessage = "Please enter a numeric value"
        End If
        TextBoxInput.Clear()
    End Sub

    Private Sub BtnPower_Click(sender As Object, e As EventArgs) Handles BtnPower.Click
        OPE = 5
        Number1 = Val(TextBoxInput.Text)
        Num = Val(TextBoxInput.Text)
        If TextBoxInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(TextBoxInput.Text) Then
            strMessage = "Please enter a numeric value"
        End If
        TextBoxInput.Clear()
    End Sub

    Private Sub BtnPi_Click(sender As Object, e As EventArgs) Handles BtnPi.Click
        TextBoxInput.Text = 3.1415926535
    End Sub

    Private Sub BtnMC_Click(sender As Object, e As EventArgs) Handles BtnMC.Click
        memory = 0
    End Sub

    Private Sub BtnMR_Click(sender As Object, e As EventArgs) Handles BtnMR.Click
        TextBoxInput.Text = memory
    End Sub

    Private Sub BtnMS_Click(sender As Object, e As EventArgs) Handles BtnMS.Click
        memory = TextBoxInput.Text
    End Sub

    Private Sub BtnSign_Click(sender As Object, e As EventArgs) Handles BtnSign.Click

        TextBoxInput.Text = Val(TextBoxInput.Text) * -1

    End Sub

    Private Sub TextBoxInput_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInput.TextChanged
        
    End Sub
End Class
