Imports System.Net.Security

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If policePictureBox.Location.Y > diddyPictureBox.Location.Y Then
            move(diddyPictureBox, 0, -5)
        Else
            move(diddyPictureBox, 0, 5)
        End If
        If diddyPictureBox.Location.X > policePictureBox.Location.X Then
            move(diddyPictureBox, -5, 0)
        Else
            move(diddyPictureBox, 5, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(diddyPictureBox, -5, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(diddyPictureBox, +5, 0)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.S Then
            move(diddyPictureBox, 0, -5)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(diddyPictureBox, 0, 5)
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.W Then
            diddyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        diddyPictureBox.Refresh()

    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

    End Sub
End Class
