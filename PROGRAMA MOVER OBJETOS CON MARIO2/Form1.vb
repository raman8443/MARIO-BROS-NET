Public Class Form1
    Dim x As Integer
    Dim y As Integer
    Dim mov As Boolean
    Dim movmario As Boolean
    Dim a As Boolean
    Dim b As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        y = 140
        mov = True
        movmario = True
        'tgeneralmover.Enabled = True

    End Sub
    Private Sub tgeneralmover_Tick(sender As Object, e As EventArgs) Handles tgeneralmover.Tick
        If mov = True Then
            x = x + 20
            pboxchampiñon.Location = New Point(x, 220)
            pboxgumball.Location = New Point(539, 109)
        End If
        If x > 695 Then
            mov = False
        End If
        If mov = False Then
            x = x - 20
            pboxchampiñon.Location = New Point(x, 220)
            pboxgumball.Location = New Point(400, 109)
        End If
        If x < 590 Then
            mov = True
        End If
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles derecha.Click


        pbmario.ImageLocation = "der.gif"
        pbmario.Left += 20

        'If pbmario.Location.X >= 340 And pbmario.Location.Y = 327 Then
        '    'x = x + 200
        '    pbmario.Location = New Point(x + 180, 327)


        'End If

        'If pbmario.Location.X >= 380 Then
        '    'x = x - 50
        '    pbmario.Location = New Point(x, 327)
        '    pbmario.ImageLocation = "der.gif"
        '    pbmario.Left += 20

        'End If


    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles izquierda.Click
        'If pbmario.Location.X >= 380 Then
        '    pbmario.Location = New Point(340, 227)



        'End If
        pbmario.ImageLocation = "izq.gif"
        pbmario.Left -= 20
        'If pbmario.Location.X >= 216 Then
        '    pbmario.Location = New Point(356, 327)


        'End If
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        'tmArriba.Enabled = True
        'Timer1.Enabled = True
        'movmario = True
        'pbmario.ImageLocation = "mariosalta1.gif"
        pbmario.Top -= 15
        pbmario.Top -= 15
        pbmario.Top += 5
        pbmario.Left += 1
        pbmario.Top += 5
        pbmario.Top += 5
        pbmario.Top += 5
        pbmario.Top += 5
        pbmario.Top += 5
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click

        tmostrayochi.Enabled = True
        tborraryochi.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If movmario = True Then
            x = +10
            pbmario.Location = New Point(x, 218)

        End If
        If x > 200 Then
            movmario = False
        End If
        If movmario = False Then
            x = x - 30
            pbmario.Location = New Point(x, 218)

        End If
        If y < 300 Then
            movmario = False
        End If


        'pbmario.Left += 50
        'pbmario.Left -= 50
        ''pbmario.Top -= 50
        'pbmario.Left += 50

        'pboxyochi.Visible = True
        'PictureBox1.Visible = False
        'PictureBox2.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'pboxyochi.Visible = False
        'PictureBox1.Visible = True
        ''PictureBox2.Visible = False

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'pboxyochi.Visible = False
        'PictureBox1.Visible = False
        'PictureBox2.Visible = True
    End Sub

    Private Sub tmoversolo_Tick(sender As Object, e As EventArgs) Handles tmoversolo.Tick
        pbmario.Left += 10
    End Sub



    Private Sub tmoversoloatras_Tick(sender As Object, e As EventArgs) Handles tmoversoloatras.Tick
        pbmario.Left -= 10
    End Sub

    Private Sub tmoversolochamp_Tick(sender As Object, e As EventArgs) Handles tmoversolochamp.Tick

        pboxchampiñon.Left += 10
        pboxchampiñon.Left += 10
        pboxchampiñon.Left -= 10
        pboxchampiñon.Left -= 10
    End Sub

    Private Sub nudowmostrar_ValueChanged(sender As Object, e As EventArgs) Handles nudowmostrar.ValueChanged
        If nudowmostrar.Value = 0 Then
            pboxmostar.Visible = False
        Else
            pboxmostar.Visible = True
            pboxmostar.ImageLocation = nudowmostrar.Value & ".jpg"
        End If
    End Sub



    Private Sub pboxchampiñon_Click(sender As Object, e As EventArgs) Handles pboxchampiñon.Click

    End Sub

    Private Sub pbmario_Click(sender As Object, e As EventArgs) Handles pbmario.Click

    End Sub

    Private Sub tmArriba_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmArriba.Tick
        pbmario.Top -= 25
        If pbmario.Location.Y = 200 Then
            tmArriba.Enabled = False
        Else
            tmAbajo.Enabled = True

        End If
    End Sub

    Private Sub tmAbajo_Tick(sender As Object, e As EventArgs) Handles tmAbajo.Tick
        pbmario.Top += 25
        If pbmario.Location.Y = 300 Then
            tmAbajo.Enabled = False
        Else
            tmArriba.Enabled = True
        End If
    End Sub
    'Public Function Colision(ByVal a As PictureBox, ByVal b As Label) As Boolean
    '    If (a.Location.X < b.Location.X + b.Width) And (b.Location.X < a.Location.X + a.Width) And (a.Location.Y < b.Location.X) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    Private Sub tborraryochi_Tick(sender As Object, e As EventArgs) Handles tborraryochi.Tick

    End Sub

    Private Sub tmostrayochi_Tick(sender As Object, e As EventArgs) Handles tmostrayochi.Tick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.mario, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If pbmario.Location.Y = 327 Then
            pbmario.Location = New Point(303, 223)
        End If


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If pbmario.Location.Y = 223 Then
            pbmario.Location = New Point(389, 327)
        End If
    End Sub
End Class
