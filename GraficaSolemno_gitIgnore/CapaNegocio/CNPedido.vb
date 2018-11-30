﻿Imports CapaEntidad
Imports CapaDatos

Public Class CNPedido
    Dim oCDPedido As New CDPedidos
    Function MostrarPedido() As DataTable
        Return oCDPedido.MostrarPedido
    End Function
    'Public Sub AgregarPedido(ByVal oCEPedido As CEPedido)
    '    oCDPedido.AgregarPedido(oCEPedido)
    'End Sub
    Public Sub GenerarElPedido(ByVal pPedido As CEPedido, ByVal TablaDetalles As DataTable)
        oCDPedido.GenerarElPedido(pPedido, TablaDetalles)
    End Sub
    Public Sub ModificarPedido(ByVal oCEPedido As CEPedido, ByVal TablaDetalles As DataTable)
        oCDPedido.ModificarPedido(oCEPedido, TablaDetalles)
    End Sub
    Public Sub EliminarPedido(ByVal IDPedido As Integer)
        oCDPedido.EliminarPedido(IDPedido)
    End Sub
    Function BuscarPedido(ByVal pcampo As String, ByVal pbuscar As String) As DataTable

        Return oCDPedido.BuscarPedido(pcampo, pbuscar)
    End Function
    Function ConsultarUltimoID() As Integer
        Return oCDPedido.ConsultarUltimoID()
    End Function
End Class
