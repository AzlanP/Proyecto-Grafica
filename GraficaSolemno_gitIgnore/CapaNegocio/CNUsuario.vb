Imports CapaDatos
Imports CapaEntidad
Public Class CNUsuario
    Dim oCDUsuario As New CDUsuario
    Dim oCEUsuario As New CEUsuario

    Public Sub RegistrarUsuario(ByVal oCEUsuario As CEUsuario)
        oCDUsuario.RegistrarUsuario(oCEUsuario)
    End Sub

    Public Sub EliminarUsuario(ByVal id As Integer, ByVal estado As String)
        oCDUsuario.EliminarUsuario(id, estado)
    End Sub
    Public Sub ModificarUsuario(ByVal oCEUsuario As CEUsuario)
        oCDUsuario.ModificarUsuario(oCEUsuario)
    End Sub
    Function ValidarUsuario(ByVal pusuario As String, ByVal pcontrasena As String) As DataTable
        Dim dt As New DataTable
        dt = oCDUsuario.ValidarUsuario(pusuario, pcontrasena)
        Return dt
    End Function

    Function ConsultarUltimoID() As Integer
        Return oCDUsuario.ConsultarUltimoID()
    End Function
    Function BuscarUsuario(ByVal ID As Integer) As DataTable
        Return oCDUsuario.BuscarUsuario(ID)
    End Function
    Function ValidarContrasenaUsuario(ByVal pcontrasena As String, ByVal id As Integer) As Boolean
        Return oCDUsuario.ValidarContrasenaUsuario(pcontrasena, id)
    End Function
End Class
