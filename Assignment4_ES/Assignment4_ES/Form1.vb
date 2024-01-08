Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' Declare Variables
        Dim decOriginalPrice As Decimal
        Dim decPercentOff As Decimal
        Dim decSalePrice As Decimal

        ' Get Inputs
        decOriginalPrice = txtOrginalPrice.Text
        decPercentOff = txtPercentOff.Text

        ' Do Calculations
        decPercentOff = decPercentOff * 0.01
        decSalePrice = decOriginalPrice - decOriginalPrice * decPercentOff

        ' Display Outputs
        lblSalePrice.Text = "$" + decSalePrice.ToString("F2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtOrginalPrice.Clear()
        txtPercentOff.Clear()
        lblSalePrice.ResetText()
        txtOrginalPrice.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub
End Class
