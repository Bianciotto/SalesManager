Imports System.Configuration
Imports System.Data.SqlClient

Public Class ApplicationDbContext
    Private ReadOnly _connectionString As String

    Public Sub New()
        ' connectionString desde App.config
        _connectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(_connectionString)
    End Function

    Public Function OpenConnection() As String
        Try
            Using conn As SqlConnection = New ApplicationDbContext().GetConnection()
                conn.Open()
                Return "✅ Conexión exitosa"
            End Using
        Catch ex As Exception
            Return "❌ Error: " & ex.Message
        End Try
    End Function

    Public Function CloseConnection() As String
        Try
            Using conn As SqlConnection = New ApplicationDbContext().GetConnection()
                conn.Close()
                Return "✅ Conexión exitosa"
            End Using
        Catch ex As Exception
            Return "❌ Error: " & ex.Message
        End Try
    End Function

End Class
