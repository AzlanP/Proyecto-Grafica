Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarCliente
    Dim oCNCliente As New CNCliente
    Dim oCECliente As New CECliente

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        oCNCliente.RegistrarCliente(TomarDatos())
        MsgBox("Los Datos fueron guardados con exito.")
        Close()
    End Sub

    Public Sub LlenarFormulario(ByVal ID As Integer)
        PrecargarCombobox()
        Dim dt As New DataTable
        Dim dr As DataRow

        'realizo la busqueda del cliente segun su ID
        dt = oCNCliente.BuscarCliente("IDCliente", ID)
        'guardo el registro del cliente en el datarow para mostrarlo
        dr = dt.Rows(0)
        'para mostrar los datos precargados de el registro
        lblID.Text = dr("IDCliente").ToString
        txtNombre.Text = dr("Nombre").ToString
        txtApellido.Text = dr("Apellido").ToString
        txtTel.Text = dr("Telefono").ToString
        txtCel.Text = dr("Telefono2").ToString
        txtDNI.Text = dr("DNI").ToString
        txtCuit.Text = dr("CUIT").ToString
        'cboPais.Text = dr("IDPais").ToString
        AsignarTextCbo(dr("Provincia").ToString, cboProvincia)
        AsignarTextCbo(dr("Localidad").ToString, cboLocalidad)
        txtBarrio.Text = dr("Barrio").ToString
        txtCalle.Text = dr("Domicilio").ToString
        txtNumeracion.Text = dr("NroCalle").ToString
        txtNumeracion.Text = dr("Dpto").ToString
        txtCP.Text = dr("CP").ToString
        txtEmail.Text = dr("EMAIL").ToString
        AsignarTextCbo(dr("Condicion de IVA").ToString, cbIVA)
        dpFecha.Text = dr("Fecha").ToString
        'la modificacion no fallo  pero ya se encotraba abierta la base de datos. revisar

        'Esto es para cambiar segun si se esta modificando aparasca el boton de guardar, o el boton de registro
        btnRegistrar.Visible = False
        btnGuardar.Visible = True
        'Esto es para que segun sea el caso el texto del formulario cambie.
        Me.Text = "Modificar Cliente"
    End Sub
    '
    Public Function TomarDatos() As CECliente
        'en este metodo debo guardar los datos de los textbox indiferente si es para registrar o para modificar


        oCECliente.IDCliente = CInt(lblID.Text)
        oCECliente.Nombre = txtNombre.Text
        oCECliente.Apellido = txtApellido.Text
        oCECliente.Telefono = txtTel.Text
        oCECliente.Telefono2 = txtCel.Text
        oCECliente.DNI = txtDNI.Text
        oCECliente.CUIT = txtCuit.Text
        oCECliente.Pais = 1
        oCECliente.Provincia = CInt(cboProvincia.SelectedValue)
        oCECliente.Localidad = CInt(cboLocalidad.SelectedValue)
        oCECliente.Barrio = txtBarrio.Text
        oCECliente.Domicilio = txtCalle.Text
        oCECliente.NroCalle = CasteoNulo(txtNumeracion.Text)
        oCECliente.Dpto = txtDpto.Text
        oCECliente.CP = CasteoNulo(txtCP.Text)
        oCECliente.Email = txtEmail.Text
        oCECliente.CondIVA = CInt(cbIVA.SelectedValue)
        oCECliente.Fecha = CDate(dpFecha.Value.ToShortDateString)
        Return oCECliente

    End Function
    Public Function CasteoNulo(ByVal value As String) As Integer
        value = Trim(value)
        If value = "" Then
            Return Nothing
        Else
            Return value
        End If

    End Function
    Public Sub Disesabletext()
        'este codigo es para desabilitar la edicion de todos los campos
        Dim ctrl As Control

        For Each ctrl In Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Enabled = False 'Creo que el error es aqui
            End If
        Next

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'MsgBox("Esta seguro de descartar los cambios?", vbOKCancel, "Confirmacion!")
        'If DialogResult.OK Then

        'End If
        If MessageBox.Show("Esta seguro de descartar los cambios?", "Confirmacion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Close()
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        oCNCliente.ModificarCliente(TomarDatos())
        MsgBox("Los Datos fueron modificados con exito.")
        Close()
    End Sub

 
    
    Private Sub RegistrarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim validacion As New Validaciones
        validacion.Validar(Me)
    End Sub
    Public Sub PrecargarCombobox()
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.CondIVA' Puede moverla o quitarla según sea necesario.
        Me.CondIVATableAdapter.Fill(Me.SolemnoDataSet.CondIVA)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.SolemnoDataSet.Provincias)
    End Sub

    '------------------------------------------------------------------------------------------------------------
    ' los siguientes metodos son utilizados para el rellenado del combobox localidad, como asi tambien el autocompletado 
    ' y el dropdown y codigo postal.
   
    Private Sub cboProvincia_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedValueChanged
        Dim dt As DataTable = oCNCliente.LocalidadesPorProvincia(cboProvincia.SelectedValue)
        cboLocalidad.DataSource = dt
        cboLocalidad.DisplayMember = "Nombre"
        cboLocalidad.ValueMember = "IDLocalidad"

    End Sub

    Private Sub cboLoca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.Enter
        If cboProvincia.Text = "" Or cboProvincia.Text = " " Then
            MsgBox("debe ingresar una provincia primero.")
            cboProvincia.Focus()

        ElseIf cboProvincia.SelectedValue = Nothing Then
            MsgBox("Debe ingresar una provincia valida")
            cboProvincia.Text = ""
            cboLocalidad.Text = ""
        End If
    End Sub

    Private Sub cboLoca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.LostFocus
        If cboLocalidad.SelectedValue = Nothing Then
            MsgBox("Debe ingresar una Localidad valida")
            cboLocalidad.Text = ""
            txtCP.Text = ""
        End If
    End Sub

    Private Sub cboLoca_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocalidad.SelectedValueChanged
        Dim idprovincia As Integer = CInt(cboProvincia.SelectedValue)
        Dim idlocalidad As Integer = CInt(cboLocalidad.SelectedValue)
        txtCP.Text = oCNCliente.TraerCP(idprovincia, idlocalidad)

    End Sub
    Private Sub cboLoca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLocalidad.KeyPress
        cboLocalidad.DroppedDown = False

    End Sub
    'para rellenar formularios.
    'compara el nombre obtenido de la base de datos con los nombres de la lista del combobox, y lo selecciona.
    Public Sub AsignarTextCbo(ByVal text As String, ByVal cbo As System.Object)

        Dim int As Integer
        int = cbo.FindString(text)
        cbo.SelectedIndex = int
    End Sub

End Class