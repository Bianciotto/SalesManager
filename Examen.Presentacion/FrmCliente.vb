Imports Examen.Entidades
Imports Examen.Logica
Public Class FrmCliente
#Region "Initial, Load, KeyPress, AuxFuntions"

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListingClients(DgvListClientTabList, LblTotalClientTabList)
        Me.ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate)
        Me.ListingClients(DgvListClientTabDelete, Nothing)
        Me.AgregarColumnaSeleccionar(DgvListClientTabUpdate)
        Me.AgregarColumnaSeleccionar(DgvListClientTabDelete)

    End Sub

    Private Sub ListingClients(dgvParameter As DataGridView, Optional lblParameter As Label = Nothing)
        Try
            Dim lCliente As New Examen.Logica.LClient()
            dgvParameter.DataSource = lCliente.ListClients()
            Me.Formato()

            If lblParameter IsNot Nothing Then
                lblParameter.Text = "Total de Registros: " & dgvParameter.Rows.Count.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarColumnaSeleccionar(dgvListClientTab)
        If Not dgvListClientTab.Columns.Contains("Seleccionar") Then
            Dim chkCol As New DataGridViewCheckBoxColumn With {
                .Name = "Seleccionar",
                .HeaderText = "Editar",
                .Width = 50
            }
            dgvListClientTab.Columns.Insert(0, chkCol)
        End If
    End Sub

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

#End Region

