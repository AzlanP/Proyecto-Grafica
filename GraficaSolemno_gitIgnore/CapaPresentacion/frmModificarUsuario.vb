Imports CapaNegocio
Imports CapaEntidad
Public Class frmModificarUsuario
    Dim oCNUsuario As New CNUsuario
    Dim oCEUsuario As New CEUsuario
    Public Editando As Boolean = False
    Public EditAdmin As Boolean = False



    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



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







    Public Sub Modificar()

        tomardatos()
        Dim validarlength As Boolean
        Dim validar As Boolean

        If CheckBox1.Checked Then
            validar = (oCEUsuario.Contrasena = TxtConfirmarContraseña.Text)
            validarlength = (oCEUsuario.Contrasena.Trim().Length >= 5 And oCEUsuario.Usuario.Trim().Length >= 5 And oCEUsuario.NombreCompleto.Trim().Length > 0)
        Else
            validarlength = oCEUsuario.Usuario.Trim().Length >= 5 And oCEUsuario.NombreCompleto.Trim().Length > 0
            validar = True
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
                MsgBox("El nombre del usuario y contraseñas  requieren una cantidad minima de 5 caracteres.", , "Validacion de usuario")
            End If

        End If




    End Sub
    Public Sub tomardatos()
        oCEUsuario.IDUsuario = Me.Tag
        oCEUsuario.NombreCompleto = Trim(TxtNombreyApellido.Text)
        oCEUsuario.Usuario = Trim(txtUsuarioRegistro.Text)
        If CheckBox1.Checked Then
            oCEUsuario.Contrasena = Trim(txtContraRegistrar.Text)
        End If
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

                MsgBox("Las contraseñas ingresadas no coinciden.", , "Validación de usuario")
            ElseIf Not validarlength Then
                MsgBox("El nombre del usuario, y contraseñas  requiere una cantidad minima de 5 caracteres.", , "Validación de usuario")
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


    Public Sub EditPassword()
        txtContraRegistrar.Enabled = CheckBox1.Checked
        TxtConfirmarContraseña.Enabled = CheckBox1.Checked
        chkMostrarContraseña.Enabled = CheckBox1.Checked
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        EditPassword()
    End Sub

    Private Sub btnRegistrar_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Editando Then

            Modificar()
        Else
            Registrar()
        End If
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
