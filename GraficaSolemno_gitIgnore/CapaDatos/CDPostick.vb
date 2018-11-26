﻿Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDPostick
    Dim oPostick As New CEPostick
    Dim oCDConexion As New CDConexion



    Public Function TablaPostick() As DataTable
        Return oCDConexion.MostrarTabla("Postick")
    End Function
    Public Sub NuevoPostick(ByVal obj As CEPostick)
        oCDConexion.Conectar()
        Dim sql As String = "insert into Postick (IDPostick, Titulo, Descripcion, Fecha) values (@IDPostick, @Titulo, @Descripcion, @Fecha)"

        Dim comando As New SQLiteCommand(sql, oCDConexion.con)
        With comando.Parameters
            .Add("@IDPostick", SqlDbType.Int).Value = ConsultarUltimoID()
            .Add("@Titulo", SqlDbType.VarChar).Value = obj.Titulo
            .Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion
            .Add("@Fecha", SqlDbType.VarChar).Value = obj.Fecha

        End With
        comando.ExecuteNonQuery()
        MsgBox("El Registro se ah guardado con exito.")
        oCDConexion.Desconectar()

    End Sub
    Public Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("Postick")
    End Function

    Public Function TraerPosticksDelDia(ByVal pfecha As Date) As Array
        Dim format As String = "yyyy/MM/d"

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
            arraypostick(i) = oPostick
        Next
        oCDConexion.Desconectar()
        Return arraypostick

    End Function
End Class
