Imports CapaEntidad
Imports CapaNegocio

Public Class AgregarProductoPedido
    Public oCEproducto As New CEProducto
    Dim oCNProducto As New CNProducto
    'Dim oCEDetallesDelPedido As New CEDetallesDelPedido
    'Dim oCNDetallesDelPedido As New CNDetallesDelPedido

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click


        oCEproducto.Nombre = CboProducto.Text
        oCEproducto.Cantidad = txtCantidad.Text
        oCEproducto.Precio = txtboxPrecio.Text
        oCEproducto.Descripcion = TextboxDescripcion.Text
        oCEproducto.IDProducto = lblID.Text
        Me.Close()
    End Sub
    Public Sub CargarGridBuscar()
        Dim dt As New DataTable
        dt = oCNProducto.MostrarProducto()
        DGBuscar.DataSource = dt.DefaultView.ToTable(True, "IDProducto", "Nombre")

    End Sub


    Private Sub AgregarProductoPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridBuscar()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        dt = oCNProducto.BuscarProducto("Nombre", txtBuscar.Text)
        DGBuscar.DataSource = dt.DefaultView.ToTable(True, "IDProducto", "Nombre")
    End Sub
    Public Sub CargarDatos(ByVal id As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNProducto.BuscarProducto("IDProducto", id)
        dr = dt.Rows(0)
        lblID.Text = dr("IDProducto")
        CboProducto.Text = dr("Nombre").ToString
        txtCantidad.Text = CInt("1")
        txtboxPrecio.Text = dr("Precio").ToString
        TextboxDescripcion.Text = ""
    End Sub
    'fijarme si no combine mas poner solo cellclick ya que el doble click aveces funciona mal
    Private Sub DGBuscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuscar.CellDoubleClick
        Dim ID As Integer = DGBuscar.Rows(e.RowIndex).Cells("IDProducto").Value
        CargarDatos(ID)
    End Sub
End Class