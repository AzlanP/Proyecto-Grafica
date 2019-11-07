Public Class CEPedido
    Private _IDPedido As Integer
    Private _Medio As Integer
    Private _Cliente As Integer
    Private _Fecha As String
    Private _PresupuestoVencimiento As String
    Private _Envio As String
    Private _Descripcion As String
    Private _Estado As String
    Private _Seña As Double
    Public Property IDPedido() As Integer
        Get
            Return _IDPedido
        End Get
        Set(ByVal value As Integer)
            _IDPedido = value
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
    Public Property PresupuestoVencimiento() As String
        Get
            Return _PresupuestoVencimiento
        End Get
        Set(ByVal value As String)
            _PresupuestoVencimiento = value
        End Set
    End Property
    Public Property Envio() As String
        Get
            Return _Envio
        End Get
        Set(ByVal value As String)
            _Envio = value
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
    Public Property Seña() As Double
        Get
            Return _Seña
        End Get
        Set(ByVal value As Double)
            _Seña = value
        End Set
    End Property
End Class