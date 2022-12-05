Imports CapaNegocio
Imports CapaEntidad
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmMenuPrincipal
    Public Shared LocalUsuario As String
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SolemnoDataSet1.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SolemnoDataSet.Usuarios)
        Dim validacion As New Validaciones
        validacion.Validar(Me)
        AbrirFormInPanel(frmPestañaTareas)
        'If Me.lblUsuario.Text.ToString().Length > 4 Then
        '    LocalUsuario = Me.lblUsuario.Text
        'End If

    End Sub
    '---------------------------------------- CLIENTE  -----------------------------------------------------------
#Region "Pestaña Cliente"
    Dim oCECliente As CECliente
    Dim oCNCliente As New CNCliente
    Dim ID As String
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        CargarGridCliente()
        CargarGridClienteInactivo()

    End Sub
    Public Sub CargarGridCliente()
        'la funcion de listar cliente retornara un datatable que contendra la tabla del cliente, y esta sera mostrada en el datagrid
        Dim dt As New DataTable
        dt = oCNCliente.MostrarCliente
        DGCliente.DataSource = dt
        DGCliente.Columns(0).Visible = False
        DGCliente.Columns(6).Visible = False
        DGCliente.Columns(7).Visible = False
        DGCliente.Columns(8).Visible = False
        MostrarSinResultados(dt, DGCliente)

        'If DGCliente.Visible Then
        '    If DGCliente.Rows.Count = 0 Then
        '        FondoSinResultados.Visible = True
        '    Else
        '        FondoSinResultados.Visible = False
        '    End If
        'End If
    End Sub
    Public Sub CargarGridClienteInactivo()
        Dim dt As New DataTable
        dt = oCNCliente.MostrarClienteIncativo()
        DGClienteInactivos.DataSource = dt
        MostrarSinResultados(dt, DGClienteInactivos)
    End Sub
    Private Sub TabCliente_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabCliente.Enter
        CargarGridCliente()
        cboBuscarCliente.SelectedIndex = 0

    End Sub
    Public Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.lblID.Text = oCNCliente.ConsultarUltimoID
        frmRegistrar.PrecargarCombobox()
        frmRegistrar.ShowDialog()
        CargarGridCliente()
    End Sub



    Private Sub DGCliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCliente.CellClick
        If e.RowIndex >= 0 Then
            ID = DGCliente.Rows(e.RowIndex).Cells("IDCliente").Value

        End If
    End Sub
    Private Sub DGCliente_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCliente.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim frmRegistrar As New RegistrarCliente
            frmRegistrar.LlenarFormulario(ID)
            frmRegistrar.txtDNI.Enabled = False
            frmRegistrar.txtCuit.Enabled = False

            frmRegistrar.ShowDialog()
            CargarGridCliente()

            DGCliente.Rows(e.RowIndex).Selected = True
        End If

    End Sub
    Private Sub btnVerCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerCliente.Click
        ID = DGCliente.Rows(DGCliente.CurrentCell.RowIndex).Cells("IDCliente").Value
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.btnGuardar.Visible = False
        frmRegistrar.btnRegistrar.Visible = False
        frmRegistrar.btnCancelar.Visible = False
        frmRegistrar.Disesabletext()

        frmRegistrar.ShowDialog()
    End Sub
    Private Sub btnModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCliente.Click
        ID = DGCliente.Rows(DGCliente.CurrentCell.RowIndex).Cells("IDCliente").Value
        Dim frmRegistrar As New RegistrarCliente

        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.txtDNI.Enabled = False
        frmRegistrar.txtCuit.Enabled = False
        frmRegistrar.ShowDialog()
        CargarGridCliente()
    End Sub
    Private Sub btnEliminarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCliente.Click
        'ID = DGCliente.Rows(DGCliente.CurrentCell.RowIndex).Cells("IDCliente").Value
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
        DGCliente.DataSource = dt.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido", "DNI", "CUIT", "Telefono")
        DGCliente.Columns(0).Visible = False
        'para que el combobox no permita escribir, se cambio el dropdownstyle =DropDownList
        MostrarSinResultados(dt, DGCliente)
    End Sub
    Public Sub OcultarColumnas(ByVal DGCliente As DataGridView)
        DGCliente.Columns(0).Visible = False
        DGCliente.Columns(6).Visible = False
        DGCliente.Columns(7).Visible = False
        DGCliente.Columns(8).Visible = False
    End Sub
    '---------- Para el estado eliminar
    Private Sub btnListadoClientesInactivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoClientesInactivos.Click
        DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()
        OcultarColumnas(DGClienteInactivos)
        If btnListadoClientesInactivos.Text = "Papelera Clientes" Then
            ControlesRecuperar()
        ElseIf btnListadoClientesInactivos.Text = "Volver" Then
            VolverAlInicio()
        End If
    End Sub
    Public Sub ControlesRecuperar()
        btnListadoClientesInactivos.Text = "Volver"
        lbltituloCliente.Text = "Papelera de Clientes"
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
        If e.RowIndex >= 0 Then
            ID = DGClienteInactivos.Rows(e.RowIndex).Cells("IDCliente").Value
        End If

    End Sub

    Private Sub DGClienteInactivos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClienteInactivos.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' '' ''ID = DGClienteInactivos.Rows(e.RowIndex).Cells("IDCliente").Value


            Dim frmRegistrar As New RegistrarCliente
            If MessageBox.Show("Esta seguro de Restaurar el Cliente? ", "Confirmacion de restaurar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                oCNCliente.EliminarCliente(ID, "Activo")
                CargarGridCliente()
                CargarGridClienteInactivo()
                VolverAlInicio()
            End If


            'DGClienteInactivos.Rows(e.RowIndex).Selected = True
        End If
        '  
    End Sub


    Private Sub btnBuscarInactivos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarInactivos.Click
        Dim dt As DataTable
        dt = oCNCliente.BuscarInactivo(cboBuscarCliente.Text, Trim(txtBuscarCliente.Text))
        DGClienteInactivos.DataSource = dt.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido", "DNI", "CUIT", "Telefono", "Provincia", "Localidad", "Condicion de IVA")
        MostrarSinResultados(dt, DGClienteInactivos)
        DGClienteInactivos.Columns(0).Visible = False
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
            CargarGridClienteInactivo()
            VolverAlInicio()
        End If


    End Sub
    Public Sub VolverAlInicio()
        btnListadoClientesInactivos.Text = "Papelera Clientes"
        lbltituloCliente.Text = "Clientes"
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
#End Region

    '---------------------------------------- PRODUCTO -----------------------------------------------------------
#Region "Pestaña Producto"
    Dim oCNProducto As New CNProducto
    Public Sub CargarGridProducto()
        Dim dt As DataTable = oCNProducto.MostrarProducto().DefaultView.ToTable(True, "IDProducto", "Nombre", "Precio", "Codigo")
        dt.Columns("Precio").ColumnName = "Precio Unitario"

        dt.AcceptChanges()

        DGProducto.DataSource = dt
        DGProducto.Columns(0).Visible = False
        MostrarSinResultados(dt, DGProducto)
    End Sub
    Public Sub CargarGridProductoInactivo()
        Dim dt As DataTable = oCNProducto.MostrarProductoInactivo().DefaultView.ToTable(True, "IDProducto", "Nombre", "Precio", "Codigo")
        dt.Columns("Precio").ColumnName = "Precio Unitario"
        dt.AcceptChanges()
        DGProductoInactivo.DataSource = dt
        DGProductoInactivo.Columns(0).Visible = False
        MostrarSinResultados(dt, DGProductoInactivo)
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
        dt = oCNProducto.BuscarProducto(cboBuscarProducto.Text, txtBuscarProducto.Text).DefaultView.ToTable(True, "IDProducto", "Nombre", "Precio", "Codigo")
        dt.Columns("Precio").ColumnName = "Precio Unitario"
        dt.AcceptChanges()
        DGProducto.DataSource = dt
        DGProducto.Columns(0).Visible = False
        MostrarSinResultados(dt, DGProducto)
    End Sub

    Private Sub DGProducto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProducto.CellClick
        If e.RowIndex >= 0 Then
            ID = DGProducto.Rows(e.RowIndex).Cells("IDProducto").Value
        End If

    End Sub

    Private Sub DGProducto_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProducto.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim frmRegistrar As New RegistrarProducto
            frmRegistrar.LlenarFormulario(ID)
            frmRegistrar.Text = "Modificar Producto"
            frmRegistrar.ShowDialog()
            CargarGridProducto()
            DGProducto.Rows(e.RowIndex).Selected = True
        End If
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

            CargarGridProductoInactivo()
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
        CargarGridProductoInactivo()
        If btnPapeleraProducto.Text = "Papelera Producto" Then
            MostrarProductosModoInactivo()
        ElseIf btnPapeleraProducto.Text = "Volver" Then
            MostrarProductosModoActivo()
        End If
    End Sub

    Private Sub btnBuscarProductoInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProductoInactivo.Click
        Dim dt As New DataTable
        dt = oCNProducto.BuscarProductoInactivo(cboBuscarProducto.Text, txtBuscarProducto.Text).DefaultView.ToTable(True, "IDProducto", "Nombre", "Precio", "Codigo")
        dt.Columns("Precio").ColumnName = "Precio Unitario"
        dt.AcceptChanges()
        DGProductoInactivo.DataSource = dt
        DGProductoInactivo.Columns(0).Visible = False
    End Sub

    Private Sub DGProductoInactivo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProductoInactivo.CellClick
        If e.RowIndex >= 0 Then
            ID = DGProductoInactivo.Rows(e.RowIndex).Cells("IDProducto").Value
        End If

    End Sub

    Private Sub DGProductoInactivo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProductoInactivo.CellDoubleClick
        If e.RowIndex >= 0 Then


            Dim frmRegistrar As New RegistrarProducto
            Dim ID As Integer = DGProductoInactivo.Rows(DGProductoInactivo.CurrentCell.RowIndex).Cells("IDProducto").Value
            If MessageBox.Show("Esta seguro de Restaurar el Producto? ", "Confirmacion de restaurar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                oCNProducto.EliminarProducto(ID, "Activo")
                CargarGridProducto()
                CargarGridProductoInactivo()
                MostrarProductosModoActivo()
            End If
        End If
    End Sub
    Public Sub MostrarProductosModoInactivo()
        lblTituloProducto.Text = "Papelera de productos"
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
        lblTituloProducto.Text = "Productos"
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
        CargarGridProductoInactivo()
        txtBuscarProducto.Text = ""
    End Sub

#End Region


    '---------------------------------------- PEDIDOS -----------------------------------------------------------
#Region "Pestaña pedido"

    Dim oCNPedido As New CNPedido
    Private Sub TabPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPedido.Enter
        CargarGridPedidos()
        cboBuscarPedido.SelectedIndex = 0
        cboFiltroPedido.SelectedIndex = 1
    End Sub
    Public Sub CargarGridPedidos()
        Dim dt As DataTable = oCNPedido.MostrarPedido
        Dim dv As DataView
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Cliente") = dt.Rows(i)("Cliente") & " " & dt.Rows(i)("Apellido")
        Next

        dv = New DataView(dt, "Estado = 'Pendiente'   or  Estado = 'Completado' ", "IDPedido Asc", DataViewRowState.CurrentRows)
        DGPedido.DataSource = dv
        DGPedido.Columns("IDPedido").Visible = False
        DGPedido.Columns("Apellido").Visible = False
        MostrarSinResultados(dt, DGPedido)
    End Sub

    Private Sub btnNuevoPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPedido.Click
        Dim frmPedido As New FormularioPedido

        frmPedido.btnAgregarPedidoNuevo.Visible = True
        frmPedido.btnGuardarPedido.Visible = True



        frmPedido.lblID.Text = oCNPedido.ConsultarUltimoID()
        frmPedido.txtResponsable.Text = lblUsuario.Text
        frmPedido.btnImprimir.Visible = False
        frmPedido.Detalles()
        'precargar combobox
        frmPedido.PrecargarCombobox()
        frmPedido.ShowDialog()
        CargarGridPedidos()
    End Sub



    Private Sub btnVerPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPedido.Click
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim index As Integer = DGPedido.CurrentCell.RowIndex
        Dim frmPedido As New FormularioPedido
        frmPedido.btnAgregarPedidoNuevo.Enabled = False
        frmPedido.btnModificarPedido.Enabled = False
        frmPedido.btnQuitar.Enabled = False
        frmPedido.btnGuardarPedido.Visible = False
        frmPedido.btnCancelarPedido.Text = "Aceptar"
        frmPedido.DGListaDePedido.Enabled = False
        frmPedido.CargarGridDetalles(ID)
        frmPedido.LLenarFormulario(ID)
        frmPedido.lblID.Text = ID
        frmPedido.Disesabletext()
        frmPedido.btnEnvioGuardado.Enabled = True
        frmPedido.ShowDialog()
        CargarGridPedidos()
        DGPedido.Rows(index).Selected = index
    End Sub

    Private Sub btnEliminarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPedido.Click
        If MessageBox.Show("Esta seguro de eliminar el pedido? ", "Confirmacion de eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNPedido.EliminarPedido(ID)
            CargarGridPedidos()

        End If
    End Sub

    Private Sub btnBuscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPedido.Click
        Dim dt As DataTable
        dt = oCNPedido.BuscarPedido(cboBuscarPedido.Text, txtBuscarPedido.Text, cboFiltroPedido.Text)
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Nombre") = dt.Rows(i)("Nombre") & " " & dt.Rows(i)("Apellido")
        Next


        DGPedido.DataSource = dt.DefaultView.ToTable(True, "IDPedido", "Nombre", "Fecha", "Estado", "Descripcion", "Responsable")
        DGPedido.Columns("Nombre").HeaderCell.Value = "Cliente"
        DGPedido.Columns(0).Visible = False
        MostrarSinResultados(dt, DGPedido)
    End Sub

    Private Sub DGPedido_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPedido.CellClick
        If e.RowIndex >= 0 Then
            ID = DGPedido.Rows(e.RowIndex).Cells("IDPedido").Value

        End If
    End Sub

    Private Sub DGPedido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPedido.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim frmPedido As New FormularioPedido
            frmPedido.btnGuardarPedido.Visible = True
            frmPedido.CargarGridDetalles(ID)
            frmPedido.LLenarFormulario(ID)
            frmPedido.lblID.Text = ID
            frmPedido.ShowDialog()
            CargarGridPedidos()
            If (DGPedido.Rows.Count > e.RowIndex) Then
                DGPedido.Rows(e.RowIndex).Selected = e.RowIndex
            End If
        End If
    End Sub
    Private Sub btnModificarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPedido.Click
        Dim index As Integer = DGPedido.CurrentCell.RowIndex
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPedido As New FormularioPedido
        frmPedido.btnGuardarPedido.Visible = True
        frmPedido.CargarGridDetalles(ID)
        frmPedido.LLenarFormulario(ID)
        frmPedido.lblID.Text = ID
        frmPedido.ShowDialog()
        CargarGridPedidos()
        If (DGPedido.Rows.Count > index) Then
            DGPedido.Rows(index).Selected = index
        End If
    End Sub
    'Private Sub DGPedido_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGPedido.MouseDoubleClick
    '    ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
    '    Dim frmPedido As New FormularioPedido
    '    frmPedido.btnAgregarPedidoNuevo.Visible = False
    '    frmPedido.btnAgregarPedidoExistente.Visible = True
    '    frmPedido.btnGuardarPedido.Visible = False
    '    frmPedido.btnGuardarCambios.Visible = True
    '    frmPedido.CargarGridDetalles(ID)
    '    frmPedido.LLenarFormulario(ID)
    '    frmPedido.lblID.Text = ID
    '    frmPedido.ShowDialog()
    '    CargarGridPedidos()
    'End Sub

    Private Sub btnRefreshPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPedido.Click
        CargarGridPedidos()

    End Sub
#End Region


    '---------------------------------------- ESTADISTICAS -----------------------------------------------------------
#Region "Pestaña estadistica"
    Dim Meses As String() = {"Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Agos", "Sep", "Oct", "Nov", "Dic"}
    Dim oCNGraficas As New CNGraficos
    Private Sub TabEstadistica_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabEstadistica.Enter
        inicializarPedidosPorFechas()
        cboTipoEstadistica.SelectedIndex = 0
    End Sub
    Public Sub ClearSeries()
        For Each serie In Me.GraficoSegunConsulta.Series
            serie.Points.Clear()
        Next
    End Sub
    Public Sub DisableSeries()
        For Each serie In Me.GraficoSegunConsulta.Series
            serie.Enabled = False
        Next
    End Sub

    Public Sub inicializarPedidosPorFechas()
        cboAño.SelectedIndex = 1
        cboAño2.SelectedIndex = 0
        cboMeses.SelectedIndex = 0
        Dim hoy As Date = Date.Now()
        dtpActual.Value = New Date(hoy.Year, hoy.Month, 1)
        dtpCompare.Value = New Date(hoy.Year, hoy.Month - 1, 1)
        dtpActual.MaxDate = New Date(hoy.Year, hoy.Month, 28)
        dtpCompare.MaxDate = New Date(hoy.Year, hoy.Month, 28)
    End Sub
#Region "Reporte"
    Dim image As Bitmap
    Public Function CapturarGrafico(ctrl As Control) As Bitmap
        Dim size As Size = ctrl.ClientSize
        Dim tmpBmp As New Bitmap(size.Width, size.Height)
        Dim g As Graphics

        g = Graphics.FromImage(tmpBmp)
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        'g.InterpolationMode = Drawing2D.InterpolationMode.High
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        g.CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighSpeed

        g.CopyFromScreen(ctrl.PointToScreen(New Drawing.Point(0, 0)), New Drawing.Point(0, 0),
                         New Size(size.Width, size.Height))
        Return tmpBmp
    End Function
    Private Sub btnVerReporteEstadistica_Click(sender As System.Object, e As System.EventArgs) Handles btnVerReporteEstadistica.Click
        Dim report As New frmReporteEstadistica
        report.imagen = CapturarGrafico(boxEstadistica)
        report.ReportViewer1.LocalReport.SetParameters(New ReportParameter("titulo", lblTituloEstadistica.Text))
        report.ShowDialog()
        report.Dispose()
    End Sub
#End Region

    'Public Sub GraficoPedidosMensuales()
    '    ClearSeries()
    '    Dim hoy As Date = New Date(2019, 8, 16, 12, 0, 0)
    '    Dim actualMes = hoy.Month
    '    Dim actualyear = hoy.Year
    '    Dim fecha As Date

    '    Dim i As Integer = 1
    '    For i = 12 To 1 Step -1
    '        fecha = hoy.AddMonths(-i)
    '        Dim f As Integer = fecha.Month
    '        Dim a As Integer = fecha.Year

    '        Dim cant2018 As Integer = oCNGraficas.GraficaPedidosMensuales(i, cboAño.SelectedItem)
    '        Dim cant2019 As Integer = oCNGraficas.GraficaPedidosMensuales(i, cboAño2.SelectedItem)
    '        Me.GraficoSegunConsulta.Series("Cantidad").Points.AddXY((Meses(f - 1)), (cant2018))
    '        Me.GraficoSegunConsulta.Series("2019").Points.AddXY((Meses(f - 1)), (cant2019))
    '    Next
    'End Sub
    Public Sub ToggleTipoEstadistica()
        lblActual.Visible = Not lblActual.Visible
        lblComparar.Visible = Not lblComparar.Visible
        lblAño.Visible = Not lblAño.Visible
        lblAño2.Visible = Not lblAño2.Visible

        dtpActual.Visible = Not dtpActual.Visible
        dtpCompare.Visible = Not dtpCompare.Visible
        cboAño.Visible = Not cboAño.Visible
        cboAño2.Visible = Not cboAño2.Visible
    End Sub

    Private Sub cboTipoEstadistica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEstadistica.SelectedIndexChanged
        If cboTipoEstadistica.SelectedIndex = 0 Then

            checkUltimaFecha.Text = "Utilizar ultimo mes"

            lblActual.Visible = True
            lblComparar.Visible = True
            lblAño.Visible = False
            lblAño2.Visible = False

            dtpActual.Visible = True
            dtpCompare.Visible = True
            cboAño.Visible = False
            cboAño2.Visible = False



            GraficoPedidosxMes()
        ElseIf cboTipoEstadistica.SelectedIndex = 1 Then
            checkUltimaFecha.Text = "Utilizar ultimo año"

            lblActual.Visible = False
            lblComparar.Visible = False
            lblAño.Visible = True
            lblAño2.Visible = True

            dtpActual.Visible = False
            dtpCompare.Visible = False
            cboAño.Visible = True
            cboAño2.Visible = True
            GraficoPedidosMensuales()
        End If
    End Sub

    Public Sub GraficoPedidosxMes()
        ClearSeries()
        DisableSeries()
        If (Me.GraficoSegunConsulta.Series.IndexOf("Mensual") <> -1) Then
            Me.GraficoSegunConsulta.Series("Mensual").Enabled = True
        Else
            Me.GraficoSegunConsulta.Series.Add("Mensual")
            Me.GraficoSegunConsulta.Series("Mensual").Color = colorPrimario.BackColor
        End If
        If (cboTipoEstadistica.SelectedIndex = 0) Then
            cboAño2.Visible = False
            Dim dt As DataTable = oCNGraficas.GraficaPedidosMensual(cboMeses.SelectedIndex + 1, cboAño.SelectedItem)
            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    Dim fecha As Date = dr(0)

                    For i = 1 To 30
                        If (i = fecha.Day) Then
                            Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(i, dr(1))
                        Else
                            Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(i, 0)
                        End If
                    Next
                Next
            Else
                For i = 1 To 30
                    Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(i, 0)
                Next
            End If

        ElseIf (cboTipoEstadistica.SelectedIndex = 1) Then
            cboAño2.Visible = True


        End If
    End Sub
    Public Sub GraficarMedios()
        Me.GraficoSegunConsulta.Series.Clear()
        Dim Comienzo As String = dtpActual.Value.Year & "/" & dtpActual.Value.Month & "/" & 1
        Dim Fin As String = dtpCompare.Value.Year & "/" & dtpCompare.Value.Month & "/" & 29

        ClearSeries()
        Dim DTMedios As DataTable = MediosTableAdapter1.GetDTGraficoMedios(Comienzo, Fin)
        'GraficoSegunConsulta.Series.Add("Medios")
        If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
            MsgBox("Debe ingresar un valor para los campos mes y año.")
        Else
            Dim dt As DataTable = oCNGraficas.GraficarCantidadPedidosPorMedio(dtpActual.Value.Month - 1, dtpActual.Value.Year)
            Dim dv As DataView = New DataView(DTMedios)
            For x = 0 To dv.Count - 1

                If (Me.GraficoSegunConsulta.Series.IndexOf(dv(x)("Nombre")) <> -1) Then

                Else
                    Me.GraficoSegunConsulta.Series.Add(dv(x)("Nombre"))
                    Me.GraficoSegunConsulta.ChartAreas(0).AxisX.Interval = 1
                    Me.GraficoSegunConsulta.ChartAreas(0).AxisX.IntervalOffset = 1
                    Me.GraficoSegunConsulta.ChartAreas(0).AxisY.Interval = 5
                    Me.GraficoSegunConsulta.ChartAreas(0).AxisY.IntervalOffset = 5
                    Me.GraficoSegunConsulta.Series(dv(x)("Nombre")).ChartType = SeriesChartType.Line
                End If


            Next
            Dim count As Integer = 1
            For x = 0 To dv.Count - 1

                For i = 1 To 12
                    Dim value As Integer = CInt(Int((2 * Rnd()) + 1))
                    Me.GraficoSegunConsulta.Series(dv(x)("Nombre")).Points.AddXY(i, dv(x)("Cantidad") * value)


                Next


            Next





        End If
    End Sub
    Public Sub GraficarProductosMensual()
        ' ClearSeries()
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

#Region "Eventos"
    Private Sub btnGraficoPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoPedidos.Click
        GraficoPedidosMensuales()
    End Sub
    Private Sub btnGraficoMedios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoMedios.Click
        GraficarMedios()
    End Sub
    Private Sub BtnGraficarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGraficarClientes.Click
        GraficarActividadClientes()
    End Sub
    Private Sub cboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño.SelectedIndexChanged
        If (cboTipoEstadistica.SelectedIndex = 1) Then
            GraficoPedidosMensuales()
        End If

    End Sub

    Private Sub cboAño2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño2.SelectedIndexChanged
        If (cboTipoEstadistica.SelectedIndex = 1) Then
            GraficoPedidosMensuales()
        End If
    End Sub

#End Region





    Public Sub GraficarActividadClientes()
        Me.GraficoSegunConsulta.Series("2019").Points.Clear()
        Me.GraficoSegunConsulta.Series("Cantidad").Points.Clear()
        Me.GraficoSegunConsulta.Series("2019").Enabled = False
        Me.GraficoSegunConsulta.Series("Cantidad").Enabled = False
        Me.GraficoSegunConsulta.Series("Mensual").Enabled = False

        Dim dt As DataTable = oCNGraficas.GraficaTopClientes()
        Dim dv As DataView = New DataView(dt)
        For x = 0 To dv.Count - 1
            GraficoSegunConsulta.Series("topClientes").Points.AddXY(dv(x)("Nombre"), dv(x)("Pedidos"))
        Next
    End Sub





#Region "Grafico cantidad de pedidos por mes y por año"

    Public Sub GraficoPedidosMensuales()
        'ClearSeries()
        ' Me.GraficoSegunConsulta.Series.Clear()



        'If (Me.GraficoSegunConsulta.Series.IndexOf(cboAño.Text) <> -1) Then
        '    MsgBox("ya existe la serie")
        'Else
        '    Me.GraficoSegunConsulta.Series.Add(cboAño.Text)
        '    Me.GraficoSegunConsulta.Series(cboAño.Text).Color = colorPrimario.BackColor
        'End If
        'If (Me.GraficoSegunConsulta.Series.IndexOf(cboAño2.Text) <> -1) Then
        '    MsgBox("ya existe la serie")
        'Else
        '    Me.GraficoSegunConsulta.Series.Add(cboAño2.Text)
        '    Me.GraficoSegunConsulta.Series(cboAño2.Text).Color = colorSecundario.BackColor
        'End If




        Dim i As Integer = 1
        For i = 1 To 12
            Dim cant2018 As Integer = oCNGraficas.GraficaPedidosMensuales(i, cboAño.SelectedItem)
            Dim cant2019 As Integer = oCNGraficas.GraficaPedidosMensuales(i, cboAño2.SelectedItem)
            Me.GraficoSegunConsulta.Series("Principal").Points.AddXY((Meses(i - 1)), (cant2018))
            Me.GraficoSegunConsulta.Series("Secundaria").Points.AddXY((Meses(i - 1)), (cant2019))
        Next
    End Sub


    Private Sub dtpCompare_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpCompare.ValueChanged
        Me.GraficoSegunConsulta.Series("Mensual2").Points.Clear()
        Dim comparar As Date = dtpCompare.Value
        Dim dt2 As DataTable = oCNGraficas.GraficaPedidosMensual(comparar.Month, comparar.Year)


        If dt2.Rows.Count = 0 Then
            For i = 1 To 30
                Me.GraficoSegunConsulta.Series("Mensual2").Points.AddXY(i, 0)
            Next
        Else
            For Each dr2 In dt2.Rows
                Dim fecha2 As Date = dr2(0)

                For i = 1 To 30

                    If (i = fecha2.Day) Then
                        ' Me.GraficoSegunConsulta.Series("Mensual2").Legend = Meses(fecha2.Month) & "-" & fecha2.Year
                        Me.GraficoSegunConsulta.Series("Mensual2").Points.AddXY(i, dr2(1))
                    Else


                        Me.GraficoSegunConsulta.Series("Mensual2").Points.AddXY(i, 0)

                    End If
                Next
            Next
        End If

    End Sub

    Private Sub dtpActual_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpActual.ValueChanged
        cboAño2.Visible = False
        Me.GraficoSegunConsulta.Series("Principal").Points.Clear()

        Dim hoy As Date = dtpActual.Value
        Dim dt As DataTable = oCNGraficas.GraficaPedidosMensual(hoy.Month, hoy.Year)

        If dt.Rows.Count = 0 Then
            For i = 1 To 30
                Me.GraficoSegunConsulta.Series("Principal").Points.AddXY(i, 0)
            Next
        Else
            For Each dr In dt.Rows
                Dim fecha As Date = dr(0)

                For i = 1 To 30
                    If (i = fecha.Day) Then
                        Me.GraficoSegunConsulta.Series("Principal").Points.AddXY(i, dr(1))

                    Else
                        Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(i, 0)
                    End If
                Next
            Next
        End If



    End Sub

#End Region

#Region "Grafica Productos x año x cantidad"
    Dim TopProductos(2) As Integer
    Private Sub btnGraficosProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficosProducto.Click
        GraficarProductosMensual()
    End Sub
    Private Sub btnGraficosTopProductos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGraficosTopProductos.Click
        GraficarProductosHistoricos()
    End Sub
    Private Sub btnSearchTop1_Click(sender As Object, e As EventArgs) Handles btnSearchTop1.Click
        TopProductos(0) = SeleccionarItem(txtSeleccion1, btnSearchTop1)
    End Sub

    Private Sub btnSearchTop2_Click(sender As Object, e As EventArgs) Handles btnSearchTop2.Click
        TopProductos(1) = SeleccionarItem(txtSeleccion2, btnSearchTop2)
    End Sub

    Private Sub btnSearchTop3_Click(sender As Object, e As EventArgs) Handles btnSearchTop3.Click
        TopProductos(2) = SeleccionarItem(txtSeleccion3, btnSearchTop3)
    End Sub
    Public Function SeleccionarItem(ByVal nombre As TextBox, ByVal btn As Button) As Integer
        Dim busquedaControl As New AgregarProductoPedido
        busquedaControl.StartPosition = FormStartPosition.CenterScreen
        busquedaControl.Size = New Point(335, 400)
        busquedaControl.PanelBusqueda.Location = New Point(0, 0)

        busquedaControl.ShowDialog()
        nombre.Text = busquedaControl.oCEproducto.Nombre
        If busquedaControl.oCEproducto.IDProducto > -1 Then
            Return busquedaControl.oCEproducto.IDProducto
        Else
            Return -1
        End If
    End Function


    Public Sub GraficarProductosHistoricos()
        ClearSeries()

        Me.GraficoSegunConsulta.Series("2019").Enabled = False
        Me.GraficoSegunConsulta.Series("Cantidad").Enabled = False
        Me.GraficoSegunConsulta.Series("Mensual").Enabled = False

        Me.GraficoSegunConsulta.ChartAreas(0).AxisY.Interval = 20
        Me.GraficoSegunConsulta.ChartAreas(0).AxisY.IntervalOffset = 20

        Dim dt As DataTable = oCNGraficas.GraficarProductosHistoricos()
        Dim dv As DataView = New DataView(dt)

        For x = 0 To dv.Count - 1
            GraficoSegunConsulta.Series("topProductos").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
        Next

    End Sub




#End Region

    'Private Sub dtpCompare_ValueChanged(sender As Object, e As EventArgs) Handles dtpCompare.ValueChanged
    '    Me.GraficoSegunConsulta.Series("Mensual2").Points.Clear()
    '    Dim comparar As Date = dtpCompare.Value
    '    Dim dt2 As DataTable = oCNGraficas.GraficaPedidosMensual(comparar.Month, comparar.Year)
    '    For Each dr2 In dt2.Rows
    '        Dim fecha2 As Date = dr2(0)

    '        For i = 1 To 30
    '            If (i = fecha2.Day) Then

    '                Me.GraficoSegunConsulta.Series("Mensual2").Points.AddXY(i, dr2(1))
    '            Else

    '                Me.GraficoSegunConsulta.Series("Mensual2").Points.AddXY(i, 0)

    '            End If
    '        Next
    '    Next
    'End Sub
    'a revisar si hay cambios comit 8/12/2019 15:32
    'Private Sub dtpActual_ValueChanged(sender As Object, e As EventArgs) Handles dtpActual.ValueChanged
    '    cboAño2.Visible = False
    '    Me.GraficoSegunConsulta.Series("Mensual").Points.Clear()

    '    Dim hoy As Date = dtpActual.Value
    '    Dim dt As DataTable = oCNGraficas.GraficaPedidosMensual(hoy.Month, hoy.Year)
    '    For Each dr In dt.Rows
    '        Dim fecha As Date = dr(0)

    '        For i = 1 To 30
    '            If (i = fecha.Day) Then
    '                Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(i, dr(1))

    '            Else
    '                Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(i, 0)


    '            End If
    '        Next
    '    Next

    'End Sub

    'Private Sub GraficoEfectividad()
    '    Dim dt As New DataTable
    '    ClearSeries()

    '    GraficoSegunConsulta.Series.Add("Efectividad")
    '    'Dim dv As DataView = New DataView(Me.DtReportePedidoTableAdapter1.GetDataBy1(cboAño.Text, cboMeses.SelectedIndex + 1))

    '    For x = 0 To dv.Count - 1
    '        GraficoSegunConsulta.Series("Efectividad").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
    '    Next

    'End Sub

#End Region


    '---------------------------------------- POSTICKS   --------------------------------------------------------

#Region "Pestaña Postick"
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
#End Region
    '----------------------------------------PRESUPUESTO  --------------------------------------------------------
#Region "Pestaña presupuesto"

    Public Sub visibilidadFormularioPresupuesto(ByVal frm As FormularioPedido)

        frm.btnAgregarPedidoNuevo.Visible = True

        frm.lblEstado.Visible = False
        frm.cboEstado.Visible = False
        frm.lblSeña.Visible = False
        frm.txtAnticipoSena.Visible = False
        frm.txtSymbol.Visible = False
        frm.btnGuardarPedido.Visible = False


        frm.dtpFechaVencimiento.Visible = True
        frm.lblFechaVencimiento.Visible = True
        frm.btnGuardarPresupuesto.Visible = True

    End Sub
    Dim oCNPresupuesto As New CNPedido
    Private Sub TabPresupuesto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPresupuesto.Enter
        AutoCancelarPresupuestos()
        CargarGridPresupuestos()
        cboBuscarPresupuesto.SelectedIndex = 0
        cboFiltroEstadoPresupuesto.SelectedIndex = 1
    End Sub
    Public Sub AutoCancelarPresupuestos()
        oCNPresupuesto.AutoCancelarPresupuesto()
    End Sub

    Private Sub btnCancelarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarPresupuesto.Click
        Dim fecha As Date = Date.Now()
        Try
            oCNPresupuesto.CancelarPresupuesto(ID, fecha)
        Catch ex As Exception
        Finally
            CargarGridPresupuestos()
        End Try

    End Sub
    Public Sub CargarGridPresupuestos()
        Dim dv As DataView
        Dim dt As New DataTable
        dt = oCNPresupuesto.MostrarPresupuesto()

        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Cliente") = dt.Rows(i)("Cliente") & " " & dt.Rows(i)("Apellido")
        Next

        cboBuscarPresupuesto.SelectedIndex = 0
        cboFiltroEstadoPresupuesto.SelectedIndex = 1
        txtBuscarPresupuesto.Text = ""

        dt = dt.DefaultView.ToTable(True, "IDPedido", "Cliente", "Fecha", "Fecha Vencimiento", "Estado", "Descripcion", "Responsable")
        dv = New DataView(dt, "Estado = 'Presupuesto' or  Estado = 'Presupuesto Cancelado' ", "IDPedido Asc", DataViewRowState.CurrentRows)
        DGPresupuesto.DataSource = dv
        DGPresupuesto.Columns(0).Visible = False
        'For Each row As DataGridViewRow In DGPresupuesto.Rows
        '    If Not (Convert.IsDBNull(row.Cells(3).Value)) Then
        '        Dim Estado As String = row.Cells("Estado").Value.ToString()
        '        If Estado = "Cancelado" Then
        '            row.DefaultCellStyle.BackColor = Color.Red
        '        End If
        '    End If
        'Next
        MostrarSinResultados(dt, DGPresupuesto)
    End Sub
    Private Sub btnNuevoPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPresupuesto.Click
        Dim frmPresupuesto As New FormularioPedido
        frmPresupuesto.Text = "Nuevo presupuesto"
        visibilidadFormularioPresupuesto(frmPresupuesto)
        frmPresupuesto.lblID.Text = oCNPresupuesto.ConsultarUltimoID()
        frmPresupuesto.Detalles()
        'precargar combobox
        ' frmPresupuesto.btnConfirmarPedido.Visible = True
        'frmPresupuesto.dtpFechaVencimiento.MinDate = Date.Now()
        frmPresupuesto.dtpFechaVencimiento.Value = Date.Now().AddDays(7)
        frmPresupuesto.txtResponsable.Text = lblUsuario.Text
        frmPresupuesto.btnImprimir.Visible = False
        frmPresupuesto.PrecargarCombobox()
        frmPresupuesto.ShowDialog()
        CargarGridPresupuestos()
    End Sub

    Private Sub btnModificarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPresupuesto.Click
        ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPresupuesto As New FormularioPedido
        frmPresupuesto.Text = "Modificar presupuesto"
        visibilidadFormularioPresupuesto(frmPresupuesto)
        frmPresupuesto.btnAgregarPedidoNuevo.Visible = True
        frmPresupuesto.btnGuardarPedido.Visible = False
        frmPresupuesto.CargarGridDetalles(ID)
        frmPresupuesto.LLenarFormulario(ID, False)
        frmPresupuesto.lblID.Text = ID
        frmPresupuesto.btnConfirmarPedido.Visible = True
        frmPresupuesto.ShowDialog()
        CargarGridPresupuestos()
    End Sub

    Private Sub btnVerPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPresupuesto.Click
        ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPresupuesto As New FormularioPedido
        frmPresupuesto.Text = "Detalles de presupuesto"
        visibilidadFormularioPresupuesto(frmPresupuesto)
        frmPresupuesto.btnAgregarPedidoNuevo.Visible = True

        frmPresupuesto.btnAgregarPedidoNuevo.Enabled = False

        frmPresupuesto.btnModificarPedido.Enabled = False
        frmPresupuesto.btnQuitar.Enabled = False
        frmPresupuesto.btnGuardarPedido.Visible = False
        frmPresupuesto.DGListaDePedido.Enabled = False
        frmPresupuesto.btnCancelarPedido.Text = "Aceptar"
        frmPresupuesto.CargarGridDetalles(ID)
        frmPresupuesto.LLenarFormulario(ID, False)
        frmPresupuesto.lblID.Text = ID
        frmPresupuesto.Disesabletext()
        frmPresupuesto.btnEnvioGuardado.Enabled = True

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

        dt = oCNPresupuesto.BuscarPresupuesto(cboBuscarPresupuesto.Text, txtBuscarPresupuesto.Text, cboFiltroEstadoPresupuesto.Text)

        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Nombre") = dt.Rows(i)("Nombre") & " " & dt.Rows(i)("Apellido")
        Next

        DGPresupuesto.DataSource = dt.DefaultView.ToTable(True, "IDPedido", "Nombre", "Fecha", "Fecha Vencimiento", "Descripcion", "Estado", "Responsable")
        DGPresupuesto.Columns("Nombre").HeaderCell.Value = "Cliente"
        DGPresupuesto.Columns(0).Visible = False
        MostrarSinResultados(dt, DGPresupuesto)
    End Sub

    Private Sub DGPresupuesto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPresupuesto.CellClick
        If e.RowIndex >= 0 Then
            ID = DGPresupuesto.Rows(DGPresupuesto.CurrentCell.RowIndex).Cells("IDPedido").Value
        End If

    End Sub

    Private Sub DGPresupuesto_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPresupuesto.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim frmPresupuesto As New FormularioPedido
            frmPresupuesto.Text = "Modificar presupuesto"
            visibilidadFormularioPresupuesto(frmPresupuesto)
            frmPresupuesto.btnAgregarPedidoNuevo.Visible = True

            frmPresupuesto.btnGuardarPedido.Visible = False
            frmPresupuesto.btnConfirmarPedido.Visible = True

            frmPresupuesto.CargarGridDetalles(ID)
            frmPresupuesto.LLenarFormulario(ID, False)
            frmPresupuesto.lblID.Text = ID
            frmPresupuesto.ShowDialog()
            CargarGridPresupuestos()
            If e.RowIndex < DGPresupuesto.Rows.Count Then
                DGPresupuesto.Rows(e.RowIndex).Selected = True
            End If

        End If
    End Sub



    Private Sub btnRefreshPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPresupuesto.Click
        CargarGridPresupuestos()

    End Sub

#End Region

    '-----------------------------------  -   USUARIOS  ---------------------------------------------------------
#Region "Pestaña usuarios"
    Dim oCNUsuario As New CNUsuario
    Dim IDUsuario As Integer
    Dim state As Boolean = True

    Private Sub TabUsuario_Enter(sender As Object, e As System.EventArgs) Handles TabUsuario.Enter
        cboFiltroUsuarios.SelectedIndex = 0
    End Sub
    Public Sub MostrarUsuarios(ByVal state As Boolean)
        ToggleState(state)
        If state Then
            DGUsuario.DataSource = Me.UsuariosTableAdapter.GetUsuarioByEstado("Activo")
        Else
            DGUsuario.DataSource = Me.UsuariosTableAdapter.GetUsuarioByEstado("Inactivo")
        End If

    End Sub
    Public Sub ToggleState(ByVal state As Boolean)

        If state = True Then
            Label9.Text = "usuarios activos"
            btnPapeleraUsuario.Text = "papelera"
            btnEliminarUsuario.Visible = True
            btnRestaurarUsuario.Visible = False
        Else
            Label9.Text = "usuarios inactivos"
            btnPapeleraUsuario.Text = "volver"
            btnEliminarUsuario.Visible = False
            btnRestaurarUsuario.Visible = True

        End If
    End Sub
    Private Sub btnRefreshUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshUsuario.Click
        MostrarUsuarios(True)
    End Sub

    Private Sub btnNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoUsuario.Click
        Dim regUser As New frmIngresaralSistema
        regUser.PanelRegistrar.Visible = True
        regUser.PanelLogin.Visible = False
        regUser.ShowDialog()
        MostrarUsuarios(True)
    End Sub


    Private Sub DGUsuario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGUsuario.CellClick
        If e.RowIndex >= 0 Then
            ID = DGUsuario.Rows(DGUsuario.CurrentCell.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub DGUsuario_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGUsuario.CellDoubleClick
        Dim regUser As New frmIngresaralSistema
        regUser.PanelRegistrar.Visible = True
        regUser.PanelLogin.Visible = False
        regUser.Editando = True
        regUser.EditAdmin = True
        regUser.chkMostrarContraseña.Visible = True
        regUser.CboCargo.Enabled = False
        regUser.TxtNombreyApellido.Enabled = False

        regUser.TxtConfirmarContraseña.Enabled = True
        regUser.txtContraRegistrar.Enabled = True
        regUser.llenarFormulario(ID)
        regUser.ShowDialog()


        MostrarUsuarios(True)
    End Sub
    Private Sub btnModificarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarUsuario.Click

        Dim regUser As New frmIngresaralSistema

        regUser.llenarFormulario(ID)


        regUser.PanelRegistrar.Visible = True
        regUser.PanelLogin.Visible = False
        regUser.Editando = True

        regUser.chkMostrarContraseña.Visible = True
        regUser.CboCargo.Enabled = True
        regUser.TxtNombreyApellido.Enabled = False
        regUser.EditAdmin = True
        regUser.TxtConfirmarContraseña.Enabled = False
        regUser.txtContraRegistrar.Enabled = False
        regUser.chkMostrarContraseña.Enabled = False
        regUser.ShowDialog()


        MostrarUsuarios(True)
    End Sub



    Private Sub btnRestaurarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurarUsuario.Click
        If MessageBox.Show("Esta seguro restaurar usuario? ", "Confirmacion restaurar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNUsuario.EliminarUsuario(ID, "Activo")

            MostrarUsuarios(True)
        End If
    End Sub

    Private Sub btnPapeleraUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPapeleraUsuario.Click
        state = Not state
        MostrarUsuarios(state)
        ToggleState(state)
    End Sub

    Private Sub btnEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarUsuario.Click
        If MessageBox.Show("Esta seguro eliminar usuario? ", "Confirmacion de eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            oCNUsuario.EliminarUsuario(ID, "Inactivo")
            Me.UsuariosTableAdapter.Fill(Me.SolemnoDataSet.Usuarios)
        End If

        MostrarUsuarios(True)
    End Sub

    Private Sub btnVerUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerUsuario.Click
        Dim regUser As New frmIngresaralSistema
        regUser.PanelRegistrar.Visible = True
        regUser.PanelLogin.Visible = False
        regUser.llenarFormulario(ID)
        regUser.Disesabletext()

        regUser.ShowDialog()
        MostrarUsuarios(True)
    End Sub
    'Private Sub btnVerUsuarioInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerUsuarioInactivo.Click

    'End Sub
    Private Sub btnBuscarUsuarioInactivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarUsuarioInactivos.Click

    End Sub
    Private Sub cboFiltroUsuarios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboFiltroUsuarios.SelectedIndexChanged
        If cboFiltroUsuarios.SelectedIndex = 0 Then
            txtBuscarUsuario.Visible = True
            cboFilterCargoUsuario.Visible = False
        Else
            cboFilterCargoUsuario.Visible = True
            txtBuscarUsuario.Visible = False
        End If
    End Sub
    Private Sub btnBuscarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarUsuario.Click
        Dim dt As DataTable
        Dim dv As New DataView
        If state Then
            dt = Me.UsuariosTableAdapter.GetUsuarioByEstado("Activo")
        Else
            dt = Me.UsuariosTableAdapter.GetUsuarioByEstado("Inactivo")
        End If

        If cboFiltroUsuarios.SelectedIndex = 0 Then
            dv = New DataView(dt, "NombreCompleto like '" & txtBuscarUsuario.Text & "%' ", "IDUsuario Asc", DataViewRowState.CurrentRows)
        ElseIf cboFiltroUsuarios.SelectedIndex = 1 Then

            dv = New DataView(dt, "Cargo = '" & cboFilterCargoUsuario.Text & "'", "IDUsuario Asc", DataViewRowState.CurrentRows)
        End If
        DGUsuario.DataSource = dv
        MostrarSinResultados(dt, DGUsuario)
    End Sub


#End Region


    '------------------------------------CONTROLES DE ACCESO-----------------------------------------------------
#Region "Controles de acceso"

    Public Sub enableAdminMode()
        If Not (TabGeneral.TabPages.Contains(TabUsuario)) Then
            TabGeneral.TabPages.Add(TabUsuario)
            TabGeneral.TabPages.Add(TabEstadistica)
            TabGeneral.TabPages.Add(TabProducto)
        End If
    End Sub
    Public Sub disabledAdminMode()
        If (TabGeneral.TabPages.Contains(TabUsuario)) Then

            TabGeneral.TabPages.Remove(TabUsuario)
            TabGeneral.TabPages.Remove(TabEstadistica)
            TabGeneral.TabPages.Remove(TabProducto)
        End If
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        Me.lblNombreUsuario.Text = ""
        frmIngresaralSistema.Show()
    End Sub


#Region "Usar Ultimo mes o ultimo año"

    Private Sub checkUltimaFecha_CheckedChanged(sender As Object, e As EventArgs) Handles checkUltimaFecha.CheckedChanged
        If checkUltimaFecha.Checked Then
            dtpActual.Enabled = False
            dtpCompare.Enabled = False
            cboAño.Enabled = False
            cboAño2.Enabled = False
        Else
            dtpActual.Enabled = True
            dtpCompare.Enabled = True
            cboAño.Enabled = True
            cboAño2.Enabled = True
        End If
    End Sub
    Private Sub UsarUltimoMes()
        Dim hoy As Date = Date.Now()
        Dim UltimaFecha As Date = hoy.AddMonths(-1)
        Dim alter As Date
        Dim count As Integer = 0

        Dim dt As DataTable = oCNGraficas.GraficaPedidosMensual(cboMeses.SelectedIndex + 1, cboAño.SelectedItem)
        If dt.Rows.Count > 0 Then
            For Each dr In dt.Rows
                Dim fecha As Date = dr(0)

                For i = 1 To 30
                    alter = UltimaFecha.AddDays(i)
                    count = alter.Day

                    If (alter.Day = fecha.Day And alter.Month = fecha.Month) Then
                        Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(count, dr(1))
                    Else
                        Me.GraficoSegunConsulta.Series("Mensual").Points.AddXY(count, 0)
                    End If
                Next
            Next
        End If






    End Sub
    Private Sub UsarUltimoAño()

        Dim hoy As Date = Date.Now()
        Dim UltimaFecha As Date = hoy.AddYears(-1)

    End Sub

#End Region


#End Region











#Region "Panel Sin Resultados"
    Dim pSearch As New Panel
    Public Sub MostrarSinResultados(ByVal dt As DataTable, ByVal DG As DataGridView)
        If dt.Rows.Count = 0 Then

            Dim alturaHeader As Integer = 32

            pSearch.Location = New Point(DG.Location.X, DG.Location.Y + alturaHeader)
            pSearch.Name = "Panel" + DG.Name
            pSearch.Size = New Size(DG.Size.Width, DG.Size.Height - alturaHeader)
            pSearch.BackColor = Color.White
            pSearch.BackgroundImage = CType(My.Resources.SinResulatosLupa, Image)
            pSearch.BackgroundImageLayout = ImageLayout.Stretch
            pSearch.Visible = True
            pSearch.BorderStyle = BorderStyle.None
            pSearch.Parent = DG.Parent
            pSearch.BringToFront()
        Else
            pSearch.Visible = False
            Dim ctrl() As Control
            ctrl = DG.Parent.Controls.Find("Panel" + DG.Name, True)
            If Not (ctrl.Length = 0) Then
                DG.Parent.Controls.Remove(ctrl(0))
            End If
        End If
    End Sub
#End Region



    Private Sub EditarUsuario_Click(sender As System.Object, e As System.EventArgs) Handles EditarUsuario.Click
        Dim regUser As New frmIngresaralSistema
        If (lblUsuario.Tag IsNot Nothing) Then
            regUser.llenarFormulario(lblUsuario.Tag)
            regUser.PanelRegistrar.Visible = True
            regUser.PanelLogin.Visible = False
            regUser.Editando = True
            regUser.chkMostrarContraseña.Visible = True
            regUser.CboCargo.Enabled = False
            regUser.TxtNombreyApellido.Enabled = False
            regUser.TxtConfirmarContraseña.Enabled = True
            regUser.txtContraRegistrar.Enabled = True
            regUser.ShowDialog()
        End If

    End Sub

    Private Sub frmMenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub cboFiltroEstadoPresupuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroEstadoPresupuesto.SelectedIndexChanged

    End Sub
End Class