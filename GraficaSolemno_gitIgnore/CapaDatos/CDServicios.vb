Imports CapaEntidad
Imports System.Data.SQLite
Public Class CDServicios
    Dim oCDConexion As New CDConexion
    Dim oCEServicio As New CEServicios
    Public Function MostrarServicios() As DataTable
        Return oCDConexion.MostrarTabla("Servicios")
    End Function
    Public Sub NuevoServicio(ByVal oCEServicio As CEServicios)
        oCDConexion.Conectar()

        Try
            Dim instruccionsql As String = "INSERT INTO Servicios (IDServicio, Nombre) VALUES (@IDServicio, @Nombre)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDServicio", SqlDbType.Int).Value = oCEServicio.IDServicio
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEServicio.Nombre
            End With
            MsgBox(instruccionsql)
            comando.executeNonQuery()

        Catch ex As Exception
            Throw New Exception("Vuelva a reintentar cargar el servicio" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarServicio(ByVal id As Integer)
        oCDConexion.Conectar()
        Dim decidir As String
        decidir = MsgBox("Esta segiro de eliminar el servicio?", vbYesNo, "Eliminar")
        If decidir = vbYes Then
            Dim instruccionsql As String = "DELETE FROM SERVICIOS WHERE (IDServicio=@IDServicio)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDServicio", SqlDbType.Int).Value = id
            comando.ExecuteNonQuery()

            MsgBox("Servicio eliminado", vbInformation, "Eliminado")

        End If
        oCDConexion.Desconectar()
    End Sub
    Public Sub ModificarServicio(ByVal oCEServicio As CEServicios)
        oCDConexion.Conectar()
        Try



            Dim instruccionsql As String = "UPDATE Servicios SET  Nombre=@Nombre where IDServicio=@IDServicio"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDServicio", SqlDbType.Int).Value = oCEServicio.IDServicio
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEServicio.Nombre
            End With
            comando.ExecuteNonQuery()
            MsgBox("El servicio se ha modificado con exito", vbInformation, "Modificado")

        Catch ex As Exception
            Throw New Exception("No se ah podido modificar el registro seleccionado:" & ex.Message)
        Finally
            oCDConexion.Desconectar()

        End Try
    End Sub
    Function BuscarServicio(ByVal pbuscar As String, ByVal campo As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try
            Dim instruccionsql As String = "SELECT * FROM Servicios WHERE " & campo & " =@pbuscar"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)

            If IsNumeric(pbuscar) Then
                comando.Parameters.Add("@pbuscar", SqlDbType.Int).Value = pbuscar
            Else
                comando.Parameters.Add("@pbuscar", SqlDbType.VarChar).Value = pbuscar
            End If


            da.SelectCommand = comando
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("El tipo de servicio que busca no se encuentra disponible" & ex.Message)
        Finally
            oCDConexion.Desconectar()

        End Try
    End Function
    Function ConsultarUltimoID() As Integer
        Return oCDConexion.ConsultarUltimoID("Servicios")
    End Function
End Class
