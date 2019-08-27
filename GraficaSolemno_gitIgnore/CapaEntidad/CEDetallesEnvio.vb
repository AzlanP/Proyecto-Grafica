Public Class CEDetallesEnvio
    Private _IDEnvio, _IDPedido, _IDCliente, _Barrio, _Domicilio, _Dpto, _Transporte, _NroSeguimiento As String
    Private _NroCalle, _CP As Integer
    Private _PrecioEnvio As Double
    Private _Provincia, _Localidad As Integer
    Private _FechaDespacho As Date
    Public Property IDEnvio() As Integer
        Get
            Return _IDEnvio
        End Get
        Set(ByVal value As Integer)
            _IDEnvio = value
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
    Public Property IDCliente() As Integer
        Get
            Return _IDCliente
        End Get
        Set(ByVal value As Integer)
            _IDCliente = value
        End Set
    End Property
    Public Property Provincia() As Integer
        Get
            Return _Provincia
        End Get
        Set(ByVal value As Integer)
            _Provincia = value
        End Set
    End Property
    Public Property Localidad() As Integer
        Get
            Return _Localidad
        End Get
        Set(ByVal value As Integer)
            _Localidad = value
        End Set
    End Property
    Public Property Barrio() As String
        Get
            Return _Barrio
        End Get
        Set(ByVal value As String)
            _Barrio = value
        End Set
    End Property
    Public Property Domicilio() As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = value
        End Set
    End Property
    Public Property NroCalle() As Integer
        Get
            Return _NroCalle
        End Get
        Set(ByVal value As Integer)
            _NroCalle = value
        End Set
    End Property
    Public Property Dpto() As String
        Get
            Return _Dpto
        End Get
        Set(ByVal value As String)
            _Dpto = value
        End Set
    End Property
    Public Property CP() As Integer
        Get
            Return _CP
        End Get
        Set(ByVal value As Integer)
            _CP = value
        End Set
    End Property
    Public Property FechaDespacho() As Date
        Get
            Return _FechaDespacho
        End Get
        Set(ByVal value As Date)
            _FechaDespacho = value
        End Set
    End Property
    Public Property Transporte() As String
        Get
            Return _Transporte
        End Get
        Set(ByVal value As String)
            _Transporte = value
        End Set
    End Property
    Public Property NroSeguimiento() As String
        Get
            Return _NroSeguimiento
        End Get
        Set(ByVal value As String)
            _NroSeguimiento = value
        End Set
    End Property
    Public Property PrecioEnvio() As Double
        Get
            Return _PrecioEnvio
        End Get
        Set(ByVal value As Double)
            _PrecioEnvio = value
        End Set
    End Property
End Class
