Imports CapaEntidad
Imports CapaNegocio

Public Class AgregarProductoPedido
    Public oCEproducto As New CEProducto
    Dim oCNProducto As New CNProducto
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        oCEproducto.IDProducto = lblID.Text
        oCEProducto.Nombre = CboProducto.Text
        oCEProducto.Cantidad = txtCantidad.Text
        oCEProducto.Precio = txtboxPrecio.Text
        oCEproducto.Descripcion = TextboxDescripcion.Text
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
        lblID.Text = dr("IDProducto").ToString
        CboProducto.Text = dr("Nombre").ToString
        txtCantidad.Text = dr("Cantidad").ToString
        txtboxPrecio.Text = dr("Precio").ToString
        TextboxDescripcion.Text = dr("Descripcion").ToString
    End Sub

    Private Sub DGBuscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuscar.CellDoubleClick
        Dim ID As Integer = DGBuscar.Rows(e.RowIndex).Cells("IDProducto").Value
        CargarDatos(ID)
    End Sub
End Class