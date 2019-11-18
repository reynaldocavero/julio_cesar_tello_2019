Imports CapaDatos
Public Class CNUsuario
    Public Shared Function listarCliente(ByVal xml As String) As DataTable
        Dim objCD As New CDUsuario
        Return objCD.Ins.listarUsuario(xml)
    End Function
End Class
