Imports System.IO
Imports System.Drawing

Public Class Form1
    Private Sub AbrirTextoToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AbrirTextoToolStripMenuItem1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = File.ReadAllText(openFileDialog.FileName)
            TextBox2.Text = "Texto cargado correctamente."
        End If
    End Sub

    Private Sub GuardarTextoToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GuardarTextoToolStripMenuItem1.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveFileDialog.FileName, TextBox1.Text)
            TextBox2.Text = "Texto guardado correctamente."
        End If
    End Sub

    Private Sub CambiarFuenteToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CambiarFuenteToolStripMenuItem1.Click
        Dim fontDialog As New FontDialog()

        If fontDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Font = fontDialog.Font
            TextBox2.Text = "Fuente cambiada correctamente."
        End If
    End Sub

    Private Sub ColorDeFondoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ColorDeFondoToolStripMenuItem.Click
        Dim colorDialog As New ColorDialog()

        If colorDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.BackColor = colorDialog.Color
            TextBox2.Text = "Color de fondo cambiado correctamente."
        End If
    End Sub

    Private Sub ColorDeLetrasToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ColorDeLetrasToolStripMenuItem1.Click
        Dim colorDialog As New ColorDialog()

        If colorDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.ForeColor = colorDialog.Color
            TextBox2.Text = "Color de letras cambiado correctamente."
        End If
    End Sub

    Private Sub ContarPalabrasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContarPalabrasToolStripMenuItem.Click
        Dim palabraCount = TextBox1.Text.Split(New Char() {" "c, vbLf, vbCr}, StringSplitOptions.RemoveEmptyEntries).Length
        TextBox2.Text = "Palabras: " & palabraCount
    End Sub

    Private Sub ContarLetrasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContarLetrasToolStripMenuItem.Click
        Dim letraCount = TextBox1.Text.Count(Function(c) Char.IsLetter(c))
        TextBox2.Text = "Letras: " & letraCount
    End Sub

    Private Sub ContarBlancosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContarBlancosToolStripMenuItem.Click
        Dim blancoCount = TextBox1.Text.Count(Function(c) Char.IsWhiteSpace(c))
        TextBox2.Text = "Espacios en blanco: " & blancoCount
    End Sub

    Private Sub ContarNumerosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContarNumerosToolStripMenuItem.Click
        Dim numeroCount = TextBox1.Text.Count(Function(c) Char.IsDigit(c))
        TextBox2.Text = "Números: " & numeroCount
    End Sub

    Private Sub SeAbreUnaLetraToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SeAbreUnaLetraToolStripMenuItem.Click
        MessageBox.Show("Este es un mensaje de ayuda.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TextBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim contextMenu As New ContextMenu()
            Dim limpiarItem As New MenuItem("Limpiar")

            AddHandler limpiarItem.Click, Sub()
                                              TextBox1.Clear()
                                              TextBox2.Text = "Texto limpiado."
                                          End Sub

            contextMenu.MenuItems.Add(limpiarItem)
            TextBox1.ContextMenu = contextMenu
        End If
    End Sub
End Class