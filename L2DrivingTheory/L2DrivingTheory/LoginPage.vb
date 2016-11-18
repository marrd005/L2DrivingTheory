Imports System.Data.OleDb
Public Module Usernames
    Public globalusernames As String
End Module
Public Class HomeScreen
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Public Structure DrivingStudents
        Dim fname As String
        Dim sname As String
        Dim username As String
        Dim password As String
    End Structure
    Dim Users(100) As DrivingStudents
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider =Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Logins.accdb")
        conn.Open()
    End Sub
    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        globalusernames = UsernameTxtBox.Text
    End Sub
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Register.Show()
    End Sub
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim tbl As New DataTable
        MyConnection()
        dapt = New OleDbDataAdapter("Select * From Logins Where Username='" & UsernameTxtBox.Text & "' and Password='" & PasswordTxtBox.Text & "'", conn)
        dapt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            PostLogin.Show()
            Me.Hide()
        Else
            MsgBox("Error, your username or password is incorrect")
        End If
    End Sub

    Private Sub ForgottenPasswordBtn_Click(sender As Object, e As EventArgs) Handles ForgottenPasswordBtn.Click
        ForgottenPassword.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        HighwayCode.Show()
    End Sub

End Class
