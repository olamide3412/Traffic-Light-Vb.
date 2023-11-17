Public Class Form1

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

            Timer1.Stop()
            Timer2.Start()


        End If







    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick



        If traffic_b_red.Visible = True Then
            traffic_b_yellow.Visible = True
            traffic_b_red.Visible = False

        ElseIf traffic_b_yellow.Visible = True Then
            traffic_b_green.Visible = True
            traffic_b_yellow.Visible = False

        ElseIf traffic_b_green.Visible = True Then
            traffic_b_green.Visible = False
            traffic_b_red.Visible = True

            Timer2.Stop()
            Timer3.Start()

        End If

       
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        If traffic_c_red.Visible = True Then
            traffic_c_yellow.Visible = True
            traffic_c_red.Visible = False

        ElseIf traffic_c_yellow.Visible = True Then
            traffic_c_green.Visible = True
            traffic_c_yellow.Visible = False

        ElseIf traffic_c_green.Visible = True Then
            traffic_c_green.Visible = False
            traffic_c_red.Visible = True

            Timer3.Stop()
            Timer4.Start()


        End If


    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If traffic_d_red.Visible = True Then
            traffic_d_yellow.Visible = True
            traffic_d_red.Visible = False

        ElseIf traffic_d_yellow.Visible = True Then
            traffic_d_green.Visible = True
            traffic_d_yellow.Visible = False

        ElseIf traffic_d_green.Visible = True Then
            traffic_d_green.Visible = False
            traffic_d_red.Visible = True

            Timer4.Stop()
            Timer1.Start()


        End If

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Timer1.Start()
        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        traffic_a_red.Visible = True
        traffic_a_yellow.Visible = False
        traffic_a_green.Visible = False


        traffic_b_red.Visible = True
        traffic_b_yellow.Visible = False
        traffic_b_green.Visible = False



        traffic_c_red.Visible = True
        traffic_c_yellow.Visible = False
        traffic_c_green.Visible = False


        traffic_d_red.Visible = True
        traffic_d_yellow.Visible = False
        traffic_d_green.Visible = False



        
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Splash.Show()
        Me.Dispose()

    End Sub
End Class
