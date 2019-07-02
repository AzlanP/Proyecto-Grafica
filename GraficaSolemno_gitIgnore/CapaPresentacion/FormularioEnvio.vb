Imports CapaEntidad
Imports CapaNegocio
Public Class FormularioEnvio
    Dim oCECliente As New CECliente
    Dim oCNCliente As New CNCliente
    Public Sub DatosCliente(ByVal Cliente As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNCliente.BuscarCliente("IDCliente", Cliente)
        dr = dt.Rows(0)
        oCECliente.IDCliente = dr("IDCliente").ToString
        'oCECliente.Pais = dr("IDPais").ToString
        AsignarTextCbo(dr("Provincia").ToString, cboProvincia)
        AsignarTextCbo(dr("Localidad").ToString, cboLocalidad)
        'oCECliente.Provincia = dr("Provincia").ToString
        'oCECliente.Localidad = dr("Localidad").ToString
        txtBarrio.Text = dr("Barrio").ToString
        txtNroCalle.Text = dr("Domicilio").ToString
        txtDomicilio.Text = dr("NroCalle").ToString
        txtDpto.Text = dr("Dpto").ToString
        txtCP.Text = dr("CP").ToString
        oCECliente.Fecha = dr("Fecha").ToString
    End Sub
    Public Sub AsignarDatosCBO()
        cboPais.Text = oCECliente.Pais

        AsignarTextCbo(oCECliente.Provincia, cboProvincia)
        AsignarTextCbo(oCECliente.Localidad, cboLocalidad)
    End Sub


    Private Sub FormularioEnvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.SolemnoDataSet.Provincias)
        cboProvincia.SelectedIndex = 0
    End Sub

    Private Sub cboProvincia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dt As DataTable = oCNCliente.LocalidadesPorProvincia(cboProvincia.SelectedValue)
        cboLocalidad.DataSource = dt
        cboLocalidad.DisplayMember = "Nombre"
        cboLocalidad.ValueMember = "IDLocalidad"

    End Sub

    Private Sub cboLocalidad_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.Enter
        If cboProvincia.Text = "" Or cboProvincia.Text = " " Then
            MsgBox("debe ingresar una provincia primero.")
            cboProvincia.Focus()
        ElseIf cboProvincia.SelectedValue = Nothing Then
            MsgBox("Debe ingresar una provincia valida")
            cboProvincia.Text = ""
            cboLocalidad.Text = ""
        End If
    End Sub

    Private Sub cboLocalidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.LostFocus
        If cboLocalidad.SelectedValue = Nothing Then
            MsgBox("Debe ingresar una Localidad valida")
            cboLocalidad.Text = ""
            txtCP.Text = ""
        End If
    End Sub

    Private Sub cboLocalidad_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.SelectedValueChanged
        Dim idprovincia As Integer = CInt(cboProvincia.SelectedValue)
        Dim idlocalidad As Integer = CInt(cboLocalidad.SelectedValue)
        txtCP.Text = oCNCliente.TraerCP(idprovincia, idlocalidad)

    End Sub
    Private Sub cboLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLocalidad.KeyPress
        cboLocalidad.DroppedDown = False

    End Sub
    Public Sub AsignarTextCbo(ByVal text As String, ByVal cbo As System.Object)

        Dim int As Integer
        int = cbo.FindString(text)
        cbo.SelectedIndex = int
    End Sub
End Class