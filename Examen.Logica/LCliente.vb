Imports Examen.Entidades
Imports Examen.Datos
Public Class LClient

    Public Function ListClients() As List(Of Cliente)
        Try
            Dim dCliente As New DCliente()
            Return dCliente.ListClients()
        Catch ex As Exception
            Console.WriteLine("Error en ListClients: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function FindClientsByCoincidence(parameter As String) As List(Of Cliente)
        Try
            Dim dCliente As New DCliente()
            Return dCliente.FindClientsByCoincidence(parameter)
        Catch ex As Exception
            Console.WriteLine("Error en GetClientById: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function FindClientById(parameter As String) As Cliente
        Try
            Dim dCliente As New DCliente()
            Return dCliente.FindClientById(parameter)
        Catch ex As Exception
            Console.WriteLine("Error en GetClientById: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function AddClient(cliente As Cliente) As Boolean
        Try
            Dim dCliente As New DCliente()
            Return dCliente.AddClient(cliente)
        Catch ex As Exception
            Console.WriteLine("Error en AddClient: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function UpdateClient(cliente As Cliente) As Boolean
        Try
            Dim dCliente As New DCliente()
            Return dCliente.UpdateClient(cliente)
        Catch ex As Exception
            Console.WriteLine("Error en UpdateClient: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function DeleteClient(idcliente As Integer) As Boolean
        Try
            Dim dCliente As New DCliente()
            Return dCliente.DeleteClient(idcliente)
        Catch ex As Exception
            Console.WriteLine("Error en DeleteClient: " & ex.Message)
            Throw
        End Try
    End Function

End Class
