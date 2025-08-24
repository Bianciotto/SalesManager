Imports Examen.Entidades
Imports System.Data.SqlClient
Public Class DProduct
    Inherits ApplicationDbContext

    Public Function ListProducts() As List(Of Producto)
        Try
            Dim products As New List(Of Producto)()
            Dim query As String = "SELECT Id, Nombre, Precio, Categoria FROM Productos"
            Using connection As SqlConnection = ApplicationDbContext.GetConnection()
                connection.Open()
                Using command As SqlCommand = New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            products.Add(MapProduct(reader))
                        End While
                    End Using
                End Using
            End Using
            Return products
        Catch ex As Exception
            Console.WriteLine("Error en ListProducts: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function FindProductById(id As Integer) As Producto
        Try
            Dim query As String = "SELECT Id, Nombre, Precio, Categoria FROM Productos WHERE Id = @Id"
            Using connection As SqlConnection = ApplicationDbContext.GetConnection()
                connection.Open()
                Using command As SqlCommand = New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Id", id)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Return MapProduct(reader)
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en FindProductById: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function AddProduct(product As Producto) As Boolean
        Try
            Dim query As String = "INSERT INTO Productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Nombre", product.Nombre)
                    command.Parameters.AddWithValue("@Precio", product.Precio)
                    command.Parameters.AddWithValue("@Categoria", product.Categoria)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en AddProduct: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function UpdateProduct(Product As Producto) As Boolean
        Try
            Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE Id = @Id"
            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Id", Product.Id)
                    command.Parameters.AddWithValue("@Nombre", Product.Nombre)
                    command.Parameters.AddWithValue("@Precio", Product.Precio)
                    command.Parameters.AddWithValue("@Categoria", Product.Categoria)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en UpdateProduct: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function DeleteProduct(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Productos WHERE Id = @Id"
            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Id", id)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en DeleteProduct: " & ex.Message)
            Throw
        End Try
    End Function

    Private Function MapProduct(reader As SqlDataReader) As Producto
        Return New Producto() With {
        .Id = reader.GetInt32(0),
        .Nombre = If(reader.IsDBNull(1), "", reader.GetString(1)),
        .Precio = If(reader.IsDBNull(2), "", reader.GetString(2)),
        .Categoria = If(reader.IsDBNull(3), "", reader.GetString(3))
    }
    End Function


End Class
