Public Class CEUsuario
    Private _Id As Integer
    Private _email As String
    Private _usuario As String
    Private _clave As String
    Private _activo As Integer
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property
    Public Property clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property
    Public Property activo As Integer
        Get
            Return _activo
        End Get
        Set(value As Integer)
            _activo = value
        End Set
    End Property
End Class
