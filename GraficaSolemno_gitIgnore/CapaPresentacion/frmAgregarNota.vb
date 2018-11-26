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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
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
    Public Sub AbrirPostick(ByVal id As Integer)
        Dim oPostick As New CEPostick
        oPostick = oCNPostick.BuscarPostick(id)
        NroPostick.Text = oPostick.IDPostick
        txtTitulo.Text = oPostick.Titulo
        dtpFecha.Text = oPostick.Fecha
        txtDescripcion.Text = oPostick.Descripcion
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        oCNPostick.EliminarPostick(CInt(NroPostick.Text))
        Me.Close()

    End Sub
End Class