Imports CapaNegocio

Public Class frmBusquedaPresupuestos
    Private Sub frmBusquedaPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGridBuscar()
    End Sub

    Dim dtGrid As New DataTable
    Public ID As Integer
    Public Nombre As String
    Public Apellido As String

    Dim oCNPedidos As New CNPedido
    Public Sub CargarGridBuscar()
        Dim dt As DataTable = oCNPedidos.MostrarPedido
        Dim dv As DataView
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Cliente") = dt.Rows(i)("Cliente") & " " & dt.Rows(i)("Apellido")
        Next

        dv = New DataView(dt, "Estado = 'Pendiente'", "IDPedido Asc", DataViewRowState.CurrentRows)

        DGBuscar.DataSource = dv
        DGBuscar.Columns("IDPedido").Visible = False
        DGBuscar.Columns("Apellido").Visible = False
        DGBuscar.Columns("Estado").Visible = False

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        dtGrid = oCNPedidos.BuscarPresupuesto("Nombre", txtBuscar.Text)

        Dim dt As DataTable = oCNPedidos.MostrarPedido
        Dim dv As DataView
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Cliente") = dt.Rows(i)("Cliente") & " " & dt.Rows(i)("Apellido")
        Next

        dv = New DataView(dt, "Estado = 'Pendiente'", "IDPedido Asc", DataViewRowState.CurrentRows)

        DGBuscar.DataSource = dv

    End Sub

    'fijarme si no combine mas poner solo cellclick ya que el doble click aveces funciona mal
    Private Sub DGBuscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuscar.CellDoubleClick
        Nombre = DGBuscar.Rows(e.RowIndex).Cells("Nombre").Value
        Apellido = DGBuscar.Rows(e.RowIndex).Cells("Apellido").Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
        '/CargarDatos(ID)
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        CargarGridBuscar()
    End Sub



End Class