Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaNegocio
Imports Utilitario

Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function buscaClientePorRuc(ByVal xml As String) As String
        Try
            Dim dt As DataTable = CNCliente.listarCliente(xml)
            Return GetJson.GetJson(dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function buscaVendedorPorNombre(ByVal xml As String) As String
        Try
            Dim dt As DataTable = CNVendedor.listarVendedor(xml)
            Return GetJson.GetJson(dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function buscaProductoPorCodigo(ByVal xml As String) As String
        Try
            ' Dim dt As DataTable = CNProducto.listarProducto(xml)
            ' Return GetJson.GetJson(dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function listarProducto() As String
        Try
            Dim dt As DataTable = CNProducto.listarProducto()
            Return GetJson.GetJson(dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class