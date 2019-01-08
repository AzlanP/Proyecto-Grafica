Imports System.Data.SQLite
Public Class CDGraficos
    Dim oCDConexion As New CDConexion
    Public Function GraficaPedidosMensuales(ByVal pmes As Integer, ByVal paño As Integer) As Integer
        oCDConexion.Conectar()
        Dim MaxDiasMes As Integer = Date.DaysInMonth(paño, pmes)
        Dim FechaInicial As String = paño & "/" & pmes & "/" & 1
        Dim FechaFinal As String = paño & "/" & pmes & "/" & MaxDiasMes
        Dim sql As String = "select count(*) from Pedidos where pedidos.fecha between '" & FechaInicial & "' AND '" & FechaFinal & "'"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim cantidad As Integer = CInt(cmd.ExecuteScalar())
        oCDConexion.Desconectar()
        Return cantidad
    End Function
    Public Function GraficarCantidadPedidosPorMedio(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
        oCDConexion.Conectar()
        Dim MaxDiasMes As Integer = Date.DaysInMonth(paño, pmes)
        Dim FechaInicial As String = paño & "/" & pmes & "/" & 1
        Dim FechaFinal As String = paño & "/" & pmes & "/" & MaxDiasMes
        Dim sql As String = " SELECT COUNT(IDPedido)  as Cantidad, Medios.Nombre FROM(medios, pedidos) where (pedidos.IDMedio = medios.IDMedio )and (  pedidos.fecha between '" & FechaInicial & "' AND '" & FechaFinal & "'" & ") GROUP BY medios.nombre"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
    End Function



    Public Function GraficarProductosMensuales(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
        oCDConexion.Conectar()
        Dim MaxDiasMes As Integer = Date.DaysInMonth(paño, pmes)
        Dim FechaInicial As String = paño & "/" & pmes & "/" & 1
        Dim FechaFinal As String = paño & "/" & pmes & "/" & MaxDiasMes
        Dim sql As String = "SELECT COUNT(*) as Cantidad , Productos.Nombre FROM(Productos, ItemsPorPedido, pedidos) where (ItemsPorPedido.IDProducto= Productos.IDProducto) and (  pedidos.fecha between '" & FechaInicial & "' AND '" & FechaFinal & "'" & ") and ( pedidos.IDPedido=ItemsPorPedido.IDPedido) GROUP BY Productos.nombre"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
    End Function
    'Public Function GraficarServiciosMensuales(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
    '    oCDConexion.Conectar()
    '    Dim MaxDiasMes As Integer = Date.DaysInMonth(paño, pmes)
    '    Dim FechaInicial As String = paño & "/" & pmes & "/" & 1
    '    Dim FechaFinal As String = paño & "/" & pmes & "/" & MaxDiasMes
    '    Dim sql As String = "SELECT COUNT(*)  as Cantidad , Servicios.Nombre FROM(Servicios, ItemsPorPedido, pedidos) where (ItemsPorPedido.IDServicio= Servicios.IDServicio ) and (  pedidos.fecha between '" & FechaInicial & "' AND '" & FechaFinal & "'" & ") and ( pedidos.IDPedido=ItemsPorPedido.IDPedido) GROUP BY Servicios.nombre"
    '    Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
    '    Dim dt As New DataTable
    '    Dim da As New SQLiteDataAdapter
    '    da.SelectCommand = cmd
    '    da.Fill(dt)
    '    oCDConexion.Desconectar()
    '    Return dt
    'End Function

End Class
