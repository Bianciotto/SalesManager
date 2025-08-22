Public Class Cliente
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Direccion As String
    Public Property Telefono As String

    Public Overridable Property Ventas As List(Of Venta)

End Class
