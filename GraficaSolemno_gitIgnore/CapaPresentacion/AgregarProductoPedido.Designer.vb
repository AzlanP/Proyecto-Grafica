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
        Me.CboCantidad = New System.Windows.Forms.ComboBox()
        Me.lblCantidadAgrProd = New System.Windows.Forms.Label()
        Me.lblProductoAgrProd = New System.Windows.Forms.Label()
        Me.CboProducto = New System.Windows.Forms.ComboBox()
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
        Me.TextboxDescripcion.Location = New System.Drawing.Point(26, 201)
        Me.TextboxDescripcion.Name = "TextboxDescripcion"
        Me.TextboxDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.TextboxDescripcion.TabIndex = 18
        '
        'lblDescripcionAgrProd
        '
        Me.lblDescripcionAgrProd.AutoSize = True
        Me.lblDescripcionAgrProd.Location = New System.Drawing.Point(23, 185)
        Me.lblDescripcionAgrProd.Name = "lblDescripcionAgrProd"
        Me.lblDescripcionAgrProd.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcionAgrProd.TabIndex = 17
        Me.lblDescripcionAgrProd.Text = "Descripcion"
        '
        'txtboxPrecio
        '
        Me.txtboxPrecio.Location = New System.Drawing.Point(26, 149)
        Me.txtboxPrecio.Name = "txtboxPrecio"
        Me.txtboxPrecio.Size = New System.Drawing.Size(70, 20)
        Me.txtboxPrecio.TabIndex = 16
        '
        'lblPrecioAgrProd
        '
        Me.lblPrecioAgrProd.AutoSize = True
        Me.lblPrecioAgrProd.Location = New System.Drawing.Point(24, 133)
        Me.lblPrecioAgrProd.Name = "lblPrecioAgrProd"
        Me.lblPrecioAgrProd.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecioAgrProd.TabIndex = 15
        Me.lblPrecioAgrProd.Text = "Precio"
        '
        'CboCantidad
        '
        Me.CboCantidad.FormattingEnabled = True
        Me.CboCantidad.Location = New System.Drawing.Point(27, 92)
        Me.CboCantidad.Name = "CboCantidad"
        Me.CboCantidad.Size = New System.Drawing.Size(69, 21)
        Me.CboCantidad.TabIndex = 14
        '
        'lblCantidadAgrProd
        '
        Me.lblCantidadAgrProd.AutoSize = True
        Me.lblCantidadAgrProd.Location = New System.Drawing.Point(24, 76)
        Me.lblCantidadAgrProd.Name = "lblCantidadAgrProd"
        Me.lblCantidadAgrProd.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidadAgrProd.TabIndex = 13
        Me.lblCantidadAgrProd.Text = "Cantidad"
        '
        'lblProductoAgrProd
        '
        Me.lblProductoAgrProd.AutoSize = True
        Me.lblProductoAgrProd.Location = New System.Drawing.Point(24, 22)
        Me.lblProductoAgrProd.Name = "lblProductoAgrProd"
        Me.lblProductoAgrProd.Size = New System.Drawing.Size(50, 13)
        Me.lblProductoAgrProd.TabIndex = 12
        Me.lblProductoAgrProd.Text = "Producto"
        '
        'CboProducto
        '
        Me.CboProducto.FormattingEnabled = True
        Me.CboProducto.Location = New System.Drawing.Point(27, 38)
        Me.CboProducto.Name = "CboProducto"
        Me.CboProducto.Size = New System.Drawing.Size(212, 21)
        Me.CboProducto.TabIndex = 11
        '
        'AgregarProductoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 323)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.TextboxDescripcion)
        Me.Controls.Add(Me.lblDescripcionAgrProd)
        Me.Controls.Add(Me.txtboxPrecio)
        Me.Controls.Add(Me.lblPrecioAgrProd)
        Me.Controls.Add(Me.CboCantidad)
        Me.Controls.Add(Me.lblCantidadAgrProd)
        Me.Controls.Add(Me.lblProductoAgrProd)
        Me.Controls.Add(Me.CboProducto)
        Me.Name = "AgregarProductoPedido"
        Me.Text = "AgregarProductoPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents TextboxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcionAgrProd As System.Windows.Forms.Label
    Friend WithEvents txtboxPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioAgrProd As System.Windows.Forms.Label
    Friend WithEvents CboCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidadAgrProd As System.Windows.Forms.Label
    Friend WithEvents lblProductoAgrProd As System.Windows.Forms.Label
    Friend WithEvents CboProducto As System.Windows.Forms.ComboBox
End Class
