Public Class VisorDeReportes

    Private Sub VisorDeReportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub AddReportResultados()
        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1
        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.DataTable1TableAdapter

        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()


        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DataTable1TableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.DataTable1TableAdapter()
        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Resultados.rdlc"


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "DataTable1"
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.DataTable1)

        Me.ReportViewer1.RefreshReport()


    End Sub

    Public Sub AddReportMedios()

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.MediosTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.MediosTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Medios.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "Medios"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.Medios)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub

    Public Sub AddReportProductos()
        Me.ReportViewer1.Clear()


        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.DataTable2TableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.DataTable2TableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.TendenciaProductos.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "DataTable2"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()



        'Dim dt As SolemnoDataSet1.DataTable2DataTable = New SolemnoDataSet1.DataTable2DataTable()
        'DataTable1TableAdapter.Fill(dt)
        'Dim list As List(Of TendenciaProducto) = New List(Of TendenciaProducto)()
        'For Each item In dt
        '    list.Add(New TendenciaProducto(item.Producto, item.Ventas, item.Year))
        'Next

        'Dim lst = From item In list
        '  Order By item.Ventas
        '  Group By item.Producto
        '  Into grp = Group, Sum(item.Ventas)
        '  Order By Sum Descending
        '  Select New TendenciaProducto(Producto, Sum, grp.FirstOrDefault().Año)





        DataTable1TableAdapter.Fill(SolemnoDataSet1.DataTable2)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub




    Public Sub AddReportPedidosPorPeriodos()

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.PedidosPorPeriodosTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.PedidosPorPeriodosTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.PedidosPorPeriodos.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "PedidosPorPeriodos"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.PedidosPorPeriodos)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub



    Public Sub AddReportEstadosPorClientes()

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.EstadoPorClienteTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.EstadoPorClienteTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.EstadoPorCliente.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "EstadoPorCliente"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()




        DataTable1TableAdapter.Fill(SolemnoDataSet1.EstadoPorCliente)  'este
        Dim clientes = DataTable1TableAdapter.GetTop10()

        Dim query = "Cliente in ("
        For Each item In clientes
            query += "'" + item.Cliente + "',"
        Next
        query += "'')"

        Dim dv = SolemnoDataSet1.EstadoPorCliente.AsDataView()

        dv.RowFilter = query

        Dim dt = dv.ToTable()


        Dim dt3 As SolemnoDataSet1.EstadoPorClienteDataTable = New SolemnoDataSet1.EstadoPorClienteDataTable()

        For Each item In dt.Rows
            dt3.ImportRow(item)
        Next



        SolemnoDataSet1.EstadoPorCliente.Clear()
        For Each item In dt.Rows
            SolemnoDataSet1.EstadoPorCliente.ImportRow(item)
        Next

        Me.ReportViewer1.RefreshReport()


    End Sub



    Public Sub AddReportResultadoPorCliente()

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.ComprasDeClientesTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.ComprasDeClientesTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ComprasPorClientes.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "ComprasDeClientes"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.ComprasDeClientes)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub



    Public Sub AddReportProvincia()

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.ProvinciasTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.ProvinciasTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportProvincias.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "Provincias"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.Provincias)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub


    Public Sub AddReportLocalidad(ByVal idProvincia As String)

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.LocalidadTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.LocalidadTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportLocalidad.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "Localidad"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.Localidad, idProvincia)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub



    Public Sub AddReportLocalidadPorPeriodos(ByVal idProvincia As String)

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.LocalidadPorPeriodosTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.LocalidadPorPeriodosTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.LocalidadPorPeriodos.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "LocalidadPorPeriodos"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.LocalidadPorPeriodos, idProvincia)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub


    Public Sub AddReportProvinciasPorPeriodos()

        Me.ReportViewer1.Clear()

        Dim DataTable1BindingSource As System.Windows.Forms.BindingSource
        Dim SolemnoDataSet1 As CapaPresentacion.SolemnoDataSet1


        Dim DataTable1TableAdapter As CapaPresentacion.SolemnoDataSet1TableAdapters.ProvinciasPorPeriodosTableAdapter = New CapaPresentacion.SolemnoDataSet1TableAdapters.ProvinciasPorPeriodosTableAdapter() 'este

        Me.components = New System.ComponentModel.Container() '
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        SolemnoDataSet1 = New CapaPresentacion.SolemnoDataSet1()
        DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ProvinciasPorPeriodos.rdlc" 'este


        'SolemnoDataSet1
        SolemnoDataSet1.DataSetName = "SolemnoDataSet1"
        SolemnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        DataTable1BindingSource.DataMember = "ProvinciasPorPeriodos"   'este
        DataTable1BindingSource.DataSource = SolemnoDataSet1
        DataTable1TableAdapter.ClearBeforeFill = True

        CType(SolemnoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        DataTable1TableAdapter.Fill(SolemnoDataSet1.ProvinciasPorPeriodos)  'este

        Me.ReportViewer1.RefreshReport()


    End Sub


End Class