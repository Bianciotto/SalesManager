Imports System.Globalization
Imports Examen.Datos
Imports Examen.Entidades
Public Class LProducto

    Public Function ListProduct() As Object
        Try
            Dim dProducto As New DProducto()
            Dim productosOriginales As List(Of Producto) = dProducto.ListProducts()

            Dim productosAdaptados = productosOriginales.Select(Function(p) New With {
            p.Id,
            p.Nombre,
            .Precio = FormatPrice(p.Precio),
            p.Categoria
        }).ToList()

            Return productosAdaptados
        Catch ex As Exception
            Console.WriteLine("Error en ListProductAdaptado: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function FindProductsByCoincidence(parameter As String) As List(Of Producto)
        Try
            Dim dProducto As New DProducto()
            Return dProducto.FindProductsByCoincidence(parameter)
        Catch ex As Exception
            Console.WriteLine("Error en FindProductsByCoincidence: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function AddProduct(name As String, price As String, category As String) As Boolean
        Dim product As New Examen.Entidades.Producto With {
                    .Nombre = ValidateName(name),
                    .Precio = If(String.IsNullOrWhiteSpace(price), Nothing, ConvertToDecimal(price)),
                    .Categoria = If(String.IsNullOrWhiteSpace(category), Nothing, category)
                    }
        Try
            Dim dProducto As New DProducto()
            Return dProducto.AddProduct(product)
        Catch ex As Exception
            Console.WriteLine("Error en AddProducto: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function UpdateProduct(product As Producto) As Boolean
        Try
            Dim dProduct As New DProducto()
            Return dProduct.UpdateProduct(product)
        Catch ex As Exception
            Console.WriteLine("Error en UpdateProducto: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function DeleteProduct(idProducto As Integer) As Boolean
        Try
            Dim dProducto As New DProducto()
            Return dProducto.DeleteProduct(idProducto)
        Catch ex As Exception
            Console.WriteLine("Error en DeleteProducto: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function FormatPrice(precio As Nullable(Of Decimal)) As String
        If Not precio.HasValue Then
            Return ""
        Else
            Dim cultura As New CultureInfo("es-AR")
            Return precio.Value.ToString("C", cultura)
        End If
    End Function

    Private Function ValidateName(name As String) As String
        If String.IsNullOrWhiteSpace(name) Then
            Throw New ArgumentException("El nombre no puede estar vacío.")
        End If
        Return name
    End Function

    Private Function ConvertToDecimal(stringPrice As String) As Decimal
        Console.WriteLine("Convirtiendo precio: " & stringPrice & "creo que es aca elo problema")
        If String.IsNullOrWhiteSpace(stringPrice) Then
            Throw New ArgumentException("El valor a convertir no puede estar vacío.")
        End If
        Console.WriteLine("Convirtiendo precio: " & stringPrice & "creo que es aca elo problema")
        Dim resultado As Decimal
        If Decimal.TryParse(stringPrice, resultado) Then
            Return resultado
        Else
            Throw New FormatException("El valor ingresado no tiene un formato decimal válido.")
        End If
    End Function

End Class
