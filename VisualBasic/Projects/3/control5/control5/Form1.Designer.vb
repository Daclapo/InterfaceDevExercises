<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirTextoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarTextoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFuenteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDeFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDeLetrasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarLetrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarBlancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarNumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeAbreUnaLetraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(13, 39)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 325)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 375)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(350, 40)
        Me.TextBox2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(375, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirTextoToolStripMenuItem1, Me.GuardarTextoToolStripMenuItem1, Me.CambiarFuenteToolStripMenuItem1, Me.ColorDeFondoToolStripMenuItem, Me.ColorDeLetrasToolStripMenuItem1})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.OpcionesToolStripMenuItem.Text = "opciones"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContarPalabrasToolStripMenuItem, Me.ContarLetrasToolStripMenuItem, Me.ContarBlancosToolStripMenuItem, Me.ContarNumerosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.HerramientasToolStripMenuItem.Text = "herramientas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeAbreUnaLetraToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AyudaToolStripMenuItem.Text = "ayuda"
        '
        'AbrirTextoToolStripMenuItem1
        '
        Me.AbrirTextoToolStripMenuItem1.Name = "AbrirTextoToolStripMenuItem1"
        Me.AbrirTextoToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.AbrirTextoToolStripMenuItem1.Text = "abrir texto"
        '
        'GuardarTextoToolStripMenuItem1
        '
        Me.GuardarTextoToolStripMenuItem1.Name = "GuardarTextoToolStripMenuItem1"
        Me.GuardarTextoToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.GuardarTextoToolStripMenuItem1.Text = "guardar texto"
        '
        'CambiarFuenteToolStripMenuItem1
        '
        Me.CambiarFuenteToolStripMenuItem1.Name = "CambiarFuenteToolStripMenuItem1"
        Me.CambiarFuenteToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.CambiarFuenteToolStripMenuItem1.Text = "cambiar fuente"
        '
        'ColorDeFondoToolStripMenuItem
        '
        Me.ColorDeFondoToolStripMenuItem.Name = "ColorDeFondoToolStripMenuItem"
        Me.ColorDeFondoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ColorDeFondoToolStripMenuItem.Text = "color de fondo"
        '
        'ColorDeLetrasToolStripMenuItem1
        '
        Me.ColorDeLetrasToolStripMenuItem1.Name = "ColorDeLetrasToolStripMenuItem1"
        Me.ColorDeLetrasToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ColorDeLetrasToolStripMenuItem1.Text = "color de letras"
        '
        'ContarPalabrasToolStripMenuItem
        '
        Me.ContarPalabrasToolStripMenuItem.Name = "ContarPalabrasToolStripMenuItem"
        Me.ContarPalabrasToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ContarPalabrasToolStripMenuItem.Text = "contar palabras"
        '
        'ContarLetrasToolStripMenuItem
        '
        Me.ContarLetrasToolStripMenuItem.Name = "ContarLetrasToolStripMenuItem"
        Me.ContarLetrasToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ContarLetrasToolStripMenuItem.Text = "contar letras"
        '
        'ContarBlancosToolStripMenuItem
        '
        Me.ContarBlancosToolStripMenuItem.Name = "ContarBlancosToolStripMenuItem"
        Me.ContarBlancosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ContarBlancosToolStripMenuItem.Text = "contar blancos"
        '
        'ContarNumerosToolStripMenuItem
        '
        Me.ContarNumerosToolStripMenuItem.Name = "ContarNumerosToolStripMenuItem"
        Me.ContarNumerosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ContarNumerosToolStripMenuItem.Text = "contar numeros"
        '
        'SeAbreUnaLetraToolStripMenuItem
        '
        Me.SeAbreUnaLetraToolStripMenuItem.Name = "SeAbreUnaLetraToolStripMenuItem"
        Me.SeAbreUnaLetraToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SeAbreUnaLetraToolStripMenuItem.Text = "se abre una letra"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 427)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirTextoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarTextoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarFuenteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDeFondoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDeLetrasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarPalabrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarLetrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarBlancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarNumerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeAbreUnaLetraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
