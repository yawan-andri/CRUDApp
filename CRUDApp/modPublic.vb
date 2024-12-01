Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module modPublic
    Public Conn As New SqlConnection
    Public Da As SqlDataAdapter
    Public Cmd As SqlCommand
    Public Rd As SqlDataReader
    Public Ds As DataSet

    Public DBconn As String
    Public jString As String

    Public Sub Koneksi()
        DBconn = "Data Source=YAWAN;Initial Catalog=Andri;Integrated Security=True"
        Conn = New SqlConnection(DBconn)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
