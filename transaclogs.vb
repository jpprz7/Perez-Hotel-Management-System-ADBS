'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS

Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class trlogs
    Dim conn As SqlConnection
    Dim cnstr As String = "data source = PEREZ; user = zerep; password = zerep; database = hms"
    Dim itemcol(999) As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Public Sub CusInfo()
        Try
            ListView1.Items.Clear()
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * from customer_checkin"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitm As New ListViewItem(itemcol)
                ListView1.Items.Add(lvitm)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub trlogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Call CusInfo()
    End Sub
End Class
