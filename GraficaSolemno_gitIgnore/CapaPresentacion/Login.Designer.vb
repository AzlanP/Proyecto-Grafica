<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresaralSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresaralSistema))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.CekMostrar = New System.Windows.Forms.CheckBox()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.PanelRegistrar = New System.Windows.Forms.Panel()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelLogin.SuspendLayout()
        Me.PanelRegistrar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.ForeColor = System.Drawing.Color.Black
        Me.TxtUsuario.Location = New System.Drawing.Point(14, 25)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(175, 20)
        Me.TxtUsuario.TabIndex = 5
        '
        'TxtContraseña
        '
        Me.TxtContraseña.ForeColor = System.Drawing.Color.Black
        Me.TxtContraseña.Location = New System.Drawing.Point(14, 80)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(175, 20)
        Me.TxtContraseña.TabIndex = 6
        '
        'CekMostrar
        '
        Me.CekMostrar.AutoSize = True
        Me.CekMostrar.ForeColor = System.Drawing.Color.Black
        Me.CekMostrar.Location = New System.Drawing.Point(14, 106)
        Me.CekMostrar.Name = "CekMostrar"
        Me.CekMostrar.Size = New System.Drawing.Size(61, 17)
        Me.CekMostrar.TabIndex = 9
        Me.CekMostrar.Text = "Mostrar"
        Me.CekMostrar.UseVisualStyleBackColor = True
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.btnIngresar)
        Me.PanelLogin.Controls.Add(Me.TxtUsuario)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.CekMostrar)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.TxtContraseña)
        Me.PanelLogin.Location = New System.Drawing.Point(259, 75)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(227, 181)
        Me.PanelLogin.TabIndex = 11
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Location = New System.Drawing.Point(48, 138)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(122, 24)
        Me.btnIngresar.TabIndex = 25
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'PanelRegistrar
        '
        Me.PanelRegistrar.Controls.Add(Me.btnCerrar)
        Me.PanelRegistrar.Controls.Add(Me.btnRegistrar)
        Me.PanelRegistrar.Controls.Add(Me.Label8)
        Me.PanelRegistrar.Controls.Add(Me.CboCargo)
        Me.PanelRegistrar.Controls.Add(Me.chkMostrarContraseña)
        Me.PanelRegistrar.Controls.Add(Me.TxtNombreyApellido)
        Me.PanelRegistrar.Controls.Add(Me.Label6)
        Me.PanelRegistrar.Controls.Add(Me.Label5)
        Me.PanelRegistrar.Controls.Add(Me.TxtConfirmarContraseña)
        Me.PanelRegistrar.Controls.Add(Me.txtUsuarioRegistro)
        Me.PanelRegistrar.Controls.Add(Me.Label3)
        Me.PanelRegistrar.Controls.Add(Me.Label4)
        Me.PanelRegistrar.Controls.Add(Me.txtContraRegistrar)
        Me.PanelRegistrar.Location = New System.Drawing.Point(262, 28)
        Me.PanelRegistrar.Name = "PanelRegistrar"
        Me.PanelRegistrar.Size = New System.Drawing.Size(204, 298)
        Me.PanelRegistrar.TabIndex = 12
        Me.PanelRegistrar.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Location = New System.Drawing.Point(34, 248)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(133, 24)
        Me.btnRegistrar.TabIndex = 24
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Cargo:"
        '
        'CboCargo
        '
        Me.CboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCargo.ForeColor = System.Drawing.Color.Black
        Me.CboCargo.FormattingEnabled = True
        Me.CboCargo.Items.AddRange(New Object() {"Administrador", "Vendedor"})
        Me.CboCargo.Location = New System.Drawing.Point(21, 221)
        Me.CboCargo.Name = "CboCargo"
        Me.CboCargo.Size = New System.Drawing.Size(165, 21)
        Me.CboCargo.TabIndex = 10
        '
        'chkMostrarContraseña
        '
        Me.chkMostrarContraseña.AutoSize = True
        Me.chkMostrarContraseña.ForeColor = System.Drawing.Color.Black
        Me.chkMostrarContraseña.Location = New System.Drawing.Point(24, 174)
        Me.chkMostrarContraseña.Name = "chkMostrarContraseña"
        Me.chkMostrarContraseña.Size = New System.Drawing.Size(117, 17)
        Me.chkMostrarContraseña.TabIndex = 23
        Me.chkMostrarContraseña.Text = "Mostrar contraseña"
        Me.chkMostrarContraseña.UseVisualStyleBackColor = True
        '
        'TxtNombreyApellido
        '
        Me.TxtNombreyApellido.ForeColor = System.Drawing.Color.Black
        Me.TxtNombreyApellido.Location = New System.Drawing.Point(24, 31)
        Me.TxtNombreyApellido.Name = "TxtNombreyApellido"
        Me.TxtNombreyApellido.Size = New System.Drawing.Size(165, 20)
        Me.TxtNombreyApellido.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Nombre y Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Confirmar contraseña:"
        '
        'TxtConfirmarContraseña
        '
        Me.TxtConfirmarContraseña.ForeColor = System.Drawing.Color.Black
        Me.TxtConfirmarContraseña.Location = New System.Drawing.Point(24, 148)
        Me.TxtConfirmarContraseña.Name = "TxtConfirmarContraseña"
        Me.TxtConfirmarContraseña.Size = New System.Drawing.Size(165, 20)
        Me.TxtConfirmarContraseña.TabIndex = 15
        '
        'txtUsuarioRegistro
        '
        Me.txtUsuarioRegistro.ForeColor = System.Drawing.Color.Black
        Me.txtUsuarioRegistro.Location = New System.Drawing.Point(24, 70)
        Me.txtUsuarioRegistro.Name = "txtUsuarioRegistro"
        Me.txtUsuarioRegistro.Size = New System.Drawing.Size(165, 20)
        Me.txtUsuarioRegistro.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Usuario:"
        '
        'txtContraRegistrar
        '
        Me.txtContraRegistrar.ForeColor = System.Drawing.Color.Black
        Me.txtContraRegistrar.Location = New System.Drawing.Point(24, 109)
        Me.txtContraRegistrar.Name = "txtContraRegistrar"
        Me.txtContraRegistrar.Size = New System.Drawing.Size(165, 20)
        Me.txtContraRegistrar.TabIndex = 13
        Me.txtContraRegistrar.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(34, 248)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(133, 24)
        Me.btnCerrar.TabIndex = 25
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        Me.btnCerrar.Visible = False
        '
        'frmIngresaralSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(676, 338)
        Me.Controls.Add(Me.PanelRegistrar)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmIngresaralSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.PanelRegistrar.ResumeLayout(False)
        Me.PanelRegistrar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents CekMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents PanelLogin As System.Windows.Forms.Panel
    Friend WithEvents PanelRegistrar As System.Windows.Forms.Panel
    Friend WithEvents CboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreyApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContraRegistrar As System.Windows.Forms.TextBox
    Friend WithEvents chkMostrarContraseña As System.Windows.Forms.CheckBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button

End Class
