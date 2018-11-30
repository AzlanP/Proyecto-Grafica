Imports CapaNegocio
Imports CapaEntidad
Public Class FormularioPedido
    Dim oPedido As New CEPedido
    Dim oCECliente As New CECliente

    Dim oCNPedido As New CNPedido
    Dim oCNDetallesDePedido As New CNDetallesDelPedido
    Dim oCEDetallesDePedido As New CEDetallesDelPedido
    Dim DTDetalles As New DataTable("ItemsPorPedido")
    Dim TablaItems As New DataTable
    Public Sub LLenarFormulario(ByVal id As Integer)
        Dim DTPedidoID As New DataTable
        DTPedidoID = oCNPedido.BuscarPedido("IDPedido", id)

        Dim DTProw As DataRow = DTPedidoID.Rows(0)
        txtDescripcion.Text = DTProw(1)
        dtpFecha.Text = Now
        cboCliente.Text = DTProw(3)
        cboTipoEnvio.Text = DTProw(4)
        cboMedio.Text = DTProw(5)
        cboEstado.Text = DTProw(6)
        txtSeña.Text = CDbl(DTProw(7))

    End Sub
    Public Sub CargarGridListaPedido(ByVal tabla As DataTable)
        DGListaDePedido.DataSource = tabla
    End Sub
    Public Sub CargarGridDetalles(ByVal id As Integer)
        TablaItems = oCNDetallesDePedido.MostrarDetalles(id)
        DGListaDePedido.DataSource = TablaItems.DefaultView.ToTable(True, "IDItems", "Nombre", "Cantidad", "Descripcion", "Precio")
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
        NuevaFilaDetalles(5) = pProducto.IDProducto
        tabla.Rows.Add(NuevaFilaDetalles)
        CargarGridListaPedido(tabla.DefaultView.ToTable(True, "IDItems", "Nombre", "Cantidad", "Descripcion", "Precio"))

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
        DTDetalles.Columns.Add("IDProducto")
    End Sub

    Private Sub btnAgregarPedidoExistente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedidoExistente.Click

        Dim AñadirProducto As New AgregarProductoPedido
        AñadirProducto.ShowDialog()
        AgregarDatosADetalles(AñadirProducto.oCEproducto, TablaItems)
    End Sub

    Public Function CargarPedido() As CEPedido
        Dim oCEPedido As New CEPedido
        oCEPedido.IDPedido = lblID.Text
        oCEPedido.Cliente = cboCliente.Text
        oCEPedido.Fecha = dtpFecha.Text
        oCEPedido.Descripcion = txtDescripcion.Text
        oCEPedido.Medio = cboMedio.Text
        oCEPedido.Estado = cboEstado.Text
        oCEPedido.Seña = txtSeña.Text
        oCEPedido.TipoDeEnvio = cboTipoEnvio.Text

        Return oCEPedido
    End Function
    Private Sub btnGuardarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPedido.Click
        oCNPedido.GenerarElPedido(CargarPedido, DTDetalles)
        Me.Close()
    End Sub

    Private Sub btnGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambios.Click
        oCNPedido.ModificarPedido(CargarPedido, TablaItems)
        Me.Close()
    End Sub
End Class