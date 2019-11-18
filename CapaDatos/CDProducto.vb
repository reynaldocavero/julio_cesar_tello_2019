Imports System.Data.SqlClient
Public Class CDProducto
    Dim objConexion As New Conexion
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection

#Region "Patron Singleton"

    Private Shared oInstancia As CDProducto = Nothing
    Dim Accion As Object

    Public Shared Function Ins() As CDProducto
        If oInstancia Is Nothing Then
            oInstancia = New CDProducto()
        End If
        Return oInstancia
    End Function

#End Region

    Public Function listarProducto() As DataTable
        Dim dtTmp As New DataTable
        Try
            Using cmd As New SqlCommand()
                cmd.CommandText = "sp_listaProducto"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = objConexion.conectar
                cmd.CommandTimeout = 0
                'cmd.Parameters.Add("@xml", SqlDbType.VarChar).Value = Xml

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
