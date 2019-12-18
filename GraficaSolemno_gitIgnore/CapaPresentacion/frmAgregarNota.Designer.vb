<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarNota
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
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardarNota = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.NroPostick = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblidpostick = New System.Windows.Forms.Label()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.cboPrioridad = New System.Windows.Forms.ComboBox()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.ckbCompletado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.UsuariosTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter()
        Me.required = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(100, 39)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(214, 20)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Tag = "3"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(100, 70)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(214, 110)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.Tag = "3"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(55, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(39, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo :"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(25, 73)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(69, 13)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripcion :"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(51, 190)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha :"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(100, 190)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(214, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'btnGuardarNota
        '
        Me.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNota.Location = New System.Drawing.Point(65, 339)
        Me.btnGuardarNota.Name = "btnGuardarNota"
        Me.btnGuardarNota.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarNota.TabIndex = 6
        Me.btnGuardarNota.Text = "Guardar"
        Me.btnGuardarNota.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(156, 339)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'NroPostick
        '
        Me.NroPostick.AutoSize = True
        Me.NroPostick.Location = New System.Drawing.Point(81, 9)
        Me.NroPostick.Name = "NroPostick"
        Me.NroPostick.Size = New System.Drawing.Size(59, 13)
        Me.NroPostick.TabIndex = 8
        Me.NroPostick.Text = "NroPostick"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(255, 339)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblidpostick
        '
        Me.lblidpostick.AutoSize = True
        Me.lblidpostick.Location = New System.Drawing.Point(12, 9)
        Me.lblidpostick.Name = "lblidpostick"
        Me.lblidpostick.Size = New System.Drawing.Size(62, 13)
        Me.lblidpostick.TabIndex = 10
        Me.lblidpostick.Text = "ID Postick :"
        '
        'lblPrioridad
        '
        Me.lblPrioridad.AutoSize = True
        Me.lblPrioridad.Location = New System.Drawing.Point(40, 239)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(54, 13)
        Me.lblPrioridad.TabIndex = 11
        Me.lblPrioridad.Text = "Prioridad :"
        '
        'cboPrioridad
        '
        Me.cboPrioridad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrioridad.FormattingEnabled = True
        Me.cboPrioridad.Items.AddRange(New Object() {"BAJA", "MEDIA", "ALTA", "URGENTE"})
        Me.cboPrioridad.Location = New System.Drawing.Point(100, 236)
        Me.cboPrioridad.Name = "cboPrioridad"
        Me.cboPrioridad.Size = New System.Drawing.Size(214, 21)
        Me.cboPrioridad.TabIndex = 12
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCambios.Location = New System.Drawing.Point(36, 339)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardarCambios.TabIndex = 13
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'ckbCompletado
        '
        Me.ckbCompletado.AutoSize = True
        Me.ckbCompletado.Location = New System.Drawing.Point(12, 303)
        Me.ckbCompletado.Name = "ckbCompletado"
        Me.ckbCompletado.Size = New System.Drawing.Size(113, 17)
        Me.ckbCompletado.TabIndex = 14
        Me.ckbCompletado.Text = "Tarea Completada"
        Me.ckbCompletado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Responsable:"
        '
        'cboResponsable
        '
        Me.cboResponsable.DataSource = Me.UsuariosBindingSource
        Me.cboResponsable.DisplayMember = "NombreCompleto"
        Me.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsable.FormattingEnabled = True
        Me.cboResponsable.Location = New System.Drawing.Point(100, 263)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(214, 21)
        Me.cboResponsable.TabIndex = 17
        Me.cboResponsable.ValueMember = "NombreCompleto"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SolemnoDataSetBindingSource
        '
        'SolemnoDataSetBindingSource
        '
        Me.SolemnoDataSetBindingSource.DataSource = Me.SolemnoDataSet
        Me.SolemnoDataSetBindingSource.Position = 0
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'required
        '
        Me.required.AutoSize = True
        Me.required.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.required.ForeColor = System.Drawing.Color.Red
        Me.required.Location = New System.Drawing.Point(39, 39)
        Me.required.Margin = New System.Windows.Forms.Padding(0)
        Me.required.Name = "required"
        Me.required.Size = New System.Drawing.Size(15, 20)
        Me.required.TabIndex = 36
        Me.required.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(11, 263)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "*"
        '
        'frmAgregarNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(348, 374)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.required)
        Me.Controls.Add(Me.cboResponsable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckbCompletado)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.cboPrioridad)
        Me.Controls.Add(Me.lblPrioridad)
        Me.Controls.Add(Me.lblidpostick)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.NroPostick)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardarNota)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtTitulo)
        Me.Name = "frmAgregarNota"
        Me.Text = "Posticks"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnGuardarNota As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents NroPostick As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblidpostick As System.Windows.Forms.Label
    Friend WithEvents lblPrioridad As System.Windows.Forms.Label
    Friend WithEvents cboPrioridad As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents ckbCompletado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboResponsable As System.Windows.Forms.ComboBox
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents SolemnoDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents required As Label
    Friend WithEvents Label2 As Label
    Public WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
End Class
