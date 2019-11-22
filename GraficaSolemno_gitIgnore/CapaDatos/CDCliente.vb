Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDCliente
    Dim oCDConexion As New CDConexion

    Dim da As SQLiteDataAdapter
    'esta funcion retorna un dataset con la tabla de cliente
    Function MostrarCliente() As DataTable
        Dim sentencia As String
        sentencia = "select clientes.IDCliente, clientes.Nombre, Clientes.Apellido, Clientes.DNI, Clientes.Telefono,Clientes.cuit, Provincias.Nombre as 'provincia' , Localidad.Nombre as 'Localidad', CondIVA.Nombre as 'Condicion de IVA' from Clientes, Provincias, Localidad, CondIVA where  Clientes.IDProvincia=Provincias.IDProvincia and clientes.IDLocalidad=Localidad.IDLocalidad and Clientes.IDCondIVA=CondIVA.IDIVA and Clientes.Estado='Activo'"
        Return oCDConexion.MostrarTablaModificada(sentencia)
    End Function
    Function MostrarClienteIncativo() As DataTable
        Dim sentencia As String
        sentencia = "select clientes.IDCliente, clientes.Nombre, Clientes.Apellido, Clientes.DNI, Clientes.Telefono,Clientes.cuit, Provincias.Nombre as 'provincia' , Localidad.Nombre as 'Localidad', CondIVA.Nombre as 'Condicion de IVA' from Clientes, Provincias, Localidad, CondIVA where  Clientes.IDProvincia=Provincias.IDProvincia and clientes.IDLocalidad=Localidad.IDLocalidad and Clientes.IDCondIVA=CondIVA.IDIVA and Clientes.Estado='Inactivo'"
        Return oCDConexion.MostrarTablaModificada(sentencia)
    End Function
    Public Sub RegistrarCliente(ByVal oCECliente As CECliente)
        oCDConexion.Conectar()
        Try

            Dim instruccionSQL = "INSERT INTO Clientes  (IDCliente, Nombre ,Apellido ,Telefono, Telefono2, DNI, CUIT, IDProvincia, IDLocalidad, Barrio, Domicilio, NroCalle, Dpto, CP, EMAIL, IDCondIVA, Fecha,Estado) VALUES (@IDCliente, @Nombre ,@Apellido ,@Telefono, @Telefono2, @DNI, @CUIT, @IDProvincia, @IDLocalidad, @Barrio, @Domicilio, @NroCalle, @Dpto, @CP, @EMAIL, @IDCondIVA, @Fecha, @Estado)"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDCliente", SqlDbType.Int).Value = oCECliente.IDCliente
                .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
                .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
                .Add("@Telefono", SqlDbType.Int).Value = SetNullValues(oCECliente.Telefono)
                .Add("@Telefono2", SqlDbType.Int).Value = SetNullValues(oCECliente.Telefono2)
                .Add("@DNI", SqlDbType.Int).Value = SetNullValues(oCECliente.DNI)
                .Add("@CUIT", SqlDbType.Int).Value = SetNullValues(oCECliente.CUIT)
                .Add("@IDProvincia", SqlDbType.Int).Value = oCECliente.Provincia
                .Add("@IDLocalidad", SqlDbType.Int).Value = oCECliente.Localidad
                .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
                .Add("@Domicilio", SqlDbType.VarChar).Value = oCECliente.Domicilio
                .Add("@NroCalle", SqlDbType.Int).Value = SetNullValues(oCECliente.NroCalle)
                .Add("@Dpto", SqlDbType.VarChar).Value = SetNullValues(oCECliente.Dpto)
                .Add("@CP", SqlDbType.VarChar).Value = SetNullValues(oCECliente.CP)
                .Add("@EMAIL", SqlDbType.VarChar).Value = oCECliente.Email
                .Add("@IDCondIVA", SqlDbType.Int).Value = oCECliente.CondIVA
                .Add("@Fecha", SqlDbType.VarChar).Value = oCECliente.Fecha
                ' para la integracion del estado de cliente y producto.
                .Add("@Estado", SqlDbType.VarChar).Value = "Activo"
            End With
            comando.ExecuteNonQuery()

            MsgBox("El nuevo cliente fue registrado con exito.", , "Registro de Cliente")
        Catch ex As Exception
            Dim errorCuiT As String = "CUIT"
            Dim errorDNI As String = "DNI"
            'esto es para cuando ingresas un dni o cuit que ya existe en la base de datos.
            If 0 < ex.Message.IndexOf(errorCuiT) Then
                MsgBox("El CUIT ingresado ya pertenece a un usuario registrado.", MsgBoxStyle.Exclamation, "Error al registrar")
            End If
            If 0 < ex.Message.IndexOf(errorDNI) Then
                MsgBox("El DNI ingresado ya pertenece a un usuario registrado.", MsgBoxStyle.Exclamation, "Error al registrar")
            End If
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
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
    Public Sub EliminarCliente(ByVal id As Integer, ByVal estado As String)
        oCDConexion.Conectar()
        Try
            Dim instruccionSQL = "Update Clientes set Estado=@esta WHERE (IDCliente = @IDCliente)"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = id
            comando.Parameters.Add("@esta", SqlDbType.VarChar).Value = estado
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error al mover a la papelera el cliente. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al registrar producto")
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarCliente(ByVal oCECliente As CECliente)
        oCDConexion.Conectar()
        Try
            Dim instruccionSQL = "UPDATE Clientes  SET Nombre=@Nombre ,Apellido=@Apellido ,Telefono=@Telefono, Telefono2=@Telefono2, DNI=@DNI, CUIT= @CUIT, IDProvincia=@IDProvincia, IDLocalidad=@IDLocalidad, Barrio=@Barrio, Domicilio=@Domicilio, NroCalle=@NroCalle, Dpto=@Dpto, CP=@CP, EMAIL=@EMAIL, IDCondIVA=@IDCondIVA, Fecha=@Fecha, Estado=@Estado WHERE IDCliente=@IDCliente"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDCliente", SqlDbType.Int).Value = oCECliente.IDCliente
                .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
                .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
                .Add("@Telefono", SqlDbType.Int).Value = SetNullValues(oCECliente.Telefono)
                .Add("@Telefono2", SqlDbType.Int).Value = SetNullValues(oCECliente.Telefono2)
                .Add("@DNI", SqlDbType.Int).Value = SetNullValues(oCECliente.DNI)
                .Add("@CUIT", SqlDbType.Int).Value = SetNullValues(oCECliente.CUIT)
                .Add("@IDProvincia", SqlDbType.Int).Value = oCECliente.Provincia
                .Add("@IDLocalidad", SqlDbType.Int).Value = oCECliente.Localidad
                .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
                .Add("@Domicilio", SqlDbType.VarChar).Value = oCECliente.Domicilio
                .Add("@NroCalle", SqlDbType.Int).Value = SetNullValues(oCECliente.NroCalle)
                .Add("@Dpto", SqlDbType.VarChar).Value = SetNullValues(oCECliente.Dpto)
                .Add("@CP", SqlDbType.VarChar).Value = SetNullValues(oCECliente.CP)
                .Add("@EMAIL", SqlDbType.VarChar).Value = oCECliente.Email
                .Add("@IDCondIVA", SqlDbType.Int).Value = oCECliente.CondIVA
                .Add("@Fecha", SqlDbType.VarChar).Value = oCECliente.Fecha
                .Add("@Estado", SqlDbType.VarChar).Value = "Activo"
            End With
            comando.ExecuteNonQuery()
            MsgBox("El cliente se modifico con exito.", , "Registro de producto")
        Catch ex As Exception
            MsgBox("Error al modificar el cliente. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al registrar producto")
        Finally
            oCDConexion.Desconectar()
        End Try

    End Sub
    Function BuscarInactivo(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        da = New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select Clientes.IDCliente, clientes.nombre, clientes.Apellido, clientes.Telefono, clientes.Telefono2, clientes.DNI, Clientes.CUIT ,  provincias.nombre as 'Provincia' , localidad.nombre as 'Localidad', clientes.barrio, clientes.domicilio, clientes.NroCalle, clientes.Dpto, clientes.CP ,clientes.EMAIL, CondIVA.Nombre as 'Condicion de IVA' ,clientes.Fecha from(clientes, provincias, localidad, CondIVA) where (Clientes.idprovincia = provincias.IDProvincia and clientes.IDLocalidad=Localidad.IDLocalidad and  clientes.IDCondIVA = condiva.IDIVA ) and clientes." & pcampo & "  like  '" + pbuscar + "%' and Clientes.Estado='Inactivo'"
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
            MsgBox("Error la busqueda ah fallado.", , "Busqueda de cliente")
            Return Nothing
        Finally
            oCDConexion.Desconectar()
        End Try

    End Function
    Function BuscarCliente(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            'Dim instruccionSQL = "Select * FROM Clientes where " & pcampo & "=@buscar "
            Dim instruccionSQL As String = "Select Clientes.IDCliente, clientes.nombre, clientes.Apellido, clientes.Telefono, clientes.Telefono2, clientes.DNI, Clientes.CUIT ,  provincias.nombre as 'Provincia' , localidad.nombre as 'Localidad', clientes.barrio, clientes.domicilio, clientes.NroCalle, clientes.Dpto, clientes.CP ,clientes.EMAIL, CondIVA.Nombre as 'Condicion de IVA' ,clientes.Fecha from(clientes, provincias, localidad, CondIVA) where (Clientes.idprovincia = provincias.IDProvincia and clientes.IDLocalidad=Localidad.IDLocalidad and  clientes.IDCondIVA = condiva.IDIVA ) and clientes." & pcampo & "  like  '" + pbuscar + "%' and Clientes.Estado='Activo'"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            If IsNumeric(pbuscar) Then
                comando.Parameters.Add("@pbuscar", SqlDbType.Int).Value = pbuscar
            Else
                comando.Parameters.Add("@pbuscar", SqlDbType.VarChar).Value = pbuscar
            End If
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            MsgBox("Error la busqueda ah fallado.", , "Busqueda de cliente")
            Return Nothing
        Finally
            oCDConexion.Desconectar()
        End Try

    End Function
    Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("Clientes")
    End Function

    '---------- 
    'metodos para los combobox, traer el codigo postal y el filtrado de localidades segun la provincia
    Public Function TraerCP(ByVal IDProvincia As Integer, ByVal IDLocalidad As Integer) As Integer
        Dim dt As New DataTable
        Dim cp As Integer
        oCDConexion.Conectar()
        da = New SQLiteDataAdapter
        Dim InstruccionSQL As String = "Select  localidad.cp  from (localidad, Provincias) where (provincias.IDProvincia = localidad.IDProvincia And provincias.IDProvincia =" & IDProvincia & " ) and Localidad.IDLocalidad=" & IDLocalidad
        Dim comando As New SQLiteCommand(InstruccionSQL, oCDConexion.con)
        cp = CInt(comando.ExecuteScalar())
        Return cp
        oCDConexion.Desconectar()
    End Function
    Public Function LocalidadesPorProvincia(ByVal idprovincia As Integer) As DataTable
        Dim dt As New DataTable
        oCDConexion.Conectar()
        da = New SQLiteDataAdapter

        Dim InstruccionSQL As String = "Select localidad.IDLocalidad, Localidad.Nombre   from(localidad, Provincias) where (provincias.IDProvincia = localidad.IDProvincia) And (provincias.IDProvincia =" & idprovincia & ") "

        Dim comando As New SQLiteCommand(InstruccionSQL, oCDConexion.con)
        da.SelectCommand = comando
        da.Fill(dt)
        Return dt
        oCDConexion.Desconectar()
    End Function

End Class
