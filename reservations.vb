'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS


'TODO: aayusin ko pa website para makapagreserve ditoo


Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class reservations
    Dim conn As SqlConnection
    Dim cnstr As String = "data source = PEREZ; user = perez; password = perez; database = Perez - HMS database"
    Dim cmd As SqlCommand
    Dim itemcol(999) As String
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListView1.Items.Clear()
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT CONCAT(customers.firstname, ' ', customers.lastname) AS 'customer',
                                room_type.room_type_name,
                                bill.room_price,
                                booking.checkin_date,
                                booking.checkout_date
                                FROM customers
                                JOIN booking ON booking.customer_id = customers.customer_id
                                JOIN bill ON bill.booking_id = booking.booking_id
                                JOIN room ON room.room_id = booking.room_id
                                JOIN room_type ON room_type.room_type_id = room.room_type_id;"
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

End Class
