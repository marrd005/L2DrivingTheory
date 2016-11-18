Imports System.Data.OleDb
Public Module forename
    Public userforename As String
End Module
Public Structure Usersname
    Dim forename As String
End Structure
Public Class Register
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles RegisterUsernameLabel.Click

    End Sub

    Private Sub RegisterBtnForm_Click(sender As Object, e As EventArgs) Handles RegisterBtnForm.Click
        userforename = ForenameTxtBox.Text
        Dim capital As Boolean = False
        Dim lowercase As Boolean = False
        Dim atleast8 As Boolean = False
        Dim complete As Boolean = False
        Dim newpassword As String

        capital = False
        lowercase = False
        atleast8 = False
        newpassword = RegisterPasswordTxtBox.Text
        If newpassword.Length >= 8 Then
            atleast8 = True
            'length is correct check if it contains a capital letter
            For i = 1 To newpassword.Length
                If Asc(GetChar(newpassword, i)) >= 65 And Asc(GetChar(newpassword, i)) <= 90 Then
                    ' password contains a capital letter
                    capital = True
                ElseIf Asc(GetChar(newpassword, i)) >= 97 And Asc(GetChar(newpassword, i)) <= 122 Then
                    ' password contains a lowercase letter
                    lowercase = True
                End If
            Next
            If capital = True And lowercase = True Then
                complete = True
            End If
        End If




        If capital = False Or lowercase = False Or atleast8 = False Then
            MsgBox("Password doesn't contain both upper and lowercase letters or is not eight characters, please try again")
            RegisterPasswordTxtBox.Text = ""
        End If

        If complete = True Then
            Dim usernme, passwrd, forename, surname As String
            usernme = RegisterUsernameTxtBox.Text
            passwrd = RegisterPasswordTxtBox.Text
            forename = ForenameTxtBox.Text
            surname = SurnameTxtBox.Text
            Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Logins.accdb"
            Using myconnection As New OleDbConnection(constring)
                myconnection.Open()
                Dim sqlQry As String = "INSERT INTO [Logins] ([username], [password], [forename], [surname]) VALUES (@usernme, @passwrd, @forename, @surname)"
                Using cmd As New OleDbCommand(sqlQry, myconnection)
                    cmd.Parameters.AddWithValue("@usernme", usernme)
                    cmd.Parameters.AddWithValue("@passwrd", passwrd)
                    cmd.Parameters.AddWithValue("@forename", forename)
                    cmd.Parameters.AddWithValue("@surname", surname)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered")
                    Me.Hide()
                    HomeScreen.Show()
                End Using
            End Using
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles SurnameLabel.Click

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class