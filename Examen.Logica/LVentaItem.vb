Imports Examen.Datos
Imports Examen.Entidades

Public Class LVentaItem
    Private ReadOnly dVentaItem As New DVentaItem()

    Public Function GetSaleItemsBySaleId(idVenta As Integer) As List(Of VentaItem)
        If idVenta <= 0 Then
            Throw New ArgumentException("El ID de la venta debe ser mayor a cero.")
        End If

        Try
            Return dVentaItem.GetSaleItemsBySaleId(idVenta)
        Catch ex As Exception
            Throw New Exception("Error al obtener los ítems de la venta desde la lógica: " & ex.Message)
        End Try
    End Function

    Public Function AddVentaItem(item As VentaItem) As Boolean
        If item Is Nothing Then
            Throw New ArgumentNullException(NameOf(item))
        End If

        If item.IDVenta <= 0 Then
            Throw New ArgumentException("El ID de la venta debe ser mayor que cero.", NameOf(item.IDVenta))
        End If

        If item.IDProducto <= 0 Then
            Throw New ArgumentException("El ID del producto debe ser mayor que cero.", NameOf(item.IDProducto))
        End If

        If item.Cantidad <= 0 OrElse item.PrecioUnitario <= 0 Then
            Console.WriteLine("Cantidad y PrecioUnitario deben ser mayores que cero.")
            Return False
        End If

        Dim totalCalc = item.Cantidad * item.PrecioUnitario
        If item.PrecioTotal <> totalCalc Then
            item.PrecioTotal = totalCalc
        End If

        Return dVentaItem.AddVentaItem(item)
    End Function

    Public Function UpdateVentaItem(item As VentaItem) As Boolean

        If item Is Nothing Then
            Throw New ArgumentNullException(NameOf(item))
        End If

        If item.ID <= 0 Then
            Throw New ArgumentException("El ID debe ser mayor que cero.", NameOf(item.ID))
        End If

        If item.Cantidad <= 0 OrElse item.PrecioUnitario <= 0 Then
            Console.WriteLine("Cantidad y precio unitario deben ser mayores que cero.")
            Return False
        End If

        Dim totalCalc = item.Cantidad * item.PrecioUnitario
        If item.PrecioTotal <> totalCalc Then
            item.PrecioTotal = totalCalc
        End If

        Return dVentaItem.UpdateVentaItem(item)
    End Function

    Public Function DeleteVentaItem(idItem As Integer) As Boolean
        If idItem <= 0 Then
            Throw New ArgumentException("El ID debe ser mayor que cero.", NameOf(idItem))
        End If

        Try
            Return dVentaItem.DeleteVentaItem(idItem)
        Catch ex As Exception
            Console.WriteLine("Error en lógica DeleteVentaItem: " & ex.Message)
            Throw
        End Try
    End Function

End Class

