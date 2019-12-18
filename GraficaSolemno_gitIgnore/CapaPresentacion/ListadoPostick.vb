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
        MostrarSinResultados(Me.SolemnoDataSet.Postick, DGPostick)
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

        Dim dv As DataView
        Dim sqlWhere As String = ""
        Dim format As String = "yyyy/MM/dd"
        Dim FechaString As String = SearchDate.Value.ToString(format)

        If cboBuscar.SelectedIndex = 0 Then
            sqlWhere = "Fecha = '" + FechaString + "'"
            dv = New DataView(Me.SolemnoDataSet.Postick, sqlWhere, "IDPostick Asc", DataViewRowState.CurrentRows)
            DGPostick.DataSource = dv
            Dim t As DataTable = dv.ToTable()
            MostrarSinResultados(t, DGPostick)
        ElseIf cboBuscar.SelectedIndex = 1 Then
            sqlWhere = "FechaEliminado = '" + FechaString + "' "
            dv = New DataView(Me.SolemnoDataSet.Postick, sqlWhere, "IDPostick Asc", DataViewRowState.CurrentRows)
            DGPostick.DataSource = dv
            Dim t As DataTable = dv.ToTable()
            MostrarSinResultados(t, DGPostick)
        ElseIf cboBuscar.SelectedIndex = 2 Then

            Dim dt As DataTable = Me.PostickTableAdapter.GetListadoByResponsable(cboResponsables.Text)
            DGPostick.DataSource = dt

            MostrarSinResultados(dt, DGPostick)
        ElseIf cboBuscar.SelectedIndex = 3 Then
            Dim dt As DataTable = Me.PostickTableAdapter.GetListadoByPrioridad(cboPrioridad.Text)
            DGPostick.DataSource = dt
            MostrarSinResultados(dt, DGPostick)
        End If




    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboResponsables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboResponsables.SelectedIndexChanged

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Dim dv As DataView
        dv = New DataView(Me.SolemnoDataSet.Postick, "", "IDPostick Asc", DataViewRowState.CurrentRows)
        DGPostick.DataSource = dv
        Dim t As DataTable = dv.ToTable()
        MostrarSinResultados(t, DGPostick)
    End Sub

    Public Sub MostrarSinResultados(ByVal dt As DataTable, ByVal DG As DataGridView)
        If dt.Rows.Count = 0 Then
            Dim pSearch As New Panel
            Dim alturaHeader As Integer = 32

            pSearch.Location = New Point(DG.Location.X, DG.Location.Y + alturaHeader)
            pSearch.Name = "Panel" + DG.Name
            pSearch.Size = New Size(DG.Size.Width, DG.Size.Height - alturaHeader)
            pSearch.BackColor = Color.White
            pSearch.BackgroundImage = CType(My.Resources.SinResulatosLupa, Image)
            pSearch.BackgroundImageLayout = ImageLayout.Stretch
            pSearch.Visible = True
            pSearch.BorderStyle = BorderStyle.None
            pSearch.Parent = DG.Parent
            pSearch.BringToFront()
        Else
            Dim ctrl() As Control
            ctrl = DG.Parent.Controls.Find("Panel" + DG.Name, True)
            If Not (ctrl.Length = 0) Then
                DG.Parent.Controls.Remove(ctrl(0))
            End If
        End If
    End Sub
End Class