﻿Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarNota

    Dim oCEPostick As New CEPostick
    Dim oCNPostick As New CNPostick
    Dim ActualUsuario As String

    Private Sub btnGuardarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarNota.Click
        If (String.IsNullOrEmpty(txtTitulo.Text)) Then
            MsgBox("El título de la tarea es requerido.", , "Validación")
            Return
        End If

        oCNPostick.NuevoPostick(TomarDatos)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Public Function FormatISO8601(ByVal pfecha As Date) As String

        Dim SoloFecha As String
        Dim dia, mes As String

        If pfecha.Month < 10 Then
            mes = "0" & pfecha.Month
        Else
            mes = pfecha.Month
        End If
        If pfecha.Day < 10 Then
            dia = "0" & pfecha.Day
        Else
            dia = pfecha.Day
        End If
        SoloFecha = pfecha.Year & "/" & mes & "/" & dia

        Return SoloFecha
    End Function
    Public Function FormatoFechaNormal(ByVal pfecha As String) As Date
        Dim fecha As Date
        Dim OrdenarFecha() As String = pfecha.Split("/")
        Dim fechaString As String = OrdenarFecha(2) & "/" & OrdenarFecha(1) & "/" & OrdenarFecha(0)
        fecha = fechaString
        Return fecha
    End Function
    Public Sub AbrirPostick(ByVal id As Integer)
        PrecargarCombobox()
        Dim oPostick As New CEPostick
        oPostick = oCNPostick.BuscarPostick(id)
        NroPostick.Text = id
        NroPostick.Text = oPostick.IDPostick
        txtTitulo.Text = oPostick.Titulo
        dtpFecha.Text = oPostick.Fecha
        txtDescripcion.Text = oPostick.Descripcion
        cboPrioridad.Text = oPostick.Prioridad
        AsignarTextCbo(oPostick.Responsable, cboResponsable)

        ckbCompletado.Checked = oPostick.Estado


        If (ckbCompletado.Checked) Then
            Disesabletext()
        End If
    End Sub
    Public Sub Disesabletext()
        'este codigo es para desabilitar la edicion de todos los campos
        Dim ctrl As Control
        For Each ctrl In Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Enabled = False 'Creo que el error es aqui
            End If
        Next
        btnGuardarCambios.Visible = False
        btnGuardarNota.Visible = False
        btnCancelar.Text = "Cerrar"
        ckbCompletado.Enabled = False

    End Sub
    Public Function TomarDatos() As CEPostick





        Dim oCEPostick As New CEPostick
        oCEPostick.IDPostick = NroPostick.Text
        oCEPostick.Titulo = txtTitulo.Text
        oCEPostick.Descripcion = txtDescripcion.Text
        oCEPostick.Fecha = FormatISO8601(dtpFecha.Text)
        oCEPostick.Prioridad = cboPrioridad.Text
        oCEPostick.Estado = ckbCompletado.Checked
        oCEPostick.Responsable = cboResponsable.SelectedValue

        Return oCEPostick
    End Function
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
      

        Dim msg As String
        msg = Microsoft.VisualBasic.InputBox("Ingrese el motivo por el cual desea eliminar la tarea.", "Motivo de eliminacion", "", Me.Location.X, Me.Location.Y)
        If msg <> "" Then

            oCNPostick.EliminarPostick(CInt(NroPostick.Text), msg, frmMenuPrincipal.lblUsuario.Text)
            Me.Close()
        End If
    End Sub
    ' estp es para el combobox tenga colores
    Private Sub cboPrioridad_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cboPrioridad.DrawItem
        Dim ColorBajaPrioridad As Brush
        ColorBajaPrioridad = New Drawing.SolidBrush(Color.FromArgb(153, 196, 231))
        Dim ColorMediaPrioridad As Brush
        ColorMediaPrioridad = New Drawing.SolidBrush(Color.FromArgb(249, 237, 117))
        Dim ColorAltaPrioridad As Brush
        ColorAltaPrioridad = New Drawing.SolidBrush(Color.FromArgb(235, 134, 82))
        Dim ColorUrgentePrioridad As Brush
        ColorUrgentePrioridad = New Drawing.SolidBrush(Color.FromArgb(221, 83, 71))
        Select Case e.Index

            Case 0
                e.Graphics.FillRectangle(ColorBajaPrioridad, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                e.Graphics.DrawString(cboPrioridad.Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), e.Bounds)
                Exit Select
            Case 1
                e.Graphics.FillRectangle(ColorMediaPrioridad, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                e.Graphics.DrawString(cboPrioridad.Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), e.Bounds)
                Exit Select
            Case 2
                e.Graphics.FillRectangle(ColorAltaPrioridad, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                e.Graphics.DrawString(cboPrioridad.Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), e.Bounds)
                Exit Select
            Case 3
                e.Graphics.FillRectangle(ColorUrgentePrioridad, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                e.Graphics.DrawString(cboPrioridad.Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), e.Bounds)
                Exit Select

        End Select
    End Sub
    Public Sub PrecargarCombobox()
        'TODO: esta línea de código carga datos en la tabla 'SolemnoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SolemnoDataSet.Usuarios)
    End Sub
    Private Sub frmAgregarNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Me.cboPrioridad.Text = "") Then
            Me.cboPrioridad.SelectedIndex = 0
        End If

        dtpFecha.MinDate = New DateTime().Now

    End Sub

    Private Sub btnGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambios.Click
        oCNPostick.ModificarPostick(TomarDatos)
        Me.Close()

    End Sub

    Public Sub AsignarTextCbo(ByVal text As String, ByVal cbo As System.Object)

        Dim int As Integer
        int = cbo.FindString(text)
        cbo.SelectedIndex = int
    End Sub


End Class