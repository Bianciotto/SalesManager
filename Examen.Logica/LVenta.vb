Imports Examen.Entidades
Imports Examen.Datos

Public Class LVenta
    Private ReadOnly dVenta As New DVenta()

    Public Function AddSale(sale As Venta) As Integer
        Try
            Dim idCliente As Integer = dVenta.AddSale(sale)
            Return idCliente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetSalesByClientId(idCliente As Integer) As List(Of Venta)
        Try
            Return DVenta.GetSalesByClientId(idCliente)
        Catch ex As Exception
            Throw New Exception("Error al obtener las ventas del cliente desde la capa lógica: " & ex.Message)
        End Try
    End Function

    Public Function DeleteSaleByID(idVenta As Integer) As Boolean
        Try
            Return dVenta.DeleteVenta(idVenta)
        Catch ex As Exception
            Console.WriteLine("Error en lógica al eliminar venta: " & ex.Message)
            Return False
        End Try
    End Function

End Class
