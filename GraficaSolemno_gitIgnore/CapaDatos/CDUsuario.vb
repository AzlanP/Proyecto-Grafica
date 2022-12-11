Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDUsuario
    Dim oCDConexion As New CDConexion
    Dim oCEUsuario As New CEUsuario



    Public Sub MostrarUsuarios()

    End Sub
    Public Sub RegistrarUsuario(ByVal oCEUsuario As CEUsuario)
        oCDConexion.Conectar()

        Try
            Dim instruccionSQL = "INSERT INTO Usuarios ( NombreCompleto, Usuario, Contrasena, FechaCreacion, Cargo, Estado) VALUES (@NombreCompleto, @Usuario, @Contrasena, @FechaCreacion, @Cargo, @Estado)"

            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDUsuario", SqlDbType.Int).Value = oCEUsuario.IDUsuario
                .Add("@NombreCompleto", SqlDbType.VarChar).Value = oCEUsuario.NombreCompleto
                .Add("@Usuario", SqlDbType.VarChar).Value = oCEUsuario.Usuario
                .Add("@Contrasena", SqlDbType.VarChar).Value = oCEUsuario.Contrasena
                .Add("@FechaCreacion", SqlDbType.VarChar).Value = oCEUsuario.FechaCreacion
                .Add("@Cargo", SqlDbType.VarChar).Value = oCEUsuario.Cargo
                .Add("@Estado", SqlDbType.VarChar).Value = "Activo"
            End With
            comando.ExecuteNonQuery()
            MsgBox("El nuevo Usuario se fue registrado con exito.", , "Registro de Usuario")
        Catch ex As Exception
            MsgBox("Error al registrar el Usuario. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al registrar Usuario")
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarUsuario(ByVal id As Integer, ByVal estado As String)
        oCDConexion.Conectar()
        Try
            'Dim instruccionSQL = "Update Usuarios set Estado=@esta WHERE (IDUsuario = @IDUsuario)"
            'Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            'comando.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = id
            'comando.Parameters.Add("@esta", SqlDbType.VarChar).Value = estado
            'comando.ExecuteNonQuery()
            Dim instruccionsql = "DELETE FROM Usuarios WHERE (IDUsuario = @IDUsuario)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = id

            comando.ExecuteNonQuery()

        Catch ex As Exception
            'If estado = "Activo" Then
            MsgBox("Error al eliminar el Usuario. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al eliminar el Usuario")
            'Else
            '    MsgBox("Error al restaurar el Usuario. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Error al restaurar el Usuario")
            'End If
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarUsuario(ByVal oCEUsuario As CEUsuario)
        oCDConexion.Conectar()
        Try
            Dim passwordIsNothing As Boolean = IsNothing(oCEUsuario.Contrasena)
            Dim addPasswordText As String = IIf(passwordIsNothing, "", "Contrasena=@Contrasena, ")
            Dim instruccionsql = " UPDATE Usuarios SET " & addPasswordText & " Cargo=@Cargo where IDUsuario=@IDUsuario and Usuario=@Usuario"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDUsuario", SqlDbType.Int).Value = oCEUsuario.IDUsuario
                .Add("@Usuario", SqlDbType.VarChar).Value = oCEUsuario.Usuario

                .Add("@Cargo", SqlDbType.VarChar).Value = oCEUsuario.Cargo
            End With

            If Not passwordIsNothing Then
                comando.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = oCEUsuario.Contrasena
            End If
            comando.ExecuteNonQuery()
            MsgBox("El Usuario se modifico con exito.", , "Modificar Usuario")
        Catch ex As Exception
            MsgBox("Error al modificar el Usuario. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Modificar Usuario")

        End Try

    End Sub
    Function ValidarUsuario(ByVal pusuario As String, ByVal pcontrasena As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select * FROM Usuarios where Usuario=@usuario and Contrasena=@contrasena"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = pusuario
            comando.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = pcontrasena
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            MsgBox("Error la busqueda ah fallado.", , "Busqueda de Usuario")
            Return Nothing
        Finally
            oCDConexion.Desconectar()
        End Try
    End Function
    Function ValidarContrasenaUsuario(ByVal pcontrasena As String, ByVal id As Integer) As Boolean
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select Count(*) FROM Usuarios where IDUsuario=@IDUsuario and Contrasena=@contrasena"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            comando.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = id
            comando.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = pcontrasena
            Dim value As Integer = CInt(comando.ExecuteScalar())
            If value = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error la busqueda ah fallado.", , "Busqueda de Usuario")
            Return Nothing
        Finally
            oCDConexion.Desconectar()
        End Try
    End Function

    Function BuscarUsuario(ByVal ID As Integer) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select * FROM Usuarios where IDUsuario=@ID"
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            da.SelectCommand = comando
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            MsgBox("Error la busqueda ah fallado.", , "Busqueda de Usuario")
            Return Nothing
        Finally
            oCDConexion.Desconectar()
        End Try
    End Function
    Public Function ConsultarUltimoID() As Integer

        Return oCDConexion.ConsultarUltimoID("Usuarios")

    End Function



End Class
