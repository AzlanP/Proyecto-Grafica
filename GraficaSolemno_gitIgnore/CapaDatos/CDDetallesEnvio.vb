﻿Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDDetallesEnvio
    Dim consulta As String
    Dim oCDConexion As New CDConexion

    Public Function InformacionDeEnvio(ByVal id As Integer) As DataTable
        consulta = "select DetallesEnvio.IDEnvio,DetallesEnvio.IDPedido, DetallesEnvio.IDCliente ,provincias.nombre as 'Provincia', localidad.nombre as 'Localidad', DetallesEnvio.Domicilio, DetallesEnvio.NroCalle, DetallesEnvio.Dpto, DetallesEnvio.CP, DetallesEnvio.Barrio, DetallesEnvio.Transporte, DetallesEnvio.NroSeguimiento, DetallesEnvio.PrecioEnvio, DetallesEnvio.FechaDespacho from DetallesEnvio,provincias,localidad where detallesenvio.IDProvincia = provincias.IDProvincia And DetallesEnvio.IDLocalidad = Localidad.IDLocalidad And detallesenvio.IDPedido = " & id
        Return oCDConexion.MostrarTablaModificada(consulta)
    End Function
   
    Public Sub RegistrarEnvio(ByVal datos As CEDetallesEnvio)
        oCDConexion.Conectar()
        consulta = "insert into DetallesEnvio(IDPedido,IDCliente,IDProvincia,IDLocalidad,Domicilio,NroCalle,Dpto,CP,Barrio,Transporte,NroSeguimiento,PrecioEnvio,FechaDespacho) values (@IDPedido,@IDCliente,@IDProvincia,@IDLocalidad,@Domicilio,@NroCalle,@Dpto,@CP,@Barrio,@Transporte,@NroSeguimiento,@PrecioEnvio,@FechaDespacho)"

        Dim cmd As New SQLiteCommand(consulta, oCDConexion.con)
        With cmd.Parameters
            .Add("@IDEnvio", SqlDbType.Int).Value = datos.IDEnvio
            .Add("@IDPedido", SqlDbType.Int).Value = datos.IDPedido
            .Add("@IDCliente", SqlDbType.Int).Value = datos.IDCliente
            .Add("@IDProvincia", SqlDbType.Int).Value = datos.Provincia
            .Add("@IDLocalidad", SqlDbType.Int).Value = datos.Localidad
            .Add("@Domicilio", SqlDbType.VarChar).Value = datos.Domicilio
            .Add("@NroCalle", SqlDbType.VarChar).Value = SetNullValues(datos.NroCalle)
            .Add("@Dpto", SqlDbType.VarChar).Value = SetNullValues(datos.Dpto)
            .Add("@CP", SqlDbType.VarChar).Value = SetNullValues(datos.CP)
            .Add("@Barrio", SqlDbType.VarChar).Value = datos.Barrio
            .Add("@Transporte", SqlDbType.VarChar).Value = datos.Transporte
            .Add("@NroSeguimiento", SqlDbType.VarChar).Value = datos.NroSeguimiento
            .Add("@PrecioEnvio", SqlDbType.VarChar).Value = datos.PrecioEnvio
            .Add("@FechaDespacho", SqlDbType.VarChar).Value = datos.FechaDespacho
        End With
        cmd.ExecuteNonQuery()
        oCDConexion.Desconectar()
    End Sub
   
    Public Sub ModificarDetallesEnvio(ByVal datos As CEDetallesEnvio)
        oCDConexion.Conectar()
        consulta = "UPDATE  DetallesEnvio SET IDCliente=@IDCliente,IDProvincia=@IDProvincia,IDLocalidad=@IDLocalidad,Domicilio=@Domicilio,NroCalle=@NroCalle,Dpto=@Dpto,CP=@CP,Barrio=@Barrio,Transporte=@Transporte,NroSeguimiento=@NroSeguimiento,PrecioEnvio=@PrecioEnvio,FechaDespacho=@FechaDespacho where IDPedido=@IDPedido "
        Dim cmd As New SQLiteCommand(consulta, oCDConexion.con)
        With cmd.Parameters
            .Add("@IDEnvio", SqlDbType.Int).Value = datos.IDEnvio
            .Add("@IDPedido", SqlDbType.Int).Value = datos.IDPedido
            .Add("@IDCliente", SqlDbType.Int).Value = datos.IDCliente
            .Add("@IDProvincia", SqlDbType.Int).Value = datos.Provincia
            .Add("@IDLocalidad", SqlDbType.Int).Value = datos.Localidad
            .Add("@Domicilio", SqlDbType.VarChar).Value = datos.Domicilio
            .Add("@NroCalle", SqlDbType.Int).Value = SetNullValues(datos.NroCalle)
            .Add("@Dpto", SqlDbType.VarChar).Value = SetNullValues(datos.Dpto)
            .Add("@CP", SqlDbType.VarChar).Value = SetNullValues(datos.CP)
            .Add("@Barrio", SqlDbType.VarChar).Value = datos.Barrio
            .Add("@Transporte", SqlDbType.VarChar).Value = datos.Transporte
            .Add("@NroSeguimiento", SqlDbType.VarChar).Value = datos.NroSeguimiento
            .Add("@PrecioEnvio", SqlDbType.VarChar).Value = datos.PrecioEnvio
            .Add("@FechaDespacho", SqlDbType.VarChar).Value = datos.FechaDespacho
        End With
        cmd.ExecuteNonQuery()
        oCDConexion.Desconectar()
    End Sub
    Public Sub EliminarInformacionEnvio(ByVal id As Integer)

        Dim dt As New DataTable
        dt = InformacionDeEnvio(id)
        oCDConexion.Conectar()
        If dt.Rows.Count > 0 Then
            consulta = "delete from DetallesEnvio where IDPedido= @IDPedido"

            Dim cmd As New SQLiteCommand(consulta, oCDConexion.con)
            With cmd.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = id
            End With
            cmd.ExecuteNonQuery()
        End If
     
        oCDConexion.Desconectar()
    End Sub
    Public Function SetNullValues(ByVal value As Object) As Object
        If IsNumeric(value) Then
            If value = 0 Then
                Return DBNull.Value
            Else
                Return CInt(value)
            End If

        Else
            If value = Nothing Or value = "" Then
                Return DBNull.Value
            Else
                Return value
            End If
        End If

    End Function
End Class
