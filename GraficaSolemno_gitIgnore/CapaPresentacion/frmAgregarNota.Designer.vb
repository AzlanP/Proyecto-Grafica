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
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(81, 39)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(200, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(81, 82)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 110)
        Me.txtDescripcion.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(39, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo :"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 85)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(69, 13)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripcion :"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 205)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha :"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(77, 205)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'btnGuardarNota
        '
        Me.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNota.Location = New System.Drawing.Point(65, 307)
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
        Me.btnCancelar.Location = New System.Drawing.Point(156, 307)
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
        Me.btnEliminar.Location = New System.Drawing.Point(255, 307)
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
        Me.lblPrioridad.Location = New System.Drawing.Point(16, 259)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(54, 13)
        Me.lblPrioridad.TabIndex = 11
        Me.lblPrioridad.Text = "Prioridad :"
        '
        'cboPrioridad
        '
        Me.cboPrioridad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboPrioridad.FormattingEnabled = True
        Me.cboPrioridad.Items.AddRange(New Object() {"BAJA", "MEDIA", "ALTA", "URGENTE"})
        Me.cboPrioridad.Location = New System.Drawing.Point(76, 256)
        Me.cboPrioridad.Name = "cboPrioridad"
        Me.cboPrioridad.Size = New System.Drawing.Size(141, 21)
        Me.cboPrioridad.TabIndex = 12
        Me.cboPrioridad.Text = "BAJA"
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCambios.Location = New System.Drawing.Point(36, 307)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardarCambios.TabIndex = 13
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'frmAgregarNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 357)
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
    Protected WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblidpostick As System.Windows.Forms.Label
    Friend WithEvents lblPrioridad As System.Windows.Forms.Label
    Friend WithEvents cboPrioridad As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
End Class
