Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic


Partial Public Class Form1
    Inherits Form

    Private barra As String
    Private Max As Integer
    Private Min As Integer
    Private salto As Double
    Private valRojo As Integer
    Private valVerde As Integer
    Private valAzul As Integer
    Private direccionRojo As Integer
    Private direccionVerde As Integer
    Private direccionAzul As Integer
    Private estadoRojo As Integer
    Private estadoVerde As Integer
    Private estadoAzul As Integer


    Public Sub New()
        MyBase.New()
        InitializeComponent()

        barra = "abcdefghijklmnopqrstuvwxyz"
        Max = 255
        Min = 125
        salto = (Max - Min) / barra.Length
        valRojo = Min
        valVerde = Min
        valAzul = Min

        'flags
        direccionRojo = -1
        direccionVerde = -1
        direccionAzul = -1
        estadoRojo = 0
        estadoVerde = 0
        estadoAzul = 0
    End Sub




    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If estadoRojo = 0 Then
            estadoRojo = 1
            Timer1.Start()
            If direccionRojo <> 1 Then
                direccionRojo = 1
            Else
                direccionRojo = -1
            End If
        Else
            estadoRojo = 0
            Timer1.Stop()
        End If
        Button1.Text = sentido(estadoRojo, direccionRojo).ToString()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If estadoVerde = 0 Then
            estadoVerde = 1
            Timer2.Start()
            If direccionVerde <> 1 Then
                direccionVerde = 1
            Else
                direccionVerde = -1
            End If
        Else
            estadoVerde = 0
            Timer2.Stop()
        End If
        Button2.Text = sentido(estadoVerde, direccionVerde).ToString()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        If estadoAzul = 0 Then
            estadoAzul = 1
            Timer3.Start()
            If direccionAzul <> 1 Then
                direccionAzul = 1
            Else
                direccionAzul = -1
            End If
        Else
            estadoAzul = 0
            Timer3.Stop()
        End If
        Button3.Text = sentido(estadoAzul, direccionAzul).ToString()
    End Sub





    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        TextBox2.Text = valRojo.ToString()
        TextBox2.BackColor = System.Drawing.Color.FromArgb(CByte(valRojo), 0, 0)
        color()

        Dim temp As Double = (valRojo - Min) / salto
        Dim lenVal As Integer = CInt(Math.Round(temp))
        TextBox1.Text = Microsoft.VisualBasic.Left(barra, lenVal)

        valRojo = valRojo + direccionRojo
        If valRojo > Max Then
            valRojo = Max
            estadoRojo = 0
        End If
        If valRojo < Min Then
            valRojo = Min
            estadoRojo = 0
        End If
        Button1.Text = sentido(estadoRojo, direccionRojo).ToString()
    End Sub


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        TextBox3.Text = valVerde.ToString()
        TextBox3.BackColor = System.Drawing.Color.FromArgb(0, CByte(valVerde), 0)
        color()

        Dim temp As Double = (valVerde - Min) / salto
        Dim lenVal As Integer = CInt(Math.Round(temp))
        TextBox4.Text = Microsoft.VisualBasic.Left(barra, lenVal)

        valVerde = valVerde + direccionVerde
        If valVerde > Max Then
            valVerde = Max
            estadoVerde = 0
        End If
        If valVerde < Min Then
            valVerde = Min
            estadoVerde = 0
        End If
        Button2.Text = sentido(estadoVerde, direccionVerde).ToString()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer3.Tick
        TextBox5.Text = valAzul.ToString()
        TextBox5.BackColor = System.Drawing.Color.FromArgb(0, 0, CByte(valAzul))
        color()

        Dim temp As Double = (valAzul - Min) / salto
        Dim lenVal As Integer = CInt(Math.Round(temp))
        TextBox6.Text = Microsoft.VisualBasic.Left(barra, lenVal)

        valAzul = valAzul + direccionAzul
        If valAzul > Max Then
            valAzul = Max
            estadoAzul = 0
        End If
        If valAzul < Min Then
            valAzul = Min
            estadoAzul = 0
        End If
        Button3.Text = sentido(estadoAzul, direccionAzul).ToString()
    End Sub

    Private Sub color()
        Dim hexColor As String = "#" & valRojo.ToString("X2") & valVerde.ToString("X2") & valAzul.ToString("X2")
        TextBox7.BackColor = ColorTranslator.FromHtml(hexColor)
    End Sub



    Public Function sentido(ByVal a As Object, ByVal b As Object) As Object
        If Not a.Equals(0) Then
            If Not b.Equals(1) Then
                Return "<<"
            Else
                Return ">>"
            End If
        Else
            Return "="
        End If
    End Function



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        TextBox1.Text = barra
        TextBox4.Text = barra
        TextBox6.Text = barra
        TextBox1.Visible = False
        TextBox4.Visible = False
        TextBox6.Visible = False
        Dim height As Integer = 38

        TextBox1.Size = New Size(471, height)
        TextBox4.Size = New Size(471, height)
        TextBox6.Size = New Size(471, height)
        TextBox2.Size = New Size(116, height)
        TextBox3.Size = New Size(116, height)
        TextBox5.Size = New Size(116, height)
        TextBox7.Size = New Size(666, height)
        TextBox8.Size = New Size(666, height)
        Button1.Size = New Size(67, height)
        Button2.Size = New Size(67, height)
        Button3.Size = New Size(67, height)
    End Sub


    Public Sub personalizarColor()
        ColorDialog1.Color = SystemColors.Control
        Dim res As DialogResult = ColorDialog1.ShowDialog()

        Me.BackColor = ColorDialog1.Color
    End Sub





    Private Sub ColorToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ColorToolStripMenuItem2.Click
        personalizarColor()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ColorToolStripMenuItem.Click
        personalizarColor()
    End Sub

    Private Sub DefectoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefectoToolStripMenuItem.Click
        Me.BackColor = SystemColors.Control
    End Sub

    Private Sub DefectoToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefectoToolStripMenuItem1.Click
        Me.BackColor = SystemColors.Control
    End Sub


    Private Sub Timer1ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1ToolStripMenuItem.Click
        TextBox1.Visible = True
        Timer1ToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Timer2ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2ToolStripMenuItem.Click
        TextBox4.Visible = True
        Timer2ToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Timer3ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Timer3ToolStripMenuItem.Click
        TextBox6.Visible = True
        Timer3ToolStripMenuItem.Enabled = False
    End Sub


    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Dispose()
    End Sub


End Class
