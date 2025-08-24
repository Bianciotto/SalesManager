Imports Examen.Entidades

Public Class FrmCliente
    Private Sub Formato()
        DgvListClientTabList.Columns(0).HeaderText = "ID"
        DgvListClientTabList.Columns(0).Width = 50
        DgvListClientTabList.Columns(1).HeaderText = "Nombre"
        DgvListClientTabList.Columns(1).Width = 200
        DgvListClientTabList.Columns(2).HeaderText = "Telefono"
        DgvListClientTabList.Columns(2).Width = 200
        DgvListClientTabList.Columns(3).HeaderText = "Correo"
        DgvListClientTabList.Columns(3).Width = 200
    End Sub

    Private Sub ListingClients(dgvParameter As DataGridView, lblParameter As Label)
        Try
            Dim LCliente As New Examen.Logica.LCliente()
            dgvParameter.DataSource = LCliente.ListClients()
            Me.Formato()
            lblParameter.Text = "Total de Registros: " & dgvParameter.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FindClientsByCoincidence(txtBuscar As TextBox, dgvListado As DataGridView, lblTotal As Label)
        Try
            Dim LCliente As New Examen.Logica.LCliente()
            Dim parametro As String = txtBuscar.Text

            dgvListado.DataSource = LCliente.FindClientsByCoincidence(parametro)
            FormatearGrid(dgvListado)

            lblTotal.Text = "Total de Registros: " & dgvListado.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message)
        End Try
    End Sub
    Private Sub FormatearGrid(dgv As DataGridView)
        DgvListClientTabList.Columns(0).HeaderText = "ID"
        DgvListClientTabList.Columns(0).Width = 50
        DgvListClientTabList.Columns(1).HeaderText = "Nombre"
        DgvListClientTabList.Columns(1).Width = 200
        DgvListClientTabList.Columns(2).HeaderText = "Telefono"
        DgvListClientTabList.Columns(2).Width = 200
        DgvListClientTabList.Columns(3).HeaderText = "Correo"
        DgvListClientTabList.Columns(3).Width = 200
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TextbFindClientTabList.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindClientsByCoincidence(TextbFindClientTabList, DgvListClientTabList, LblTotalClientTabList)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ClearTextBoxByGroupBox(groupBox As GroupBox)
        For Each ctrl As Control In groupBox.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub



    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListingClients(DgvListClientTabList, LblTotalClientTabList)
        Me.ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate)
    End Sub
    Private Sub AgregarColumnaSeleccionar()
        If Not DgvListClientTabUpdate.Columns.Contains("Seleccionar") Then
            Dim chkCol As New DataGridViewCheckBoxColumn With {
                .Name = "Seleccionar",
                .HeaderText = "Editar",
                .Width = 50
            }
            DgvListClientTabUpdate.Columns.Insert(0, chkCol)
        End If
    End Sub

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        If Me.ValidateChildren = True And TextbClientClientTabAdd.Text <> "" And TextbPhoneClientTabAdd.Text <> "" And TextbMailClientTabAdd.Text <> "" Then
            Try
                Dim cliente As New Examen.Entidades.Cliente With {
                    .Cliente = TextbClientClientTabAdd.Text,
                    .Telefono = TextbPhoneClientTabAdd.Text,
                    .Correo = TextbMailClientTabAdd.Text
                }
                Dim LCliente As New Examen.Logica.LCliente()
                If LCliente.AddClient(cliente) Then
                    MessageBox.Show("Cliente agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ListingClients(DgvListClientTabList, LblTotalClientTabList)
                    Me.ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate)
                    Me.ClearTextBoxByGroupBox(GroupBoxTabAdd)
                    TabctrlClient.SelectedIndex = 0
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

    Private Sub BtnCancelAddClient_Click(sender As Object, e As EventArgs) Handles BtnCancelAddClient.Click
        Me.ClearTextBoxByGroupBox(GroupBoxTabAdd)
        TabctrlClient.SelectedIndex = 0
    End Sub

    Private Sub BtnFindClientTabUpdate_Click(sender As Object, e As EventArgs) Handles BtnFindClientTabUpdate.Click
        FindClientsByCoincidence(TextbFindClientTabUpdate, DgvListClientTabUpdate, LblTotalClientTabUpdate)
    End Sub

    Private Sub BtnFindClientTabList_Click(sender As Object, e As EventArgs) Handles BtnFindClientTabList.Click
        FindClientsByCoincidence(TextbFindClientTabList, DgvListClientTabList, LblTotalClientTabList)
    End Sub
    Private Sub AddColumnSelect()
        If Not DgvListClientTabUpdate.Columns.Contains("Seleccionar") Then
            Dim chkCol As New DataGridViewCheckBoxColumn With {
                .Name = "Seleccionar",
                .HeaderText = "Editar",
                .Width = 50
            }
            DgvListClientTabUpdate.Columns.Insert(0, chkCol)
        End If
    End Sub
    Private Sub DgvListClientTabUpdate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListClientTabUpdate.CellContentClick
        ' Verificamos que se haya hecho clic en la columna "Seleccionar"
        If DgvListClientTabUpdate.Columns(e.ColumnIndex).Name = "Seleccionar" AndAlso e.RowIndex >= 0 Then
            ' Obtenemos la fila seleccionada
            Dim fila As DataGridViewRow = DgvListClientTabUpdate.Rows(e.RowIndex)

            ' Cargamos los datos en los TextBox
            TextbClientClientTabUpdate.Text = fila.Cells("Cliente").Value.ToString()
            TextbPhoneClientTabUpdate.Text = fila.Cells("Telefono").Value.ToString()
            TextbMailClientTabUpdate.Text = fila.Cells("Correo").Value.ToString()
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnUpdateClientTabUpdate.Click
        ' Validar que haya un cliente seleccionado
        If String.IsNullOrWhiteSpace(TextbClientClientTabUpdate.Text) AndAlso
       String.IsNullOrWhiteSpace(TextbPhoneClientTabUpdate.Text) AndAlso
       String.IsNullOrWhiteSpace(TextbMailClientTabUpdate.Text) Then
            MessageBox.Show("No hay datos cargados para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Buscar la fila marcada en el DataGridView
        Dim filaSeleccionada As DataGridViewRow = Nothing
        For Each fila As DataGridViewRow In DgvListClientTabUpdate.Rows
            If Convert.ToBoolean(fila.Cells("Seleccionar").Value) = True Then
                filaSeleccionada = fila
                Exit For
            End If
        Next

        If filaSeleccionada Is Nothing Then
            MessageBox.Show("Debe seleccionar un cliente para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Comparar los datos actuales con los originales
        Dim datosModificados As Boolean = False

        If TextbClientClientTabUpdate.Text <> filaSeleccionada.Cells("Cliente").Value.ToString() Then datosModificados = True
        If TextbPhoneClientTabUpdate.Text <> filaSeleccionada.Cells("Telefono").Value.ToString() Then datosModificados = True
        If TextbMailClientTabUpdate.Text <> filaSeleccionada.Cells("Correo").Value.ToString() Then datosModificados = True

        If Not datosModificados Then
            MessageBox.Show("Los datos no han sido modificados. No se puede actualizar.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Confirmación del usuario
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas aplicar los cambios?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            ' Crear objeto Cliente actualizado
            Dim clienteActualizado As New Cliente With {
            .Id = Convert.ToInt32(filaSeleccionada.Cells("Id").Value),
            .Cliente = TextbClientClientTabUpdate.Text,
            .Telefono = TextbPhoneClientTabUpdate.Text,
            .Correo = TextbMailClientTabUpdate.Text
        }

            Try
                Dim LCliente As New Examen.Logica.LCliente()
                LCliente.UpdateClient(clienteActualizado)

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate) ' Refrescar la grilla
                ClearTextBoxByGroupBox(GroupBoxTabUpdate)
            Catch ex As Exception
                MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class