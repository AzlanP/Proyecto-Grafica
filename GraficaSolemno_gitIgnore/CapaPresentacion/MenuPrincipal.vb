﻿Imports CapaNegocio
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
            oCNCliente.EliminarCliente(ID, "Inactivo")
            CargarGridCliente()
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
        MsgBox("Restaurar id" & ID)
        ' agregarle una confirmacion para restaurar
        oCNCliente.EliminarCliente(ID, "Activo")
        CargarGridCliente()
        DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()
        VolverAlInicio()
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

        oCNCliente.EliminarCliente(ID, "Activo")
        CargarGridCliente()
        DGClienteInactivos.DataSource = oCNCliente.MostrarClienteIncativo()
        VolverAlInicio()
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
        DGProducto.DataSource = oCNProducto.MostrarProducto()
    End Sub
    Private Sub TabProducto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabProducto.Enter
        CargarGridProducto()
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
        frmRegistrar.ShowDialog()
        CargarGridProducto()
    End Sub
    Private Sub btnVerProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProducto.Click
        ID = DGProducto.Rows(DGProducto.CurrentCell.RowIndex).Cells("IDProducto").Value
        Dim frmRegistrar As New RegistrarProducto
        frmRegistrar.LlenarFormulario(ID)

        frmRegistrar.Disesabletext()

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
        frmRegistrar.ShowDialog()
        CargarGridProducto()
    End Sub
    '------------------------para la papelera------ 
    Private Sub btnEliminarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        ID = DGProducto.Rows(DGProducto.CurrentCell.RowIndex).Cells("IDProducto").Value
        oCNProducto.EliminarProducto(ID, "Inactivo")
        CargarGridProducto()
    End Sub
    Private Sub btnRestaurarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurarProducto.Click
        Dim ID As Integer = DGProductoInactivo.Rows(DGProductoInactivo.CurrentCell.RowIndex).Cells("IDProducto").Value

        oCNProducto.EliminarProducto(ID, "Activo")
        CargarGridProducto()
        DGProductoInactivo.DataSource = oCNProducto.MostrarProductoInactivo()

        MostrarProductosModoActivo()

    End Sub

    Private Sub btnDetalleProductoInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleProductoInactivo.Click
        ID = DGProductoInactivo.Rows(DGProductoInactivo.CurrentCell.RowIndex).Cells("IDProducto").Value
        Dim frmProducto As New RegistrarProducto
        frmProducto.LlenarFormularioInactivo(ID)
        frmProducto.Disesabletext()
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
        MsgBox("Restaurar id" & ID)
        ' agregarle una confirmacion para restaurar
        oCNProducto.EliminarProducto(ID, "Activo")
        CargarGridProducto()
        DGProductoInactivo.DataSource = oCNProducto.MostrarProductoInactivo()
        MostrarProductosModoActivo()
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
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- PEDIDOS -----------------------------------------------------------
    Dim oCNPedido As New CNPedido
    Private Sub TabPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPedido.Enter
        CargarGridPedidos()
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


    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- ESTADISTICAS -----------------------------------------------------------
    Dim oCNGraficas As New CNGraficos
    Dim Meses As String() = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Public Sub GraficoPedidosMensuales()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()
        Dim i As Integer = 1
        For i = 6 To 12
            Dim cant As Integer = oCNGraficas.GraficaPedidosMensuales(i, 2018)
            Me.GraficoSegunConsulta.Series("Cantidad").Points.AddXY((Meses(i - 1)), (cant))
        Next
    End Sub
    Public Sub GraficarMedios()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()

        If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
            MsgBox("Debe ingresar un valor para los campos mes y año.")
        Else
            Dim dt As DataTable = oCNgraficas.GraficarCantidadPedidosPorMedio(cboMeses.SelectedIndex + 1, cboAño.Text)
            Dim dv As DataView = New DataView(dt)
            For x = 0 To dv.Count - 1

                GraficoSegunConsulta.Series("Cantidad").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
            Next
        End If
    End Sub
    Public Sub GraficarProductosMensual()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()

        If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
            MsgBox("Debe ingresar un valor para los campos mes y año.")
        Else
            Dim dt As DataTable = oCNgraficas.GraficarProductosMensuales(cboMeses.SelectedIndex + 1, cboAño.Text)
            Dim dv As DataView = New DataView(dt)
            For x = 0 To dv.Count - 1
    GraficoSegunConsulta.Series("Cantidad").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
            Next
        End If
    End Sub
    'Public Sub GraficarServiciosMensuales()
    '    GraficoSegunConsulta.Series("Cantidad").Points.Clear()

    '    If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
    '        MsgBox("Debe ingresar un valor para los campos mes y año.")
    '    Else
    '        Dim dt As DataTable = oCNgraficas.GraficarServiciosMensuales(cboMeses.SelectedIndex + 1, cboAño.Text)
    '        Dim dv As DataView = New DataView(dt)
    '        For x = 0 To dv.Count - 1

    '            GraficoSegunConsulta.Series("Cantidad").Points.AddXY(dv(x)("Nombre"), dv(x)("Cantidad"))
    '        Next
    '    End If
    'End Sub
    Private Sub btnGraficoPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoPedidos.Click
        GraficoPedidosMensuales()
    End Sub
    Private Sub btnGraficoMedios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoMedios.Click
        GraficarMedios()
    End Sub
    Private Sub btnGraficoServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoServicios.Click
        'GraficarServiciosMensuales()
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

    
    
   

    

    
 
End Class