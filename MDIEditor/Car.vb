' Author: Kunal Goyal
' Date: 16 March 2020
' Description: This class repersent a Car object which has properties like make, model, year, price and new
'              created for Lab 4 for NETD 2202.
'              The code of this class is written with the help of video provided by the Kyle.
'              https://www.twitch.tv/videos/566065081

Option Strict On

Public Class Car
#Region "Vaiable declarations"

    Private Shared carCount As Integer = 0
    Private carId As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carStatus As Boolean = True

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default constructor to increase the car count
    ''' </summary>
    Friend Sub New()
        carCount += 1
        carId = carCount
    End Sub

    ''' <summary>
    ''' Sets all private variable on arguments passed in
    ''' </summary>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, statusValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carStatus = statusValue

    End Sub

#End Region

#Region "Property Procedures"

    ''' <summary>
    ''' Returns the number of car objects
    ''' </summary>
    ''' <returns></returns>
    Private Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property


    ''' <summary>
    ''' Returns the car's unique ID
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Id() As Integer
        Get
            Return carId
        End Get
    End Property


    ''' <summary>
    ''' Returns the manufacturer of car
    ''' </summary>
    ''' <returns></returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the model of the car
    ''' </summary>
    ''' <returns></returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the year of making of car
    ''' </summary>
    ''' <returns></returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the price of the car
    ''' </summary>
    ''' <returns></returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the status of car whether the car is new or old
    ''' </summary>
    ''' <returns></returns>
    Public Property Status() As Boolean
        Get
            Return carStatus
        End Get
        Set(value As Boolean)
            carStatus = value
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' returns a string describing the car
    ''' </summary>
    ''' <returns></returns>
    Friend Function GetCarData() As String

        Return IIf(carStatus, "New ", "Used ").ToString & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")

    End Function

#End Region

End Class
