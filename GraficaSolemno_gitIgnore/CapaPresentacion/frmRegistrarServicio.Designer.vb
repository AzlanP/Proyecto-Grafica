<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarServicio
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
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarNuevo = New System.Windows.Forms.Button()
        Me.txtNombreServicio = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtIDServicio = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Location = New System.Drawing.Point(34, 171)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(102, 23)
        Me.btnGuardarCambios.TabIndex = 13
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(135, 200)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardarNuevo
        '
        Me.btnGuardarNuevo.Location = New System.Drawing.Point(34, 200)
        Me.btnGuardarNuevo.Name = "btnGuardarNuevo"
        Me.btnGuardarNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarNuevo.TabIndex = 11
        Me.btnGuardarNuevo.Text = "Registrar"
        Me.btnGuardarNuevo.UseVisualStyleBackColor = True
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.Location = New System.Drawing.Point(102, 80)
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.Size = New System.Drawing.Size(148, 20)
        Me.txtNombreServicio.TabIndex = 10
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(57, 83)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'txtIDServicio
        '
        Me.txtIDServicio.Location = New System.Drawing.Point(102, 38)
        Me.txtIDServicio.Name = "txtIDServicio"
        Me.txtIDServicio.Size = New System.Drawing.Size(148, 20)
        Me.txtIDServicio.TabIndex = 8
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(57, 41)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "lblID"
        '
        'frmRegistrarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardarNuevo)
        Me.Controls.Add(Me.txtNombreServicio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtIDServicio)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmRegistrarServicio"
        Me.Text = "frmRegistrarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardarNuevo As System.Windows.Forms.Button
    Friend WithEvents txtNombreServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtIDServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
