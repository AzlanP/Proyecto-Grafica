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
        Me.lblPrecioAgrProd = New System.Windows.Forms.Label()
        Me.lblCantidadAgrProd = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.DGBuscar = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDesc = New System.Windows.Forms.ComboBox()
        Me.txtPrecioTotal = New CapaPresentacion.ValidacionMoneda()
        Me.txtboxPrecio = New CapaPresentacion.ValidacionMoneda()
        Me.required = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelBusqueda = New System.Windows.Forms.Panel()
        CType(Me.DGBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(132, 325)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(103, 24)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Location = New System.Drawing.Point(27, 325)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 24)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'TextboxDescripcion
        '
        Me.TextboxDescripcion.Location = New System.Drawing.Point(24, 223)
        Me.TextboxDescripcion.MaxLength = 30000
        Me.TextboxDescripcion.Multiline = True
        Me.TextboxDescripcion.Name = "TextboxDescripcion"
        Me.TextboxDescripcion.Size = New System.Drawing.Size(211, 81)
        Me.TextboxDescripcion.TabIndex = 18
        Me.TextboxDescripcion.Tag = ""
        '
        'lblDescripcionAgrProd
        '
        Me.lblDescripcionAgrProd.AutoSize = True
        Me.lblDescripcionAgrProd.Location = New System.Drawing.Point(28, 207)
        Me.lblDescripcionAgrProd.Name = "lblDescripcionAgrProd"
        Me.lblDescripcionAgrProd.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcionAgrProd.TabIndex = 17
        Me.lblDescripcionAgrProd.Text = "Descripcion:"
        '
        'lblPrecioAgrProd
        '
        Me.lblPrecioAgrProd.AutoSize = True
        Me.lblPrecioAgrProd.Location = New System.Drawing.Point(23, 102)
        Me.lblPrecioAgrProd.Name = "lblPrecioAgrProd"
        Me.lblPrecioAgrProd.Size = New System.Drawing.Size(79, 13)
        Me.lblPrecioAgrProd.TabIndex = 15
        Me.lblPrecioAgrProd.Text = "Precio Unitario:"
        '
        'lblCantidadAgrProd
        '
        Me.lblCantidadAgrProd.AutoSize = True
        Me.lblCantidadAgrProd.Location = New System.Drawing.Point(24, 63)
        Me.lblCantidadAgrProd.Name = "lblCantidadAgrProd"
        Me.lblCantidadAgrProd.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidadAgrProd.TabIndex = 13
        Me.lblCantidadAgrProd.Text = "Cantidad:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(22, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(26, 79)
        Me.txtCantidad.MaxLength = 6
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidad.TabIndex = 21
        Me.txtCantidad.Tag = "2"
        Me.txtCantidad.Text = "0"
        '
        'DGBuscar
        '
        Me.DGBuscar.AllowUserToAddRows = False
        Me.DGBuscar.AllowUserToDeleteRows = False
        Me.DGBuscar.AllowUserToResizeColumns = False
        Me.DGBuscar.AllowUserToResizeRows = False
        Me.DGBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGBuscar.BackgroundColor = System.Drawing.Color.White
        Me.DGBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBuscar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGBuscar.Location = New System.Drawing.Point(13, 48)
        Me.DGBuscar.MultiSelect = False
        Me.DGBuscar.Name = "DGBuscar"
        Me.DGBuscar.ReadOnly = True
        Me.DGBuscar.RowHeadersVisible = False
        Me.DGBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBuscar.Size = New System.Drawing.Size(296, 267)
        Me.DGBuscar.TabIndex = 22
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(13, 14)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(228, 20)
        Me.txtBuscar.TabIndex = 23
        Me.txtBuscar.Tag = "3"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(247, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 24)
        Me.btnBuscar.TabIndex = 24
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(41, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 25
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(25, 40)
        Me.txtNombreProducto.MaxLength = 50
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(210, 20)
        Me.txtNombreProducto.TabIndex = 27
        Me.txtNombreProducto.Tag = "3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Importe:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "% Desc."
        '
        'cboDesc
        '
        Me.cboDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesc.FormattingEnabled = True
        Me.cboDesc.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30"})
        Me.cboDesc.Location = New System.Drawing.Point(119, 79)
        Me.cboDesc.Name = "cboDesc"
        Me.cboDesc.Size = New System.Drawing.Size(70, 21)
        Me.cboDesc.TabIndex = 32
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.AutoSize = True
        Me.txtPrecioTotal.Enabled = False
        Me.txtPrecioTotal.labeltext = Nothing
        Me.txtPrecioTotal.Location = New System.Drawing.Point(24, 173)
        Me.txtPrecioTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.Size = New System.Drawing.Size(78, 22)
        Me.txtPrecioTotal.TabIndex = 29
        Me.txtPrecioTotal.valor = 0.0R
        '
        'txtboxPrecio
        '
        Me.txtboxPrecio.AutoSize = True
        Me.txtboxPrecio.Enabled = False
        Me.txtboxPrecio.labeltext = Nothing
        Me.txtboxPrecio.Location = New System.Drawing.Point(24, 120)
        Me.txtboxPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.txtboxPrecio.Name = "txtboxPrecio"
        Me.txtboxPrecio.Size = New System.Drawing.Size(78, 22)
        Me.txtboxPrecio.TabIndex = 26
        Me.txtboxPrecio.valor = 0.0R
        '
        'required
        '
        Me.required.AutoSize = True
        Me.required.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.required.ForeColor = System.Drawing.Color.Red
        Me.required.Location = New System.Drawing.Point(9, 22)
        Me.required.Margin = New System.Windows.Forms.Padding(0)
        Me.required.Name = "required"
        Me.required.Size = New System.Drawing.Size(15, 20)
        Me.required.TabIndex = 37
        Me.required.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "*"
        '
        'PanelBusqueda
        '
        Me.PanelBusqueda.Controls.Add(Me.txtBuscar)
        Me.PanelBusqueda.Controls.Add(Me.DGBuscar)
        Me.PanelBusqueda.Controls.Add(Me.btnBuscar)
        Me.PanelBusqueda.Location = New System.Drawing.Point(247, 9)
        Me.PanelBusqueda.Name = "PanelBusqueda"
        Me.PanelBusqueda.Size = New System.Drawing.Size(325, 318)
        Me.PanelBusqueda.TabIndex = 39
        '
        'AgregarProductoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.PanelBusqueda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.required)
        Me.Controls.Add(Me.cboDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecioTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.txtboxPrecio)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.TextboxDescripcion)
        Me.Controls.Add(Me.lblDescripcionAgrProd)
        Me.Controls.Add(Me.lblPrecioAgrProd)
        Me.Controls.Add(Me.lblCantidadAgrProd)
        Me.Controls.Add(Me.lblNombre)
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.MinimumSize = New System.Drawing.Size(275, 400)
        Me.Name = "AgregarProductoPedido"
        Me.Text = "Agregar Al Pedido"
        CType(Me.DGBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBusqueda.ResumeLayout(False)
        Me.PanelBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents TextboxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcionAgrProd As System.Windows.Forms.Label
    Friend WithEvents lblPrecioAgrProd As System.Windows.Forms.Label
    Friend WithEvents lblCantidadAgrProd As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents DGBuscar As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtboxPrecio As CapaPresentacion.ValidacionMoneda
    Friend WithEvents txtNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioTotal As CapaPresentacion.ValidacionMoneda
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDesc As System.Windows.Forms.ComboBox
    Friend WithEvents required As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelBusqueda As Panel
End Class
