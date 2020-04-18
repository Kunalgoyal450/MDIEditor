' Author: Kunal Goyal
' Date: February 26, 2020
' Description: 
'   This program takes the number of units shipped by an employee per day and calculate average for the employee and for overall per day.

Option Strict On
Public Class frmAverageUnitsShippedByEmployee

    ' Variable Declarations
    Dim day As Integer = 0
    Dim employeeNumber As Integer = 0
    Dim averageUnitsShippedByEmployee As Double
    Dim totalUnitsShippedByEmployee As Integer
    Dim totalUnitsShipped As Integer
    Dim averageUnitsShipped As Double

    Const DaysInWeek As Integer = 7
    Const NumberOfEmployees As Integer = 3

    Dim unitsShipped(NumberOfEmployees - 1, DaysInWeek - 1) As Integer

    Dim outputLabelArray() As Label
    Dim outputTextboxArray() As TextBox


    ''' <summary>
    ''' When form loads, initilazing arrays of controls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputLabelArray = {lblEmployee1AverageOutput, lblEmployee2AverageOutput, lblEmployee3AverageOutput}
        outputTextboxArray = {txtUnitsEmployee1, txtUnitsEmployee2, txtUnitsEmployee3}
    End Sub


    ''' <summary>
    ''' Exit button code for closing the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Code for reset button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' code for enter button. validate the user data and calculate averages
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Variable declarations specific to calculation
        Dim currentUnits As Integer
        Const MinimumUnitRequirement As Integer = 0
        Const MaximumUnitRequirement As Integer = 5000

        ' Checking if user input is numeric.
        If Integer.TryParse(txtUnitsInput.Text, unitsShipped(employeeNumber, day)) Then

            'Parsing user input in currentunits
            currentUnits = unitsShipped(employeeNumber, day)
            ' Checking if value of currentUnits is between 0 and 5000
            If currentUnits >= MinimumUnitRequirement And currentUnits <= MaximumUnitRequirement Then

                'output the units value and day
                outputTextboxArray(employeeNumber).Text &= unitsShipped(employeeNumber, day) & vbCrLf

                'Increment the day and clear the textbox.
                day += 1
                txtUnitsInput.Clear()

                ' If day is equal to 7, calculate average for employee
                If day = DaysInWeek Then

                    totalUnitsShippedByEmployee = 0

                    For dayConter As Integer = 0 To DaysInWeek - 1
                        totalUnitsShippedByEmployee += unitsShipped(employeeNumber, dayConter)
                    Next

                    ' Average calculation
                    averageUnitsShippedByEmployee = totalUnitsShippedByEmployee / DaysInWeek
                    'Output the average
                    outputLabelArray(employeeNumber).Text = CStr(Math.Round(averageUnitsShippedByEmployee, 2))

                    'Setting the day value back and incresing the employee number
                    day = 0
                    employeeNumber += 1

                End If

                'Conting the days
                lblDay.Text = "Day " & (day + 1)

                'If all employees are done
                If employeeNumber = NumberOfEmployees Then

                    totalUnitsShipped = 0

                    For Each units In unitsShipped
                        totalUnitsShipped += units
                    Next

                    'Total average per day combining all three emplyees and output it to the label
                    averageUnitsShipped = totalUnitsShipped / unitsShipped.Length
                    lblAveragePerDayOutput.Text = "Average: " & Math.Round(averageUnitsShipped, 2)

                    'Disable the Controls
                    txtUnitsInput.Enabled = False
                    btnEnter.Enabled = False
                    btnReset.Focus()

                End If
            Else
                'If entry is out of range show message and reset focus.
                MessageBox.Show("Units must be between 0 and 5000.")
                txtUnitsInput.SelectAll()
                txtUnitsInput.Focus()

            End If

        Else
            'If entry is non-numeric show message and reset focus.
            MessageBox.Show("Units value must be a whole number.")
            txtUnitsInput.SelectAll()
            txtUnitsInput.Focus()

        End If

    End Sub
    ''' <summary>
    ''' Procedure to clear array of controls
    ''' </summary>
    ''' <param name="contrlArray"></param>
    Sub ClearControls(contrlArray As Control())

        For Each controlToClear As Control In contrlArray
            controlToClear.Text = String.Empty
        Next

    End Sub

    ''' <summary>
    ''' Sub procedure to reset the form
    ''' </summary>
    Sub SetDefaults()

        ' Clear input and output fields
        ClearControls(outputTextboxArray) ' Calls to empty all input textboxes
        ClearControls(outputLabelArray) 'Calls to empty all output labels
        lblAveragePerDayOutput.Text = String.Empty ' Empty the label containg average units shipped
        day = 0                              ' Set day to 0
        employeeNumber = 0                            ' Set employee number to 0
        lblDay.Text = "Day " & (day + 1)


        ' Re-enable any controls disabled
        txtUnitsInput.Enabled = True
        btnEnter.Enabled = True

        ' Set focus to input text box
        txtUnitsInput.Focus()

    End Sub
End Class
