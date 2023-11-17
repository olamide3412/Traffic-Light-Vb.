Public Class Splash

    Dim trafficAnimStop As Integer = 0

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If traffic_a_red.Visible = True Then
            traffic_a_yellow.Visible = True
            traffic_a_red.Visible = False

        ElseIf traffic_a_yellow.Visible = True Then
            traffic_a_green.Visible = True
            traffic_a_yellow.Visible = False

        ElseIf traffic_a_green.Visible = True Then
            traffic_a_green.Visible = False
            traffic_a_red.Visible = True

        End If


        trafficAnimStop = trafficAnimStop + 1

        If trafficAnimStop = 6 Then
            Timer1.Stop()
            traffic_a_red.Visible = True
            traffic_a_yellow.Visible = True
            traffic_a_green.Visible = True
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(2)

        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            ProgressBar1.Value = 0
            Form1.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Visible = True

        Timer2.Start()
        Timer1.Start()

    End Sub

   
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        End
    End Sub
End Class