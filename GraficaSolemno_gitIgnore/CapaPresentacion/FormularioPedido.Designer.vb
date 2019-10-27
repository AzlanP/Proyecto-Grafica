<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPedido))
        Me.lblTipoEnvio = New System.Windows.Forms.Label()
        Me.cboTipoEnvio = New System.Windows.Forms.ComboBox()
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnTipoEnvioNuevo = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblMedio = New System.Windows.Forms.Label()
        Me.cboMedio = New System.Windows.Forms.ComboBox()
        Me.MediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSeña = New System.Windows.Forms.Label()
        Me.btnAgregarPedidoExistente = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ClientesTableAdapter()
        Me.MediosTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.MediosTableAdapter()
        Me.TipoEnvioTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.TipoEnvioTableAdapter()
        Me.ValidacionMoneda1 = New CapaPresentacion.ValidacionMoneda()
        Me.txtTotal = New CapaPresentacion.ValidacionMoneda()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnEnvioGuardado = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboDesc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TipoEnvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGListaDePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoEnvio
        '
        Me.lblTipoEnvio.AutoSize = True
        Me.lblTipoEnvio.Location = New System.Drawing.Point(346, 353)
        Me.lblTipoEnvio.Name = "lblTipoEnvio"
        Me.lblTipoEnvio.Size = New System.Drawing.Size(72, 13)
        Me.lblTipoEnvio.TabIndex = 33
        Me.lblTipoEnvio.Text = "Tipo de envio"
        '
        'cboTipoEnvio
        '
        Me.cboTipoEnvio.DataSource = Me.TipoEnvioBindingSource
        Me.cboTipoEnvio.DisplayMember = "Nombre"
        Me.cboTipoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoEnvio.FormattingEnabled = True
        Me.cboTipoEnvio.Location = New System.Drawing.Point(346, 369)
        Me.cboTipoEnvio.Name = "cboTipoEnvio"
        Me.cboTipoEnvio.Size = New System.Drawing.Size(90, 21)
        Me.cboTipoEnvio.TabIndex = 32
        Me.cboTipoEnvio.ValueMember = "IDTipoEnvio"
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
        Me.btnCancelarPedido.Location = New System.Drawing.Point(613, 389)
        Me.btnCancelarPedido.Name = "btnCancelarPedido"
        Me.btnCancelarPedido.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelarPedido.TabIndex = 31
        Me.btnCancelarPedido.Text = "Cancelar"
        Me.btnCancelarPedido.UseVisualStyleBackColor = False
        '
        'btnGuardarPedido
        '
        Me.btnGuardarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPedido.Location = New System.Drawing.Point(513, 389)
        Me.btnGuardarPedido.Name = "btnGuardarPedido"
        Me.btnGuardarPedido.Size = New System.Drawing.Size(94, 26)
        Me.btnGuardarPedido.TabIndex = 30
        Me.btnGuardarPedido.Text = "Cargar Nuevo"
        Me.btnGuardarPedido.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 350)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(295, 81)
        Me.txtDescripcion.TabIndex = 29
        Me.txtDescripcion.Tag = "3"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(75, 71)
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
        Me.cboCliente.Location = New System.Drawing.Point(75, 38)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCliente.TabIndex = 27
        Me.cboCliente.ValueMember = "IDCliente"
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
        Me.btnModificarPedido.Location = New System.Drawing.Point(593, 192)
        Me.btnModificarPedido.Name = "btnModificarPedido"
        Me.btnModificarPedido.Size = New System.Drawing.Size(81, 22)
        Me.btnModificarPedido.TabIndex = 25
        Me.btnModificarPedido.Text = "Modificar"
        Me.btnModificarPedido.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(593, 164)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(81, 22)
        Me.btnQuitar.TabIndex = 24
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregarPedidoNuevo
        '
        Me.btnAgregarPedidoNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarPedidoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPedidoNuevo.Location = New System.Drawing.Point(593, 120)
        Me.btnAgregarPedidoNuevo.Name = "btnAgregarPedidoNuevo"
        Me.btnAgregarPedidoNuevo.Size = New System.Drawing.Size(81, 38)
        Me.btnAgregarPedidoNuevo.TabIndex = 23
        Me.btnAgregarPedidoNuevo.Text = "Agregar a pedido"
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
        Me.DGListaDePedido.Location = New System.Drawing.Point(12, 120)
        Me.DGListaDePedido.MultiSelect = False
        Me.DGListaDePedido.Name = "DGListaDePedido"
        Me.DGListaDePedido.ReadOnly = True
        Me.DGListaDePedido.RowHeadersVisible = False
        Me.DGListaDePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGListaDePedido.Size = New System.Drawing.Size(575, 174)
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
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(20, 14)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID:"
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
        Me.lblFecha.Location = New System.Drawing.Point(20, 77)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 18
        Me.lblFecha.Text = "Fecha"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(24, 38)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 17
        Me.lblCliente.Text = "Cliente"
        '
        'btnTipoEnvioNuevo
        '
        Me.btnTipoEnvioNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTipoEnvioNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoEnvioNuevo.Location = New System.Drawing.Point(346, 397)
        Me.btnTipoEnvioNuevo.Name = "btnTipoEnvioNuevo"
        Me.btnTipoEnvioNuevo.Size = New System.Drawing.Size(104, 25)
        Me.btnTipoEnvioNuevo.TabIndex = 34
        Me.btnTipoEnvioNuevo.Text = "envio Nuevo"
        Me.btnTipoEnvioNuevo.UseVisualStyleBackColor = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(414, 72)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 36
        Me.lblEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Pendiente", "Completado"})
        Me.cboEstado.Location = New System.Drawing.Point(463, 70)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(108, 21)
        Me.cboEstado.TabIndex = 35
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(335, 41)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(123, 13)
        Me.lblMedio.TabIndex = 38
        Me.lblMedio.Text = "Medio De Comunicacion"
        '
        'cboMedio
        '
        Me.cboMedio.DataSource = Me.MediosBindingSource
        Me.cboMedio.DisplayMember = "Nombre"
        Me.cboMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedio.FormattingEnabled = True
        Me.cboMedio.Location = New System.Drawing.Point(464, 38)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(107, 21)
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
        Me.lblSeña.Location = New System.Drawing.Point(20, 303)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(41, 13)
        Me.lblSeña.TabIndex = 39
        Me.lblSeña.Text = "Seña : "
        '
        'btnAgregarPedidoExistente
        '
        Me.btnAgregarPedidoExistente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarPedidoExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPedidoExistente.Location = New System.Drawing.Point(593, 120)
        Me.btnAgregarPedidoExistente.Name = "btnAgregarPedidoExistente"
        Me.btnAgregarPedidoExistente.Size = New System.Drawing.Size(81, 38)
        Me.btnAgregarPedidoExistente.TabIndex = 41
        Me.btnAgregarPedidoExistente.Text = "Agregar a pedido"
        Me.btnAgregarPedidoExistente.UseVisualStyleBackColor = False
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCambios.Location = New System.Drawing.Point(513, 389)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(94, 26)
        Me.btnGuardarCambios.TabIndex = 42
        Me.btnGuardarCambios.Text = "Cargar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
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
        'ValidacionMoneda1
        '
        Me.ValidacionMoneda1.labeltext = Nothing
        Me.ValidacionMoneda1.Location = New System.Drawing.Point(67, 297)
        Me.ValidacionMoneda1.Name = "ValidacionMoneda1"
        Me.ValidacionMoneda1.Size = New System.Drawing.Size(123, 27)
        Me.ValidacionMoneda1.TabIndex = 43
        Me.ValidacionMoneda1.valor = 0.0R
        '
        'txtTotal
        '
        Me.txtTotal.labeltext = Nothing
        Me.txtTotal.Location = New System.Drawing.Point(482, 297)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(117, 27)
        Me.txtTotal.TabIndex = 45
        Me.txtTotal.valor = 0.0R
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(442, 303)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 44
        Me.lblTotal.Text = "Total:"
        '
        'btnEnvioGuardado
        '
        Me.btnEnvioGuardado.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnvioGuardado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnvioGuardado.Location = New System.Drawing.Point(346, 322)
        Me.btnEnvioGuardado.Name = "btnEnvioGuardado"
        Me.btnEnvioGuardado.Size = New System.Drawing.Size(104, 25)
        Me.btnEnvioGuardado.TabIndex = 46
        Me.btnEnvioGuardado.Text = "envio guardado"
        Me.btnEnvioGuardado.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(211, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(38, 40)
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
        Me.btnAdd.Location = New System.Drawing.Point(255, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 30)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboDesc
        '
        Me.cboDesc.DisplayMember = "0"
        Me.cboDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesc.FormattingEnabled = True
        Me.cboDesc.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30"})
        Me.cboDesc.Location = New System.Drawing.Point(196, 300)
        Me.cboDesc.Name = "cboDesc"
        Me.cboDesc.Size = New System.Drawing.Size(70, 21)
        Me.cboDesc.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "% Desc."
        '
        'FormularioPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 443)
        Me.Controls.Add(Me.cboDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEnvioGuardado)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.ValidacionMoneda1)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.btnAgregarPedidoExistente)
        Me.Controls.Add(Me.lblSeña)
        Me.Controls.Add(Me.lblMedio)
        Me.Controls.Add(Me.cboMedio)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.btnTipoEnvioNuevo)
        Me.Controls.Add(Me.lblTipoEnvio)
        Me.Controls.Add(Me.cboTipoEnvio)
        Me.Controls.Add(Me.btnCancelarPedido)
        Me.Controls.Add(Me.btnGuardarPedido)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.btnModificarPedido)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregarPedidoNuevo)
        Me.Controls.Add(Me.DGListaDePedido)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCliente)
        Me.Name = "FormularioPedido"
        Me.Text = "Detalles del Pedido"
        CType(Me.TipoEnvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGListaDePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoEnvio As System.Windows.Forms.Label
    Friend WithEvents cboTipoEnvio As System.Windows.Forms.ComboBox
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
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnTipoEnvioNuevo As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents cboMedio As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeña As System.Windows.Forms.Label
    Friend WithEvents btnAgregarPedidoExistente As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents MediosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediosTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.MediosTableAdapter
    Friend WithEvents TipoEnvioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoEnvioTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.TipoEnvioTableAdapter
    Friend WithEvents ValidacionMoneda1 As CapaPresentacion.ValidacionMoneda
    Friend WithEvents txtTotal As CapaPresentacion.ValidacionMoneda
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnEnvioGuardado As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboDesc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
