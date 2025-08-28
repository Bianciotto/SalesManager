Imports Examen.Entidades
Imports System.Data.SqlClient

Public Class DVenta
    Inherits ApplicationDbContext

    Public Function AddSale(venta As Venta) As Integer
        Try
            Dim query As String = "
            INSERT INTO Ventas (IDCliente, Fecha, Total)
            VALUES (@IDCliente, @Fecha, @Total);
            SELECT SCOPE_IDENTITY();"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@IDCliente", venta.IdCliente)
                    command.Parameters.AddWithValue("@Fecha", If(venta.Fecha IsNot Nothing, venta.Fecha, DBNull.Value))
                    command.Parameters.AddWithValue("@Total", If(venta.Total IsNot Nothing, venta.Total, DBNull.Value))

                    Dim newId As Integer = ExecuteInsertAndGetId(command)
                    Return newId
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function ExecuteInsertAndGetId(command As SqlCommand) As Integer
        Try
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), Nothing) Then
                Return Convert.ToInt32(result)
            Else
                Console.WriteLine("Error: No se pudo obtener un ID válido desde ExecuteScalar.")
                Return -1
            End If
        Catch ex As Exception
            Console.WriteLine($"Error en ExecuteInsertAndGetId: {ex.Message}")
            Return -1
        End Try
    End Function

    Public Function ReadVentaById(id As Integer) As Venta
        Try
            Dim query As String = "SELECT ID, IDCliente, Fecha, Total FROM Venta WHERE ID = @ID"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@ID", id)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Return New Venta With {
                            .Id = Convert.ToInt32(reader("ID")),
                            .IdCliente = Convert.ToInt32(reader("IDCliente")),
                            .Fecha = If(IsDBNull(reader("Fecha")), Nothing, Convert.ToDateTime(reader("Fecha"))),
                            .Total = Convert.ToDouble(reader("Total"))
                        }
                        Else
                            Console.WriteLine($"Venta no encontrada (ID={id})")
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error en ReadVentaById (ID={id}): {ex.Message}")
            Throw
        End Try
    End Function

    Public Function UpdateVenta(venta As Venta) As Boolean
        Try
            Dim query As String = "
            UPDATE Ventas 
            SET IDCliente = @IDCliente, 
                Fecha = @Fecha, 
                Total = @Total 
            WHERE ID = @ID"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@ID", venta.Id)
                    command.Parameters.AddWithValue("@IDCliente", venta.IdCliente)
                    command.Parameters.AddWithValue("@Fecha", If(venta.Fecha, DBNull.Value))
                    command.Parameters.AddWithValue("@Total", If(venta.Total, DBNull.Value))

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Console.WriteLine($"Venta actualizada (ID={venta.Id}). Filas afectadas: {rowsAffected}")
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error en UpdateVenta (ID={venta.Id}): {ex.Message}")
            Throw
        End Try
    End Function

    Public Function DeleteVenta(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Ventas WHERE ID = @ID"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@ID", id)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Console.WriteLine($"Venta eliminada (ID={id}). Filas afectadas: {rowsAffected}")
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error en DeleteVenta (ID={id}): {ex.Message}")
            Throw
        End Try
    End Function

    Public Function GetSalesByClientId(idCliente As Integer) As List(Of Venta)
        Dim ventas As New List(Of Venta)()

        Try
            Dim query As String = "
            SELECT ID, Fecha, Total
            FROM Ventas
            WHERE IDCliente = @IDCliente
            ORDER BY Fecha DESC"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@IDCliente", idCliente)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim venta As New Venta() With {
                            .Id = Convert.ToInt32(reader("ID")),
                            .Fecha = Convert.ToDateTime(reader("Fecha")),
                            .Total = Convert.ToDecimal(reader("Total"))
                        }
                            ventas.Add(venta)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las ventas del cliente: " & ex.Message)
        End Try

        Return ventas
    End Function
End Class
