
Imports CapaDatos
Imports CapaEntidad
Public Class CNDetallesDelPedido

    Dim oCDDetallesDelPedido As New CDDetallesDelPedido
    Public Function MostrarDetalles(ByVal id As Integer) As DataTable
        Return oCDDetallesDelPedido.MostrarDetalles(id)
    End Function
    Public Sub AgregarItemAlPedido(ByVal pItem As CEDetallesDelPedido)

        oCDDetallesDelPedido.AgregarItemAlPedido(pItem)
    End Sub
    Public Sub Eliminaritemdelistado(ByVal id As Integer)
        oCDDetallesDelPedido.EliminarItemDelListado(id)
    End Sub


    Function ConsultarUltimoID() As Integer
        Return oCDDetallesDelPedido.ConsultarUltimoID
    End Function


End Class
