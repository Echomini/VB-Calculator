Module Module1
    'When a button is clicked it's value will now show in the Text Box
    Sub ShowValue(ByVal butt As Button)
        frmCalculator.txtOutput.Text() = Val(frmCalculator.txtOutput.Text() & butt.Text)
    End Sub

    'Handles the aritmetic buttons i.e. + and - 
    Sub arithmetic(ByRef butt As Button)
        frmCalculator.Value1 = Val(frmCalculator.txtOutput.Text)
        frmCalculator.Oper = butt.Text
        frmCalculator.txtOutput.Text = ""
    End Sub

    'Handles the caculations 
    Sub Calculate()
        Select Case frmCalculator.Oper
            Case "+"
                frmCalculator.txtOutput.Text = frmCalculator.Value1 + Val(frmCalculator.txtOutput.Text)
            Case "-"
                frmCalculator.txtOutput.Text = frmCalculator.Value1 - Val(frmCalculator.txtOutput.Text)
            Case "x"
                frmCalculator.txtOutput.Text = frmCalculator.Value1 * Val(frmCalculator.txtOutput.Text)
            Case "/"
                frmCalculator.txtOutput.Text = frmCalculator.Value1 / Val(frmCalculator.txtOutput.Text)
            Case "^"
                frmCalculator.txtOutput.Text = frmCalculator.Value1 ^ Val(frmCalculator.txtOutput.Text)
            Case "√"
                frmCalculator.txtOutput.Text = frmCalculator.Value1 ^ (1 / 2)
            Case "e"
                frmCalculator.txtOutput.Text = Math.Exp(frmCalculator.Value1)
            Case "ln"
                frmCalculator.txtOutput.Text = Math.Log(frmCalculator.Value1)
                'Case "%"
                'frmCalculator.txtOutput.Text = (frmCalculator.Value1 / 100) & "%"
        End Select
    End Sub

End Module
