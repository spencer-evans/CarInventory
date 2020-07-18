Public Class Car
#Region "Properties"
    Shared Count As Integer = 0
    Private ReadOnly IdentificationNumber As Integer = -1
    Private Make As String = String.Empty
    Private Model As String = String.Empty
    Private Year As Integer = 0
    Private Price As Double = 0.0
    Private NewStatus As Boolean = False
#End Region

#Region "Constructors"
    Public Sub New()
        IdentificationNumber = Count
        Count += 1
    End Sub

    Public Sub New(make As String, model As String, year As Integer, price As Double, newStatus As Boolean)
        Me.New()
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Price = price
        Me.NewStatus = newStatus
    End Sub
#End Region

#Region "Property Methods"
    Public Property CarMake() As String
        Get
            Return Make
        End Get
        Set(ByVal value As String)
            Make = value
        End Set
    End Property

    Public Property CarModel() As String
        Get
            Return Model
        End Get
        Set(ByVal value As String)
            Make = Model
        End Set
    End Property

    Public Property CarYear() As Integer
        Get
            Return Year
        End Get
        Set(ByVal value As Integer)
            Year = value
        End Set
    End Property

    Public Property CarPrice() As Double
        Get
            Return Price
        End Get
        Set(ByVal value As Double)
            Price = value
        End Set
    End Property

    Public Property CarNewStatus() As Boolean
        Get
            Return NewStatus
        End Get
        Set(ByVal value As Boolean)
            NewStatus = value
        End Set
    End Property

    Public ReadOnly Property CarID() As Integer
        Get
            Return IdentificationNumber
        End Get
    End Property

    Public ReadOnly Property CarCount() As Integer
        Get
            Return Count
        End Get
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' Returns all attribute of car object as a single string
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property GetCarData() As String
        Get
            Return NewStatus & " " & Year & " " & Make & " " & Model & " costs " & Price
        End Get
    End Property
#End Region
End Class
