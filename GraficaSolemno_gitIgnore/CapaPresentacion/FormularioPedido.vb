Imports CapaNegocio
Imports CapaEntidad
Public Class FormularioPedido
    Dim oPedido As New CEPedido
    Dim ListProductos() As CEProducto
    Dim ListServicios() As CEServicio
    Public Sub LLenarFormulario(ByVal id As Integer)
        cboCliente.Text = oPedido.Cliente
        dtpFecha.Text = oPedido.Fecha
        txtDescripcion.Text = oPedido.Descripcion
        cboTipoEnvio.Text = oPedido.TipoDeEnvio
    
        cboEstado.Text = oPedido.Estado
        cboMedio.Text = oPedido.Medio
        CargarGridListaPedido(id)

    End Sub
    Public Sub CargarGridListaPedido(ByVal id As Integer)
        For Each producto In oPedido.Productos
            DGListaDePedido.Controls.Add(producto)
        Next
        For Each servicio In oPedido.Servicios
            DGListaDePedido.Controls.Add(servicio)
        Next
    End Sub
    Public Sub SeleccionarCliente()

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        oPedido.Cliente = cboCliente.Text
        oPedido.Fecha = dtpFecha.Text
        oPedido.Descripcion = txtDescripcion.Text
        oPedido.TipoDeEnvio = cboTipoEnvio.Text

        oPedido.Estado = cboEstado.Text
        oPedido.Medio = cboMedio.Text
        oPedido.Productos = ListProductos
        oPedido.Servicios = ListServicios
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

    End Sub

    Private Sub btnModificarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPedido.Click

    End Sub

    Private Sub btnTipoEnvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoEnvio.Click
        Dim frmEnvio As New FormularioEnvio
        frmEnvio.ShowDialog()
    End Sub

    Private Sub btnGuardarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPedido.Click

    End Sub

    Private Sub btnCancelarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarPedido.Click

    End Sub
End Class