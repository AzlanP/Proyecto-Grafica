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
        Me.btnGuardarCambiosRegServ = New System.Windows.Forms.Button()
        Me.btnCancelarRegServ = New System.Windows.Forms.Button()
        Me.btnGuardarNuevoRegServ = New System.Windows.Forms.Button()
        Me.txtNombreServicio = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardarCambiosRegServ
        '
        Me.btnGuardarCambiosRegServ.Location = New System.Drawing.Point(89, 200)
        Me.btnGuardarCambiosRegServ.Name = "btnGuardarCambiosRegServ"
        Me.btnGuardarCambiosRegServ.Size = New System.Drawing.Size(102, 23)
        Me.btnGuardarCambiosRegServ.TabIndex = 13
        Me.btnGuardarCambiosRegServ.Text = "Guardar Cambios"
        Me.btnGuardarCambiosRegServ.UseVisualStyleBackColor = True
        '
        'btnCancelarRegServ
        '
        Me.btnCancelarRegServ.Location = New System.Drawing.Point(197, 200)
        Me.btnCancelarRegServ.Name = "btnCancelarRegServ"
        Me.btnCancelarRegServ.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarRegServ.TabIndex = 12
        Me.btnCancelarRegServ.Text = "Cancelar"
        Me.btnCancelarRegServ.UseVisualStyleBackColor = True
        '
        'btnGuardarNuevoRegServ
        '
        Me.btnGuardarNuevoRegServ.Location = New System.Drawing.Point(8, 200)
        Me.btnGuardarNuevoRegServ.Name = "btnGuardarNuevoRegServ"
        Me.btnGuardarNuevoRegServ.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarNuevoRegServ.TabIndex = 11
        Me.btnGuardarNuevoRegServ.Text = "Registrar"
        Me.btnGuardarNuevoRegServ.UseVisualStyleBackColor = True
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.Location = New System.Drawing.Point(92, 80)
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.Size = New System.Drawing.Size(148, 20)
        Me.txtNombreServicio.TabIndex = 10
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(31, 80)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(57, 42)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 7
        '
        'frmRegistrarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGuardarCambiosRegServ)
        Me.Controls.Add(Me.btnCancelarRegServ)
        Me.Controls.Add(Me.btnGuardarNuevoRegServ)
        Me.Controls.Add(Me.txtNombreServicio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmRegistrarServicio"
        Me.Text = "frmRegistrarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardarCambiosRegServ As System.Windows.Forms.Button
    Friend WithEvents btnCancelarRegServ As System.Windows.Forms.Button
    Friend WithEvents btnGuardarNuevoRegServ As System.Windows.Forms.Button
    Friend WithEvents txtNombreServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
