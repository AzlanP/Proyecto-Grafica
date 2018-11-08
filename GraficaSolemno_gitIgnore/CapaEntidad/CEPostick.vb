Public Class CEPostick

    Private _IDPostick As Integer
    Private _Titulo As String
    Private _Descripcion As String
    Private _Fecha As Date
    Private _Prioridad As String

    Public Property IDPostick As Integer
        Get
            Return _IDPostick
        End Get
        Set(ByVal value As Integer)

            _IDPostick = value

        End Set
    End Property
    Public Property Titulo As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property
    Public Property Prioridad As String
        Get
            Return _Prioridad
        End Get
        Set(ByVal value As String)
            _Prioridad = value
        End Set
    End Property


End Class
