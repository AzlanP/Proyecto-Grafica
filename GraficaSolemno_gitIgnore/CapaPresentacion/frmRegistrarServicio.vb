Imports CapaEntidad
Imports CapaNegocio

Public Class frmRegistrarServicio
    Dim oCEServicios As New CEServicios
    Dim oCNServicios As New CNServicios
    Public Function TomarDatos() As CEServicios
        oCEServicios.IDServicio = CInt(lblID.Text)

        oCEServicios.Nombre = txtNombreServicio.Text
        Return oCEServicios

    End Function

    Private Sub btnGuardarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarNuevoRegServ.Click
        oCNServicios.NuevoServicio(TomarDatos())
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarRegServ.Click
        Me.Close()

    End Sub

    Private Sub btnGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambiosRegServ.Click
        oCNServicios.ModificarServicio(TomarDatos())

        Close()
    End Sub
    Public Sub Disesabletext()
        'este codigo es para desabilitar la edicion de todos los campos
        Dim ctrl As Control

        For Each ctrl In Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Enabled = False 'Creo que el error es aqui
            End If
        Next

    End Sub

    Public Sub LLenarFormulario(ByVal ID)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNServicios.BuscarServicio(ID, "IDServicio")
        dr = dt.Rows(0)

        lblID.Text = dr("IDServicio").ToString
        txtNombreServicio.Text = dr("Nombre").ToString


    End Sub
End Class