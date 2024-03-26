Imports System.Data.OleDb
Public Class Form1
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    ' Dim C As New conection
    Dim cmd As OleDbCommand
    Private Sub ConDB()
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\geton\OneDrive\Documents\Transport.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub


    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Call ConDB()
        command = "INSERT into Registration([Username],[email],[password]) VALUES('" & username.Text & "','" & email.Text & "','" & password.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Username", CType(username.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("email", CType(email.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("password", CType(password.Text, String)))


        MsgBox(email.Text & " Registered Successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            ' txtFullNames.Clear() 
            ' txtRegNo.Clear() 
            ' txtAddress.Clear() 
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BookingForm As New BookingForm
        BookingForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
