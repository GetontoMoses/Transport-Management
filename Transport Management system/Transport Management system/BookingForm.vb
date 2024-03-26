Imports System.Data.OleDb
Public Class BookingForm
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

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click
        Call ConDB()
        command = "INSERT into booking([Bookingdate],[pickup point],[Destination]) VALUES('" & bookdate.Text & "','" & pickup.Text & "','" & destination.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Bookingdate", CType(bookdate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("pickup point", CType(pickup.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Destination", CType(destination.Text, String)))


        MsgBox(destination.Text & " Booked Successfully")
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
        Dim Form1Instance As New Form1
        Form1.Show()
        Me.Hide()
    End Sub
End Class