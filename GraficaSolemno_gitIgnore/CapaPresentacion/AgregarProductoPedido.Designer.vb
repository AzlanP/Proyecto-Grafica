<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProductoPedido
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.TextboxDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcionAgrProd = New System.Windows.Forms.Label()
        Me.txtboxPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecioAgrProd = New System.Windows.Forms.Label()
        Me.lblCantidadAgrProd = New System.Windows.Forms.Label()
        Me.lblProductoAgrProd = New System.Windows.Forms.Label()
        Me.CboProducto = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.DGBuscar = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.DGBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(163, 271)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 37)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Location = New System.Drawing.Point(49, 271)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 37)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'TextboxDescripcion
        '
        Me.TextboxDescripcion.Location = New System.Drawing.Point(40, 243)
        Me.TextboxDescripcion.Name = "TextboxDescripcion"
        Me.TextboxDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.TextboxDescripcion.TabIndex = 18
        '
        'lblDescripcionAgrProd
        '
        Me.lblDescripcionAgrProd.AutoSize = True
        Me.lblDescripcionAgrProd.Location = New System.Drawing.Point(37, 227)
        Me.lblDescripcionAgrProd.Name = "lblDescripcionAgrProd"
        Me.lblDescripcionAgrProd.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcionAgrProd.TabIndex = 17
        Me.lblDescripcionAgrProd.Text = "Descripcion"
        '
        'txtboxPrecio
        '
        Me.txtboxPrecio.Location = New System.Drawing.Point(40, 191)
        Me.txtboxPrecio.Name = "txtboxPrecio"
        Me.txtboxPrecio.Size = New System.Drawing.Size(70, 20)
        Me.txtboxPrecio.TabIndex = 16
        '
        'lblPrecioAgrProd
        '
        Me.lblPrecioAgrProd.AutoSize = True
        Me.lblPrecioAgrProd.Location = New System.Drawing.Point(38, 175)
        Me.lblPrecioAgrProd.Name = "lblPrecioAgrProd"
        Me.lblPrecioAgrProd.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecioAgrProd.TabIndex = 15
        Me.lblPrecioAgrProd.Text = "Precio"
        '
        'lblCantidadAgrProd
        '
        Me.lblCantidadAgrProd.AutoSize = True
        Me.lblCantidadAgrProd.Location = New System.Drawing.Point(38, 118)
        Me.lblCantidadAgrProd.Name = "lblCantidadAgrProd"
        Me.lblCantidadAgrProd.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidadAgrProd.TabIndex = 13
        Me.lblCantidadAgrProd.Text = "Cantidad"
        '
        'lblProductoAgrProd
        '
        Me.lblProductoAgrProd.AutoSize = True
        Me.lblProductoAgrProd.Location = New System.Drawing.Point(38, 64)
        Me.lblProductoAgrProd.Name = "lblProductoAgrProd"
        Me.lblProductoAgrProd.Size = New System.Drawing.Size(100, 13)
        Me.lblProductoAgrProd.TabIndex = 12
        Me.lblProductoAgrProd.Text = "Producto o Servicio"
        '
        'CboProducto
        '
        Me.CboProducto.FormattingEnabled = True
        Me.CboProducto.Location = New System.Drawing.Point(41, 80)
        Me.CboProducto.Name = "CboProducto"
        Me.CboProducto.Size = New System.Drawing.Size(212, 21)
        Me.CboProducto.TabIndex = 11
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(40, 134)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidad.TabIndex = 21
        '
        'DGBuscar
        '
        Me.DGBuscar.BackgroundColor = System.Drawing.Color.White
        Me.DGBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBuscar.Location = New System.Drawing.Point(294, 64)
        Me.DGBuscar.Name = "DGBuscar"
        Me.DGBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBuscar.Size = New System.Drawing.Size(259, 244)
        Me.DGBuscar.TabIndex = 22
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(294, 38)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(191, 20)
        Me.txtBuscar.TabIndex = 23
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(491, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 20)
        Me.btnBuscar.TabIndex = 24
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(38, 24)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(49, 13)
        Me.lblID.TabIndex = 25
        Me.lblID.Text = "Cantidad"
        '
        'AgregarProductoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 323)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DGBuscar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.TextboxDescripcion)
        Me.Controls.Add(Me.lblDescripcionAgrProd)
        Me.Controls.Add(Me.txtboxPrecio)
        Me.Controls.Add(Me.lblPrecioAgrProd)
        Me.Controls.Add(Me.lblCantidadAgrProd)
        Me.Controls.Add(Me.lblProductoAgrProd)
        Me.Controls.Add(Me.CboProducto)
        Me.Name = "AgregarProductoPedido"
        Me.Text = "Agregar Al Pedido"
        CType(Me.DGBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents TextboxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcionAgrProd As System.Windows.Forms.Label
    Friend WithEvents txtboxPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioAgrProd As System.Windows.Forms.Label
    Friend WithEvents lblCantidadAgrProd As System.Windows.Forms.Label
    Friend WithEvents lblProductoAgrProd As System.Windows.Forms.Label
    Friend WithEvents CboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents DGBuscar As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
