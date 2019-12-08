Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDPostick
    Dim oPostick As New CEPostick
    Dim oCDConexion As New CDConexion



    Public Function TablaPostick() As DataTable
        Return oCDConexion.MostrarTabla("Postick")
    End Function
    Public Sub NuevoPostick(ByVal obj As CEPostick)
      
        Try

            oCDConexion.Conectar()
            Dim sql As String = "insert into Postick (IDPostick, Titulo, Descripcion, Fecha, Prioridad, Responsable, Estado) values (@IDPostick, @Titulo, @Descripcion, @Fecha, @Prioridad, @Responsable, @Estado)"

            Dim comando As New SQLiteCommand(sql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDPostick", SqlDbType.Int).Value = obj.IDPostick
                .Add("@Titulo", SqlDbType.VarChar).Value = obj.Titulo
                .Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion
                .Add("@Fecha", SqlDbType.VarChar).Value = obj.Fecha
                .Add("@Prioridad", SqlDbType.VarChar).Value = obj.Prioridad
                .Add("@Responsable", SqlDbType.VarChar).Value = obj.Responsable
                .Add("@Estado", SqlDbType.VarChar).Value = obj.Estado
            End With
            comando.ExecuteNonQuery()
            MsgBox("El Registro se ah guardado con exito.")
            oCDConexion.Desconectar()

        Catch ex As Exception
            MsgBox("Error la busqueda ah fallado.", MsgBoxStyle.Exclamation, "Busqueda de producto")
        End Try
      

    End Sub
    Public Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("Postick")
    End Function

    Public Function TraerPosticksDelDia(ByVal pfecha As Date) As Array
        Dim format As String = "yyyy/MM/dd"

        Dim FechaString As String = pfecha.ToString(format)

        ' Este metodo al ingresar una fecha como parametro, consulta con la base de datos
        ' y esta retorna todos los posticks que se encuentren ese dia , estos son guardados en 
        ' un array el cual es devuelto por medio del return
        oCDConexion.Conectar()
        Dim sql As String = "select * from Postick where (Fecha= '" & FechaString & "')"
        Dim comando As New SQLiteCommand(sql, oCDConexion.con)
        'With comando.Parameters

        '    .Add(@Fecha, SqlDbType.VarChar).Value = pfecha

        'End With
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = comando
        da.Fill(dt)


        Dim total As Integer = dt.Rows.Count - 1
        Dim arraypostick(total) As CEPostick

        For i = 0 To total
            Dim oPostick As New CEPostick
            oPostick.IDPostick = dt.Rows(i)(0)
            oPostick.Titulo = dt.Rows(i)(1)
            oPostick.Descripcion = dt.Rows(i)(2)
            oPostick.Fecha = dt.Rows(i)(3)
            oPostick.Prioridad = dt.Rows(i)(4)
            oPostick.Responsable = dt.Rows(i)(5)
            oPostick.Estado = dt.Rows(i)(6)
            arraypostick(i) = oPostick
        Next
        oCDConexion.Desconectar()
        Return arraypostick

    End Function
    Public Function BuscarPostick(ByVal id As Integer) As CEPostick
        oCDConexion.Conectar()
        Dim sql As String = "select * from Postick where (IDPostick= '" & id & "')"
        Dim comando As New SQLiteCommand(sql, oCDConexion.con)
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = comando
        da.Fill(dt)

        Dim oPostick As New CEPostick
        oPostick.IDPostick = dt.Rows(0)(0)
        oPostick.Titulo = dt.Rows(0)(1)
        oPostick.Descripcion = dt.Rows(0)(2)
        oPostick.Fecha = dt.Rows(0)(3)
        oPostick.Prioridad = dt.Rows(0)(4)
        oPostick.Responsable = dt.Rows(0)(5)
        oPostick.Estado = dt.Rows(0)(6)
        oCDConexion.Desconectar()


        Return oPostick
    End Function
    Public Sub EliminarPostick(ByVal id As Integer)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "DELETE FROM Postick WHERE (IDPostick=@IDPostick)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDPostick", SqlDbType.Int).Value = id
            comando.ExecuteNonQuery()

            MsgBox("Registro eliminado")
        Catch ex As Exception
            Throw New Exception("No se ah podido eliminar el registro:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try

    End Sub
    Public Sub ModificarPostick(ByVal obj As CEPostick)
        oCDConexion.Conectar()
        Dim sql As String = "update Postick set Titulo=@Titulo, Descripcion=@Descripcion, Fecha=@Fecha, Prioridad=@Prioridad, Responsable=@Responsable, Estado=@Estado where IDPostick=@IDPostick"

        Dim comando As New SQLiteCommand(sql, oCDConexion.con)
        With comando.Parameters
            .Add("@IDPostick", SqlDbType.Int).Value = obj.IDPostick
            .Add("@Titulo", SqlDbType.VarChar).Value = obj.Titulo
            .Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion
            .Add("@Fecha", SqlDbType.VarChar).Value = obj.Fecha
            .Add("@Prioridad", SqlDbType.VarChar).Value = obj.Prioridad
            .Add("@Responsable", SqlDbType.VarChar).Value = obj.Responsable
            .Add("@Estado", SqlDbType.VarChar).Value = obj.Estado
        End With
        comando.ExecuteNonQuery()
        MsgBox("El Registro se ah guardado con exito.")
        oCDConexion.Desconectar()

    End Sub
End Class
