﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cboPais = New System.Windows.Forms.ComboBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNumeracion = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProvinciasTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.CondIVATableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.CondIVATableAdapter()
        CType(Me.CondIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "DNI :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "CUIT :"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(140, 167)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(203, 21)
        Me.txtCuit.TabIndex = 116
        Me.txtCuit.Tag = "2"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(206, 386)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 33)
        Me.btnGuardar.TabIndex = 115
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
        '
        'lblIDinfo
        '
        Me.lblIDinfo.AutoSize = True
        Me.lblIDinfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDinfo.Location = New System.Drawing.Point(24, 64)
        Me.lblIDinfo.Name = "lblIDinfo"
        Me.lblIDinfo.Size = New System.Drawing.Size(21, 15)
        Me.lblIDinfo.TabIndex = 113
        Me.lblIDinfo.Text = "ID:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(386, 386)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(182, 33)
        Me.btnCancelar.TabIndex = 112
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(488, 12)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(203, 21)
        Me.dpFecha.TabIndex = 111
        Me.dpFecha.Value = New Date(2018, 5, 7, 22, 44, 48, 0)
        '
        'cbIVA
        '
        Me.cbIVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbIVA.DataSource = Me.CondIVABindingSource
        Me.cbIVA.DisplayMember = "Nombre"
        Me.cbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIVA.FormattingEnabled = True
        Me.cbIVA.Location = New System.Drawing.Point(140, 228)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(205, 23)
        Me.cbIVA.TabIndex = 110
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
        Me.Label1.Location = New System.Drawing.Point(383, 271)
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
        Me.cboProvincia.Location = New System.Drawing.Point(489, 130)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(205, 23)
        Me.cboProvincia.TabIndex = 106
        Me.cboProvincia.ValueMember = "IDProvincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.SolemnoDataSet
        '
        'cboPais
        '
        Me.cboPais.AutoCompleteCustomSource.AddRange(New String() {"Argentina", "Chile", "Bolivia", "Uruguay", "Paraguay"})
        Me.cboPais.FormattingEnabled = True
        Me.cboPais.Items.AddRange(New Object() {"Argentina", "Chile", "Bolivia", "Paraguay", "Uruguay", "Brasil"})
        Me.cboPais.Location = New System.Drawing.Point(489, 92)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Size = New System.Drawing.Size(205, 23)
        Me.cboPais.TabIndex = 105
        Me.cboPais.Text = "Argentina"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(489, 201)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(203, 21)
        Me.txtCP.TabIndex = 104
        Me.txtCP.Tag = "2"
        '
        'txtNumeracion
        '
        Me.txtNumeracion.Location = New System.Drawing.Point(553, 298)
        Me.txtNumeracion.Name = "txtNumeracion"
        Me.txtNumeracion.Size = New System.Drawing.Size(38, 21)
        Me.txtNumeracion.TabIndex = 103
        Me.txtNumeracion.Tag = "2"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(488, 264)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(205, 21)
        Me.txtCalle.TabIndex = 102
        Me.txtCalle.Tag = "3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(489, 304)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 15)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "Numero :"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(489, 233)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(203, 21)
        Me.txtBarrio.TabIndex = 100
        Me.txtBarrio.Tag = "3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(435, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 15)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Fecha :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 233)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 15)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Condicion de IVA :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(383, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Codigo Postal :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(383, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Barrio :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(383, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Pais :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Apellido :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Nombre :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(140, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 21)
        Me.txtNombre.TabIndex = 91
        Me.txtNombre.Tag = "3"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(140, 200)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(203, 21)
        Me.txtDNI.TabIndex = 90
        Me.txtDNI.Tag = "2"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(140, 332)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 21)
        Me.txtEmail.TabIndex = 89
        Me.txtEmail.Tag = "4"
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(140, 298)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(203, 21)
        Me.txtCel.TabIndex = 88
        Me.txtCel.Tag = "2"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(140, 264)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(203, 21)
        Me.txtTel.TabIndex = 87
        Me.txtTel.Tag = "2"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(140, 126)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(203, 21)
        Me.txtApellido.TabIndex = 86
        Me.txtApellido.Tag = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Provincia :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Localidad :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "E-MAIL :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Telefono 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 267)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(206, 386)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(137, 33)
        Me.btnRegistrar.TabIndex = 80
        Me.btnRegistrar.Text = "Registrar Cliente"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(646, 298)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(45, 21)
        Me.TextBox3.TabIndex = 122
        Me.TextBox3.Tag = "2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(607, 304)
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
        Me.cboLocalidad.Location = New System.Drawing.Point(488, 165)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(205, 23)
        Me.cboLocalidad.TabIndex = 123
        '
        'CondIVATableAdapter
        '
        Me.CondIVATableAdapter.ClearBeforeFill = True
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(712, 453)
        Me.Controls.Add(Me.cboLocalidad)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblIDinfo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dpFecha)
        Me.Controls.Add(Me.cbIVA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.cboPais)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtNumeracion)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBarrio)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RegistrarCliente"
        Me.Text = "Registrar Nuevo Cliente"
        CType(Me.CondIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboPais As System.Windows.Forms.ComboBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeracion As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ProvinciasTableAdapter
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents CondIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CondIVATableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.CondIVATableAdapter
End Class
