Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaNegocio
Imports Utilitario

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function buscaUsuario(ByVal xml As String) As String
        Try
            Dim dt As DataTable = CNUsuario.listarCliente(xml)
            Return GetJson.GetJson(dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class