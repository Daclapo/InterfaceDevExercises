Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim nVeces As Integer = Integer.Parse(TextBox1.Text)
            Dim res As String = GenerarLetras(nVeces)
            TextBox2.AppendText(res & vbCrLf)
        Catch ex As Exception
            MessageBox.Show("Por favor, introduce un número válido en el TextBox1.")
        End Try
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim nVeces As Integer = Integer.Parse(TextBox1.Text)
            Dim res As String = GenerarNumeros(nVeces)
            TextBox2.AppendText(res & Environment.NewLine)
        Catch ex As Exception
            MessageBox.Show("Por favor, introduce un número válido en el TextBox1.")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim nVeces As Integer = Integer.Parse(TextBox1.Text)
            Dim res As String = GenerarSimbolos(nVeces)
            TextBox2.AppendText(res & Environment.NewLine)
        Catch ex As Exception
            MessageBox.Show("Por favor, introduce un número válido en el TextBox1.")
        End Try
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub



    Private Function GenerarLetras(ByVal nVeces As Integer) As String
        Dim rand As New Random()
        Dim res As String = ""
        For i As Integer = 1 To nVeces
            Dim letra As Char = Chr(rand.Next(65, 91))
            res &= letra
        Next
        Return res
    End Function


    Private Function GenerarNumeros(ByVal nVeces As Integer) As String
        Dim rand As New Random()
        Dim res As String = ""
        For i As Integer = 1 To nVeces
            Dim num As Integer = rand.Next(0, 10)
            res &= num
        Next
        Return res
    End Function


    Private Function GenerarSimbolos(ByVal nVeces As Integer) As String
        Dim rand As New Random()
        Dim simbolos As String = "!@#$%^&*()_+{}[]|:;<>,.?/"
        Dim res As String = ""
        For i As Integer = 1 To nVeces
            Dim simbolo As Char = simbolos(rand.Next(0, simbolos.Length))
            res &= simbolo
        Next
        Return res
    End Function



    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("No hay texto para copiar.")
        Else
            Clipboard.SetText(TextBox2.Text)
            MessageBox.Show("Texto copiado al portapapeles.")
        End If
    End Sub

End Class
