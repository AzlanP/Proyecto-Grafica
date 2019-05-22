Imports CapaDatos
Imports CapaEntidad
'prueba para el git ignore
Public Class CNCliente
    Dim oCDCliente As New CDCliente
    'por buenas practicas la funcion llevara el mismo nombre que en la capa de datos
    Function MostrarCliente() As DataTable
        Return oCDCliente.MostrarCliente
    End Function
    Public Sub RegistrarCliente(ByVal oCECliente As CECliente)
        oCDCliente.RegistrarCliente(oCECliente)
    End Sub
    Public Sub EliminarCliente(ByVal id As Integer, ByVal estado As String)
        oCDCliente.EliminarCliente(id, estado)
    End Sub
    Public Sub ModificarCliente(ByVal oCECliente As CECliente)
        oCDCliente.ModificarCliente(oCECliente)
    End Sub
    Function BuscarInactivo(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        Dim dt As New DataTable
        dt = oCDCliente.BuscarCliente(pcampo, pbuscar)
        Return dt
    End Function
    Function BuscarCliente(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        Return oCDCliente.BuscarCliente(pcampo, pbuscar)
    End Function
    Function ConsultarUltimoID() As Integer
        Return oCDCliente.ConsultarUltimoID()
    End Function

    '---- metodos combobox
    Public Function TraerCP(ByVal IDProvincia As Integer, ByVal IDLocalidad As Integer) As Integer
        Return oCDCliente.TraerCP(IDProvincia, IDLocalidad)
    End Function
    Public Function LocalidadesPorProvincia(ByVal idprovincia As Integer) As DataTable
        Return oCDCliente.LocalidadesPorProvincia(idprovincia)
    End Function
    '-----------Para restaurar el cliente "eliminado"
    Function MostrarClienteIncativo() As DataTable
        Return oCDCliente.MostrarClienteIncativo()
    End Function
End Class
