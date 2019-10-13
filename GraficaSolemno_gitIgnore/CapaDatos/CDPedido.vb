Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDPedidos
    Dim oCDConexion As New CDConexion
    Dim oCEPedido As New CEPedido
    Dim oCEDetallesDelPedido As New CEDetallesDelPedido
    Dim oCDDetallesDelPedido As New CDDetallesDelPedido
    Dim da As SQLiteDataAdapter
    Function MostrarPedido() As DataTable
        'Return oCDConexion.MostrarTabla("Pedidos")
        Dim consulta As String = "SELECT Pedidos.IDPedido, Clientes.nombre as 'Cliente', pedidos.Fecha, pedidos.Estado, pedidos.seña, pedidos.Descripcion FROM(Pedidos, Clientes, medios, tipoenvio) WHERE(pedidos.IDCliente = clientes.IDCliente And pedidos.IDMedio = medios.IDMedio And pedidos.IDTipoEnvio = TipoEnvio.IDTipoEnvio)"
        Return oCDConexion.MostrarTablaModificada(consulta)
    End Function
    Public Sub GenerarElPedido(ByVal pPedido As CEPedido, ByVal TablaDetalles As DataTable)

        oCDConexion.Conectar()
        Try
            'Dim instruccionsql As String = "Select * from pedidos  where pedidos.IDPedido= " & pPedido.IDPedido
            'Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            'Dim FilasAfectadas As Integer = comando.ExecuteScalar()
            'If FilasAfectadas = 1 Then
            '    'significa que el pedido ya existe por lo que 
            '    '*se le agregarian mas productos
            '    '*se le reducirian productos
            '    '*se le modificarian las cantidades
            '    MsgBox("el pedido ya existe")

            'ElseIf FilasAfectadas = 0 Then
            '    '*significa que el pedido no fue encontrado por lo tanto no existe
            '    '*debemos crear el pedido, y luego asignarle a ese pedido todos los elementos de la lista
            Dim instruccionsql As String = "Insert into Pedidos (IDPedido, Descripcion ,Fecha , IDCliente, IDTipoEnvio, IDMedio, Estado, Seña) values (@IDPedido, @Descripcion ,@Fecha , @IDCliente, @IDTipoEnvio, @IDMedio, @Estado, @Seña)"
            Dim cmd As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With cmd.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = pPedido.IDPedido
                .Add("@Descripcion", SqlDbType.VarChar).Value = pPedido.Descripcion
                .Add("@Fecha", SqlDbType.VarChar).Value = pPedido.Fecha
                .Add("@IDCliente", SqlDbType.Int).Value = pPedido.Cliente
                .Add("@IDTipoEnvio", SqlDbType.Int).Value = pPedido.TipoDeEnvio
                .Add("@IDMedio", SqlDbType.Int).Value = pPedido.Medio
                .Add("@Estado", SqlDbType.VarChar).Value = pPedido.Estado
                .Add("@Seña", SqlDbType.Real).Value = pPedido.Seña
            End With
            cmd.ExecuteNonQuery()
            For Each row As DataRow In TablaDetalles.Rows
                oCEDetallesDelPedido.IDPedido = pPedido.IDPedido
                oCEDetallesDelPedido.IDItems = row(0)
                oCEDetallesDelPedido.Nombre = row(1)
                oCEDetallesDelPedido.Cantidad = row(2)
                oCEDetallesDelPedido.Descripcion = row(3)
                oCEDetallesDelPedido.Precio = row(4)
                'considerar mostrar solo id de producto para la tabla de items el nombre es irrelevante
                oCEDetallesDelPedido.IDProducto = row(5)
                oCDDetallesDelPedido.AgregarItemAlPedido(oCEDetallesDelPedido)
            Next

        Catch ex As Exception
            Throw New Exception("Error al Cargar el pedido." & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarPedido(ByVal oCEPedido As CEPedido, ByVal TablaDetalles As DataTable)
       
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "UPDATE Pedidos SET Descripcion=@Descripcion, Fecha=@Fecha, IDCliente=@IDCliente, IDTipoEnvio=@IDTipoEnvio, IDMedio=@IDMedio, Estado=@Estado, Seña=@Seña where  IDPedido=@IDPedido"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = oCEPedido.IDPedido
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEPedido.Descripcion
                .Add("@Fecha", SqlDbType.VarChar).Value = oCEPedido.Fecha
                .Add("@IDCliente", SqlDbType.Int).Value = oCEPedido.Cliente
                .Add("@IDTipoEnvio", SqlDbType.VarChar).Value = oCEPedido.TipoDeEnvio
                .Add("@IDMedio", SqlDbType.Int).Value = oCEPedido.Medio
                .Add("@Estado", SqlDbType.VarChar).Value = oCEPedido.Estado
                .Add("@Seña", SqlDbType.Real).Value = oCEPedido.Seña
            End With
            comando.ExecuteNonQuery()
            MsgBox("La modificacion se realizo con exito")

            'eliminar tabla detalles de la base de datos 

            instruccionsql = "DELETE FROM ItemsPorPedido WHERE (IDPedido=@IDPedido)"
            comando = New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDPedido", SqlDbType.Int).Value = oCEPedido.IDPedido

            comando.ExecuteNonQuery()

            ' volver a insertar todas los registros a la tabla de pedido

            For Each row As DataRow In TablaDetalles.Rows

                oCEDetallesDelPedido.IDPedido = oCEPedido.IDPedido
                oCEDetallesDelPedido.IDItems = row(0)
                oCEDetallesDelPedido.Nombre = row(1)
                oCEDetallesDelPedido.Cantidad = row(2)
                oCEDetallesDelPedido.Descripcion = row(3)
                oCEDetallesDelPedido.Precio = row(4)
                oCEDetallesDelPedido.IDProducto = row(5)
                oCDDetallesDelPedido.AgregarItemAlPedido(oCEDetallesDelPedido)
            Next



        Catch ex As Exception
            Throw New Exception("No se pudo modificar: " & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarPedido(ByVal IDPedido As Integer)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "DELETE FROM Pedidos WHERE (IDPedido=@IDPedido)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDPedido", SqlDbType.Int).Value = IDPedido
            comando.ExecuteNonQuery()
            MsgBox("El pedido se acaba de eliminar")
        Catch ex As Exception
            Throw New Exception("No se pudo eliminar:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("Pedidos")
    End Function
    Function BuscarPedido(ByVal campo As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try
            Dim instruccionsql As String = "SELECT Pedidos.IDPedido, pedidos.Descripcion, pedidos.Fecha, Clientes.nombre || ' ' || Clientes.apellido as 'cliente' , tipoenvio.Nombre as 'TipoEnvio', medios.nombre as 'Medio', pedidos.Estado, pedidos.seña, Clientes.apellido as 'Apellido' FROM Pedidos, Clientes, medios, tipoenvio WHERE " & campo & " =@pbuscar  and (pedidos.IDCliente=clientes.IDCliente and pedidos.IDMedio= medios.IDMedio and pedidos.IDTipoEnvio = TipoEnvio.IDTipoEnvio )"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)

            If IsNumeric(pbuscar) Then
                comando.Parameters.Add("@pbuscar", SqlDbType.Int).Value = pbuscar
            Else
                comando.Parameters.Add("@pbuscar", SqlDbType.VarChar).Value = pbuscar
            End If


            da.SelectCommand = comando
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("El tipo de servicio que busca no se encuentra disponible" & ex.Message)
        Finally
            oCDConexion.Desconectar()

        End Try
    End Function
    Public Function ValidarEliminarPedido(ByVal ID As Integer) As Boolean
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Dim InstruccionSQL As String = " SELECT Pedidos.IDPedido,Clientes.nombre as 'Nombre Cliente' ,Clientes.apellido as 'Apellido Cliente', pedidos.Descripcion, pedidos.Fecha,  pedidos.Estado FROM(Pedidos, Clientes, medios, tipoenvio) WHERE  (pedidos.IDCliente=clientes.IDCliente and pedidos.IDMedio= medios.IDMedio and pedidos.IDTipoEnvio = TipoEnvio.IDTipoEnvio ) and clientes.IDCliente=" & ID & " and pedidos.estado='Pendiente'"
        Dim comando As New SQLiteCommand(InstruccionSQL, oCDConexion.con)
        da.SelectCommand = comando
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim NombreCliente As String = ""
            For Each row As DataRow In dt.Rows
                NombreCliente = row(1) + " " + row(2) ' hago esto para guardar en cliente se guardara nombre y apellido
            Next

            'en un futuro hacer una descripcion mas detallada de los pedidos del cliente.
            MsgBox("Fallo mover a la pepelera. El cliente " & NombreCliente & " tiene " & dt.Rows.Count & " pedido/s pendiente/s.", , "Mover a la papelera")
            Return False
        Else
            Return True
        End If
        oCDConexion.Desconectar()
    End Function
End Class