<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoPostick
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DGPostick = New System.Windows.Forms.DataGridView()
        Me.IDPostickDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrioridadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEliminadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminadoPorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PostickTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.PostickTableAdapter()
        Me.SearchDate = New System.Windows.Forms.DateTimePicker()
        Me.cboResponsables = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ClientesTableAdapter()
        Me.cboPrioridad = New System.Windows.Forms.ComboBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter()
        CType(Me.DGPostick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(1029, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(83, 21)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DGPostick
        '
        Me.DGPostick.AllowUserToAddRows = False
        Me.DGPostick.AllowUserToDeleteRows = False
        Me.DGPostick.AllowUserToResizeRows = False
        Me.DGPostick.AutoGenerateColumns = False
        Me.DGPostick.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGPostick.BackgroundColor = System.Drawing.Color.White
        Me.DGPostick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPostick.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPostickDataGridViewTextBoxColumn, Me.TituloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PrioridadDataGridViewTextBoxColumn, Me.ResponsableDataGridViewTextBoxColumn, Me.FechaEliminadoDataGridViewTextBoxColumn, Me.MotivoDataGridViewTextBoxColumn, Me.EliminadoPorDataGridViewTextBoxColumn})
        Me.DGPostick.DataSource = Me.PostickBindingSource
        Me.DGPostick.Location = New System.Drawing.Point(16, 45)
        Me.DGPostick.MultiSelect = False
        Me.DGPostick.Name = "DGPostick"
        Me.DGPostick.ReadOnly = True
        Me.DGPostick.RowHeadersVisible = False
        Me.DGPostick.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPostick.Size = New System.Drawing.Size(1096, 310)
        Me.DGPostick.TabIndex = 17
        '
        'IDPostickDataGridViewTextBoxColumn
        '
        Me.IDPostickDataGridViewTextBoxColumn.DataPropertyName = "IDPostick"
        Me.IDPostickDataGridViewTextBoxColumn.HeaderText = "IDPostick"
        Me.IDPostickDataGridViewTextBoxColumn.Name = "IDPostickDataGridViewTextBoxColumn"
        Me.IDPostickDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        Me.TituloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrioridadDataGridViewTextBoxColumn
        '
        Me.PrioridadDataGridViewTextBoxColumn.DataPropertyName = "Prioridad"
        Me.PrioridadDataGridViewTextBoxColumn.HeaderText = "Prioridad"
        Me.PrioridadDataGridViewTextBoxColumn.Name = "PrioridadDataGridViewTextBoxColumn"
        Me.PrioridadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResponsableDataGridViewTextBoxColumn
        '
        Me.ResponsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable"
        Me.ResponsableDataGridViewTextBoxColumn.HeaderText = "Responsable"
        Me.ResponsableDataGridViewTextBoxColumn.Name = "ResponsableDataGridViewTextBoxColumn"
        Me.ResponsableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEliminadoDataGridViewTextBoxColumn
        '
        Me.FechaEliminadoDataGridViewTextBoxColumn.DataPropertyName = "FechaEliminado"
        Me.FechaEliminadoDataGridViewTextBoxColumn.HeaderText = "FechaEliminado"
        Me.FechaEliminadoDataGridViewTextBoxColumn.Name = "FechaEliminadoDataGridViewTextBoxColumn"
        Me.FechaEliminadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotivoDataGridViewTextBoxColumn
        '
        Me.MotivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo"
        Me.MotivoDataGridViewTextBoxColumn.HeaderText = "Motivo"
        Me.MotivoDataGridViewTextBoxColumn.Name = "MotivoDataGridViewTextBoxColumn"
        Me.MotivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminadoPorDataGridViewTextBoxColumn
        '
        Me.EliminadoPorDataGridViewTextBoxColumn.DataPropertyName = "EliminadoPor"
        Me.EliminadoPorDataGridViewTextBoxColumn.HeaderText = "EliminadoPor"
        Me.EliminadoPorDataGridViewTextBoxColumn.Name = "EliminadoPorDataGridViewTextBoxColumn"
        Me.EliminadoPorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PostickBindingSource
        '
        Me.PostickBindingSource.DataMember = "Postick"
        Me.PostickBindingSource.DataSource = Me.SolemnoDataSet
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboBuscar
        '
        Me.cboBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Fecha", "Fecha de eliminacion", "Responsable", "Prioridad"})
        Me.cboBuscar.Location = New System.Drawing.Point(892, 18)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(131, 21)
        Me.cboBuscar.TabIndex = 14
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefresh.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.home
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(16, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(36, 30)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'PostickTableAdapter
        '
        Me.PostickTableAdapter.ClearBeforeFill = True
        '
        'SearchDate
        '
        Me.SearchDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SearchDate.Location = New System.Drawing.Point(776, 18)
        Me.SearchDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.SearchDate.Name = "SearchDate"
        Me.SearchDate.Size = New System.Drawing.Size(110, 20)
        Me.SearchDate.TabIndex = 51
        '
        'cboResponsables
        '
        Me.cboResponsables.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cboResponsables.DataSource = Me.UsuariosBindingSource
        Me.cboResponsables.DisplayMember = "NombreCompleto"
        Me.cboResponsables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsables.FormattingEnabled = True
        Me.cboResponsables.Location = New System.Drawing.Point(755, 17)
        Me.cboResponsables.Name = "cboResponsables"
        Me.cboResponsables.Size = New System.Drawing.Size(131, 21)
        Me.cboResponsables.TabIndex = 52
        Me.cboResponsables.ValueMember = "IDUsuario"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SolemnoDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'cboPrioridad
        '
        Me.cboPrioridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrioridad.FormattingEnabled = True
        Me.cboPrioridad.Items.AddRange(New Object() {"BAJA", "MEDIA", "ALTA", "URGENTE"})
        Me.cboPrioridad.Location = New System.Drawing.Point(755, 17)
        Me.cboPrioridad.Name = "cboPrioridad"
        Me.cboPrioridad.Size = New System.Drawing.Size(131, 21)
        Me.cboPrioridad.TabIndex = 53
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SolemnoDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'ListadoPostick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1124, 379)
        Me.Controls.Add(Me.cboPrioridad)
        Me.Controls.Add(Me.cboResponsables)
        Me.Controls.Add(Me.SearchDate)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DGPostick)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cboBuscar)
        Me.Name = "ListadoPostick"
        Me.Text = "ListadoPostick"
        CType(Me.DGPostick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DGPostick As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cboBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents PostickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PostickTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.PostickTableAdapter
    Friend WithEvents IDPostickDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TituloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrioridadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponsableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEliminadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminadoPorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboResponsables As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents cboPrioridad As System.Windows.Forms.ComboBox
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.UsuariosTableAdapter
End Class
