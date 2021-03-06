﻿Imports CapaDatos
Imports CapaEntidad
Public Class CNPostick
    Dim oCEPostick As New CEPostick
    Dim oCDPostick As New CDPostick
    Public Function TablaPostick() As DataTable
        Return oCDPostick.TablaPostick()
    End Function
    Public Sub NuevoPostick(ByVal obj As CEPostick)
        oCDPostick.NuevoPostick(obj)
    End Sub
    Public Function ConsultarUltimoID() As Integer
        Return oCDPostick.ConsultarUltimoID()
    End Function

    Public Function TraerPosticksDelDia(ByVal pfecha As Date) As Array
        Return ocdpostick.TraerPosticksDelDia(pfecha)
    End Function
    Public Function BuscarPostick(ByVal id As Integer) As CEPostick
        Return oCDPostick.BuscarPostick(id)
    End Function
    Public Sub EliminarPostick(ByVal id As Integer, ByVal motivo As String, ByVal responsable As String)
        oCDPostick.EliminarPostick(id, motivo, responsable)
    End Sub
    Public Sub ModificarPostick(ByVal oCEPostick As CEPostick)
        oCDPostick.ModificarPostick(oCEPostick)
    End Sub
End Class
