Public Class Form1
    Public Sub New()
        InitializeComponent()

        Me.Size = New Drawing.Size(300, 400)
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim txtDisplay As New TextBox()
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Font = New Font("Arial", 16)
        txtDisplay.TextAlign = HorizontalAlignment.Right
        txtDisplay.ReadOnly = True
        txtDisplay.Dock = DockStyle.Top
        txtDisplay.Height = 50
        Me.Controls.Add(txtDisplay)

        Dim grpButtons As New GroupBox()
        grpButtons.Text = "Controles"
        grpButtons.Dock = DockStyle.Fill
        Me.Controls.Add(grpButtons)

        Dim tablePanel As New TableLayoutPanel()
        tablePanel.Dock = DockStyle.Fill
        tablePanel.RowCount = 5
        tablePanel.ColumnCount = 4
        tablePanel.ColumnStyles.Clear()
        tablePanel.RowStyles.Clear()

        For i As Integer = 0 To 3
            tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25))
        Next
        For i As Integer = 0 To 4
            tablePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20))
        Next

        grpButtons.Controls.Add(tablePanel)

        Dim btn7 As New Button() With {.Text = "7", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn7, 0, 0)
        Dim btn8 As New Button() With {.Text = "8", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn8, 1, 0)
        Dim btn9 As New Button() With {.Text = "9", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn9, 2, 0)
        Dim btnDiv As New Button() With {.Text = "/", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnDiv, 3, 0)

        Dim btn4 As New Button() With {.Text = "4", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn4, 0, 1)
        Dim btn5 As New Button() With {.Text = "5", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn5, 1, 1)
        Dim btn6 As New Button() With {.Text = "6", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn6, 2, 1)
        Dim btnMul As New Button() With {.Text = "*", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnMul, 3, 1)

        Dim btn1 As New Button() With {.Text = "1", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn1, 0, 2)
        Dim btn2 As New Button() With {.Text = "2", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn2, 1, 2)
        Dim btn3 As New Button() With {.Text = "3", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn3, 2, 2)
        Dim btnSub As New Button() With {.Text = "-", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnSub, 3, 2)

        Dim btnC As New Button() With {.Text = "C", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnC, 0, 3)
        Dim btn0 As New Button() With {.Text = "0", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btn0, 1, 3)
        Dim btnDot As New Button() With {.Text = ".", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnDot, 2, 3)
        Dim btnAdd As New Button() With {.Text = "+", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnAdd, 3, 3)

        Dim btnEmpty1 As New Button() With {.Visible = False}
        tablePanel.Controls.Add(btnEmpty1, 0, 4)
        Dim btnEmpty2 As New Button() With {.Visible = False}
        tablePanel.Controls.Add(btnEmpty2, 1, 4)
        Dim btnEq As New Button() With {.Text = "=", .Font = New Font("Arial", 12), .Dock = DockStyle.Fill}
        tablePanel.Controls.Add(btnEq, 2, 4)
        Dim btnEmpty3 As New Button() With {.Visible = False}
        tablePanel.Controls.Add(btnEmpty3, 3, 4)
    End Sub
End Class
