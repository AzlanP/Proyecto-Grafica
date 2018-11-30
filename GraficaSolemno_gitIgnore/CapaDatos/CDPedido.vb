Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDPedidos
    Dim oCDConexion As New CDConexion
    Dim oCEPedido As New CEPedido
    Dim oCEDetallesDelPedido As New CEDetallesDelPedido
    Dim oCDDetallesDelPedido As New CDDetallesDelPedido
    Dim da As SQLiteDataAdapter
    Function MostrarPedido() As DataTable
        Return oCDConexion.MostrarTabla("Pedidos")
    End Function
    Public Sub GenerarElPedido(ByVal pPedido As CEPedido, ByVal TablaDetalles As DataTable)

        oCDConexion.Conectar()
        Try
            Dim instruccionsql As String = "Select * from pedidos  where pedidos.IDPedido= " & pPedido.IDPedido
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            Dim FilasAfectadas As Integer = comando.ExecuteScalar()
            If FilasAfectadas = 1 Then
                'significa que el pedido ya existe por lo que 
                '*se le agregarian mas productos
                '*se le reducirian productos
                '*se le modificarian las cantidades
                MsgBox("el pedido ya existe")

            ElseIf FilasAfectadas = 0 Then
                '*significa que el pedido no fue encontrado por lo tanto no existe
                '*debemos crear el pedido, y luego asignarle a ese pedido todos los elementos de la lista
                instruccionsql = "Insert into Pedidos (IDPedido, Descripcion ,Fecha , IDCliente, TipoEnvio, IDMedio, Estado, Seña) values (@IDPedido, @Descripcion ,@Fecha , @IDCliente, @TipoEnvio, @IDMedio, @Estado, @Seña)"
                Dim cmd As New SQLiteCommand(instruccionsql, oCDConexion.con)
                With cmd.Parameters
                    .Add("@IDPedido", SqlDbType.Int).Value = pPedido.IDPedido
                    .Add("@Descripcion", SqlDbType.VarChar).Value = pPedido.Descripcion
                    .Add("@Fecha", SqlDbType.VarChar).Value = pPedido.Fecha
                    .Add("@IDCliente", SqlDbType.Int).Value = pPedido.Cliente
                    .Add("@TipoEnvio", SqlDbType.Int).Value = pPedido.TipoDeEnvio
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
                    oCEDetallesDelPedido.IDProducto = row(5)
                    oCDDetallesDelPedido.AgregarItemAlPedido(oCEDetallesDelPedido)
                Next



            Else
                Throw New Exception("Error no puede haber 2 pedidos con el mismo ID")
            End If
        Catch ex As Exception
            Throw New Exception("Error al Cargar el pedido." & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarPedido(ByVal oCEPedido As CEPedido, ByVal TablaDetalles As DataTable)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "UPDATE Pedidos SET Descripcion=@Descripcion, Fecha=@Fecha, IDCliente=@IDCliente, TipoEnvio=@TipoEnvio, IDMedio=@IDMedio, Estado=@Estado, Seña=@Seña where  IDPedido=@IDPedido"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = oCEPedido.IDPedido
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEPedido.Descripcion
                .Add("@Fecha", SqlDbType.VarChar).Value = oCEPedido.Fecha
                .Add("@IDCliente", SqlDbType.Int).Value = oCEPedido.Cliente
                .Add("@TipoEnvio", SqlDbType.VarChar).Value = oCEPedido.TipoDeEnvio
                .Add("@IDMedio", SqlDbType.Int).Value = oCEPedido.Medio
                .Add("@Estado", SqlDbType.VarChar).Value = oCEPedido.Estado
                .Add("@Seña", SqlDbType.Real).Value = oCEPedido.Seña
            End With
            comando.ExecuteNonQuery()
            MsgBox("La modificacion se realizo con exito")
            Dim TablaBD As New DataTable
            TablaBD = oCDDetallesDelPedido.MostrarDetalles(oCEPedido.IDPedido)
            Dim i As Integer = 0
            Dim validado As Boolean = False
            For Each row As DataRow In TablaDetalles.Rows

                For Each rowBD As DataRow In TablaBD.Rows
                    validado = False
                    If row.Item(0) = rowBD.Item(0) Then
                        MsgBox("Este elemento existe por lo tanto sera modificado" & row.Item("Nombre"))
                        'se modificara
                        validado = True
                    ElseIf i = TablaBD.Rows.Count And validado = False Then
                        MsgBox("Este elemento no existe por lo tanto sera Agregado" & row.Item("Nombre"))
                        'se agrega
                        validado = True
                    End If

                Next
             
                i += 1
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
            Dim instruccionsql As String = "SELECT * FROM Pedidos WHERE " & campo & " =@pbuscar"
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
End Class