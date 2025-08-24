Public Class Venta
    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As DateTime
    Private _total As Decimal

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property
End Class