Public Class HazardPerception
    Dim second As Integer = 0
    Dim pointsScored As Integer = 0
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        PostLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub Clip1Btn_Click(sender As Object, e As EventArgs) Handles Clip1Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
        Me.Controls.Add(Clip1)
    End Sub

    Private Sub HazardPerception_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Remove(HazardSpottedBtn)
        Me.Controls.Remove(Clip1)
    End Sub

    Private Sub Clip2Btn_Click(sender As Object, e As EventArgs) Handles Clip2Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip3Btn_Click(sender As Object, e As EventArgs) Handles Clip3Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip4Btn_Click(sender As Object, e As EventArgs) Handles Clip4Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip5Btn_Click(sender As Object, e As EventArgs) Handles Clip5Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip6Btn_Click(sender As Object, e As EventArgs) Handles Clip6Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip7Btn_Click(sender As Object, e As EventArgs) Handles Clip7Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip8Btn_Click(sender As Object, e As EventArgs) Handles Clip8Btn.Click
        Me.Controls.Remove(Clip1Btn)
        Me.Controls.Remove(Clip2Btn)
        Me.Controls.Remove(Clip3Btn)
        Me.Controls.Remove(Clip4Btn)
        Me.Controls.Remove(Clip5Btn)
        Me.Controls.Remove(Clip6Btn)
        Me.Controls.Remove(Clip7Btn)
        Me.Controls.Remove(Clip8Btn)
        Me.Controls.Remove(BackBtn)
        Me.Controls.Remove(ExitBtn)
        Me.Controls.Remove(HPIntro)

        Me.Controls.Add(HazardSpottedBtn)
    End Sub

    Private Sub Clip1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Clip1.DocumentCompleted

    End Sub

    Private Sub HazardSpottedBtn_Click(sender As Object, e As EventArgs) Handles HazardSpottedBtn.Click
        If second = 30 Then
            pointsScored = pointsScored + 5
        ElseIf second = 31 Then
            pointsScored = pointsScored + 4
        ElseIf second = 32 Then
            pointsScored = pointsScored + 3
        ElseIf second = 33 Then
            pointsScored = pointsScored + 2
        ElseIf second = 34 Then
            pointsScored = pointsScored + 1
        End If

        If second = 52 Then
            Timer1.Stop()
            MsgBox(pointsScored)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
    End Sub
End Class