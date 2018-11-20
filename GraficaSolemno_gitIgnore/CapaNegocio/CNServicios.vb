Imports CapaDatos
Imports CapaEntidad


Public Class CNServicios
    Dim oCDServicio As New CDServicios
    Function MostrarServicios() As DataTable


        Return oCDServicio.MostrarServicios()
    End Function
    Public Sub NuevoServicio(ByVal oCEServicio As CEServicios)

        oCDServicio.NuevoServicio(oCEServicio)
    End Sub
    Function BuscarServicio(ByVal pbuscar As String, ByVal campo As String) As DataTable
        Dim dt As New DataTable

        Return oCDServicio.BuscarServicio(pbuscar, campo)
    End Function
    Public Sub ModificarServicio(ByVal oCEServicio As CEServicios)

        oCDServicio.ModificarServicio(oCEServicio)
    End Sub
    Public Sub EliminarServicio(ByVal id As Integer)

        oCDServicio.EliminarServicio(id)
    End Sub
    Public Function ConsultarUltimoID()
        Return oCDServicio.ConsultarUltimoID()
    End Function

End Class

