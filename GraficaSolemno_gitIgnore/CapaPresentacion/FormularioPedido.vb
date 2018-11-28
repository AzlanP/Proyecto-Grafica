Imports CapaNegocio
Imports CapaEntidad
Public Class FormularioPedido
    Dim oPedido As New CEPedido
    Dim oCECliente As New CECliente
    Dim ListProductos() As CEProducto
    Dim oCNDetallesDePedido As New CNDetallesDelPedido

    Dim DTDetalles As New DataTable("Detalles")
    Public Sub LLenarFormulario(ByVal id As Integer)

        cboCliente.Text = oPedido.Cliente
        dtpFecha.Text = oPedido.Fecha
        txtDescripcion.Text = oPedido.Descripcion
        cboTipoEnvio.Text = oPedido.TipoDeEnvio
        cboEstado.Text = oPedido.Estado
        cboMedio.Text = oPedido.Medio
        CargarGridListaPedido()
    End Sub
    Public Sub CargarGridListaPedido()
        DGListaDePedido.DataSource = DTDetalles
    End Sub
    Public Sub CargarGridDetalles(ByVal id As Integer)
        DGListaDePedido.DataSource = oCNDetallesDePedido.MostrarDetalles(id)
    End Sub
    Public Sub SeleccionarCliente()

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        Dim AñadirProducto As New AgregarProductoPedido
        AñadirProducto.ShowDialog()

        AgregarDatosADetalles(AñadirProducto.oceproducto)


    End Sub
    Public Sub AgregarDatosADetalles(ByVal pProducto As CEProducto)
        Dim NuevaFilaDetalles As DataRow = DTDetalles.NewRow()
        NuevaFilaDetalles(0) = pProducto.IDProducto
        NuevaFilaDetalles(1) = pProducto.Nombre
        NuevaFilaDetalles(2) = pProducto.Cantidad
        NuevaFilaDetalles(3) = pProducto.Precio
        NuevaFilaDetalles(4) = pProducto.Descripcion
        DTDetalles.Rows.Add(NuevaFilaDetalles)
        CargarGridListaPedido()

    End Sub
    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim ID As Integer = DGListaDePedido.Rows(DGListaDePedido.CurrentCell.RowIndex).Cells("ID").Value
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
        Detalles()
    End Sub
    Public Sub Detalles()
        DTDetalles.Columns.Add("ID")
        DTDetalles.Columns.Add("Nombre")
        DTDetalles.Columns.Add("Cantidad")
        DTDetalles.Columns.Add("Precio")
        DTDetalles.Columns.Add("Descripcion")
    End Sub
End Class