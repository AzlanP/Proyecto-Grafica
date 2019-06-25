Imports CapaEntidad
Public Class FormularioEnvio
    Dim oCECliente As New CECliente
    Dim oCEPedido As New CEPedido
    Public Sub DatosCliente(ByVal Cliente As Integer)

        MsgBox(Cliente)
    End Sub


End Class