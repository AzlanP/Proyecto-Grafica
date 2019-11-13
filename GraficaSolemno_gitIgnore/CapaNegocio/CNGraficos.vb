Imports CapaDatos
Public Class CNGraficos

    Dim oCDGraficos As New CDGraficos
    Public Function GraficaPedidosMensuales(ByVal pmes As Integer, ByVal paño As Integer) As Integer
        Return oCDGraficos.GraficaPedidosMensuales(pmes, paño)
    End Function
    Public Function GraficarCantidadPedidosPorMedio(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
        Return oCDGraficos.GraficarCantidadPedidosPorMedio(pmes, paño)
    End Function
    Public Function GraficarProductosMensuales(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
        Return oCDGraficos.GraficarProductosMensuales(pmes, paño)
    End Function
    Public Function GraficaPedidosMensual(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
        Return oCDGraficos.GraficaPedidosMensual(pmes, paño)
    End Function
    Public Function GraficarProductosHistoricos() As DataTable
        Return oCDGraficos.GraficarProductosHistoricos()
    End Function

End Class
