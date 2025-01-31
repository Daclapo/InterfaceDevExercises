Public Class Form1
    Private contador As Integer = 0

    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArchivoToolStripMenuItem.Click
        EjecutarToolStripMenuItem.Visible = True
    End Sub

    Private Sub OtraToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OtraToolStripMenuItem.Click
        Label1.Text = "otra"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Label1.Text = "open"
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseToolStripMenuItem.Click
        Label1.Text = "close"
    End Sub

    Private Sub BastaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BastaToolStripMenuItem.Click
        ApagadoToolStripMenuItem.Enabled = True
        ApagadoToolStripMenuItem.Text = "encendido"
    End Sub

    Private Sub SoyAzulToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SoyAzulToolStripMenuItem.Click
        Label1.BackColor = Color.Blue
    End Sub

    Private Sub SoyRojoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SoyRojoToolStripMenuItem.Click
        Label1.BackColor = Color.Red
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel1.Click
        Label1.Text = "soy un icono"
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ToolStripProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        contador += 1
        If contador = 100 Then
            Timer1.[Stop]()
            Label2.Visible = False
            ToolStripProgressBar1.Visible = False
        End If
        Label2.Text = contador.ToString()
        ToolStripProgressBar1.Value = contador
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        dale()
    End Sub

    Private Sub dale()
        For num As Integer = 1 To 10000
            Button1.Text = num.ToString()
            Application.DoEvents()
        Next
        Button1.Visible = False
    End Sub

    ' Eventos vacíos necesarios para la estructura
    Private Sub SssToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SssToolStripMenuItem.Click
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
    End Sub
End Class