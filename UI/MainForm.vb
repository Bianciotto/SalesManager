Public Class MainForm
    Inherits Form

    Private lblEstado As Label
    Private btnCerrar As Button
    Private btnConectar As Button


    Public Sub New()
        Me.Text = "Panel Principal"
        Me.Size = New Size(400, 250)
        Me.StartPosition = FormStartPosition.CenterScreen

        lblEstado = New Label()
        lblEstado.Text = "Estado: Sin conexión"
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(30, 30)
        Me.Controls.Add(lblEstado)

        btnConectar = New Button()
        btnConectar.Text = "Conectar BD"
        btnConectar.Size = New Size(100, 30)
        btnConectar.Location = New Point(30, 70)
        AddHandler btnConectar.Click, AddressOf ConectarBD
        Me.Controls.Add(btnConectar)

        btnCerrar = New Button()
        btnCerrar.Text = "Cerrar"
        btnCerrar.Size = New Size(100, 30)
        btnCerrar.Location = New Point(150, 70)
        AddHandler btnCerrar.Click, AddressOf CerrarApp
        Me.Controls.Add(btnCerrar)
    End Sub


    Private Sub ConectarBD(sender As Object, e As EventArgs)
        Dim dbContext As New ApplicationDbContext()
        lblEstado.Text = dbContext.OpenConnection()
    End Sub

    Private Sub CerrarApp(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class