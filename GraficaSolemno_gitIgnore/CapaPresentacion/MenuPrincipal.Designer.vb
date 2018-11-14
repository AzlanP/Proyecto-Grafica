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
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabTareas = New System.Windows.Forms.TabPage()
        Me.TabCliente = New System.Windows.Forms.TabPage()
        Me.PanelCentralCliente = New System.Windows.Forms.Panel()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.cboBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.DGCliente = New System.Windows.Forms.DataGridView()
        Me.PanelSuperiorCliente = New System.Windows.Forms.Panel()
        Me.lbltituloCliente = New System.Windows.Forms.Label()
        Me.PanelLateralCliente = New System.Windows.Forms.Panel()
        Me.PictureBoxCliente = New System.Windows.Forms.PictureBox()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.TabPedido = New System.Windows.Forms.TabPage()
        Me.PanelCentralPedido = New System.Windows.Forms.Panel()
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
        Me.TabProducto = New System.Windows.Forms.TabPage()
        Me.panelCentralProducto = New System.Windows.Forms.Panel()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.DGProducto = New System.Windows.Forms.DataGridView()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.cboBuscarProducto = New System.Windows.Forms.ComboBox()
        Me.panelSuperiorProducto = New System.Windows.Forms.Panel()
        Me.lblTituloProducto = New System.Windows.Forms.Label()
        Me.panelLateralProducto = New System.Windows.Forms.Panel()
        Me.btnVerProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.IconoProducto = New System.Windows.Forms.PictureBox()
        Me.TabServicios = New System.Windows.Forms.TabPage()
        Me.panelCentralServicio = New System.Windows.Forms.Panel()
        Me.DGServicios = New System.Windows.Forms.DataGridView()
        Me.btnBuscarServicio = New System.Windows.Forms.Button()
        Me.cboBuscarServicio = New System.Windows.Forms.ComboBox()
        Me.txtBuscarServicio = New System.Windows.Forms.TextBox()
        Me.panelSuperiorServicio = New System.Windows.Forms.Panel()
        Me.lblTituloServicio = New System.Windows.Forms.Label()
        Me.panelLateralServicio = New System.Windows.Forms.Panel()
        Me.btnEliminarServicio = New System.Windows.Forms.Button()
        Me.BtnModificarServicio = New System.Windows.Forms.Button()
        Me.btnVerServicio = New System.Windows.Forms.Button()
        Me.btnNuevoServicio = New System.Windows.Forms.Button()
        Me.iconoServicio = New System.Windows.Forms.PictureBox()
        Me.TabEstadistica = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PanelSupEstadistica = New System.Windows.Forms.Panel()
        Me.lblTituloEstadistica = New System.Windows.Forms.Label()
        Me.PnlLateralEstadistica = New System.Windows.Forms.Panel()
        Me.lblSubtituloEstadisticas = New System.Windows.Forms.Label()
        Me.btnGraficosProducto = New System.Windows.Forms.Button()
        Me.btnGraficoServicios = New System.Windows.Forms.Button()
        Me.btnGraficoMedios = New System.Windows.Forms.Button()
        Me.btnGraficoPedidos = New System.Windows.Forms.Button()
        Me.PictureBoxEstadistic = New System.Windows.Forms.PictureBox()
        Me.TabAyuda = New System.Windows.Forms.TabPage()
        Me.PanelCentralAyuda = New System.Windows.Forms.Panel()
        Me.PanelSuperiorAyuda = New System.Windows.Forms.Panel()
        Me.lblTituloAyuda = New System.Windows.Forms.Label()
        Me.PanelLateralAyuda = New System.Windows.Forms.Panel()
        Me.lblIndice = New System.Windows.Forms.Label()
        Me.IconoAyuda = New System.Windows.Forms.PictureBox()
        Me.TabGeneral.SuspendLayout()
        Me.TabCliente.SuspendLayout()
        Me.PanelCentralCliente.SuspendLayout()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperiorCliente.SuspendLayout()
        Me.PanelLateralCliente.SuspendLayout()
        CType(Me.PictureBoxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPedido.SuspendLayout()
        Me.PanelCentralPedido.SuspendLayout()
        CType(Me.DGPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperiorPedido.SuspendLayout()
        Me.PanelLateralPedido.SuspendLayout()
        CType(Me.IconoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProducto.SuspendLayout()
        Me.panelCentralProducto.SuspendLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperiorProducto.SuspendLayout()
        Me.panelLateralProducto.SuspendLayout()
        CType(Me.IconoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabServicios.SuspendLayout()
        Me.panelCentralServicio.SuspendLayout()
        CType(Me.DGServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperiorServicio.SuspendLayout()
        Me.panelLateralServicio.SuspendLayout()
        CType(Me.iconoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEstadistica.SuspendLayout()
        Me.PanelSupEstadistica.SuspendLayout()
        Me.PnlLateralEstadistica.SuspendLayout()
        CType(Me.PictureBoxEstadistic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAyuda.SuspendLayout()
        Me.PanelSuperiorAyuda.SuspendLayout()
        Me.PanelLateralAyuda.SuspendLayout()
        CType(Me.IconoAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabTareas)
        Me.TabGeneral.Controls.Add(Me.TabCliente)
        Me.TabGeneral.Controls.Add(Me.TabPedido)
        Me.TabGeneral.Controls.Add(Me.TabProducto)
        Me.TabGeneral.Controls.Add(Me.TabServicios)
        Me.TabGeneral.Controls.Add(Me.TabEstadistica)
        Me.TabGeneral.Controls.Add(Me.TabAyuda)
        Me.TabGeneral.Location = New System.Drawing.Point(12, 12)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Drawing.Point(6, 4)
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(882, 500)
        Me.TabGeneral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabGeneral.TabIndex = 0
        '
        'TabTareas
        '
        Me.TabTareas.BackColor = System.Drawing.SystemColors.Control
        Me.TabTareas.Location = New System.Drawing.Point(4, 24)
        Me.TabTareas.Name = "TabTareas"
        Me.TabTareas.Size = New System.Drawing.Size(874, 472)
        Me.TabTareas.TabIndex = 6
        Me.TabTareas.Text = "Tareas"
        '
        'TabCliente
        '
        Me.TabCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabCliente.Controls.Add(Me.PanelCentralCliente)
        Me.TabCliente.Controls.Add(Me.PanelSuperiorCliente)
        Me.TabCliente.Controls.Add(Me.PanelLateralCliente)
        Me.TabCliente.Location = New System.Drawing.Point(4, 24)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.Size = New System.Drawing.Size(874, 472)
        Me.TabCliente.TabIndex = 0
        Me.TabCliente.Text = "Cliente"
        '
        'PanelCentralCliente
        '
        Me.PanelCentralCliente.Controls.Add(Me.txtBuscarCliente)
        Me.PanelCentralCliente.Controls.Add(Me.btnBuscarCliente)
        Me.PanelCentralCliente.Controls.Add(Me.cboBuscarCliente)
        Me.PanelCentralCliente.Controls.Add(Me.DGCliente)
        Me.PanelCentralCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralCliente.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralCliente.Name = "PanelCentralCliente"
        Me.PanelCentralCliente.Size = New System.Drawing.Size(690, 383)
        Me.PanelCentralCliente.TabIndex = 13
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(20, 36)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(389, 20)
        Me.txtBuscarCliente.TabIndex = 0
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Location = New System.Drawing.Point(535, 33)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(115, 24)
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
        Me.cboBuscarCliente.Location = New System.Drawing.Point(415, 35)
        Me.cboBuscarCliente.Name = "cboBuscarCliente"
        Me.cboBuscarCliente.Size = New System.Drawing.Size(114, 21)
        Me.cboBuscarCliente.TabIndex = 6
        '
        'DGCliente
        '
        Me.DGCliente.AllowUserToAddRows = False
        Me.DGCliente.AllowUserToDeleteRows = False
        Me.DGCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGCliente.BackgroundColor = System.Drawing.Color.White
        Me.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCliente.Location = New System.Drawing.Point(20, 74)
        Me.DGCliente.MultiSelect = False
        Me.DGCliente.Name = "DGCliente"
        Me.DGCliente.ReadOnly = True
        Me.DGCliente.Size = New System.Drawing.Size(630, 310)
        Me.DGCliente.TabIndex = 7
        '
        'PanelSuperiorCliente
        '
        Me.PanelSuperiorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSuperiorCliente.Controls.Add(Me.lbltituloCliente)
        Me.PanelSuperiorCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorCliente.Location = New System.Drawing.Point(184, 0)
        Me.PanelSuperiorCliente.Name = "PanelSuperiorCliente"
        Me.PanelSuperiorCliente.Size = New System.Drawing.Size(690, 89)
        Me.PanelSuperiorCliente.TabIndex = 12
        '
        'lbltituloCliente
        '
        Me.lbltituloCliente.AutoSize = True
        Me.lbltituloCliente.Font = New System.Drawing.Font("WarHeliosCondCBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltituloCliente.Location = New System.Drawing.Point(241, 14)
        Me.lbltituloCliente.Name = "lbltituloCliente"
        Me.lbltituloCliente.Size = New System.Drawing.Size(151, 59)
        Me.lbltituloCliente.TabIndex = 1
        Me.lbltituloCliente.Text = "Cliente"
        '
        'PanelLateralCliente
        '
        Me.PanelLateralCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PanelLateralCliente.Controls.Add(Me.PictureBoxCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnEliminarCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnVerCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnModificarCliente)
        Me.PanelLateralCliente.Controls.Add(Me.btnNuevoCliente)
        Me.PanelLateralCliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralCliente.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateralCliente.Name = "PanelLateralCliente"
        Me.PanelLateralCliente.Size = New System.Drawing.Size(184, 472)
        Me.PanelLateralCliente.TabIndex = 11
        '
        'PictureBoxCliente
        '
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
        'TabPedido
        '
        Me.TabPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPedido.Controls.Add(Me.PanelCentralPedido)
        Me.TabPedido.Controls.Add(Me.PanelSuperiorPedido)
        Me.TabPedido.Controls.Add(Me.PanelLateralPedido)
        Me.TabPedido.Location = New System.Drawing.Point(4, 24)
        Me.TabPedido.Name = "TabPedido"
        Me.TabPedido.Size = New System.Drawing.Size(874, 472)
        Me.TabPedido.TabIndex = 2
        Me.TabPedido.Text = "Pedido"
        '
        'PanelCentralPedido
        '
        Me.PanelCentralPedido.Controls.Add(Me.txtBuscarPedido)
        Me.PanelCentralPedido.Controls.Add(Me.btnBuscarPedido)
        Me.PanelCentralPedido.Controls.Add(Me.DGPedido)
        Me.PanelCentralPedido.Controls.Add(Me.cboBuscarPedido)
        Me.PanelCentralPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralPedido.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralPedido.Name = "PanelCentralPedido"
        Me.PanelCentralPedido.Size = New System.Drawing.Size(690, 383)
        Me.PanelCentralPedido.TabIndex = 16
        '
        'txtBuscarPedido
        '
        Me.txtBuscarPedido.Location = New System.Drawing.Point(20, 36)
        Me.txtBuscarPedido.Name = "txtBuscarPedido"
        Me.txtBuscarPedido.Size = New System.Drawing.Size(389, 20)
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
        Me.DGPedido.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPedido.Location = New System.Drawing.Point(20, 74)
        Me.DGPedido.Name = "DGPedido"
        Me.DGPedido.Size = New System.Drawing.Size(630, 310)
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
        Me.PanelSuperiorPedido.Size = New System.Drawing.Size(690, 89)
        Me.PanelSuperiorPedido.TabIndex = 15
        '
        'lblTituloPedidos
        '
        Me.lblTituloPedidos.AutoSize = True
        Me.lblTituloPedidos.Font = New System.Drawing.Font("WarHeliosCondCBold", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloPedidos.Location = New System.Drawing.Point(241, 14)
        Me.lblTituloPedidos.Name = "lblTituloPedidos"
        Me.lblTituloPedidos.Size = New System.Drawing.Size(172, 59)
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
        Me.PanelLateralPedido.Size = New System.Drawing.Size(184, 472)
        Me.PanelLateralPedido.TabIndex = 14
        '
        'btnEliminarPedido
        '
        Me.btnEliminarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPedido.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPedido.Location = New System.Drawing.Point(0, 330)
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
        Me.btnVerPedido.Location = New System.Drawing.Point(0, 386)
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
        Me.IconoPedido.Location = New System.Drawing.Point(7, 14)
        Me.IconoPedido.Name = "IconoPedido"
        Me.IconoPedido.Size = New System.Drawing.Size(170, 150)
        Me.IconoPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoPedido.TabIndex = 23
        Me.IconoPedido.TabStop = False
        '
        'TabProducto
        '
        Me.TabProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabProducto.Controls.Add(Me.panelCentralProducto)
        Me.TabProducto.Controls.Add(Me.panelSuperiorProducto)
        Me.TabProducto.Controls.Add(Me.panelLateralProducto)
        Me.TabProducto.Location = New System.Drawing.Point(4, 24)
        Me.TabProducto.Name = "TabProducto"
        Me.TabProducto.Size = New System.Drawing.Size(874, 472)
        Me.TabProducto.TabIndex = 1
        Me.TabProducto.Text = "Producto"
        '
        'panelCentralProducto
        '
        Me.panelCentralProducto.Controls.Add(Me.txtBuscarProducto)
        Me.panelCentralProducto.Controls.Add(Me.DGProducto)
        Me.panelCentralProducto.Controls.Add(Me.btnBuscarProducto)
        Me.panelCentralProducto.Controls.Add(Me.cboBuscarProducto)
        Me.panelCentralProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentralProducto.Location = New System.Drawing.Point(184, 89)
        Me.panelCentralProducto.Name = "panelCentralProducto"
        Me.panelCentralProducto.Size = New System.Drawing.Size(690, 383)
        Me.panelCentralProducto.TabIndex = 17
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(20, 36)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(389, 20)
        Me.txtBuscarProducto.TabIndex = 14
        '
        'DGProducto
        '
        Me.DGProducto.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducto.Location = New System.Drawing.Point(20, 74)
        Me.DGProducto.Name = "DGProducto"
        Me.DGProducto.Size = New System.Drawing.Size(630, 310)
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
        Me.cboBuscarProducto.FormattingEnabled = True
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
        Me.panelSuperiorProducto.Size = New System.Drawing.Size(690, 89)
        Me.panelSuperiorProducto.TabIndex = 17
        '
        'lblTituloProducto
        '
        Me.lblTituloProducto.AutoSize = True
        Me.lblTituloProducto.Font = New System.Drawing.Font("WarHeliosCondCBold", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloProducto.Location = New System.Drawing.Point(207, 14)
        Me.lblTituloProducto.Name = "lblTituloProducto"
        Me.lblTituloProducto.Size = New System.Drawing.Size(211, 59)
        Me.lblTituloProducto.TabIndex = 1
        Me.lblTituloProducto.Text = "Productos"
        '
        'panelLateralProducto
        '
        Me.panelLateralProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.panelLateralProducto.Controls.Add(Me.btnVerProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnModificarProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnEliminarProducto)
        Me.panelLateralProducto.Controls.Add(Me.btnAgregarProducto)
        Me.panelLateralProducto.Controls.Add(Me.IconoProducto)
        Me.panelLateralProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateralProducto.Location = New System.Drawing.Point(0, 0)
        Me.panelLateralProducto.Name = "panelLateralProducto"
        Me.panelLateralProducto.Size = New System.Drawing.Size(184, 472)
        Me.panelLateralProducto.TabIndex = 16
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
        Me.btnVerProducto.Text = "Eliminar Producto"
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
        Me.btnEliminarProducto.Location = New System.Drawing.Point(0, 386)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarProducto.TabIndex = 20
        Me.btnEliminarProducto.Text = "Ver Detalles Producto"
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
        Me.btnAgregarProducto.Text = "Nuevo Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'IconoProducto
        '
        Me.IconoProducto.Location = New System.Drawing.Point(7, 14)
        Me.IconoProducto.Name = "IconoProducto"
        Me.IconoProducto.Size = New System.Drawing.Size(170, 150)
        Me.IconoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoProducto.TabIndex = 18
        Me.IconoProducto.TabStop = False
        '
        'TabServicios
        '
        Me.TabServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabServicios.Controls.Add(Me.panelCentralServicio)
        Me.TabServicios.Controls.Add(Me.panelSuperiorServicio)
        Me.TabServicios.Controls.Add(Me.panelLateralServicio)
        Me.TabServicios.Location = New System.Drawing.Point(4, 24)
        Me.TabServicios.Name = "TabServicios"
        Me.TabServicios.Size = New System.Drawing.Size(874, 472)
        Me.TabServicios.TabIndex = 5
        Me.TabServicios.Text = "Servicios"
        '
        'panelCentralServicio
        '
        Me.panelCentralServicio.Controls.Add(Me.DGServicios)
        Me.panelCentralServicio.Controls.Add(Me.btnBuscarServicio)
        Me.panelCentralServicio.Controls.Add(Me.cboBuscarServicio)
        Me.panelCentralServicio.Controls.Add(Me.txtBuscarServicio)
        Me.panelCentralServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentralServicio.Location = New System.Drawing.Point(184, 89)
        Me.panelCentralServicio.Name = "panelCentralServicio"
        Me.panelCentralServicio.Size = New System.Drawing.Size(690, 383)
        Me.panelCentralServicio.TabIndex = 18
        '
        'DGServicios
        '
        Me.DGServicios.AllowUserToAddRows = False
        Me.DGServicios.AllowUserToDeleteRows = False
        Me.DGServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGServicios.BackgroundColor = System.Drawing.Color.White
        Me.DGServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGServicios.Location = New System.Drawing.Point(20, 74)
        Me.DGServicios.MultiSelect = False
        Me.DGServicios.Name = "DGServicios"
        Me.DGServicios.ReadOnly = True
        Me.DGServicios.Size = New System.Drawing.Size(630, 310)
        Me.DGServicios.TabIndex = 15
        '
        'btnBuscarServicio
        '
        Me.btnBuscarServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarServicio.Location = New System.Drawing.Point(535, 33)
        Me.btnBuscarServicio.Name = "btnBuscarServicio"
        Me.btnBuscarServicio.Size = New System.Drawing.Size(115, 24)
        Me.btnBuscarServicio.TabIndex = 13
        Me.btnBuscarServicio.Text = "Buscar"
        Me.btnBuscarServicio.UseVisualStyleBackColor = False
        '
        'cboBuscarServicio
        '
        Me.cboBuscarServicio.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboBuscarServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarServicio.FormattingEnabled = True
        Me.cboBuscarServicio.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarServicio.Location = New System.Drawing.Point(415, 35)
        Me.cboBuscarServicio.Name = "cboBuscarServicio"
        Me.cboBuscarServicio.Size = New System.Drawing.Size(114, 21)
        Me.cboBuscarServicio.TabIndex = 14
        '
        'txtBuscarServicio
        '
        Me.txtBuscarServicio.Location = New System.Drawing.Point(20, 36)
        Me.txtBuscarServicio.Name = "txtBuscarServicio"
        Me.txtBuscarServicio.Size = New System.Drawing.Size(389, 20)
        Me.txtBuscarServicio.TabIndex = 8
        '
        'panelSuperiorServicio
        '
        Me.panelSuperiorServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.panelSuperiorServicio.Controls.Add(Me.lblTituloServicio)
        Me.panelSuperiorServicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperiorServicio.Location = New System.Drawing.Point(184, 0)
        Me.panelSuperiorServicio.Name = "panelSuperiorServicio"
        Me.panelSuperiorServicio.Size = New System.Drawing.Size(690, 89)
        Me.panelSuperiorServicio.TabIndex = 17
        '
        'lblTituloServicio
        '
        Me.lblTituloServicio.AutoSize = True
        Me.lblTituloServicio.Font = New System.Drawing.Font("WarHeliosCondCBold", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloServicio.Location = New System.Drawing.Point(236, 14)
        Me.lblTituloServicio.Name = "lblTituloServicio"
        Me.lblTituloServicio.Size = New System.Drawing.Size(195, 59)
        Me.lblTituloServicio.TabIndex = 0
        Me.lblTituloServicio.Text = "Servicios"
        '
        'panelLateralServicio
        '
        Me.panelLateralServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.panelLateralServicio.Controls.Add(Me.btnEliminarServicio)
        Me.panelLateralServicio.Controls.Add(Me.BtnModificarServicio)
        Me.panelLateralServicio.Controls.Add(Me.btnVerServicio)
        Me.panelLateralServicio.Controls.Add(Me.btnNuevoServicio)
        Me.panelLateralServicio.Controls.Add(Me.iconoServicio)
        Me.panelLateralServicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateralServicio.Location = New System.Drawing.Point(0, 0)
        Me.panelLateralServicio.Name = "panelLateralServicio"
        Me.panelLateralServicio.Size = New System.Drawing.Size(184, 472)
        Me.panelLateralServicio.TabIndex = 16
        '
        'btnEliminarServicio
        '
        Me.btnEliminarServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarServicio.ForeColor = System.Drawing.Color.White
        Me.btnEliminarServicio.Location = New System.Drawing.Point(0, 330)
        Me.btnEliminarServicio.Name = "btnEliminarServicio"
        Me.btnEliminarServicio.Size = New System.Drawing.Size(184, 50)
        Me.btnEliminarServicio.TabIndex = 17
        Me.btnEliminarServicio.Text = "Eliminar"
        Me.btnEliminarServicio.UseVisualStyleBackColor = False
        '
        'BtnModificarServicio
        '
        Me.BtnModificarServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnModificarServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnModificarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificarServicio.ForeColor = System.Drawing.Color.White
        Me.BtnModificarServicio.Location = New System.Drawing.Point(0, 274)
        Me.BtnModificarServicio.Name = "BtnModificarServicio"
        Me.BtnModificarServicio.Size = New System.Drawing.Size(184, 50)
        Me.BtnModificarServicio.TabIndex = 16
        Me.BtnModificarServicio.Text = "Modificar"
        Me.BtnModificarServicio.UseVisualStyleBackColor = False
        '
        'btnVerServicio
        '
        Me.btnVerServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerServicio.ForeColor = System.Drawing.Color.White
        Me.btnVerServicio.Location = New System.Drawing.Point(0, 386)
        Me.btnVerServicio.Name = "btnVerServicio"
        Me.btnVerServicio.Size = New System.Drawing.Size(184, 50)
        Me.btnVerServicio.TabIndex = 15
        Me.btnVerServicio.Text = "Ver Servicio"
        Me.btnVerServicio.UseVisualStyleBackColor = False
        '
        'btnNuevoServicio
        '
        Me.btnNuevoServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoServicio.ForeColor = System.Drawing.Color.White
        Me.btnNuevoServicio.Location = New System.Drawing.Point(0, 218)
        Me.btnNuevoServicio.Name = "btnNuevoServicio"
        Me.btnNuevoServicio.Size = New System.Drawing.Size(184, 50)
        Me.btnNuevoServicio.TabIndex = 14
        Me.btnNuevoServicio.Text = "Nuevo Servicio"
        Me.btnNuevoServicio.UseVisualStyleBackColor = False
        '
        'iconoServicio
        '
        Me.iconoServicio.Location = New System.Drawing.Point(7, 14)
        Me.iconoServicio.Name = "iconoServicio"
        Me.iconoServicio.Size = New System.Drawing.Size(170, 150)
        Me.iconoServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconoServicio.TabIndex = 13
        Me.iconoServicio.TabStop = False
        '
        'TabEstadistica
        '
        Me.TabEstadistica.Controls.Add(Me.Panel7)
        Me.TabEstadistica.Controls.Add(Me.PanelSupEstadistica)
        Me.TabEstadistica.Controls.Add(Me.PnlLateralEstadistica)
        Me.TabEstadistica.Location = New System.Drawing.Point(4, 24)
        Me.TabEstadistica.Name = "TabEstadistica"
        Me.TabEstadistica.Size = New System.Drawing.Size(874, 472)
        Me.TabEstadistica.TabIndex = 3
        Me.TabEstadistica.Text = "Estadistica"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(184, 89)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(690, 383)
        Me.Panel7.TabIndex = 6
        '
        'PanelSupEstadistica
        '
        Me.PanelSupEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSupEstadistica.Controls.Add(Me.lblTituloEstadistica)
        Me.PanelSupEstadistica.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSupEstadistica.Location = New System.Drawing.Point(184, 0)
        Me.PanelSupEstadistica.Name = "PanelSupEstadistica"
        Me.PanelSupEstadistica.Size = New System.Drawing.Size(690, 89)
        Me.PanelSupEstadistica.TabIndex = 5
        '
        'lblTituloEstadistica
        '
        Me.lblTituloEstadistica.AutoSize = True
        Me.lblTituloEstadistica.Font = New System.Drawing.Font("WarHeliosCondCBold", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloEstadistica.ForeColor = System.Drawing.Color.Black
        Me.lblTituloEstadistica.Location = New System.Drawing.Point(136, 14)
        Me.lblTituloEstadistica.Name = "lblTituloEstadistica"
        Me.lblTituloEstadistica.Size = New System.Drawing.Size(381, 59)
        Me.lblTituloEstadistica.TabIndex = 0
        Me.lblTituloEstadistica.Text = "Pedidos mensuales"
        '
        'PnlLateralEstadistica
        '
        Me.PnlLateralEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PnlLateralEstadistica.Controls.Add(Me.lblSubtituloEstadisticas)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficosProducto)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficoServicios)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficoMedios)
        Me.PnlLateralEstadistica.Controls.Add(Me.btnGraficoPedidos)
        Me.PnlLateralEstadistica.Controls.Add(Me.PictureBoxEstadistic)
        Me.PnlLateralEstadistica.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLateralEstadistica.Location = New System.Drawing.Point(0, 0)
        Me.PnlLateralEstadistica.Name = "PnlLateralEstadistica"
        Me.PnlLateralEstadistica.Size = New System.Drawing.Size(184, 472)
        Me.PnlLateralEstadistica.TabIndex = 4
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
        Me.btnGraficosProducto.Location = New System.Drawing.Point(0, 386)
        Me.btnGraficosProducto.Name = "btnGraficosProducto"
        Me.btnGraficosProducto.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficosProducto.TabIndex = 4
        Me.btnGraficosProducto.Text = "Productos Solicitados"
        Me.btnGraficosProducto.UseVisualStyleBackColor = False
        '
        'btnGraficoServicios
        '
        Me.btnGraficoServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoServicios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGraficoServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoServicios.ForeColor = System.Drawing.Color.White
        Me.btnGraficoServicios.Location = New System.Drawing.Point(0, 330)
        Me.btnGraficoServicios.Name = "btnGraficoServicios"
        Me.btnGraficoServicios.Size = New System.Drawing.Size(184, 50)
        Me.btnGraficoServicios.TabIndex = 3
        Me.btnGraficoServicios.Text = "Servicios Solicitados"
        Me.btnGraficoServicios.UseVisualStyleBackColor = False
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
        Me.TabAyuda.Size = New System.Drawing.Size(874, 472)
        Me.TabAyuda.TabIndex = 4
        Me.TabAyuda.Text = "Ayuda"
        '
        'PanelCentralAyuda
        '
        Me.PanelCentralAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelCentralAyuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentralAyuda.Location = New System.Drawing.Point(184, 89)
        Me.PanelCentralAyuda.Name = "PanelCentralAyuda"
        Me.PanelCentralAyuda.Size = New System.Drawing.Size(690, 383)
        Me.PanelCentralAyuda.TabIndex = 19
        '
        'PanelSuperiorAyuda
        '
        Me.PanelSuperiorAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSuperiorAyuda.Controls.Add(Me.lblTituloAyuda)
        Me.PanelSuperiorAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorAyuda.Location = New System.Drawing.Point(184, 0)
        Me.PanelSuperiorAyuda.Name = "PanelSuperiorAyuda"
        Me.PanelSuperiorAyuda.Size = New System.Drawing.Size(690, 89)
        Me.PanelSuperiorAyuda.TabIndex = 18
        '
        'lblTituloAyuda
        '
        Me.lblTituloAyuda.AutoSize = True
        Me.lblTituloAyuda.Font = New System.Drawing.Font("WarHeliosCondCBold", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloAyuda.Location = New System.Drawing.Point(137, 14)
        Me.lblTituloAyuda.Name = "lblTituloAyuda"
        Me.lblTituloAyuda.Size = New System.Drawing.Size(394, 59)
        Me.lblTituloAyuda.TabIndex = 0
        Me.lblTituloAyuda.Text = "Ayuda del programa"
        '
        'PanelLateralAyuda
        '
        Me.PanelLateralAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PanelLateralAyuda.Controls.Add(Me.lblIndice)
        Me.PanelLateralAyuda.Controls.Add(Me.IconoAyuda)
        Me.PanelLateralAyuda.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralAyuda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateralAyuda.Name = "PanelLateralAyuda"
        Me.PanelLateralAyuda.Size = New System.Drawing.Size(184, 472)
        Me.PanelLateralAyuda.TabIndex = 17
        '
        'lblIndice
        '
        Me.lblIndice.AutoSize = True
        Me.lblIndice.Font = New System.Drawing.Font("WarHeliosCondCBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndice.Location = New System.Drawing.Point(57, 176)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(78, 33)
        Me.lblIndice.TabIndex = 14
        Me.lblIndice.Text = "Indice"
        '
        'IconoAyuda
        '
        Me.IconoAyuda.Location = New System.Drawing.Point(7, 14)
        Me.IconoAyuda.Name = "IconoAyuda"
        Me.IconoAyuda.Size = New System.Drawing.Size(170, 150)
        Me.IconoAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoAyuda.TabIndex = 13
        Me.IconoAyuda.TabStop = False
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(913, 525)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabCliente.ResumeLayout(False)
        Me.PanelCentralCliente.ResumeLayout(False)
        Me.PanelCentralCliente.PerformLayout()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperiorCliente.ResumeLayout(False)
        Me.PanelSuperiorCliente.PerformLayout()
        Me.PanelLateralCliente.ResumeLayout(False)
        CType(Me.PictureBoxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPedido.ResumeLayout(False)
        Me.PanelCentralPedido.ResumeLayout(False)
        Me.PanelCentralPedido.PerformLayout()
        CType(Me.DGPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperiorPedido.ResumeLayout(False)
        Me.PanelSuperiorPedido.PerformLayout()
        Me.PanelLateralPedido.ResumeLayout(False)
        CType(Me.IconoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProducto.ResumeLayout(False)
        Me.panelCentralProducto.ResumeLayout(False)
        Me.panelCentralProducto.PerformLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperiorProducto.ResumeLayout(False)
        Me.panelSuperiorProducto.PerformLayout()
        Me.panelLateralProducto.ResumeLayout(False)
        CType(Me.IconoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabServicios.ResumeLayout(False)
        Me.panelCentralServicio.ResumeLayout(False)
        Me.panelCentralServicio.PerformLayout()
        CType(Me.DGServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperiorServicio.ResumeLayout(False)
        Me.panelSuperiorServicio.PerformLayout()
        Me.panelLateralServicio.ResumeLayout(False)
        CType(Me.iconoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEstadistica.ResumeLayout(False)
        Me.PanelSupEstadistica.ResumeLayout(False)
        Me.PanelSupEstadistica.PerformLayout()
        Me.PnlLateralEstadistica.ResumeLayout(False)
        Me.PnlLateralEstadistica.PerformLayout()
        CType(Me.PictureBoxEstadistic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAyuda.ResumeLayout(False)
        Me.PanelSuperiorAyuda.ResumeLayout(False)
        Me.PanelSuperiorAyuda.PerformLayout()
        Me.PanelLateralAyuda.ResumeLayout(False)
        Me.PanelLateralAyuda.PerformLayout()
        CType(Me.IconoAyuda, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabServicios As System.Windows.Forms.TabPage
    Friend WithEvents cboBuscarPedido As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscarPedido As System.Windows.Forms.TextBox
    Friend WithEvents DGServicios As System.Windows.Forms.DataGridView
    Friend WithEvents cboBuscarServicio As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarServicio As System.Windows.Forms.Button
    Friend WithEvents txtBuscarServicio As System.Windows.Forms.TextBox
    Friend WithEvents panelCentralServicio As System.Windows.Forms.Panel
    Friend WithEvents panelSuperiorServicio As System.Windows.Forms.Panel
    Friend WithEvents lblTituloServicio As System.Windows.Forms.Label
    Friend WithEvents panelLateralServicio As System.Windows.Forms.Panel
    Friend WithEvents btnNuevoServicio As System.Windows.Forms.Button
    Friend WithEvents iconoServicio As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminarServicio As System.Windows.Forms.Button
    Friend WithEvents BtnModificarServicio As System.Windows.Forms.Button
    Friend WithEvents btnVerServicio As System.Windows.Forms.Button
    Friend WithEvents panelCentralProducto As System.Windows.Forms.Panel
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
    Friend WithEvents btnGraficoServicios As System.Windows.Forms.Button
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
End Class
