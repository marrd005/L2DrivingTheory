Public Class HighwayCode

    Private Sub HighwayCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Process.Start(Application.StartupPath & "\Highwaycode.pdf")
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        PostLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class