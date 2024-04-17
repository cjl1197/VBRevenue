'Studio Revenue Calculator

Option Strict Off
Option Explicit Off

Public Class frmStudioRevenue
    Dim counter As Integer = 0


    ' Calculates and populates the charges and number of groups added
    Private Sub btnCalculateAmountCharged_Click(sender As Object, e As EventArgs) Handles btnCalculateAmountCharged.Click
        Dim a As Double = 200 / 60
        Dim b As Double = 0
        Dim c As Double = 0
        counter += 1



        Try
            b = Double.Parse(txtTimeUsed.Text)
            c = (a * b)
            lblAmountCharged.Text = (c).ToString("C")
            lblTotalChargesCalculated.Text = (lblTotalChargesCalculated.Text + c).ToString("C")
            lblAvgChargeCalculated.Text = (lblTotalChargesCalculated.Text / counter).ToString("C")
            lblNumGroupsCalculated.Text = (counter).ToString
        Catch
            MessageBox.Show("Please Enter a Valid Number of Minutes!!")
            counter -= 1
        End Try


    End Sub

    'closes the program         
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'clears data from the text boxes, total charged label, and sets focus
    Private Sub btnClearData_Click(sender As Object, e As EventArgs) Handles btnClearData.Click
        txtGroupName.Text = String.Empty
        txtTimeUsed.Text = String.Empty
        lblAmountCharged.Text = "$0.00"
        txtGroupName.Focus()
    End Sub

    'clears the form
    Private Sub btnClearAllData_Click(sender As Object, e As EventArgs) Handles btnClearAllData.Click
        btnClearData.PerformClick()
        counter = 0
        lblTotalChargesCalculated.Text = "$0.00"
        lblAvgChargeCalculated.Text = "$0.00"
        lblNumGroupsCalculated.Text = "0"
    End Sub

    'adds date and time to the form on load 
    Private Sub frmStudioRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim theDate As Date = Today
        stsDateTimeGrp.Text = theDate.ToString("f")

    End Sub

End Class
