﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static contador As Integer = 20
        If contador = -1 Then
            TextBox1.Text = "termino"
            Timer1.Enabled = False
        Else
            TextBox1.Text = contador
            contador -= 1
        End If

    End Sub

End Class