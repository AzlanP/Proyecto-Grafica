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
        PrecargarCombobox()
        Dim DTPedidoID As New DataTable
        DTPedidoID = oCNPedido.BuscarPedido("IDPedido", id)
        Dim DTProw As DataRow = DTPedidoID.Rows(0)
        txtDescripcion.Text = DTProw(1)
        dtpFecha.Text = CDate(DTProw(2))
        AsignarTextCbo(DTProw(3), cboCliente)
        AsignarTextCbo(DTProw(4), cboTipoEnvio)
        AsignarTextCbo(DTProw(5), cboMedio)
        cboEstado.Text = DTProw(6)
        ValidacionMoneda1.TextBox1.Text = CDbl(DTProw(7))

    End Sub
    Public Sub CargarGridListaPedido(ByVal tabla As DataTable)
        DGListaDePedido.DataSource = tabla.DefaultView.ToTable(True, "IDItems", "Nombre", "Cantidad", "Descripcion", "Precio")
        ' esta tabla luego de remover un producto de la lista imprime IDpedido pero por error da el id de producto. niuno deveria mostrarse
    End Sub
    Public Sub CargarGridDetalles(ByVal id As Integer)
        TablaItems = oCNDetallesDePedido.MostrarDetalles(id)
        DGListaDePedido.DataSource = TablaItems.DefaultView.ToTable(True, "IDItems", "Nombre", "Cantidad", "Descripcion", "Precio")
    End Sub
    Private Sub btnAgregarPedidoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedidoNuevo.Click

        Dim AñadirProducto As New AgregarProductoPedido
        AñadirProducto.ShowDialog()
        AgregarDatosADetalles(AñadirProducto.oCEproducto, DTDetalles)
    End Sub
    Public Sub AgregarDatosADetalles(ByVal pProducto As CEProducto, ByVal tabla As DataTable)
        Dim NuevaFilaDetalles As DataRow = tabla.NewRow()
        'esto genera un error, si borras uno de arriba, el de abajo tomara el mismo valor de id que el de arriba.
        'enves de tabla.rows.count capas sirva hacerlo con rows.index retornara el valor que ocupa en su posicion y no se salteara nuevos luego de borrar
        NuevaFilaDetalles(0) = oCNDetallesDePedido.ConsultarUltimoID + tabla.Rows.Count
        NuevaFilaDetalles(1) = pProducto.Nombre
        NuevaFilaDetalles(2) = pProducto.Cantidad
        NuevaFilaDetalles(3) = pProducto.Descripcion
        NuevaFilaDetalles(4) = pProducto.Precio
        NuevaFilaDetalles(5) = pProducto.IDProducto
        tabla.Rows.Add(NuevaFilaDetalles)
        CargarGridListaPedido(tabla)

    End Sub
    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim ID As Integer = DGListaDePedido.Rows(DGListaDePedido.CurrentCell.RowIndex).Cells("IDItems").Value
        ' en esta funcion hay un problema, si 2 articulos son iguales tomara el mismo iditem y borrara las 2 celdas
        If DTDetalles.Rows.Count > 0 Then

            Dim i As Integer = DTDetalles.Rows.Count - 1
            Dim posborrado As Integer

            For x As Integer = 0 To DTDetalles.Rows.Count - 1
                Dim iditem As Integer = DTDetalles.Rows(x).Item("IDItems")
                If (iditem = ID) Then
                    posborrado = x
                    DTDetalles.Rows.RemoveAt(x)
                End If
                'If posborrado < x Then
                '    DTDetalles.Rows(x + 1).Item("IDItems")
                'End If

            Next
            'For Each row As DataRow In DTDetalles.Rows
            '    row.
            '    MsgBox("Index De tabla: " &  & " , " & row(0) & " , " & row(1) & " , " & row(2) & " , " & row(3) & " , " & row(4) & " , " & row(5))

            'Next



            'For x As Int32 = DTDetalles.Rows.Count - 1 To 0 Step -1
            '    Dim iditem As Integer = DTDetalles.Rows(x).Item("IDItems")
            '    If (iditem = ID) Then
            '        posborrado = x
            '        DTDetalles.Rows.RemoveAt(x)
            '    End If
            '    'If posborrado < x Then
            '    '    DTDetalles.Rows(x + 1).Item("IDItems")
            '    'End If

            'Next
            CargarGridListaPedido(DTDetalles)
        ElseIf TablaItems.Rows.Count > 0 Then


            Dim i As Integer = TablaItems.Rows.Count - 1

            For x As Int32 = TablaItems.Rows.Count - 1 To 0 Step -1
                Dim iditem As Integer = TablaItems.Rows(x).Item("IDItems")
                If (iditem = ID) Then
                    TablaItems.Rows.RemoveAt(x)
                End If

            Next
            CargarGridListaPedido(TablaItems)
        End If


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
    Public Sub PrecargarCombobox()
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.TipoEnvio' Puede moverla o quitarla según sea necesario.
        Me.TipoEnvioTableAdapter.Fill(Me.SolemnoDataSet.TipoEnvio)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Medios' Puede moverla o quitarla según sea necesario.
        Me.MediosTableAdapter.Fill(Me.SolemnoDataSet.Medios)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.SolemnoDataSet.Clientes)

    End Sub
    Private Sub FormularioPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim validacion As New Validaciones
        validacion.Validar(Me)
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
        oCEPedido.Cliente = cboCliente.SelectedValue
        oCEPedido.Fecha = dtpFecha.Text
        oCEPedido.Descripcion = Trim(txtDescripcion.Text)
        oCEPedido.Medio = cboMedio.SelectedValue
        oCEPedido.Estado = cboEstado.Text
       oCEPedido.Seña = CDbl(ValidacionMoneda1.TextBox1.Text)
        oCEPedido.TipoDeEnvio = cboTipoEnvio.SelectedValue
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

    Public Sub AsignarTextCbo(ByVal text As String, ByVal cbo As System.Object)

        Dim int As Integer
        int = cbo.FindString(text)
        cbo.SelectedIndex = int
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
End Class
