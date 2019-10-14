Imports CapaNegocio
Imports CapaEntidad

Public Class frmMenuPrincipal
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim validacion As New Validaciones
        validacion.Validar(Me)
        AbrirFormInPanel(frmPestañaTareas)
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- CLIENTE  -----------------------------------------------------------

    Dim oCECliente As CECliente
    Dim oCNCliente As New CNCliente
    Dim ID As String
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        CargarGridCliente()
        DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()

    End Sub
    Public Sub CargarGridCliente()
        'la funcion de listar cliente retornara un datatable que contendra la tabla del cliente, y esta sera mostrada en el datagrid
        DGCliente.DataSource = oCNCliente.MostrarCliente

    End Sub
    Private Sub TabCliente_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabCliente.Enter
        CargarGridCliente()
        cboBuscarCliente.SelectedIndex = 0
    End Sub
    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.lblID.Text = oCNCliente.ConsultarUltimoID
        frmRegistrar.PrecargarCombobox()
        frmRegistrar.ShowDialog()
        CargarGridCliente()
    End Sub
    Private Sub DGCliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCliente.CellClick
        'se usa esto para cuando hagan click en alguna celda del datagridview se seleccione la fila completa
        DGCliente.CurrentRow.Selected = True
        'esta siguiente parte es para cuando das click en el datagridview te de el ID de esa fila
        ID = DGCliente.Rows(e.RowIndex).Cells("IDCliente").Value

        '---------------------------importante-------------
        ' aca tenia el metodo LlenarFormulario para precargar los datos. pero en algun momento lo borre,
        ' y  funciono sin el, debido que al no tener posibilidad de modificar el
        'id se updateo con el.
    End Sub
    Private Sub DGCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGCliente.DoubleClick
        'Dim dr As DataRow = DGCliente.SelectedRows(0).Index
        'Dim ID As String = DGCliente.SelectedRows(0).Cells("IDCliente").Value.ToString()
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.ShowDialog()
        CargarGridCliente()
    End Sub
    Private Sub btnVerCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerCliente.Click
        ID = DGCliente.Rows(DGCliente.CurrentCell.RowIndex).Cells("IDCliente").Value
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.LlenarFormulario(ID)

        frmRegistrar.Disesabletext()

        frmRegistrar.ShowDialog()
    End Sub
    Private Sub btnModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCliente.Click
        ID = DGCliente.Rows(DGCliente.CurrentCell.RowIndex).Cells("IDCliente").Value
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.ShowDialog()
        CargarGridCliente()
    End Sub
    Private Sub btnEliminarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCliente.Click
        ID = DGCliente.Rows(DGCliente.CurrentCell.RowIndex).Cells("IDCliente").Value
        If oCNPedido.ValidarEliminarPedido(ID) Then
            '--
            If MessageBox.Show("Esta seguro de mandar a la papelera el cliente? ", "Confirmacion de eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                oCNCliente.EliminarCliente(ID, "Inactivo")
                CargarGridCliente()
            End If

            '--
        End If
       
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim dt As DataTable
        dt = oCNCliente.BuscarCliente(cboBuscarCliente.Text, Trim(txtBuscarCliente.Text))
        DGCliente.DataSource = dt.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido", "DNI", "CUIT", "Telefono", "Provincia", "Localidad", "Condicion de IVA")
        'para que el combobox no permita escribir, se cambio el dropdownstyle =DropDownList
    End Sub
    '---------- Para el estado eliminar
    Private Sub btnListadoClientesInactivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoClientesInactivos.Click
        DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()

        If btnListadoClientesInactivos.Text = "Papelera Clientes" Then
            ControlesRecuperar()
        ElseIf btnListadoClientesInactivos.Text = "Volver" Then
            VolverAlInicio()
        End If
    End Sub
    Public Sub ControlesRecuperar()
        btnListadoClientesInactivos.Text = "Volver"
        DGClienteInactivos.Visible = True
        DGCliente.Visible = False
        btnNuevoCliente.Enabled = False
        btnModificarCliente.Enabled = False
        btnVerCliente.Visible = False
        btnVerInactivo.Visible = True
        btnBuscarCliente.Visible = False
        btnEliminarCliente.Visible = False
        btnBuscarInactivos.Visible = True
        btnRestaurar.Visible = True
    End Sub
    Private Sub DGClienteInactivos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClienteInactivos.CellClick
        DGClienteInactivos.CurrentRow.Selected = True

        ID = DGClienteInactivos.Rows(e.RowIndex).Cells("IDCliente").Value

     
    End Sub
    Private Sub DGClienteInactivos_CellDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGClienteInactivos.CellDoubleClick

        Dim frmRegistrar As New RegistrarCliente
        If MessageBox.Show("Esta seguro de Restaurar el Cliente? ", "Confirmacion de restaurar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNCliente.EliminarCliente(ID, "Activo")
            CargarGridCliente()
            DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()
            VolverAlInicio()
        End If
    End Sub
    Private Sub btnBuscarInactivos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarInactivos.Click
        Dim dt As DataTable
        dt = oCNCliente.BuscarInactivo(cboBuscarCliente.Text, Trim(txtBuscarCliente.Text))
        DGClienteInactivos.DataSource = dt.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido", "DNI", "CUIT", "Telefono", "Provincia", "Localidad", "Condicion de IVA")

    End Sub
    Private Sub btnVerInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerInactivo.Click
        ID = DGClienteInactivos.Rows(DGClienteInactivos.CurrentCell.RowIndex).Cells("IDCliente").Value
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.LlenarFormularioInactivo(ID)
        frmRegistrar.Disesabletext()
        frmRegistrar.ShowDialog()
    End Sub
    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click
        ID = DGClienteInactivos.Rows(DGClienteInactivos.CurrentCell.RowIndex).Cells("IDCliente").Value
        If MessageBox.Show("Esta seguro de restaurar el cliente? ", "Confirmacion de restaurar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNCliente.EliminarCliente(ID, "Activo")
            CargarGridCliente()
            DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()
            VolverAlInicio()
        End If

       
    End Sub
    Public Sub VolverAlInicio()
        btnListadoClientesInactivos.Text = "Papelera Clientes"
        DGCliente.Visible = True
        btnNuevoCliente.Enabled = True
        btnModificarCliente.Enabled = True
        btnVerCliente.Visible = True
        btnBuscarCliente.Visible = True
        btnEliminarCliente.Visible = True

        btnVerInactivo.Visible = False
        btnRestaurar.Visible = False
        DGClienteInactivos.Visible = False
        btnBuscarInactivos.Visible = False
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- PRODUCTO -----------------------------------------------------------

    Dim oCNProducto As New CNProducto
    Public Sub CargarGridProducto()
        DGProducto.DataSource = oCNProducto.MostrarProducto().DefaultView.ToTable(True, "IDProducto", "Nombre", "Precio", "Codigo")
    End Sub
    Private Sub TabProducto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabProducto.Enter
        CargarGridProducto()
        cboBuscarProducto.SelectedIndex = 0
    End Sub
    Private Sub btnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        Dim frmRegistrar As New RegistrarProducto
        frmRegistrar.lblID.Text = oCNProducto.ConsultarUltimoID()
        frmRegistrar.ShowDialog()
        CargarGridProducto()
    End Sub
   
    Private Sub btnModificarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.Click
        ID = DGProducto.Rows(DGProducto.CurrentCell.RowIndex).Cells("IDProducto").Value
        Dim frmRegistrar As New RegistrarProducto
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.Text = "Modificar Producto"
        frmRegistrar.ShowDialog()
        CargarGridProducto()
    End Sub
    Private Sub btnVerProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProducto.Click
        ID = DGProducto.Rows(DGProducto.CurrentCell.RowIndex).Cells("IDProducto").Value
        Dim frmRegistrar As New RegistrarProducto
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.Text = "Detalles de productos"
        frmRegistrar.Disesabletext()
        frmRegistrar.btnCancelar.Visible = False
        frmRegistrar.btnGuardarProducto.Visible = False
        frmRegistrar.btnRegistrarProducto.Visible = False
        frmRegistrar.btnAceptar.Visible = True
        frmRegistrar.ShowDialog()
    End Sub
    Private Sub btnBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProducto.Click
        Dim dt As New DataTable
        dt = oCNProducto.BuscarProducto(cboBuscarProducto.Text, txtBuscarProducto.Text)
        DGProducto.DataSource = dt
    End Sub
   
    Private Sub DGProducto_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGProducto.CellMouseDoubleClick
        ID = DGProducto.Rows(e.RowIndex).Cells("IDProducto").Value
        Dim frmRegistrar As New RegistrarProducto
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.Text = "Modificar Producto"
        frmRegistrar.ShowDialog()
        CargarGridProducto()
    End Sub
    '------------------------para la papelera------ 
    Private Sub btnEliminarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        ID = DGProducto.Rows(DGProducto.CurrentCell.RowIndex).Cells("IDProducto").Value
        If MessageBox.Show("Esta seguro de mandar a la papelera el Producto? ", "Confirmacion de eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNProducto.EliminarProducto(ID, "Inactivo")
            CargarGridProducto()
        End If

        
       
    End Sub
    Private Sub btnRestaurarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurarProducto.Click
        Dim ID As Integer = DGProductoInactivo.Rows(DGProductoInactivo.CurrentCell.RowIndex).Cells("IDProducto").Value
        If MessageBox.Show("Esta seguro de restaurar el producto? ", "Restaurar el producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNProducto.EliminarProducto(ID, "Activo")
            CargarGridProducto()
            DGProductoInactivo.DataSource = oCNProducto.MostrarProductoInactivo()
            MostrarProductosModoActivo()
        End If
    End Sub

    Private Sub btnDetalleProductoInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleProductoInactivo.Click
        ID = DGProductoInactivo.Rows(DGProductoInactivo.CurrentCell.RowIndex).Cells("IDProducto").Value
        Dim frmProducto As New RegistrarProducto
        frmProducto.Text = "Detalles de productos"
        frmProducto.LlenarFormularioInactivo(ID)
        frmProducto.Disesabletext()
        frmProducto.btnCancelar.Visible = False
        frmProducto.btnGuardarProducto.Visible = False
        frmProducto.btnRegistrarProducto.Visible = False
        frmProducto.btnAceptar.Visible = True
        frmProducto.ShowDialog()
    End Sub

    Private Sub btnPapeleraProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPapeleraProducto.Click
        DGProductoInactivo.DataSource = oCNProducto.MostrarProductoInactivo()
        If btnPapeleraProducto.Text = "Papelera Producto" Then
            MostrarProductosModoInactivo()
        ElseIf btnPapeleraProducto.Text = "Volver" Then
            MostrarProductosModoActivo()
        End If
    End Sub

    Private Sub btnBuscarProductoInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProductoInactivo.Click
        Dim dt As DataTable
        dt = oCNProducto.BuscarProductoInactivo(cboBuscarProducto.Text, Trim(txtBuscarProducto.Text))
        DGProductoInactivo.DataSource = dt

    End Sub

    Private Sub DGProductoInactivo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProductoInactivo.CellClick
        DGProductoInactivo.CurrentRow.Selected = True
        ID = DGProductoInactivo.Rows(e.RowIndex).Cells("IDProducto").Value
    End Sub

    Private Sub DGProductoInactivo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProductoInactivo.CellDoubleClick
        Dim frmRegistrar As New RegistrarProducto
        Dim ID As Integer = DGProductoInactivo.Rows(DGProductoInactivo.CurrentCell.RowIndex).Cells("IDProducto").Value
        If MessageBox.Show("Esta seguro de Restaurar el Producto? ", "Confirmacion de restaurar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNProducto.EliminarProducto(ID, "Activo")
            CargarGridProducto()
            DGProductoInactivo.DataSource = oCNProducto.MostrarProductoInactivo()
            MostrarProductosModoActivo()
        End If
        
    End Sub
    Public Sub MostrarProductosModoInactivo()
        btnPapeleraProducto.Text = "Volver"
        btnBuscarProductoInactivo.Visible = True
        btnRestaurarProducto.Visible = True
        btnDetalleProductoInactivo.Visible = True
        DGProductoInactivo.Visible = True


        btnEliminarProducto.Visible = False
        btnVerProducto.Visible = False
        DGProducto.Visible = False
        btnBuscarProducto.Visible = False

        btnAgregarProducto.Enabled = False
        btnModificarProducto.Enabled = False
    End Sub
    Public Sub MostrarProductosModoActivo()
        btnPapeleraProducto.Text = "Papelera Producto"
        btnBuscarProductoInactivo.Visible = False
        btnRestaurarProducto.Visible = False
        btnDetalleProductoInactivo.Visible = False
        DGProductoInactivo.Visible = False

        btnBuscarProducto.Visible = True
        btnEliminarProducto.Visible = True
        btnVerProducto.Visible = True
        DGProducto.Visible = True
        btnAgregarProducto.Enabled = True
        btnModificarProducto.Enabled = True
    End Sub
    Private Sub btnRefreshProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshProduct.Click
        CargarGridProducto()
        DGProductoInactivo.DataSource = oCNProducto.MostrarProductoInactivo()
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- PEDIDOS -----------------------------------------------------------
    Dim oCNPedido As New CNPedido
    Private Sub TabPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPedido.Enter
        CargarGridPedidos()
        cboBuscarPedido.SelectedIndex = 0
    End Sub
    Public Sub CargarGridPedidos()
        DGPedido.DataSource = oCNPedido.MostrarPedido
    End Sub
    Private Sub btnNuevoPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPedido.Click
        Dim frmPedido As New FormularioPedido
        frmPedido.btnAgregarPedidoExistente.Visible = False
        frmPedido.btnAgregarPedidoNuevo.Visible = True
        frmPedido.btnGuardarPedido.Visible = True
        frmPedido.btnGuardarCambios.Visible = False
        frmPedido.lblID.Text = oCNPedido.ConsultarUltimoID()
        frmPedido.Detalles()
        'precargar combobox
        frmPedido.PrecargarCombobox()
        frmPedido.ShowDialog()
        CargarGridPedidos()
    End Sub

    Private Sub btnModificarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPedido.Click
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPedido As New FormularioPedido
        frmPedido.btnAgregarPedidoNuevo.Visible = False
        frmPedido.btnAgregarPedidoExistente.Visible = True
        frmPedido.btnGuardarPedido.Visible = False
        frmPedido.btnGuardarCambios.Visible = True
        frmPedido.CargarGridDetalles(ID)
        frmPedido.LLenarFormulario(ID)
        frmPedido.lblID.Text = ID
        frmPedido.ShowDialog()
        CargarGridPedidos()
    End Sub

    Private Sub btnVerPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPedido.Click
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPedido As New FormularioPedido
        frmPedido.btnAgregarPedidoNuevo.Visible = False
        frmPedido.btnAgregarPedidoExistente.Visible = True
        frmPedido.btnAgregarPedidoNuevo.Enabled = False
        frmPedido.btnAgregarPedidoExistente.Enabled = False
        frmPedido.btnModificarPedido.Enabled = False
        frmPedido.btnQuitar.Enabled = False
        frmPedido.btnGuardarPedido.Visible = False
        frmPedido.btnGuardarCambios.Visible = False
        frmPedido.btnCancelarPedido.Text = "Aceptar"
        frmPedido.CargarGridDetalles(ID)
        frmPedido.LLenarFormulario(ID)
        frmPedido.Disesabletext()
        frmPedido.ShowDialog()
        CargarGridPedidos()
    End Sub

    Private Sub btnEliminarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPedido.Click
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        oCNPedido.EliminarPedido(ID)
        CargarGridPedidos()
    End Sub

    Private Sub btnBuscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPedido.Click
        Dim dt As DataTable
        dt = oCNPedido.BuscarPedido(txtBuscarPedido.Text, cboBuscarPedido.Text)
        DGPedido.DataSource = dt
    End Sub

    Private Sub DGPedido_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGPedido.MouseDoubleClick
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPedido As New FormularioPedido
        frmPedido.btnAgregarPedidoNuevo.Visible = False
        frmPedido.btnAgregarPedidoExistente.Visible = True
        frmPedido.btnGuardarPedido.Visible = False
        frmPedido.btnGuardarCambios.Visible = True
        frmPedido.CargarGridDetalles(ID)
        frmPedido.LLenarFormulario(ID)
        frmPedido.lblID.Text = ID
        frmPedido.ShowDialog()
        CargarGridPedidos()
    End Sub

    Private Sub btnRefreshPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshPedido.Click
        CargarGridPedidos()

    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- ESTADISTICAS -----------------------------------------------------------
    Dim oCNGraficas As New CNGraficos

    Dim Meses As String() = {"Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Agos", "Sep", "Oct", "Nov", "Dic"}
    Public Sub GraficoPedidosMensuales()
        Me.GraficoSegunConsulta.Series("2019").Points.Clear()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()
        Dim i As Integer = 1
        For i = 1 To 12
            Dim cant2018 As Integer = oCNGraficas.GraficaPedidosMensuales(i, 2018)
            Dim cant2019 As Integer = oCNGraficas.GraficaPedidosMensuales(i, cboAño2.SelectedItem)
            Me.GraficoSegunConsulta.Series("Cantidad").Points.AddXY((Meses(i - 1)), (cant2018))
            Me.GraficoSegunConsulta.Series("2019").Points.AddXY((Meses(i - 1)), (cant2019))
        Next
    End Sub
    Public Sub GraficarMedios()
        Me.GraficoSegunConsulta.Series("2019").Points.Clear()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()

        If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
            MsgBox("Debe ingresar un valor para los campos mes y año.")
        Else
            Dim dt As DataTable = oCNGraficas.GraficarCantidadPedidosPorMedio(cboMeses.SelectedIndex + 1, cboAño.Text)
            Dim dv As DataView = New DataView(dt)
            For x = 0 To dv.Count - 1

                GraficoSegunConsulta.Series("Cantidad").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
            Next
        End If
    End Sub
    Public Sub GraficarProductosMensual()
        Me.GraficoSegunConsulta.Series("2019").Points.Clear()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()

        If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
            MsgBox("Debe ingresar un valor para los campos mes y año.")
        Else
            Dim dt As DataTable = oCNGraficas.GraficarProductosMensuales(cboMeses.SelectedIndex + 1, cboAño.Text)
            Dim dv As DataView = New DataView(dt)
            For x = 0 To dv.Count - 1
                GraficoSegunConsulta.Series("Cantidad").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
            Next
        End If
    End Sub
   
    Private Sub btnGraficoPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoPedidos.Click
        GraficoPedidosMensuales()
    End Sub
    Private Sub btnGraficoMedios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoMedios.Click
        GraficarMedios()
    End Sub
 
    Private Sub btnGraficosProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficosProducto.Click
        GraficarProductosMensual()
    End Sub



    '--------------------------------------------------------------------------------------------------------------
    '----------------------------------------   POSTICKS         -----------------------------------------------
   
   
    Private Sub TabTareas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabTareas.Enter
        AbrirFormInPanel(frmPestañaTareas)
    End Sub

    Public Sub AbrirFormInPanel(ByVal formHijo As Object)

        If (Me.TabTareas.Controls.Count > 0) Then

            TabTareas.Controls.RemoveAt(0)
            Dim fh As Form = formHijo
            fh.TopLevel = False
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            TabTareas.Controls.Add(fh)
            TabTareas.Tag = fh
            fh.Show()

        End If

    End Sub

    '--------------------------------------------------------------------------------------------
    '-------------------------------presupuesto---------------------------------
    Dim oCNPresupuesto As New CNPedido
    Private Sub TabPresupuesto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPresupuesto.Enter
        CargarGridPresupuestos()
        cboBuscarPresupuesto.SelectedIndex = 0
    End Sub
    Public Sub CargarGridPresupuestos()
        DGPresupuesto.DataSource = oCNPresupuesto.MostrarPedido
    End Sub
    Private Sub btnNuevoPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPresupuesto.Click
        Dim frmPresupuesto As New FormularioPresupuesto
        frmPresupuesto.btnAgregarPedidoExistente.Visible = False
        frmPresupuesto.btnAgregarPedidoNuevo.Visible = True
        frmPresupuesto.btnGuardarPedido.Visible = True
        frmPresupuesto.btnGuardarCambios.Visible = False
        frmPresupuesto.lblID.Text = oCNPresupuesto.ConsultarUltimoID()
        frmPresupuesto.Detalles()
        'precargar combobox
        frmPresupuesto.PrecargarCombobox()
        frmPresupuesto.ShowDialog()
        CargarGridPresupuestos()
    End Sub

    Private Sub btnModificarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPresupuesto.Click
        ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPresupuesto As New FormularioPresupuesto
        frmPresupuesto.btnAgregarPedidoNuevo.Visible = False
        frmPresupuesto.btnAgregarPedidoExistente.Visible = True
        frmPresupuesto.btnGuardarPedido.Visible = False
        frmPresupuesto.btnGuardarCambios.Visible = True
        frmPresupuesto.CargarGridDetalles(ID)
        frmPresupuesto.LLenarFormulario(ID)
        frmPresupuesto.lblID.Text = ID
        frmPresupuesto.ShowDialog()
        CargarGridPresupuestos()
    End Sub

    Private Sub btnVerPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPresupuesto.Click
        ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPresupuesto As New FormularioPresupuesto
        frmPresupuesto.btnAgregarPedidoNuevo.Visible = False
        frmPresupuesto.btnAgregarPedidoExistente.Visible = True
        frmPresupuesto.btnAgregarPedidoNuevo.Enabled = False
        frmPresupuesto.btnAgregarPedidoExistente.Enabled = False
        frmPresupuesto.btnModificarPedido.Enabled = False
        frmPresupuesto.btnQuitar.Enabled = False
        frmPresupuesto.btnGuardarPedido.Visible = False
        frmPresupuesto.btnGuardarCambios.Visible = False
        frmPresupuesto.btnCancelarPedido.Text = "Aceptar"
        frmPresupuesto.CargarGridDetalles(ID)
        frmPresupuesto.LLenarFormulario(ID)
        frmPresupuesto.Disesabletext()
        frmPresupuesto.ShowDialog()
        CargarGridPresupuestos()
    End Sub

    Private Sub btnEliminarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPresupuesto.Click
        ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        oCNPresupuesto.EliminarPedido(ID)
        CargarGridPresupuestos()
    End Sub

    Private Sub btnBuscarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPresupuesto.Click
        Dim dt As DataTable
        dt = oCNPresupuesto.BuscarPedido(txtBuscarPresupuesto.Text, cboBuscarPresupuesto.Text)
        DGPresupuesto.DataSource = dt
    End Sub

    Private Sub DGPresupuesto_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGPresupuesto.MouseDoubleClick
        ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPresupuesto As New FormularioPresupuesto
        frmPresupuesto.btnAgregarPedidoNuevo.Visible = False
        frmPresupuesto.btnAgregarPedidoExistente.Visible = True
        frmPresupuesto.btnGuardarPedido.Visible = False
        frmPresupuesto.btnGuardarCambios.Visible = True
        frmPresupuesto.CargarGridDetalles(ID)
        frmPresupuesto.LLenarFormulario(ID)
        frmPresupuesto.lblID.Text = ID
        frmPresupuesto.ShowDialog()
        CargarGridPresupuestos()
    End Sub

    Private Sub btnRefreshPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshPresupuesto.Click
        CargarGridPresupuestos()

    End Sub

    Public Sub enableAdminMode()

        TabGeneral.TabPages.Add(TabPresupuesto)

    End Sub
    Public Sub enableEsclavoMode()
        If (TabGeneral.TabPages.Contains(TabPresupuesto)) Then
            TabGeneral.TabPages.Remove(TabPresupuesto)
        End If
    End Sub

    Private Sub btnDeslogear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeslogear.Click
        Me.Hide()
        Me.lblNombreUsuario.Text = ""
        frmIngresaralSistema.Show()
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

 
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEstadistica.SelectedIndexChanged
        If (cbo) Then

    End Sub
End Class