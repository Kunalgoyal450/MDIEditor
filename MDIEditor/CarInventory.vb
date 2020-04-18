' Author: Kunal Goyal
' Date: 23 March 2020
' Description: This is th code for form it takes dt about a car from user and append it lo list which user acan use further to get the information about the car. This is created as a lab requirement for lab 4 for NETD 2202.
'              The code for this form is referred from Professor Kyle Campman's code for his example SmashedCharacters from his Github repository.
'              https://github.com/KyleChapman/SmashCharacters

Option Strict On

Public Class frmCarInventory

#Region "Declarations"
    ' Declarations required for the form
    Dim isCarSelected As Boolean = False ' Boolean variable to tell whether a car is selected in a form or not
    Dim car As Car ' Creating a object of car class
    Dim carList As New List(Of Car) 'List where all objects of class are added
    Dim AddingToListView As Boolean = False 'Boolean for adding the car to list

#End Region

#Region "Event Hadlers"
    ''' <summary>
    ''' Code for reset button to reset the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Code for Enter button to perform the actions
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Checking if the user input is valid using function
        If IsValidInput() = True Then
            lblErrorBox.Text = "The entry is added" 'If user input is correct displa message

            If Not isCarSelected Then 'If car from list is not selected assign the value in boxrs to car
                car = New Car(cmbMake.Text, txtModel.Text, CInt(cmbYear.Text), Convert.ToDecimal(txtPrice.Text), chkNew.Checked)
                carList.Add(car)

            ElseIf car.Id.ToString.Trim.Length > 0 Then

                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = CInt(cmbYear.Text)
                car.Price = Convert.ToDecimal(txtPrice.Text)
                car.Status = chkNew.Checked

            End If

        End If
        SetDefaults()

    End Sub

    ''' <summary>
    ''' Code for exit button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Code for List view box when a car is selected from the box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCarInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarInventory.SelectedIndexChanged
        If lvwCarInventory.SelectedIndices.Count = 1 Then
            car = carList(lvwCarInventory.SelectedIndices(0))
            isCarSelected = True

            cmbMake.Text = car.Make
            txtModel.Text = car.Model
            cmbYear.Text = car.Year.ToString
            txtPrice.Text = car.Price.ToString
            chkNew.Checked = car.Status

            lblErrorBox.Text = car.GetCarData()

        Else
            isCarSelected = False
        End If
    End Sub

    ''' <summary>
    ''' Disaalows user to uncheck or check the box in list view.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCarInventory_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarInventory.ItemCheck
        If Not AddingToListView Then
            e.NewValue = e.CurrentValue
        End If
    End Sub
#End Region

#Region "Procedures"

    ''' <summary>
    ''' Funtion to set the form to its default values.
    ''' </summary>
    Private Sub SetDefaults()
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        lblErrorBox.Text = String.Empty

        PopulateList()

        isCarSelected = False

        txtModel.Focus()
    End Sub

    ''' <summary>
    ''' Funtion to check the values entered by user are correct or not
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim price As Decimal = 0.0D

        If cmbMake.SelectedIndex = -1 Then
            outputMessage += "Car's make must be selected" & vbCrLf
            returnValue = False
        End If

        If cmbYear.SelectedIndex = -1 Then
            outputMessage += "Car's manufacturing year must be selected." & vbCrLf
            returnValue = False
        End If

        If txtModel.Text.Trim.Length = 0 Then
            outputMessage += "Enter car's model" & vbCrLf
            returnValue = False
        End If

        If txtPrice.Text.Trim.Length = 0 Then
            outputMessage += "Enter car's price." & vbCrLf
            returnValue = False
        ElseIf Not (Decimal.TryParse(txtPrice.Text, price) And price > 0) Then
            outputMessage = "Price must be numeric and greater than 0." & vbCrLf
            returnValue = False
        End If

        If returnValue = False Then
            lblErrorBox.Text = "ERRORS" & vbCrLf & outputMessage
        End If

        Return returnValue

    End Function

    ''' <summary>
    ''' This populates and clears the list of my form 
    ''' </summary>
    Sub PopulateList()

        lvwCarInventory.Items.Clear()

        For index As Integer = 0 To carList.Count - 1

            Dim carItem As New ListViewItem()

            carItem.SubItems.Add(carList(index).Id.ToString)
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString)
            carItem.SubItems.Add(carList(index).Price.ToString)
            carItem.Checked = carList(index).Status

            AddingToListView = True

            lvwCarInventory.Items.Add(carItem)

            AddingToListView = False

        Next


    End Sub



#End Region
End Class
