Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarProducto
    Dim oCEProducto As New CEProducto
    Dim oCNProducto As New CNProducto


    Public Function TomarDatos() As CEProducto
        oCEProducto.IDProducto = CInt(lblID.Text)
        oCEProducto.Nombre = txtNombre.Text

        oCEProducto.Precio = CDbl(controlPrecio.valor)
        oCEProducto.Descripcion = txtDescripcion.Text
        oCEProducto.Codigo = txtCodigo.Text
        Return oCEProducto
    End Function
        Public Function CasteoNulo(ByVal value As String) As Integer
        value = Trim(value)
        If value = "" Then
            Return Nothing
        Else
            Return value
        End If
    End Function
    Public Sub LlenarFormulario(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNProducto.BuscarProducto("IDProducto", ID)
        dr = dt.Rows(0)
        lblID.Text = dr("IDProducto").ToString
        txtNombre.Text = dr("Nombre").ToString
        controlPrecio.valor = CasteoNulo(dr("Precio").ToString)
        txtDescripcion.Text = dr("Descripcion").ToString
        txtCodigo.Text = dr("Codigo").ToString
        btnRegistrarProducto.Visible = False
        btnGuardarProducto.Visible = True


    End Sub
    Public Sub LlenarFormularioInactivo(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNProducto.BuscarProductoInactivo("IDProducto", ID)
        dr = dt.Rows(0)
        lblID.Text = dr("IDProducto").ToString
        txtNombre.Text = dr("Nombre").ToString

        controlPrecio.valor = dr("Precio").ToString
        txtDescripcion.Text = dr("Descripcion").ToString
        txtCodigo.Text = dr("Codigo").ToString
        btnRegistrarProducto.Visible = False
        btnGuardarProducto.Visible = True


    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProducto.Click
        If (txtNombre.Text.Trim() = "") Then
            MessageBox.Show("El nombre del producto es requerido")
        Else
            oCNProducto.ModificarProducto(TomarDatos())
            Close()
        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta seguro de descartar los cambios?", "Descartar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
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
        controlPrecio.TextBox1.Enabled = False


    End Sub

    Private Sub btnRegistrarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarProducto.Click
        If (TomarDatos().Nombre = "") Then
            MessageBox.Show("El nombre del producto no puede ser nulo")
        Else
            oCNProducto.RegistrarProducto(TomarDatos())
            Close()
        End If


    End Sub

    Private Sub RegistrarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim validacion As New Validaciones
        validacion.Validar(Me)
    End Sub
  
    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub controlPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles controlPrecio.Load
        controlPrecio.SetSize(controlPrecio.Size)
    End Sub


End Class