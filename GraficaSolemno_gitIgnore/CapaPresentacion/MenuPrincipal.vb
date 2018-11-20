Imports CapaNegocio
Imports CapaEntidad

Public Class frmMenuPrincipal

    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- CLIENTE  -----------------------------------------------------------

    Dim oCECliente As CECliente
    Dim oCNCliente As New CNCliente
    Dim ID As String
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    '-----------------METODOS CLIENTE-----------------------------------

    Public Sub CargarGridCliente()
        'la funcion de listar cliente retornara un datatable que contendra la tabla del cliente, y esta sera mostrada en el datagrid
        DGCliente.DataSource = oCNCliente.MostrarCliente
    End Sub
    ' -------------Eventos cliente-------------------------------------------------------------
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
    '---------------------------------- EVENTOS DE PRODUCTO---------------------------------------------------
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
        frmNuevoServicio.txtIDServicio.Text = oCNServicio.ConsultarUltimoID
        frmNuevoServicio.btnGuardarCambios.Visible = False
        frmNuevoServicio.btnGuardarNuevo.Visible = True
        frmNuevoServicio.ShowDialog()

        CargarGridServicios()
    End Sub

    Private Sub BtnModificarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarServicio.Click
        ID = DGServicios.Rows(DGServicios.CurrentCell.RowIndex).Cells("IDServicio").Value
        Dim frmNuevoServicio As New frmRegistrarServicio
        frmNuevoServicio.LLenarFormulario(ID)
        frmNuevoServicio.btnGuardarNuevo.Visible = False
        frmNuevoServicio.ShowDialog()
        CargarGridServicios()
    End Sub

    Private Sub btnVerServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerServicio.Click
        ID = DGServicios.Rows(DGServicios.CurrentCell.RowIndex).Cells("IDServicio").Value
        Dim frmNuevoServicio As New frmRegistrarServicio
        frmNuevoServicio.LLenarFormulario(ID)
        frmNuevoServicio.Disesabletext()
        frmNuevoServicio.btnGuardarNuevo.Visible = False
        frmNuevoServicio.btnGuardarcambios.Visible = False
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
        oNuevoServicio.btnGuardarNuevo.Visible = False
        oNuevoServicio.ShowDialog()
        CargarGridServicios()
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- PEDIDOS -----------------------------------------------------------
    Private Sub TabPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPedido.Enter

    End Sub
    Private Sub btnNuevoPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPedido.Click

    End Sub

    Private Sub btnModificarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPedido.Click

    End Sub

    Private Sub btnVerPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPedido.Click

    End Sub

    Private Sub btnEliminarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPedido.Click

    End Sub

    Private Sub btnBuscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPedido.Click

    End Sub


    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '---------------------------------------- ESTADISTICAS -----------------------------------------------------------


    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    '----------------------------------------   POSTICKS         -----------------------------------------------
   
   
    
End Class