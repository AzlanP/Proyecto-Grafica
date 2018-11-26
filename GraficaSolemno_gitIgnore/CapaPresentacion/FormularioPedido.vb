Imports CapaNegocio
Imports CapaEntidad
Public Class FormularioPedido
    Dim oPedido As New CEPedido
    Dim oCECliente As New CECliente
    Dim ListProductos() As CEProducto

    Dim listGeneral()() As String
   
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
        DGListaDePedido.DataSource = listGeneral
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

    End Sub
    Public Sub AgregarArrayDG()
        ReDim Preserve listGeneral(ListProductos.Length)
        Dim i = 0
        For Each producto In ListProductos
            listGeneral(0)(i) = i
            listGeneral(1)(i) = producto.Nombre
            listGeneral(2)(i) = producto.Precio
            listGeneral(3)(i) = producto.Cantidad
            listGeneral(4)(i) = producto.Descripcion
            i = i + 1
        Next
        i = ListProductos.Length - 1
        
    End Sub
    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim ID As Integer = DGListaDePedido.Rows(DGListaDePedido.CurrentCell.RowIndex).Cells("ID").Value
        listGeneral(ID)(0).Remove(0, ID)


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
End Class