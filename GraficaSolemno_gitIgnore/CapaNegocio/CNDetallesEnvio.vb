Imports CapaDatos
Imports CapaEntidad

Public Class CNDetallesEnvio
    Dim oCDDetallesEnvio As New CDDetallesEnvio
    Dim oCEDetallesEnvio As New CEDetallesEnvio

    Public Function InformacionDeEnvio(ByVal id As Integer) As DataTable
        Return oCDDetallesEnvio.InformacionDeEnvio(id)
    End Function
    Public Sub RegistrarEnvio(ByVal datos As CEDetallesEnvio)
        oCDDetallesEnvio.RegistrarEnvio(datos)
    End Sub
    Public Sub ModificarDetallesEnvio(ByVal datos As CEDetallesEnvio)
        oCDDetallesEnvio.ModificarDetallesEnvio(datos)
    End Sub
    Public Sub EliminarInformacionEnvio(ByVal id As Integer)
        oCDDetallesEnvio.EliminarInformacionEnvio(id)
    End Sub

End Class
