Public Class CECliente
    Private _Id As Integer
    Private _nombre As String
    Private _tipoDoc As String
    Private _numDoc As String
    Private _activo As Integer


    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property numDoc As String
        Get
            Return _numDoc
        End Get
        Set(value As String)
            _numDoc = value
        End Set
    End Property
    Public Property tipoDoc As String
        Get
            Return _tipoDoc
        End Get
        Set(value As String)
            _tipoDoc = value
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
