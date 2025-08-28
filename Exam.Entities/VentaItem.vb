Public Class VentaItem
    Private _iD As Integer
    Private _iDVenta As Integer
    Private _IDProducto As Integer
    Private _cantidad As Integer
    Private _precioUnitario As Decimal
    Private _precioTotal As Decimal

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(value As Integer)
            _iD = value
        End Set
    End Property

    Public Property IDVenta As Integer
        Get
            Return _iDVenta
        End Get
        Set(value As Integer)
            _iDVenta = value
        End Set
    End Property

    Public Property IDProducto As Integer
        Get
            Return _IDProducto
        End Get
        Set(value As Integer)
            _IDProducto = value
        End Set
    End Property

    Public Property Cantidad As Integer?
        Get
            Return _cantidad
        End Get
        Set(value As Integer?)
            _cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal?
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal?)
            _precioUnitario = value
        End Set
    End Property

    Public Property PrecioTotal As Decimal?
        Get
            Return _precioTotal
        End Get
        Set(value As Decimal?)
            _precioTotal = value
        End Set
    End Property
End Class