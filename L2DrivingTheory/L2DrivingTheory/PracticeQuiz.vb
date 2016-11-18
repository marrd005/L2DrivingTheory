Imports System.Net.Mail
Imports System.Data.OleDb
Public Class PracticeQuiz
    Dim completed As Boolean = False
    Public Shared QuizPoints As Integer = 0
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Dim emailaddress As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Structure ExamQuestions
        Dim question As String
        Dim answer1 As String
        Dim answer2 As String
        Dim answer3 As String
        Dim correct As String
        Dim category As String
    End Structure
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider =Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Logins.accdb")
        conn.Open()
    End Sub
    Private Sub PracticeQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TestQuestions(100) As ExamQuestions
        TestQuestions(0).question = "When you are driving whent tired, what should you do?"
        TestQuestions(0).answer1 = "Take a nap at the wheel"
        TestQuestions(0).answer2 = "Pull over onto the hard shoulder"
        TestQuestions(0).answer3 = "Open a window"
        TestQuestions(0).correct = "Stop at the nearest service station and rest"
        TestQuestions(0).category = "Awareness"



        If completed = True Then
            Dim Mail As New MailMessage
            Mail.Subject = "Practice Quiz Results"
            Mail.To.Add("spam@mailinator.com")
            Mail.From = New MailAddress("l2drivingtheory@gmail.com")
            Mail.Body = "On this test you scored " & QuizPoints

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("l2drivingtheory", "drivingtheory")
            SMTP.Port = "587"
            SMTP.Send(Mail)
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged

    End Sub

    Private Sub StartQuizBtn_Click(sender As Object, e As EventArgs) Handles StartQuizBtn.Click
        Me.Controls.Remove(CheckBox1)
        Me.Controls.Remove(CheckBox2)
        Me.Controls.Remove(CheckBox3)
        Me.Controls.Remove(CheckBox4)
        Me.Controls.Remove(CheckBox5)
        Me.Controls.Remove(CheckBox6)
        Me.Controls.Remove(CheckBox7)
        Me.Controls.Remove(CheckBox8)
        Me.Controls.Remove(CheckBox9)
        Me.Controls.Remove(StartQuizBtn)
        Me.Controls.Remove(CheckBox10)
        Me.Controls.Remove(CheckBox11)
        Me.Controls.Remove(CheckBox12)
        Me.Controls.Remove(CheckBox13)
        Me.Controls.Remove(CheckBox14)
        Me.Controls.Remove(Logo)
        Me.Controls.Remove(QuizIMG)
    End Sub
End Class