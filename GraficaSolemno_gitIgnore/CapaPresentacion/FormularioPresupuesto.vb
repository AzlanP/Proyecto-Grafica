Imports CapaNegocio
Imports CapaEntidad
Public Class FormularioPresupuesto
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
        'Dim NuevaFilaDetalles As DataRow = tabla.NewRow()
        'NuevaFilaDetalles(0) = 0
        'NuevaFilaDetalles(1) = pProducto.Nombre
        'NuevaFilaDetalles(2) = pProducto.Cantidad
        'NuevaFilaDetalles(3) = pProducto.Descripcion
        'NuevaFilaDetalles(4) = pProducto.Precio
        'NuevaFilaDetalles(5) = pProducto.IDProducto
        'tabla.Rows.Add(NuevaFilaDetalles)

        tabla.Columns("IDItems").AutoIncrement = True
        tabla.Columns("IDItems").AutoIncrementSeed = oCNDetallesDePedido.ConsultarUltimoID
        tabla.Columns("IDItems").AutoIncrementStep = 1
        tabla.Rows.Add(Nothing, pProducto.Nombre, pProducto.Cantidad, pProducto.Descripcion, pProducto.Precio, pProducto.IDProducto)

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
                    Exit For
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
        Dim ID As Integer = DGListaDePedido.Rows(DGListaDePedido.CurrentCell.RowIndex).Cells("IDItems").Value
        Dim ProductoID As Integer
        Dim dtrow As DataRow
        Dim ValorIndex As Integer
        If DTDetalles.Rows.Count > 0 Then
            Dim i As Integer = DTDetalles.Rows.Count - 1
            For x As Integer = 0 To DTDetalles.Rows.Count - 1
                Dim iditem As Integer = DTDetalles.Rows(x).Item("IDItems")
                If (iditem = ID) Then

                    ProductoID = DTDetalles.Rows(x).Item("IDProducto")
                    ValorIndex = x
                    Exit For
                End If

            Next
        ElseIf TablaItems.Rows.Count > 0 Then
            Dim i As Integer = TablaItems.Rows.Count - 1
            For x As Integer = 0 To TablaItems.Rows.Count - 1
                Dim iditem As Integer = TablaItems.Rows(x).Item("IDItems")
                If (iditem = ID) Then

                    ProductoID = TablaItems.Rows(x).Item("IDProducto")

                    dtrow = (DGListaDePedido.Rows(x).DataBoundItem).Row
                    ValorIndex = x

                    Exit For
                End If

            Next
        End If
        Dim frmModProducto As New AgregarProductoPedido
        If dtrow Is Nothing Then

        Else
            frmModProducto.CargarDatosModificar(ProductoID, dtrow)
            frmModProducto.ShowDialog()
            TablaItems.Rows.RemoveAt(ValorIndex)
            AgregarDatosADetalles(frmModProducto.oCEproducto, TablaItems)

            '    If DTDetalles Is Nothing Then
            '        If TablaItems Is Nothing Then
            '            MsgBox("Error")-
            '        Else

            '        End If
            '    Else
            '        AgregarDatosADetalles(frmModProducto.oCEproducto, DTDetalles)
            '    End If

        End If



    End Sub

    Private Sub btnTipoEnvioNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoEnvioNuevo.Click
        Dim frmEnvioNuevo As New FormularioEnvio
        'precargado pero con los datos traidos desde la tabla de cliente 
        frmEnvioNuevo.DatosCliente(cboCliente.SelectedValue)
        frmEnvioNuevo.Tag = lblID.Text
        frmEnvioNuevo.ShowDialog()
    End Sub

    Private Sub btnEnvioGuardado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvioGuardado.Click
        Dim frmEnvioNuevo As New FormularioEnvio
        'precargado pero con los datos traidos desde la tabla envio
        frmEnvioNuevo.llenarFormularioInfoEnvio(Me.lblID.Text)
        frmEnvioNuevo.Tag = lblID.Text
        frmEnvioNuevo.ShowDialog()
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
        'DGListaDePedido.AutoGenerateColumns = False
    End Sub
    Public Sub Detalles()

        DTDetalles.Columns.AddRange(New DataColumn(5) {New DataColumn("IDItems"),
                                                       New DataColumn("Nombre"),
                                                       New DataColumn("Cantidad"),
                                                       New DataColumn("Descripcion"),
                                                       New DataColumn("Precio"),
                                                       New DataColumn("IDProducto")})
        'DTDetalles.Columns.Add("IDItems")
        'DTDetalles.Columns.Add("Nombre")
        'DTDetalles.Columns.Add("Cantidad")
        'DTDetalles.Columns.Add("Descripcion")
        'DTDetalles.Columns.Add("Precio")
        'DTDetalles.Columns.Add("IDProducto")
    End Sub
    Private Sub btnAgregarPedidoExistente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedidoExistente.Click

        Dim AñadirProducto As New AgregarProductoPedido
        AñadirProducto.Size = New Point(597, 425)
        AñadirProducto.ShowDialog()
        AgregarDatosADetalles(AñadirProducto.oCEproducto, TablaItems)
    End Sub
    Public Function CargarPedido() As CEPedido
        Dim oCEPedido As New CEPedido
        oCEPedido.IDPedido = lblID.Text
        oCEPedido.Cliente = cboCliente.SelectedValue
        oCEPedido.Fecha = FormatISO8601(dtpFecha.Text)
        oCEPedido.Descripcion = Trim(txtDescripcion.Text)
        oCEPedido.Medio = cboMedio.SelectedValue
        oCEPedido.Estado = cboEstado.Text
        oCEPedido.Seña = CDbl(ValidacionMoneda1.TextBox1.Text)
        oCEPedido.Envio = cboTipoEnvio.SelectedValue

        Return oCEPedido
    End Function
    Private Sub btnGuardarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPedido.Click
        'en este evento deberan iniciarse los procesos para registrar
        'en este todo debe ser insert en efecto cascada
        'oCEPedido
        'oTablaDetalles (listado de productos)
        oCNPedido.GenerarElPedido(CargarPedido, DTDetalles)


        'oCEDetallesEnvio
        Dim oCEDetallesEnvio As New CEDetallesEnvio



        Me.Close()
    End Sub
    Private Sub btnGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambios.Click
        'en este evento se iniciaran los procesos para modificar 
        'el oCEpedido recibira un update
        'oCEDetallesEnvio si existe alguno con el idpedido recibira update, si no existe recibira un insert.

        oCNPedido.ModificarPedido(CargarPedido, TablaItems) 'este recibe el update
        'el proximo a ingresar es el dato de envio como un insert o como update
        ' si existe --->Update
        ' Si no existe --->Insert
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

    Public Function FormatISO8601(ByVal pfecha As Date) As String

        Dim SoloFecha As String
        Dim dia, mes As String

        If pfecha.Month < 10 Then
            mes = "0" & pfecha.Month
        Else
            mes = pfecha.Month
        End If
        If pfecha.Day < 10 Then
            dia = "0" & pfecha.Day
        Else
            dia = pfecha.Day
        End If
        SoloFecha = pfecha.Year & "/" & mes & "/" & dia

        Return SoloFecha
    End Function
    Public Function FormatoFechaNormal(ByVal pfecha As String) As Date
        Dim fecha As Date
        Dim OrdenarFecha() As String = pfecha.Split("/")
        Dim fechaString As String = OrdenarFecha(2) & "/" & OrdenarFecha(1) & "/" & OrdenarFecha(0)
        fecha = fechaString
        Return fecha
    End Function

    Private Sub cboTipoEnvio_SelectedvaluesChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEnvio.SelectedValueChanged
        Dim oCNDetallesEnvio As New CNDetallesEnvio

        If cboTipoEnvio.Text = "NULO" Then
            'revisar porque cuando se hace doble click para abrir el pedido 4 que tiene por envio "nulo" 
            'pero el lblid.text tiene ":ID" dentro del label.
            'este metodo no deberia de ejecutarse al momento de abrir el formulario, solo cuando se selecciona manualmente el combobox.

            'oCNDetallesEnvio.EliminarInformacionEnvio(lblID.Text)


        End If

    End Sub

End Class
