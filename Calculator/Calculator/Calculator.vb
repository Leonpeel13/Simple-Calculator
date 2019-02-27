Public Class Calculator


    Public varOperator As String
    Public varNum1 As String
    Public varNum2 As String
    Public BoolNum1 As Boolean
    Public BoolNum2 As Boolean
    Public varOutcome As Double
    Public Done As Boolean


    Private Sub BtnCmdMin_Click(sender As Object, e As EventArgs) Handles BtnCmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCmdExit_Click(sender As Object, e As EventArgs) Handles BtnCmdExit.Click
        Me.Close()
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length > 0 Then
                    varNum1 = varNum1.Substring(0, varNum1.Length - 1)
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length > 0 Then
                    varNum2 = varNum2.Substring(0, varNum2.Length - 1)
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        FormCalculator_Load(e, e)
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        If Done = False Then
            BoolNum1 = False
            BoolNum2 = True
            varOperator = "+"
        End If
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        If Done = False Then
            BoolNum1 = False
            BoolNum2 = True
            varOperator = "-"
        End If
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        If Done = False Then
            BoolNum1 = False
            BoolNum2 = True
            varOperator = "*"
        End If
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        If Done = False Then
            BoolNum1 = False
            BoolNum2 = True
            varOperator = "/"
        End If
    End Sub

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click
        If BoolNum1 = True Then
            LblNum.Text = varNum1
        Else
            Select Case varOperator
                Case "+"
                    varOutcome = Decimal.Parse(varNum1) + Decimal.Parse(varNum2)
                Case "-"
                    varOutcome = varNum1 - varNum2
                Case "/"
                    varOutcome = varNum1 / varNum2
                Case "*"
                    varOutcome = varNum1 * varNum2
            End Select
            LblNum.Text = varOutcome
            Done = True
        End If
    End Sub

    Private Sub FormCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varNum1 = ""
        varNum2 = ""
        varOperator = ""
        BoolNum1 = True
        BoolNum2 = False
        LblNum.Text = "0"
        Done = False
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "0"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "0"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "1"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "1"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "2"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "2"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "3"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "3"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "4"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "4"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "5"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "5"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "6"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "6"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "7"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "7"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "8"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "8"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "9"
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "9"
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub

    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles BtnDecimal.Click
        If Done = False Then
            If BoolNum1 = True Then
                If varNum1.Length < 9 Then
                    varNum1 = varNum1 + "."
                    LblNum.Text = varNum1
                End If
            ElseIf BoolNum2 = True Then
                If varNum2.Length < 9 Then
                    varNum2 = varNum2 + "."
                    LblNum.Text = varNum2
                End If
            End If
        End If
    End Sub
End Class
