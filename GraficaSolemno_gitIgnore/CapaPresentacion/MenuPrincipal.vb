﻿Imports CapaNegocio
Imports CapaEntidad

Public Class frmMenuPrincipal
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- CLIENTE  -----------------------------------------------------------

    Dim oCECliente As CECliente
    Dim oCNCliente As New CNCliente
    Dim ID As String

    Public Sub CargarGridCliente()
        'la funcion de listar cliente retornara un datatable que contendra la tabla del cliente, y esta sera mostrada en el datagrid
        DGCliente.DataSource = oCNCliente.MostrarCliente
    End Sub
    Private Sub TabCliente_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabCliente.Enter
        CargarGridCliente()
    End Sub
    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.lblID.Text = oCNCliente.ConsultarUltimoID
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
        oCNCliente.EliminarCliente(ID)
        CargarGridCliente()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim dt As DataTable
        dt = oCNCliente.Buscar(cboBuscarCliente.Text, txtBuscarCliente.Text)
        DGCliente.DataSource = dt
        'para que el combobox no permita escribir, se cambio el dropdownstyle =DropDownList
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
    Private Sub btnEliminarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        ID = DGProducto.Rows(DGProducto.CurrentCell.RowIndex).Cells("IDProducto").Value
        oCNProducto.EliminarProducto(ID)
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
    Private Sub DGProducto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProducto.CellClick
        DGProducto.CurrentRow.Selected = True
        ID = DGProducto.Rows(e.RowIndex).Cells("IDProducto").Value
    End Sub
    Private Sub DGProducto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGProducto.DoubleClick
        Dim frmRegistrar As New RegistrarProducto
        frmRegistrar.LlenarFormulario(ID)
        frmRegistrar.ShowDialog()
        CargarGridProducto()
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- SERVICIOS -----------------------------------------------------------
    Dim oCNServicio As New CNServicios
    Private Sub TabServicios_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabServicios.Enter
        CargarGridServicios()
    End Sub
    Public Sub CargarGridServicios()
        DGServicios.DataSource = oCNServicio.MostrarServicios()
    End Sub
    Private Sub btnNuevoServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoServicio.Click
        Dim frmNuevoServicio As New frmRegistrarServicio
        frmNuevoServicio.lblID.Text = oCNServicio.ConsultarUltimoID
        frmNuevoServicio.btnGuardarCambiosRegServ.Visible = False
        frmNuevoServicio.btnGuardarNuevoRegServ.Visible = True
        frmNuevoServicio.ShowDialog()

        CargarGridServicios()
    End Sub
    Private Sub BtnModificarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarServicio.Click
        ID = DGServicios.Rows(DGServicios.CurrentCell.RowIndex).Cells("IDServicio").Value
        Dim frmNuevoServicio As New frmRegistrarServicio
        frmNuevoServicio.LLenarFormulario(ID)
        frmNuevoServicio.btnGuardarNuevoRegServ.Visible = False
        frmNuevoServicio.ShowDialog()
        CargarGridServicios()
    End Sub
    Private Sub btnVerServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerServicio.Click
        ID = DGServicios.Rows(DGServicios.CurrentCell.RowIndex).Cells("IDServicio").Value
        Dim frmNuevoServicio As New frmRegistrarServicio
        frmNuevoServicio.LLenarFormulario(ID)
        frmNuevoServicio.Disesabletext()
        frmNuevoServicio.btnGuardarNuevoRegServ.Visible = False
        frmNuevoServicio.btnGuardarCambiosRegServ.Visible = False
        frmNuevoServicio.ShowDialog()
    End Sub
    Private Sub btnEliminarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarServicio.Click
        ID = DGServicios.Rows(DGServicios.CurrentCell.RowIndex).Cells("IDServicio").Value
        oCNServicio.EliminarServicio(ID)
        CargarGridServicios()
    End Sub
    Private Sub btnBuscarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarServicio.Click
        Dim dt As DataTable
        dt = oCNServicio.BuscarServicio(txtBuscarServicio.Text, cboBuscarServicio.Text)
        DGServicios.DataSource = dt

    End Sub
    Private Sub DGServicios_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGServicios.CellMouseDoubleClick
        ID = DGServicios.Rows(DGServicios.CurrentCell.RowIndex).Cells("IDServicio").Value
        Dim oNuevoServicio As New frmRegistrarServicio
        oNuevoServicio.LLenarFormulario(ID)
        oNuevoServicio.btnGuardarNuevoRegServ.Visible = False
        oNuevoServicio.ShowDialog()
        CargarGridServicios()
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
        frmPedido.lblID.Text = oCNPedido.ConsultarUltimoID()
        frmPedido.ShowDialog()
        CargarGridProducto()
    End Sub

    Private Sub btnModificarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPedido.Click
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPedido As New FormularioPedido
        frmPedido.LLenarFormulario(ID)
        frmPedido.ShowDialog()
        CargarGridServicios()
    End Sub

    Private Sub btnVerPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPedido.Click
        'ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        'Dim frmPedido As New FormularioPedido
        'frmPedido.LLenarFormulario(ID)
        'frmPedido.Disesabletext()
        'frmPedido.ShowDialog()
    End Sub

    Private Sub btnEliminarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPedido.Click
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        oCNPedido.EliminarPedido(ID)
        CargarGridPedidos()
    End Sub

    Private Sub btnBuscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPedido.Click
        Dim dt As DataTable
        dt = oCNPedido.BuscarPedido(txtBuscarServicio.Text, cboBuscarServicio.Text)
        DGPedido.DataSource = dt
    End Sub

    Private Sub DGPedido_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGPedido.MouseDoubleClick
        ID = DGPedido.Rows(DGPedido.CurrentCell.RowIndex).Cells("IDPedido").Value
        Dim frmPedido As New FormularioPedido
        frmPedido.LLenarFormulario(ID)
        frmPedido.ShowDialog()
        CargarGridServicios()
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
    Public Sub GraficarServiciosMensuales()
        GraficoSegunConsulta.Series("Cantidad").Points.Clear()

        If (cboAño.Text = Nothing) Or (cboMeses.Text = Nothing) Then
            MsgBox("Debe ingresar un valor para los campos mes y año.")
        Else
            Dim dt As DataTable = oCNgraficas.GraficarServiciosMensuales(cboMeses.SelectedIndex + 1, cboAño.Text)
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
    Private Sub btnGraficoServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoServicios.Click
        GraficarServiciosMensuales()
    End Sub
    Private Sub btnGraficosProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficosProducto.Click
        GraficarProductosMensual()
    End Sub



    '--------------------------------------------------------------------------------------------------------------
    '----------------------------------------   POSTICKS         -----------------------------------------------
   
   
End Class