Imports Examen.Entidades

Public Class FrmProducto
#Region "Initial, Load, KeyPress, AuxFuntions"
    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ListingProduct(DgvListProductTabList, LblTotalProductTabList)
        Me.ListingProduct(DgvListProductTabUpdate, LblTotalProductTabUpdate)
        Me.ListingProduct(DgvListProductTabDelete, Nothing)
        Me.AgregarColumnaSeleccionar(DgvListProductTabUpdate)
        Me.AgregarColumnaSeleccionar(DgvListProductTabDelete)
    End Sub
    Private Sub FormatearGrid(dgv As DataGridView)
        DgvListProductTabList.Columns(0).HeaderText = "ID"
        DgvListProductTabList.Columns(0).Width = 50
        DgvListProductTabList.Columns(1).HeaderText = "Nombre"
        DgvListProductTabList.Columns(1).Width = 200
        DgvListProductTabList.Columns(2).HeaderText = "Precio"
        DgvListProductTabList.Columns(2).Width = 200
        DgvListProductTabList.Columns(3).HeaderText = "Categoria"
        DgvListProductTabList.Columns(3).Width = 200
    End Sub
    Private Sub Formato()
        DgvListProductTabList.Columns(0).HeaderText = "ID"
        DgvListProductTabList.Columns(0).Width = 50
        DgvListProductTabList.Columns(1).HeaderText = "Nombre"
        DgvListProductTabList.Columns(1).Width = 200
        DgvListProductTabList.Columns(2).HeaderText = "Precio"
        DgvListProductTabList.Columns(2).Width = 200
        DgvListProductTabList.Columns(3).HeaderText = "Categoria"
        DgvListProductTabList.Columns(3).Width = 200
    End Sub
    Private Sub ListingProduct(dgvParameter As DataGridView, Optional lblParameter As Label = Nothing)
        Try
            Dim lProduct As New Examen.Logica.LProducto()
            dgvParameter.DataSource = lProduct.ListProduct()
            Me.Formato()

            If lblParameter IsNot Nothing Then
                lblParameter.Text = "Total de Registros: " & dgvParameter.Rows.Count.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TextbPriceProductTabAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextbPriceProductTabAdd.KeyPress
        Dim c As Char = e.KeyChar
        Dim currentText As String = CType(sender, TextBox).Text

        If Char.IsDigit(c) OrElse c = ChrW(Keys.Back) Then
            e.Handled = False
            Return
        End If

        If c = "."c Then
            If currentText.Contains(".") OrElse currentText.Length = 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
            Return
        End If

        e.Handled = True
    End Sub
    Private Sub AgregarColumnaSeleccionar(dgvListProductTab)
        If Not dgvListProductTab.Columns.Contains("Seleccionar") Then
            Dim chkCol As New DataGridViewCheckBoxColumn With {
    .Name = "Seleccionar",
    .HeaderText = "Editar",
    .Width = 50
            }
            dgvListProductTab.Columns.Insert(0, chkCol)
        End If
    End Sub
#End Region



