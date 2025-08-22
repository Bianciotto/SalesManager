Public Class Venta
    Public Property Id As Integer
    Public Property Fecha As DateTime
    Public Property ClienteId As Integer

    Public Overridable Property Cliente As Cliente
    Public Overridable Property Items As List(Of VentaItem)
End Class