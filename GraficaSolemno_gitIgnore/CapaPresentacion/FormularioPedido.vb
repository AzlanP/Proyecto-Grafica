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
    Dim DTPedidoID As New DataTable
    Dim IDitemSelected As Integer
    Dim Cantidad As Integer
    Dim Descuento As Integer
    Dim Importe As Double
    Public Sub LLenarFormulario(ByVal id As Integer, Optional ByVal isPedido As Boolean = True)
        PrecargarCombobox()

        If (isPedido = True) Then
            DTPedidoID = oCNPedido.BuscarPedido("IDPedido", id)
        Else
            DTPedidoID = oCNPedido.BuscarPresupuesto("IDPedido", id)
        End If

        Dim DTProw As DataRow = DTPedidoID.Rows(0)
        txtDescripcion.Text = DTProw(1)
        dtpFecha.Text = CDate(DTProw(2))
        AsignarTextCbo(DTProw(3), cboCliente)
        txtClienteNombreCompleto.Text = CStr(DTProw(3)) + " " + CStr(DTProw(4))
        chkEnvio.Checked = DTProw(5)
        AsignarTextCbo(DTProw(6), cboMedio)
        cboEstado.Text = DTProw(7)
        txtAnticipoSena.Text = CDbl(DTProw(8))
        cboDesc.Text = DTProw(9)
        txtTotal.valor = DTProw(10)
        txtSubTotal.valor = DTProw(11)
        If CStr(DTProw(7)) = "Presupuesto" Then
            dtpFechaVencimiento.Text = DTProw(12)
        Else
            'CambioAPedido()

        End If
    End Sub
    Public Sub CargarGridListaPedido(ByVal tabla As DataTable)
        DGListaDePedido.DataSource = tabla.DefaultView.ToTable(True, "IDItems", "Nombre", "Cantidad", "Descripcion", "Descuento", "PrecioUnitario", "PrecioFinal")
        DGListaDePedido.Columns("PrecioFinal").HeaderCell.Value = "Importe"

        ' esta tabla luego de remover un producto de la lista imprime IDpedido pero por error da el id de producto. niuno deveria mostrarse
    End Sub
    Public Sub CargarGridDetalles(ByVal id As Integer)
        TablaItems = oCNDetallesDePedido.MostrarDetalles(id)
        DGListaDePedido.DataSource = TablaItems.DefaultView.ToTable(True, "IDItems", "Nombre", "Cantidad", "Descripcion", "Descuento", "PrecioUnitario", "PrecioFinal")
        DGListaDePedido.Columns("PrecioFinal").HeaderCell.Value = "Importe"
    End Sub
    Private Sub btnAgregarPedidoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedidoNuevo.Click
        Dim AñadirProducto As New AgregarProductoPedido

        If oCNDetallesDePedido.MostrarDetalles(lblID.Text).Rows.Count > 0 Then
            AñadirProducto.Size = New Point(600, 400)
            AñadirProducto.ShowDialog()
            If (AñadirProducto.oCEproducto.IDProducto <> 0) Then
                AgregarDatosADetalles(AñadirProducto.oCEproducto, TablaItems, AñadirProducto.oCEDetallesDelPedido)
            End If
        Else
            AñadirProducto.Size = New Point(600, 400)
            AñadirProducto.ShowDialog()
            If (AñadirProducto.oCEproducto.IDProducto <> 0) Then
                If (DTDetalles.Columns.Count = 0) Then
                    Detalles()
                End If
                AgregarDatosADetalles(AñadirProducto.oCEproducto, DTDetalles, AñadirProducto.oCEDetallesDelPedido)
            End If
        End If
        CalcularTotalBruto()


    End Sub

    Public Sub AgregarDatosADetalles(ByVal pProducto As CEProducto, ByVal tabla As DataTable, ByVal otras As CEDetallesDelPedido)
        tabla.Columns("IDItems").AutoIncrement = True
        tabla.Columns("IDItems").AutoIncrementSeed = oCNDetallesDePedido.ConsultarUltimoID
        tabla.Columns("IDItems").AutoIncrementStep = 1
        tabla.Rows.Add(Nothing, pProducto.Nombre, otras.Cantidad, pProducto.Descripcion, otras.Descuento, pProducto.Precio, otras.PrecioFinal, pProducto.IDProducto)
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

        CalcularTotalBruto()
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

        If Not (dtrow Is Nothing) Then
            frmModProducto.CargarDatosModificar(ProductoID, dtrow)
            frmModProducto.ShowDialog()
            If Not frmModProducto.oCEproducto.Nombre Is Nothing Then

                TablaItems.Rows.RemoveAt(ValorIndex)
                AgregarDatosADetalles(frmModProducto.oCEproducto, TablaItems, frmModProducto.oCEDetallesDelPedido)
            End If

        Else
            dtrow = DTDetalles.Rows(ValorIndex)
            frmModProducto.CargarDatosModificar(ProductoID, dtrow)
            frmModProducto.ShowDialog()
            If Not frmModProducto.oCEproducto.Nombre Is Nothing Then
                DTDetalles.Rows.RemoveAt(ValorIndex)
                AgregarDatosADetalles(frmModProducto.oCEproducto, DTDetalles, frmModProducto.oCEDetallesDelPedido)
            End If

        End If

        CalcularTotalBruto()

    End Sub


    Private Sub btnEnvioGuardado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvioGuardado.Click
        Dim frmEnvioNuevo As New FormularioEnvio

        Dim oCNDetallesEnvio As New CNDetallesEnvio

        Dim dt As DataTable = oCNDetallesEnvio.InformacionDeEnvio(Me.lblID.Text)
        If dt.Rows.Count > 0 Then
            frmEnvioNuevo.llenarFormularioInfoEnvio(Me.lblID.Text)
            frmEnvioNuevo.Tag = lblID.Text
            frmEnvioNuevo.ShowDialog()
        Else

            frmEnvioNuevo.DatosCliente(cboCliente.SelectedValue)
            frmEnvioNuevo.Tag = lblID.Text
            frmEnvioNuevo.ShowDialog()
        End If

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
        cboEstado.SelectedIndex = 0
        cboDesc.SelectedIndex = 0
    End Sub
    Private Sub FormularioPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim validacion As New Validaciones
        validacion.Validar(Me)
        ' dtpFechaVencimiento.MinDate = Date.Now()
    End Sub
    Public Sub Detalles()
        DTDetalles.Columns.AddRange(New DataColumn(7) {New DataColumn("IDItems"),
                                                       New DataColumn("Nombre"),
                                                       New DataColumn("Cantidad"),
                                                       New DataColumn("Descripcion"),
                                                       New DataColumn("Descuento"),
                                                       New DataColumn("PrecioUnitario"),
                                                       New DataColumn("PrecioFinal"),
                                                       New DataColumn("IDProducto")})

    End Sub

    Public Function CargarPedido() As CEPedido
        Dim oCEPedido As New CEPedido
        oCEPedido.IDPedido = lblID.Text
        oCEPedido.Cliente = cboCliente.SelectedValue
        oCEPedido.Fecha = FormatISO8601(dtpFecha.Text)
        oCEPedido.Descripcion = Trim(txtDescripcion.Text)
        oCEPedido.Medio = cboMedio.SelectedValue
        oCEPedido.Estado = cboEstado.Text
        oCEPedido.Seña = CDbl(txtAnticipoSena.Text)
        oCEPedido.Envio = CStr(chkEnvio.Checked)
        oCEPedido.SubTotal = CDbl(txtSubTotal.valor)
        oCEPedido.Descuento = CInt(cboDesc.Text)
        oCEPedido.Total = CDbl(txtTotal.valor)
        Return oCEPedido
    End Function
    Private Sub btnGuardarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPedido.Click
        If DGListaDePedido.Rows.Count <> 0 Then
            If oCNDetallesDePedido.MostrarDetalles(lblID.Text).Rows.Count > 0 Then
                oCNPedido.ModificarPedido(CargarPedido, TablaItems)
            Else
                oCNPedido.GenerarElPedido(CargarPedido, DTDetalles)
            End If
            Me.Close()
        Else
            MsgBox("El pedido debe contener como minimo 1 producto. ", , "Error de registro")
        End If
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
        chkEnvio.Enabled = False
        btnEnvioGuardado.Enabled = False
        txtSubTotal.Enabled = False
        txtAnticipoSena.Enabled = False
        txtSymbol.Enabled = False
        txtTotal.Enabled = False
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
    Private Sub cboTipoEnvio_SelectedvaluesChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oCNDetallesEnvio As New CNDetallesEnvio

        If chkEnvio.Checked Then
            'revisar porque cuando se hace doble click para abrir el pedido 4 que tiene por envio "nulo" 
            'pero el lblid.text tiene ":ID" dentro del label.
            'este metodo no deberia de ejecutarse al momento de abrir el formulario, solo cuando se selecciona manualmente el combobox.

            'oCNDetallesEnvio.EliminarInformacionEnvio(lblID.Text)


        End If

    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim busquedaControl As New frmBusqueda
        busquedaControl.StartPosition = FormStartPosition.Manual
        busquedaControl.Location = Me.PointToScreen(New Point(btnSearch.Left, btnSearch.Top + btnSearch.Height))
        busquedaControl.ShowDialog()
        txtClienteNombreCompleto.Text = busquedaControl.Nombre + " " + busquedaControl.Apellido
        AsignarTextCbo(busquedaControl.Nombre, cboCliente)
    End Sub
    Public Sub actualizarNombre()
        Me.ClientesTableAdapter.Fill(Me.SolemnoDataSet.Clientes)
        Dim dt As DataTable = Me.ClientesTableAdapter.GetData
        Dim index As Integer = Me.ClientesTableAdapter.GetData.Count - 1
        Dim nombre As String = Me.ClientesTableAdapter.GetData.Rows(index)("Nombre")
        Dim apellido As String = Me.ClientesTableAdapter.GetData.Rows(index)("Apellido")
        txtClienteNombreCompleto.Text = nombre + " " + apellido
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim mainFrm As New frmMenuPrincipal
        mainFrm.btnNuevoCliente_Click(sender, e)
        actualizarNombre()
        cboCliente.SelectedIndex = CInt(cboCliente.Items.Count - 1)

    End Sub

    Private Sub btnGuardarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPresupuesto.Click
        Dim oCEPedido As New CEPedido
        CalcularTotalBruto()
        oCEPedido = CargarPedido()
        oCEPedido.Estado = "Presupuesto"
        oCEPedido.PresupuestoVencimiento = FormatISO8601(dtpFechaVencimiento.Text)
        oCEPedido.Seña = 0

        If DGListaDePedido.Rows.Count <> 0 Then
            If DTDetalles.Rows.Count > 0 And TablaItems.Rows.Count > 0 Then
                MsgBox("Error en la carga del presupuesto")
            ElseIf DTDetalles.Rows.Count > 0 And TablaItems.Rows.Count = 0 Then
                oCNPedido.GenerarElPedido(oCEPedido, DTDetalles)
            ElseIf DTDetalles.Rows.Count = 0 And TablaItems.Rows.Count > 0 Then
                oCNPedido.ModificarPedido(oCEPedido, TablaItems)
            End If
            CalcularTotalBruto()
            Me.Close()
        Else
            MsgBox("El presupuesto debe contener como minimo 1 producto. ", , "Error de registro")
        End If

    End Sub

    Private Sub chkEnvio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnvio.CheckedChanged
        btnEnvioGuardado.Enabled = chkEnvio.Checked
    End Sub
    Private Sub CalcularTotal(ByVal dt As DataTable)
        Dim tablaTotal As Double = 0
        For Each dr As DataRow In dt.Rows
            'tablaTotal += dr.Item("Cantidad") * dr.Item("PrecioUnitario")
            tablaTotal += dr.Item("PrecioFinal")
        Next
        txtSubTotal.valor = tablaTotal
        Dim valueSena As Double = 0.0
        If (txtAnticipoSena.Text = "") Then
            valueSena = 0.0
        Else
            valueSena = CDbl(txtAnticipoSena.Text)
        End If

        Dim total As Double = tablaTotal - valueSena - (tablaTotal / 100 * cboDesc.Text)
        txtTotal.valor = total
    End Sub


    Private Sub txtAnticipoSena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnticipoSena.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))


    End Sub

    Private Sub txtAnticipoSena_TextChanged(sender As Object, e As EventArgs) Handles txtAnticipoSena.TextChanged

        CalcularTotalBruto()
    End Sub

    Public Sub CalcularTotalBruto()
        If DTDetalles.Rows.Count > 0 And TablaItems.Rows.Count > 0 Then
            MsgBox("Error en la carga del presupuesto")
        ElseIf DTDetalles.Rows.Count > 0 And TablaItems.Rows.Count = 0 Then
            CalcularTotal(DTDetalles)
        ElseIf DTDetalles.Rows.Count = 0 And TablaItems.Rows.Count > 0 Then
            CalcularTotal(TablaItems)
        End If
    End Sub
    Private Sub cboDesc_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesc.SelectedValueChanged
        If DTDetalles.Rows.Count > 0 And TablaItems.Rows.Count > 0 Then
            MsgBox("Error en la carga del presupuesto")
        ElseIf DTDetalles.Rows.Count > 0 And TablaItems.Rows.Count = 0 Then
            CalcularTotal(DTDetalles)
        ElseIf DTDetalles.Rows.Count = 0 And TablaItems.Rows.Count > 0 Then
            CalcularTotal(TablaItems)
        End If
    End Sub
    Private Sub DGListaDePedido_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGListaDePedido.CellClick

        If e.RowIndex >= 0 Then
            IDitemSelected = DGListaDePedido.Rows(e.RowIndex).Cells("IDItems").Value

        End If
    End Sub


    Private Sub DGListaDePedido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGListaDePedido.CellDoubleClick
        If e.RowIndex >= 0 Then

            CalcularTotalBruto()
            Dim ProductoID As Integer
            Dim dtrow As DataRow
            Dim ValorIndex As Integer
            If DTDetalles.Rows.Count > 0 Then
                Dim i As Integer = DTDetalles.Rows.Count - 1
                For x As Integer = 0 To DTDetalles.Rows.Count - 1
                    Dim iditem As Integer = DTDetalles.Rows(x).Item("IDItems")
                    If (iditem = IDitemSelected) Then

                        ProductoID = DTDetalles.Rows(x).Item("IDProducto")
                        ValorIndex = x
                        Exit For
                    End If

                Next
            ElseIf TablaItems.Rows.Count > 0 Then
                Dim i As Integer = TablaItems.Rows.Count - 1
                For x As Integer = 0 To TablaItems.Rows.Count - 1
                    Dim iditem As Integer = TablaItems.Rows(x).Item("IDItems")
                    If (iditem = IDitemSelected) Then

                        ProductoID = TablaItems.Rows(x).Item("IDProducto")

                        dtrow = (DGListaDePedido.Rows(x).DataBoundItem).Row
                        ValorIndex = x

                        Exit For
                    End If

                Next
            End If
            Dim frmModProducto As New AgregarProductoPedido
            If Not (dtrow Is Nothing) Then
                frmModProducto.CargarDatosModificar(ProductoID, dtrow)
                frmModProducto.ShowDialog()
                If Not frmModProducto.oCEproducto.Nombre Is Nothing Then

                    TablaItems.Rows.RemoveAt(ValorIndex)
                    AgregarDatosADetalles(frmModProducto.oCEproducto, TablaItems, frmModProducto.oCEDetallesDelPedido)
                End If
            Else
                dtrow = DTDetalles.Rows(ValorIndex)
                frmModProducto.CargarDatosModificar(ProductoID, dtrow)
                frmModProducto.ShowDialog()
                If Not frmModProducto.oCEproducto.Nombre Is Nothing Then
                    DTDetalles.Rows.RemoveAt(ValorIndex)
                    AgregarDatosADetalles(frmModProducto.oCEproducto, DTDetalles, frmModProducto.oCEDetallesDelPedido)
                End If

            End If


            DGListaDePedido.Rows(e.RowIndex).Selected = True
        End If
        CalcularTotalBruto()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim report As New frmReportePedido
        If (lblID.Text) Then
            report.IDPedido = CInt(lblID.Text)
        End If
        report.ShowDialog()
        report.Dispose()

    End Sub

    'Private Sub txtAnticipo_LostFocus(sender As Object, e As EventArgs) Handles txtAnticipo.LostFocus
    '    CalcularTotalBruto()
    'End Sub

    Private Sub btnConfirmarPedido_Click(sender As Object, e As EventArgs) Handles btnConfirmarPedido.Click
        visibilidadFormularioPresupuesto()

    End Sub

    Public Sub visibilidadFormularioPresupuesto()


        Me.btnConfirmarPedido.Text = "Volver"
        Me.lblEstado.Visible = Not (Me.lblEstado.Visible)
        Me.cboEstado.Visible = Not (Me.cboEstado.Visible)
        Me.lblSeña.Visible = Not (Me.lblSeña.Visible)
        Me.txtAnticipoSena.Visible = Not (Me.txtAnticipoSena.Visible)
        Me.txtSymbol.Visible = Not (Me.txtSymbol.Visible)

        If lblSeña.Visible = True Then
            Me.btnConfirmarPedido.Text = "Volver"
            Me.Text = "Detalles del pedido"
        Else
            Me.btnConfirmarPedido.Text = "Generar el pedido"
            Me.Text = "Detalles del presupuesto"
        End If
        Me.btnGuardarPedido.Visible = Not (Me.btnGuardarPedido.Visible)


        Me.dtpFechaVencimiento.Visible = Not (Me.dtpFechaVencimiento.Visible)
        Me.lblFechaVencimiento.Visible = Not (Me.lblFechaVencimiento.Visible)
        Me.btnGuardarPresupuesto.Visible = Not (Me.btnGuardarPresupuesto.Visible)

    End Sub
End Class
