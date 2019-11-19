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
            Dim instruccionSQL = "INSERT INTO Productos (IDProducto, Nombre, Precio, Descripcion, Codigo, Estado) VALUES (@IDProducto, @Nombre, @Precio, @Descripcion, @Codigo, @Estado)"

            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDProducto", SqlDbType.Int).Value = oCEProducto.IDProducto
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre

                .Add("@Precio", SqlDbType.Real).Value = oCEProducto.Precio
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEProducto.Descripcion
                .Add("@Codigo", SqlDbType.VarChar).Value = oCEProducto.Codigo
                .Add("@Estado", SqlDbType.VarChar).Value = "Activo"
            End With
            comando.ExecuteNonQuery()
            MsgBox("El nuevo producto ha sido registrado con exito.", MsgBoxStyle.Information, "Registro de producto")
        Catch ex As Exception
            MsgBox("Error al registrar el producto. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al registrar producto")
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
            If estado = "Activo" Then
                MsgBox("Error al mover a la papelera el producto. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al eliminar el producto")
            Else
                MsgBox("Error al restaurar el producto. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al restaurar el producto")
            End If
         Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarProducto(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = " UPDATE Productos SET Nombre=@Nombre, Precio=@Precio, Descripcion=@Descripcion, Codigo=@Codigo where IDProducto=@IDProducto"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDProducto", SqlDbType.Int).Value = oCEProducto.IDProducto
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre
                .Add("@Codigo", SqlDbType.VarChar).Value = oCEProducto.Codigo
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEProducto.Descripcion

                .Add("@Precio", SqlDbType.Real).Value = oCEProducto.Precio
            End With
            comando.ExecuteNonQuery()
            MsgBox("El producto se modifico con exito.", MsgBoxStyle.Information, "Modificar producto")
        Catch ex As Exception
            MsgBox("Error al modificar el producto. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Modificar producto")

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
            MsgBox("Error la busqueda ah fallado.", MsgBoxStyle.Exclamation, "Busqueda de producto")
            Return Nothing
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
            MsgBox("Error la busqueda ah fallado.", MsgBoxStyle.Exclamation, "Busqueda de producto")
            Return Nothing
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
    Public Function SetNullValues(ByVal value As Object) As Object
        If IsNumeric(value) Then
            If value = 0 Then
                Return DBNull.Value
            Else
                Try
                    Return CInt(value)
                Catch ex As Exception
                    Return Str(value)
                End Try

            End If

        Else
            If value = Nothing Or value = "" Then
                Return DBNull.Value
            Else
                Return CInt(value)
            End If
        End If

    End Function
End Class
