Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDCliente
    Dim oCDConexion As New CDConexion

    Dim da As SQLiteDataAdapter
    'esta funcion retorna un dataset con la tabla de cliente
    Function MostrarCliente() As DataTable
        Dim sentencia As String
        sentencia = "select clientes.IDCliente, clientes.Nombre, Clientes.Apellido, Clientes.DNI, Clientes.Telefono,Clientes.cuit, Provincias.Nombre as 'provincia' , Localidad.Nombre as 'Localidad', CondIVA.Nombre as 'Condicion de IVA' from Clientes, Pais, Provincias, Localidad, CondIVA where Clientes.IDPais=Pais.IDPais and Clientes.IDProvincia=Provincias.IDProvincia and clientes.IDLocalidad=Localidad.IDLocalidad and Clientes.IDCondIVA=CondIVA.IDIVA "
        Return oCDConexion.MostrarTablaModificada(sentencia)
    End Function
    Public Sub RegistrarCliente(ByVal oCECliente As CECliente)
        oCDConexion.Conectar()
        Try
            'ya la sentencia quedo bien...NO TOCAR!!!
            Dim instruccionSQL = "INSERT INTO Clientes  (IDCliente, Nombre ,Apellido ,Telefono, Telefono2, DNI, CUIT, IDPais, IDProvincia, IDLocalidad, Barrio, Domicilio, NroCalle, Dpto, CP, EMAIL, IDCondIVA, Fecha) VALUES (@IDCliente, @Nombre ,@Apellido ,@Telefono, @Telefono2, @DNI, @CUIT, @IDPais, @IDProvincia, @IDLocalidad, @Barrio, @Domicilio, @NroCalle, @Dpto, @CP, @EMAIL, @IDCondIVA, @Fecha)"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDCliente", SqlDbType.Int).Value = oCECliente.IDCliente
                .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
                .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
                .Add("@Telefono", SqlDbType.Int).Value = oCECliente.Telefono
                .Add("@Telefono2", SqlDbType.Int).Value = oCECliente.Telefono2
                .Add("@DNI", SqlDbType.Int).Value = oCECliente.DNI
                .Add("@CUIT", SqlDbType.Int).Value = oCECliente.CUIT
                .Add("@IDPais", SqlDbType.Int).Value = oCECliente.Pais
                .Add("@IDProvincia", SqlDbType.Int).Value = oCECliente.Provincia
                .Add("@IDLocalidad", SqlDbType.Int).Value = oCECliente.Localidad
                .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
                .Add("@Domicilio", SqlDbType.VarChar).Value = oCECliente.Domicilio
                .Add("@NroCalle", SqlDbType.Int).Value = oCECliente.NroCalle
                .Add("@Dpto", SqlDbType.Int).Value = oCECliente.Dpto
                .Add("@CP", SqlDbType.VarChar).Value = oCECliente.CP
                .Add("@EMAIL", SqlDbType.VarChar).Value = oCECliente.Email
                .Add("@IDCondIVA", SqlDbType.Int).Value = oCECliente.CondIVA
                .Add("@Fecha", SqlDbType.VarChar).Value = oCECliente.Fecha

            End With
            comando.ExecuteNonQuery()
            MsgBox("Se ah hecho el registro con exito")
        Catch ex As Exception
            Throw New Exception("ERROR al registrar cliente. Descripcion:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarCliente(ByVal id As Integer)
        oCDConexion.Conectar()
        Try
            Dim instruccionSQL = "DELETE FROM Clientes WHERE ( IDCliente = @IDCliente)"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = id
            comando.ExecuteNonQuery()
            MsgBox("El registro se ah eliminado exitosamente.")
        Catch ex As Exception
            Throw New Exception("ERROR al eliminar el registro. Descripcion:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarCliente(ByVal oCECliente As CECliente)
        oCDConexion.Conectar()
        Try
            Dim instruccionSQL = "UPDATE Clientes  SET Nombre=@Nombre ,Apellido=@Apellido ,Telefono=@Telefono, Telefono2=@Telefono2, DNI=@DNI, CUIT= @CUIT, IDPais=@IDPais, IDProvincia=@IDProvincia, IDLocalidad=@IDLocalidad, Barrio=@Barrio, Domicilio=@Domicilio, NroCalle=@NroCalle, Dpto=@Dpto, CP=@CP, EMAIL=@EMAIL, IDCondIVA=@IDCondIVA, Fecha=@Fecha WHERE IDCliente=@IDCliente"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDCliente", SqlDbType.Int).Value = oCECliente.IDCliente
                .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
                .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
                .Add("@Telefono", SqlDbType.VarChar).Value = oCECliente.Telefono
                .Add("@Telefono2", SqlDbType.VarChar).Value = oCECliente.Telefono2
                .Add("@DNI", SqlDbType.VarChar).Value = oCECliente.DNI
                .Add("@CUIT", SqlDbType.VarChar).Value = oCECliente.CUIT
                .Add("@IDPais", SqlDbType.Int).Value = oCECliente.Pais
                .Add("@IDProvincia", SqlDbType.Int).Value = oCECliente.Provincia
                .Add("@IDLocalidad", SqlDbType.Int).Value = oCECliente.Localidad
                .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
                .Add("@Domicilio", SqlDbType.VarChar).Value = oCECliente.Domicilio
                .Add("@NroCalle", SqlDbType.Int).Value = oCECliente.NroCalle
                .Add("@Dpto", SqlDbType.Int).Value = oCECliente.Dpto
                .Add("@CP", SqlDbType.VarChar).Value = oCECliente.CP
                .Add("@EMAIL", SqlDbType.VarChar).Value = oCECliente.Email
                .Add("@IDCondIVA", SqlDbType.Int).Value = oCECliente.CondIVA
                .Add("@Fecha", SqlDbType.VarChar).Value = oCECliente.Fecha
            End With
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("ERROR  el registro no ah podido ser modificado. Descripcion:" & ex.Message)
        End Try

    End Sub
    Function Buscar(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        da = New SQLiteDataAdapter
        Dim dt As New DataTable
        Try
            
            Dim instruccionSQL = "Select * FROM Clientes where " & pcampo & "=@buscar "
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
    Function BuscarCliente(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            'Dim instruccionSQL = "Select * FROM Clientes where " & pcampo & "=@buscar "
            Dim instruccionSQL As String = "Select Clientes.IDCliente, clientes.nombre, clientes.Apellido, clientes.Telefono, clientes.Telefono2, clientes.DNI, Clientes.CUIT ,  provincias.nombre as 'Provincia' , localidad.nombre as 'Localidad', clientes.barrio, clientes.domicilio, clientes.NroCalle, clientes.Dpto, clientes.CP ,clientes.EMAIL, CondIVA.Nombre as 'Condicion de IVA' ,clientes.Fecha from(clientes, provincias, localidad, CondIVA) where (Clientes.idprovincia = provincias.IDProvincia and clientes.IDLocalidad=Localidad.IDLocalidad and  clientes.IDCondIVA = condiva.IDIVA ) and clientes." & pcampo & "  like  '" + pbuscar + "%'"
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
            Throw New Exception("ERROR la busqueda ah fallado. Descripcion:" & ex.Message)
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
