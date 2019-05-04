Public Class CECliente
    'tendria que ver si es mejor referirse como Localidad o localidad
    Dim oCECliente As CECliente

    Private _Telefono, _Telefono2, _CUIT, _DNI, _IDCliente, _Nombre, _Apellido, _Email, _Barrio, _Domicilio As String
    Private _NroCalle, _Dpto, _CP As Integer
    Private _Pais, _Provincia, _Localidad, _CondIVA As Integer
    Private _Fecha As Date

    'SET and GET de las variables
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    Public Property Pais() As Integer
        Get
            Return _Pais
        End Get
        Set(ByVal value As Integer)
            _Pais = value
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
    Public Property CondIVA() As Integer
        Get
            Return _CondIVA
        End Get
        Set(ByVal value As Integer)
            _CondIVA = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Telefono2() As String
        Get
            Return _Telefono2
        End Get
        Set(ByVal value As String)
            _Telefono2 = value
        End Set
    End Property
    Public Property CUIT() As String
        Get
            Return _CUIT
        End Get
        Set(ByVal value As String)
            _CUIT = value
        End Set
    End Property
    Public Property DNI() As String
        Get
            Return _DNI
        End Get
        Set(ByVal value As String)
            _DNI = value
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
    Public Property Dpto() As Integer
        Get
            Return _Dpto
        End Get
        Set(ByVal value As Integer)
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
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
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
End Class
