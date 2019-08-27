<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioEnvio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioEnvio))
        Me.btnCancelarFormEnvio = New System.Windows.Forms.Button()
        Me.btnGuardarNuevo = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtNroSeguimiento = New System.Windows.Forms.TextBox()
        Me.lblNseguimiento = New System.Windows.Forms.Label()
        Me.dtpFechaDespacho = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDespacho = New System.Windows.Forms.Label()
        Me.lblTransporte = New System.Windows.Forms.Label()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.lblDpto = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtNroCalle = New System.Windows.Forms.TextBox()
        Me.lblNumeroCalle = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.lblBarrio = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.ProvinciasTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lblcp = New System.Windows.Forms.Label()
        Me.ValidacionPrecio = New CapaPresentacion.ValidacionMoneda()
        Me.txtTransporte = New System.Windows.Forms.TextBox()
        Me.GuardarCambio = New System.Windows.Forms.Button()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarFormEnvio
        '
        Me.btnCancelarFormEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelarFormEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarFormEnvio.Location = New System.Drawing.Point(240, 394)
        Me.btnCancelarFormEnvio.Name = "btnCancelarFormEnvio"
        Me.btnCancelarFormEnvio.Size = New System.Drawing.Size(84, 27)
        Me.btnCancelarFormEnvio.TabIndex = 21
        Me.btnCancelarFormEnvio.Text = "Cancelar"
        Me.btnCancelarFormEnvio.UseVisualStyleBackColor = False
        '
        'btnGuardarNuevo
        '
        Me.btnGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNuevo.Location = New System.Drawing.Point(109, 394)
        Me.btnGuardarNuevo.Name = "btnGuardarNuevo"
        Me.btnGuardarNuevo.Size = New System.Drawing.Size(99, 27)
        Me.btnGuardarNuevo.TabIndex = 20
        Me.btnGuardarNuevo.Text = "Guardar Nuevo"
        Me.btnGuardarNuevo.UseVisualStyleBackColor = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(48, 126)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(86, 13)
        Me.lblPrecio.TabIndex = 18
        Me.lblPrecio.Text = "Precio del envio:"
        '
        'txtNroSeguimiento
        '
        Me.txtNroSeguimiento.Location = New System.Drawing.Point(154, 88)
        Me.txtNroSeguimiento.Name = "txtNroSeguimiento"
        Me.txtNroSeguimiento.Size = New System.Drawing.Size(170, 20)
        Me.txtNroSeguimiento.TabIndex = 17
        Me.txtNroSeguimiento.Tag = "3"
        '
        'lblNseguimiento
        '
        Me.lblNseguimiento.AutoSize = True
        Me.lblNseguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNseguimiento.Location = New System.Drawing.Point(48, 91)
        Me.lblNseguimiento.Name = "lblNseguimiento"
        Me.lblNseguimiento.Size = New System.Drawing.Size(80, 13)
        Me.lblNseguimiento.TabIndex = 16
        Me.lblNseguimiento.Text = "N° Seguimiento"
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(154, 51)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(170, 20)
        Me.dtpFechaDespacho.TabIndex = 15
        '
        'lblFechaDespacho
        '
        Me.lblFechaDespacho.AutoSize = True
        Me.lblFechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDespacho.Location = New System.Drawing.Point(48, 56)
        Me.lblFechaDespacho.Name = "lblFechaDespacho"
        Me.lblFechaDespacho.Size = New System.Drawing.Size(102, 13)
        Me.lblFechaDespacho.TabIndex = 14
        Me.lblFechaDespacho.Text = "Fecha de despacho"
        '
        'lblTransporte
        '
        Me.lblTransporte.AutoSize = True
        Me.lblTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransporte.Location = New System.Drawing.Point(48, 21)
        Me.lblTransporte.Name = "lblTransporte"
        Me.lblTransporte.Size = New System.Drawing.Size(64, 13)
        Me.lblTransporte.TabIndex = 12
        Me.lblTransporte.Text = "Transporte :"
        '
        'txtDpto
        '
        Me.txtDpto.Location = New System.Drawing.Point(136, 359)
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(57, 20)
        Me.txtDpto.TabIndex = 136
        Me.txtDpto.Tag = "3"
        '
        'lblDpto
        '
        Me.lblDpto.AutoSize = True
        Me.lblDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDpto.Location = New System.Drawing.Point(133, 341)
        Me.lblDpto.Name = "lblDpto"
        Me.lblDpto.Size = New System.Drawing.Size(36, 13)
        Me.lblDpto.TabIndex = 135
        Me.lblDpto.Text = "Dpto :"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(47, 301)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(55, 13)
        Me.lblDomicilio.TabIndex = 134
        Me.lblDomicilio.Text = "Domicilio :"
        '
        'cboProvincia
        '
        Me.cboProvincia.DataSource = Me.ProvinciasBindingSource
        Me.cboProvincia.DisplayMember = "Nombre"
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(153, 194)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(205, 21)
        Me.cboProvincia.TabIndex = 133
        Me.cboProvincia.ValueMember = "IDProvincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.SolemnoDataSet
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(154, 303)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(205, 20)
        Me.txtDomicilio.TabIndex = 131
        Me.txtDomicilio.Tag = "3"
        '
        'txtNroCalle
        '
        Me.txtNroCalle.Location = New System.Drawing.Point(51, 359)
        Me.txtNroCalle.Name = "txtNroCalle"
        Me.txtNroCalle.Size = New System.Drawing.Size(57, 20)
        Me.txtNroCalle.TabIndex = 130
        Me.txtNroCalle.Tag = "2"
        '
        'lblNumeroCalle
        '
        Me.lblNumeroCalle.AutoSize = True
        Me.lblNumeroCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCalle.Location = New System.Drawing.Point(48, 341)
        Me.lblNumeroCalle.Name = "lblNumeroCalle"
        Me.lblNumeroCalle.Size = New System.Drawing.Size(50, 13)
        Me.lblNumeroCalle.TabIndex = 129
        Me.lblNumeroCalle.Text = "Numero :"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(154, 268)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(205, 20)
        Me.txtBarrio.TabIndex = 128
        Me.txtBarrio.Tag = "3"
        '
        'lblBarrio
        '
        Me.lblBarrio.AutoSize = True
        Me.lblBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarrio.Location = New System.Drawing.Point(48, 266)
        Me.lblBarrio.Name = "lblBarrio"
        Me.lblBarrio.Size = New System.Drawing.Size(40, 13)
        Me.lblBarrio.TabIndex = 126
        Me.lblBarrio.Text = "Barrio :"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincia.Location = New System.Drawing.Point(48, 196)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(57, 13)
        Me.lblProvincia.TabIndex = 124
        Me.lblProvincia.Text = "Provincia :"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(48, 231)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(59, 13)
        Me.lblLocalidad.TabIndex = 123
        Me.lblLocalidad.Text = "Localidad :"
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'cboLocalidad
        '
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(153, 231)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(205, 21)
        Me.cboLocalidad.TabIndex = 137
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(226, 359)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(57, 20)
        Me.txtCP.TabIndex = 138
        Me.txtCP.Tag = "3"
        '
        'lblcp
        '
        Me.lblcp.AutoSize = True
        Me.lblcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcp.Location = New System.Drawing.Point(223, 341)
        Me.lblcp.Name = "lblcp"
        Me.lblcp.Size = New System.Drawing.Size(21, 13)
        Me.lblcp.TabIndex = 139
        Me.lblcp.Text = "CP"
        '
        'ValidacionPrecio
        '
        Me.ValidacionPrecio.labeltext = Nothing
        Me.ValidacionPrecio.Location = New System.Drawing.Point(149, 114)
        Me.ValidacionPrecio.Name = "ValidacionPrecio"
        Me.ValidacionPrecio.Size = New System.Drawing.Size(131, 35)
        Me.ValidacionPrecio.TabIndex = 140
        Me.ValidacionPrecio.valor = 0.0R
        '
        'txtTransporte
        '
        Me.txtTransporte.Location = New System.Drawing.Point(154, 14)
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.Size = New System.Drawing.Size(170, 20)
        Me.txtTransporte.TabIndex = 141
        Me.txtTransporte.Tag = "3"
        '
        'GuardarCambio
        '
        Me.GuardarCambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GuardarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarCambio.Location = New System.Drawing.Point(12, 394)
        Me.GuardarCambio.Name = "GuardarCambio"
        Me.GuardarCambio.Size = New System.Drawing.Size(93, 27)
        Me.GuardarCambio.TabIndex = 142
        Me.GuardarCambio.Text = "GuardarCambio"
        Me.GuardarCambio.UseVisualStyleBackColor = False
        '
        'FormularioEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 431)
        Me.Controls.Add(Me.GuardarCambio)
        Me.Controls.Add(Me.txtTransporte)
        Me.Controls.Add(Me.ValidacionPrecio)
        Me.Controls.Add(Me.lblcp)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.cboLocalidad)
        Me.Controls.Add(Me.txtDpto)
        Me.Controls.Add(Me.lblDpto)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtNroCalle)
        Me.Controls.Add(Me.lblNumeroCalle)
        Me.Controls.Add(Me.txtBarrio)
        Me.Controls.Add(Me.lblBarrio)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.btnCancelarFormEnvio)
        Me.Controls.Add(Me.btnGuardarNuevo)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtNroSeguimiento)
        Me.Controls.Add(Me.lblNseguimiento)
        Me.Controls.Add(Me.dtpFechaDespacho)
        Me.Controls.Add(Me.lblFechaDespacho)
        Me.Controls.Add(Me.lblTransporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormularioEnvio"
        Me.Text = "FormularioEnvio"
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelarFormEnvio As System.Windows.Forms.Button
    Friend WithEvents btnGuardarNuevo As System.Windows.Forms.Button
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents txtNroSeguimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblNseguimiento As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDespacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaDespacho As System.Windows.Forms.Label
    Friend WithEvents lblTransporte As System.Windows.Forms.Label
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents lblDpto As System.Windows.Forms.Label
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtNroCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroCalle As System.Windows.Forms.Label
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents lblBarrio As System.Windows.Forms.Label
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents lblcp As System.Windows.Forms.Label
    Friend WithEvents ValidacionPrecio As CapaPresentacion.ValidacionMoneda
    Friend WithEvents txtTransporte As System.Windows.Forms.TextBox
    Friend WithEvents GuardarCambio As System.Windows.Forms.Button
End Class
