Imports System.Data
Imports System.Data.SQLite
Imports Microsoft.Reporting.WinForms
Public Class frmReportePedido
    Public IDPedido As Integer
    Private Sub frmReportePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.DTReportePedido' Puede moverla o quitarla según sea necesario.
        Me.DTReportePedidoTableAdapter.Fill(Me.SolemnoDataSet.DTReportePedido)
        Me.DTReportePedidoTableAdapter.GetReportePedidoPorID(Me.SolemnoDataSet.DTReportePedido, 35)
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.ItemsPorPedido' Puede moverla o quitarla según sea necesario.
        Me.ItemsPorPedidoTableAdapter.Fill(Me.SolemnoDataSet.ItemsPorPedido)
        ' Filter()

        Me.ReportViewer1.RefreshReport()
    End Sub


    'Public Class repPatientList
    '    Private Sub repPatientList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    '        Dim dt As New DataTable
    '        connectdB()
    '        Dim cmd As New OleDb.OleDbCommand("SELECT * from PatientMaster", connDB)
    '        cmd.CommandTimeout = 4096
    '        Dim ta As New OleDb.OleDbDataAdapter(cmd)
    '        ta.Fill(dt)
    '        With Me.ReportViewer1.LocalReport
    '            .DataSources.Clear()
    '            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
    '        End With
    '        Me.ReportViewer1.RefreshReport()
    '    End Sub
    'End Class
    Public Function FiltrarPedido(ByVal dtprincipal As DataTable) As DataTable
        ' Seleccionamos las filas que se correspondan con el identificador
        Dim rows() As DataRow = dtprincipal.Select("IDItems = 124")
        ' Clonamos la estructura del objeto DataTable principal
        Dim dt1 As DataTable = dtprincipal.Clone()
        ' Importamos los registros al nuevo DataTable
        For Each row As DataRow In rows
            dt1.ImportRow(row)
        Next
        Return dt1
    End Function

    Public Sub Filter()
        Me.DTReportePedidoTableAdapter.GetReportePedidoPorID(Me.SolemnoDataSet.DTReportePedido, 35)
    End Sub
    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load
   
    End Sub
End Class