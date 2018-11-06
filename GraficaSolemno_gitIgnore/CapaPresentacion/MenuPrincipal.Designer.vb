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
        Me.DGCliente = New System.Windows.Forms.DataGridView()
        Me.cboBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.TabPedido = New System.Windows.Forms.TabPage()
        Me.cboBuscarPedido = New System.Windows.Forms.ComboBox()
        Me.txtBuscarPedido = New System.Windows.Forms.TextBox()
        Me.btnBuscarPedido = New System.Windows.Forms.Button()
        Me.btnEliminarPedido = New System.Windows.Forms.Button()
        Me.btnModificarPedido = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.DGPedido = New System.Windows.Forms.DataGridView()
        Me.TabProducto = New System.Windows.Forms.TabPage()
        Me.cboBuscarProducto = New System.Windows.Forms.ComboBox()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.btnVerProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.DGProducto = New System.Windows.Forms.DataGridView()
        Me.TabServicios = New System.Windows.Forms.TabPage()
        Me.DGServicios = New System.Windows.Forms.DataGridView()
        Me.cboBuscarServicio = New System.Windows.Forms.ComboBox()
        Me.btnBuscarServicio = New System.Windows.Forms.Button()
        Me.btnEliminarServicio = New System.Windows.Forms.Button()
        Me.btnVerServicio = New System.Windows.Forms.Button()
        Me.btnModificarServicio = New System.Windows.Forms.Button()
        Me.btnNuevoServicio = New System.Windows.Forms.Button()
        Me.txtBuscarServicio = New System.Windows.Forms.TextBox()
        Me.TabEstadistica = New System.Windows.Forms.TabPage()
        Me.TabAyuda = New System.Windows.Forms.TabPage()
        Me.TabGeneral.SuspendLayout()
        Me.TabCliente.SuspendLayout()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPedido.SuspendLayout()
        CType(Me.DGPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProducto.SuspendLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabServicios.SuspendLayout()
        CType(Me.DGServicios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(702, 450)
        Me.TabGeneral.TabIndex = 0
        '
        'TabTareas
        '
        Me.TabTareas.Location = New System.Drawing.Point(4, 22)
        Me.TabTareas.Name = "TabTareas"
        Me.TabTareas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTareas.Size = New System.Drawing.Size(694, 424)
        Me.TabTareas.TabIndex = 6
        Me.TabTareas.Text = "Tareas"
        Me.TabTareas.UseVisualStyleBackColor = True
        '
        'TabCliente
        '
        Me.TabCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabCliente.Controls.Add(Me.DGCliente)
        Me.TabCliente.Controls.Add(Me.cboBuscarCliente)
        Me.TabCliente.Controls.Add(Me.btnBuscarCliente)
        Me.TabCliente.Controls.Add(Me.btnEliminarCliente)
        Me.TabCliente.Controls.Add(Me.btnVerCliente)
        Me.TabCliente.Controls.Add(Me.btnModificarCliente)
        Me.TabCliente.Controls.Add(Me.btnNuevoCliente)
        Me.TabCliente.Controls.Add(Me.txtBuscarCliente)
        Me.TabCliente.Location = New System.Drawing.Point(4, 22)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCliente.Size = New System.Drawing.Size(694, 424)
        Me.TabCliente.TabIndex = 0
        Me.TabCliente.Text = "Cliente"
        '
        'DGCliente
        '
        Me.DGCliente.AllowUserToAddRows = False
        Me.DGCliente.AllowUserToDeleteRows = False
        Me.DGCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGCliente.BackgroundColor = System.Drawing.Color.White
        Me.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCliente.Location = New System.Drawing.Point(38, 62)
        Me.DGCliente.MultiSelect = False
        Me.DGCliente.Name = "DGCliente"
        Me.DGCliente.ReadOnly = True
        Me.DGCliente.Size = New System.Drawing.Size(621, 284)
        Me.DGCliente.TabIndex = 7
        '
        'cboBuscarCliente
        '
        Me.cboBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarCliente.FormattingEnabled = True
        Me.cboBuscarCliente.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarCliente.Location = New System.Drawing.Point(405, 35)
        Me.cboBuscarCliente.Name = "cboBuscarCliente"
        Me.cboBuscarCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscarCliente.TabIndex = 6
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(543, 33)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCliente.TabIndex = 5
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(441, 352)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnEliminarCliente.TabIndex = 4
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnVerCliente
        '
        Me.btnVerCliente.Location = New System.Drawing.Point(299, 352)
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnVerCliente.TabIndex = 3
        Me.btnVerCliente.Text = "Ver Cliente"
        Me.btnVerCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(167, 352)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnModificarCliente.TabIndex = 2
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Location = New System.Drawing.Point(38, 352)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnNuevoCliente.TabIndex = 1
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(38, 36)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(352, 20)
        Me.txtBuscarCliente.TabIndex = 0
        '
        'TabPedido
        '
        Me.TabPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPedido.Controls.Add(Me.cboBuscarPedido)
        Me.TabPedido.Controls.Add(Me.txtBuscarPedido)
        Me.TabPedido.Controls.Add(Me.btnBuscarPedido)
        Me.TabPedido.Controls.Add(Me.btnEliminarPedido)
        Me.TabPedido.Controls.Add(Me.btnModificarPedido)
        Me.TabPedido.Controls.Add(Me.Button7)
        Me.TabPedido.Controls.Add(Me.btnNuevoPedido)
        Me.TabPedido.Controls.Add(Me.DGPedido)
        Me.TabPedido.Location = New System.Drawing.Point(4, 22)
        Me.TabPedido.Name = "TabPedido"
        Me.TabPedido.Size = New System.Drawing.Size(694, 424)
        Me.TabPedido.TabIndex = 2
        Me.TabPedido.Text = "Pedido"
        '
        'cboBuscarPedido
        '
        Me.cboBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarPedido.FormattingEnabled = True
        Me.cboBuscarPedido.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarPedido.Location = New System.Drawing.Point(385, 36)
        Me.cboBuscarPedido.Name = "cboBuscarPedido"
        Me.cboBuscarPedido.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscarPedido.TabIndex = 13
        '
        'txtBuscarPedido
        '
        Me.txtBuscarPedido.Location = New System.Drawing.Point(38, 36)
        Me.txtBuscarPedido.Name = "txtBuscarPedido"
        Me.txtBuscarPedido.Size = New System.Drawing.Size(341, 20)
        Me.txtBuscarPedido.TabIndex = 12
        '
        'btnBuscarPedido
        '
        Me.btnBuscarPedido.Location = New System.Drawing.Point(512, 34)
        Me.btnBuscarPedido.Name = "btnBuscarPedido"
        Me.btnBuscarPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarPedido.TabIndex = 11
        Me.btnBuscarPedido.Text = "Buscar"
        Me.btnBuscarPedido.UseVisualStyleBackColor = True
        '
        'btnEliminarPedido
        '
        Me.btnEliminarPedido.Location = New System.Drawing.Point(184, 359)
        Me.btnEliminarPedido.Name = "btnEliminarPedido"
        Me.btnEliminarPedido.Size = New System.Drawing.Size(114, 23)
        Me.btnEliminarPedido.TabIndex = 10
        Me.btnEliminarPedido.Text = "Eliminar"
        Me.btnEliminarPedido.UseVisualStyleBackColor = True
        '
        'btnModificarPedido
        '
        Me.btnModificarPedido.Location = New System.Drawing.Point(320, 359)
        Me.btnModificarPedido.Name = "btnModificarPedido"
        Me.btnModificarPedido.Size = New System.Drawing.Size(114, 23)
        Me.btnModificarPedido.TabIndex = 9
        Me.btnModificarPedido.Text = "Modificar"
        Me.btnModificarPedido.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(456, 359)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Ver"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.Location = New System.Drawing.Point(48, 359)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(114, 23)
        Me.btnNuevoPedido.TabIndex = 7
        Me.btnNuevoPedido.Text = "Nuevo Producto"
        Me.btnNuevoPedido.UseVisualStyleBackColor = True
        '
        'DGPedido
        '
        Me.DGPedido.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPedido.Location = New System.Drawing.Point(38, 62)
        Me.DGPedido.Name = "DGPedido"
        Me.DGPedido.Size = New System.Drawing.Size(621, 284)
        Me.DGPedido.TabIndex = 6
        '
        'TabProducto
        '
        Me.TabProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabProducto.Controls.Add(Me.cboBuscarProducto)
        Me.TabProducto.Controls.Add(Me.txtBuscarProducto)
        Me.TabProducto.Controls.Add(Me.btnVerProducto)
        Me.TabProducto.Controls.Add(Me.btnModificarProducto)
        Me.TabProducto.Controls.Add(Me.btnEliminarProducto)
        Me.TabProducto.Controls.Add(Me.btnAgregarProducto)
        Me.TabProducto.Controls.Add(Me.btnBuscarProducto)
        Me.TabProducto.Controls.Add(Me.DGProducto)
        Me.TabProducto.Location = New System.Drawing.Point(4, 22)
        Me.TabProducto.Name = "TabProducto"
        Me.TabProducto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProducto.Size = New System.Drawing.Size(694, 424)
        Me.TabProducto.TabIndex = 1
        Me.TabProducto.Text = "Producto"
        '
        'cboBuscarProducto
        '
        Me.cboBuscarProducto.FormattingEnabled = True
        Me.cboBuscarProducto.Location = New System.Drawing.Point(409, 34)
        Me.cboBuscarProducto.Name = "cboBuscarProducto"
        Me.cboBuscarProducto.Size = New System.Drawing.Size(169, 21)
        Me.cboBuscarProducto.TabIndex = 15
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(38, 35)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(365, 20)
        Me.txtBuscarProducto.TabIndex = 14
        '
        'btnVerProducto
        '
        Me.btnVerProducto.Location = New System.Drawing.Point(460, 352)
        Me.btnVerProducto.Name = "btnVerProducto"
        Me.btnVerProducto.Size = New System.Drawing.Size(112, 23)
        Me.btnVerProducto.TabIndex = 13
        Me.btnVerProducto.Text = "Ver Producto"
        Me.btnVerProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(312, 352)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(126, 23)
        Me.btnModificarProducto.TabIndex = 12
        Me.btnModificarProducto.Text = "Modificar Producto"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(169, 352)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(119, 23)
        Me.btnEliminarProducto.TabIndex = 11
        Me.btnEliminarProducto.Text = "Eliminar Producto"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(38, 352)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(111, 23)
        Me.btnAgregarProducto.TabIndex = 10
        Me.btnAgregarProducto.Text = "Nuevo Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(584, 32)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscarProducto.TabIndex = 9
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'DGProducto
        '
        Me.DGProducto.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducto.Location = New System.Drawing.Point(38, 59)
        Me.DGProducto.Name = "DGProducto"
        Me.DGProducto.Size = New System.Drawing.Size(621, 284)
        Me.DGProducto.TabIndex = 8
        '
        'TabServicios
        '
        Me.TabServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabServicios.Controls.Add(Me.DGServicios)
        Me.TabServicios.Controls.Add(Me.cboBuscarServicio)
        Me.TabServicios.Controls.Add(Me.btnBuscarServicio)
        Me.TabServicios.Controls.Add(Me.btnEliminarServicio)
        Me.TabServicios.Controls.Add(Me.btnVerServicio)
        Me.TabServicios.Controls.Add(Me.btnModificarServicio)
        Me.TabServicios.Controls.Add(Me.btnNuevoServicio)
        Me.TabServicios.Controls.Add(Me.txtBuscarServicio)
        Me.TabServicios.Location = New System.Drawing.Point(4, 22)
        Me.TabServicios.Name = "TabServicios"
        Me.TabServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabServicios.Size = New System.Drawing.Size(694, 424)
        Me.TabServicios.TabIndex = 5
        Me.TabServicios.Text = "Servicios"
        '
        'DGServicios
        '
        Me.DGServicios.AllowUserToAddRows = False
        Me.DGServicios.AllowUserToDeleteRows = False
        Me.DGServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGServicios.BackgroundColor = System.Drawing.Color.White
        Me.DGServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGServicios.Location = New System.Drawing.Point(38, 62)
        Me.DGServicios.MultiSelect = False
        Me.DGServicios.Name = "DGServicios"
        Me.DGServicios.ReadOnly = True
        Me.DGServicios.Size = New System.Drawing.Size(621, 284)
        Me.DGServicios.TabIndex = 15
        '
        'cboBuscarServicio
        '
        Me.cboBuscarServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscarServicio.FormattingEnabled = True
        Me.cboBuscarServicio.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscarServicio.Location = New System.Drawing.Point(396, 35)
        Me.cboBuscarServicio.Name = "cboBuscarServicio"
        Me.cboBuscarServicio.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscarServicio.TabIndex = 14
        '
        'btnBuscarServicio
        '
        Me.btnBuscarServicio.Location = New System.Drawing.Point(537, 35)
        Me.btnBuscarServicio.Name = "btnBuscarServicio"
        Me.btnBuscarServicio.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarServicio.TabIndex = 13
        Me.btnBuscarServicio.Text = "Buscar"
        Me.btnBuscarServicio.UseVisualStyleBackColor = True
        '
        'btnEliminarServicio
        '
        Me.btnEliminarServicio.Location = New System.Drawing.Point(175, 352)
        Me.btnEliminarServicio.Name = "btnEliminarServicio"
        Me.btnEliminarServicio.Size = New System.Drawing.Size(110, 23)
        Me.btnEliminarServicio.TabIndex = 12
        Me.btnEliminarServicio.Text = "Eliminar"
        Me.btnEliminarServicio.UseVisualStyleBackColor = True
        '
        'btnVerServicio
        '
        Me.btnVerServicio.Location = New System.Drawing.Point(326, 352)
        Me.btnVerServicio.Name = "btnVerServicio"
        Me.btnVerServicio.Size = New System.Drawing.Size(110, 23)
        Me.btnVerServicio.TabIndex = 11
        Me.btnVerServicio.Text = "Ver servicio"
        Me.btnVerServicio.UseVisualStyleBackColor = True
        '
        'btnModificarServicio
        '
        Me.btnModificarServicio.Location = New System.Drawing.Point(442, 352)
        Me.btnModificarServicio.Name = "btnModificarServicio"
        Me.btnModificarServicio.Size = New System.Drawing.Size(110, 23)
        Me.btnModificarServicio.TabIndex = 10
        Me.btnModificarServicio.Text = "Modificar"
        Me.btnModificarServicio.UseVisualStyleBackColor = True
        '
        'btnNuevoServicio
        '
        Me.btnNuevoServicio.Location = New System.Drawing.Point(48, 352)
        Me.btnNuevoServicio.Name = "btnNuevoServicio"
        Me.btnNuevoServicio.Size = New System.Drawing.Size(110, 23)
        Me.btnNuevoServicio.TabIndex = 9
        Me.btnNuevoServicio.Text = "Nuevo Servicio"
        Me.btnNuevoServicio.UseVisualStyleBackColor = True
        '
        'txtBuscarServicio
        '
        Me.txtBuscarServicio.Location = New System.Drawing.Point(38, 36)
        Me.txtBuscarServicio.Name = "txtBuscarServicio"
        Me.txtBuscarServicio.Size = New System.Drawing.Size(352, 20)
        Me.txtBuscarServicio.TabIndex = 8
        '
        'TabEstadistica
        '
        Me.TabEstadistica.Location = New System.Drawing.Point(4, 22)
        Me.TabEstadistica.Name = "TabEstadistica"
        Me.TabEstadistica.Size = New System.Drawing.Size(694, 424)
        Me.TabEstadistica.TabIndex = 3
        Me.TabEstadistica.Text = "Estadistica"
        Me.TabEstadistica.UseVisualStyleBackColor = True
        '
        'TabAyuda
        '
        Me.TabAyuda.Location = New System.Drawing.Point(4, 22)
        Me.TabAyuda.Name = "TabAyuda"
        Me.TabAyuda.Size = New System.Drawing.Size(694, 424)
        Me.TabAyuda.TabIndex = 4
        Me.TabAyuda.Text = "Ayuda"
        Me.TabAyuda.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(726, 491)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabCliente.ResumeLayout(False)
        Me.TabCliente.PerformLayout()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPedido.ResumeLayout(False)
        Me.TabPedido.PerformLayout()
        CType(Me.DGPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProducto.ResumeLayout(False)
        Me.TabProducto.PerformLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabServicios.ResumeLayout(False)
        Me.TabServicios.PerformLayout()
        CType(Me.DGServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabGeneral As System.Windows.Forms.TabControl
    Friend WithEvents TabCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabProducto As System.Windows.Forms.TabPage
    Friend WithEvents DGCliente As System.Windows.Forms.DataGridView
    Friend WithEvents cboBuscarCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents btnEliminarCliente As System.Windows.Forms.Button
    Friend WithEvents btnVerCliente As System.Windows.Forms.Button
    Friend WithEvents btnModificarCliente As System.Windows.Forms.Button
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCliente As System.Windows.Forms.TextBox
    Friend WithEvents TabPedido As System.Windows.Forms.TabPage
    Friend WithEvents TabEstadistica As System.Windows.Forms.TabPage
    Friend WithEvents TabAyuda As System.Windows.Forms.TabPage
    Friend WithEvents cboBuscarProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnVerProducto As System.Windows.Forms.Button
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnEliminarProducto As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents DGProducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarPedido As System.Windows.Forms.Button
    Friend WithEvents btnEliminarPedido As System.Windows.Forms.Button
    Friend WithEvents btnModificarPedido As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnNuevoPedido As System.Windows.Forms.Button
    Friend WithEvents DGPedido As System.Windows.Forms.DataGridView
    Friend WithEvents TabTareas As System.Windows.Forms.TabPage
    Friend WithEvents TabServicios As System.Windows.Forms.TabPage
    Friend WithEvents cboBuscarPedido As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscarPedido As System.Windows.Forms.TextBox
    Friend WithEvents DGServicios As System.Windows.Forms.DataGridView
    Friend WithEvents cboBuscarServicio As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarServicio As System.Windows.Forms.Button
    Friend WithEvents btnEliminarServicio As System.Windows.Forms.Button
    Friend WithEvents btnVerServicio As System.Windows.Forms.Button
    Friend WithEvents btnModificarServicio As System.Windows.Forms.Button
    Friend WithEvents btnNuevoServicio As System.Windows.Forms.Button
    Friend WithEvents txtBuscarServicio As System.Windows.Forms.TextBox
End Class
