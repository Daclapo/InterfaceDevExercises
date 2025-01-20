Imports System.IO ' Importar System.IO para trabajar con archivos

Public Class Form1

    ' Ruta del archivo de log
    Private ReadOnly archivoLog As String = "LogNumerosGenerados.txt"

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
        ' Validar y mostrar mensaje de error dinámicamente
        If Not Comprobacion(TextBox1) Then
            Label3.Text = "El valor mínimo debe ser un número entero válido."
        Else
            Label3.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        ' Validar y mostrar mensaje de error dinámicamente
        If Not Comprobacion(TextBox2) Then
            Label3.Text = "El valor máximo debe ser un número entero válido."
        Else
            Label3.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown
        ' Si se presiona la tecla Enter y ambos TextBox son válidos, ejecutar la funcionalidad
        If e.KeyCode = Keys.Enter Then
            EjecutarSorteo()
        End If
    End Sub

    Private Function Comprobacion(ByVal textBox As TextBox) As Boolean
        ' Validar si el TextBox contiene un número entero válido
        Dim value As Integer
        If Not IsNumeric(textBox.Text) OrElse Not Integer.TryParse(textBox.Text, value) Then
            Return False
        End If
        Return True
    End Function

    Private Sub EjecutarSorteo()
        Try
            ' Verificar que ambos TextBox contienen valores válidos antes de generar el número aleatorio
            If Not Comprobacion(TextBox1) Or Not Comprobacion(TextBox2) Then
                Label3.Text = "Corrige los errores en las entradas de valores min y max antes de continuar."
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

            ' Mostrar el número generado en el Label
            Label3.Text = "Número generado:  " & vbCrLf & numero.ToString()

            ' Guardar el número en el archivo de log
            GuardarNumeroEnLog(numero)
        Catch ex As Exception
            ' Manejar cualquier error inesperado durante el sorteo
            Label3.Text = "Ocurrió un error al intentar realizar el sorteo. Inténtalo de nuevo."
        End Try
    End Sub

    Private Sub GuardarNumeroEnLog(ByVal numero As Integer)
        Try
            ' Intentar escribir el número generado en el archivo de log
            Dim texto As String = $"{DateTime.Now}: Número generado = {numero}"
            File.AppendAllText(archivoLog, texto & Environment.NewLine)
        Catch ex As Exception
            ' Manejar cualquier error relacionado con la escritura en el archivo
            Label3.Text = "Ocurrió un error al guardar el número en el archivo de log."
        End Try
    End Sub
End Class
