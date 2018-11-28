Imports CapaNegocio
Imports CapaEntidad
Public Class FormularioPedido
    Dim oPedido As New CEPedido
    Dim oCECliente As New CECliente
    Dim ListProductos() As CEProducto
    Dim oCNDetallesDePedido As New CNDetallesDelPedido
    Dim oCEDetallesDePedido As New CEDetallesDelPedido
    Dim DTDetalles As New DataTable("ItemsPorPedido")
    Dim TablaItems As New DataTable
    Public Sub LLenarFormulario(ByVal id As Integer)

        cboCliente.Text = oPedido.Cliente
        dtpFecha.Text = oPedido.Fecha
        txtDescripcion.Text = oPedido.Descripcion
        cboTipoEnvio.Text = oPedido.TipoDeEnvio
        cboEstado.Text = oPedido.Estado
        cboMedio.Text = oPedido.Medio

    End Sub
    Public Sub CargarGridListaPedido(ByVal tabla As DataTable)
        DGListaDePedido.DataSource = tabla
    End Sub
    Public Sub CargarGridDetalles(ByVal id As Integer)
        TablaItems = oCNDetallesDePedido.MostrarDetalles(id)
        DGListaDePedido.DataSource = TablaItems
    End Sub
    Public Sub SeleccionarCliente()

    End Sub
    Private Sub btnAgregarPedidoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedidoNuevo.Click

        Dim AñadirProducto As New AgregarProductoPedido
        AñadirProducto.ShowDialog()
        AgregarDatosADetalles(AñadirProducto.oCEproducto, DTDetalles)
    End Sub
    Public Sub AgregarDatosADetalles(ByVal pProducto As CEProducto, ByVal tabla As DataTable)
        Dim NuevaFilaDetalles As DataRow = tabla.NewRow()
        NuevaFilaDetalles(0) = oCNDetallesDePedido.ConsultarUltimoID + tabla.Rows.Count
        NuevaFilaDetalles(1) = pProducto.Nombre
        NuevaFilaDetalles(2) = pProducto.Cantidad
        NuevaFilaDetalles(3) = pProducto.Descripcion
        NuevaFilaDetalles(4) = pProducto.Precio
        tabla.Rows.Add(NuevaFilaDetalles)
        CargarGridListaPedido(tabla)

    End Sub
    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim ID As Integer = DGListaDePedido.Rows(DGListaDePedido.CurrentCell.RowIndex).Cells("IDItems").Value
        DTDetalles.Rows.RemoveAt(ID)

    End Sub

    Private Sub btnModificarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPedido.Click
        Dim ID As Integer = DGListaDePedido.Rows(DGListaDePedido.CurrentCell.RowIndex).Cells("ID").Value
        'crear un formulario de edision
    End Sub

    Private Sub btnTipoEnvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoEnvio.Click
        Dim frmEnvio As New FormularioEnvio
        frmEnvio.ShowDialog()
    End Sub

    Private Sub btnGuardarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPedido.Click

    End Sub

    Private Sub btnCancelarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarPedido.Click
        Me.Close()
    End Sub

    Private Sub FormularioPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Detalles()
        DTDetalles.Columns.Add("IDItems")
        DTDetalles.Columns.Add("Nombre")
        DTDetalles.Columns.Add("Cantidad")
        DTDetalles.Columns.Add("Descripcion")
        DTDetalles.Columns.Add("Precio")
    End Sub

    Private Sub btnAgregarPedidoExistente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedidoExistente.Click

        Dim AñadirProducto As New AgregarProductoPedido
        AñadirProducto.ShowDialog()
        AgregarDatosADetalles(AñadirProducto.oCEproducto, TablaItems)
    End Sub

End Class