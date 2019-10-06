Public Class CEUsuario
    Private _IDUsuario As Integer
    Private _NombreCompleto, _Usuario, _Contrasena, _FechaCreacion, _Cargo As String
    Public Property IDUsuario() As Integer
        Get
            Return _IDUsuario
        End Get
        Set(value As Integer)
            _IDUsuario = value
        End Set
    End Property
    Public Property NombreCompleto() As String
        Get
            Return _NombreCompleto
        End Get
        Set(ByVal value As String)
            _NombreCompleto = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property
    Public Property Contrasena() As String
        Get
            Return _Contrasena
        End Get
        Set(ByVal value As String)
            _Contrasena = value
        End Set
    End Property
    Public Property FechaCreacion() As String
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As String)
            _FechaCreacion = value
        End Set
    End Property
    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property
End Class
