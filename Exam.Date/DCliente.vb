Imports Examen.Entidades
Imports System.Data.SqlClient
Public Class DCliente
    Inherits ApplicationDbContext
    Public Function ListClients() As List(Of Cliente)
        Try
            Dim clients As New List(Of Cliente)()
            Dim query As String = "SELECT ID, Cliente, Telefono, Correo FROM Clientes"
            Using connection As SqlConnection = ApplicationDbContext.GetConnection
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            clients.Add(MapClient(reader))
                        End While
                    End Using
                End Using
            End Using
            Return clients
        Catch ex As Exception
            Console.WriteLine("Error en ListClients: " & ex.Message)
            Throw
        End Try
    End Function

    Private Function MapClient(reader As SqlDataReader) As Cliente
        Return New Cliente() With {
        .Id = reader.GetInt32(0),
        .Cliente = If(reader.IsDBNull(1), "", reader.GetString(1)),
        .Telefono = If(reader.IsDBNull(2), "", reader.GetString(2)),
        .Correo = If(reader.IsDBNull(3), "", reader.GetString(3))
    }
    End Function

    Public Function FindClientsByCoincidence(parameter As String) As List(Of Cliente)
        Dim result As New List(Of Cliente)
        Try
            Using connection As SqlConnection = ApplicationDbContext.GetConnection()
                connection.Open()
                Dim query As String = "
                    SELECT Id, Cliente, Telefono, Correo 
                    FROM Clientes  
                    WHERE Cliente LIKE @Parameter  
                    OR Telefono LIKE @Parameter    
                    OR Correo LIKE @Parameter"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@Parameter", SqlDbType.NVarChar).Value = "%" & parameter & "%"
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim cliente As New Cliente With {
                                .Id = If(reader.IsDBNull(reader.GetOrdinal("Id")), 0, Convert.ToInt32(reader("Id"))),
                                .Cliente = If(reader.IsDBNull(reader.GetOrdinal("Cliente")), "", reader("Cliente").ToString()),
                                .Telefono = If(reader.IsDBNull(reader.GetOrdinal("Telefono")), "", reader("Telefono").ToString()),
                                   .Correo = If(reader.IsDBNull(reader.GetOrdinal("Correo")), "", reader("Correo").ToString())
}
                            result.Add(cliente)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("FindClientByCoincidence: " & ex.Message)
            Throw
        End Try
        Return result
    End Function

    Public Function AddClient(client As Cliente) As Boolean
        Try
            Dim query As String = "INSERT INTO Clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Correo, @Telefono)"
            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Cliente", client.Cliente)
                    command.Parameters.AddWithValue("@Telefono", client.Telefono)
                    command.Parameters.AddWithValue("@Correo", client.Correo)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en AddClient: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function UpdateClient(client As Cliente) As Boolean
        Try
            Dim query As String = "UPDATE Clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @Id"
            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Id", client.Id)
                    command.Parameters.AddWithValue("@Cliente", client.Cliente)
                    command.Parameters.AddWithValue("@Telefono", client.Telefono)
                    command.Parameters.AddWithValue("@Correo", client.Correo)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en UpdateClient: " & ex.Message)
            Throw
        End Try
    End Function

    Public Function DeleteClient(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Clientes WHERE ID = @Id"
            Using conn As SqlConnection = ApplicationDbContext.GetConnection()
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Id", id)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en DeleteClient: " & ex.Message)
            Throw
        End Try
    End Function
    'puede ser que la use para mas filtros
    Public Function FindClientById(id As Integer) As Cliente
        Try
            Dim query As String = "
                SELECT ID, Cliente, Telefono, Correo
                FROM Clientes
                WHERE ID = @Id"
            Using connection As SqlConnection = ApplicationDbContext.GetConnection()
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Id", id)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Return MapClient(reader)
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error en FindClientById: " & ex.Message)
            Throw
        End Try
    End Function
End Class
