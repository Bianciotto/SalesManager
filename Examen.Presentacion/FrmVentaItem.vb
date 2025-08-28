Imports System.Globalization
Imports Examen.Entidades
Imports Examen.Logica
Public Class FrmVentaItem

#Region "Variables_Globales"
    Private totalVentaActual As Decimal = 0D
    Private idClient As Integer
    Private filaSeleccionadaEdit As DataGridViewRow
    Private idVentaEdit As Integer
    Private PosRelativeLblTotalSaleItemTabSell As RectangleF
    Private PosRelativeLblTotalTitelSaleItemTabSell As RectangleF
    Private PosRelativeBtnFindClientSaleItemTabSell As RectangleF
    Private PosRelativeLblFindClientSaleItemTabSell As RectangleF
    Private PosRelativeTextbFindClientSaleItemTabSell As RectangleF
    Private PosRelativeLblDataClientSaleItemTabSell As RectangleF
    Private PosRelativeBtnFindProductSaleItemTabSell As RectangleF
    Private PosRelativeLblFindProductSaleItemTabSell As RectangleF
    Private PosRelativeTextbFindProductSaleItemTabSell As RectangleF
    Private PosRelativeLblTotalProductSaleItemTabSell As RectangleF
#End Region


#Region "Init"

    Private Sub FrmVentaItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDgvListProductAddSaleItemTabSell()
        InitDgvListProductSaleItemTabSell()
        InitDgvListItemSaleItemTabEdit()
        InitDgvListSaleSaleItemTabEdit()
        LoadDgvListProductSaleItemTabSell()
    End Sub

    Private Sub InitDgvListProductAddSaleItemTabSell()
        With DgvListProductAddSaleItemTabSell
            .Columns.Clear()
            .Columns.AddRange(
            New DataGridViewTextBoxColumn() With {.Name = "Id", .HeaderText = "Id", .ReadOnly = True, .Width = 50},
            New DataGridViewTextBoxColumn() With {.Name = "Nombre", .HeaderText = "Nombre", .ReadOnly = True, .Width = 150},
            New DataGridViewTextBoxColumn() With {.Name = "Precio", .HeaderText = "Precio", .ReadOnly = True, .Width = 80, .DefaultCellStyle = New DataGridViewCellStyle() With {.Format = "C2"}},
            New DataGridViewTextBoxColumn() With {.Name = "Categoria", .HeaderText = "Categoría", .ReadOnly = True, .Width = 100},
            New DataGridViewTextBoxColumn() With {.Name = "Cantidad", .HeaderText = "Cantidad", .ReadOnly = False, .Width = 70},
            New DataGridViewTextBoxColumn() With {.Name = "Subtotal", .HeaderText = "Subtotal", .ReadOnly = True, .Width = 90, .DefaultCellStyle = New DataGridViewCellStyle() With {.Format = "C2"}},
            New DataGridViewButtonColumn() With {.Name = "Quitar", .HeaderText = "Quitar", .Text = "🗑 Quitar", .UseColumnTextForButtonValue = True, .ReadOnly = True, .Width = 80}
        )

            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub InitDgvListItemSaleItemTabEdit()
        With DgvListItemSaleItemTabEdit
            .Columns.Clear()

            .Columns.AddRange(
            New DataGridViewTextBoxColumn With {.Name = "IDItem", .HeaderText = "IDItem", .ReadOnly = True, .Width = 50},
            New DataGridViewTextBoxColumn With {.Name = "IDProducto", .HeaderText = "IDProducto", .ReadOnly = True, .Width = 150},
            New DataGridViewTextBoxColumn With {.Name = "Precio", .HeaderText = "Precio", .ReadOnly = True, .Width = 80, .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "C2"}},
            New DataGridViewTextBoxColumn With {.Name = "Cantidad", .HeaderText = "Cantidad", .ValueType = GetType(Integer), .ReadOnly = True, .Width = 70, .DefaultCellStyle = New DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight}},
            New DataGridViewTextBoxColumn With {.Name = "SubTotal", .HeaderText = "SubTotal", .ValueType = GetType(String), .ReadOnly = True, .Width = 90, .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "C2", .Alignment = DataGridViewContentAlignment.MiddleRight}
            }
        )

            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub InitDgvListProductSaleItemTabSell()
        With DgvListProductSaleItemTabSell
            .Columns.Clear()

            .Columns.AddRange(
            New DataGridViewTextBoxColumn With {.Name = "Id", .HeaderText = "Id", .ReadOnly = True, .Width = 50},
            New DataGridViewTextBoxColumn With {.Name = "Nombre", .HeaderText = "Nombre", .ReadOnly = True, .Width = 150},
            New DataGridViewTextBoxColumn With {.Name = "Precio", .HeaderText = "Precio", .ReadOnly = True, .Width = 80, .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "C2"}},
            New DataGridViewTextBoxColumn With {.Name = "Categoria", .HeaderText = "Categoría", .ReadOnly = True, .Width = 100},
            New DataGridViewTextBoxColumn With {.Name = "Cantidad", .HeaderText = "Cantidad", .ValueType = GetType(Integer), .Width = 70, .DefaultCellStyle = New DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight}},
            New DataGridViewButtonColumn With {.Name = "Agregar", .HeaderText = "Agregar", .Text = "Agregar", .UseColumnTextForButtonValue = True, .ReadOnly = True, .Width = 80},
            New DataGridViewTextBoxColumn With {
                .Name = "SubTotal",
                .HeaderText = "SubTotal",
                .ValueType = GetType(String),
                .ReadOnly = True,
                .Width = 90,
                .DefaultCellStyle = New DataGridViewCellStyle With {
                    .Format = "C2",
                    .Alignment = DataGridViewContentAlignment.MiddleRight,
                    .NullValue = FormatPrice(0D)
                }
            }
        )

            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub InitDgvListSaleSaleItemTabEdit()
        With DgvListSaleSaleItemTabEdit
            .Columns.Clear()
            .AutoGenerateColumns = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False

            Dim colSeleccionar As New DataGridViewCheckBoxColumn With {
                .Name = "Seleccionar",
                .HeaderText = "Seleccionar",
                .DataPropertyName = "Seleccionar",
                .Width = 80
            }
            .Columns.Add(colSeleccionar)

            Dim colId As New DataGridViewTextBoxColumn With {
                .Name = "ID",
                .HeaderText = "IDVenta",
                .DataPropertyName = "ID",
                .Width = 60
            }
            .Columns.Add(colId)

            Dim colFecha As New DataGridViewTextBoxColumn With {
                .Name = "Fecha",
                .HeaderText = "Fecha",
                .DataPropertyName = "Fecha",
                .Width = 100
            }
            .Columns.Add(colFecha)

            Dim colTotal As New DataGridViewTextBoxColumn With {
                .Name = "Total",
                .HeaderText = "Total",
                .DataPropertyName = "Total"
            }
            colTotal.DefaultCellStyle.Format = "C2"
            colTotal.Width = 100
            .Columns.Add(colTotal)
        End With
    End Sub

    Private Sub LoadDgvListProductSaleItemTabSell()
        Try
            Dim lProduct As New Examen.Logica.LProducto()
            Dim listaProductos = lProduct.ListProduct()

            DgvListProductSaleItemTabSell.Rows.Clear()

            For Each prod In listaProductos
                DgvListProductSaleItemTabSell.Rows.Add(
                prod.Id,
                prod.Nombre,
                prod.Precio,
                prod.Categoria,
                0,
                "Agregar",
                FormatPrice(0D)
            )
            Next

            LblTotalProductSaleItemTabSell.Text = "Total de Registros: " & listaProductos.Count.ToString()

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "OnlyBtn_Press"


    Private Sub DgvListProductSaleItemTabSell_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvListProductSaleItemTabSell.EditingControlShowing
        If DgvListProductSaleItemTabSell.CurrentCell.ColumnIndex = DgvListProductSaleItemTabSell.Columns("Cantidad").Index Then
            Dim txtBox As TextBox = TryCast(e.Control, TextBox)
            If txtBox IsNot Nothing Then
                RemoveHandler txtBox.KeyDown, AddressOf ValidarCantidadKeyDown
                AddHandler txtBox.KeyDown, AddressOf ValidarCantidadKeyDown

                RemoveHandler txtBox.KeyPress, AddressOf ValidarCantidadKeyPress
                AddHandler txtBox.KeyPress, AddressOf ValidarCantidadKeyPress
            End If
        End If
    End Sub

    Private Sub ValidarCantidadKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Sub ValidarCantidadKeyPress(sender As Object, e As KeyPressEventArgs)
        Dim txtBox As TextBox = DirectCast(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        If txtBox.SelectionStart = 0 AndAlso e.KeyChar = "0"c Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub BtnFindProductSaleItemTabSell_Click(sender As Object, e As EventArgs) Handles BtnFindProductSaleItemTabSell.Click
        FindProductsByCoincidence()
    End Sub

    Private Sub BtnFindClientSaleItemTabSell_Click(sender As Object, e As EventArgs) Handles BtnFindClientSaleItemTabSell.Click
        FindClientById(TextbFindClientSaleItemTabSell, LblDataClientSaleItemTabSell)
    End Sub


    Private Sub TextbFindProductSaleItemTabSell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextbFindProductSaleItemTabSell.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Console.WriteLine("Detectado Enter en TextbFindProductSaleItemTabSell")
            FindClientById(TextbFindClientSaleItemTabSell, LblFindClientSaleItemTabSell)
        End If
    End Sub

    Private Sub BtnCancelSellSaleItemTabSell_Click(sender As Object, e As EventArgs) Handles BtnCancelSellSaleItemTabSell.Click
        DgvListProductAddSaleItemTabSell.Rows.Clear()
        totalVentaActual = 0D
        ActualizarLabelTotal()
    End Sub

    Private Sub TextbFindClientSaleItemTabSell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextbFindClientSaleItemTabSell.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        If TextbFindClientSaleItemTabSell.TextLength = 0 AndAlso e.KeyChar = "0"c Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim idVentaSeleccionada As Integer = -1
            For Each fila As DataGridViewRow In DgvListSaleSaleItemTabEdit.Rows
                If fila.Cells("Seleccionar").Value IsNot Nothing AndAlso Convert.ToBoolean(fila.Cells("Seleccionar").Value) Then
                    idVentaSeleccionada = Convert.ToInt32(fila.Cells("ID").Value)
                    Exit For
                End If
            Next

            If idVentaSeleccionada <= 0 Then
                MessageBox.Show("Debe seleccionar una venta marcando el checkbox.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim itemsEliminados As Boolean = DeleteAllItemsOfSale(idVentaSeleccionada)

            If Not itemsEliminados Then
                MessageBox.Show("No se pudieron eliminar los ítems de la venta. La venta no será eliminada.", "Error en ítems", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim lVenta As New LVenta()
            Dim ventaEliminada As Boolean = lVenta.DeleteSaleByID(idVentaSeleccionada)

            If ventaEliminada Then
                MessageBox.Show("La venta y sus ítems fueron eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If DgvListSaleSaleItemTabEdit.DataSource IsNot Nothing Then
                    Dim tabla = TryCast(DgvListSaleSaleItemTabEdit.DataSource, DataTable)
                    If tabla IsNot Nothing Then
                        tabla.Rows.Clear()
                    Else
                        DgvListSaleSaleItemTabEdit.Rows.Clear()
                    End If
                End If

                If DgvListItemSaleItemTabEdit.DataSource IsNot Nothing Then
                    Dim tabla = TryCast(DgvListItemSaleItemTabEdit.DataSource, DataTable)
                    If tabla IsNot Nothing Then
                        tabla.Rows.Clear()
                    Else
                        DgvListItemSaleItemTabEdit.Rows.Clear()
                    End If
                End If

            Else
                MessageBox.Show("No se pudo eliminar la venta. Verifique si está vinculada a otros registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al procesar la eliminación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Funtions For Responsive"

    Public Function ObtenerPosicionRelativa(control As Control, contenedor As Control) As RectangleF
        If control Is Nothing OrElse contenedor Is Nothing Then Return RectangleF.Empty

        Dim xRelativo As Single = control.Left / contenedor.Width
        Dim yRelativo As Single = control.Top / contenedor.Height
        Dim anchoRelativo As Single = control.Width / contenedor.Width
        Dim altoRelativo As Single = control.Height / contenedor.Height

        Return New RectangleF(xRelativo, yRelativo, anchoRelativo, altoRelativo)
    End Function
    Public Sub AplicarPosicionRelativa(control As Control, contenedor As Control, posRelativa As RectangleF)
        If control Is Nothing OrElse contenedor Is Nothing Then Exit Sub

        Dim nuevoX As Integer = CInt(contenedor.Width * posRelativa.X)
        Dim nuevoY As Integer = CInt(contenedor.Height * posRelativa.Y)
        Dim nuevoAncho As Integer = CInt(contenedor.Width * posRelativa.Width)
        Dim nuevoAlto As Integer = CInt(contenedor.Height * posRelativa.Height)

        control.SetBounds(nuevoX, nuevoY, nuevoAncho, nuevoAlto)
    End Sub
    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PosRelativeLblTotalSaleItemTabSell = ObtenerPosicionRelativa(LblTotalSaleItemTabSell, GroupBoxListProductAddSaleItemTabSell)
        PosRelativeLblTotalTitelSaleItemTabSell = ObtenerPosicionRelativa(LblTotalTitelSaleItemTabSell, GroupBoxListProductAddSaleItemTabSell)
        PosRelativeBtnFindClientSaleItemTabSell = ObtenerPosicionRelativa(BtnFindClientSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeLblFindClientSaleItemTabSell = ObtenerPosicionRelativa(LblFindClientSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeTextbFindClientSaleItemTabSell = ObtenerPosicionRelativa(TextbFindClientSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeLblDataClientSaleItemTabSell = ObtenerPosicionRelativa(LblDataClientSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeBtnFindProductSaleItemTabSell = ObtenerPosicionRelativa(BtnFindProductSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeLblFindProductSaleItemTabSell = ObtenerPosicionRelativa(LblFindProductSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeTextbFindProductSaleItemTabSell = ObtenerPosicionRelativa(TextbFindProductSaleItemTabSell, GroupBoxFindSaleItemTabSell)
        PosRelativeLblTotalProductSaleItemTabSell = ObtenerPosicionRelativa(LblTotalProductSaleItemTabSell, GroupBoxFindSaleItemTabSell)
    End Sub
    Private Sub GroupBoxFindSaleItemTabSell_Resize(sender As Object, e As EventArgs) Handles GroupBoxFindSaleItemTabSell.Resize
        AplicarPosicionRelativa(BtnFindClientSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeBtnFindClientSaleItemTabSell)
        AplicarPosicionRelativa(LblFindClientSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeLblFindClientSaleItemTabSell)
        AplicarPosicionRelativa(TextbFindClientSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeTextbFindClientSaleItemTabSell)
        AplicarPosicionRelativa(LblDataClientSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeLblDataClientSaleItemTabSell)
        AplicarPosicionRelativa(BtnFindProductSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeBtnFindProductSaleItemTabSell)
        AplicarPosicionRelativa(LblFindProductSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeLblFindProductSaleItemTabSell)
        AplicarPosicionRelativa(TextbFindProductSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeTextbFindProductSaleItemTabSell)
        AplicarPosicionRelativa(LblTotalProductSaleItemTabSell, GroupBoxFindSaleItemTabSell, PosRelativeLblTotalProductSaleItemTabSell)
    End Sub
    Private Sub GroupBoxListProductAddSaleItemTabSell_Resize(sender As Object, e As EventArgs) Handles GroupBoxListProductAddSaleItemTabSell.Resize
        AplicarPosicionRelativa(LblTotalSaleItemTabSell, GroupBoxListProductAddSaleItemTabSell, PosRelativeLblTotalSaleItemTabSell)
        AplicarPosicionRelativa(LblTotalTitelSaleItemTabSell, GroupBoxListProductAddSaleItemTabSell, PosRelativeLblTotalTitelSaleItemTabSell)
    End Sub

#End Region


#Region "Funtion of  Price  add Cant"

    Private Function ConvertToDecimal(stringPrice As String) As Decimal
        If String.IsNullOrWhiteSpace(stringPrice) Then
            Return 0D
        End If
        Dim clean As String = stringPrice.Trim()
        clean = clean.Replace("$", "").Replace(" ", "")
        clean = System.Text.RegularExpressions.Regex.Replace(clean, "\s+", "")
        clean = clean.Replace(".", "").Replace(",", ".")

        Dim res As Decimal
        If Decimal.TryParse(clean, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, res) Then
            Return res
        Else
            Throw New FormatException("El precio ingresado no tiene un formato decimal válido.")
        End If
    End Function

    Public Function FormatPrice(precio As Nullable(Of Decimal)) As String
        If Not precio.HasValue Then
            Return ""
        Else
            Dim cultura As New CultureInfo("es-AR")
            Return precio.Value.ToString("C", cultura)
        End If
    End Function

    Private Sub CalcularSubtotalFila(filaIndex As Integer)
        Dim fila = DgvListProductSaleItemTabSell.Rows(filaIndex)

        Dim cantidad As Decimal = 0D
        Decimal.TryParse(fila.Cells("Cantidad").Value?.ToString(), cantidad)
        Dim precio As Decimal = ConvertToDecimal(fila.Cells("Precio").Value?.ToString())

        fila.Cells("SubTotal").Value = FormatPrice(cantidad * precio)
    End Sub

    Private Sub SumarSubtotal(subtotal As Decimal)
        totalVentaActual += subtotal
        ActualizarLabelTotal()
    End Sub

    Private Sub RestarSubtotal(subtotal As Decimal)
        totalVentaActual -= subtotal
        If totalVentaActual < 0 Then totalVentaActual = 0D
        ActualizarLabelTotal()
    End Sub

    Private Sub ActualizarLabelTotal()
        LblTotalTitelSaleItemTabSell.Text = $"Total de la venta: ${totalVentaActual:N2}"
        LblTotalTitelSaleItemTabSell.ForeColor = Color.DarkGreen
    End Sub

    Private Function ObtenerCantidadSegura(valor As Object) As Integer
        If valor Is Nothing OrElse String.IsNullOrWhiteSpace(valor.ToString()) Then
            Return 0
        End If

        Dim cantidad As Integer
        If Integer.TryParse(valor.ToString(), cantidad) Then
            Return cantidad
        Else
            Return 0
        End If
    End Function

    Private Function PrecioEsValido(precio As String) As Boolean
        Return ConvertToDecimal(precio) > 0
    End Function

#End Region


#Region "Tab_Sell"
    Private Function BuscarFilaExistente(idProducto As String) As DataGridViewRow
        For Each fila As DataGridViewRow In DgvListProductAddSaleItemTabSell.Rows
            If fila.Cells("Id").Value?.ToString() = idProducto Then
                Return fila
            End If
        Next
        Return Nothing
    End Function

    Private Sub AddProductToSumary(idProducto As String, nombre As String, categoria As String, precio As Decimal, cantidad As Integer)
        If cantidad <= 0 Then
            MessageBox.Show("La cantidad a agregar no puede ser cero o vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim filaExistente As DataGridViewRow = BuscarFilaExistente(idProducto)

        If filaExistente IsNot Nothing Then
            Dim cantidadActual As Integer = ObtenerCantidadSegura(filaExistente.Cells("Cantidad").Value)
            Dim nuevaCantidad As Integer = cantidadActual + cantidad
            filaExistente.Cells("Cantidad").Value = nuevaCantidad
            filaExistente.Cells("Subtotal").Value = nuevaCantidad * precio
            Console.WriteLine("Producto ya existente. Se actualizó la cantidad.")
        Else
            Dim nuevaFila As New DataGridViewRow()
            nuevaFila.CreateCells(DgvListProductAddSaleItemTabSell)
            nuevaFila.Cells(0).Value = idProducto
            nuevaFila.Cells(1).Value = nombre
            nuevaFila.Cells(2).Value = precio
            nuevaFila.Cells(3).Value = categoria
            nuevaFila.Cells(4).Value = cantidad
            nuevaFila.Cells(5).Value = cantidad * precio
            nuevaFila.Cells(6).Value = "🗑 Quitar"
            DgvListProductAddSaleItemTabSell.Rows.Add(nuevaFila)
            Console.WriteLine("Producto agregado al resumen.")
        End If

        SumarSubtotal(ConvertToDecimal(cantidad * precio))
    End Sub

    Private Sub DgvListProductSaleItemTabSell_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListProductSaleItemTabSell.CellContentClick
        If DgvListProductSaleItemTabSell.Columns(e.ColumnIndex).Name = "Agregar" AndAlso e.RowIndex >= 0 Then
            Dim filaOrigen As DataGridViewRow = DgvListProductSaleItemTabSell.Rows(e.RowIndex)
            If Not PrecioEsValido(filaOrigen.Cells("Precio").Value.ToString()) Then
                MessageBox.Show("El precio del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim idProducto As String = filaOrigen.Cells("Id").Value.ToString()
            Dim nombreProducto As String = filaOrigen.Cells("Nombre").Value.ToString()
            Dim categoriaProducto As String = filaOrigen.Cells("Categoria").Value.ToString()
            Dim cantidadNueva As Integer = ObtenerCantidadSegura(filaOrigen.Cells("Cantidad").Value)
            Dim precioUnitario As Decimal = ConvertToDecimal(filaOrigen.Cells("Precio").Value)

            AddProductToSumary(idProducto, nombreProducto, categoriaProducto, precioUnitario, cantidadNueva)

            filaOrigen.Cells("Cantidad").Value = ""
        End If
    End Sub

    Private Sub DgvListProductAddSaleItemTabSell_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListProductAddSaleItemTabSell.CellContentClick
        If DgvListProductAddSaleItemTabSell.Columns(e.ColumnIndex).Name = "Quitar" AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DgvListProductAddSaleItemTabSell.Rows(e.RowIndex)

            Dim subtotal As Decimal = 0D
            If fila.Cells("Subtotal").Value IsNot Nothing AndAlso IsNumeric(fila.Cells("Subtotal").Value) Then
                subtotal = Convert.ToDecimal(fila.Cells("Subtotal").Value)
            End If

            RestarSubtotal(subtotal)

            DgvListProductAddSaleItemTabSell.Rows.RemoveAt(e.RowIndex)

        End If
    End Sub

    Private Sub BtnSellSaleItemTabSell_Click(sender As Object, e As EventArgs) Handles BtnSellSaleItemTabSell.Click
        If idClient <= 0 Then
            MessageBox.Show("Debe seleccionar un cliente válido antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DgvEmpy(DgvListProductAddSaleItemTabSell) Then
            MessageBox.Show("Debe agregar al menos un producto antes de registrar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If Not AddVenta() Then
                MessageBox.Show("No se pudo registrar la venta. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            totalVentaActual = 0D
            ActualizarLabelTotal()
            ClearResumenDgvListProductAddSaleItemTabSell()

            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Console.WriteLine("Error inesperado en BtnSellSaleItemTabSell_Click: " & ex.Message)
            MessageBox.Show("Ocurrió un error inesperado al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function DgvEmpy(dgv As DataGridView) As Boolean
        Return dgv.Rows.Cast(Of DataGridViewRow)().
        All(Function(r) r.IsNewRow OrElse r.Cells.Cast(Of DataGridViewCell)().
        All(Function(c) c.Value Is Nothing OrElse String.IsNullOrWhiteSpace(c.Value.ToString())))
    End Function

    Private Sub AddVentaItems(ventaId As Integer)
        Dim logic = New Examen.Logica.LVentaItem()
        For Each row As DataGridViewRow In DgvListProductAddSaleItemTabSell.Rows
            If row.IsNewRow Then Continue For

            Try
                logic.AddVentaItem(New VentaItem With {
                .IDVenta = ventaId,
                .IDProducto = GetValue(Of Integer)(row, "Id"),
                .PrecioUnitario = GetValue(Of Decimal)(row, "Precio"),
                .Cantidad = GetValue(Of Integer)(row, "Cantidad"),
                .PrecioTotal = GetValue(Of Decimal)(row, "Subtotal")
            })
            Catch ex As Exception
                Debug.WriteLine($"Fila {row.Index} omitida: {ex.Message}")
            End Try
        Next
        Console.WriteLine("Finalizado AddVentaItems")
    End Sub

    Private Function AddVenta() As Boolean
        Try
            Dim nuevaVenta As New Venta With {
            .IDCliente = idClient,
            .Fecha = DateTime.Now,
            .Total = ConvertToDecimal(totalVentaActual)
        }
            Dim lVenta As New Examen.Logica.LVenta()
            Dim SaleIdGenerated As Integer = lVenta.AddSale(nuevaVenta)

            If SaleIdGenerated <= 0 Then
                Return False
            End If
            AddVentaItems(SaleIdGenerated)
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub ClearResumenDgvListProductAddSaleItemTabSell()
        Try
            DgvListProductAddSaleItemTabSell.Rows.Clear()
            DgvListProductAddSaleItemTabSell.ClearSelection()
            DgvListProductAddSaleItemTabSell.Refresh()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function GetValue(Of T)(row As DataGridViewRow, col As String) As T
        Dim raw = row.Cells(col).Value
        If raw Is Nothing OrElse IsDBNull(raw) Then
            Throw New InvalidOperationException($"{col} inválido")
        End If
        Return CType(Convert.ChangeType(raw, GetType(T)), T)
    End Function

#End Region

#Region "Other Function"

    Private Sub FindClientById(textBox As TextBox, Optional label As Label = Nothing)
        Dim LCliente As New Examen.Logica.LClient()
        Dim parametro As String = textBox.Text.Trim()

        idClient = 0

        If String.IsNullOrEmpty(parametro) Then
            MessageBox.Show("Por favor, ingrese un ID de cliente.")
            Exit Sub
        End If

        Try
            Dim cliente As Cliente = LCliente.FindClientById(parametro)

            If cliente IsNot Nothing Then
                If label IsNot Nothing Then
                    label.Text = $"Cliente:{vbCrLf}" &
                             $"ID: {cliente.Id}{vbCrLf}" &
                             $"Nombre: {cliente.Cliente}{vbCrLf}" &
                             $"Teléfono: {cliente.Correo}{vbCrLf}" &
                             $"Correo: {cliente.Telefono}"
                End If

                idClient = ObtenerIdCliente(cliente.Id)
                TextbFindClientSaleItemTabSell.Clear()
            Else
                If label IsNot Nothing Then
                    label.Text = "Cliente no encontrado."
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar el cliente: " & ex.Message)
        End Try
    End Sub

    Public Function ObtenerIdCliente(texto As String) As Integer
        Dim id As Integer
        If Integer.TryParse(texto.Trim(), id) Then
            Return id
        End If
        Return -1 ' Valor por defecto si falla
    End Function


    Private Sub DgvListSaleSaleItemTabEdit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListSaleSaleItemTabEdit.CellContentClick
        If DgvListSaleSaleItemTabEdit.Columns(e.ColumnIndex).Name = "Seleccionar" AndAlso e.RowIndex >= 0 Then
            For Each fila As DataGridViewRow In DgvListSaleSaleItemTabEdit.Rows
                fila.Cells("Seleccionar").Value = False
            Next

            filaSeleccionadaEdit = DgvListSaleSaleItemTabEdit.Rows(e.RowIndex)
            filaSeleccionadaEdit.Cells("Seleccionar").Value = True

            idVentaEdit = Convert.ToInt32(filaSeleccionadaEdit.Cells("ID").Value)

            GetSaleItemsBySaleId(idVentaEdit)
        End If
    End Sub

    Private Sub BtnFindClientSaleItemTabEdit_Click(sender As Object, e As EventArgs) Handles BtnFindClientSaleItemTabEdit.Click
        FindClientById(TextbFindClientSaleItemTabEdit)
        GetSalesByClientId()
    End Sub


    Private Sub CargarVentasEnGrilla(ventas As List(Of Venta))
        Try
            Dim listaFormateada = ventas.Select(Function(v) New With {
            v.ID,
            .Fecha = If(v.Fecha.HasValue, v.Fecha.Value.ToShortDateString(), "Sin fecha"),
            v.Total
        }).ToList()

            DgvListSaleSaleItemTabEdit.DataSource = ConvertirADataTable(listaFormateada)

        Catch ex As Exception
            MessageBox.Show("Error al cargar ventas: " & ex.Message)
        End Try
    End Sub

    Private Function ConvertirADataTable(Of T)(datos As List(Of T)) As DataTable
        Dim dt As New DataTable()
        Dim propiedades = GetType(T).GetProperties()

        For Each prop In propiedades
            dt.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next

        For Each item In datos
            Dim valores(propiedades.Length - 1) As Object
            For i = 0 To propiedades.Length - 1
                valores(i) = propiedades(i).GetValue(item, Nothing)
            Next
            dt.Rows.Add(valores)
        Next

        Return dt
    End Function

    Private Sub GetSalesByClientId()
        Try

            If idClient <= 0 Then
                MessageBox.Show("No se ha seleccionado un cliente válido.")
                Exit Sub
            End If
            LblFindClientSaleItemTabEdit.Text = "Cantidad de Ventas: "
            Dim lVenta As New LVenta()
            Dim ventas As List(Of Venta) = lVenta.GetSalesByClientId(idClient)
            LblFindClientSaleItemTabEdit.Text += ventas.Count.ToString()
            CargarVentasEnGrilla(ventas)

        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas del cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub GetSaleItemsBySaleId(idVenta As Integer)
        Try
            If idVenta <= 0 Then
                MessageBox.Show("No se ha seleccionado una venta válida.")
                Exit Sub
            End If

            Dim lVentaItem As New LVentaItem()
            Dim items As List(Of VentaItem) = lVentaItem.GetSaleItemsBySaleId(idVenta)
            CargarItemsEnGrilla(items)

        Catch ex As Exception
            MessageBox.Show("Error al cargar los ítems de la venta: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarItemsEnGrilla(items As List(Of VentaItem))
        Try
            DgvListItemSaleItemTabEdit.Rows.Clear()

            For Each item As VentaItem In items
                DgvListItemSaleItemTabEdit.Rows.Add(
                item.ID,
                item.IDProducto,
                item.PrecioUnitario,
                item.Cantidad,
                item.PrecioTotal
            )
            Next

            DgvListItemSaleItemTabEdit.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los ítems en la grilla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function DeleteAllItemsOfSale(idVenta As Integer) As Boolean
        Try
            If idVenta <= 0 Then
                MessageBox.Show("ID de venta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If DgvListItemSaleItemTabEdit.Rows.Count = 0 Then
                MessageBox.Show("Este ID de venta no tiene ítems vinculados.", "Sin ítems", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If

            Dim confirmacion = MessageBox.Show("¿Está seguro que desea eliminar todos los ítems de esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion <> DialogResult.Yes Then Return False

            Dim lVentaItem As New LVentaItem()
            Dim errores As Integer = 0

            For Each fila As DataGridViewRow In DgvListItemSaleItemTabEdit.Rows
                If fila.Cells("IDItem").Value IsNot Nothing Then
                    Dim idItem As Integer = Convert.ToInt32(fila.Cells("IDItem").Value)
                    Dim eliminado As Boolean = lVentaItem.DeleteVentaItem(idItem)
                    If Not eliminado Then errores += 1
                End If
            Next

            If errores = 0 Then
                MessageBox.Show("Todos los ítems fueron eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DgvListItemSaleItemTabEdit.Rows.Clear()
                Return True
            Else
                MessageBox.Show("Algunos ítems no pudieron eliminarse. Verifique los registros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar los ítems: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub DeleteSaleByID(idVenta As Integer)
        Try
            If idVenta <= 0 Then
                MessageBox.Show("ID de venta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim confirmacion = MessageBox.Show("¿Está seguro que desea eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion <> DialogResult.Yes Then Exit Sub

            Dim lVenta As New LVenta()
            Dim resultado As Boolean = lVenta.DeleteSaleByID(idVenta)

            If resultado Then
                MessageBox.Show("La venta fue eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo eliminar la venta. Verifique si está vinculada a otros registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FindProductsByCoincidence()
        Try
            Dim lProduct As New Examen.Logica.LProducto()
            Dim parametro As String = TextbFindProductSaleItemTabSell.Text
            Dim productosFiltrados = lProduct.FindProductsByCoincidence(parametro)

            DgvListProductSaleItemTabSell.Rows.Clear()

            For Each prod In productosFiltrados
                DgvListProductSaleItemTabSell.Rows.Add(
                prod.Id,
                prod.Nombre,
                prod.Precio,
                prod.Categoria,
                0,
                "Agregar",
                FormatPrice(0D)
            )
            Next

            LblTotalProductSaleItemTabSell.Text = "Total de Registros: " & productosFiltrados.Count.ToString()
            TextbFindProductSaleItemTabSell.Clear()
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message)
        End Try
    End Sub

    Private Sub TextbFindClientSaleItemTabEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextbFindClientSaleItemTabEdit.KeyPress
        Dim txtBox As TextBox = DirectCast(sender, TextBox)

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        If txtBox.SelectionStart = 0 AndAlso e.KeyChar = "0"c Then
            e.Handled = True
            Return
        End If
    End Sub


#End Region


End Class