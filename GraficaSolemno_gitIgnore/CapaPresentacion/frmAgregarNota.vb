Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarNota

    Dim oCEPostick As New CEPostick
    Dim oCNPostick As New CNPostick

    Private Sub btnGuardarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarNota.Click
        Dim oCEPostick As New CEPostick
        oCEPostick.Titulo = txtTitulo.Text
        oCEPostick.Descripcion = txtDescripcion.Text
        oCEPostick.Fecha = FormatISO8601(dtpFecha.Text)
        oCNPostick.NuevoPostick(oCEPostick)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Public Function FormatISO8601(ByVal pfecha As Date) As String

        Dim SoloFecha As String
        SoloFecha = pfecha.Year & "/" & pfecha.Month & "/" & pfecha.Day


        Return SoloFecha
    End Function
    Public Function FormatoFechaNormal(ByVal pfecha As String) As Date
        Dim fecha As Date
        Dim OrdenarFecha() As String = pfecha.Split("/")
        Dim fechaString As String = OrdenarFecha(2) & "/" & OrdenarFecha(1) & "/" & OrdenarFecha(0)
        fecha = fechaString
        Return fecha
    End Function

End Class