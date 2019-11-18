Imports System.Data.SqlClient
Imports CapaEntidad
Public Class CDUsuario
    Dim objConexion As New Conexion
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection

#Region "Patron Singleton"

    Private Shared oInstancia As CDUsuario = Nothing
    Dim Accion As Object

    Public Shared Function Ins() As CDUsuario
        If oInstancia Is Nothing Then
            oInstancia = New CDUsuario()
        End If
        Return oInstancia
    End Function

#End Region

    Public Function listarUsuario(ByVal xml As String) As DataTable
        Dim dtTmp As New DataTable
        Try
            Using cmd As New SqlCommand()
                cmd.CommandText = "sp_usuario"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = objConexion.conectar
                cmd.CommandTimeout = 0
                cmd.Parameters.Add("@xml", SqlDbType.VarChar).Value = xml

                objConexion.conectar.Open()
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                adapter.Fill(dtTmp)
            End Using
            Return dtTmp
        Catch ex1 As SqlException
            Throw ex1
        Catch ex As Exception
            Throw ex
        Finally
            'destruyeconexion(objConexion)
        End Try
    End Function
End Class
