Module Module1

    Public Sub Main()
        Form1.ShowDialog()
        Dim form2 = New Form2

        form2.Text = "form2, hola que tal"
        form2.ShowDialog()
    End Sub

    Class Form2
        Inherits Form

    End Class


End Module
