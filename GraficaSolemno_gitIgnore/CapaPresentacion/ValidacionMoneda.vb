﻿Public Class ValidacionMoneda
    Private _labeltext As String
    Private _valor As Double
    Private _simbolo As String

    Public Property labeltext As String
        Get
            Return _labeltext

        End Get
        Set(ByVal value As String)
            _labeltext = value
            SimboloPeso.Text = value
        End Set
    End Property
    Public Property valor As Double
        Get
            Return _valor

        End Get
        Set(ByVal value As Double)
            _valor = value
            TextBox1.Text = _simbolo & FormatNumber(valor)

        End Set
    End Property

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Or e.KeyChar = "." Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        If TextBox1.Text = 0.0 Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        Try
            valor = TextBox1.Text
        Catch ex As Exception
            valor = 0
        End Try
    End Sub

    
End Class