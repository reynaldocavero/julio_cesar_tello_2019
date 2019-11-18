Imports CapaDatos
Public Class CNVendedor
    Public Shared Function listarVendedor(ByVal xml As String) As DataTable
        Dim objCD As New CDVendedor
        Return objCD.Ins.listarVendedor(xml)
    End Function
End Class
