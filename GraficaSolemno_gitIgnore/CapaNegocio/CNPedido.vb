Imports CapaEntidad
Imports CapaDatos

Public Class CNPedido
    Dim oCDPedido As New CDPedidos
    Function MostrarPedido() As DataTable
        Return oCDPedido.MostrarPedido
    End Function
    Public Sub AgregarPedido(ByVal oCEPedido As CEPedidos)
        oCDPedido.AgregarPedido(oCEPedido)
    End Sub
    Public Sub ModificarPedido(ByVal oCEPedido As CEPedidos)
        oCDPedido.ModificarPedido(oCEPedido)
    End Sub
    Public Sub EliminarPedido(ByVal IDPedido As Integer)
        oCDPedido.EliminarPedido(IDPedido)
    End Sub
    Function BuscarPedido(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        Dim dt As New DataTable
        dt = oCDPedido.BuscarPedido(pcampo, pbuscar)
        Return dt
    End Function
    Function ConsultarUltimoID() As Integer
        Return oCDPedido.ConsultarUltimoID()
    End Function
End Class
