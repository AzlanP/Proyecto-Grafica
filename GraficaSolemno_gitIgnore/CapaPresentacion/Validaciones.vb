Imports System.Text.RegularExpressions

Public Class Validaciones
    Public Sub Validar(ByVal formulario As Windows.Forms.Form)
        For Each obj In formulario.Controls
            If TypeOf obj Is TextBox Then

                Dim txt As TextBox = obj
                If txt.Tag = "" Then

                ElseIf txt.Tag = 1 Then
                    AddHandler txt.KeyPress, AddressOf keypressValidacionLetras
                ElseIf txt.Tag = 2 Then
                    AddHandler txt.KeyPress, AddressOf keypressValidacionNumeros
                ElseIf txt.Tag = 3 Then
                    AddHandler txt.KeyPress, AddressOf keypressValidacionAlfaNumerico
                ElseIf txt.Tag = 4 Then
                    AddHandler txt.KeyPress, AddressOf keypressValidarEmail
                    AddHandler txt.LostFocus, AddressOf EmailLostFocus
                ElseIf txt.Tag = 5 Then
                    AddHandler txt.KeyPress, AddressOf KeypressValidarCantidad


                End If

            End If
        Next
    End Sub

    Public Sub keypressValidacionLetras(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub keypressValidacionNumeros(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub keypressValidacionAlfaNumerico(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub keypressValidarEmail(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "@" Or e.KeyChar = "." Or e.KeyChar = "_" Or e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
    Private Sub EmailLostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = sender
        Dim rex As String = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If (Regex.IsMatch(txt.Text, rex)) Then
            MsgBox("aceptado")
        Else

            MsgBox("Email, no valido, Ejemplo usuario@dominio.com")
            txt.Text = ""
        End If
    End Sub

    Public Sub KeypressValidarCantidad(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim txt As TextBox = sender
        If Char.IsDigit(e.KeyChar) Then

            If CInt(txt.Text + e.KeyChar) > 99 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
