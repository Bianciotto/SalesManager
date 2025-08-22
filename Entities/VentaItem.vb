Public Class VentaItem
    Public Property Id As Integer
    Public Property VentaId As Integer
    Public Property ProductoId As Integer
    Public Property Cantidad As Integer
    Public Property PrecioUnitario As Decimal
    Public Property PrecioTotal As Decimal

    Public Overridable Property Venta As Venta
    Public Overridable Property Producto As Producto
End Class