Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDDetallesDelPedido

    Dim oCDConexion As New CDConexion
    Dim oCEProducto As New CEProducto


    Public Function MostrarDetalles(ByVal id As Integer) As DataTable
        oCDConexion.Conectar()
        Try
            Dim dt As New DataTable
            Dim da As New SQLiteDataAdapter
            Dim InstruccionSQL As String = "Select itemsporpedido.IDItems , Productos.Nombre , itemsporpedido.cantidad ,itemsporpedido.Descripcion, itemsporpedido.Descuento, itemsporpedido.PrecioUnitario,itemsporpedido.PrecioFinal ,itemsporpedido.IDProducto from pedidos join itemsporpedido on pedidos.idpedido=itemsporpedido.IDPedido join productos on  itemsporpedido.IDProducto= productos.IDProducto where  pedidos.IDPedido= " & id
            Dim comando As New SQLiteCommand(InstruccionSQL, oCDConexion.con)
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt
       

        Catch ex As Exception
            Throw New Exception("ERROR La consulta de Mostrar Detalles del pedido fallo. Descripcion:" & ex.Message)
        End Try
        oCDConexion.Desconectar()
    End Function
    Public Sub AgregarItemAlPedido(ByVal pItem As CEDetallesDelPedido)


        oCDConexion.Conectar()

        Try
            Dim instruccionsql As String = "INSERT INTO ItemsPorPedido (IDItems, IDProducto, IDPedido, Cantidad, Descripcion, Precio) VALUES (@IDItems, @IDProducto, @IDPedido, @Cantidad, @Descripcion, @Precio)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDItems", SqlDbType.Int).Value = pItem.IDItems
                .Add("@IDProducto", SqlDbType.Int).Value = pItem.IDProducto
                .Add("@IDPedido", SqlDbType.Int).Value = pItem.IDPedido
                .Add("@Cantidad", SqlDbType.Real).Value = pItem.Cantidad
                .Add("@Descripcion", SqlDbType.VarChar).Value = pItem.Descripcion
                .Add("@Precio", SqlDbType.Real).Value = pItem.Precio
            End With

            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception("Error al agregar el item al pedido." & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarItemDelListado(ByVal id As Integer)
        oCDConexion.Conectar()
        Dim instruccionsql As String = "DELETE FROM ItemsPorPedido WHERE (IDItems=@IDItems)"
        Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
        comando.Parameters.Add("@IDItems", SqlDbType.Int).Value = id
        comando.ExecuteNonQuery()
        oCDConexion.Desconectar()
    End Sub
    Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("ItemsPorPedido")
    End Function
    Public Sub ModificarItem(ByVal oDetalles As CEDetallesDelPedido)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql As String = "UPDATE ItemsPorPedido SET  IDProducto=@IDProducto, Descripcion=@Descripcion, Cantidad=@Cantidad, Precio=@Precio where IDItems=@IDItems and IDPedido=@IDPedido "
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = oDetalles.IDPedido
                .Add("@IDItems", SqlDbType.Int).Value = oDetalles.IDItems
                .Add("@IDProducto", SqlDbType.Int).Value = oDetalles.IDProducto
                .Add("@Descripcion", SqlDbType.VarChar).Value = oDetalles.Descripcion
                .Add("@Cantidad", SqlDbType.Real).Value = oDetalles.Cantidad
                .Add("@Precio", SqlDbType.Real).Value = oDetalles.Precio
            End With

            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception("Error al modificar el producto o servicio del pedido." & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub

End Class


