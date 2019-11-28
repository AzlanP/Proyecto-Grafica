<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.btnRefreshPresupuesto = New System.Windows.Forms.Button()
        Me.txtBuscarPresupuesto = New System.Windows.Forms.TextBox()
        Me.btnBuscarPresupuesto = New System.Windows.Forms.Button()
        Me.DGPresupuesto = New System.Windows.Forms.DataGridView()
        Me.cboBuscarPresupuesto = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEliminarPresupuesto = New System.Windows.Forms.Button()
        Me.btnModificarPresupuesto = New System.Windows.Forms.Button()
        Me.btnVerPresupuesto = New System.Windows.Forms.Button()
        Me.btnNuevoPresupuesto = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPedido = New System.Windows.Forms.TabPage()
        Me.PanelCentralPedido = New System.Windows.Forms.Panel()
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
        Me.btnBuscarUsuarioInactivos = New System.Windows.Forms.Button()
        Me.DGUsuario = New System.Windows.Forms.DataGridView()
        Me.IDUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.btnRefreshUsuario = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTipoEstadistica = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboAño2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.cboMeses = New System.Windows.Forms.ComboBox()
        Me.GraficoSegunConsulta = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelSupEstadistica = New System.Windows.Forms.Panel()
        Me.lblTituloEstadistica = New System.Windows.Forms.Label()
        Me.PnlLateralEstadistica = New System.Windows.Forms.Panel()
        Me.BtnGraficarClientes = New System.Windows.Forms.Button()
        Me.btnGraficosTopProductos = New System.Windows.Forms.Button()
        Me.lblSubtituloEstadisticas = New System.Windows.Forms.Label()
        Me.btnGraficosProducto = New System.Windows.Forms.Button()
        Me.btnGraficoMedios = New System.Windows.Forms.Button()
        Me.btnGraficoPedidos = New System.Windows.Forms.Button()
        Me.PictureBoxEstadistic = New System.Windows.Forms.PictureBox()
        Me.TabAyuda = New System.Windows.Forms.TabPage()
        Me.PanelCentralAyuda = New System.Windows.Forms.Panel()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PanelSuperiorAyuda = New System.Windows.Forms.Panel()
        Me.lblTituloAyuda = New System.Windows.Forms.Label()
        Me.PanelLateralAyuda = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblIndice = New System.Windows.Forms.Label()
        Me.IconoAyuda = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UsuariosTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter()
        Me.Panel9 = New System.Windows.Forms.Panel()
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
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GraficoSegunConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSupEstadistica.SuspendLayout()
        Me.PnlLateralEstadistica.SuspendLayout()
        CType(Me.PictureBoxEstadistic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAyuda.SuspendLayout()
        Me.PanelCentralAyuda.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperiorAyuda.SuspendLayout()
        Me.PanelLateralAyuda.SuspendLayout()
        CType(Me.IconoAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TabGeneral.Controls.Add(Me.TabAyuda)
        Me.TabGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabGeneral.Location = New System.Drawing.Point(3, 100)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Drawing.Point(6, 4)
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1147, 584)
        Me.TabGeneral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabGeneral.TabIndex = 0
        '
        'TabTareas
        '
        Me.TabTareas.BackColor = System.Drawing.SystemColors.Control
        Me.TabTareas.Controls.Add(Me.panelTareas)
        Me.TabTareas.Location = New System.Drawing.Point(4, 24)
        Me.TabTareas.Name = "TabTareas"
        Me.TabTareas.Size = New System.Drawing.Size(1139, 556)
        Me.TabTareas.TabIndex = 6
        Me.TabTareas.Text = "Tareas"
        '
        'panelTareas
        '
        Me.panelTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTareas.Location = New System.Drawing.Point(0, 0)
        Me.panelTareas.Name = "panelTareas"
        Me.panelTareas.Size = New System.Drawing.Size(1139, 556)
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
        Me.TabCliente.Size = New System.Drawing.Size(1139, 556)
        Me.TabCliente.TabIndex = 0
        Me.TabCliente.Text = "Cliente"
        '
        'PanelCentralCliente
        '
        Me.PanelCentralCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelCentralCliente.Controls.Add(Me.Panel9)
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
        Me.PanelCentralCliente.Size = New System.Drawing.Size(955, 467)
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
        Me.cboBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
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
        Me.PanelSuperiorCliente.Size = New System.Drawing.Size(955, 89)
        Me.PanelSuperiorCliente.TabIndex = 12
        '
        'lbltituloCliente
        '
        Me.lbltituloCliente.AutoSize = True
        Me.lbltituloCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltituloCliente.Location = New System.Drawing.Point(241, 14)
        Me.lbltituloCliente.Name = "lbltituloCliente"
        Me.lbltituloCliente.Size = New System.Drawing.Size(180, 55)
        Me.lbltituloCliente.TabIndex = 1
        Me.lbltituloCliente.Text = "Cliente"
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
        Me.btnRestaurar.Location = New System.Drawing.Point(0, 386)
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
        Me.btnVerInactivo.Location = New System.Drawing.Point(0, 330)
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
        Me.btnListadoClientesInactivos.Location = New System.Drawing.Point(0, 442)
        Me.btnListadoClientesInactivos.Name = "btnListadoClientesInactivos"
        Me.btnListadoClientesInactivos.Size = New System.Drawing.Size(184, 50)
        Me.btnListadoClientesInactivos.TabIndex = 11
        Me.btnListadoClientesInactivos.Text = "Papelera Clientes"
        Me.btnListadoClientesInactivos.UseVisualStyleBackColor = False
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
        Me.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCliente.Location = New System.Drawing.Point(0, 386)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarCliente.TabIndex = 9
        Me.btnEliminarCliente.Text = "Eliminar Cliente"
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
        Me.btnVerCliente.Text = "Ver Detalles Cliente"
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
        Me.btnModificarCliente.Text = "Modificar Cliente"
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
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'TabPresupuesto
        '
        Me.TabPresupuesto.Controls.Add(Me.Panel4)
        Me.TabPresupuesto.Controls.Add(Me.Panel2)
        Me.TabPresupuesto.Controls.Add(Me.Panel3)
        Me.TabPresupuesto.Location = New System.Drawing.Point(4, 24)
        Me.TabPresupuesto.Name = "TabPresupuesto"
        Me.TabPresupuesto.Size = New System.Drawing.Size(1139, 556)
        Me.TabPresupuesto.TabIndex = 7
        Me.TabPresupuesto.Text = "Presupuesto"
        Me.TabPresupuesto.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnRefreshPresupuesto)
        Me.Panel4.Controls.Add(Me.txtBuscarPresupuesto)
        Me.Panel4.Controls.Add(Me.btnBuscarPresupuesto)
        Me.Panel4.Controls.Add(Me.DGPresupuesto)
        Me.Panel4.Controls.Add(Me.cboBuscarPresupuesto)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(184, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(955, 467)
        Me.Panel4.TabIndex = 18
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
        Me.txtBuscarPresupuesto.Location = New System.Drawing.Point(67, 36)
        Me.txtBuscarPresupuesto.Name = "txtBuscarPresupuesto"
        Me.txtBuscarPresupuesto.Size = New System.Drawing.Size(342, 20)
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
        Me.DGPresupuesto.Location = New System.Drawing.Point(20, 74)
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
        Me.cboBuscarPresupuesto.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarPresupuesto.Location = New System.Drawing.Point(415, 35)
        Me.cboBuscarPresupuesto.Name = "cboBuscarPresupuesto"
        Me.cboBuscarPresupuesto.Size = New System.Drawing.Size(114, 21)
        Me.cboBuscarPresupuesto.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(184, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(955, 89)
        Me.Panel2.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(241, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 55)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Presupuesto"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
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
        'btnEliminarPresupuesto
        '
        Me.btnEliminarPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPresupuesto.Location = New System.Drawing.Point(0, 386)
        Me.btnEliminarPresupuesto.Name = "btnEliminarPresupuesto"
        Me.btnEliminarPresupuesto.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarPresupuesto.TabIndex = 27
        Me.btnEliminarPresupuesto.Text = "Eliminar presupuesto"
        Me.btnEliminarPresupuesto.UseVisualStyleBackColor = False
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
        Me.btnModificarPresupuesto.Text = "Modificar presupuesto"
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
        Me.btnVerPresupuesto.Text = "Ver Detalles presupuesto"
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
        Me.btnNuevoPresupuesto.Text = "Nuevo presupuesto"
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
        Me.TabPedido.Size = New System.Drawing.Size(1139, 556)
        Me.TabPedido.TabIndex = 2
        Me.TabPedido.Text = "Pedido"
        '
        'PanelCentralPedido
        '
        Me.PanelCentralPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelCentralPedido.Controls.Add(Me.btnRefreshPedido)
        Me.PanelCentralPedido.Controls.Add(Me.txtBuscarPedido)
        Me.PanelCentralPedido.Controls.Add(Me.btnBuscarPedido)
        Me.PanelCentralPedido.Controls.Add(Me.DGPedido)
        Me.PanelCentralPedido.Controls.Add(Me.cboBuscarPedido)
        Me.PanelCentralPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralPedido.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralPedido.Name = "PanelCentralPedido"
        Me.PanelCentralPedido.Size = New System.Drawing.Size(955, 467)
        Me.PanelCentralPedido.TabIndex = 16
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
        Me.txtBuscarPedido.Location = New System.Drawing.Point(67, 36)
        Me.txtBuscarPedido.Name = "txtBuscarPedido"
        Me.txtBuscarPedido.Size = New System.Drawing.Size(342, 20)
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
        Me.cboBuscarPedido.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarPedido.Location = New System.Drawing.Point(415, 35)
        Me.cboBuscarPedido.Name = "cboBuscarPedido"
        Me.cboBuscarPedido.Size = New System.Drawing.Size(114, 21)
        Me.cboBuscarPedido.TabIndex = 13
        '
        'PanelSuperiorPedido
        '
        Me.PanelSuperiorPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSuperiorPedido.Controls.Add(Me.lblTituloPedidos)
        Me.PanelSuperiorPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorPedido.Location = New System.Drawing.Point(184, 0)
        Me.PanelSuperiorPedido.Name = "PanelSuperiorPedido"
        Me.PanelSuperiorPedido.Size = New System.Drawing.Size(955, 89)
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
        Me.btnEliminarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPedido.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPedido.Location = New System.Drawing.Point(0, 386)
        Me.btnEliminarPedido.Name = "btnEliminarPedido"
        Me.btnEliminarPedido.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarPedido.TabIndex = 27
        Me.btnEliminarPedido.Text = "Eliminar Pedido"
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
        Me.btnModificarPedido.Text = "Modificar Pedido"
        Me.btnModificarPedido.UseVisualStyleBackColor = False
        '
        'btnVerPedido
        '
        Me.btnVerPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPedido.ForeColor = System.Drawing.Color.White
        Me.btnVerPedido.Location = New System.Drawing.Point(0, 330)
        Me.btnVerPedido.Name = "btnVerPedido"
        Me.btnVerPedido.Size = New System.Drawing.Size(184, 50)
        Me.btnVerPedido.TabIndex = 25
        Me.btnVerPedido.Text = "Ver Detalles Pedido"
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
        Me.btnNuevoPedido.Text = "Nuevo Pedido"
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
        Me.TabUsuario.Size = New System.Drawing.Size(1139, 556)
        Me.TabUsuario.TabIndex = 8
        Me.TabUsuario.Text = "Usuario"
        Me.TabUsuario.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel8.Controls.Add(Me.btnBuscarUsuarioInactivos)
        Me.Panel8.Controls.Add(Me.DGUsuario)
        Me.Panel8.Controls.Add(Me.btnRefreshUsuario)
        Me.Panel8.Controls.Add(Me.TextBox1)
        Me.Panel8.Controls.Add(Me.btnBuscarUsuario)
        Me.Panel8.Controls.Add(Me.ComboBox1)
        Me.Panel8.Controls.Add(Me.DataGridView2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(187, 92)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(949, 461)
        Me.Panel8.TabIndex = 15
        '
        'btnBuscarUsuarioInactivos
        '
        Me.btnBuscarUsuarioInactivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarUsuarioInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUsuarioInactivos.Location = New System.Drawing.Point(567, 28)
        Me.btnBuscarUsuarioInactivos.Name = "btnBuscarUsuarioInactivos"
        Me.btnBuscarUsuarioInactivos.Size = New System.Drawing.Size(83, 24)
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
        Me.DGUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUsuarioDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn})
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
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SolemnoDataSet
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(389, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(567, 28)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(83, 24)
        Me.btnBuscarUsuario.TabIndex = 5
        Me.btnBuscarUsuario.Text = "Buscar"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nombre", "Apellido", "Cargo"})
        Me.ComboBox1.Location = New System.Drawing.Point(465, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox1.TabIndex = 6
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
        Me.Panel5.Size = New System.Drawing.Size(949, 89)
        Me.Panel5.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 55)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Usuario"
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
        Me.btnRestaurarUsuario.Location = New System.Drawing.Point(0, 386)
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
        Me.btnVerUsuarioInactivo.Location = New System.Drawing.Point(3, 330)
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
        Me.btnPapeleraUsuario.Location = New System.Drawing.Point(-3, 442)
        Me.btnPapeleraUsuario.Name = "btnPapeleraUsuario"
        Me.btnPapeleraUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnPapeleraUsuario.TabIndex = 11
        Me.btnPapeleraUsuario.Text = "Papelera usuario"
        Me.btnPapeleraUsuario.UseVisualStyleBackColor = False
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
        Me.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(0, 386)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarUsuario.TabIndex = 9
        Me.btnEliminarUsuario.Text = "Eliminar usuario"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = False
        '
        'btnVerUsuario
        '
        Me.btnVerUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerUsuario.ForeColor = System.Drawing.Color.White
        Me.btnVerUsuario.Location = New System.Drawing.Point(0, 330)
        Me.btnVerUsuario.Name = "btnVerUsuario"
        Me.btnVerUsuario.Size = New System.Drawing.Size(184, 50)
        Me.btnVerUsuario.TabIndex = 8
        Me.btnVerUsuario.Text = "Ver Detalles usuario"
        Me.btnVerUsuario.UseVisualStyleBackColor = False
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
        Me.btnModificarUsuario.Text = "Modificar usuario"
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
        Me.btnNuevoUsuario.Text = "Nuevo usuario"
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
        Me.TabProducto.Size = New System.Drawing.Size(1139, 556)
        Me.TabProducto.TabIndex = 1
        Me.TabProducto.Text = "Producto"
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
        Me.PanelProductos.Size = New System.Drawing.Size(955, 467)
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
        Me.cboBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
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
        Me.panelSuperiorProducto.Size = New System.Drawing.Size(955, 89)
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
        Me.btnDetalleProductoInactivo.Location = New System.Drawing.Point(0, 282)
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
        Me.btnRestaurarProducto.Location = New System.Drawing.Point(0, 338)
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
        Me.btnPapeleraProducto.Location = New System.Drawing.Point(0, 394)
        Me.btnPapeleraProducto.Name = "btnPapeleraProducto"
        Me.btnPapeleraProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnPapeleraProducto.TabIndex = 23
        Me.btnPapeleraProducto.Text = "Papelera Producto"
        Me.btnPapeleraProducto.UseVisualStyleBackColor = False
        '
        'btnVerProducto
        '
        Me.btnVerProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerProducto.ForeColor = System.Drawing.Color.White
        Me.btnVerProducto.Location = New System.Drawing.Point(0, 282)
        Me.btnVerProducto.Name = "btnVerProducto"
        Me.btnVerProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnVerProducto.TabIndex = 22
        Me.btnVerProducto.Text = "Detalles  de Producto"
        Me.btnVerProducto.UseVisualStyleBackColor = False
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.ForeColor = System.Drawing.Color.White
        Me.btnModificarProducto.Location = New System.Drawing.Point(0, 226)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnModificarProducto.TabIndex = 21
        Me.btnModificarProducto.Text = "Modificar Producto"
        Me.btnModificarProducto.UseVisualStyleBackColor = False
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarProducto.Location = New System.Drawing.Point(0, 338)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarProducto.TabIndex = 20
        Me.btnEliminarProducto.Text = "Eliminar Producto"
        Me.btnEliminarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProducto.Location = New System.Drawing.Point(0, 170)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnAgregarProducto.TabIndex = 19
        Me.btnAgregarProducto.Text = "Nuevo Producto"
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
        Me.TabEstadistica.Size = New System.Drawing.Size(1139, 556)
        Me.TabEstadistica.TabIndex = 3
        Me.TabEstadistica.Text = "Estadistica"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.cboTipoEstadistica)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.cboAño2)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.cboAño)
        Me.Panel7.Controls.Add(Me.cboMeses)
        Me.Panel7.Controls.Add(Me.GraficoSegunConsulta)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(184, 89)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(955, 467)
        Me.Panel7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tipo de grafico"
        '
        'cboTipoEstadistica
        '
        Me.cboTipoEstadistica.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoEstadistica.FormattingEnabled = True
        Me.cboTipoEstadistica.Items.AddRange(New Object() {"Mensual", "Anual"})
        Me.cboTipoEstadistica.Location = New System.Drawing.Point(18, 342)
        Me.cboTipoEstadistica.Name = "cboTipoEstadistica"
        Me.cboTipoEstadistica.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoEstadistica.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Año:"
        '
        'cboAño2
        '
        Me.cboAño2.BackColor = System.Drawing.SystemColors.Window
        Me.cboAño2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño2.FormattingEnabled = True
        Me.cboAño2.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAño2.Location = New System.Drawing.Point(198, 398)
        Me.cboAño2.Name = "cboAño2"
        Me.cboAño2.Size = New System.Drawing.Size(121, 21)
        Me.cboAño2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mes:"
        '
        'cboAño
        '
        Me.cboAño.BackColor = System.Drawing.SystemColors.Window
        Me.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAño.Location = New System.Drawing.Point(201, 344)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(121, 21)
        Me.cboAño.TabIndex = 7
        '
        'cboMeses
        '
        Me.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeses.FormattingEnabled = True
        Me.cboMeses.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMeses.Location = New System.Drawing.Point(346, 344)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.Size = New System.Drawing.Size(121, 21)
        Me.cboMeses.TabIndex = 6
        '
        'GraficoSegunConsulta
        '
        Me.GraficoSegunConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.GraficoSegunConsulta.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.LabelAutoFitMinFontSize = 5
        ChartArea1.AxisX.MaximumAutoSize = 40.0!
        ChartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1
        ChartArea1.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.Tomato
        ChartArea1.AxisY.Interval = 1.0R
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.GraficoSegunConsulta.ChartAreas.Add(ChartArea1)
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.ForeColor = System.Drawing.Color.Maroon
        Legend1.ItemColumnSpacing = 0
        Legend1.Name = "Legend1"
        Me.GraficoSegunConsulta.Legends.Add(Legend1)
        Me.GraficoSegunConsulta.Location = New System.Drawing.Point(18, 21)
        Me.GraficoSegunConsulta.Name = "GraficoSegunConsulta"
        Me.GraficoSegunConsulta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Cantidad"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "2019"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Mensual"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "topProductos"
        Me.GraficoSegunConsulta.Series.Add(Series1)
        Me.GraficoSegunConsulta.Series.Add(Series2)
        Me.GraficoSegunConsulta.Series.Add(Series3)
        Me.GraficoSegunConsulta.Series.Add(Series4)
        Me.GraficoSegunConsulta.Size = New System.Drawing.Size(805, 300)
        Me.GraficoSegunConsulta.TabIndex = 0
        Me.GraficoSegunConsulta.Text = "Chart1"
        '
        'PanelSupEstadistica
        '
        Me.PanelSupEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSupEstadistica.Controls.Add(Me.lblTituloEstadistica)
        Me.PanelSupEstadistica.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSupEstadistica.Location = New System.Drawing.Point(184, 0)
        Me.PanelSupEstadistica.Name = "PanelSupEstadistica"
        Me.PanelSupEstadistica.Size = New System.Drawing.Size(955, 89)
        Me.PanelSupEstadistica.TabIndex = 5
        '
        'lblTituloEstadistica
        '
        Me.lblTituloEstadistica.AutoSize = True
        Me.lblTituloEstadistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloEstadistica.ForeColor = System.Drawing.Color.Black
        Me.lblTituloEstadistica.Location = New System.Drawing.Point(136, 14)
        Me.lblTituloEstadistica.Name = "lblTituloEstadistica"
        Me.lblTituloEstadistica.Size = New System.Drawing.Size(461, 55)
        Me.lblTituloEstadistica.TabIndex = 0
        Me.lblTituloEstadistica.Text = "Pedidos mensuales"
        '
        'PnlLateralEstadistica
        '
        Me.PnlLateralEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PnlLateralEstadistica.Controls.Add(Me.BtnGraficarClientes)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficosTopProductos)
        Me.PnlLateralEstadistica.Controls.Add(Me.lblSubtituloEstadisticas)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficosProducto)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficoMedios)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficoPedidos)
        Me.PnlLateralEstadistica.Controls.Add(Me.PictureBoxEstadistic)
        Me.PnlLateralEstadistica.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLateralEstadistica.Location = New System.Drawing.Point(0, 0)
        Me.PnlLateralEstadistica.Name = "PnlLateralEstadistica"
        Me.PnlLateralEstadistica.Size = New System.Drawing.Size(184, 556)
        Me.PnlLateralEstadistica.TabIndex = 4
        '
        'BtnGraficarClientes
        '
        Me.BtnGraficarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnGraficarClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnGraficarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGraficarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGraficarClientes.ForeColor = System.Drawing.Color.White
        Me.BtnGraficarClientes.Location = New System.Drawing.Point(0, 471)
        Me.BtnGraficarClientes.Name = "BtnGraficarClientes"
        Me.BtnGraficarClientes.Size = New System.Drawing.Size(184, 50)
        Me.BtnGraficarClientes.TabIndex = 7
        Me.BtnGraficarClientes.Text = "clientes yorsh"
        Me.BtnGraficarClientes.UseVisualStyleBackColor = False
        '
        'btnGraficosTopProductos
        '
        Me.btnGraficosTopProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosTopProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosTopProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficosTopProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficosTopProductos.ForeColor = System.Drawing.Color.White
        Me.btnGraficosTopProductos.Location = New System.Drawing.Point(0, 404)
        Me.btnGraficosTopProductos.Name = "btnGraficosTopProductos"
        Me.btnGraficosTopProductos.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficosTopProductos.TabIndex = 6
        Me.btnGraficosTopProductos.Text = "productos tito"
        Me.btnGraficosTopProductos.UseVisualStyleBackColor = False
        '
        'lblSubtituloEstadisticas
        '
        Me.lblSubtituloEstadisticas.AutoSize = True
        Me.lblSubtituloEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtituloEstadisticas.ForeColor = System.Drawing.Color.White
        Me.lblSubtituloEstadisticas.Location = New System.Drawing.Point(44, 184)
        Me.lblSubtituloEstadisticas.Name = "lblSubtituloEstadisticas"
        Me.lblSubtituloEstadisticas.Size = New System.Drawing.Size(107, 25)
        Me.lblSubtituloEstadisticas.TabIndex = 5
        Me.lblSubtituloEstadisticas.Text = "Graficas:"
        '
        'btnGraficosProducto
        '
        Me.btnGraficosProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficosProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficosProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficosProducto.ForeColor = System.Drawing.Color.White
        Me.btnGraficosProducto.Location = New System.Drawing.Point(0, 341)
        Me.btnGraficosProducto.Name = "btnGraficosProducto"
        Me.btnGraficosProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficosProducto.TabIndex = 4
        Me.btnGraficosProducto.Text = "Productos Solicitados"
        Me.btnGraficosProducto.UseVisualStyleBackColor = False
        '
        'btnGraficoMedios
        '
        Me.btnGraficoMedios.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoMedios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoMedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoMedios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoMedios.ForeColor = System.Drawing.Color.White
        Me.btnGraficoMedios.Location = New System.Drawing.Point(0, 274)
        Me.btnGraficoMedios.Name = "btnGraficoMedios"
        Me.btnGraficoMedios.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficoMedios.TabIndex = 2
        Me.btnGraficoMedios.Text = "Medios"
        Me.btnGraficoMedios.UseVisualStyleBackColor = False
        '
        'btnGraficoPedidos
        '
        Me.btnGraficoPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoPedidos.ForeColor = System.Drawing.Color.White
        Me.btnGraficoPedidos.Location = New System.Drawing.Point(0, 218)
        Me.btnGraficoPedidos.Name = "btnGraficoPedidos"
        Me.btnGraficoPedidos.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficoPedidos.TabIndex = 1
        Me.btnGraficoPedidos.Text = "Pedidos Mensuales"
        Me.btnGraficoPedidos.UseVisualStyleBackColor = False
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
        'TabAyuda
        '
        Me.TabAyuda.Controls.Add(Me.PanelCentralAyuda)
        Me.TabAyuda.Controls.Add(Me.PanelSuperiorAyuda)
        Me.TabAyuda.Controls.Add(Me.PanelLateralAyuda)
        Me.TabAyuda.Location = New System.Drawing.Point(4, 24)
        Me.TabAyuda.Name = "TabAyuda"
        Me.TabAyuda.Size = New System.Drawing.Size(1139, 556)
        Me.TabAyuda.TabIndex = 4
        Me.TabAyuda.Text = "Ayuda"
        '
        'PanelCentralAyuda
        '
        Me.PanelCentralAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelCentralAyuda.Controls.Add(Me.ListBox3)
        Me.PanelCentralAyuda.Controls.Add(Me.PictureBox2)
        Me.PanelCentralAyuda.Controls.Add(Me.Label4)
        Me.PanelCentralAyuda.Controls.Add(Me.Label3)
        Me.PanelCentralAyuda.Controls.Add(Me.ListBox2)
        Me.PanelCentralAyuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralAyuda.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralAyuda.Name = "PanelCentralAyuda"
        Me.PanelCentralAyuda.Size = New System.Drawing.Size(955, 467)
        Me.PanelCentralAyuda.TabIndex = 19
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Items.AddRange(New Object() {"3)Agrege un titulo deceado a su postick para un posterior reconomiento del mismo." & _
                        "", "4)Describa detalladamente el motivo del postick.", "5)Agrege la Fecha del postick en el cual quiere que sea mostrado.", "6)seleccione ""Guardar""."})
        Me.ListBox3.Location = New System.Drawing.Point(352, 145)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(589, 300)
        Me.ListBox3.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CapaPresentacion.My.Resources.Resources.Screenshot_2
        Me.PictureBox2.Location = New System.Drawing.Point(37, 145)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(288, 311)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Agregar Postick al Tablero :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tareas"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Items.AddRange(New Object() {"1) Dirijase a la Pestaña de tareas", "2)Haga Click en el boton inferior ""Agregar Tarea"""})
        Me.ListBox2.Location = New System.Drawing.Point(37, 87)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(494, 40)
        Me.ListBox2.TabIndex = 16
        '
        'PanelSuperiorAyuda
        '
        Me.PanelSuperiorAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSuperiorAyuda.Controls.Add(Me.lblTituloAyuda)
        Me.PanelSuperiorAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorAyuda.Location = New System.Drawing.Point(184, 0)
        Me.PanelSuperiorAyuda.Name = "PanelSuperiorAyuda"
        Me.PanelSuperiorAyuda.Size = New System.Drawing.Size(955, 89)
        Me.PanelSuperiorAyuda.TabIndex = 18
        '
        'lblTituloAyuda
        '
        Me.lblTituloAyuda.AutoSize = True
        Me.lblTituloAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloAyuda.Location = New System.Drawing.Point(137, 14)
        Me.lblTituloAyuda.Name = "lblTituloAyuda"
        Me.lblTituloAyuda.Size = New System.Drawing.Size(476, 55)
        Me.lblTituloAyuda.TabIndex = 0
        Me.lblTituloAyuda.Text = "Ayuda del programa"
        '
        'PanelLateralAyuda
        '
        Me.PanelLateralAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PanelLateralAyuda.Controls.Add(Me.ListBox1)
        Me.PanelLateralAyuda.Controls.Add(Me.lblIndice)
        Me.PanelLateralAyuda.Controls.Add(Me.IconoAyuda)
        Me.PanelLateralAyuda.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralAyuda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateralAyuda.Name = "PanelLateralAyuda"
        Me.PanelLateralAyuda.Size = New System.Drawing.Size(184, 556)
        Me.PanelLateralAyuda.TabIndex = 17
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Tareas", "     Agregar Postick", "     Eliminar Postick", "     Modificar Postick", "Clientes", "    Agregar Cliente", "    Modificar Cliente", "    Ver Detalles del Cliente", "    Eliminar Cliente", "    Buscar Cliente", "Productos y servicios", "    Agregar Prod. o Serv.", "    Modificar Prod. o Serv.", "    Ver Detalles ", "    Eliminar Prod. o Serv.", "    Buscar Prod. o Serv.", "Pedidos", "     Agregar Pedido", "     Modificar Pedido", "     Eliminar Pedido", "     Buscar Pedido", "     Ver Detalles", "     Agregar Producto al pedido"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 221)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(184, 345)
        Me.ListBox1.TabIndex = 15
        '
        'lblIndice
        '
        Me.lblIndice.AutoSize = True
        Me.lblIndice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndice.Location = New System.Drawing.Point(57, 176)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(93, 31)
        Me.lblIndice.TabIndex = 14
        Me.lblIndice.Text = "Indice"
        '
        'IconoAyuda
        '
        Me.IconoAyuda.Image = Global.CapaPresentacion.My.Resources.Resources.ayuda
        Me.IconoAyuda.Location = New System.Drawing.Point(7, 14)
        Me.IconoAyuda.Name = "IconoAyuda"
        Me.IconoAyuda.Size = New System.Drawing.Size(170, 150)
        Me.IconoAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoAyuda.TabIndex = 13
        Me.IconoAyuda.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.lblNombreUsuario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1147, 91)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63731!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.11883!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27605!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1147, 91)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.slmn
        Me.PictureBox1.Location = New System.Drawing.Point(175, 3)
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
        Me.Label1.Location = New System.Drawing.Point(297, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SOLEMNO GRAFICA"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.47059!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnLogout, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1068, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(68, 85)
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
        Me.btnLogout.Location = New System.Drawing.Point(18, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(47, 34)
        Me.btnLogout.TabIndex = 49
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblUsuario, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(884, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(178, 85)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(3, 16)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(172, 18)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1153, 687)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), System.Drawing.Image)
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Location = New System.Drawing.Point(24, 98)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(614, 277)
        Me.Panel9.TabIndex = 12
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1153, 687)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(1169, 600)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "MenuPrincipal"
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
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel7.PerformLayout()
        CType(Me.GraficoSegunConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSupEstadistica.ResumeLayout(False)
        Me.PanelSupEstadistica.PerformLayout()
        Me.PnlLateralEstadistica.ResumeLayout(False)
        Me.PnlLateralEstadistica.PerformLayout()
        CType(Me.PictureBoxEstadistic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAyuda.ResumeLayout(False)
        Me.PanelCentralAyuda.ResumeLayout(False)
        Me.PanelCentralAyuda.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperiorAyuda.ResumeLayout(False)
        Me.PanelSuperiorAyuda.PerformLayout()
        Me.PanelLateralAyuda.ResumeLayout(False)
        Me.PanelLateralAyuda.PerformLayout()
        CType(Me.IconoAyuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabGeneral As System.Windows.Forms.TabControl
    Friend WithEvents TabCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabProducto As System.Windows.Forms.TabPage
    Friend WithEvents TabPedido As System.Windows.Forms.TabPage
    Friend WithEvents TabEstadistica As System.Windows.Forms.TabPage
    Friend WithEvents TabAyuda As System.Windows.Forms.TabPage
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
    Friend WithEvents PanelCentralAyuda As System.Windows.Forms.Panel
    Friend WithEvents PanelSuperiorAyuda As System.Windows.Forms.Panel
    Friend WithEvents lblTituloAyuda As System.Windows.Forms.Label
    Friend WithEvents PanelLateralAyuda As System.Windows.Forms.Panel
    Friend WithEvents lblIndice As System.Windows.Forms.Label
    Friend WithEvents IconoAyuda As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GraficoSegunConsulta As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAño As System.Windows.Forms.ComboBox
    Friend WithEvents cboMeses As System.Windows.Forms.ComboBox
    Friend WithEvents panelTareas As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboAño2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboTipoEstadistica As System.Windows.Forms.ComboBox
    Friend WithEvents TabUsuario As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarUsuarioInactivos As System.Windows.Forms.Button
    Friend WithEvents DGUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefreshUsuario As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
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
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents IDUsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
End Class
