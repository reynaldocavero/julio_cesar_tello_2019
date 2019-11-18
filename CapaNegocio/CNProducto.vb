Imports CapaDatos
Public Class CNProducto
    Public Shared Function listarProducto() As DataTable
        Dim objCD As New CDProducto
        Return objCD.Ins.listarProducto()
    End Function
End Class
