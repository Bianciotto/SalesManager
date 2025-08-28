Public Class Venta
    Private _iD As Integer
    Private _iDCliente As Integer
    Private _fecha As DateTime
    Private _total As Decimal

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(value As Integer)
            _iD = value
        End Set
    End Property

    Public Property IDCliente As Integer
        Get
            Return _iDCliente
        End Get
        Set(value As Integer)
            _iDCliente = value
        End Set
    End Property

    Public Property Fecha As DateTime?
        Get
            Return _fecha
        End Get
        Set(value As DateTime?)
            _fecha = value
        End Set
    End Property

    Public Property Total As Decimal?
        Get
            Return _total
        End Get
        Set(value As Decimal?)
            _total = value
        End Set
    End Property
End Class