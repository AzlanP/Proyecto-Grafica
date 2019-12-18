Public Class frmReportePresupuesto
    Public IDPedido As Integer
    Private Sub frmReportePresupuesto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.DTReportePedido' Puede moverla o quitarla según sea necesario.
        Me.DTReportePedidoTableAdapter.Fill(Me.SolemnoDataSet.DTReportePedido)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.DTReportePedido' Puede moverla o quitarla según sea necesario.
        Me.DTReportePedidoTableAdapter.Fill(Me.SolemnoDataSet.DTReportePedido)


        If Not (IDPedido) Then
            Me.DTReportePedidoTableAdapter.GetReportePedidoPorID(Me.SolemnoDataSet.DTReportePedido, IDPedido)
        End If
        Me.ItemsPorPedidoTableAdapter.Fill(Me.SolemnoDataSet.ItemsPorPedido)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class