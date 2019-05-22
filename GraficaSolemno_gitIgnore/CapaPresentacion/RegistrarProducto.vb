Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarProducto
    Dim oCEProducto As New CEProducto
    Dim oCNProducto As New CNProducto


    Public Function TomarDatos() As CEProducto
        If cboTipo.Text = "Producto" And txtNombre.Text <> "" Then
            oCEProducto.Tipo = cboTipo.Text
            oCEProducto.IDProducto = CInt(lblID.Text)
            oCEProducto.Nombre = txtNombre.Text
            oCEProducto.Cantidad = CInt(txtCantidad.Text)
            oCEProducto.Precio = CDbl(txtPrecio.Text)
            oCEProducto.Descripcion = txtDescripcion.Text
            oCEProducto.Codigo = CInt(txtCodigo.Text)
            Return oCEProducto
        ElseIf cboTipo.Text = "Servicio" Then
            oCEProducto.Tipo = cboTipo.Text
            oCEProducto.IDProducto = CInt(lblID.Text)
            oCEProducto.Nombre = txtNombre.Text
            oCEProducto.Descripcion = txtDescripcion.Text

            Return oCEProducto
        Else
            Return Nothing
        End If
    End Function
    Public Sub LlenarFormulario(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNProducto.BuscarProducto("IDProducto", ID)
        dr = dt.Rows(0)
        lblID.Text = dr("IDProducto").ToString
        txtNombre.Text = dr("Nombre").ToString
        txtCantidad.Text = dr("Cantidad").ToString
        txtPrecio.Text = dr("Precio").ToString
        txtDescripcion.Text = dr("Descripcion").ToString
        txtCodigo.Text = dr("Codigo").ToString
        cboTipo.Text = dr("Tipo").ToString
        btnRegistrarProducto.Visible = False
        btnGuardarProducto.Visible = True

        Me.Text = "Modificar Producto"
    End Sub
    Public Sub LlenarFormularioInactivo(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNProducto.BuscarProductoInactivo("IDProducto", ID)
        dr = dt.Rows(0)
        lblID.Text = dr("IDProducto").ToString
        txtNombre.Text = dr("Nombre").ToString
        txtCantidad.Text = dr("Cantidad").ToString
        txtPrecio.Text = dr("Precio").ToString
        txtDescripcion.Text = dr("Descripcion").ToString
        txtCodigo.Text = dr("Codigo").ToString
        cboTipo.Text = dr("Tipo").ToString
        btnRegistrarProducto.Visible = False
        btnGuardarProducto.Visible = True

        Me.Text = "Modificar Producto"
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProducto.Click
        oCNProducto.ModificarProducto(TomarDatos())
        MsgBox("Los Datos fueron modificados con exito.")
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta seguro de descartar los cambios?", "Confirmacion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Close()
        End If

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

    Private Sub btnRegistrarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarProducto.Click
        oCNProducto.RegistrarProducto(TomarDatos())
        MsgBox("Los Datos fueron guardados con exito.")
        Close()
    End Sub

    Private Sub RegistrarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.Text = "Producto" Then
            lblCantidad.Visible = True
            lblCodigo.Visible = True
            lblPrecio.Visible = True
            txtCantidad.Visible = True
            txtCodigo.Visible = True
            txtPrecio.Visible = True
        ElseIf cboTipo.Text = "Servicio" Then
            lblCantidad.Visible = False
            lblCodigo.Visible = False
            lblPrecio.Visible = False
            txtCantidad.Visible = False
            txtCodigo.Visible = False
            txtPrecio.Visible = False
        End If
    End Sub

  
End Class