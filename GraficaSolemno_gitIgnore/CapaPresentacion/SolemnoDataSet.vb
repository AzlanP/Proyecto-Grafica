Partial Class SolemnoDataSet
    Partial Public Class ClientesDataTable
        Private Sub ClientesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NombreColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace SolemnoDataSetTableAdapters
    
    Partial Public Class ClientesTableAdapter
    End Class
End Namespace
