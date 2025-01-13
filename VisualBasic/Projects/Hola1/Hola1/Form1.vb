Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClientSize = New System.Drawing.Size(500, 200)
        Label1.Text = "Doble clic para maximizar la ventana."
    End Sub


    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.ClientSize = New System.Drawing.Size(600, 200)
    End Sub

    Private Sub Form1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        BackColor = Color.Red
        reset()
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        BackColor = Color.Green
        reset()
        CheckBox1.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        BackColor = Color.Blue
        reset()
        CheckBox2.Checked = False
        CheckBox1.Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.BackColor = System.Drawing.SystemColors.ControlDark
        BackColor = System.Drawing.SystemColors.ControlDark
    End Sub


    Sub reset()
        If (CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Unchecked And CheckBox3.CheckState = CheckState.Unchecked) Then
            Me.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub botonVacio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button3.Click
        MsgBox("Botón sin contenido")
    End Sub

End Class
