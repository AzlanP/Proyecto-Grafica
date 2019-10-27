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
    End Sub

    Private Sub linkTab_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTab.LinkClicked
        PanelRegistrar.Visible = True
        PanelLogin.Visible = False
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        PanelRegistrar.Visible = False
        PanelLogin.Visible = True
    End Sub
End Class
