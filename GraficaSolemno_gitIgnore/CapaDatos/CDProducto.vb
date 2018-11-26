Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDProducto
    Dim oCDConexion As New CDConexion
    Dim oCEProducto As New CEProducto

    Public Function MostrarProducto() As DataTable
        Return oCDConexion.MostrarTabla("Productos")
    End Function



    Public Sub RegistrarProducto(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()

        Try
            Dim instruccionSQL = "INSERT INTO Productos (IDProducto, Nombre, Cantidad, Precio, Descripcion, Codigo, Tipo) VALUES (@IDProducto, @Nombre, @Cantidad, @Precio, @Descripcion, @Codigo,@Tipo)"

            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDProducto", SqlDbType.Int).Value = oCEProducto.IDProducto
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre
                .Add("@Cantidad", SqlDbType.Int).Value = oCEProducto.Cantidad
                .Add("@Precio", SqlDbType.Real).Value = oCEProducto.Precio
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEProducto.Descripcion
                .Add("@Codigo", SqlDbType.VarChar).Value = oCEProducto.Codigo
                .Add("@Tipo", SqlDbType.VarChar).Value = oCEProducto.Tipo
            End With
            MsgBox(instruccionSQL)
            comando.ExecuteNonQuery()
            MsgBox("El Producto se ah Registrado con Exito")
        Catch ex As Exception


            Throw New Exception("ERROR al registrar " & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarProducto(ByVal id As Integer)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "DELETE FROM Productos WHERE (IDProducto=@IDProducto)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDProducto", SqlDbType.Int).Value = id
            comando.ExecuteNonQuery()

            MsgBox("Registro eliminado")
        Catch ex As Exception
            Throw New Exception("No se ah podido eliminar el registro:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try

    End Sub
    Public Sub ModificarProducto(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = " UPDATE Productos SET Nombre=@Nombre,Cantidad=@Cantidad, Precio=@Precio, Descripcion=@Descripcion, Codigo=@Codigo, Tipo=@Tipo where IDProducto=@IDProducto"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDProducto", SqlDbType.Int).Value = oCEProducto.IDProducto
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre
                .Add("@Codigo", SqlDbType.VarChar).Value = oCEProducto.Codigo
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEProducto.Descripcion
                .Add("@Cantidad", SqlDbType.Int).Value = oCEProducto.Cantidad
                .Add("@Precio", SqlDbType.Real).Value = oCEProducto.Precio
                .Add("@Tipo", SqlDbType.VarChar).Value = oCEProducto.Tipo
            End With
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("No se ah podido modificar el registro seleccionado:" & ex.Message)

        End Try

    End Sub
    Function BuscarProducto(ByVal camp As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select * FROM Productos where " & camp & "=@buscar "
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            If IsNumeric(pbuscar) Then
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = pbuscar
            Else
                comando.Parameters.Add("@buscar", SqlDbType.VarChar).Value = pbuscar
            End If
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw New Exception("ERROR la busqueda ah fallado. Descripcion:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Function
    Public Function ConsultarUltimoID() As Integer

        Return oCDConexion.ConsultarUltimoID("Productos")
        
    End Function

End Class
