Public Class VentaItem
    Private _id As Integer
    Private _ventaId As Integer
    Private _productoId As Integer
    Private _cantidad As Integer
    Private _precioUnitario As Decimal
    Private _precioTotal As Decimal

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property VentaId As Integer
        Get
            Return _ventaId
        End Get
        Set(value As Integer)
            _ventaId = value
        End Set
    End Property

    Public Property ProductoId As Integer
        Get
            Return _productoId
        End Get
        Set(value As Integer)
            _productoId = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
        End Set
    End Property

    Public Property PrecioTotal As Decimal
        Get
            Return _precioTotal
        End Get
        Set(value As Decimal)
            _precioTotal = value
        End Set
    End Property
End Class