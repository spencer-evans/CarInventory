''' <summary>
''' Author: Spencer Evans
''' Date: 2020-07-18
''' 
''' Description: The purpose of this program is to keep track of a car inventory. Users are require to enter the
'''              make, model, year, and price of each car as well as if it is new/used. The program also allows the
'''              user to update previous entries.
'''
''' </summary>

Public Class frmCarInventory

#Region "Variables and Constants"
    Const MIN_PRICE As Double = 0.0 'Minimum price user can enter

    Dim cars As New List(Of Car) 'List to store all cars entered by user
    Dim editMode As Boolean = False ' Specifies if the user is editing an existing entry
    Dim updatingData As Boolean = False
    Dim currentlySelectedIndex As Integer = -1
#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' Automatically populates the "year" drop down list with the past 100 years when the form opens
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmCarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For year As Integer = 0 To 99
            cbYear.Items.Add(2020 - year)
        Next
    End Sub

    ''' <summary>
    ''' Handles enter button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        lblOutput.Text = String.Empty
        Dim inputMake As String = cbMake.Text
        Dim inputModel As String = txtModel.Text
        Dim inputYear As String = cbYear.Text
        Dim inputPrice As String = txtPrice.Text
        Dim inputNewStatus As Boolean = ckNew.Checked
        Dim errors As String = DataValidation(inputMake, inputModel, inputYear, inputPrice)
        Dim car As Car

        If (String.IsNullOrEmpty(errors)) Then
            ' Validation successful
            If (editMode) Then
                ' If user was editing a previous entry assign data at selected the entry's index to the new values
                cars(currentlySelectedIndex).CarModel = inputModel
                cars(currentlySelectedIndex).CarMake = inputMake
                cars(currentlySelectedIndex).CarYear = inputYear
                cars(currentlySelectedIndex).CarPrice = inputPrice
                cars(currentlySelectedIndex).CarNewStatus = inputNewStatus

                UpdateCarList()
                ResetForm()

                lblOutput.Text = "Updated Car Entry"
            Else
                ' If user is not selecting previous entry append new values to list
                car = New Car(inputMake, inputModel, inputYear, inputPrice, inputNewStatus)
                cars.Add(car)
                UpdateCarList()

                ResetForm()

                lblOutput.Text = "Added a new car"
            End If
        Else
            ' Validation unsuccessful. Ouput list of errors
            lblOutput.Text = errors
        End If
    End Sub

    ''' <summary>
    ''' Handles reset button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    ''' <summary>
    ''' Handles exit button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
        Me.Close()
    End Sub

    ''' <summary>
    ''' When listview item is selected program enters edit mode
    ''' Form controls are populated with values of the selected item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvInventory.SelectedIndexChanged
        Dim car As Car

        If (Not lvInventory.FocusedItem Is Nothing) Then
            currentlySelectedIndex = lvInventory.FocusedItem.Index
            car = cars(currentlySelectedIndex)
            editMode = True

            ' Fill form controls with selected data
            cbMake.Text = car.CarMake
            txtModel.Text = car.CarModel
            cbYear.Text = car.CarYear
            txtPrice.Text = car.CarPrice
            ckNew.Checked = car.CarNewStatus

            lblOutput.Text = "Loaded Car data to update"
        End If
    End Sub

    Private Sub ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvInventory.ItemCheck
        If (Not updatingData) Then
            e.NewValue = e.CurrentValue
        End If
    End Sub

#End Region

#Region "Functions"
    ''' <summary>
    ''' Resets all form controls to default state except listview
    ''' </summary>
    ''' <returns></returns>
    Function ResetForm()
        lvInventory.SelectedIndices.Clear()
        cbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        ckNew.Checked = False

        editMode = False

        lblOutput.Text = "Form Reset"
    End Function

    ''' <summary>
    ''' Clears list view and repopulates with updated cars list
    ''' </summary>
    ''' <returns></returns>
    Function UpdateCarList()
        Dim CarListItem As ListViewItem

        updatingData = True
        lvInventory.Items.Clear()

        For Each car As Car In cars
            CarListItem = New ListViewItem

            CarListItem.Checked = car.CarNewStatus
            CarListItem.SubItems.Add(car.CarID)
            CarListItem.SubItems.Add(car.CarMake)
            CarListItem.SubItems.Add(car.CarModel)
            CarListItem.SubItems.Add(car.CarYear)
            CarListItem.SubItems.Add(car.CarPrice)

            lvInventory.Items.Add(CarListItem)
        Next

        updatingData = False

    End Function

    ''' <summary>
    ''' Checks that data is valid and return a string of error messages for any issues
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <returns></returns>
    Function DataValidation(make As String, model As String, year As String, price As String) As String
        Dim errorMessage As String = String.Empty
        Dim numericPrice As Double

        If (String.IsNullOrWhiteSpace(make)) Then
            errorMessage += "Please select a valid make" & Environment.NewLine
        End If

        If (String.IsNullOrWhiteSpace(model)) Then
            errorMessage += "Please enter a valid model" & Environment.NewLine
        End If

        If (String.IsNullOrWhiteSpace(year)) Then
            errorMessage += "Please select a valid year" & Environment.NewLine
        End If

        If (Double.TryParse(price, numericPrice)) Then
            If (numericPrice < MIN_PRICE) Then
                errorMessage += "Please enter a valid price" & Environment.NewLine
            End If
        Else
            errorMessage += "Please enter a valid price" & Environment.NewLine
        End If

        Return errorMessage
    End Function

#End Region

End Class



