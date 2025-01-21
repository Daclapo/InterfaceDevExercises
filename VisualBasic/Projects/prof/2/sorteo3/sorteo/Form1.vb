Public Class Form1
    'Entrada de datos por combobox
    'Rellenar combobox.items

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Introduce dos numeros y pulsa SORTEO"
        rellenaCombo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As New Random
        Label1.Text = r.Next(ComboBox1.SelectedItem, ComboBox2.SelectedItem + 1)
    End Sub

    Private Sub rellenaCombo()
        For j As Integer = 1 To 10
            Debug.Print(j)
            ComboBox1.Items.Add(j)
            ' Debug.Print("hola" & j)
            ' Debug.window inmediate,local,watch
            ComboBox2.Items.Add(j)
        Next
    End Sub

End Class
