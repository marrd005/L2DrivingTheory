Imports System.Data.OleDb
Public Class ForgottenPassword
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        Dim passwrd As String = NewPassword.Text
        Dim usernme As String = EnterEmailBtn.Text

        Dim tbl As New DataTable
        dapt = New OleDbDataAdapter("Select * From Logins Where Username='" & usernme & "' ", conn)
        dapt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim sqlQry As String = "INSERT INTO [Logins] ([password]) VALUES (@passwrd)"
            Using cmd As New OleDbCommand(sqlQry, MyConnection)
                cmd.Parameters.AddWithValue("@passwrd", passwrd)
                cmd.ExecuteNonQuery()
                MsgBox("Password updated")
                HomeScreen.Show()
                Me.Hide()
            End Using
        Else
            MsgBox("Error, username not found")
        End If
    End Sub

    Private Sub ForgottenPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub EnterEmailBtn_TextChanged(sender As Object, e As EventArgs) Handles EnterEmailBtn.TextChanged

    End Sub
End Class