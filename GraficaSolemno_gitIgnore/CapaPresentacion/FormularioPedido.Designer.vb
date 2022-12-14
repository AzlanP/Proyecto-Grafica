<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPedido))
        Me.TipoEnvioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.btnCancelarPedido = New System.Windows.Forms.Button()
        Me.btnGuardarPedido = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnModificarPedido = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregarPedidoNuevo = New System.Windows.Forms.Button()
        Me.DGListaDePedido = New System.Windows.Forms.DataGridView()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblMedio = New System.Windows.Forms.Label()
        Me.cboMedio = New System.Windows.Forms.ComboBox()
        Me.MediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSeña = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ClientesTableAdapter()
        Me.MediosTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.MediosTableAdapter()
        Me.TipoEnvioTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.TipoEnvioTableAdapter()
        Me.txtTotal = New CapaPresentacion.ValidacionMoneda()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnEnvioGuardado = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboDesc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaVencimiento = New System.Windows.Forms.Label()
        Me.btnGuardarPresupuesto = New System.Windows.Forms.Button()
        Me.chkEnvio = New System.Windows.Forms.CheckBox()
        Me.txtClienteNombreCompleto = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtSubTotal = New CapaPresentacion.ValidacionMoneda()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmarPedido = New System.Windows.Forms.Button()
        Me.txtAnticipoSena = New System.Windows.Forms.TextBox()
        Me.txtSymbol = New System.Windows.Forms.TextBox()
        Me.required = New System.Windows.Forms.Label()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.txtIdPresupuesto = New System.Windows.Forms.TextBox()
        Me.btnBuscarPresupuesto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlBuscarPresupuesto = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.UsuariosTableAdapter1 = New CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TipoEnvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGListaDePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlData.SuspendLayout()
        Me.pnlBuscarPresupuesto.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoEnvioBindingSource
        '
        Me.TipoEnvioBindingSource.DataMember = "TipoEnvio"
        Me.TipoEnvioBindingSource.DataSource = Me.SolemnoDataSet
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancelarPedido
        '
        Me.btnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarPedido.Location = New System.Drawing.Point(787, 404)
        Me.btnCancelarPedido.Name = "btnCancelarPedido"
        Me.btnCancelarPedido.Size = New System.Drawing.Size(81, 24)
        Me.btnCancelarPedido.TabIndex = 31
        Me.btnCancelarPedido.Text = "Cancelar"
        Me.btnCancelarPedido.UseVisualStyleBackColor = False
        '
        'btnGuardarPedido
        '
        Me.btnGuardarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPedido.Location = New System.Drawing.Point(687, 405)
        Me.btnGuardarPedido.Name = "btnGuardarPedido"
        Me.btnGuardarPedido.Size = New System.Drawing.Size(94, 24)
        Me.btnGuardarPedido.TabIndex = 30
        Me.btnGuardarPedido.Text = "Guardar"
        Me.btnGuardarPedido.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 350)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(637, 81)
        Me.txtDescripcion.TabIndex = 29
        Me.txtDescripcion.Tag = "3"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(639, 51)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 28
        '
        'cboCliente
        '
        Me.cboCliente.DataSource = Me.ClientesBindingSource
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(144, 11)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(107, 21)
        Me.cboCliente.TabIndex = 27
        Me.cboCliente.ValueMember = "IDCliente"
        Me.cboCliente.Visible = False
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SolemnoDataSet
        '
        'btnModificarPedido
        '
        Me.btnModificarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPedido.Location = New System.Drawing.Point(778, 178)
        Me.btnModificarPedido.Name = "btnModificarPedido"
        Me.btnModificarPedido.Size = New System.Drawing.Size(89, 24)
        Me.btnModificarPedido.TabIndex = 25
        Me.btnModificarPedido.Text = "Modificar"
        Me.btnModificarPedido.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(778, 150)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(89, 24)
        Me.btnQuitar.TabIndex = 24
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregarPedidoNuevo
        '
        Me.btnAgregarPedidoNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarPedidoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPedidoNuevo.Location = New System.Drawing.Point(779, 120)
        Me.btnAgregarPedidoNuevo.Name = "btnAgregarPedidoNuevo"
        Me.btnAgregarPedidoNuevo.Size = New System.Drawing.Size(89, 24)
        Me.btnAgregarPedidoNuevo.TabIndex = 23
        Me.btnAgregarPedidoNuevo.Text = "Añadir producto "
        Me.btnAgregarPedidoNuevo.UseVisualStyleBackColor = False
        '
        'DGListaDePedido
        '
        Me.DGListaDePedido.AllowUserToAddRows = False
        Me.DGListaDePedido.AllowUserToDeleteRows = False
        Me.DGListaDePedido.AllowUserToOrderColumns = True
        Me.DGListaDePedido.AllowUserToResizeRows = False
        Me.DGListaDePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGListaDePedido.BackgroundColor = System.Drawing.Color.White
        Me.DGListaDePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaDePedido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGListaDePedido.Location = New System.Drawing.Point(23, 120)
        Me.DGListaDePedido.MultiSelect = False
        Me.DGListaDePedido.Name = "DGListaDePedido"
        Me.DGListaDePedido.ReadOnly = True
        Me.DGListaDePedido.RowHeadersVisible = False
        Me.DGListaDePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGListaDePedido.Size = New System.Drawing.Size(737, 174)
        Me.DGListaDePedido.TabIndex = 22
        '
        'lblDetalles
        '
        Me.lblDetalles.AutoSize = True
        Me.lblDetalles.Location = New System.Drawing.Point(20, 104)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.Size = New System.Drawing.Size(43, 13)
        Me.lblDetalles.TabIndex = 21
        Me.lblDetalles.Text = "Detalle:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 334)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 19
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(587, 53)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 18
        Me.lblFecha.Text = "Fecha:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(93, 14)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 17
        Me.lblCliente.Text = "Cliente:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(584, 17)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 36
        Me.lblEstado.Text = "Estado:"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Pendiente", "Completado"})
        Me.cboEstado.Location = New System.Drawing.Point(639, 13)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 35
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(15, 45)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(123, 13)
        Me.lblMedio.TabIndex = 38
        Me.lblMedio.Text = "Medio de comunicacion:"
        '
        'cboMedio
        '
        Me.cboMedio.DataSource = Me.MediosBindingSource
        Me.cboMedio.DisplayMember = "Nombre"
        Me.cboMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedio.FormattingEnabled = True
        Me.cboMedio.Location = New System.Drawing.Point(144, 42)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(164, 21)
        Me.cboMedio.TabIndex = 37
        Me.cboMedio.ValueMember = "IDMedio"
        '
        'MediosBindingSource
        '
        Me.MediosBindingSource.DataMember = "Medios"
        Me.MediosBindingSource.DataSource = Me.SolemnoDataSet
        '
        'lblSeña
        '
        Me.lblSeña.AutoSize = True
        Me.lblSeña.Location = New System.Drawing.Point(190, 307)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(41, 13)
        Me.lblSeña.TabIndex = 39
        Me.lblSeña.Text = "Seña : "
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'MediosTableAdapter
        '
        Me.MediosTableAdapter.ClearBeforeFill = True
        '
        'TipoEnvioTableAdapter
        '
        Me.TipoEnvioTableAdapter.ClearBeforeFill = True
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Enabled = False
        Me.txtTotal.labeltext = "$"
        Me.txtTotal.Location = New System.Drawing.Point(677, 302)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(83, 22)
        Me.txtTotal.TabIndex = 45
        Me.txtTotal.valor = 0R
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(640, 307)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 44
        Me.lblTotal.Text = "Total:"
        '
        'btnEnvioGuardado
        '
        Me.btnEnvioGuardado.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnvioGuardado.Enabled = False
        Me.btnEnvioGuardado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnvioGuardado.Location = New System.Drawing.Point(778, 248)
        Me.btnEnvioGuardado.Name = "btnEnvioGuardado"
        Me.btnEnvioGuardado.Size = New System.Drawing.Size(89, 24)
        Me.btnEnvioGuardado.TabIndex = 46
        Me.btnEnvioGuardado.Text = "Datos de envio"
        Me.btnEnvioGuardado.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.LUPA
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(319, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(355, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboDesc
        '
        Me.cboDesc.DisplayMember = "0"
        Me.cboDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesc.FormattingEnabled = True
        Me.cboDesc.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30"})
        Me.cboDesc.Location = New System.Drawing.Point(418, 304)
        Me.cboDesc.Name = "cboDesc"
        Me.cboDesc.Size = New System.Drawing.Size(61, 21)
        Me.cboDesc.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Descuento (%):"
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(639, 80)
        Me.dtpFechaVencimiento.MinDate = New Date(2016, 11, 23, 0, 0, 0, 0)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(121, 20)
        Me.dtpFechaVencimiento.TabIndex = 52
        Me.dtpFechaVencimiento.Visible = False
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.AutoSize = True
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(527, 80)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(100, 13)
        Me.lblFechaVencimiento.TabIndex = 51
        Me.lblFechaVencimiento.Text = "Fecha vencimiento:"
        Me.lblFechaVencimiento.Visible = False
        '
        'btnGuardarPresupuesto
        '
        Me.btnGuardarPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPresupuesto.Location = New System.Drawing.Point(687, 405)
        Me.btnGuardarPresupuesto.Name = "btnGuardarPresupuesto"
        Me.btnGuardarPresupuesto.Size = New System.Drawing.Size(94, 24)
        Me.btnGuardarPresupuesto.TabIndex = 53
        Me.btnGuardarPresupuesto.Text = "Guardar presupuesto"
        Me.btnGuardarPresupuesto.UseVisualStyleBackColor = False
        Me.btnGuardarPresupuesto.Visible = False
        '
        'chkEnvio
        '
        Me.chkEnvio.AutoSize = True
        Me.chkEnvio.Location = New System.Drawing.Point(778, 225)
        Me.chkEnvio.Name = "chkEnvio"
        Me.chkEnvio.Size = New System.Drawing.Size(53, 17)
        Me.chkEnvio.TabIndex = 54
        Me.chkEnvio.Text = "Envio"
        Me.chkEnvio.UseVisualStyleBackColor = True
        '
        'txtClienteNombreCompleto
        '
        Me.txtClienteNombreCompleto.Enabled = False
        Me.txtClienteNombreCompleto.Location = New System.Drawing.Point(144, 11)
        Me.txtClienteNombreCompleto.Name = "txtClienteNombreCompleto"
        Me.txtClienteNombreCompleto.ReadOnly = True
        Me.txtClienteNombreCompleto.Size = New System.Drawing.Size(164, 20)
        Me.txtClienteNombreCompleto.TabIndex = 55
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(778, 11)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(89, 24)
        Me.btnImprimir.TabIndex = 56
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoSize = True
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.labeltext = "$"
        Me.txtSubTotal.Location = New System.Drawing.Point(554, 302)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(83, 22)
        Me.txtSubTotal.TabIndex = 58
        Me.txtSubTotal.valor = 0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(502, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Subtotal:"
        '
        'btnConfirmarPedido
        '
        Me.btnConfirmarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarPedido.Location = New System.Drawing.Point(748, 350)
        Me.btnConfirmarPedido.Name = "btnConfirmarPedido"
        Me.btnConfirmarPedido.Size = New System.Drawing.Size(120, 24)
        Me.btnConfirmarPedido.TabIndex = 59
        Me.btnConfirmarPedido.Text = "Generar el pedido"
        Me.btnConfirmarPedido.UseVisualStyleBackColor = False
        Me.btnConfirmarPedido.Visible = False
        '
        'txtAnticipoSena
        '
        Me.txtAnticipoSena.Location = New System.Drawing.Point(246, 305)
        Me.txtAnticipoSena.Name = "txtAnticipoSena"
        Me.txtAnticipoSena.Size = New System.Drawing.Size(72, 20)
        Me.txtAnticipoSena.TabIndex = 60
        Me.txtAnticipoSena.Text = "0.0"
        '
        'txtSymbol
        '
        Me.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSymbol.Location = New System.Drawing.Point(235, 305)
        Me.txtSymbol.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSymbol.Name = "txtSymbol"
        Me.txtSymbol.ReadOnly = True
        Me.txtSymbol.Size = New System.Drawing.Size(13, 20)
        Me.txtSymbol.TabIndex = 61
        Me.txtSymbol.Text = "$"
        '
        'required
        '
        Me.required.AutoSize = True
        Me.required.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.required.ForeColor = System.Drawing.Color.Red
        Me.required.Location = New System.Drawing.Point(81, 11)
        Me.required.Margin = New System.Windows.Forms.Padding(0)
        Me.required.Name = "required"
        Me.required.Size = New System.Drawing.Size(15, 20)
        Me.required.TabIndex = 62
        Me.required.Text = "*"
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Location = New System.Drawing.Point(63, 76)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(72, 13)
        Me.lblResponsable.TabIndex = 65
        Me.lblResponsable.Text = "Responsable:"
        '
        'txtResponsable
        '
        Me.txtResponsable.Enabled = False
        Me.txtResponsable.Location = New System.Drawing.Point(144, 74)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.ReadOnly = True
        Me.txtResponsable.Size = New System.Drawing.Size(164, 20)
        Me.txtResponsable.TabIndex = 66
        '
        'pnlData
        '
        Me.pnlData.Controls.Add(Me.cboResponsable)
        Me.pnlData.Controls.Add(Me.txtClienteNombreCompleto)
        Me.pnlData.Controls.Add(Me.lblCliente)
        Me.pnlData.Controls.Add(Me.txtResponsable)
        Me.pnlData.Controls.Add(Me.cboCliente)
        Me.pnlData.Controls.Add(Me.lblResponsable)
        Me.pnlData.Controls.Add(Me.cboMedio)
        Me.pnlData.Controls.Add(Me.required)
        Me.pnlData.Controls.Add(Me.lblMedio)
        Me.pnlData.Controls.Add(Me.btnSearch)
        Me.pnlData.Controls.Add(Me.btnAdd)
        Me.pnlData.Location = New System.Drawing.Point(22, 2)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(390, 99)
        Me.pnlData.TabIndex = 68
        '
        'txtIdPresupuesto
        '
        Me.txtIdPresupuesto.Enabled = False
        Me.txtIdPresupuesto.Location = New System.Drawing.Point(6, 33)
        Me.txtIdPresupuesto.Name = "txtIdPresupuesto"
        Me.txtIdPresupuesto.ReadOnly = True
        Me.txtIdPresupuesto.Size = New System.Drawing.Size(62, 20)
        Me.txtIdPresupuesto.TabIndex = 71
        '
        'btnBuscarPresupuesto
        '
        Me.btnBuscarPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarPresupuesto.FlatAppearance.BorderSize = 0
        Me.btnBuscarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPresupuesto.Location = New System.Drawing.Point(74, 27)
        Me.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto"
        Me.btnBuscarPresupuesto.Size = New System.Drawing.Size(30, 30)
        Me.btnBuscarPresupuesto.TabIndex = 70
        Me.btnBuscarPresupuesto.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Buscar presupuesto:"
        '
        'pnlBuscarPresupuesto
        '
        Me.pnlBuscarPresupuesto.Controls.Add(Me.Label3)
        Me.pnlBuscarPresupuesto.Controls.Add(Me.txtIdPresupuesto)
        Me.pnlBuscarPresupuesto.Controls.Add(Me.btnBuscarPresupuesto)
        Me.pnlBuscarPresupuesto.Location = New System.Drawing.Point(427, 8)
        Me.pnlBuscarPresupuesto.Name = "pnlBuscarPresupuesto"
        Me.pnlBuscarPresupuesto.Size = New System.Drawing.Size(114, 62)
        Me.pnlBuscarPresupuesto.TabIndex = 73
        Me.pnlBuscarPresupuesto.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(784, 58)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID:"
        '
        'cboResponsable
        '
        Me.cboResponsable.DataSource = Me.UsuariosBindingSource
        Me.cboResponsable.DisplayMember = "NombreCompleto"
        Me.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsable.FormattingEnabled = True
        Me.cboResponsable.Location = New System.Drawing.Point(144, 73)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(164, 21)
        Me.cboResponsable.TabIndex = 67
        Me.cboResponsable.ValueMember = "NombreCompleto"
        '
        'UsuariosTableAdapter1
        '
        Me.UsuariosTableAdapter1.ClearBeforeFill = True
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SolemnoDataSet
        '
        'FormularioPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 442)
        Me.Controls.Add(Me.pnlBuscarPresupuesto)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.txtSymbol)
        Me.Controls.Add(Me.txtAnticipoSena)
        Me.Controls.Add(Me.btnConfirmarPedido)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.chkEnvio)
        Me.Controls.Add(Me.btnGuardarPresupuesto)
        Me.Controls.Add(Me.dtpFechaVencimiento)
        Me.Controls.Add(Me.lblFechaVencimiento)
        Me.Controls.Add(Me.cboDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEnvioGuardado)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSeña)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.btnCancelarPedido)
        Me.Controls.Add(Me.btnGuardarPedido)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnModificarPedido)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregarPedidoNuevo)
        Me.Controls.Add(Me.DGListaDePedido)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormularioPedido"
        Me.Text = "Detalles del Pedido"
        CType(Me.TipoEnvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGListaDePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.pnlBuscarPresupuesto.ResumeLayout(False)
        Me.pnlBuscarPresupuesto.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelarPedido As System.Windows.Forms.Button
    Friend WithEvents btnGuardarPedido As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificarPedido As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPedidoNuevo As System.Windows.Forms.Button
    Friend WithEvents DGListaDePedido As System.Windows.Forms.DataGridView
    Friend WithEvents lblDetalles As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents cboMedio As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeña As System.Windows.Forms.Label
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents MediosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediosTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.MediosTableAdapter
    Friend WithEvents TipoEnvioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoEnvioTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.TipoEnvioTableAdapter
    Friend WithEvents txtTotal As CapaPresentacion.ValidacionMoneda
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnEnvioGuardado As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboDesc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents btnGuardarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents chkEnvio As System.Windows.Forms.CheckBox
    Friend WithEvents txtClienteNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents txtSubTotal As CapaPresentacion.ValidacionMoneda
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmarPedido As Button
    Friend WithEvents txtAnticipoSena As TextBox
    Friend WithEvents txtSymbol As TextBox
    Friend WithEvents required As Label
    Friend WithEvents lblResponsable As Label
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents pnlData As Panel
    Friend WithEvents txtIdPresupuesto As TextBox
    Friend WithEvents btnBuscarPresupuesto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlBuscarPresupuesto As Panel
    Friend WithEvents lblID As Label
    Friend WithEvents cboResponsable As ComboBox
    Friend WithEvents UsuariosTableAdapter1 As SolemnoDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
End Class
