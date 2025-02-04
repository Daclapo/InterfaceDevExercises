Public Class Form1

    Private WithEvents ContadorTimer As New Timer()

    Public Sub New()
        InitializeComponent()

        ContadorTimer.Interval = 1000 ' (1 sec)
        ContadorTimer.Start()

        Label1.Text = "20"
    End Sub

    Private Sub ContadorTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles ContadorTimer.Tick
        Static ContadorActual As Integer = 20

        If ContadorActual > 0 Then
            ContadorActual -= 1
            Label1.Text = ContadorActual.ToString()
        Else
            Label1.Text = "Terminó"
            ContadorTimer.Stop()
        End If
    End Sub

End Class
