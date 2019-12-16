Imports System.Data.SQLite
Public Class CDGraficos
    Dim oCDConexion As New CDConexion
    Public Function GraficaPedidosMensuales(ByVal pmes As Integer, ByVal paño As Integer) As Integer
        oCDConexion.Conectar()
        Dim MaxDiasMes As Integer = Date.DaysInMonth(paño, pmes)
        Dim FechaInicial As String = paño & "/" & pmes & "/" & 1
        Dim FechaFinal As String = paño & "/" & pmes & "/" & MaxDiasMes

        Dim sql As String = "select count(*) from Pedidos where pedidos.fecha between '" & FormatISO8601(FechaInicial) & "' AND '" & FormatISO8601(FechaFinal) & "'"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim cantidad As Integer = CInt(cmd.ExecuteScalar())
        oCDConexion.Desconectar()
        Return cantidad
    End Function
    Public Function GraficaPedidosMensual(ByVal pmes As Integer, ByVal paño As Integer) As DataTable
        oCDConexion.Conectar()
        Dim MaxDiasMes As Integer = Date.DaysInMonth(paño, pmes)
        Dim FechaInicial As String = paño & "/" & pmes & "/" & 1
        Dim FechaFinal As String = paño & "/" & pmes & "/" & MaxDiasMes
        Dim ConsultaSQL = "select pedidos.fecha, count(fecha) as 'pedidos' from Pedidos where pedidos.fecha between '" & FormatISO8601(FechaInicial) & "' AND '" & FormatISO8601(FechaFinal) & "' group by fecha"
        Dim cmd As New SQLiteCommand(ConsultaSQL, oCDConexion.con)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
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
        Dim sql As String = "SELECT COUNT(*) as Cantidad , Productos.Nombre FROM(Productos, ItemsPorPedido, pedidos) where (ItemsPorPedido.IDProducto= Productos.IDProducto) and (  pedidos.fecha between '" & FormatISO8601(FechaInicial) & "' AND '" & FormatISO8601(FechaFinal) & "'" & ") and ( pedidos.IDPedido=ItemsPorPedido.IDPedido) GROUP BY Productos.nombre"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
    End Function
    Public Shared Function FormatISO8601(ByVal pfecha As Date) As String

        Dim SoloFecha As String
        Dim dia, mes As String

        If pfecha.Month < 10 Then
            mes = "0" & pfecha.Month
        Else
            mes = pfecha.Month
        End If
        If pfecha.Day < 10 Then
            dia = "0" & pfecha.Day
        Else
            dia = pfecha.Day
        End If
        SoloFecha = pfecha.Year & "/" & mes & "/" & dia

        Return SoloFecha
    End Function
    Public Shared Function FormatoFechaNormal(ByVal pfecha As String) As Date
        Dim fecha As Date
        Dim OrdenarFecha() As String = pfecha.Split("/")
        Dim fechaString As String = OrdenarFecha(2) & "/" & OrdenarFecha(1) & "/" & OrdenarFecha(0)
        fecha = fechaString
        Return fecha
    End Function


    Public Function GraficarProductosHistoricos() As DataTable
        oCDConexion.Conectar()
        Dim sql As String = "select SUM(itemsPorPedido.cantidad) as Cantidad ,ItemsPorPedido.IDProducto, productos.nombre from(ItemsPorPedido, productos) where(ItemsPorPedido.IDProducto = Productos.IDProducto) group by ItemsPorPedido.IDProducto"

        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter
        'Dim sql As String = "select sum(itemsPorPedido.cantidad),ItemsPorPedido.IDProducto, productos.nombre from(ItemsPorPedido, productos) where(ItemsPorPedido.IDProducto = Productos.IDProducto) group by ItemsPorPedido.IDProducto"
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
    End Function

    'yorsh 16/11
    Public Function GraficaTopClientes() As DataTable
        oCDConexion.Conectar()
        Dim dt As New DataTable
        Dim sql As String = "select Clientes.Nombre,count(Clientes.Nombre) as 'Pedidos' from(Clientes, Pedidos)where Clientes.IDCliente=Pedidos.IDCliente and Pedidos.Estado='Completado'group by Clientes.Nombre"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim da As New SQLiteDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
    End Function

    Public Function GraficaProductosMasVendidos() As DataTable
        oCDConexion.Conectar()

        Dim sql As String = "select sum(itemsPorPedido.cantidad),ItemsPorPedido.IDProducto, productos.nombre from(ItemsPorPedido, productos) where(ItemsPorPedido.IDProducto = Productos.IDProducto) group by ItemsPorPedido.IDProducto"
        Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        oCDConexion.Desconectar()
        Return dt
    End Function

    Public Function Top10PorTabla(ByVal tabla As String, ByVal fecha As Date) As DataTable
        Dim dt As New DataTable
        Try
            oCDConexion.Conectar()

            Dim sql As String = "select sum(itemsPorPedido.cantidad),ItemsPorPedido.IDProducto, productos.nombre from(ItemsPorPedido, productos) where(ItemsPorPedido.IDProducto = Productos.IDProducto) group by ItemsPorPedido.IDProducto"
            Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
            Dim da As New SQLiteDataAdapter

            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MsgBox("Error al cargar el listado de top 10", , "Error de carga")
        Finally
            oCDConexion.Desconectar()
        End Try
        Return dt
    End Function
End Class
