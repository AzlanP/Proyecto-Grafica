Imports CapaNegocio
Imports CapaEntidad
Public Class frmIngresaralSistema
    Dim oCNUsuario As New CNUsuario
    Dim oCEUsuario As New CEUsuario

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        oCEUsuario.Usuario = Trim(TxtUsuario.Text)
        oCEUsuario.Contrasena = Trim(TxtContraseña.Text)


        Dim resultado As DataTable = oCNUsuario.BuscarUsuario(oCEUsuario.Usuario, oCEUsuario.Contrasena)
        If (resultado.Rows.Count = 0) Then
            MsgBox("El usuario o la Contraseña es incorrecta")
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            TxtUsuario.Focus()
        ElseIf (resultado.Rows.Count = 1) Then


            Dim cargo As String = resultado.Rows(0)("Cargo")
            Dim NombreCompleto As String = resultado.Rows(0)("NombreCompleto")
            frmMenuPrincipal.lblNombreUsuario.Text = NombreCompleto

            If (cargo = "Admin") Then
                frmMenuPrincipal.enableAdminMode()
            ElseIf (cargo = "Esclavo") Then
                frmMenuPrincipal.enableEsclavoMode()
            End If
            Me.Hide()
            frmMenuPrincipal.Show()
        End If
    End Sub





    Private Sub CekMostrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekMostrar.CheckedChanged
        If CekMostrar.Checked = True Then
            TxtContraseña.UseSystemPasswordChar = False
        Else
            TxtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmIngresaralSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtContraseña.UseSystemPasswordChar = True
        TxtConfirmarContraseña.UseSystemPasswordChar = True
        CboCargo.SelectedIndex = 0
    End Sub

    Private Sub linkTab_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTab.LinkClicked
        PanelRegistrar.Visible = True
        PanelLogin.Visible = False
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        guardar()
    End Sub
    Public Sub tomardatos()
        oCEUsuario.NombreCompleto = Trim(TxtNombreyApellido.Text)
        oCEUsuario.Usuario = Trim(txtUsuarioRegistro.Text)
        oCEUsuario.Contrasena = Trim(txtContraRegistrar.Text)
        oCEUsuario.Cargo = CboCargo.Text
        oCEUsuario.FechaCreacion = Date.Now().ToString()
    End Sub
    Public Sub cargardatos()
        TxtNombreyApellido.Text = oCEUsuario.NombreCompleto
        txtUsuarioRegistro.Text = oCEUsuario.Usuario
        txtContraRegistrar.Text = oCEUsuario.Contrasena
        CboCargo.Text = oCEUsuario.Cargo
    End Sub
    Public Sub guardar()
        tomardatos()
        If (oCEUsuario.Contrasena = TxtConfirmarContraseña.Text) And oCEUsuario.NombreCompleto <> "" Then
            Try
                oCNUsuario.RegistrarUsuario(oCEUsuario)
            Catch ex As Exception
                MsgBox("Error en el registro de usuario")
            End Try
        End If
    End Sub



    Private Sub chkMostrarContraseña_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarContraseña.CheckedChanged
        If chkMostrarContraseña.Checked = True Then
            TxtConfirmarContraseña.UseSystemPasswordChar = False
        Else
            TxtConfirmarContraseña.UseSystemPasswordChar = True
        End If
    End Sub
End Class
