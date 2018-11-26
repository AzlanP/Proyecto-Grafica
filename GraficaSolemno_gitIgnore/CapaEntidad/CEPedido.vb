Public Class CEPedido
    Private _IDPedido As Integer

    Private _Cliente As Integer
    Private _Productos() As Array
    Private _Servicios() As Array
    Private _Fecha As String
    Private _TipoDeEnvio As Integer
    Private _Descripcion As String
    Private _Medio As Integer
    Private _Estado As String
    Public Property IDPedido() As Integer
        Get
            Return _IDPedido
        End Get
        Set(ByVal value As Integer)
            _IDPedido = value
        End Set
    End Property
    Public Property Productos() As Array
        Get
            Return _Productos
        End Get
        Set(ByVal value As Array)
            _Productos = value
        End Set
    End Property
    Public Property Servicios() As Array
        Get
            Return _Servicios
        End Get
        Set(ByVal value As Array)
            _Servicios = value

        End Set
    End Property

    Public Property Medio() As Integer
        Get
            Return _Medio
        End Get
        Set(ByVal value As Integer)
            _Medio = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Public Property Cliente() As Integer
        Get
            Return _Cliente
        End Get
        Set(ByVal value As Integer)
            _Cliente = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property
    Public Property TipoDeEnvio() As Integer
        Get
            Return _TipoDeEnvio
        End Get
        Set(ByVal value As Integer)
            _TipoDeEnvio = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
End Class