#Region "Indefinida"

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TextbFindClientTabList.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindClientsByCoincidence(TextbFindClientTabList, DgvListClientTabList, LblTotalClientTabList)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub FindClientsByCoincidence(txtFind As TextBox, dgvList As DataGridView, lblTotal As Label)
        Try
            Dim lCliente As New Examen.Logica.LClient()
            Dim parametro As String = txtFind.Text

            dgvList.DataSource = lCliente.FindClientsByCoincidence(parametro)
            FormatearGrid(dgvList)

            lblTotal.Text = "Total de Registros: " & dgvList.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "BtnAdd/Update/Delete_Click,Selecct_Click AuxFuntions"

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        If Me.ValidateChildren = True And TextbClientClientTabAdd.Text <> "" And TextbPhoneClientTabAdd.Text <> "" And TextbMailClientTabAdd.Text <> "" Then
            Try
                Dim cliente As New Examen.Entidades.Cliente With {
                    .Cliente = TextbClientClientTabAdd.Text,
                    .Telefono = TextbPhoneClientTabAdd.Text,
                    .Correo = TextbMailClientTabAdd.Text
                }
                Dim lCliente As New Examen.Logica.LClient()
                If lCliente.AddClient(cliente) Then
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

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnUpdateClientTabUpdate.Click

        If AreClientFieldsEmpty() Then
            MessageBox.Show("No hay datos cargados para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = GetSelectedRowByCheckbox(DgvListClientTabUpdate, "Seleccionar")

        If selectedRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un cliente para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim modifiedData As Boolean = ValidationToModifyData(selectedRow)

        If Not modifiedData Then
            MessageBox.Show("Los datos no han sido modificados. No se puede actualizar.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas aplicar los cambios?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then

            Dim clienteActualizado As New Cliente With {
            .Id = Convert.ToInt32(selectedRow.Cells("Id").Value),
            .Cliente = TextbClientClientTabUpdate.Text,
            .Telefono = TextbPhoneClientTabUpdate.Text,
            .Correo = TextbMailClientTabUpdate.Text
        }

            Try
                Dim lCliente As New Examen.Logica.LClient()
                lCliente.UpdateClient(clienteActualizado)

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate)
                ClearTextBoxByGroupBox(GroupBoxClientTabUpdate)
            Catch ex As Exception
                MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnDeleteClientTabDelete_Click(sender As Object, e As EventArgs) Handles BtnDeleteClientTabDelete.Click
        Dim selectedRow As DataGridViewRow = GetSelectedRowByCheckbox(DgvListClientTabDelete, "Seleccionar")
        If selectedRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un cliente para Eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas Eliminar al Cliente?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                Dim lCliente As New Examen.Logica.LClient()
                lCliente.DeleteClient(Convert.ToInt32(selectedRow.Cells("Id").Value))

                MessageBox.Show("Cliente Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ListingClients(DgvListClientTabList, LblTotalClientTabList)
                Me.ListingClients(DgvListClientTabUpdate, LblTotalClientTabUpdate)
                Me.ListingClients(DgvListClientTabDelete, LblTotalClientTabDelete)
                ClearTextBoxByGroupBox(GroupBoxClientTabDelete)

            Catch ex As Exception
                MessageBox.Show("Error al Eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DgvListClientTabUpdate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListClientTabUpdate.CellContentClick
        If DgvListClientTabUpdate.Columns(e.ColumnIndex).Name = "Seleccionar" AndAlso e.RowIndex >= 0 Then

            For Each f As DataGridViewRow In DgvListClientTabUpdate.Rows
                f.Cells("Seleccionar").Value = False
            Next

            Dim fila As DataGridViewRow = DgvListClientTabUpdate.Rows(e.RowIndex)
            fila.Cells("Seleccionar").Value = True

            TextbClientClientTabUpdate.Text = fila.Cells("Cliente").Value.ToString()
            TextbPhoneClientTabUpdate.Text = fila.Cells("Telefono").Value.ToString()
            TextbMailClientTabUpdate.Text = fila.Cells("Correo").Value.ToString()

        End If
    End Sub

    Private Sub DgvListClientTabDelete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListClientTabDelete.CellContentClick
        If DgvListClientTabUpdate.Columns(e.ColumnIndex).Name = "Seleccionar" AndAlso e.RowIndex >= 0 Then

            For Each f As DataGridViewRow In DgvListClientTabDelete.Rows
                f.Cells("Seleccionar").Value = False
            Next

            Dim fila As DataGridViewRow = DgvListClientTabDelete.Rows(e.RowIndex)
            fila.Cells("Seleccionar").Value = True

            LblEmpyClientClientTabDelete.Text = fila.Cells("Cliente").Value.ToString()
            LblEmpyPhoneClientTabDelete.Text = fila.Cells("Telefono").Value.ToString()
            LblEmpyMailClientTabDelete.Text = fila.Cells("Correo").Value.ToString()

        End If
    End Sub

    Private Function AreClientFieldsEmpty() As Boolean
        Return String.IsNullOrWhiteSpace(TextbClientClientTabUpdate.Text) AndAlso
           String.IsNullOrWhiteSpace(TextbPhoneClientTabUpdate.Text) AndAlso
           String.IsNullOrWhiteSpace(TextbMailClientTabUpdate.Text)
    End Function

    Private Function GetSelectedRowByCheckbox(dgv As DataGridView, checkboxColumnName As String) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If Convert.ToBoolean(row.Cells(checkboxColumnName).Value) = True Then
                Return row
            End If
        Next
        Return Nothing
    End Function

    Private Function ValidationToModifyData(row As DataGridViewRow) As Boolean
        Return TextbClientClientTabUpdate.Text <> row.Cells("Cliente").Value.ToString() OrElse
           TextbPhoneClientTabUpdate.Text <> row.Cells("Telefono").Value.ToString() OrElse
           TextbMailClientTabUpdate.Text <> row.Cells("Correo").Value.ToString()
    End Function

    Private Sub ClearTextBoxByGroupBox(groupBox As GroupBox)
        For Each ctrl As Control In groupBox.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

#End Region

#Region "BtnFind_Click, BtnCancel_Click, AuxFuntions"

    Private Sub BtnFindClientTabList_Click(sender As Object, e As EventArgs) Handles BtnFindClientTabList.Click
        FindClientsByCoincidence(TextbFindClientTabList, DgvListClientTabList, LblTotalClientTabList)
    End Sub

    Private Sub BtnFindClientTabUpdate_Click(sender As Object, e As EventArgs) Handles BtnFindClientTabUpdate.Click
        FindClientsByCoincidence(TextbFindClientTabUpdate, DgvListClientTabUpdate, LblTotalClientTabUpdate)
    End Sub

    Private Sub BtnFindClientTabDelete_Click(sender As Object, e As EventArgs) Handles BtnFindClientTabDelete.Click
        FindClientsByCoincidence(TextbFindClientTabDelete, DgvListClientTabDelete, LblTotalClientTabDelete)
    End Sub

    Private Sub BtnCancelAddClient_Click(sender As Object, e As EventArgs) Handles BtnCancelAddClient.Click
        Me.ClearTextBoxByGroupBox(GroupBoxTabAdd)
    End Sub

    Private Sub BtnCancelClientTabUpdate_Click(sender As Object, e As EventArgs) Handles BtnCancelClientTabUpdate.Click
        ClearTextBoxByGroupBox(GroupBoxClientTabUpdate)
    End Sub

    Private Sub BtnCancelClientTabDelete_Click(sender As Object, e As EventArgs) Handles BtnCancelClientTabDelete.Click
        For Each f As DataGridViewRow In DgvListClientTabDelete.Rows
            f.Cells("Seleccionar").Value = False
        Next
        LblEmpyClientClientTabDelete.Text = ""
        LblEmpyPhoneClientTabDelete.Text = ""
        LblEmpyMailClientTabDelete.Text = ""
    End Sub

#End Region
End Class