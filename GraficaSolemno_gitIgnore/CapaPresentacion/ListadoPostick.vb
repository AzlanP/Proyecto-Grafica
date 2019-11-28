Public Class ListadoPostick
    Dim fecha As Date
    Dim fechaEliminacion As Date
    Dim motivo As String

    Private Sub ListadoPostick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SolemnoDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.SolemnoDataSet.Clientes)

        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Postick' Puede moverla o quitarla según sea necesario.
        cboResponsables.SelectedIndex = 0
        cboPrioridad.SelectedIndex = 0
        cboBuscar.SelectedIndex = 0
        Me.PostickTableAdapter.Fill(Me.SolemnoDataSet.Postick)
        Me.PostickTableAdapter.GetMotivoEliminacion(Me.SolemnoDataSet.Postick)

    End Sub

    Private Sub cboBuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscar.SelectedIndexChanged
        If (cboBuscar.SelectedIndex = 0 Or cboBuscar.SelectedIndex = 1) Then
            SearchDate.Visible = True
            cboPrioridad.Visible = False
            cboResponsables.Visible = False
        ElseIf cboBuscar.SelectedIndex = 2 Then
            SearchDate.Visible = False
            cboPrioridad.Visible = False
            cboResponsables.Visible = True
        ElseIf cboBuscar.SelectedIndex = 3 Then
            SearchDate.Visible = False
            cboPrioridad.Visible = True
            cboResponsables.Visible = False
            End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If (cboBuscar.SelectedIndex = 0 Or cboBuscar.SelectedIndex = 1) Then
            Dim dv As DataView
            Dim sqlWhere As String = ""
            If cboBuscar.SelectedIndex = 0 Then
                sqlWhere = "Fecha = '" + SearchDate.Text + "' "
            ElseIf cboBuscar.SelectedIndex = 1 Then
                sqlWhere = "FechaEliminado = '" + SearchDate.Text + "' "
            End If

            dv = New DataView(Me.SolemnoDataSet.Postick, sqlWhere, "IDPostick Asc", DataViewRowState.CurrentRows)
            DGPostick.DataSource = dv
        Else
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboResponsables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboResponsables.SelectedIndexChanged

    End Sub
End Class