#Region "BtnAdd/Update/Delete,Select_Click, AuxFuntions"
    Private Sub BtnAddPruductTabAdd_Click(sender As Object, e As EventArgs) Handles BtnAddProductTabAdd.Click
        If Me.ValidateChildren = True And TextbNameProductTabAdd.Text <> "" Then
            Console.WriteLine("Intentando agregar producto...")
            Try
                Dim lProducto As New Examen.Logica.LProducto()
                If lProducto.AddProduct(TextbNameProductTabAdd.Text, TextbPriceProductTabAdd.Text, TextbCategoryProductTabAdd.Text) Then
                    MessageBox.Show("Producto agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ListingProduct(DgvListProductTabList, LblTotalProductTabList)
                    Me.ListingProduct(DgvListProductTabUpdate, LblTotalProductTabUpdate)
                    Me.ClearTextBoxByGroupBox(GroupBoxProductTabAdd)
                Else
                    MessageBox.Show("Error al agregar el Producto", "Faltan Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Console.WriteLine("Proceso de agregar producto finalizado.")
    End Sub
    Private Sub BtnUpdateProducto_Click(sender As Object, e As EventArgs) Handles BtnUpdateProductTabUpdate.Click

        If AreProductFieldsEmpty() Then
            MessageBox.Show("No hay datos cargados para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = GetSelectedRowByCheckbox(DgvListProductTabUpdate, "Seleccionar")

        If selectedRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un producto para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim modifiedData As Boolean = ValidationToModifyProductData(selectedRow)

        If Not modifiedData Then
            MessageBox.Show("Los datos no han sido modificados. No se puede actualizar.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas aplicar los cambios?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Dim productoActualizado As New Producto With {
            .Id = Convert.ToInt32(selectedRow.Cells("Id").Value),
            .Nombre = TextbNameProductTabUpdate.Text,
            .Precio = ConvertToDecimal(TextbPriceProductTabUpdate.Text),
            .Categoria = TextbCategoryProductTabUpdate.Text
        }

            Try
                Dim LProducto As New Examen.Logica.LProducto()
                LProducto.UpdateProduct(productoActualizado)

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListingProduct(DgvListProductTabUpdate, LblTotalProductTabUpdate)
                ClearTextBoxByGroupBox(GroupBoxProductTabUpdate)
            Catch ex As Exception
                MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub BtnDeleteProductTabDelete_Click(sender As Object, e As EventArgs) Handles BtnDeleteProductTabDelete.Click
        Dim selectedRow As DataGridViewRow = GetSelectedRowByCheckbox(DgvListProductTabDelete, "Seleccionar")
        If selectedRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                Dim LProducto As New Examen.Logica.LProducto()
                LProducto.DeleteProduct(Convert.ToInt32(selectedRow.Cells("Id").Value))

                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListingProduct(DgvListProductTabDelete, LblTotalProductTabDelete)
                ClearTextBoxByGroupBox(GroupBoxProductTabDelete)
                ListingProduct(DgvListProductTabList, LblTotalProductTabList)
                ListingProduct(DgvListProductTabUpdate, LblTotalProductTabUpdate)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub DgvListProductTabUpdate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListProductTabUpdate.CellContentClick
        If DgvListProductTabUpdate.Columns(e.ColumnIndex).Name = "Seleccionar" AndAlso e.RowIndex >= 0 Then

            For Each f As DataGridViewRow In DgvListProductTabUpdate.Rows
                f.Cells("Seleccionar").Value = False
            Next

            Dim fila As DataGridViewRow = DgvListProductTabUpdate.Rows(e.RowIndex)
            fila.Cells("Seleccionar").Value = True

            TextbNameProductTabUpdate.Text = fila.Cells("Nombre").Value.ToString()
            TextbPriceProductTabUpdate.Text = If(IsNothing(fila.Cells("Precio").Value) OrElse fila.Cells("Precio").Value.ToString().Trim() = "", "", fila.Cells("Precio").Value.ToString())
            TextbCategoryProductTabUpdate.Text = If(IsNothing(fila.Cells("Categoria").Value) OrElse fila.Cells("Categoria").Value.ToString().Trim() = "", "", fila.Cells("Categoria").Value.ToString())


        End If
    End Sub
    Private Sub DgvListProductTabDelete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListProductTabDelete.CellContentClick
        If DgvListProductTabDelete.Columns(e.ColumnIndex).Name = "Seleccionar" AndAlso e.RowIndex >= 0 Then

            For Each f As DataGridViewRow In DgvListProductTabDelete.Rows
                f.Cells("Seleccionar").Value = False
            Next

            Dim fila As DataGridViewRow = DgvListProductTabDelete.Rows(e.RowIndex)
            fila.Cells("Seleccionar").Value = True

            LblEmpyNameProductTabDelete.Text = fila.Cells("Nombre").Value.ToString()
            LblEmpyPriceProductTabDelete.Text = fila.Cells("Precio").Value.ToString()
            LblEmpyCategoryProductTabDelete.Text = fila.Cells("Categoria").Value.ToString()

        End If
    End Sub
    Private Function AreProductFieldsEmpty() As Boolean
        Return String.IsNullOrWhiteSpace(TextbNameProductTabUpdate.Text) AndAlso
           String.IsNullOrWhiteSpace(TextbPriceProductTabUpdate.Text) AndAlso
           String.IsNullOrWhiteSpace(TextbCategoryProductTabUpdate.Text)
    End Function
    Private Function ValidationToModifyProductData(row As DataGridViewRow) As Boolean
        Return TextbNameProductTabUpdate.Text <> SafeCellText(row.Cells("Nombre")) OrElse
           TextbPriceProductTabUpdate.Text <> SafeCellText(row.Cells("Precio")) OrElse
           TextbCategoryProductTabUpdate.Text <> SafeCellText(row.Cells("Categoria"))
    End Function
    Private Function SafeCellText(cell As DataGridViewCell) As String
        If cell Is Nothing OrElse IsNothing(cell.Value) Then
            Return ""
        End If

        Dim texto As String = cell.Value.ToString().Trim()

        If texto = "" Then
            Return ""
        End If

        Return texto
    End Function
    Private Function GetSelectedRowByCheckbox(dgv As DataGridView, checkboxColumnName As String) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If Convert.ToBoolean(row.Cells(checkboxColumnName).Value) = True Then
                Return row
            End If
        Next
        Return Nothing
    End Function
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
#End Region

#Region "BtnFind_Click, BtnCancel_Click, AuxFuntions"
    Private Sub FindProductsByCoincidence(txtBuscar As TextBox, dgvListado As DataGridView, lblTotal As Label)
        Try
            Dim lProduct As New Examen.Logica.LProducto()
            Dim parametro As String = txtBuscar.Text

            dgvListado.DataSource = lProduct.FindProductsByCoincidence(parametro)
            FormatearGrid(dgvListado)

            lblTotal.Text = "Total de Registros: " & dgvListado.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearTextBoxByGroupBox(groupBox As GroupBox)
        For Each ctrl As Control In groupBox.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    Private Sub BtnFindProductTabProduct_Click(sender As Object, e As EventArgs) Handles BtnFindProductTabProduct.Click
        FindProductsByCoincidence(TextbFindProductTabList, DgvListProductTabList, LblTotalProductTabList)
    End Sub
    Private Sub BtnFindProductTabUpdate_Click(sender As Object, e As EventArgs) Handles BtnFindProductTabUpdate.Click
        FindProductsByCoincidence(TextbFindProductTabUpdate, DgvListProductTabUpdate, LblTotalProductTabUpdate)
    End Sub
    Private Sub BtnFindProductTabDelete_Click(sender As Object, e As EventArgs) Handles BtnFindProductTabDelete.Click
        FindProductsByCoincidence(TextbFindProductTabDelete, DgvListProductTabDelete, LblTotalProductTabDelete)
    End Sub
    Private Sub BtnCancelProductTabAdd_Click(sender As Object, e As EventArgs) Handles BtnCancelProductTabAdd.Click
        Me.ClearTextBoxByGroupBox(GroupBoxProductTabAdd)
    End Sub
    Private Sub BtnCancelProductTabUpdate_Click(sender As Object, e As EventArgs) Handles BtnCancelProductTabUpdate.Click
        Me.ClearTextBoxByGroupBox(GroupBoxProductTabUpdate)
    End Sub
    Private Sub BtnCancelProductTabDelete_Click(sender As Object, e As EventArgs) Handles BtnCancelProductTabDelete.Click
        Me.ClearTextBoxByGroupBox(GroupBoxProductTabDelete)
    End Sub
#End Region
End Class