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
        Me.lblTipoEnvio = New System.Windows.Forms.Label()
        Me.cboTipoEnvio = New System.Windows.Forms.ComboBox()
        Me.btnCancelarPedido = New System.Windows.Forms.Button()
        Me.btnGuardarPedido = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.btnModificarPedido = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.DGListaDePedido = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnTipoEnvio = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblMedio = New System.Windows.Forms.Label()
        Me.cboMedio = New System.Windows.Forms.ComboBox()
        Me.btnAgregarServicio = New System.Windows.Forms.Button()
        CType(Me.DGListaDePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoEnvio
        '
        Me.lblTipoEnvio.AutoSize = True
        Me.lblTipoEnvio.Location = New System.Drawing.Point(17, 356)
        Me.lblTipoEnvio.Name = "lblTipoEnvio"
        Me.lblTipoEnvio.Size = New System.Drawing.Size(72, 13)
        Me.lblTipoEnvio.TabIndex = 33
        Me.lblTipoEnvio.Text = "Tipo de envio"
        '
        'cboTipoEnvio
        '
        Me.cboTipoEnvio.FormattingEnabled = True
        Me.cboTipoEnvio.Location = New System.Drawing.Point(98, 353)
        Me.cboTipoEnvio.Name = "cboTipoEnvio"
        Me.cboTipoEnvio.Size = New System.Drawing.Size(156, 21)
        Me.cboTipoEnvio.TabIndex = 32
        '
        'btnCancelarPedido
        '
        Me.btnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarPedido.Location = New System.Drawing.Point(482, 383)
        Me.btnCancelarPedido.Name = "btnCancelarPedido"
        Me.btnCancelarPedido.Size = New System.Drawing.Size(81, 34)
        Me.btnCancelarPedido.TabIndex = 31
        Me.btnCancelarPedido.Text = "Cancelar"
        Me.btnCancelarPedido.UseVisualStyleBackColor = False
        '
        'btnGuardarPedido
        '
        Me.btnGuardarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPedido.Location = New System.Drawing.Point(382, 383)
        Me.btnGuardarPedido.Name = "btnGuardarPedido"
        Me.btnGuardarPedido.Size = New System.Drawing.Size(81, 34)
        Me.btnGuardarPedido.TabIndex = 30
        Me.btnGuardarPedido.Text = "Cargar Pedido"
        Me.btnGuardarPedido.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(98, 312)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(108, 20)
        Me.txtDescripcion.TabIndex = 29
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(75, 71)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 28
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(75, 38)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCliente.TabIndex = 27
        '
        'btnModificarPedido
        '
        Me.btnModificarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPedido.Location = New System.Drawing.Point(469, 241)
        Me.btnModificarPedido.Name = "btnModificarPedido"
        Me.btnModificarPedido.Size = New System.Drawing.Size(81, 34)
        Me.btnModificarPedido.TabIndex = 25
        Me.btnModificarPedido.Text = "Modificar"
        Me.btnModificarPedido.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(469, 201)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(81, 34)
        Me.btnQuitar.TabIndex = 24
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Location = New System.Drawing.Point(469, 161)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(81, 34)
        Me.btnAgregarProducto.TabIndex = 23
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'DGListaDePedido
        '
        Me.DGListaDePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGListaDePedido.BackgroundColor = System.Drawing.Color.White
        Me.DGListaDePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaDePedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Precio, Me.Cantidad, Me.Descripcion})
        Me.DGListaDePedido.Location = New System.Drawing.Point(22, 120)
        Me.DGListaDePedido.Name = "DGListaDePedido"
        Me.DGListaDePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGListaDePedido.Size = New System.Drawing.Size(441, 174)
        Me.DGListaDePedido.TabIndex = 22
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
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
        Me.lblDescripcion.Location = New System.Drawing.Point(17, 312)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 19
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(19, 71)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 18
        Me.lblFecha.Text = "Fecha"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(20, 38)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 17
        Me.lblCliente.Text = "Cliente"
        '
        'btnTipoEnvio
        '
        Me.btnTipoEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTipoEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoEnvio.Location = New System.Drawing.Point(260, 353)
        Me.btnTipoEnvio.Name = "btnTipoEnvio"
        Me.btnTipoEnvio.Size = New System.Drawing.Size(75, 26)
        Me.btnTipoEnvio.TabIndex = 34
        Me.btnTipoEnvio.Text = "envio"
        Me.btnTipoEnvio.UseVisualStyleBackColor = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(40, 394)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 36
        Me.lblEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(98, 391)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(156, 21)
        Me.cboEstado.TabIndex = 35
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(253, 315)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(123, 13)
        Me.lblMedio.TabIndex = 38
        Me.lblMedio.Text = "Medio De Comunicacion"
        '
        'cboMedio
        '
        Me.cboMedio.FormattingEnabled = True
        Me.cboMedio.Location = New System.Drawing.Point(382, 309)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(156, 21)
        Me.cboMedio.TabIndex = 37
        '
        'btnAgregarServicio
        '
        Me.btnAgregarServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarServicio.Location = New System.Drawing.Point(469, 120)
        Me.btnAgregarServicio.Name = "btnAgregarServicio"
        Me.btnAgregarServicio.Size = New System.Drawing.Size(81, 34)
        Me.btnAgregarServicio.TabIndex = 39
        Me.btnAgregarServicio.Text = "Agregar Servicio"
        Me.btnAgregarServicio.UseVisualStyleBackColor = False
        '
        'FormularioPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 420)
        Me.Controls.Add(Me.btnAgregarServicio)
        Me.Controls.Add(Me.lblMedio)
        Me.Controls.Add(Me.cboMedio)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.btnTipoEnvio)
        Me.Controls.Add(Me.lblTipoEnvio)
        Me.Controls.Add(Me.cboTipoEnvio)
        Me.Controls.Add(Me.btnCancelarPedido)
        Me.Controls.Add(Me.btnGuardarPedido)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.btnModificarPedido)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.DGListaDePedido)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCliente)
        Me.Name = "FormularioPedido"
        Me.Text = "FormularioPedido"
        CType(Me.DGListaDePedido, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents DGListaDePedido As System.Windows.Forms.DataGridView
    Friend WithEvents lblDetalles As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnTipoEnvio As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents cboMedio As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarServicio As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
