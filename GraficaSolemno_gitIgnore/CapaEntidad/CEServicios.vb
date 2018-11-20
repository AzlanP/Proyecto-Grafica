Public Class CEServicios
    Private _IDServicio As Integer
    Private _Nombre As String
    Public Property IDServicio() As Integer
        Get
            Return _IDServicio
        End Get
        Set(ByVal value As Integer)
            _IDServicio = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
End Class
