<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ItemsPorPedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolemnoDataSet = New CapaPresentacion.SolemnoDataSet()
        Me.ItemsPorPedidoTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.ItemsPorPedidoTableAdapter()
        Me.DTReportePedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTReportePedidoTableAdapter = New CapaPresentacion.SolemnoDataSetTableAdapters.DTReportePedidoTableAdapter()
        CType(Me.ItemsPorPedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTReportePedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReporteDataSet"
        ReportDataSource1.Value = Me.DTReportePedidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportPedido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(880, 693)
        Me.ReportViewer1.TabIndex = 0
        '
        'ItemsPorPedidoBindingSource
        '
        Me.ItemsPorPedidoBindingSource.DataMember = "ItemsPorPedido"
        Me.ItemsPorPedidoBindingSource.DataSource = Me.SolemnoDataSet
        '
        'SolemnoDataSet
        '
        Me.SolemnoDataSet.DataSetName = "SolemnoDataSet"
        Me.SolemnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsPorPedidoTableAdapter
        '
        Me.ItemsPorPedidoTableAdapter.ClearBeforeFill = True
        '
        'DTReportePedidoBindingSource
        '
        Me.DTReportePedidoBindingSource.DataMember = "DTReportePedido"
        Me.DTReportePedidoBindingSource.DataSource = Me.SolemnoDataSet
        '
        'DTReportePedidoTableAdapter
        '
        Me.DTReportePedidoTableAdapter.ClearBeforeFill = True
        '
        'frmReportePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 693)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportePedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ItemsPorPedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolemnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTReportePedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ItemsPorPedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SolemnoDataSet As CapaPresentacion.SolemnoDataSet
    Friend WithEvents ItemsPorPedidoTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.ItemsPorPedidoTableAdapter
    Friend WithEvents DTReportePedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DTReportePedidoTableAdapter As CapaPresentacion.SolemnoDataSetTableAdapters.DTReportePedidoTableAdapter
End Class
