﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabTareas = New System.Windows.Forms.TabPage()
        Me.panelTareas = New System.Windows.Forms.Panel()
        Me.TabCliente = New System.Windows.Forms.TabPage()
        Me.PanelCentralCliente = New System.Windows.Forms.Panel()
        Me.btnBuscarInactivos = New System.Windows.Forms.Button()
        Me.DGClienteInactivos = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.cboBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.DGCliente = New System.Windows.Forms.DataGridView()
        Me.PanelSuperiorCliente = New System.Windows.Forms.Panel()
        Me.lbltituloCliente = New System.Windows.Forms.Label()
        Me.PanelLateralCliente = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnVerInactivo = New System.Windows.Forms.Button()
        Me.btnListadoClientesInactivos = New System.Windows.Forms.Button()
        Me.PictureBoxCliente = New System.Windows.Forms.PictureBox()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.TabPresupuesto = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboFiltroEstadoPresupuesto = New System.Windows.Forms.ComboBox()
        Me.btnRefreshPresupuesto = New System.Windows.Forms.Button()
        Me.txtBuscarPresupuesto = New System.Windows.Forms.TextBox()
        Me.btnBuscarPresupuesto = New System.Windows.Forms.Button()
        Me.DGPresupuesto = New System.Windows.Forms.DataGridView()
        Me.cboBuscarPresupuesto = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelarPresupuesto = New System.Windows.Forms.Button()
        Me.btnEliminarPresupuesto = New System.Windows.Forms.Button()
        Me.btnModificarPresupuesto = New System.Windows.Forms.Button()
        Me.btnVerPresupuesto = New System.Windows.Forms.Button()
        Me.btnNuevoPresupuesto = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPedido = New System.Windows.Forms.TabPage()
        Me.PanelCentralPedido = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFiltroPedido = New System.Windows.Forms.ComboBox()
        Me.btnRefreshPedido = New System.Windows.Forms.Button()
        Me.txtBuscarPedido = New System.Windows.Forms.TextBox()
        Me.btnBuscarPedido = New System.Windows.Forms.Button()
        Me.DGPedido = New System.Windows.Forms.DataGridView()
        Me.cboBuscarPedido = New System.Windows.Forms.ComboBox()
        Me.PanelSuperiorPedido = New System.Windows.Forms.Panel()
        Me.lblTituloPedidos = New System.Windows.Forms.Label()
        Me.PanelLateralPedido = New System.Windows.Forms.Panel()
        Me.btnEliminarPedido = New System.Windows.Forms.Button()
        Me.btnModificarPedido = New System.Windows.Forms.Button()
        Me.btnVerPedido = New System.Windows.Forms.Button()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.IconoPedido = New System.Windows.Forms.PictureBox()
        Me.TabUsuario = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cboFilterCargoUsuario = New System.Windows.Forms.ComboBox()
        Me.btnBuscarUsuarioInactivos = New System.Windows.Forms.Button()
        Me.DGUsuario = New System.Windows.Forms.DataGridView()
        Me.IDUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet()
        Me.btnRefreshUsuario = New System.Windows.Forms.Button()
        Me.txtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.cboFiltroUsuarios = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRestaurarUsuario = New System.Windows.Forms.Button()
        Me.btnVerUsuarioInactivo = New System.Windows.Forms.Button()
        Me.btnPapeleraUsuario = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnVerUsuario = New System.Windows.Forms.Button()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.TabProducto = New System.Windows.Forms.TabPage()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.DGProductoInactivo = New System.Windows.Forms.DataGridView()
        Me.btnBuscarProductoInactivo = New System.Windows.Forms.Button()
        Me.btnRefreshProduct = New System.Windows.Forms.Button()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.DGProducto = New System.Windows.Forms.DataGridView()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.cboBuscarProducto = New System.Windows.Forms.ComboBox()
        Me.panelSuperiorProducto = New System.Windows.Forms.Panel()
        Me.lblTituloProducto = New System.Windows.Forms.Label()
        Me.panelLateralProducto = New System.Windows.Forms.Panel()
        Me.btnDetalleProductoInactivo = New System.Windows.Forms.Button()
        Me.btnRestaurarProducto = New System.Windows.Forms.Button()
        Me.btnPapeleraProducto = New System.Windows.Forms.Button()
        Me.btnVerProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.IconoProducto = New System.Windows.Forms.PictureBox()
        Me.TabEstadistica = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.IngresosPorClientes = New System.Windows.Forms.Button()
        Me.EstadosPorCliente = New System.Windows.Forms.Button()
        Me.pedidosPorPeriodos = New System.Windows.Forms.Button()
        Me.VentasDeProductos = New System.Windows.Forms.Button()
        Me.TendenciaMedios = New System.Windows.Forms.Button()
        Me.IngresosPorPeriodos = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblSubtituloEstadisticas = New System.Windows.Forms.Label()
        Me.btnVerReporteEstadistica = New System.Windows.Forms.Button()
        Me.checkUltimaFecha = New System.Windows.Forms.CheckBox()
        Me.lblTipoGrafico = New System.Windows.Forms.Label()
        Me.btnGraficoPedidos = New System.Windows.Forms.Button()
        Me.cboTipoEstadistica = New System.Windows.Forms.ComboBox()
        Me.btnGraficosTopProductos = New System.Windows.Forms.Button()
        Me.BtnGraficarClientes = New System.Windows.Forms.Button()
        Me.colorSecundario = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.colorPrimario = New System.Windows.Forms.Label()
        Me.txtSeleccion3 = New System.Windows.Forms.TextBox()
        Me.btnGraficosProducto = New System.Windows.Forms.Button()
        Me.GraficoSegunConsulta = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblComparar = New System.Windows.Forms.Label()
        Me.btnSearchTop3 = New System.Windows.Forms.Button()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.txtSeleccion2 = New System.Windows.Forms.TextBox()
        Me.dtpCompare = New System.Windows.Forms.DateTimePicker()
        Me.btnGraficoMedios = New System.Windows.Forms.Button()
        Me.dtpActual = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchTop2 = New System.Windows.Forms.Button()
        Me.txtSeleccion1 = New System.Windows.Forms.TextBox()
        Me.btnSearchTop1 = New System.Windows.Forms.Button()
        Me.lblAño2 = New System.Windows.Forms.Label()
        Me.boxEstadistica = New System.Windows.Forms.PictureBox()
        Me.cboAño2 = New System.Windows.Forms.ComboBox()
        Me.cboMeses = New System.Windows.Forms.ComboBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.PanelSupEstadistica = New System.Windows.Forms.Panel()
        Me.lblTituloEstadistica = New System.Windows.Forms.Label()
        Me.PnlLateralEstadistica = New System.Windows.Forms.Panel()
        Me.PictureBoxEstadistic = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.EditarUsuario = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.UsuariosTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter()
        Me.MediosTableAdapter1 = New CapaPresentacion.SolemnoDataSetTableAdapters.MediosTableAdapter()
        Me.btnReportProvincias = New System.Windows.Forms.Button()
        Me.btnReportLocalidad = New System.Windows.Forms.Button()
        Me.btnReportProvinciasPorPeriodos = New System.Windows.Forms.Button()
        Me.btnReportLocalidadPorPeriodo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboProvinciaReporte = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinciasTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabGeneral.SuspendLayout()
        Me.TabTareas.SuspendLayout()
        Me.TabCliente.SuspendLayout()
        Me.PanelCentralCliente.SuspendLayout()
        CType(Me.DGClienteInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperiorCliente.SuspendLayout()
        Me.PanelLateralCliente.SuspendLayout()
        CType(Me.PictureBoxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPresupuesto.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DGPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPedido.SuspendLayout()
        Me.PanelCentralPedido.SuspendLayout()
        CType(Me.DGPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperiorPedido.SuspendLayout()
        Me.PanelLateralPedido.SuspendLayout()
        CType(Me.IconoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUsuario.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DGUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProducto.SuspendLayout()
        Me.PanelProductos.SuspendLayout()
        CType(Me.DGProductoInactivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperiorProducto.SuspendLayout()
        Me.panelLateralProducto.SuspendLayout()
        CType(Me.IconoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEstadistica.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.GraficoSegunConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSupEstadistica.SuspendLayout()
        Me.PnlLateralEstadistica.SuspendLayout()
        CType(Me.PictureBoxEstadistic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabTareas)
        Me.TabGeneral.Controls.Add(Me.TabCliente)
        Me.TabGeneral.Controls.Add(Me.TabPresupuesto)
        Me.TabGeneral.Controls.Add(Me.TabPedido)
        Me.TabGeneral.Controls.Add(Me.TabUsuario)
        Me.TabGeneral.Controls.Add(Me.TabProducto)
        Me.TabGeneral.Controls.Add(Me.TabEstadistica)
        Me.TabGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabGeneral.Location = New System.Drawing.Point(3, 100)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Drawing.Point(6, 4)
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1180, 584)
        Me.TabGeneral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabGeneral.TabIndex = 0
        '
        'TabTareas
        '
        Me.TabTareas.BackColor = System.Drawing.SystemColors.Control
        Me.TabTareas.Controls.Add(Me.panelTareas)
        Me.TabTareas.Location = New System.Drawing.Point(4, 24)
        Me.TabTareas.Name = "TabTareas"
        Me.TabTareas.Size = New System.Drawing.Size(1172, 556)
        Me.TabTareas.TabIndex = 6
        Me.TabTareas.Text = "Tareas"
        '
        'panelTareas
        '
        Me.panelTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTareas.Location = New System.Drawing.Point(0, 0)
        Me.panelTareas.Name = "panelTareas"
        Me.panelTareas.Size = New System.Drawing.Size(1172, 556)
        Me.panelTareas.TabIndex = 0
        '
        'TabCliente
        '
        Me.TabCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabCliente.Controls.Add(Me.PanelCentralCliente)
        Me.TabCliente.Controls.Add(Me.PanelSuperiorCliente)
        Me.TabCliente.Controls.Add(Me.PanelLateralCliente)
        Me.TabCliente.Location = New System.Drawing.Point(4, 24)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.Size = New System.Drawing.Size(1172, 556)
        Me.TabCliente.TabIndex = 0
        Me.TabCliente.Text = "Clientes"
        '
        'PanelCentralCliente
        '
        Me.PanelCentralCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelCentralCliente.Controls.Add(Me.btnBuscarInactivos)
        Me.PanelCentralCliente.Controls.Add(Me.DGClienteInactivos)
        Me.PanelCentralCliente.Controls.Add(Me.btnRefresh)
        Me.PanelCentralCliente.Controls.Add(Me.txtBuscarCliente)
        Me.PanelCentralCliente.Controls.Add(Me.btnBuscarCliente)
        Me.PanelCentralCliente.Controls.Add(Me.cboBuscarCliente)
        Me.PanelCentralCliente.Controls.Add(Me.DGCliente)
        Me.PanelCentralCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralCliente.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralCliente.Name = "PanelCentralCliente"
        Me.PanelCentralCliente.Size = New System.Drawing.Size(988, 467)
        Me.PanelCentralCliente.TabIndex = 13
        '
        'btnBuscarInactivos
        '
        Me.btnBuscarInactivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarInactivos.Location = New System.Drawing.Point(557, 29)
        Me.btnBuscarInactivos.Name = "btnBuscarInactivos"
        Me.btnBuscarInactivos.Size = New System.Drawing.Size(83, 24)
        Me.btnBuscarInactivos.TabIndex = 11
        Me.btnBuscarInactivos.Text = "Buscar"
        Me.btnBuscarInactivos.UseVisualStyleBackColor = False
        Me.btnBuscarInactivos.Visible = False
        '
        'DGClienteInactivos
        '
        Me.DGClienteInactivos.AllowUserToAddRows = False
        Me.DGClienteInactivos.AllowUserToDeleteRows = False
        Me.DGClienteInactivos.AllowUserToResizeRows = False
        Me.DGClienteInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGClienteInactivos.BackgroundColor = System.Drawing.Color.White
        Me.DGClienteInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClienteInactivos.Location = New System.Drawing.Point(24, 65)
        Me.DGClienteInactivos.MultiSelect = False
        Me.DGClienteInactivos.Name = "DGClienteInactivos"
        Me.DGClienteInactivos.ReadOnly = True
        Me.DGClienteInactivos.RowHeadersVisible = False
        Me.DGClienteInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGClienteInactivos.Size = New System.Drawing.Size(614, 310)
        Me.DGClienteInactivos.TabIndex = 10
        Me.DGClienteInactivos.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefresh.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.home
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(20, 29)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(36, 30)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(70, 32)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(379, 20)
        Me.txtBuscarCliente.TabIndex = 0
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Location = New System.Drawing.Point(557, 29)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(83, 24)
        Me.btnBuscarCliente.TabIndex = 5
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'cboBuscarCliente
        '
        Me.cboBuscarCliente.BackColor = System.Drawing.SystemColors.Window
        Me.cboBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarCliente.FormattingEnabled = True
        Me.cboBuscarCliente.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarCliente.Location = New System.Drawing.Point(455, 32)
        Me.cboBuscarCliente.Name = "cboBuscarCliente"
        Me.cboBuscarCliente.Size = New System.Drawing.Size(96, 21)
        Me.cboBuscarCliente.TabIndex = 6
        '
        'DGCliente
        '
        Me.DGCliente.AllowUserToAddRows = False
        Me.DGCliente.AllowUserToDeleteRows = False
        Me.DGCliente.AllowUserToResizeRows = False
        Me.DGCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCliente.BackgroundColor = System.Drawing.Color.White
        Me.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCliente.Location = New System.Drawing.Point(24, 65)
        Me.DGCliente.MultiSelect = False
        Me.DGCliente.Name = "DGCliente"
        Me.DGCliente.ReadOnly = True
        Me.DGCliente.RowHeadersVisible = False
        Me.DGCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCliente.Size = New System.Drawing.Size(614, 310)
        Me.DGCliente.TabIndex = 7
        '
        'PanelSuperiorCliente
        '
        Me.PanelSuperiorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSuperiorCliente.Controls.Add(Me.lbltituloCliente)
        Me.PanelSuperiorCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorCliente.Location = New System.Drawing.Point(184, 0)
        Me.PanelSuperiorCliente.Name = "PanelSuperiorCliente"
        Me.PanelSuperiorCliente.Size = New System.Drawing.Size(988, 89)
        Me.PanelSuperiorCliente.TabIndex = 12
        '
        'lbltituloCliente
        '
        Me.lbltituloCliente.AutoSize = True
        Me.lbltituloCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltituloCliente.Location = New System.Drawing.Point(241, 14)
        Me.lbltituloCliente.Name = "lbltituloCliente"
        Me.lbltituloCliente.Size = New System.Drawing.Size(205, 55)
        Me.lbltituloCliente.TabIndex = 1
        Me.lbltituloCliente.Text = "Clientes"
        '
        'PanelLateralCliente
        '
        Me.PanelLateralCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PanelLateralCliente.Controls.Add(Me.btnRestaurar)
        Me.PanelLateralCliente.Controls.Add(Me.btnVerInactivo)
        Me.PanelLateralCliente.Controls.Add(Me.btnListadoClientesInactivos)
        Me.PanelLateralCliente.Controls.Add(Me.PictureBoxCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnEliminarCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnVerCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnModificarCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnNuevoCliente)
        Me.PanelLateralCliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralCliente.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateralCliente.Name = "PanelLateralCliente"
        Me.PanelLateralCliente.Size = New System.Drawing.Size(184, 556)
        Me.PanelLateralCliente.TabIndex = 11
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.ForeColor = System.Drawing.Color.White
        Me.btnRestaurar.Location = New System.Drawing.Point(3, 501)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(184, 50)
        Me.btnRestaurar.TabIndex = 13
        Me.btnRestaurar.Text = "Restaurar Cliente"
        Me.btnRestaurar.UseVisualStyleBackColor = False
        Me.btnRestaurar.Visible = False
        '
        'btnVerInactivo
        '
        Me.btnVerInactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerInactivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerInactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerInactivo.ForeColor = System.Drawing.Color.White
        Me.btnVerInactivo.Location = New System.Drawing.Point(0, 503)
        Me.btnVerInactivo.Name = "btnVerInactivo"
        Me.btnVerInactivo.Size = New System.Drawing.Size(184, 50)
        Me.btnVerInactivo.TabIndex = 12
        Me.btnVerInactivo.Text = "Ver Detalles Cliente Inactivo"
        Me.btnVerInactivo.UseVisualStyleBackColor = False
        Me.btnVerInactivo.Visible = False
        '
        'btnListadoClientesInactivos
        '
        Me.btnListadoClientesInactivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnListadoClientesInactivos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnListadoClientesInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoClientesInactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoClientesInactivos.ForeColor = System.Drawing.Color.White
        Me.btnListadoClientesInactivos.Location = New System.Drawing.Point(7, 501)
        Me.btnListadoClientesInactivos.Name = "btnListadoClientesInactivos"
        Me.btnListadoClientesInactivos.Size = New System.Drawing.Size(184, 50)
        Me.btnListadoClientesInactivos.TabIndex = 11
        Me.btnListadoClientesInactivos.Text = "Papelera Clientes"
        Me.btnListadoClientesInactivos.UseVisualStyleBackColor = False
        Me.btnListadoClientesInactivos.Visible = False
        '
        'PictureBoxCliente
        '
        Me.PictureBoxCliente.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.PictureBoxCliente.Location = New System.Drawing.Point(7, 14)
        Me.PictureBoxCliente.Name = "PictureBoxCliente"
        Me.PictureBoxCliente.Size = New System.Drawing.Size(170, 150)
        Me.PictureBoxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCliente.TabIndex = 10
        Me.PictureBoxCliente.TabStop = False
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarCliente.FlatAppearance.BorderSize = 0
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCliente.Location = New System.Drawing.Point(-3, 386)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarCliente.TabIndex = 9
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'btnVerCliente
        '
        Me.btnVerCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerCliente.ForeColor = System.Drawing.Color.White
        Me.btnVerCliente.Location = New System.Drawing.Point(0, 330)
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(184, 50)
        Me.btnVerCliente.TabIndex = 8
        Me.btnVerCliente.Text = "Ver Detalles"
        Me.btnVerCliente.UseVisualStyleBackColor = False
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.ForeColor = System.Drawing.Color.White
        Me.btnModificarCliente.Location = New System.Drawing.Point(0, 274)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(184, 50)
        Me.btnModificarCliente.TabIndex = 7
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.White
        Me.btnNuevoCliente.Location = New System.Drawing.Point(0, 218)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(184, 50)
        Me.btnNuevoCliente.TabIndex = 6
        Me.btnNuevoCliente.Text = "Agregar"
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'TabPresupuesto
        '
        Me.TabPresupuesto.Controls.Add(Me.Panel4)
        Me.TabPresupuesto.Controls.Add(Me.Panel2)
        Me.TabPresupuesto.Controls.Add(Me.Panel3)
        Me.TabPresupuesto.Location = New System.Drawing.Point(4, 24)
        Me.TabPresupuesto.Name = "TabPresupuesto"
        Me.TabPresupuesto.Size = New System.Drawing.Size(1172, 556)
        Me.TabPresupuesto.TabIndex = 7
        Me.TabPresupuesto.Text = "Presupuestos"
        Me.TabPresupuesto.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.cboFiltroEstadoPresupuesto)
        Me.Panel4.Controls.Add(Me.btnRefreshPresupuesto)
        Me.Panel4.Controls.Add(Me.txtBuscarPresupuesto)
        Me.Panel4.Controls.Add(Me.btnBuscarPresupuesto)
        Me.Panel4.Controls.Add(Me.DGPresupuesto)
        Me.Panel4.Controls.Add(Me.cboBuscarPresupuesto)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(184, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(988, 467)
        Me.Panel4.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(438, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Filtrar por:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Filtrar por estado:"
        '
        'cboFiltroEstadoPresupuesto
        '
        Me.cboFiltroEstadoPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltroEstadoPresupuesto.FormattingEnabled = True
        Me.cboFiltroEstadoPresupuesto.Items.AddRange(New Object() {"Todos", "Presupuesto", "Cancelado", "Presupuesto Vencido"})
        Me.cboFiltroEstadoPresupuesto.Location = New System.Drawing.Point(279, 32)
        Me.cboFiltroEstadoPresupuesto.Name = "cboFiltroEstadoPresupuesto"
        Me.cboFiltroEstadoPresupuesto.Size = New System.Drawing.Size(122, 21)
        Me.cboFiltroEstadoPresupuesto.TabIndex = 15
        '
        'btnRefreshPresupuesto
        '
        Me.btnRefreshPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefreshPresupuesto.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.home
        Me.btnRefreshPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshPresupuesto.Location = New System.Drawing.Point(20, 27)
        Me.btnRefreshPresupuesto.Name = "btnRefreshPresupuesto"
        Me.btnRefreshPresupuesto.Size = New System.Drawing.Size(36, 30)
        Me.btnRefreshPresupuesto.TabIndex = 14
        Me.btnRefreshPresupuesto.UseVisualStyleBackColor = False
        '
        'txtBuscarPresupuesto
        '
        Me.txtBuscarPresupuesto.Location = New System.Drawing.Point(62, 33)
        Me.txtBuscarPresupuesto.Name = "txtBuscarPresupuesto"
        Me.txtBuscarPresupuesto.Size = New System.Drawing.Size(210, 20)
        Me.txtBuscarPresupuesto.TabIndex = 12
        '
        'btnBuscarPresupuesto
        '
        Me.btnBuscarPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPresupuesto.Location = New System.Drawing.Point(535, 33)
        Me.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto"
        Me.btnBuscarPresupuesto.Size = New System.Drawing.Size(115, 24)
        Me.btnBuscarPresupuesto.TabIndex = 11
        Me.btnBuscarPresupuesto.Text = "Buscar"
        Me.btnBuscarPresupuesto.UseVisualStyleBackColor = False
        '
        'DGPresupuesto
        '
        Me.DGPresupuesto.AllowUserToAddRows = False
        Me.DGPresupuesto.AllowUserToDeleteRows = False
        Me.DGPresupuesto.AllowUserToResizeRows = False
        Me.DGPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGPresupuesto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPresupuesto.Location = New System.Drawing.Point(20, 81)
        Me.DGPresupuesto.MultiSelect = False
        Me.DGPresupuesto.Name = "DGPresupuesto"
        Me.DGPresupuesto.ReadOnly = True
        Me.DGPresupuesto.RowHeadersVisible = False
        Me.DGPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPresupuesto.Size = New System.Drawing.Size(630, 289)
        Me.DGPresupuesto.TabIndex = 6
        '
        'cboBuscarPresupuesto
        '
        Me.cboBuscarPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarPresupuesto.FormattingEnabled = True
        Me.cboBuscarPresupuesto.Items.AddRange(New Object() {"Nombre y apellido", "Responsable"})
        Me.cboBuscarPresupuesto.Location = New System.Drawing.Point(407, 33)
        Me.cboBuscarPresupuesto.Name = "cboBuscarPresupuesto"
        Me.cboBuscarPresupuesto.Size = New System.Drawing.Size(122, 21)
        Me.cboBuscarPresupuesto.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(184, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 89)
        Me.Panel2.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(241, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(331, 55)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Presupuestos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCancelarPresupuesto)
        Me.Panel3.Controls.Add(Me.btnEliminarPresupuesto)
        Me.Panel3.Controls.Add(Me.btnModificarPresupuesto)
        Me.Panel3.Controls.Add(Me.btnVerPresupuesto)
        Me.Panel3.Controls.Add(Me.btnNuevoPresupuesto)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 556)
        Me.Panel3.TabIndex = 16
        '
        'btnCancelarPresupuesto
        '
        Me.btnCancelarPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnCancelarPresupuesto.Location = New System.Drawing.Point(0, 386)
        Me.btnCancelarPresupuesto.Name = "btnCancelarPresupuesto"
        Me.btnCancelarPresupuesto.Size = New System.Drawing.Size(184, 50)
        Me.btnCancelarPresupuesto.TabIndex = 28
        Me.btnCancelarPresupuesto.Text = "Cancelar"
        Me.btnCancelarPresupuesto.UseVisualStyleBackColor = False
        '
        'btnEliminarPresupuesto
        '
        Me.btnEliminarPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPresupuesto.FlatAppearance.BorderSize = 0
        Me.btnEliminarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPresupuesto.Location = New System.Drawing.Point(0, 503)
        Me.btnEliminarPresupuesto.Name = "btnEliminarPresupuesto"
        Me.btnEliminarPresupuesto.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarPresupuesto.TabIndex = 27
        Me.btnEliminarPresupuesto.Text = "Eliminar"
        Me.btnEliminarPresupuesto.UseVisualStyleBackColor = False
        Me.btnEliminarPresupuesto.Visible = False
        '
        'btnModificarPresupuesto
        '
        Me.btnModificarPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnModificarPresupuesto.Location = New System.Drawing.Point(0, 274)
        Me.btnModificarPresupuesto.Name = "btnModificarPresupuesto"
        Me.btnModificarPresupuesto.Size = New System.Drawing.Size(184, 50)
        Me.btnModificarPresupuesto.TabIndex = 26
        Me.btnModificarPresupuesto.Text = "Modificar"
        Me.btnModificarPresupuesto.UseVisualStyleBackColor = False
        '
        'btnVerPresupuesto
        '
        Me.btnVerPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnVerPresupuesto.Location = New System.Drawing.Point(0, 330)
        Me.btnVerPresupuesto.Name = "btnVerPresupuesto"
        Me.btnVerPresupuesto.Size = New System.Drawing.Size(184, 50)
        Me.btnVerPresupuesto.TabIndex = 25
        Me.btnVerPresupuesto.Text = "Ver Detalles"
        Me.btnVerPresupuesto.UseVisualStyleBackColor = False
        '
        'btnNuevoPresupuesto
        '
        Me.btnNuevoPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnNuevoPresupuesto.Location = New System.Drawing.Point(0, 218)
        Me.btnNuevoPresupuesto.Name = "btnNuevoPresupuesto"
        Me.btnNuevoPresupuesto.Size = New System.Drawing.Size(184, 50)
        Me.btnNuevoPresupuesto.TabIndex = 24
        Me.btnNuevoPresupuesto.Text = "Agregar"
        Me.btnNuevoPresupuesto.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CapaPresentacion.My.Resources.Resources.pedidos
        Me.PictureBox3.Location = New System.Drawing.Point(7, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(170, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'TabPedido
        '
        Me.TabPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPedido.Controls.Add(Me.PanelCentralPedido)
        Me.TabPedido.Controls.Add(Me.PanelSuperiorPedido)
        Me.TabPedido.Controls.Add(Me.PanelLateralPedido)
        Me.TabPedido.Location = New System.Drawing.Point(4, 24)
        Me.TabPedido.Name = "TabPedido"
        Me.TabPedido.Size = New System.Drawing.Size(1172, 556)
        Me.TabPedido.TabIndex = 2
        Me.TabPedido.Text = "Pedidos"
        '
        'PanelCentralPedido
        '
        Me.PanelCentralPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelCentralPedido.Controls.Add(Me.Label8)
        Me.PanelCentralPedido.Controls.Add(Me.Label7)
        Me.PanelCentralPedido.Controls.Add(Me.cboFiltroPedido)
        Me.PanelCentralPedido.Controls.Add(Me.btnRefreshPedido)
        Me.PanelCentralPedido.Controls.Add(Me.txtBuscarPedido)
        Me.PanelCentralPedido.Controls.Add(Me.btnBuscarPedido)
        Me.PanelCentralPedido.Controls.Add(Me.DGPedido)
        Me.PanelCentralPedido.Controls.Add(Me.cboBuscarPedido)
        Me.PanelCentralPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralPedido.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralPedido.Name = "PanelCentralPedido"
        Me.PanelCentralPedido.Size = New System.Drawing.Size(988, 467)
        Me.PanelCentralPedido.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(439, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Filtrar por:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Filtrar por estado:"
        '
        'cboFiltroPedido
        '
        Me.cboFiltroPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltroPedido.FormattingEnabled = True
        Me.cboFiltroPedido.Items.AddRange(New Object() {"Todos", "Pendiente", "Completado", "Cancelado"})
        Me.cboFiltroPedido.Location = New System.Drawing.Point(279, 32)
        Me.cboFiltroPedido.Name = "cboFiltroPedido"
        Me.cboFiltroPedido.Size = New System.Drawing.Size(122, 21)
        Me.cboFiltroPedido.TabIndex = 16
        '
        'btnRefreshPedido
        '
        Me.btnRefreshPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefreshPedido.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.home
        Me.btnRefreshPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshPedido.Location = New System.Drawing.Point(20, 27)
        Me.btnRefreshPedido.Name = "btnRefreshPedido"
        Me.btnRefreshPedido.Size = New System.Drawing.Size(36, 30)
        Me.btnRefreshPedido.TabIndex = 14
        Me.btnRefreshPedido.UseVisualStyleBackColor = False
        '
        'txtBuscarPedido
        '
        Me.txtBuscarPedido.Location = New System.Drawing.Point(67, 33)
        Me.txtBuscarPedido.Name = "txtBuscarPedido"
        Me.txtBuscarPedido.Size = New System.Drawing.Size(206, 20)
        Me.txtBuscarPedido.TabIndex = 12
        '
        'btnBuscarPedido
        '
        Me.btnBuscarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPedido.Location = New System.Drawing.Point(535, 33)
        Me.btnBuscarPedido.Name = "btnBuscarPedido"
        Me.btnBuscarPedido.Size = New System.Drawing.Size(115, 24)
        Me.btnBuscarPedido.TabIndex = 11
        Me.btnBuscarPedido.Text = "Buscar"
        Me.btnBuscarPedido.UseVisualStyleBackColor = False
        '
        'DGPedido
        '
        Me.DGPedido.AllowUserToAddRows = False
        Me.DGPedido.AllowUserToDeleteRows = False
        Me.DGPedido.AllowUserToResizeRows = False
        Me.DGPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGPedido.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPedido.Location = New System.Drawing.Point(20, 74)
        Me.DGPedido.MultiSelect = False
        Me.DGPedido.Name = "DGPedido"
        Me.DGPedido.ReadOnly = True
        Me.DGPedido.RowHeadersVisible = False
        Me.DGPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPedido.Size = New System.Drawing.Size(630, 289)
        Me.DGPedido.TabIndex = 6
        '
        'cboBuscarPedido
        '
        Me.cboBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarPedido.FormattingEnabled = True
        Me.cboBuscarPedido.Items.AddRange(New Object() {"Nombre y apellido", "Responsable"})
        Me.cboBuscarPedido.Location = New System.Drawing.Point(407, 33)
        Me.cboBuscarPedido.Name = "cboBuscarPedido"
        Me.cboBuscarPedido.Size = New System.Drawing.Size(122, 21)
        Me.cboBuscarPedido.TabIndex = 13
        '
        'PanelSuperiorPedido
        '
        Me.PanelSuperiorPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSuperiorPedido.Controls.Add(Me.lblTituloPedidos)
        Me.PanelSuperiorPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorPedido.Location = New System.Drawing.Point(184, 0)
        Me.PanelSuperiorPedido.Name = "PanelSuperiorPedido"
        Me.PanelSuperiorPedido.Size = New System.Drawing.Size(988, 89)
        Me.PanelSuperiorPedido.TabIndex = 15
        '
        'lblTituloPedidos
        '
        Me.lblTituloPedidos.AutoSize = True
        Me.lblTituloPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloPedidos.Location = New System.Drawing.Point(241, 14)
        Me.lblTituloPedidos.Name = "lblTituloPedidos"
        Me.lblTituloPedidos.Size = New System.Drawing.Size(205, 55)
        Me.lblTituloPedidos.TabIndex = 2
        Me.lblTituloPedidos.Text = "Pedidos"
        '
        'PanelLateralPedido
        '
        Me.PanelLateralPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PanelLateralPedido.Controls.Add(Me.btnEliminarPedido)
        Me.PanelLateralPedido.Controls.Add(Me.btnModificarPedido)
        Me.PanelLateralPedido.Controls.Add(Me.btnVerPedido)
        Me.PanelLateralPedido.Controls.Add(Me.btnNuevoPedido)
        Me.PanelLateralPedido.Controls.Add(Me.IconoPedido)
        Me.PanelLateralPedido.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralPedido.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateralPedido.Name = "PanelLateralPedido"
        Me.PanelLateralPedido.Size = New System.Drawing.Size(184, 556)
        Me.PanelLateralPedido.TabIndex = 14
        '
        'btnEliminarPedido
        '
        Me.btnEliminarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPedido.FlatAppearance.BorderSize = 0
        Me.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPedido.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPedido.Location = New System.Drawing.Point(0, 386)
        Me.btnEliminarPedido.Name = "btnEliminarPedido"
        Me.btnEliminarPedido.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarPedido.TabIndex = 27
        Me.btnEliminarPedido.Text = "Eliminar"
        Me.btnEliminarPedido.UseVisualStyleBackColor = False
        '
        'btnModificarPedido
        '
        Me.btnModificarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPedido.ForeColor = System.Drawing.Color.White
        Me.btnModificarPedido.Location = New System.Drawing.Point(0, 274)
        Me.btnModificarPedido.Name = "btnModificarPedido"
        Me.btnModificarPedido.Size = New System.Drawing.Size(184, 50)
        Me.btnModificarPedido.TabIndex = 26
        Me.btnModificarPedido.Text = "Modificar"
        Me.btnModificarPedido.UseVisualStyleBackColor = False
        '
        'btnVerPedido
        '
        Me.btnVerPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPedido.ForeColor = System.Drawing.Color.White
        Me.btnVerPedido.Location = New System.Drawing.Point(3, 330)
        Me.btnVerPedido.Name = "btnVerPedido"
        Me.btnVerPedido.Size = New System.Drawing.Size(184, 50)
        Me.btnVerPedido.TabIndex = 25
        Me.btnVerPedido.Text = "Ver Detalles"
        Me.btnVerPedido.UseVisualStyleBackColor = False
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPedido.ForeColor = System.Drawing.Color.White
        Me.btnNuevoPedido.Location = New System.Drawing.Point(0, 218)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(184, 50)
        Me.btnNuevoPedido.TabIndex = 24
        Me.btnNuevoPedido.Text = "Agregar"
        Me.btnNuevoPedido.UseVisualStyleBackColor = False
        '
        'IconoPedido
        '
        Me.IconoPedido.Image = Global.CapaPresentacion.My.Resources.Resources.pedidos
        Me.IconoPedido.Location = New System.Drawing.Point(7, 14)
        Me.IconoPedido.Name = "IconoPedido"
        Me.IconoPedido.Size = New System.Drawing.Size(170, 150)
        Me.IconoPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoPedido.TabIndex = 23
        Me.IconoPedido.TabStop = False
        '
        'TabUsuario
        '
        Me.TabUsuario.Controls.Add(Me.Panel8)
        Me.TabUsuario.Controls.Add(Me.Panel5)
        Me.TabUsuario.Controls.Add(Me.Panel6)
        Me.TabUsuario.Location = New System.Drawing.Point(4, 24)
        Me.TabUsuario.Name = "TabUsuario"
        Me.TabUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUsuario.Size = New System.Drawing.Size(1172, 556)
        Me.TabUsuario.TabIndex = 8
        Me.TabUsuario.Text = "Usuarios"
        Me.TabUsuario.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel8.Controls.Add(Me.cboFilterCargoUsuario)
        Me.Panel8.Controls.Add(Me.btnBuscarUsuarioInactivos)
        Me.Panel8.Controls.Add(Me.DGUsuario)
        Me.Panel8.Controls.Add(Me.btnRefreshUsuario)
        Me.Panel8.Controls.Add(Me.txtBuscarUsuario)
        Me.Panel8.Controls.Add(Me.btnBuscarUsuario)
        Me.Panel8.Controls.Add(Me.cboFiltroUsuarios)
        Me.Panel8.Controls.Add(Me.DataGridView2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(187, 92)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(982, 461)
        Me.Panel8.TabIndex = 15
        '
        'cboFilterCargoUsuario
        '
        Me.cboFilterCargoUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.cboFilterCargoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterCargoUsuario.FormattingEnabled = True
        Me.cboFilterCargoUsuario.Items.AddRange(New Object() {"Administrador", "Vendedor"})
        Me.cboFilterCargoUsuario.Location = New System.Drawing.Point(309, 31)
        Me.cboFilterCargoUsuario.Name = "cboFilterCargoUsuario"
        Me.cboFilterCargoUsuario.Size = New System.Drawing.Size(129, 21)
        Me.cboFilterCargoUsuario.TabIndex = 12
        Me.cboFilterCargoUsuario.Visible = False
        '
        'btnBuscarUsuarioInactivos
        '
        Me.btnBuscarUsuarioInactivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarUsuarioInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUsuarioInactivos.Location = New System.Drawing.Point(567, 39)
        Me.btnBuscarUsuarioInactivos.Name = "btnBuscarUsuarioInactivos"
        Me.btnBuscarUsuarioInactivos.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscarUsuarioInactivos.TabIndex = 11
        Me.btnBuscarUsuarioInactivos.Text = "Buscar"
        Me.btnBuscarUsuarioInactivos.UseVisualStyleBackColor = False
        Me.btnBuscarUsuarioInactivos.Visible = False
        '
        'DGUsuario
        '
        Me.DGUsuario.AllowUserToAddRows = False
        Me.DGUsuario.AllowUserToDeleteRows = False
        Me.DGUsuario.AllowUserToResizeRows = False
        Me.DGUsuario.AutoGenerateColumns = False
        Me.DGUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGUsuario.BackgroundColor = System.Drawing.Color.White
        Me.DGUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUsuarioDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DGUsuario.DataSource = Me.UsuariosBindingSource
        Me.DGUsuario.Location = New System.Drawing.Point(24, 78)
        Me.DGUsuario.MultiSelect = False
        Me.DGUsuario.Name = "DGUsuario"
        Me.DGUsuario.ReadOnly = True
        Me.DGUsuario.RowHeadersVisible = False
        Me.DGUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUsuario.Size = New System.Drawing.Size(614, 310)
        Me.DGUsuario.TabIndex = 10
        '
        'IDUsuarioDataGridViewTextBoxColumn
        '
        Me.IDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IDUsuario"
        Me.IDUsuarioDataGridViewTextBoxColumn.HeaderText = "IDUsuario"
        Me.IDUsuarioDataGridViewTextBoxColumn.Name = "IDUsuarioDataGridViewTextBoxColumn"
        Me.IDUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.Name = "FechaCreacionDataGridViewTextBoxColumn"
        Me.FechaCreacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        Me.CargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SolemnoDataSet1
        '
        'SolemnoDataSet1
        '
        Me.SolemnoDataSet1.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRefreshUsuario
        '
        Me.btnRefreshUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefreshUsuario.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.home
        Me.btnRefreshUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshUsuario.Location = New System.Drawing.Point(20, 29)
        Me.btnRefreshUsuario.Name = "btnRefreshUsuario"
        Me.btnRefreshUsuario.Size = New System.Drawing.Size(36, 30)
        Me.btnRefreshUsuario.TabIndex = 9
        Me.btnRefreshUsuario.UseVisualStyleBackColor = False
        '
        'txtBuscarUsuario
        '
        Me.txtBuscarUsuario.Location = New System.Drawing.Point(70, 32)
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(355, 20)
        Me.txtBuscarUsuario.TabIndex = 0
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(567, 31)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(83, 21)
        Me.btnBuscarUsuario.TabIndex = 5
        Me.btnBuscarUsuario.Text = "Buscar"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = False
        '
        'cboFiltroUsuarios
        '
        Me.cboFiltroUsuarios.BackColor = System.Drawing.SystemColors.Window
        Me.cboFiltroUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltroUsuarios.FormattingEnabled = True
        Me.cboFiltroUsuarios.Items.AddRange(New Object() {"Nombre Completo", "Cargo"})
        Me.cboFiltroUsuarios.Location = New System.Drawing.Point(444, 32)
        Me.cboFiltroUsuarios.Name = "cboFiltroUsuarios"
        Me.cboFiltroUsuarios.Size = New System.Drawing.Size(117, 21)
        Me.cboFiltroUsuarios.TabIndex = 6
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(24, 78)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(614, 310)
        Me.DataGridView2.TabIndex = 7
        Me.DataGridView2.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(187, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(982, 89)
        Me.Panel5.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 55)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Usuarios"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btnRestaurarUsuario)
        Me.Panel6.Controls.Add(Me.btnVerUsuarioInactivo)
        Me.Panel6.Controls.Add(Me.btnPapeleraUsuario)
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.btnEliminarUsuario)
        Me.Panel6.Controls.Add(Me.btnVerUsuario)
        Me.Panel6.Controls.Add(Me.btnModificarUsuario)
        Me.Panel6.Controls.Add(Me.btnNuevoUsuario)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(184, 550)
        Me.Panel6.TabIndex = 13
        '
        'btnRestaurarUsuario
        '
        Me.btnRestaurarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRestaurarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRestaurarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnRestaurarUsuario.Location = New System.Drawing.Point(0, 497)
        Me.btnRestaurarUsuario.Name = "btnRestaurarUsuario"
        Me.btnRestaurarUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnRestaurarUsuario.TabIndex = 13
        Me.btnRestaurarUsuario.Text = "Restaurar usuario"
        Me.btnRestaurarUsuario.UseVisualStyleBackColor = False
        Me.btnRestaurarUsuario.Visible = False
        '
        'btnVerUsuarioInactivo
        '
        Me.btnVerUsuarioInactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerUsuarioInactivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerUsuarioInactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerUsuarioInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerUsuarioInactivo.ForeColor = System.Drawing.Color.White
        Me.btnVerUsuarioInactivo.Location = New System.Drawing.Point(0, 498)
        Me.btnVerUsuarioInactivo.Name = "btnVerUsuarioInactivo"
        Me.btnVerUsuarioInactivo.Size = New System.Drawing.Size(184, 50)
        Me.btnVerUsuarioInactivo.TabIndex = 12
        Me.btnVerUsuarioInactivo.Text = "Ver Detalles usuario Inactivo"
        Me.btnVerUsuarioInactivo.UseVisualStyleBackColor = False
        Me.btnVerUsuarioInactivo.Visible = False
        '
        'btnPapeleraUsuario
        '
        Me.btnPapeleraUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPapeleraUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPapeleraUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPapeleraUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPapeleraUsuario.ForeColor = System.Drawing.Color.White
        Me.btnPapeleraUsuario.Location = New System.Drawing.Point(0, 497)
        Me.btnPapeleraUsuario.Name = "btnPapeleraUsuario"
        Me.btnPapeleraUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnPapeleraUsuario.TabIndex = 11
        Me.btnPapeleraUsuario.Text = "Papelera usuario"
        Me.btnPapeleraUsuario.UseVisualStyleBackColor = False
        Me.btnPapeleraUsuario.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.PictureBox4.Location = New System.Drawing.Point(7, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(170, 150)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnEliminarUsuario.FlatAppearance.BorderSize = 0
        Me.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(0, 330)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarUsuario.TabIndex = 9
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = False
        '
        'btnVerUsuario
        '
        Me.btnVerUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerUsuario.ForeColor = System.Drawing.Color.White
        Me.btnVerUsuario.Location = New System.Drawing.Point(0, 503)
        Me.btnVerUsuario.Name = "btnVerUsuario"
        Me.btnVerUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnVerUsuario.TabIndex = 8
        Me.btnVerUsuario.Text = "Ver Detalles"
        Me.btnVerUsuario.UseVisualStyleBackColor = False
        Me.btnVerUsuario.Visible = False
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnModificarUsuario.Location = New System.Drawing.Point(0, 274)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnModificarUsuario.TabIndex = 7
        Me.btnModificarUsuario.Text = "Modificar"
        Me.btnModificarUsuario.UseVisualStyleBackColor = False
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.ForeColor = System.Drawing.Color.White
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(0, 218)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnNuevoUsuario.TabIndex = 6
        Me.btnNuevoUsuario.Text = "Agregar"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'TabProducto
        '
        Me.TabProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabProducto.Controls.Add(Me.PanelProductos)
        Me.TabProducto.Controls.Add(Me.panelSuperiorProducto)
        Me.TabProducto.Controls.Add(Me.panelLateralProducto)
        Me.TabProducto.Location = New System.Drawing.Point(4, 24)
        Me.TabProducto.Name = "TabProducto"
        Me.TabProducto.Size = New System.Drawing.Size(1172, 556)
        Me.TabProducto.TabIndex = 1
        Me.TabProducto.Text = "Productos"
        '
        'PanelProductos
        '
        Me.PanelProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelProductos.Controls.Add(Me.DGProductoInactivo)
        Me.PanelProductos.Controls.Add(Me.btnBuscarProductoInactivo)
        Me.PanelProductos.Controls.Add(Me.btnRefreshProduct)
        Me.PanelProductos.Controls.Add(Me.txtBuscarProducto)
        Me.PanelProductos.Controls.Add(Me.DGProducto)
        Me.PanelProductos.Controls.Add(Me.btnBuscarProducto)
        Me.PanelProductos.Controls.Add(Me.cboBuscarProducto)
        Me.PanelProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelProductos.Location = New System.Drawing.Point(184, 89)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(988, 467)
        Me.PanelProductos.TabIndex = 17
        '
        'DGProductoInactivo
        '
        Me.DGProductoInactivo.AllowUserToAddRows = False
        Me.DGProductoInactivo.AllowUserToDeleteRows = False
        Me.DGProductoInactivo.AllowUserToOrderColumns = True
        Me.DGProductoInactivo.AllowUserToResizeRows = False
        Me.DGProductoInactivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGProductoInactivo.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGProductoInactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProductoInactivo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGProductoInactivo.Location = New System.Drawing.Point(20, 74)
        Me.DGProductoInactivo.MultiSelect = False
        Me.DGProductoInactivo.Name = "DGProductoInactivo"
        Me.DGProductoInactivo.RowHeadersVisible = False
        Me.DGProductoInactivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProductoInactivo.Size = New System.Drawing.Size(600, 291)
        Me.DGProductoInactivo.TabIndex = 18
        Me.DGProductoInactivo.Visible = False
        '
        'btnBuscarProductoInactivo
        '
        Me.btnBuscarProductoInactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarProductoInactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProductoInactivo.Location = New System.Drawing.Point(535, 33)
        Me.btnBuscarProductoInactivo.Name = "btnBuscarProductoInactivo"
        Me.btnBuscarProductoInactivo.Size = New System.Drawing.Size(115, 24)
        Me.btnBuscarProductoInactivo.TabIndex = 17
        Me.btnBuscarProductoInactivo.Text = "Buscar"
        Me.btnBuscarProductoInactivo.UseVisualStyleBackColor = False
        Me.btnBuscarProductoInactivo.Visible = False
        '
        'btnRefreshProduct
        '
        Me.btnRefreshProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefreshProduct.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.home
        Me.btnRefreshProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshProduct.Location = New System.Drawing.Point(20, 29)
        Me.btnRefreshProduct.Name = "btnRefreshProduct"
        Me.btnRefreshProduct.Size = New System.Drawing.Size(36, 30)
        Me.btnRefreshProduct.TabIndex = 16
        Me.btnRefreshProduct.UseVisualStyleBackColor = False
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(70, 36)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(339, 20)
        Me.txtBuscarProducto.TabIndex = 14
        '
        'DGProducto
        '
        Me.DGProducto.AllowUserToAddRows = False
        Me.DGProducto.AllowUserToDeleteRows = False
        Me.DGProducto.AllowUserToResizeRows = False
        Me.DGProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGProducto.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGProducto.Location = New System.Drawing.Point(20, 74)
        Me.DGProducto.MultiSelect = False
        Me.DGProducto.Name = "DGProducto"
        Me.DGProducto.RowHeadersVisible = False
        Me.DGProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProducto.Size = New System.Drawing.Size(600, 291)
        Me.DGProducto.TabIndex = 8
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Location = New System.Drawing.Point(535, 33)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(115, 24)
        Me.btnBuscarProducto.TabIndex = 9
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'cboBuscarProducto
        '
        Me.cboBuscarProducto.BackColor = System.Drawing.SystemColors.Window
        Me.cboBuscarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarProducto.FormattingEnabled = True
        Me.cboBuscarProducto.Items.AddRange(New Object() {"Nombre", "Codigo"})
        Me.cboBuscarProducto.Location = New System.Drawing.Point(415, 35)
        Me.cboBuscarProducto.Name = "cboBuscarProducto"
        Me.cboBuscarProducto.Size = New System.Drawing.Size(114, 21)
        Me.cboBuscarProducto.TabIndex = 15
        '
        'panelSuperiorProducto
        '
        Me.panelSuperiorProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.panelSuperiorProducto.Controls.Add(Me.lblTituloProducto)
        Me.panelSuperiorProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperiorProducto.Location = New System.Drawing.Point(184, 0)
        Me.panelSuperiorProducto.Name = "panelSuperiorProducto"
        Me.panelSuperiorProducto.Size = New System.Drawing.Size(988, 89)
        Me.panelSuperiorProducto.TabIndex = 17
        '
        'lblTituloProducto
        '
        Me.lblTituloProducto.AutoSize = True
        Me.lblTituloProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloProducto.Location = New System.Drawing.Point(207, 14)
        Me.lblTituloProducto.Name = "lblTituloProducto"
        Me.lblTituloProducto.Size = New System.Drawing.Size(250, 55)
        Me.lblTituloProducto.TabIndex = 1
        Me.lblTituloProducto.Text = "Productos"
        '
        'panelLateralProducto
        '
        Me.panelLateralProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.panelLateralProducto.Controls.Add(Me.btnDetalleProductoInactivo)
        Me.panelLateralProducto.Controls.Add(Me.btnRestaurarProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnPapeleraProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnVerProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnModificarProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnEliminarProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnAgregarProducto)
        Me.panelLateralProducto.Controls.Add(Me.IconoProducto)
        Me.panelLateralProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateralProducto.Location = New System.Drawing.Point(0, 0)
        Me.panelLateralProducto.Name = "panelLateralProducto"
        Me.panelLateralProducto.Size = New System.Drawing.Size(184, 556)
        Me.panelLateralProducto.TabIndex = 16
        '
        'btnDetalleProductoInactivo
        '
        Me.btnDetalleProductoInactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDetalleProductoInactivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDetalleProductoInactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleProductoInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleProductoInactivo.ForeColor = System.Drawing.Color.White
        Me.btnDetalleProductoInactivo.Location = New System.Drawing.Point(0, 503)
        Me.btnDetalleProductoInactivo.Name = "btnDetalleProductoInactivo"
        Me.btnDetalleProductoInactivo.Size = New System.Drawing.Size(184, 50)
        Me.btnDetalleProductoInactivo.TabIndex = 25
        Me.btnDetalleProductoInactivo.Text = "Detalles Inactivo"
        Me.btnDetalleProductoInactivo.UseVisualStyleBackColor = False
        Me.btnDetalleProductoInactivo.Visible = False
        '
        'btnRestaurarProducto
        '
        Me.btnRestaurarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRestaurarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRestaurarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarProducto.ForeColor = System.Drawing.Color.White
        Me.btnRestaurarProducto.Location = New System.Drawing.Point(-6, 501)
        Me.btnRestaurarProducto.Name = "btnRestaurarProducto"
        Me.btnRestaurarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnRestaurarProducto.TabIndex = 24
        Me.btnRestaurarProducto.Text = "Restaurar Producto"
        Me.btnRestaurarProducto.UseVisualStyleBackColor = False
        Me.btnRestaurarProducto.Visible = False
        '
        'btnPapeleraProducto
        '
        Me.btnPapeleraProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPapeleraProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPapeleraProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPapeleraProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPapeleraProducto.ForeColor = System.Drawing.Color.White
        Me.btnPapeleraProducto.Location = New System.Drawing.Point(0, 501)
        Me.btnPapeleraProducto.Name = "btnPapeleraProducto"
        Me.btnPapeleraProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnPapeleraProducto.TabIndex = 23
        Me.btnPapeleraProducto.Text = "Papelera Producto"
        Me.btnPapeleraProducto.UseVisualStyleBackColor = False
        Me.btnPapeleraProducto.Visible = False
        '
        'btnVerProducto
        '
        Me.btnVerProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerProducto.ForeColor = System.Drawing.Color.White
        Me.btnVerProducto.Location = New System.Drawing.Point(0, 330)
        Me.btnVerProducto.Name = "btnVerProducto"
        Me.btnVerProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnVerProducto.TabIndex = 22
        Me.btnVerProducto.Text = "Ver Detalles"
        Me.btnVerProducto.UseVisualStyleBackColor = False
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.ForeColor = System.Drawing.Color.White
        Me.btnModificarProducto.Location = New System.Drawing.Point(0, 274)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnModificarProducto.TabIndex = 21
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = False
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarProducto.Location = New System.Drawing.Point(-3, 386)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarProducto.TabIndex = 20
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProducto.Location = New System.Drawing.Point(0, 218)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnAgregarProducto.TabIndex = 19
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'IconoProducto
        '
        Me.IconoProducto.Image = Global.CapaPresentacion.My.Resources.Resources.articulos
        Me.IconoProducto.Location = New System.Drawing.Point(7, 14)
        Me.IconoProducto.Name = "IconoProducto"
        Me.IconoProducto.Size = New System.Drawing.Size(170, 150)
        Me.IconoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoProducto.TabIndex = 18
        Me.IconoProducto.TabStop = False
        '
        'TabEstadistica
        '
        Me.TabEstadistica.Controls.Add(Me.Panel7)
        Me.TabEstadistica.Controls.Add(Me.PanelSupEstadistica)
        Me.TabEstadistica.Controls.Add(Me.PnlLateralEstadistica)
        Me.TabEstadistica.Location = New System.Drawing.Point(4, 24)
        Me.TabEstadistica.Name = "TabEstadistica"
        Me.TabEstadistica.Size = New System.Drawing.Size(1172, 556)
        Me.TabEstadistica.TabIndex = 3
        Me.TabEstadistica.Text = "Reportes"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel7.Controls.Add(Me.GroupBox6)
        Me.Panel7.Controls.Add(Me.GroupBox5)
        Me.Panel7.Controls.Add(Me.GroupBox4)
        Me.Panel7.Controls.Add(Me.GroupBox1)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(184, 89)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(988, 467)
        Me.Panel7.TabIndex = 6
        '
        'IngresosPorClientes
        '
        Me.IngresosPorClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.IngresosPorClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngresosPorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresosPorClientes.Location = New System.Drawing.Point(304, 19)
        Me.IngresosPorClientes.Name = "IngresosPorClientes"
        Me.IngresosPorClientes.Size = New System.Drawing.Size(191, 24)
        Me.IngresosPorClientes.TabIndex = 70
        Me.IngresosPorClientes.Text = "Ingresos de las ventas"
        Me.IngresosPorClientes.UseVisualStyleBackColor = False
        '
        'EstadosPorCliente
        '
        Me.EstadosPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.EstadosPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadosPorCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadosPorCliente.Location = New System.Drawing.Point(37, 19)
        Me.EstadosPorCliente.Name = "EstadosPorCliente"
        Me.EstadosPorCliente.Size = New System.Drawing.Size(231, 24)
        Me.EstadosPorCliente.TabIndex = 69
        Me.EstadosPorCliente.Text = "Estados de pedidos"
        Me.EstadosPorCliente.UseVisualStyleBackColor = False
        '
        'pedidosPorPeriodos
        '
        Me.pedidosPorPeriodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pedidosPorPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pedidosPorPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pedidosPorPeriodos.Location = New System.Drawing.Point(516, 21)
        Me.pedidosPorPeriodos.Name = "pedidosPorPeriodos"
        Me.pedidosPorPeriodos.Size = New System.Drawing.Size(172, 25)
        Me.pedidosPorPeriodos.TabIndex = 68
        Me.pedidosPorPeriodos.Text = "Pedidos por periodos"
        Me.pedidosPorPeriodos.UseVisualStyleBackColor = False
        '
        'VentasDeProductos
        '
        Me.VentasDeProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.VentasDeProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VentasDeProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasDeProductos.Location = New System.Drawing.Point(33, 21)
        Me.VentasDeProductos.Name = "VentasDeProductos"
        Me.VentasDeProductos.Size = New System.Drawing.Size(235, 25)
        Me.VentasDeProductos.TabIndex = 67
        Me.VentasDeProductos.Text = "Ventas de productos por periodos"
        Me.VentasDeProductos.UseVisualStyleBackColor = False
        '
        'TendenciaMedios
        '
        Me.TendenciaMedios.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TendenciaMedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TendenciaMedios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TendenciaMedios.Location = New System.Drawing.Point(37, 24)
        Me.TendenciaMedios.Name = "TendenciaMedios"
        Me.TendenciaMedios.Size = New System.Drawing.Size(231, 24)
        Me.TendenciaMedios.TabIndex = 66
        Me.TendenciaMedios.Text = "Medios más utilizados"
        Me.TendenciaMedios.UseVisualStyleBackColor = False
        '
        'IngresosPorPeriodos
        '
        Me.IngresosPorPeriodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.IngresosPorPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngresosPorPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresosPorPeriodos.Location = New System.Drawing.Point(304, 21)
        Me.IngresosPorPeriodos.Name = "IngresosPorPeriodos"
        Me.IngresosPorPeriodos.Size = New System.Drawing.Size(191, 25)
        Me.IngresosPorPeriodos.TabIndex = 65
        Me.IngresosPorPeriodos.Text = "Ingresos por periodos"
        Me.IngresosPorPeriodos.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lblSubtituloEstadisticas)
        Me.Panel9.Controls.Add(Me.btnVerReporteEstadistica)
        Me.Panel9.Controls.Add(Me.checkUltimaFecha)
        Me.Panel9.Controls.Add(Me.lblTipoGrafico)
        Me.Panel9.Controls.Add(Me.btnGraficoPedidos)
        Me.Panel9.Controls.Add(Me.cboTipoEstadistica)
        Me.Panel9.Controls.Add(Me.btnGraficosTopProductos)
        Me.Panel9.Controls.Add(Me.BtnGraficarClientes)
        Me.Panel9.Controls.Add(Me.colorSecundario)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.colorPrimario)
        Me.Panel9.Controls.Add(Me.txtSeleccion3)
        Me.Panel9.Controls.Add(Me.btnGraficosProducto)
        Me.Panel9.Controls.Add(Me.GraficoSegunConsulta)
        Me.Panel9.Controls.Add(Me.lblComparar)
        Me.Panel9.Controls.Add(Me.btnSearchTop3)
        Me.Panel9.Controls.Add(Me.lblActual)
        Me.Panel9.Controls.Add(Me.txtSeleccion2)
        Me.Panel9.Controls.Add(Me.dtpCompare)
        Me.Panel9.Controls.Add(Me.btnGraficoMedios)
        Me.Panel9.Controls.Add(Me.dtpActual)
        Me.Panel9.Controls.Add(Me.btnSearchTop2)
        Me.Panel9.Controls.Add(Me.txtSeleccion1)
        Me.Panel9.Controls.Add(Me.btnSearchTop1)
        Me.Panel9.Controls.Add(Me.lblAño2)
        Me.Panel9.Controls.Add(Me.boxEstadistica)
        Me.Panel9.Controls.Add(Me.cboAño2)
        Me.Panel9.Controls.Add(Me.cboMeses)
        Me.Panel9.Controls.Add(Me.lblAño)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.cboAño)
        Me.Panel9.Location = New System.Drawing.Point(951, 20)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 10)
        Me.Panel9.TabIndex = 64
        Me.Panel9.Visible = False
        '
        'lblSubtituloEstadisticas
        '
        Me.lblSubtituloEstadisticas.AutoSize = True
        Me.lblSubtituloEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtituloEstadisticas.ForeColor = System.Drawing.Color.White
        Me.lblSubtituloEstadisticas.Location = New System.Drawing.Point(396, 142)
        Me.lblSubtituloEstadisticas.Name = "lblSubtituloEstadisticas"
        Me.lblSubtituloEstadisticas.Size = New System.Drawing.Size(107, 25)
        Me.lblSubtituloEstadisticas.TabIndex = 5
        Me.lblSubtituloEstadisticas.Text = "Graficas:"
        '
        'btnVerReporteEstadistica
        '
        Me.btnVerReporteEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerReporteEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerReporteEstadistica.Location = New System.Drawing.Point(277, -5)
        Me.btnVerReporteEstadistica.Name = "btnVerReporteEstadistica"
        Me.btnVerReporteEstadistica.Size = New System.Drawing.Size(112, 23)
        Me.btnVerReporteEstadistica.TabIndex = 61
        Me.btnVerReporteEstadistica.Text = "Generar el reporte"
        Me.btnVerReporteEstadistica.UseVisualStyleBackColor = False
        '
        'checkUltimaFecha
        '
        Me.checkUltimaFecha.AutoSize = True
        Me.checkUltimaFecha.Location = New System.Drawing.Point(926, 14)
        Me.checkUltimaFecha.Name = "checkUltimaFecha"
        Me.checkUltimaFecha.Size = New System.Drawing.Size(109, 17)
        Me.checkUltimaFecha.TabIndex = 65
        Me.checkUltimaFecha.Text = "Utilizar ultimo mes"
        Me.checkUltimaFecha.UseVisualStyleBackColor = True
        Me.checkUltimaFecha.Visible = False
        '
        'lblTipoGrafico
        '
        Me.lblTipoGrafico.AutoSize = True
        Me.lblTipoGrafico.Location = New System.Drawing.Point(-37, 0)
        Me.lblTipoGrafico.Name = "lblTipoGrafico"
        Me.lblTipoGrafico.Size = New System.Drawing.Size(81, 13)
        Me.lblTipoGrafico.TabIndex = 13
        Me.lblTipoGrafico.Text = "Tipo de grafico:"
        '
        'btnGraficoPedidos
        '
        Me.btnGraficoPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoPedidos.ForeColor = System.Drawing.Color.White
        Me.btnGraficoPedidos.Location = New System.Drawing.Point(331, 103)
        Me.btnGraficoPedidos.Name = "btnGraficoPedidos"
        Me.btnGraficoPedidos.Size = New System.Drawing.Size(184, 35)
        Me.btnGraficoPedidos.TabIndex = 1
        Me.btnGraficoPedidos.Text = "Pedidos Mensuales"
        Me.btnGraficoPedidos.UseVisualStyleBackColor = False
        '
        'cboTipoEstadistica
        '
        Me.cboTipoEstadistica.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoEstadistica.FormattingEnabled = True
        Me.cboTipoEstadistica.Items.AddRange(New Object() {"Mensual", "Anual"})
        Me.cboTipoEstadistica.Location = New System.Drawing.Point(-129, 3)
        Me.cboTipoEstadistica.Name = "cboTipoEstadistica"
        Me.cboTipoEstadistica.Size = New System.Drawing.Size(126, 21)
        Me.cboTipoEstadistica.TabIndex = 12
        '
        'btnGraficosTopProductos
        '
        Me.btnGraficosTopProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosTopProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosTopProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficosTopProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficosTopProductos.ForeColor = System.Drawing.Color.White
        Me.btnGraficosTopProductos.Location = New System.Drawing.Point(145, 137)
        Me.btnGraficosTopProductos.Name = "btnGraficosTopProductos"
        Me.btnGraficosTopProductos.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficosTopProductos.TabIndex = 6
        Me.btnGraficosTopProductos.Text = "productos tito"
        Me.btnGraficosTopProductos.UseVisualStyleBackColor = False
        Me.btnGraficosTopProductos.Visible = False
        '
        'BtnGraficarClientes
        '
        Me.BtnGraficarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnGraficarClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnGraficarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGraficarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGraficarClientes.ForeColor = System.Drawing.Color.White
        Me.BtnGraficarClientes.Location = New System.Drawing.Point(253, 28)
        Me.BtnGraficarClientes.Name = "BtnGraficarClientes"
        Me.BtnGraficarClientes.Size = New System.Drawing.Size(184, 50)
        Me.BtnGraficarClientes.TabIndex = 7
        Me.BtnGraficarClientes.Text = "clientes yorsh"
        Me.BtnGraficarClientes.UseVisualStyleBackColor = False
        Me.BtnGraficarClientes.Visible = False
        '
        'colorSecundario
        '
        Me.colorSecundario.AutoSize = True
        Me.colorSecundario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colorSecundario.Location = New System.Drawing.Point(884, 14)
        Me.colorSecundario.Margin = New System.Windows.Forms.Padding(0)
        Me.colorSecundario.MinimumSize = New System.Drawing.Size(16, 16)
        Me.colorSecundario.Name = "colorSecundario"
        Me.colorSecundario.Size = New System.Drawing.Size(16, 16)
        Me.colorSecundario.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-27, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 15)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Seleccion de productos"
        '
        'colorPrimario
        '
        Me.colorPrimario.AutoSize = True
        Me.colorPrimario.BackColor = System.Drawing.Color.Fuchsia
        Me.colorPrimario.Location = New System.Drawing.Point(652, 12)
        Me.colorPrimario.Margin = New System.Windows.Forms.Padding(0)
        Me.colorPrimario.MinimumSize = New System.Drawing.Size(16, 16)
        Me.colorPrimario.Name = "colorPrimario"
        Me.colorPrimario.Size = New System.Drawing.Size(16, 16)
        Me.colorPrimario.TabIndex = 62
        '
        'txtSeleccion3
        '
        Me.txtSeleccion3.Enabled = False
        Me.txtSeleccion3.Location = New System.Drawing.Point(3, 109)
        Me.txtSeleccion3.Name = "txtSeleccion3"
        Me.txtSeleccion3.ReadOnly = True
        Me.txtSeleccion3.Size = New System.Drawing.Size(107, 20)
        Me.txtSeleccion3.TabIndex = 61
        '
        'btnGraficosProducto
        '
        Me.btnGraficosProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficosProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficosProducto.ForeColor = System.Drawing.Color.White
        Me.btnGraficosProducto.Location = New System.Drawing.Point(148, 137)
        Me.btnGraficosProducto.Name = "btnGraficosProducto"
        Me.btnGraficosProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficosProducto.TabIndex = 4
        Me.btnGraficosProducto.Text = "Productos Solicitados"
        Me.btnGraficosProducto.UseVisualStyleBackColor = False
        Me.btnGraficosProducto.Visible = False
        '
        'GraficoSegunConsulta
        '
        Me.GraficoSegunConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.GraficoSegunConsulta.BackSecondaryColor = System.Drawing.Color.White
        ChartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea3.AxisX.Interval = 1.0R
        ChartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea3.AxisX.LabelAutoFitMinFontSize = 5
        ChartArea3.AxisX.MaximumAutoSize = 40.0!
        ChartArea3.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1
        ChartArea3.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea3.AxisX.TitleForeColor = System.Drawing.Color.Tomato
        ChartArea3.AxisY.Interval = 1.0R
        ChartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.GraficoSegunConsulta.ChartAreas.Add(ChartArea3)
        Legend3.DockedToChartArea = "ChartArea1"
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.IsDockedInsideChartArea = False
        Legend3.IsTextAutoFit = False
        Legend3.ItemColumnSpacing = 0
        Legend3.Name = "Legend1"
        Me.GraficoSegunConsulta.Legends.Add(Legend3)
        Me.GraficoSegunConsulta.Location = New System.Drawing.Point(351, 2)
        Me.GraficoSegunConsulta.Name = "GraficoSegunConsulta"
        Me.GraficoSegunConsulta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series13.ChartArea = "ChartArea1"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series13.Legend = "Legend1"
        Series13.Name = "Cantidad"
        Series14.ChartArea = "ChartArea1"
        Series14.Legend = "Legend1"
        Series14.Name = "Mensual"
        Series15.ChartArea = "ChartArea1"
        Series15.Legend = "Legend1"
        Series15.Name = "topProductos"
        Series16.ChartArea = "ChartArea1"
        Series16.Legend = "Legend1"
        Series16.Name = "Mensual2"
        Series17.ChartArea = "ChartArea1"
        Series17.IsValueShownAsLabel = True
        Series17.Legend = "Legend1"
        Series17.Name = "Principal"
        Series18.ChartArea = "ChartArea1"
        Series18.IsValueShownAsLabel = True
        Series18.Legend = "Legend1"
        Series18.Name = "Secundaria"
        Me.GraficoSegunConsulta.Series.Add(Series13)
        Me.GraficoSegunConsulta.Series.Add(Series14)
        Me.GraficoSegunConsulta.Series.Add(Series15)
        Me.GraficoSegunConsulta.Series.Add(Series16)
        Me.GraficoSegunConsulta.Series.Add(Series17)
        Me.GraficoSegunConsulta.Series.Add(Series18)
        Me.GraficoSegunConsulta.Size = New System.Drawing.Size(34, 25)
        Me.GraficoSegunConsulta.TabIndex = 0
        Me.GraficoSegunConsulta.Text = "Chart1"
        '
        'lblComparar
        '
        Me.lblComparar.AutoSize = True
        Me.lblComparar.Location = New System.Drawing.Point(689, 14)
        Me.lblComparar.Name = "lblComparar"
        Me.lblComparar.Size = New System.Drawing.Size(95, 13)
        Me.lblComparar.TabIndex = 17
        Me.lblComparar.Text = "Fecha secundaria:"
        '
        'btnSearchTop3
        '
        Me.btnSearchTop3.BackgroundImage = CType(resources.GetObject("btnSearchTop3.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchTop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchTop3.FlatAppearance.BorderSize = 0
        Me.btnSearchTop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTop3.Location = New System.Drawing.Point(125, 103)
        Me.btnSearchTop3.Name = "btnSearchTop3"
        Me.btnSearchTop3.Size = New System.Drawing.Size(30, 30)
        Me.btnSearchTop3.TabIndex = 60
        Me.btnSearchTop3.UseVisualStyleBackColor = True
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Location = New System.Drawing.Point(472, 14)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(82, 13)
        Me.lblActual.TabIndex = 16
        Me.lblActual.Text = "Fecha principal:"
        '
        'txtSeleccion2
        '
        Me.txtSeleccion2.Enabled = False
        Me.txtSeleccion2.Location = New System.Drawing.Point(3, 70)
        Me.txtSeleccion2.Name = "txtSeleccion2"
        Me.txtSeleccion2.ReadOnly = True
        Me.txtSeleccion2.Size = New System.Drawing.Size(107, 20)
        Me.txtSeleccion2.TabIndex = 59
        '
        'dtpCompare
        '
        Me.dtpCompare.CustomFormat = "MM/yyyy"
        Me.dtpCompare.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCompare.Location = New System.Drawing.Point(790, 12)
        Me.dtpCompare.Name = "dtpCompare"
        Me.dtpCompare.ShowUpDown = True
        Me.dtpCompare.Size = New System.Drawing.Size(91, 20)
        Me.dtpCompare.TabIndex = 15
        '
        'btnGraficoMedios
        '
        Me.btnGraficoMedios.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoMedios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoMedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoMedios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoMedios.ForeColor = System.Drawing.Color.White
        Me.btnGraficoMedios.Location = New System.Drawing.Point(144, 137)
        Me.btnGraficoMedios.Name = "btnGraficoMedios"
        Me.btnGraficoMedios.Size = New System.Drawing.Size(184, 39)
        Me.btnGraficoMedios.TabIndex = 2
        Me.btnGraficoMedios.Text = "Medios"
        Me.btnGraficoMedios.UseVisualStyleBackColor = False
        Me.btnGraficoMedios.Visible = False
        '
        'dtpActual
        '
        Me.dtpActual.CustomFormat = "MM/yyyy"
        Me.dtpActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActual.Location = New System.Drawing.Point(558, 11)
        Me.dtpActual.Name = "dtpActual"
        Me.dtpActual.ShowUpDown = True
        Me.dtpActual.Size = New System.Drawing.Size(91, 20)
        Me.dtpActual.TabIndex = 14
        '
        'btnSearchTop2
        '
        Me.btnSearchTop2.BackgroundImage = CType(resources.GetObject("btnSearchTop2.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchTop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchTop2.FlatAppearance.BorderSize = 0
        Me.btnSearchTop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTop2.Location = New System.Drawing.Point(125, 64)
        Me.btnSearchTop2.Name = "btnSearchTop2"
        Me.btnSearchTop2.Size = New System.Drawing.Size(30, 30)
        Me.btnSearchTop2.TabIndex = 58
        Me.btnSearchTop2.UseVisualStyleBackColor = True
        '
        'txtSeleccion1
        '
        Me.txtSeleccion1.Enabled = False
        Me.txtSeleccion1.Location = New System.Drawing.Point(3, 34)
        Me.txtSeleccion1.Name = "txtSeleccion1"
        Me.txtSeleccion1.ReadOnly = True
        Me.txtSeleccion1.Size = New System.Drawing.Size(107, 20)
        Me.txtSeleccion1.TabIndex = 57
        '
        'btnSearchTop1
        '
        Me.btnSearchTop1.BackgroundImage = CType(resources.GetObject("btnSearchTop1.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchTop1.FlatAppearance.BorderSize = 0
        Me.btnSearchTop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTop1.Location = New System.Drawing.Point(125, 28)
        Me.btnSearchTop1.Name = "btnSearchTop1"
        Me.btnSearchTop1.Size = New System.Drawing.Size(30, 30)
        Me.btnSearchTop1.TabIndex = 56
        Me.btnSearchTop1.UseVisualStyleBackColor = True
        '
        'lblAño2
        '
        Me.lblAño2.AutoSize = True
        Me.lblAño2.Location = New System.Drawing.Point(700, 14)
        Me.lblAño2.Name = "lblAño2"
        Me.lblAño2.Size = New System.Drawing.Size(84, 13)
        Me.lblAño2.TabIndex = 11
        Me.lblAño2.Text = "Año secundario:"
        Me.lblAño2.Visible = False
        '
        'boxEstadistica
        '
        Me.boxEstadistica.Location = New System.Drawing.Point(125, -46)
        Me.boxEstadistica.Name = "boxEstadistica"
        Me.boxEstadistica.Size = New System.Drawing.Size(203, 140)
        Me.boxEstadistica.TabIndex = 19
        Me.boxEstadistica.TabStop = False
        '
        'cboAño2
        '
        Me.cboAño2.BackColor = System.Drawing.SystemColors.Window
        Me.cboAño2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño2.FormattingEnabled = True
        Me.cboAño2.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAño2.Location = New System.Drawing.Point(790, 11)
        Me.cboAño2.Name = "cboAño2"
        Me.cboAño2.Size = New System.Drawing.Size(91, 21)
        Me.cboAño2.TabIndex = 10
        Me.cboAño2.Visible = False
        '
        'cboMeses
        '
        Me.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeses.FormattingEnabled = True
        Me.cboMeses.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMeses.Location = New System.Drawing.Point(370, 33)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.Size = New System.Drawing.Size(121, 21)
        Me.cboMeses.TabIndex = 6
        Me.cboMeses.Visible = False
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(483, 14)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(71, 13)
        Me.lblAño.TabIndex = 9
        Me.lblAño.Text = "Año principal:"
        Me.lblAño.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mes:"
        Me.Label2.Visible = False
        '
        'cboAño
        '
        Me.cboAño.BackColor = System.Drawing.SystemColors.Window
        Me.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAño.Location = New System.Drawing.Point(558, 11)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(91, 21)
        Me.cboAño.TabIndex = 7
        Me.cboAño.Visible = False
        '
        'PanelSupEstadistica
        '
        Me.PanelSupEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSupEstadistica.Controls.Add(Me.lblTituloEstadistica)
        Me.PanelSupEstadistica.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSupEstadistica.Location = New System.Drawing.Point(184, 0)
        Me.PanelSupEstadistica.Name = "PanelSupEstadistica"
        Me.PanelSupEstadistica.Size = New System.Drawing.Size(988, 89)
        Me.PanelSupEstadistica.TabIndex = 5
        '
        'lblTituloEstadistica
        '
        Me.lblTituloEstadistica.AutoSize = True
        Me.lblTituloEstadistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloEstadistica.ForeColor = System.Drawing.Color.Black
        Me.lblTituloEstadistica.Location = New System.Drawing.Point(358, 14)
        Me.lblTituloEstadistica.Name = "lblTituloEstadistica"
        Me.lblTituloEstadistica.Size = New System.Drawing.Size(228, 55)
        Me.lblTituloEstadistica.TabIndex = 0
        Me.lblTituloEstadistica.Text = "Reportes"
        '
        'PnlLateralEstadistica
        '
        Me.PnlLateralEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PnlLateralEstadistica.Controls.Add(Me.PictureBoxEstadistic)
        Me.PnlLateralEstadistica.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLateralEstadistica.Location = New System.Drawing.Point(0, 0)
        Me.PnlLateralEstadistica.Name = "PnlLateralEstadistica"
        Me.PnlLateralEstadistica.Size = New System.Drawing.Size(184, 556)
        Me.PnlLateralEstadistica.TabIndex = 4
        '
        'PictureBoxEstadistic
        '
        Me.PictureBoxEstadistic.Image = Global.CapaPresentacion.My.Resources.Resources.barchart1_78007
        Me.PictureBoxEstadistic.Location = New System.Drawing.Point(7, 14)
        Me.PictureBoxEstadistic.Name = "PictureBoxEstadistic"
        Me.PictureBoxEstadistic.Size = New System.Drawing.Size(170, 150)
        Me.PictureBoxEstadistic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEstadistic.TabIndex = 0
        Me.PictureBoxEstadistic.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.lblNombreUsuario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1180, 91)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63731!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.11883!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27605!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1180, 91)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.slmn
        Me.PictureBox1.Location = New System.Drawing.Point(167, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SOLEMNO GRÁFICA"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnLogout, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EditarUsuario, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1037, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(100, 85)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(53, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(44, 31)
        Me.btnLogout.TabIndex = 49
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'EditarUsuario
        '
        Me.EditarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.EditarUsuario.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.EditUser
        Me.EditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditarUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditarUsuario.FlatAppearance.BorderSize = 0
        Me.EditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarUsuario.Location = New System.Drawing.Point(3, 8)
        Me.EditarUsuario.Name = "EditarUsuario"
        Me.EditarUsuario.Size = New System.Drawing.Size(44, 31)
        Me.EditarUsuario.TabIndex = 50
        Me.EditarUsuario.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblUsuario, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(859, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(172, 85)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(3, 16)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(166, 18)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(954, 5)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreUsuario.Size = New System.Drawing.Size(0, 18)
        Me.lblNombreUsuario.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabGeneral, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16894!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.83106!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1186, 687)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'MediosTableAdapter1
        '
        Me.MediosTableAdapter1.ClearBeforeFill = True
        '
        'btnReportProvincias
        '
        Me.btnReportProvincias.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnReportProvincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportProvincias.Location = New System.Drawing.Point(83, 19)
        Me.btnReportProvincias.Name = "btnReportProvincias"
        Me.btnReportProvincias.Size = New System.Drawing.Size(165, 24)
        Me.btnReportProvincias.TabIndex = 71
        Me.btnReportProvincias.Text = "Ventas historicas"
        Me.btnReportProvincias.UseVisualStyleBackColor = False
        '
        'btnReportLocalidad
        '
        Me.btnReportLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnReportLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportLocalidad.Location = New System.Drawing.Point(284, 15)
        Me.btnReportLocalidad.Name = "btnReportLocalidad"
        Me.btnReportLocalidad.Size = New System.Drawing.Size(194, 24)
        Me.btnReportLocalidad.TabIndex = 72
        Me.btnReportLocalidad.Text = "Ventas historicas"
        Me.btnReportLocalidad.UseVisualStyleBackColor = False
        '
        'btnReportProvinciasPorPeriodos
        '
        Me.btnReportProvinciasPorPeriodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnReportProvinciasPorPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportProvinciasPorPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportProvinciasPorPeriodos.Location = New System.Drawing.Point(284, 17)
        Me.btnReportProvinciasPorPeriodos.Name = "btnReportProvinciasPorPeriodos"
        Me.btnReportProvinciasPorPeriodos.Size = New System.Drawing.Size(191, 26)
        Me.btnReportProvinciasPorPeriodos.TabIndex = 73
        Me.btnReportProvinciasPorPeriodos.Text = "Ventas el último año"
        Me.btnReportProvinciasPorPeriodos.UseVisualStyleBackColor = False
        '
        'btnReportLocalidadPorPeriodo
        '
        Me.btnReportLocalidadPorPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnReportLocalidadPorPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportLocalidadPorPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportLocalidadPorPeriodo.Location = New System.Drawing.Point(496, 14)
        Me.btnReportLocalidadPorPeriodo.Name = "btnReportLocalidadPorPeriodo"
        Me.btnReportLocalidadPorPeriodo.Size = New System.Drawing.Size(178, 24)
        Me.btnReportLocalidadPorPeriodo.TabIndex = 74
        Me.btnReportLocalidadPorPeriodo.Text = "Ventas el último año"
        Me.btnReportLocalidadPorPeriodo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 146)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubicación"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReportProvincias)
        Me.GroupBox2.Controls.Add(Me.btnReportProvinciasPorPeriodos)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 56)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Provincia"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboProvinciaReporte)
        Me.GroupBox3.Controls.Add(Me.btnReportLocalidad)
        Me.GroupBox3.Controls.Add(Me.btnReportLocalidadPorPeriodo)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(683, 48)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Localidad"
        '
        'cboProvinciaReporte
        '
        Me.cboProvinciaReporte.DataSource = Me.ProvinciasBindingSource
        Me.cboProvinciaReporte.DisplayMember = "Nombre"
        Me.cboProvinciaReporte.FormattingEnabled = True
        Me.cboProvinciaReporte.Location = New System.Drawing.Point(17, 18)
        Me.cboProvinciaReporte.Name = "cboProvinciaReporte"
        Me.cboProvinciaReporte.Size = New System.Drawing.Size(231, 21)
        Me.cboProvinciaReporte.TabIndex = 75
        Me.cboProvinciaReporte.ValueMember = "IDProvincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.SolemnoDataSet1
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EstadosPorCliente)
        Me.GroupBox4.Controls.Add(Me.IngresosPorClientes)
        Me.GroupBox4.Location = New System.Drawing.Point(41, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(725, 58)
        Me.GroupBox4.TabIndex = 76
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TendenciaMedios)
        Me.GroupBox5.Location = New System.Drawing.Point(41, 94)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(316, 57)
        Me.GroupBox5.TabIndex = 77
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Medios de contacto"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.VentasDeProductos)
        Me.GroupBox6.Controls.Add(Me.IngresosPorPeriodos)
        Me.GroupBox6.Controls.Add(Me.pedidosPorPeriodos)
        Me.GroupBox6.Location = New System.Drawing.Point(41, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(725, 66)
        Me.GroupBox6.TabIndex = 78
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Periodos"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 687)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1169, 600)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Solemno Gráfica"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabTareas.ResumeLayout(False)
        Me.TabCliente.ResumeLayout(False)
        Me.PanelCentralCliente.ResumeLayout(False)
        Me.PanelCentralCliente.PerformLayout()
        CType(Me.DGClienteInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperiorCliente.ResumeLayout(False)
        Me.PanelSuperiorCliente.PerformLayout()
        Me.PanelLateralCliente.ResumeLayout(False)
        CType(Me.PictureBoxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPresupuesto.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPedido.ResumeLayout(False)
        Me.PanelCentralPedido.ResumeLayout(False)
        Me.PanelCentralPedido.PerformLayout()
        CType(Me.DGPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperiorPedido.ResumeLayout(False)
        Me.PanelSuperiorPedido.PerformLayout()
        Me.PanelLateralPedido.ResumeLayout(False)
        CType(Me.IconoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUsuario.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DGUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProducto.ResumeLayout(False)
        Me.PanelProductos.ResumeLayout(False)
        Me.PanelProductos.PerformLayout()
        CType(Me.DGProductoInactivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperiorProducto.ResumeLayout(False)
        Me.panelSuperiorProducto.PerformLayout()
        Me.panelLateralProducto.ResumeLayout(False)
        CType(Me.IconoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEstadistica.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.GraficoSegunConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSupEstadistica.ResumeLayout(False)
        Me.PanelSupEstadistica.PerformLayout()
        Me.PnlLateralEstadistica.ResumeLayout(False)
        CType(Me.PictureBoxEstadistic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabGeneral As System.Windows.Forms.TabControl
    Friend WithEvents TabCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabProducto As System.Windows.Forms.TabPage
    Friend WithEvents TabPedido As System.Windows.Forms.TabPage
    Friend WithEvents TabEstadistica As System.Windows.Forms.TabPage
    Friend WithEvents cboBuscarProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents DGProducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarPedido As System.Windows.Forms.Button
    Friend WithEvents DGPedido As System.Windows.Forms.DataGridView
    Friend WithEvents TabTareas As System.Windows.Forms.TabPage
    Friend WithEvents cboBuscarPedido As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscarPedido As System.Windows.Forms.TextBox
    Friend WithEvents PanelProductos As System.Windows.Forms.Panel
    Friend WithEvents panelSuperiorProducto As System.Windows.Forms.Panel
    Friend WithEvents panelLateralProducto As System.Windows.Forms.Panel
    Friend WithEvents btnVerProducto As System.Windows.Forms.Button
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnEliminarProducto As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents IconoProducto As System.Windows.Forms.PictureBox
    Friend WithEvents PanelCentralPedido As System.Windows.Forms.Panel
    Friend WithEvents PanelSuperiorPedido As System.Windows.Forms.Panel
    Friend WithEvents PanelLateralPedido As System.Windows.Forms.Panel
    Friend WithEvents btnEliminarPedido As System.Windows.Forms.Button
    Friend WithEvents btnModificarPedido As System.Windows.Forms.Button
    Friend WithEvents btnVerPedido As System.Windows.Forms.Button
    Friend WithEvents btnNuevoPedido As System.Windows.Forms.Button
    Friend WithEvents IconoPedido As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloProducto As System.Windows.Forms.Label
    Friend WithEvents lblTituloPedidos As System.Windows.Forms.Label
    Friend WithEvents PanelCentralCliente As System.Windows.Forms.Panel
    Friend WithEvents txtBuscarCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents cboBuscarCliente As System.Windows.Forms.ComboBox
    Friend WithEvents DGCliente As System.Windows.Forms.DataGridView
    Friend WithEvents PanelSuperiorCliente As System.Windows.Forms.Panel
    Friend WithEvents lbltituloCliente As System.Windows.Forms.Label
    Friend WithEvents PanelLateralCliente As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxCliente As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminarCliente As System.Windows.Forms.Button
    Friend WithEvents btnVerCliente As System.Windows.Forms.Button
    Friend WithEvents btnModificarCliente As System.Windows.Forms.Button
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents PanelSupEstadistica As System.Windows.Forms.Panel
    Friend WithEvents lblTituloEstadistica As System.Windows.Forms.Label
    Friend WithEvents PnlLateralEstadistica As System.Windows.Forms.Panel
    Friend WithEvents lblSubtituloEstadisticas As System.Windows.Forms.Label
    Friend WithEvents btnGraficosProducto As System.Windows.Forms.Button
    Friend WithEvents btnGraficoMedios As System.Windows.Forms.Button
    Friend WithEvents btnGraficoPedidos As System.Windows.Forms.Button
    Friend WithEvents PictureBoxEstadistic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GraficoSegunConsulta As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAño As System.Windows.Forms.ComboBox
    Friend WithEvents cboMeses As System.Windows.Forms.ComboBox
    Friend WithEvents panelTareas As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnRefreshPedido As System.Windows.Forms.Button
    Friend WithEvents btnRefreshProduct As System.Windows.Forms.Button
    Friend WithEvents btnListadoClientesInactivos As System.Windows.Forms.Button
    Friend WithEvents DGClienteInactivos As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarInactivos As System.Windows.Forms.Button
    Friend WithEvents btnVerInactivo As System.Windows.Forms.Button
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents btnDetalleProductoInactivo As System.Windows.Forms.Button
    Friend WithEvents btnRestaurarProducto As System.Windows.Forms.Button
    Friend WithEvents btnPapeleraProducto As System.Windows.Forms.Button
    Friend WithEvents btnBuscarProductoInactivo As System.Windows.Forms.Button
    Friend WithEvents DGProductoInactivo As System.Windows.Forms.DataGridView
    Friend WithEvents TabPresupuesto As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnRefreshPresupuesto As Button
    Friend WithEvents txtBuscarPresupuesto As TextBox
    Friend WithEvents btnBuscarPresupuesto As Button
    Friend WithEvents DGPresupuesto As DataGridView
    Friend WithEvents cboBuscarPresupuesto As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEliminarPresupuesto As Button
    Friend WithEvents btnModificarPresupuesto As Button
    Friend WithEvents btnVerPresupuesto As Button
    Friend WithEvents btnNuevoPresupuesto As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblAño2 As System.Windows.Forms.Label
    Friend WithEvents cboAño2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoGrafico As System.Windows.Forms.Label
    Friend WithEvents cboTipoEstadistica As System.Windows.Forms.ComboBox
    Friend WithEvents TabUsuario As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarUsuarioInactivos As System.Windows.Forms.Button
    Friend WithEvents DGUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefreshUsuario As System.Windows.Forms.Button
    Friend WithEvents txtBuscarUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents cboFiltroUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnRestaurarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnVerUsuarioInactivo As System.Windows.Forms.Button
    Friend WithEvents btnPapeleraUsuario As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnVerUsuario As System.Windows.Forms.Button
    Friend WithEvents btnModificarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnNuevoUsuario As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnGraficosTopProductos As System.Windows.Forms.Button
    Friend WithEvents BtnGraficarClientes As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents UsuariosTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents dtpActual As DateTimePicker
    Friend WithEvents lblComparar As Label
    Friend WithEvents lblActual As Label
    Friend WithEvents dtpCompare As DateTimePicker
    Friend WithEvents btnCancelarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents btnVerReporteEstadistica As Button
    Friend WithEvents boxEstadistica As PictureBox
    Friend WithEvents colorSecundario As Label
    Friend WithEvents colorPrimario As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtSeleccion3 As TextBox
    Friend WithEvents btnSearchTop3 As Button
    Friend WithEvents txtSeleccion2 As TextBox
    Friend WithEvents btnSearchTop2 As Button
    Friend WithEvents txtSeleccion1 As TextBox
    Friend WithEvents btnSearchTop1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents checkUltimaFecha As CheckBox
    Friend WithEvents MediosTableAdapter1 As CapaPresentacion.SolemnoDataSetTableAdapters.MediosTableAdapter
    Friend WithEvents cboFiltroEstadoPresupuesto As System.Windows.Forms.ComboBox
    Friend WithEvents cboFiltroPedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EditarUsuario As System.Windows.Forms.Button
    Friend WithEvents SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboFilterCargoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents IDUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IngresosPorClientes As System.Windows.Forms.Button
    Friend WithEvents EstadosPorCliente As System.Windows.Forms.Button
    Friend WithEvents pedidosPorPeriodos As System.Windows.Forms.Button
    Friend WithEvents VentasDeProductos As System.Windows.Forms.Button
    Friend WithEvents TendenciaMedios As System.Windows.Forms.Button
    Friend WithEvents IngresosPorPeriodos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboProvinciaReporte As ComboBox
    Friend WithEvents btnReportLocalidad As Button
    Friend WithEvents btnReportLocalidadPorPeriodo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReportProvincias As Button
    Friend WithEvents btnReportProvinciasPorPeriodos As Button
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents ProvinciasTableAdapter As SolemnoDataSetTableAdapters.ProvinciasTableAdapter
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
