Imports System.IO ' Importar System.IO para trabajar con archivos

Public Class Form1

    ' Ruta del archivo de log
    Private ReadOnly archivoLog As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\LogNumerosGenerados.txt")

    Public Sub New()
        InitializeComponent()

        ' Evitar que la ventana sea redimensionable
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EjecutarSorteo()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ValidarEntradas()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        ValidarEntradas()
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            EjecutarSorteo()
        End If
    End Sub

    Private Sub ValidarEntradas()
        ' Validar dinámicamente y mostrar errores en el Label
        If Not Comprobacion(TextBox1) Then
            Label3.Text = "El valor mínimo debe ser un número entero válido."
        ElseIf Not Comprobacion(TextBox2) Then
            Label3.Text = "El valor máximo debe ser un número entero válido."
        Else
            Label3.Text = String.Empty
        End If
    End Sub

    Private Function Comprobacion(ByVal textBox As TextBox) As Boolean
        ' Validar si el TextBox contiene un número entero válido
        Dim value As Integer
        Return Integer.TryParse(textBox.Text, value)
    End Function

    Private Sub EjecutarSorteo()
        Try
            If Not Comprobacion(TextBox1) OrElse Not Comprobacion(TextBox2) Then
                Label3.Text = "Corrige los errores en las entradas de valores antes de continuar."
                Return
            End If

            Dim min As Integer = CInt(TextBox1.Text)
            Dim max As Integer = CInt(TextBox2.Text)

            If min > max Then
                Label3.Text = "El valor mínimo no puede ser mayor que el máximo."
                Return
            End If

            Dim aleatorio As New Random()
            Dim numero As Integer = aleatorio.Next(min, max + 1)

            Label3.Text = "Número generado: " & vbCrLf & numero.ToString()

            GuardarNumeroEnLog(numero)
        Catch ex As Exception
            Label3.Text = "Error al realizar el sorteo: " & ex.Message
        End Try
    End Sub

    Private Sub GuardarNumeroEnLog(ByVal numero As Integer)
        Try
            Dim texto As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & ": Número generado = " & numero.ToString()
            File.AppendAllText(archivoLog, texto & Environment.NewLine)
            Label3.Text &= vbCrLf & "El resultado se guardó en: " & archivoLog
        Catch ex As Exception
            Label3.Text = "Error al guardar en el archivo de log: " & ex.Message
        End Try
    End Sub
End Class
