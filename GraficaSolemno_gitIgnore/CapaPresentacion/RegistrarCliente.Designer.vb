<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCliente
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIDinfo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbIVA = New System.Windows.Forms.ComboBox()
        Me.CondIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNumeracion = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProvinciasTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.CondIVATableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.CondIVATableAdapter()
        Me.required = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblDobleAster = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.CondIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "DNI :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "CUIT :"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(83, 101)
        Me.txtCuit.MaxLength = 14
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(203, 21)
        Me.txtCuit.TabIndex = 3
        Me.txtCuit.Tag = "3"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(418, 337)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 24)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        Me.btnGuardar.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(140, 64)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 15)
        Me.lblID.TabIndex = 114
        Me.lblID.Visible = False
        '
        'lblIDinfo
        '
        Me.lblIDinfo.AutoSize = True
        Me.lblIDinfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDinfo.Location = New System.Drawing.Point(12, 12)
        Me.lblIDinfo.Name = "lblIDinfo"
        Me.lblIDinfo.Size = New System.Drawing.Size(21, 15)
        Me.lblIDinfo.TabIndex = 113
        Me.lblIDinfo.Text = "ID:"
        Me.lblIDinfo.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(568, 337)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 24)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dpFecha
        '
        Me.dpFecha.Enabled = False
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(470, 12)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(203, 21)
        Me.dpFecha.TabIndex = 111
        Me.dpFecha.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'cbIVA
        '
        Me.cbIVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbIVA.DataSource = Me.CondIVABindingSource
        Me.cbIVA.DisplayMember = "Nombre"
        Me.cbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIVA.FormattingEnabled = True
        Me.cbIVA.Location = New System.Drawing.Point(467, 301)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(188, 23)
        Me.cbIVA.TabIndex = 5
        Me.cbIVA.ValueMember = "IDIVA"
        '
        'CondIVABindingSource
        '
        Me.CondIVABindingSource.DataMember = "CondIVA"
        Me.CondIVABindingSource.DataSource = Me.SolemnoDataSet
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Domicilio :"
        '
        'cboProvincia
        '
        Me.cboProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProvincia.DataSource = Me.ProvinciasBindingSource
        Me.cboProvincia.DisplayMember = "Nombre"
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(112, 28)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(205, 23)
        Me.cboProvincia.TabIndex = 9
        Me.cboProvincia.ValueMember = "IDProvincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.SolemnoDataSet
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(112, 99)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(203, 21)
        Me.txtCP.TabIndex = 11
        Me.txtCP.Tag = "3"
        '
        'txtNumeracion
        '
        Me.txtNumeracion.Location = New System.Drawing.Point(176, 196)
        Me.txtNumeracion.MaxLength = 10
        Me.txtNumeracion.Name = "txtNumeracion"
        Me.txtNumeracion.Size = New System.Drawing.Size(38, 21)
        Me.txtNumeracion.TabIndex = 14
        Me.txtNumeracion.Tag = "2"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(111, 162)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(205, 21)
        Me.txtCalle.TabIndex = 13
        Me.txtCalle.Tag = "3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(88, 199)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 15)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "Numeración :"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(112, 131)
        Me.txtBarrio.MaxLength = 25
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(203, 21)
        Me.txtBarrio.TabIndex = 12
        Me.txtBarrio.Tag = "3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(417, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 15)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Fecha :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(357, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 15)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Condicion de IVA :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Codigo Postal :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(58, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Barrio :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Apellido :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Nombre :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(83, 26)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 21)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Tag = "3"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(83, 134)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(203, 21)
        Me.txtDNI.TabIndex = 4
        Me.txtDNI.Tag = "3"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(84, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 21)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Tag = "4"
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(84, 66)
        Me.txtCel.MaxLength = 20
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(203, 21)
        Me.txtCel.TabIndex = 7
        Me.txtCel.Tag = "2"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(84, 32)
        Me.txtTel.MaxLength = 20
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(203, 21)
        Me.txtTel.TabIndex = 6
        Me.txtTel.Tag = "2"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(83, 60)
        Me.txtApellido.MaxLength = 20
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(203, 21)
        Me.txtApellido.TabIndex = 2
        Me.txtApellido.Tag = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Provincia :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Localidad :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "E-MAIL :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Telefono 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Teléfono :"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(418, 337)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(137, 24)
        Me.btnRegistrar.TabIndex = 18
        Me.btnRegistrar.Text = "Registrar Cliente"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtDpto
        '
        Me.txtDpto.Location = New System.Drawing.Point(269, 196)
        Me.txtDpto.MaxLength = 10
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(45, 21)
        Me.txtDpto.TabIndex = 15
        Me.txtDpto.Tag = "3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(224, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Dpto :"
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'cboLocalidad
        '
        Me.cboLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(111, 63)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(205, 23)
        Me.cboLocalidad.TabIndex = 10
        '
        'CondIVATableAdapter
        '
        Me.CondIVATableAdapter.ClearBeforeFill = True
        '
        'required
        '
        Me.required.AutoSize = True
        Me.required.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.required.ForeColor = System.Drawing.Color.Red
        Me.required.Location = New System.Drawing.Point(8, 28)
        Me.required.Margin = New System.Windows.Forms.Padding(0)
        Me.required.Name = "required"
        Me.required.Size = New System.Drawing.Size(15, 20)
        Me.required.TabIndex = 124
        Me.required.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(8, 63)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(4, 33)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(18, 102)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 20)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "**"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(27, 136)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 20)
        Me.Label20.TabIndex = 128
        Me.Label20.Text = "**"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(40, 13)
        Me.Label23.Margin = New System.Windows.Forms.Padding(0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 20)
        Me.Label23.TabIndex = 131
        Me.Label23.Text = "**"
        '
        'LblDobleAster
        '
        Me.LblDobleAster.AutoSize = True
        Me.LblDobleAster.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDobleAster.Location = New System.Drawing.Point(64, 13)
        Me.LblDobleAster.Name = "LblDobleAster"
        Me.LblDobleAster.Size = New System.Drawing.Size(141, 15)
        Me.LblDobleAster.TabIndex = 133
        Me.LblDobleAster.Text = "Requerido almenos uno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCuit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.required)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 171)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información personal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCel)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 139)
        Me.GroupBox2.TabIndex = 135
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de contacto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtBarrio)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtCalle)
        Me.GroupBox3.Controls.Add(Me.cboLocalidad)
        Me.GroupBox3.Controls.Add(Me.txtNumeracion)
        Me.GroupBox3.Controls.Add(Me.txtDpto)
        Me.GroupBox3.Controls.Add(Me.txtCP)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cboProvincia)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(341, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 236)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dirección"
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 381)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblDobleAster)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblIDinfo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dpFecha)
        Me.Controls.Add(Me.cbIVA)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(707, 420)
        Me.MinimumSize = New System.Drawing.Size(707, 420)
        Me.Name = "RegistrarCliente"
        Me.Text = "Registrar cliente"
        CType(Me.CondIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblIDinfo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbIVA As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeracion As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents CondIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CondIVATableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.CondIVATableAdapter
    Friend WithEvents required As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents LblDobleAster As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
