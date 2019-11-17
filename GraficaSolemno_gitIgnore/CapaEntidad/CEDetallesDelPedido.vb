Public Class CEDetallesDelPedido
    Private _IDPedido As Integer
    Private _IDItems As Integer
    Private _IDProducto As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Cantidad As Integer = 1
    Private _PrecioUnitario As Double = 0.0
    Private _PrecioFinal As Double = 0.0
    Private _Descuento As Integer = 0
    Public Property IDItems() As Integer
        Get
            Return _IDItems
        End Get
        Set(ByVal value As Integer)
            _IDItems = value
        End Set
    End Property
    Public Property Descuento() As Integer
        Get
            Return _Descuento
        End Get
        Set(ByVal value As Integer)
            _Descuento = value
        End Set
    End Property
    Public Property IDProducto() As Integer
        Get
            Return _IDProducto
        End Get
        Set(ByVal value As Integer)
            _IDProducto = value
        End Set
    End Property
    Public Property IDPedido() As Integer
        Get
            Return _IDPedido
        End Get
        Set(ByVal value As Integer)
            _IDPedido = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
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

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property PrecioUnitario() As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Double)
            _PrecioUnitario = value
        End Set
    End Property
    Public Property PrecioFinal() As Double
        Get
            Return _PrecioFinal
        End Get
        Set(ByVal value As Double)
            _PrecioFinal = value
        End Set
    End Property

End Class
