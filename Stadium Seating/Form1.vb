Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClassATRevenue.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnCalcRevenue_Click(sender As Object, e As EventArgs) Handles btnCalcRevenue.Click

        ' Declare Constants for seat prices
        Const dblCLASS_A_SEAT_PRICE As Double = 15.0
        Const dblCLASS_B_SEAT_PRICE As Double = 12.0
        Const dblCLASS_C_SEAT_PRICE As Double = 9.0

        Try
            ' Declare variables to hold input data on number of each class of seat sold and assign the data
            Dim dblClassASeatsSold As Double = CDbl(txtClassASeatsSold.Text)
            Dim dblClassBSeatsSold As Double = CDbl(txtClassBSeatsSold.Text)
            Dim dblClassCSeatsSold As Double = CDbl(txtClassCSeatsSold.Text)

            ' Declare variables to hold revenue totals for each class of seat
            Dim dblRevenueA As Double = 0.0
            Dim dblRevenueB As Double = 0.0
            Dim dblRevenueC As Double = 0.0
            Dim dblTotalRevenue As Double = 0.0

            ' Calculate total revenue for each class
            dblRevenueA = dblClassASeatsSold * dblCLASS_A_SEAT_PRICE
            dblRevenueB = dblClassBSeatsSold * dblCLASS_B_SEAT_PRICE
            dblRevenueC = dblClassCSeatsSold * dblCLASS_C_SEAT_PRICE

            ' Calculate total revenue
            dblTotalRevenue = dblRevenueA + dblRevenueB + dblRevenueC

            ' Convert back to strings and output to form
            lblClassATRevenue.Text = dblRevenueA.ToString("c")
            lblClassBRevenue.Text = dblRevenueB.ToString("c")
            lblClassCRevenue.Text = dblRevenueC.ToString("c")

            ' convert total revenue to a string and output it.
            lblTotalRevenue.Text = dblTotalRevenue.ToString("c")
        Catch
            lblStatus.Text = "You must enter numeric data"
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all the text boxes
        txtClassASeatsSold.Clear()
        txtClassBSeatsSold.Clear()
        txtClassCSeatsSold.Clear()

        ' Clear the labels
        lblClassATRevenue.Text = String.Empty
        lblClassBRevenue.Text = String.Empty
        lblClassCRevenue.Text = String.Empty
        lblTotalRevenue.Text = String.Empty

        ' Clear the status window
        lblStatus.Text = String.Empty

        ' return with focus on first text box
        txtClassASeatsSold.Focus()

    End Sub
End Class
