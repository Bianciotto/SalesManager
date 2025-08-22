Public Class Producto
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property PrecioUnitario As Decimal

    Public Overridable Property VentaItems As List(Of VentaItem)
End Class
