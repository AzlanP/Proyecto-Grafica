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
        Me.required = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTransporte = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelarFormEnvio
        '
        Me.btnCancelarFormEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelarFormEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarFormEnvio.Location = New System.Drawing.Point(221, 406)
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
        Me.btnGuardarNuevo.Location = New System.Drawing.Point(110, 406)
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
        Me.lblPrecio.Location = New System.Drawing.Point(761, 91)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(86, 13)
        Me.lblPrecio.TabIndex = 18
        Me.lblPrecio.Text = "Precio del envio:"
        '
        'txtNroSeguimiento
        '
        Me.txtNroSeguimiento.Location = New System.Drawing.Point(117, 100)
        Me.txtNroSeguimiento.MaxLength = 25
        Me.txtNroSeguimiento.Name = "txtNroSeguimiento"
        Me.txtNroSeguimiento.Size = New System.Drawing.Size(170, 20)
        Me.txtNroSeguimiento.TabIndex = 17
        Me.txtNroSeguimiento.Tag = ""
        '
        'lblNseguimiento
        '
        Me.lblNseguimiento.AutoSize = True
        Me.lblNseguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNseguimiento.Location = New System.Drawing.Point(28, 100)
        Me.lblNseguimiento.Name = "lblNseguimiento"
        Me.lblNseguimiento.Size = New System.Drawing.Size(83, 13)
        Me.lblNseguimiento.TabIndex = 16
        Me.lblNseguimiento.Text = "N° Seguimiento:"
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(117, 63)
        Me.dtpFechaDespacho.MinDate = New Date(2019, 11, 7, 0, 0, 0, 0)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(170, 20)
        Me.dtpFechaDespacho.TabIndex = 15
        '
        'lblFechaDespacho
        '
        Me.lblFechaDespacho.AutoSize = True
        Me.lblFechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDespacho.Location = New System.Drawing.Point(6, 68)
        Me.lblFechaDespacho.Name = "lblFechaDespacho"
        Me.lblFechaDespacho.Size = New System.Drawing.Size(105, 13)
        Me.lblFechaDespacho.TabIndex = 14
        Me.lblFechaDespacho.Text = "Fecha de despacho:"
        '
        'lblTransporte
        '
        Me.lblTransporte.AutoSize = True
        Me.lblTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransporte.Location = New System.Drawing.Point(47, 28)
        Me.lblTransporte.Name = "lblTransporte"
        Me.lblTransporte.Size = New System.Drawing.Size(64, 13)
        Me.lblTransporte.TabIndex = 12
        Me.lblTransporte.Text = "Transporte :"
        '
        'txtDpto
        '
        Me.txtDpto.Location = New System.Drawing.Point(125, 183)
        Me.txtDpto.MaxLength = 25
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(57, 20)
        Me.txtDpto.TabIndex = 136
        Me.txtDpto.Tag = ""
        '
        'lblDpto
        '
        Me.lblDpto.AutoSize = True
        Me.lblDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDpto.Location = New System.Drawing.Point(135, 165)
        Me.lblDpto.Name = "lblDpto"
        Me.lblDpto.Size = New System.Drawing.Size(36, 13)
        Me.lblDpto.TabIndex = 135
        Me.lblDpto.Text = "Dpto :"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(37, 126)
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
        Me.cboProvincia.Location = New System.Drawing.Point(98, 19)
        Me.cboProvincia.MaxLength = 25
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(170, 21)
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
        Me.txtDomicilio.Location = New System.Drawing.Point(98, 128)
        Me.txtDomicilio.MaxLength = 25
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(170, 20)
        Me.txtDomicilio.TabIndex = 131
        Me.txtDomicilio.Tag = ""
        '
        'txtNroCalle
        '
        Me.txtNroCalle.Location = New System.Drawing.Point(40, 183)
        Me.txtNroCalle.MaxLength = 25
        Me.txtNroCalle.Name = "txtNroCalle"
        Me.txtNroCalle.Size = New System.Drawing.Size(57, 20)
        Me.txtNroCalle.TabIndex = 130
        Me.txtNroCalle.Tag = "2"
        '
        'lblNumeroCalle
        '
        Me.lblNumeroCalle.AutoSize = True
        Me.lblNumeroCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCalle.Location = New System.Drawing.Point(30, 165)
        Me.lblNumeroCalle.Name = "lblNumeroCalle"
        Me.lblNumeroCalle.Size = New System.Drawing.Size(70, 13)
        Me.lblNumeroCalle.TabIndex = 129
        Me.lblNumeroCalle.Text = "Numeración :"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(98, 93)
        Me.txtBarrio.MaxLength = 25
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(170, 20)
        Me.txtBarrio.TabIndex = 128
        Me.txtBarrio.Tag = "3"
        '
        'lblBarrio
        '
        Me.lblBarrio.AutoSize = True
        Me.lblBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarrio.Location = New System.Drawing.Point(52, 91)
        Me.lblBarrio.Name = "lblBarrio"
        Me.lblBarrio.Size = New System.Drawing.Size(40, 13)
        Me.lblBarrio.TabIndex = 126
        Me.lblBarrio.Text = "Barrio :"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincia.Location = New System.Drawing.Point(35, 21)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(57, 13)
        Me.lblProvincia.TabIndex = 124
        Me.lblProvincia.Text = "Provincia :"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(33, 56)
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
        Me.cboLocalidad.Location = New System.Drawing.Point(98, 56)
        Me.cboLocalidad.MaxLength = 25
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(170, 21)
        Me.cboLocalidad.TabIndex = 137
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(215, 183)
        Me.txtCP.MaxLength = 25
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(57, 20)
        Me.txtCP.TabIndex = 138
        Me.txtCP.Tag = ""
        '
        'lblcp
        '
        Me.lblcp.AutoSize = True
        Me.lblcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcp.Location = New System.Drawing.Point(228, 165)
        Me.lblcp.Name = "lblcp"
        Me.lblcp.Size = New System.Drawing.Size(24, 13)
        Me.lblcp.TabIndex = 139
        Me.lblcp.Text = "CP:"
        '
        'ValidacionPrecio
        '
        Me.ValidacionPrecio.AutoSize = True
        Me.ValidacionPrecio.labeltext = Nothing
        Me.ValidacionPrecio.Location = New System.Drawing.Point(740, 116)
        Me.ValidacionPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.ValidacionPrecio.Name = "ValidacionPrecio"
        Me.ValidacionPrecio.Size = New System.Drawing.Size(131, 35)
        Me.ValidacionPrecio.TabIndex = 140
        Me.ValidacionPrecio.valor = 0R
        '
        'txtTransporte
        '
        Me.txtTransporte.Location = New System.Drawing.Point(117, 25)
        Me.txtTransporte.MaxLength = 25
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.Size = New System.Drawing.Size(55, 20)
        Me.txtTransporte.TabIndex = 141
        Me.txtTransporte.Tag = ""
        Me.txtTransporte.Visible = False
        '
        'required
        '
        Me.required.AutoSize = True
        Me.required.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.required.ForeColor = System.Drawing.Color.Red
        Me.required.Location = New System.Drawing.Point(29, 28)
        Me.required.Margin = New System.Windows.Forms.Padding(0)
        Me.required.Name = "required"
        Me.required.Size = New System.Drawing.Size(15, 20)
        Me.required.TabIndex = 146
        Me.required.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(19, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(18, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "*"
        '
        'cboTransporte
        '
        Me.cboTransporte.BackColor = System.Drawing.SystemColors.Window
        Me.cboTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransporte.FormattingEnabled = True
        Me.cboTransporte.Items.AddRange(New Object() {"Correo Argentino", "Correo OCA", "Andreani", "Via cargo", "Buspack", "Buses Lep", "Integral Express", "Crusero del Norte"})
        Me.cboTransporte.Location = New System.Drawing.Point(117, 25)
        Me.cboTransporte.Name = "cboTransporte"
        Me.cboTransporte.Size = New System.Drawing.Size(170, 21)
        Me.cboTransporte.TabIndex = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.required)
        Me.GroupBox1.Controls.Add(Me.cboTransporte)
        Me.GroupBox1.Controls.Add(Me.lblTransporte)
        Me.GroupBox1.Controls.Add(Me.lblFechaDespacho)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDespacho)
        Me.GroupBox1.Controls.Add(Me.lblNseguimiento)
        Me.GroupBox1.Controls.Add(Me.txtNroSeguimiento)
        Me.GroupBox1.Controls.Add(Me.txtTransporte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 149)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Transporte"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboProvincia)
        Me.GroupBox2.Controls.Add(Me.lblLocalidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblProvincia)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblBarrio)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtBarrio)
        Me.GroupBox2.Controls.Add(Me.lblNumeroCalle)
        Me.GroupBox2.Controls.Add(Me.lblcp)
        Me.GroupBox2.Controls.Add(Me.txtNroCalle)
        Me.GroupBox2.Controls.Add(Me.txtCP)
        Me.GroupBox2.Controls.Add(Me.txtDomicilio)
        Me.GroupBox2.Controls.Add(Me.cboLocalidad)
        Me.GroupBox2.Controls.Add(Me.lblDomicilio)
        Me.GroupBox2.Controls.Add(Me.txtDpto)
        Me.GroupBox2.Controls.Add(Me.lblDpto)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 226)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dirección de Envio"
        '
        'FormularioEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ValidacionPrecio)
        Me.Controls.Add(Me.btnCancelarFormEnvio)
        Me.Controls.Add(Me.btnGuardarNuevo)
        Me.Controls.Add(Me.lblPrecio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormularioEnvio"
        Me.Text = "FormularioEnvio"
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents required As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
