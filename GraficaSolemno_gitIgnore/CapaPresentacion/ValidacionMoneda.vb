Public Class ValidacionMoneda
    Private _labeltext As String
    Private _valor As Double
    Private _simbolo As String = "$"
    Public frmParent As AgregarProductoPedido
    Public Alto As Integer
    Public Ancho As Integer
    Public Sub SetSize(ByVal s As System.Drawing.Size)
        'Me.TextBox1.Size = s
        SimboloPeso.Visible = True
        ''New System.Drawing.Size(Altura, Ancho)
    End Sub


    Public Property labeltext As String
        Get
            Return _labeltext

        End Get
        Set(ByVal value As String)
            _labeltext = _simbolo
            SimboloPeso.Text = _simbolo
        End Set
    End Property

    Public Property valor As Double
        Get
            Return _valor

        End Get
        Set(ByVal value As Double)

            _valor = value
            mostrarValor()

        End Set
    End Property

    Public Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If TextBox1.Text = "0.00" Then
            TextBox1.Text = ""
        End If

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

        If e.Handled = False Then

            Dim value = TextBox1.Text.Replace("$", "").Trim().Replace(",", ".")
            Dim dou As Double
            Double.TryParse(value, dou)
            If dou > 1000000 Then

                e.Handled = True

            End If

        End If
    End Sub
    'verificar esto problema!
    'Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
    '    If TextBox1.Text = 0.0 Then
    '        TextBox1.Text = ""
    '    End If
    'End Sub


    Private Sub mostrarValor()
        TextBox1.Text = FormatNumber(_valor)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        Try
            Dim value = TextBox1.Text.Replace("$", "").Trim().Replace(",", ".")
            Double.TryParse(value, valor)

        Catch ex As Exception
            valor = 0
        End Try
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ValidacionMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



