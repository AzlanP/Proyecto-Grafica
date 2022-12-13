Imports CapaEntidad
Imports CapaNegocio

Public Class frmBusqueda
    Dim dtGrid As New DataTable
    Public ID As Integer
    Public Nombre As String
    Public Apellido As String

    Dim oCNCliente As New CNCliente
    Public Sub CargarGridBuscar()

        dtGrid = oCNCliente.MostrarCliente()
        DGBuscar.DataSource = dtGrid.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido")

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        dtGrid = oCNCliente.BuscarCliente("Nombre", txtBuscar.Text)
        DGBuscar.DataSource = dtGrid.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido")
    End Sub

    'fijarme si no combine mas poner solo cellclick ya que el doble click aveces funciona mal
    Private Sub DGBuscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuscar.CellDoubleClick
        Nombre = DGBuscar.Rows(e.RowIndex).Cells("Nombre").Value
        Apellido = DGBuscar.Rows(e.RowIndex).Cells("Apellido").Value

        Me.DialogResult = DialogResult.OK
        Me.Close()
        '/CargarDatos(ID)
    End Sub
    Private Sub frmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridBuscar()


    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        CargarGridBuscar()
    End Sub




End Class