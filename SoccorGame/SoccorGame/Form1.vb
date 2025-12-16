Public Class Form1
    Class Player
        Public Sub New(ByVal num, ByVal _x, ByVal _y)
            x = _x
            y = _y
        End Sub
        Public Sub Move()
            Dim r As Integer = Rnd() * 5
            Select Case r
                Case 1
                    x = x + 1
                Case 2
                    x = x - 1
                Case 3
                    y = y + 1
                Case 4
                    y = y - 1
            End Select
        End Sub
        Public num As Integer
        Public x As Integer
        Public y As Integer
        Public width As Integer = 32
        Public height As Integer = 32
    End Class
    Private bmp As Bitmap
    Private gnd As Bitmap
    Private sp1 As Bitmap
    Private Team(11) As Player
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim _g As Graphics
        _g = Graphics.FromImage(bmp)
        _g.DrawImage(gnd, 0, 0)
        For i = 0 To 10 Step 1
            Team(i).Move()
            _g.DrawImage(sp1, Team(i).x, Team(i).y)
        Next
        _g.Dispose()
        PictureBox1.Image = bmp
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        gnd = New Bitmap("..\..\Ground.png")
        sp1 = New Bitmap("..\..\SoccorPlayer1.png")
        Team(0) = New Player(0, 150, 100)
        Team(1) = New Player(1, 150, 200)
        Team(2) = New Player(2, 150, 300)
        Team(3) = New Player(3, 300, 100)
        Team(4) = New Player(4, 300, 200)
        Team(5) = New Player(5, 300, 300)
        Team(6) = New Player(6, 450, 100)
        Team(7) = New Player(7, 450, 200)
        Team(8) = New Player(8, 450, 300)
        Team(9) = New Player(9, 600, 100)
        Team(10) = New Player(10, 600, 200)
        Timer1.Start()
    End Sub
End Class
