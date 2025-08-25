Public Class FormProducto
    Private Sub BtnAddPruductTabAdd_Click(sender As Object, e As EventArgs) Handles BtnAddProductTabAdd.Click
        If Me.ValidateChildren = True And TextbNameProductTabAdd.Text <> "" And TextbPriceProductTabAdd.Text <> "" And TextbCategoryProductTabAdd.Text <> "" Then
            Try
                Dim producto As New Examen.Entidades.Producto With {
                    .Nombre = TextbNameProductTabAdd.Text,
                    .Precio = TextbPriceProductTabAdd.Text,
                    .Categoria = TextbCategoryProductTabAdd.Text
                }
                Dim LCliente As New Examen.Logica.LCliente()
                If LCliente.AddClient(cliente) Then
                    MessageBox.Show("Cliente agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ListingClients(DgvListClientTabList, LblTotalClientTabList)
                    Me.ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate)
                    Me.ClearTextBoxByGroupBox(GroupBoxTabAdd)
                Else
                    MessageBox.Show("Error al agregar el cliente", "Faltan Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class