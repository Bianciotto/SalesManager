Imports Examen.Datos
Imports Examen.Entidades

Public Class LProducto

    Public Function ListProduct() As List(Of Producto)
        Try
            Dim dProducto As New DProducto()
            Return dProducto.ListProducts()
        Catch ex As Exception
            Console.WriteLine("Error en ListProducts: " & ex.Message)
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

    Public Function AddClient(cliente As Cliente) As Boolean
        Try
            Dim dCliente As New DCliente()
            Return dCliente.AddClient(cliente)
        Catch ex As Exception
            Console.WriteLine("Error en AddClient: " & ex.Message)
            Throw
        End Try
    End Function
    Public Function UpdateClient(cliente As Cliente) As Boolean
        Try
            Dim dCliente As New DCliente()
            Return dCliente.UpdateClient(cliente)
        Catch ex As Exception
            Console.WriteLine("Error en UpdateClient: " & ex.Message)
            Throw
        End Try
    End Function
    Public Function DeleteClient(idCliente As Integer) As Boolean
        Try
            Dim dCliente As New DCliente()
            Return dCliente.DeleteClient(idCliente)
        Catch ex As Exception
            Console.WriteLine("Error en DeleteClient: " & ex.Message)
            Throw
        End Try
    End Function
End Class
