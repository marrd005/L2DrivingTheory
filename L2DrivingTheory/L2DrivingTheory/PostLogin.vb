Public Class PostLogin
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub HighwayCodeBtn_Click(sender As Object, e As EventArgs) Handles HighwayCodeBtn.Click
        HighwayCode.Show()
        Me.Hide()
    End Sub

    Private Sub HazardPerceptionBtn_Click(sender As Object, e As EventArgs) Handles HazardPerceptionBtn.Click
        HazardPerception.Show()
        Me.Close()
    End Sub

    Private Sub MockTestBtn_Click(sender As Object, e As EventArgs) Handles MockTestBtn.Click
        MockTest.Show()
        Me.Hide()
    End Sub

    Private Sub PracticeQuizBtn_Click(sender As Object, e As EventArgs) Handles PracticeQuizBtn.Click
        PracticeQuiz.Show()
        Me.Hide()
    End Sub

    Private Sub PostLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLabel.Text = "Welcome " & userforename
    End Sub

    Private Sub StudyBtn_Click(sender As Object, e As EventArgs) Handles StudyBtn.Click
        Study.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles WelcomeLabel.Click
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles DateTime.Click
        DateTime.Text = DateTime.ToString("yyyy/mm/dd HH:mm:ss")
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
