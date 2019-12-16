Imports CapaEntidad
Imports CapaNegocio

Public Class AgregarProductoPedido
    Public oCEproducto As New CEProducto
    Dim oCNProducto As New CNProducto
    Public oCEDetallesDelPedido As New CEDetallesDelPedido
    Dim oCNDetallesDelPedido As New CNDetallesDelPedido


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        oCEDetallesDelPedido.Cantidad = CInt(txtCantidad.Text)

        If (oCEDetallesDelPedido.Cantidad > 0) Then
            oCEproducto.Nombre = txtNombreProducto.Text
            oCEproducto.Precio = txtboxPrecio.valor
            oCEproducto.Descripcion = TextboxDescripcion.Text
            oCEproducto.IDProducto = lblID.Text
            oCEDetallesDelPedido.Cantidad = CInt(txtCantidad.Text)
            oCEDetallesDelPedido.Descuento = CInt(cboDesc.Text)
            calcularPrecioXCantidad()
            oCEDetallesDelPedido.PrecioFinal = CDbl(txtPrecioTotal.valor)
            Me.Close()
        Else
            MsgBox("La cantidad minima es de 1 articulo.", MessageBoxIcon.Exclamation, "Error al agregar producto.")
        End If
    End Sub
    Public Function CasteoNulo(ByVal value As String) As Integer
        value = Trim(value)
        If value = "" Then
            Return Nothing
        Else
            Return value
        End If
    End Function
    Public Sub CargarGridBuscar()
        Dim dt As New DataTable
        dt = oCNProducto.MostrarProducto()
        DGBuscar.DataSource = dt.DefaultView.ToTable(True, "IDProducto", "Nombre")

    End Sub
    Private Sub AgregarProductoPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridBuscar()
        Dim validacion As New Validaciones
        validacion.Validar(Me)

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
        txtNombreProducto.Text = dr("Nombre").ToString
        'txtCantidad.Text = oCEDetallesDelPedido.Cantidad
        txtCantidad.Text = 1
        txtboxPrecio.valor = nullearDouble(dr("Precio").ToString)
        TextboxDescripcion.Text = ""
    End Sub
    Public Function nullearInteger(ByVal ob As Object) As Integer
        Dim value As Integer
        Try
            value = ob
            Return value
        Catch ex As Exception
            value = 0
            Return 0
        End Try
    End Function
    Public Function nullearDouble(ByVal ob As Object) As Double
        Dim value As Double
        Try
            value = ob
            Return value
        Catch ex As Exception
            value = 0
            Return 0
        End Try
    End Function
    Public Sub CargarDatosModificar(ByVal id As Integer, ByVal dr As DataRow)

        Dim dt As New DataTable
        Me.Size = New Point(275, 400)
        lblID.Text = id
        txtNombreProducto.Text = dr("Nombre").ToString
        txtCantidad.Text = CInt(dr("Cantidad"))
        txtboxPrecio.valor = CDbl(dr("PrecioUnitario").ToString)
        TextboxDescripcion.Text = dr("Descripcion").ToString
        oCEDetallesDelPedido.Descuento = CInt(dr("Descuento").ToString)
        cboDesc.Text = CInt(dr("Descuento").ToString)
    End Sub
    Public Function SetNullValues(ByVal value As Object) As Object
        If IsNumeric(value) Then
            If value = 0 Then
                Return DBNull.Value
            Else
                Try
                    Return CInt(value)
                Catch ex As Exception
                    Return Str(value)
                End Try

            End If

        Else
            If value = Nothing Or value = "" Then
                Return DBNull.Value
            Else
                Return CInt(value)
            End If
        End If

    End Function
    'fijarme si no combine mas poner solo cellclick ya que el doble click aveces funciona mal
    Private Sub DGBuscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuscar.CellDoubleClick
        Dim ID As Integer = DGBuscar.Rows(e.RowIndex).Cells("IDProducto").Value

        CargarDatos(ID)
    End Sub

    Private Sub btnGuardarCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub calcularPrecioXCantidad()
        If (txtCantidad.Text = "") Then
            txtCantidad.Text = 0
        End If
        If (cboDesc.Text = "") Then
            cboDesc.Text = 0
        End If
        Dim total = txtboxPrecio.valor * txtCantidad.Text
        'total = total - total * (cboDesc.Text / 100) 'para que no recalcule el valor automaticamente con el descuento
        txtPrecioTotal.valor = total
    End Sub
    Public Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        calcularPrecioXCantidad()
    End Sub
    Private Sub txtboxPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxPrecio.Load
        calcularPrecioXCantidad()
        Dim moneda As ValidacionMoneda = txtboxPrecio
        moneda.frmParent = Me
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub cboDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesc.SelectedIndexChanged
        calcularPrecioXCantidad()
    End Sub


End Class