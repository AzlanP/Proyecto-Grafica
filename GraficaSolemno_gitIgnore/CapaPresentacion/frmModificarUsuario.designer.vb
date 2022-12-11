<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboCargo = New System.Windows.Forms.ComboBox()
        Me.chkMostrarContraseña = New System.Windows.Forms.CheckBox()
        Me.TxtNombreyApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuarioRegistro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraRegistrar = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(147, 286)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 24)
        Me.btnCerrar.TabIndex = 38
        Me.btnCerrar.Text = "Cancelar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Location = New System.Drawing.Point(52, 286)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(79, 24)
        Me.btnRegistrar.TabIndex = 37
        Me.btnRegistrar.Text = "Guardar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(36, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Cargo:"
        '
        'CboCargo
        '
        Me.CboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCargo.ForeColor = System.Drawing.Color.Black
        Me.CboCargo.FormattingEnabled = True
        Me.CboCargo.Items.AddRange(New Object() {"Administrador", "Vendedor"})
        Me.CboCargo.Location = New System.Drawing.Point(36, 119)
        Me.CboCargo.Name = "CboCargo"
        Me.CboCargo.Size = New System.Drawing.Size(202, 21)
        Me.CboCargo.TabIndex = 26
        '
        'chkMostrarContraseña
        '
        Me.chkMostrarContraseña.AutoSize = True
        Me.chkMostrarContraseña.ForeColor = System.Drawing.Color.Black
        Me.chkMostrarContraseña.Location = New System.Drawing.Point(36, 246)
        Me.chkMostrarContraseña.Name = "chkMostrarContraseña"
        Me.chkMostrarContraseña.Size = New System.Drawing.Size(117, 17)
        Me.chkMostrarContraseña.TabIndex = 36
        Me.chkMostrarContraseña.Text = "Mostrar contraseña"
        Me.chkMostrarContraseña.UseVisualStyleBackColor = True
        '
        'TxtNombreyApellido
        '
        Me.TxtNombreyApellido.Enabled = False
        Me.TxtNombreyApellido.ForeColor = System.Drawing.Color.Black
        Me.TxtNombreyApellido.Location = New System.Drawing.Point(36, 32)
        Me.TxtNombreyApellido.Name = "TxtNombreyApellido"
        Me.TxtNombreyApellido.Size = New System.Drawing.Size(202, 20)
        Me.TxtNombreyApellido.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(36, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nombre y Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(36, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Confirmar contraseña:"
        '
        'TxtConfirmarContraseña
        '
        Me.TxtConfirmarContraseña.ForeColor = System.Drawing.Color.Black
        Me.TxtConfirmarContraseña.Location = New System.Drawing.Point(36, 220)
        Me.TxtConfirmarContraseña.Name = "TxtConfirmarContraseña"
        Me.TxtConfirmarContraseña.Size = New System.Drawing.Size(202, 20)
        Me.TxtConfirmarContraseña.TabIndex = 32
        Me.TxtConfirmarContraseña.UseSystemPasswordChar = True
        '
        'txtUsuarioRegistro
        '
        Me.txtUsuarioRegistro.Enabled = False
        Me.txtUsuarioRegistro.ForeColor = System.Drawing.Color.Black
        Me.txtUsuarioRegistro.Location = New System.Drawing.Point(36, 71)
        Me.txtUsuarioRegistro.Name = "txtUsuarioRegistro"
        Me.txtUsuarioRegistro.Size = New System.Drawing.Size(202, 20)
        Me.txtUsuarioRegistro.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(36, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Usuario:"
        '
        'txtContraRegistrar
        '
        Me.txtContraRegistrar.ForeColor = System.Drawing.Color.Black
        Me.txtContraRegistrar.Location = New System.Drawing.Point(36, 178)
        Me.txtContraRegistrar.Name = "txtContraRegistrar"
        Me.txtContraRegistrar.Size = New System.Drawing.Size(202, 20)
        Me.txtContraRegistrar.TabIndex = 30
        Me.txtContraRegistrar.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(36, 145)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Cambiar contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(270, 322)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboCargo)
        Me.Controls.Add(Me.chkMostrarContraseña)
        Me.Controls.Add(Me.TxtNombreyApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtConfirmarContraseña)
        Me.Controls.Add(Me.txtUsuarioRegistro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContraRegistrar)
        Me.MaximumSize = New System.Drawing.Size(286, 361)
        Me.MinimumSize = New System.Drawing.Size(286, 361)
        Me.Name = "frmModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CboCargo As ComboBox
    Friend WithEvents chkMostrarContraseña As CheckBox
    Friend WithEvents TxtNombreyApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtConfirmarContraseña As TextBox
    Friend WithEvents txtUsuarioRegistro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraRegistrar As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
