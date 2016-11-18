Public Class MockTest
   Structure ExamQuestions
        Dim question As String
        Dim answer1 As String
        Dim answer2 As String
        Dim answer3 As String
        Dim correct As String
        Dim category As String
    End Structure
    Private Sub MockTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Remove(TimeLeftLabel)
        Me.Controls.Remove(Seconds)
        Me.Controls.Remove(TimeLeft)
    End Sub

    Private Sub StartTestBtn_Click(sender As Object, e As EventArgs) Handles StartTestBtn.Click
        Timer1.Start()
        Timer2.Start()
        Me.Controls.Add(Seconds)
        Me.Controls.Add(TimeLeftLabel)
        Me.Controls.Remove(StartTestBtn)
        Me.Controls.Add(TimeLeft)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLeft.Text = TimeLeft.Text - 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Seconds.Text = Seconds.Text - 1

        If Seconds.Text = 0 Then
            Seconds.Text = 60
        End If
    End Sub

    Private Sub TimeLeft_TextChanged(sender As Object, e As EventArgs) Handles TimeLeft.TextChanged
        If TimeLeft.Text = 0 Then
            MsgBox("Time's up!")
        End If
    End Sub
End Class