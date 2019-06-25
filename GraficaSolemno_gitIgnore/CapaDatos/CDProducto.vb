Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDProducto
    Dim oCDConexion As New CDConexion
    Dim oCEProducto As New CEProducto

    Public Function MostrarProducto() As DataTable
        Dim sentencia As String
        sentencia = "select * from Productos where productos.Estado='Activo'"
        Return oCDConexion.MostrarTablaModificada(sentencia)
    End Function



    Public Sub RegistrarProducto(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()

        Try
            Dim instruccionSQL = "INSERT INTO Productos (IDProducto, Nombre, Cantidad, Precio, Descripcion, Codigo, Tipo, Estado) VALUES (@IDProducto, @Nombre, @Cantidad, @Precio, @Descripcion, @Codigo,@Tipo, @Estado)"

            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDProducto", SqlDbType.Int).Value = oCEProducto.IDProducto
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre
                .Add("@Cantidad", SqlDbType.Int).Value = oCEProducto.Cantidad
                .Add("@Precio", SqlDbType.Real).Value = oCEProducto.Precio
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEProducto.Descripcion
                .Add("@Codigo", SqlDbType.VarChar).Value = oCEProducto.Codigo
                .Add("@Tipo", SqlDbType.VarChar).Value = oCEProducto.Tipo
                .Add("@Estado", SqlDbType.VarChar).Value = "Activo"
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
    Public Sub EliminarProducto(ByVal id As Integer, ByVal estado As String)
        oCDConexion.Conectar()
        Try
            Dim instruccionSQL = "Update Productos set Estado=@esta WHERE (IDProducto = @IDProducto)"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            comando.Parameters.Add("@IDProducto", SqlDbType.Int).Value = id
            comando.Parameters.Add("@esta", SqlDbType.VarChar).Value = estado
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("ERROR al eliminar el registro. Descripcion:" & ex.Message)
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

            Dim instruccionSQL = "Select * FROM Productos where " & camp & "  like  '" + pbuscar + "%' and Estado='Activo'"
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
    Function BuscarProductoInactivo(ByVal camp As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select * FROM Productos where " & camp & "  like  '" + pbuscar + "%' and Estado='Inactivo'"
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


    '--------------producto papelera-----------------
    Function MostrarProductoIncativo() As DataTable
        Dim sentencia As String
        sentencia = "select * from Productos where productos.Estado='Inactivo'"
        Return oCDConexion.MostrarTablaModificada(sentencia)
    End Function
    'Function BuscarProductoInactivo(ByVal pcampo As String, ByVal pbuscar As String) As DataTable

    'End Function
End Class
