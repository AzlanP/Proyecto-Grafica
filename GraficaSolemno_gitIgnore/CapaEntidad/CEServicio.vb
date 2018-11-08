Public Class CEServicio
    Private _IDservicio As Integer
    Private _Nombre As String

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property IDServicio As Integer
        Get
            Return _IDservicio
        End Get
        Set(ByVal value As Integer)
            _IDservicio = value
        End Set
    End Property
End Class
