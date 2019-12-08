Imports CapaNegocio
Imports CapaEntidad
Public Class frmIngresaralSistema
    Dim oCNUsuario As New CNUsuario
    Dim oCEUsuario As New CEUsuario

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

    'revisar
    Public Sub llenarFormulario(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow

        'realizo la busqueda del cliente segun su ID
        dt = oCNUsuario.BuscarUsuario(ID)

        dr = dt.Rows(0)
        'para mostrar los datos precargados de el registro
        'txtNombre.Text = dr("Nombre").ToString
        'txtApellido.Text = dr("Apellido").ToString
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
        TxtContraseña.UseSystemPasswordChar = True
        TxtConfirmarContraseña.UseSystemPasswordChar = True
        CboCargo.SelectedIndex = 0
    End Sub

    Private Sub linkTab_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
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
        oCEUsuario.FechaCreacion = FormatDateTime(Now, DateFormat.ShortDate)
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
