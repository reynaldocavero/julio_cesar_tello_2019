Imports System.Configuration
Imports System.Data.SqlClient
Public Class Conexion
    Dim conexion As SqlConnection
    Public Function conectar()
        conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return conexion
    End Function
End Class
