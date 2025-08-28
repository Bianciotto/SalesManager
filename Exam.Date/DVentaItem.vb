Imports Examen.Entidades
Imports System.Data.SqlClient
Public Class DVentaItem
    Inherits ApplicationDbContext

    Public Function AddVentaItem(item As VentaItem) As Boolean
        Try
            Dim query As String = "
            INSERT INTO VentasItems (IDVenta, IDProducto, Cantidad, PrecioUnitario, PrecioTotal)
            VALUES (@IDVenta, @IDProducto, @Cantidad, @PrecioUnitario, @PrecioTotal)"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    With command.Parameters
                        .Add(New SqlParameter("@IDVenta", SqlDbType.Int)).Value = item.IDVenta
                        .Add(New SqlParameter("@IDProducto", SqlDbType.Int)).Value = item.IDProducto
                        .Add(New SqlParameter("@Cantidad", SqlDbType.Float)).Value = item.Cantidad
                        .Add(New SqlParameter("@PrecioUnitario", SqlDbType.Float)).Value = item.PrecioUnitario
                        .Add(New SqlParameter("@PrecioTotal", SqlDbType.Float)).Value = item.PrecioTotal
                    End With

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As SqlException
            Console.WriteLine($"SQL Error en AddVentaItem: {ex.Number} - {ex.Message}")
            Return False
        Catch ex As Exception
            Console.WriteLine($"Error general en AddVentaItem: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function UpdateVentaItem(item As VentaItem) As Boolean
        Dim query As String = "
        UPDATE VentasItems 
        SET IDVenta       = @IDVenta,
            IDProducto    = @IDProducto,
            Cantidad      = @Cantidad,
            PrecioUnitario= @PrecioUnitario,
            PrecioTotal   = @PrecioTotal
        WHERE ID = @ID"

        Using conn As SqlConnection = ApplicationDbContext.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                With cmd.Parameters
                    .Add("@ID", SqlDbType.Int).Value = item.ID
                    .Add("@IDVenta", SqlDbType.Int).Value = item.IDVenta
                    .Add("@IDProducto", SqlDbType.Int).Value = item.IDProducto
                    .Add("@Cantidad", SqlDbType.Float).Value = item.Cantidad
                    .Add("@PrecioUnitario", SqlDbType.Float).Value = item.PrecioUnitario
                    .Add("@PrecioTotal", SqlDbType.Float).Value = item.PrecioTotal
                End With
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DeleteVentaItem(id As Integer) As Boolean
        Try

            Dim query As String = "DELETE FROM VentasItems WHERE ID = @ID"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = id

                    Return command.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As SqlException
            Console.WriteLine($"SQL Error en DeleteVentaItem: {ex.Number} - {ex.Message}")
            Return False
        Catch ex As Exception
            Console.WriteLine($"Error general en DeleteVentaItem: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function GetSaleItemsBySaleId(idVenta As Integer) As List(Of VentaItem)
        Dim listaItems As New List(Of VentaItem)

        Try
            Dim query As String = "
        SELECT ID, IDProducto, Cantidad, PrecioUnitario, PrecioTotal
        FROM VentasItems
        WHERE IDVenta = @IDVenta"

            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.Add(New SqlParameter("@IDVenta", SqlDbType.Int)).Value = idVenta

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim item As New VentaItem With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .IDProducto = Convert.ToInt32(reader("IDProducto")),
                            .Cantidad = Convert.ToDouble(reader("Cantidad")),
                            .PrecioUnitario = Convert.ToDouble(reader("PrecioUnitario")),
                            .PrecioTotal = Convert.ToDouble(reader("PrecioTotal"))
                        }
                            listaItems.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As SqlException
            Console.WriteLine($"SQL Error en GetSaleItemsBySaleId: {ex.Number} - {ex.Message}")
        Catch ex As Exception
            Console.WriteLine($"Error general en GetSaleItemsBySaleId: {ex.Message}")
        End Try

        Return listaItems
    End Function




End Class
