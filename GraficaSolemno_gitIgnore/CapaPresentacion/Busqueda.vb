Imports CapaEntidad
Imports CapaNegocio

Public Class Busqueda
    Dim dtGrid As New DataTable
    Dim ID As Integer
    Dim oCNCliente As New CNCliente
    Public Sub CargarGridBuscar()

        dtGrid = oCNCliente.MostrarCliente()
        DGBuscar.DataSource = dtGrid.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido")

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        dtGrid = oCNCliente.BuscarCliente("Nombre", txtBuscar.Text)
        DGBuscar.DataSource = dtGrid.DefaultView.ToTable(True, "IDCliente", "Nombre", "Apellido")
    End Sub


    Private Sub DGBuscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuscar.CellDoubleClick
        ID = DGBuscar.Rows(e.RowIndex).Cells("IDCliente").Value
        '/CargarDatos(ID)
    End Sub

    Private Sub Busqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridBuscar()
    End Sub
End Class
