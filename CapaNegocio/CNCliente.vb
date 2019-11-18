Imports CapaDatos
Public Class CNCliente
    Public Shared Function listarCliente(ByVal xml As String) As DataTable
        Dim objCD As New CDCliente
        Return objCD.Ins.listarCliente(xml)
    End Function
End Class
