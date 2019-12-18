Imports CapaNegocio
Imports CapaEntidad
Public Class frmIngresaralSistema
    Dim oCNUsuario As New CNUsuario
    Dim oCEUsuario As New CEUsuario
    Public Editando As Boolean = False
    Public EditAdmin As Boolean = False



    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        oCEUsuario.Usuario = Trim(TxtUsuario.Text)
        oCEUsuario.Contrasena = Trim(TxtContraseña.Text)

        Dim resultado As DataTable = oCNUsuario.ValidarUsuario(oCEUsuario.Usuario, oCEUsuario.Contrasena)

        If (resultado.Rows.Count = 0) Then
            MsgBox("El usuario o la Contraseña es incorrecta")
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            TxtUsuario.Focus()
        ElseIf (resultado.Rows.Count = 1) Then


            Dim cargo As String = resultado.Rows(0)("Cargo")
            Dim NombreCompleto As String = resultado.Rows(0)("NombreCompleto")
            frmMenuPrincipal.lblUsuario.Text = NombreCompleto
            frmMenuPrincipal.lblUsuario.Tag = resultado.Rows(0)("IDUsuario")

            If (cargo = "Administrador") Then
                frmMenuPrincipal.enableAdminMode()

            ElseIf (cargo = "Vendedor") Then
                frmMenuPrincipal.disabledAdminMode()
            End If
            Me.Hide()
            oCEUsuario.Usuario = ""
            oCEUsuario.Contrasena = ""
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            frmMenuPrincipal.Show()
        End If
    End Sub


    Public Sub llenarFormulario(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNUsuario.BuscarUsuario(ID)
        dr = dt.Rows(0)
        Me.Tag = ID
        TxtNombreyApellido.Text = dr("NombreCompleto").ToString
        txtUsuarioRegistro.Text = dr("Usuario").ToString
        CboCargo.Text = dr("Cargo").ToString
    End Sub


    Private Sub CekMostrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekMostrar.CheckedChanged

        If CekMostrar.Checked = True Then
            TxtContraseña.UseSystemPasswordChar = False
        Else
            TxtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmIngresaralSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'chkMostrarContraseña.Visible = Not Editando
        'CboCargo.Enabled = Not Editando
        'TxtNombreyApellido.Enabled = Not Editando

        'TxtConfirmarContraseña.Enabled = Editando
        'txtContraRegistrar.Enabled = Editando

        TxtContraseña.UseSystemPasswordChar = True
        TxtConfirmarContraseña.UseSystemPasswordChar = True
        If CboCargo.Text = "" Then
            CboCargo.SelectedIndex = 0
        End If
        If Editando Then
            btnRegistrar.Text = "Guardar"
        End If
    End Sub


    Private Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If (Editando) Then
            Modificar()
        Else
            Registrar()
        End If

    End Sub
    Public Sub Modificar()

        tomardatos()
        Dim validarlength As Boolean
        Dim validar As Boolean
        If EditAdmin Then
            validarlength = oCEUsuario.Usuario.Trim().Length >= 5
            validar = True
        Else
            validar = (oCEUsuario.Contrasena = TxtConfirmarContraseña.Text)
            validarlength = (oCEUsuario.Contrasena.Trim().Length >= 5 And oCEUsuario.Usuario.Trim().Length >= 5 And oCEUsuario.NombreCompleto.Trim().Length >= 5)
        End If

        If validar And validarlength Then
            Try
                oCNUsuario.ModificarUsuario(oCEUsuario)
                Me.Close()
            Catch ex As Exception
                MsgBox("Error en la modificacion de usuario")
            End Try
        Else
            If Not validar Then

                MsgBox("Las contraseñas ingresadas no coinciden.", , "Validacion de usuario")
            ElseIf Not validarlength Then
                    MsgBox("El nombre del usuario, y contraseñas  requiere una cantidad minima de 5 caracteres.", , "Validacion de usuario")
                End If

            End If
            



    End Sub
    Public Sub tomardatos()
        oCEUsuario.IDUsuario = Me.Tag
        oCEUsuario.NombreCompleto = Trim(TxtNombreyApellido.Text)
        oCEUsuario.Usuario = Trim(txtUsuarioRegistro.Text)
        oCEUsuario.Contrasena = Trim(txtContraRegistrar.Text)
        oCEUsuario.Cargo = CboCargo.Text
        oCEUsuario.FechaCreacion = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub
    Public Sub cargardatos()
        TxtNombreyApellido.Text = oCEUsuario.NombreCompleto
        txtUsuarioRegistro.Text = oCEUsuario.Usuario
        txtContraRegistrar.Text = oCEUsuario.Contrasena
        CboCargo.Text = oCEUsuario.Cargo
    End Sub

    Public Sub Registrar()
        tomardatos()
        Dim validarlength As Boolean
        Dim validar As Boolean
     
            validar = (oCEUsuario.Contrasena = TxtConfirmarContraseña.Text)
            validarlength = (oCEUsuario.Contrasena.Trim().Length >= 5 And oCEUsuario.Usuario.Trim().Length >= 5 And oCEUsuario.NombreCompleto.Trim().Length >= 5)


        If validar And validarlength Then
            Try
                oCNUsuario.RegistrarUsuario(oCEUsuario)
                Me.Close()
            Catch ex As Exception
                MsgBox("Error en el registro de usuario")
            End Try
        Else
            If Not validar Then

                MsgBox("Las contraseñas ingresadas no coinciden.", , "Validacion de usuario")
            ElseIf Not validarlength Then
                MsgBox("El nombre del usuario, y contraseñas  requiere una cantidad minima de 5 caracteres.", , "Validacion de usuario")
            End If

        End If

    End Sub



    Private Sub chkMostrarContraseña_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarContraseña.CheckedChanged
        If chkMostrarContraseña.Checked = True Then
            txtContraRegistrar.UseSystemPasswordChar = False
            TxtConfirmarContraseña.UseSystemPasswordChar = False
        Else
            txtContraRegistrar.UseSystemPasswordChar = True
            TxtConfirmarContraseña.UseSystemPasswordChar = True
        End If
    End Sub
    Public Sub Disesabletext()

        Dim ctrl As Control

        For Each ctrl In Controls

            If TypeOf ctrl Is Panel Then
                For Each btn In ctrl.Controls
                    btn.Enabled = False
                Next

            End If
            'If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is Panel Then

            '    ctrl.Enabled = False
            'End If
        Next
        btnRegistrar.Visible = False
        btnCerrar.Visible = True
        btnCerrar.Enabled = True
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
