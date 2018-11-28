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

            Dim InstruccionSQL As String = "Select itemsporpedido.IDItems , Productos.Nombre , itemsporpedido.cantidad ,itemsporpedido.Descripcion from pedidos join itemsporpedido on pedidos.idpedido=itemsporpedido.IDPedido join productos on  itemsporpedido.IDProducto= productos.IDProducto where  pedidos.IDPedido= " & id

            Dim comando As New SQLiteCommand(InstruccionSQL, oCDConexion.con)
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt
       

        Catch ex As Exception
            Throw New Exception("ERROR La consulta de Mostrar Detalles del pedido fallo. Descripcion:" & ex.Message)
        End Try
        oCDConexion.Desconectar()
    End Function
    Public Sub AgregarItemAlPedido(ByVal pItem As Object, ByVal tipo As String)


        'oCDConexion.Conectar()

        'Try
        '    Dim instruccionsql As String = "INSERT INTO ItemsPorPedido(IDItems, IDProducto, IDServicio, IDPedido, Cantidad, Descripcion) VALUES (@IDItems, @IDProducto, @IDServicio, @IDPedido, @Cantidad, @Descripcion)"
        '    Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
        '    With comando.Parameters
        '        .Add("@IDItems", SqlDbType.Int).Value = pListado.IDItems
        '        .Add("@IDPedido", SqlDbType.Int).Value = pListado.IDPedido
        '        .Add("@IDServicio", SqlDbType.Int).Value = oCEServicio.IDServicio
        '        .Add("@IDProducto", SqlDbType.Int).Value = oCEServicio.IDServicio
        '        .Add("@Cantidad", SqlDbType.Int).Value = pListado.Cantidad
        '        .Add("@Descripcion", SqlDbType.VarChar).Value = pListado.Descripcion
        '    End With

        '    comando.ExecuteNonQuery()

        'Catch ex As Exception
        '    Throw New Exception("Error al agregar el item al pedido." & ex.Message)
        'Finally
        '    oCDConexion.Desconectar()
        'End Try
    End Sub
    Public Sub EliminarItemDelListado(ByVal id As Integer)
        oCDConexion.Conectar()
        Dim instruccionsql As String = "DELETE FROM ItemsPorPedido WHERE (IDItems=@IDItems)"
        Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
        comando.Parameters.Add("@IDItems", SqlDbType.Int).Value = id
        comando.ExecuteNonQuery()
        oCDConexion.Desconectar()
    End Sub
    Public Sub ModificarServicio(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()
        Try



            Dim instruccionsql As String = "UPDATE Servicios SET  Nombre=@Nombre where IDServicio=@IDServicio"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDServicio", SqlDbType.Int).Value = oCEProducto.IDProducto

                '.Add("@IDItems", SqlDbType.Int).Value = pListado.IDItems
                '.Add("@IDPedido", SqlDbType.Int).Value = .IDPedido
                '.Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre
                '.Add("@Cantidad", SqlDbType.Int).Value = pListado.Cantidad
                '.Add("@Descripcion", SqlDbType.VarChar).Value = pListado.Descripcion
            End With
            comando.ExecuteNonQuery()
            MsgBox("El servicio se ha modificado con exito", vbInformation, "Modificado")

        Catch ex As Exception
            Throw New Exception("No se ah podido modificar el registro seleccionado:" & ex.Message)
        Finally
            oCDConexion.Desconectar()

        End Try
    End Sub

    Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("ItemsPorPedido")
    End Function
End Class


