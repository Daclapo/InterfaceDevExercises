Public Class Form1

    Public Sub New()
        InitializeComponent()

        ' Evitar que la ventana sea redimensionable
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
    End Sub

    ' Método que se ejecuta cuando el formulario se carga
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Rellenar los ComboBox con los números del -100 al 100, ya ordenados
        For n As Integer = -100 To 100
            ComboBox1.Items.Add(n)
            ComboBox2.Items.Add(n)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'EjecutarSorteo()

        ' Verificar que haya selección en los ComboBox
        If ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem IsNot Nothing Then
            Label3.Text = (New Random).Next(CInt(ComboBox1.SelectedItem), CInt(ComboBox2.SelectedItem) + 1).ToString()
            Debug.Print(Label3.Text)
        Else
            Label3.Text = "Seleccione ambos valores."
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Validar y mostrar mensaje de error dinámicamente
        If Not Comprobacion(TextBox1) Then
            Label3.Text = "El valor mínimo debe ser un número entero válido."
        Else
            Label3.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Validar y mostrar mensaje de error dinámicamente
        If Not Comprobacion(TextBox2) Then
            Label3.Text = "El valor máximo debe ser un número entero válido."
        Else
            Label3.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs)
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

        Label3.Text = "Número generado:  " & vbCrLf & numero.ToString()

    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
