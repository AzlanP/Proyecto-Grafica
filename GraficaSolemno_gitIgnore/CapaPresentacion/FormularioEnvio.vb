﻿Imports CapaEntidad
Imports CapaNegocio
Public Class FormularioEnvio
    Dim oCECliente As New CECliente
    Dim oCNCliente As New CNCliente
    Dim oCEDetallesEnvio As New CEDetallesEnvio
    Dim oCNDetallesEnvio As New CNDetallesEnvio
    Dim IDDelPedido As Integer = Me.Tag

    Public Sub DatosCliente(ByVal Cliente As Integer)
        PrecargarCbo()

        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNCliente.BuscarCliente("IDCliente", Cliente)
        dr = dt.Rows(0)
        oCECliente.IDCliente = dr("IDCliente").ToString
        'oCECliente.Pais = dr("IDPais").ToString
        AsignarTextCbo(dr("Provincia").ToString, cboProvincia)
        AsignarTextCbo(dr("Localidad").ToString, cboLocalidad)
        'oCECliente.Provincia = dr("Provincia").ToString
        'oCECliente.Localidad = dr("Localidad").ToString
        txtBarrio.Text = dr("Barrio").ToString
        txtNroCalle.Text = dr("NroCalle").ToString
        txtDomicilio.Text = dr("Domicilio").ToString
        txtDpto.Text = dr("Dpto").ToString
        txtCP.Text = dr("CP").ToString
        oCECliente.Fecha = dr("Fecha").ToString
        'Me.Tag = dr("IDPedido").ToString
    End Sub
    Public Sub llenarFormularioInfoEnvio(ByVal id As Integer)
        PrecargarCbo()

        Dim oCNDetallesEnvio As New CNDetallesEnvio
        Dim dt As New DataTable
        dt = oCNDetallesEnvio.InformacionDeEnvio(id)
        'aca deberia de hacer la comprobacion si el datatable tiene 0 row, ponga la informacion por defecto.
        Dim dr As DataRow = dt.Rows(0)
        txtTransporte.Text = dr("Transporte").ToString
        dtpFechaDespacho.Text = CDate(dr("FechaDespacho").ToString)
        txtNroSeguimiento.Text = dr("NroSeguimiento").ToString
        ValidacionPrecio.valor = dr("PrecioEnvio").ToString
        'cboPais.SelectedText = dr("Barrio").ToString
        AsignarTextCbo(dr("Provincia").ToString, cboProvincia)
        AsignarTextCbo(dr("Localidad").ToString, cboLocalidad)
        txtBarrio.Text = dr("Barrio").ToString
        txtDomicilio.Text = dr("Domicilio").ToString
        txtNroCalle.Text = dr("NroCalle").ToString
        txtDpto.Text = dr("Dpto").ToString
        txtCP.Text = dr("CP").ToString
        'Me.Tag = dr("IDPedido").ToString

    End Sub
    Public Sub AsignarDatosCBO()
        cboPais.Text = oCECliente.Pais

        AsignarTextCbo(oCECliente.Provincia, cboProvincia)
        AsignarTextCbo(oCECliente.Localidad, cboLocalidad)
    End Sub
    Public Sub PrecargarCbo()
        Me.ProvinciasTableAdapter.Fill(Me.SolemnoDataSet.Provincias)
        cboProvincia.SelectedIndex = 0
    End Sub

    'Private Sub FormularioEnvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Provincias' Puede moverla o quitarla según sea necesario.
    '    Me.ProvinciasTableAdapter.Fill(Me.SolemnoDataSet.Provincias)
    '    cboProvincia.SelectedIndex = 0
    'End Sub
    Public Sub TomarInformacion()

        oCEDetallesEnvio.IDPedido = Me.Tag
        oCEDetallesEnvio.Provincia = CInt(cboProvincia.SelectedValue)
        oCEDetallesEnvio.Localidad = CInt(cboLocalidad.SelectedValue)
        oCEDetallesEnvio.Domicilio = txtDomicilio.Text
        oCEDetallesEnvio.NroCalle = txtNroCalle.Text
        oCEDetallesEnvio.Dpto = txtDpto.Text
        oCEDetallesEnvio.CP = txtCP.Text
        oCEDetallesEnvio.Barrio = txtBarrio.Text
        oCEDetallesEnvio.Transporte = txtTransporte.Text
        oCEDetallesEnvio.NroSeguimiento = txtNroSeguimiento.Text
        oCEDetallesEnvio.PrecioEnvio = ValidacionPrecio.valor
        oCEDetallesEnvio.FechaDespacho = CDate(dtpFechaDespacho.Text)
    End Sub


    Private Sub cboLocalidad_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.Enter
        If cboProvincia.Text = "" Or cboProvincia.Text = " " Then
            MsgBox("debe ingresar una provincia primero.")
            cboProvincia.Focus()
        ElseIf cboProvincia.SelectedValue = Nothing Then
            MsgBox("Debe ingresar una provincia valida")
            cboProvincia.Text = ""
            cboLocalidad.Text = ""
        End If
    End Sub

    Private Sub cboLocalidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.LostFocus
        If cboLocalidad.SelectedValue = Nothing Then
            MsgBox("Debe ingresar una Localidad valida")
            cboLocalidad.Text = ""
            txtCP.Text = ""
        End If
    End Sub

    Private Sub cboLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLocalidad.KeyPress
        cboLocalidad.DroppedDown = False

    End Sub
    Public Sub AsignarTextCbo(ByVal text As String, ByVal cbo As System.Object)

        Dim int As Integer
        int = cbo.FindString(text)
        cbo.SelectedIndex = int
    End Sub


    Private Sub cboLocalidad_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.SelectedValueChanged
        Dim idprovincia As Integer = CInt(cboProvincia.SelectedValue)
        Dim idlocalidad As Integer = CInt(cboLocalidad.SelectedValue)
        txtCP.Text = oCNCliente.TraerCP(idprovincia, idlocalidad)

    End Sub

    Private Sub cboProvincia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedValueChanged
        Dim dt As DataTable = oCNCliente.LocalidadesPorProvincia(cboProvincia.SelectedValue)
        cboLocalidad.DataSource = dt
        cboLocalidad.DisplayMember = "Nombre"
        cboLocalidad.ValueMember = "IDLocalidad"
    End Sub



    Private Sub GuardarCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambio.Click
        TomarInformacion()
        oCNDetallesEnvio.EliminarInformacionEnvio(Me.Tag)
        oCNDetallesEnvio.RegistrarEnvio(oCEDetallesEnvio)
        Me.Close()
    End Sub

    Private Sub btnGuardarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarNuevo.Click
        TomarInformacion()
        'para pedidos-nuevo pedido-nuevo envio esto no debe valer, ya que debera mantenerse como temporal hasta que den guardar cambios.
        ' aca se podria verificar si existe el pedido ya (en este caso continuara el curso normal
        'de ejecucion, en caso contrario dara a pasar el ocedetallesenvio a la capa de formulario de pedido
        'cuando se realize la Carga del Nuevo Pedido, este recien sera registrado.
        Dim oCNPedido As New CNPedido
        Dim dt As New DataTable
        dt = oCNPedido.BuscarPedido("IDPedido", IDDelPedido)
        Dim i As Integer
        i = dt.Rows.Count
        If i > 0 Then

        Else
            oCNDetallesEnvio.EliminarInformacionEnvio(IDDelPedido)
            oCNDetallesEnvio.ModificarDetallesEnvio(oCEDetallesEnvio)
        End If
        
        Me.Close()
    End Sub
End Class