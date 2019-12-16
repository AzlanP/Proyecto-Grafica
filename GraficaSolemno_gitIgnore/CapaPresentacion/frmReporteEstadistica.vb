Imports Microsoft.Reporting.WinForms

Public Class frmReporteEstadistica
    Public imagen As Bitmap
    Public imagenBase64 As String
    Private Sub frmReporteEstadistica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ItemsPorPedidoTableAdapter.Fill(Me.SolemnoDataSet.ItemsPorPedido)

        Me.ReportViewer1.RefreshReport()


        Try
            If Not (imagen Is Nothing) Then
                Dim ms As IO.MemoryStream = New IO.MemoryStream()
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteImage As Byte() = ms.ToArray()
                imagenBase64 = Convert.ToBase64String(byteImage)

                Me.ReportViewer1.LocalReport.EnableExternalImages = True
                Dim templateImage = "file:\" + Application.StartupPath + "\grafico.jpeg"
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("imgBase64", imagenBase64))
                Me.ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox("Se ah producido un error en la generacion del reporte.", , "Error de reporte")

        End Try
    
 
    End Sub
End Class