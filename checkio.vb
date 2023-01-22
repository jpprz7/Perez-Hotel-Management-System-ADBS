'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS

Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class checkio
    'database reference
    Dim cmd As SqlCommand
    Dim conn As SqlConnection
    Dim cnstr As String = "data source = PEREZ; user = perez; password = perez; database = Perez - HMS database"

    Dim roomtype, price As String
    Private Sub checkio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    'pang clear sa form
    Public Sub Clearform()
        txtbxFrstname.Clear()
        txtbxMidName.Clear()
        txtbxSurname.Clear()
        txtbxContact.Clear()
        txtbxNights.Clear()
        txtbxPricebox.Clear()
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
    End Sub

    'check-in
    Private Sub btnCheckin_Click(sender As Object, e As EventArgs) Handles btnCheckin.Click
        Try
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim SQL As String = "INSERT INTO customer_checkin (cfirstname, cmiddlename, clastname, ccontact_num, room_type, checkin, checkout, nights, total) 
                values('" & txtbxFrstname.Text & "','" & txtbxMidName.Text & "','" & txtbxSurname.Text & "','" & txtbxContact.Text & "','" & roomtype & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "','" & txtbxNights.Text & "', '" & price & "');
                "
            cmd = New SqlCommand(SQL, conn)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Check-in successful!", vbInformation, "Admin")
            Else
                MsgBox("Check-in failed!", vbCritical, "Sheeesh, mate!")
            End If
            Call Clearform()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Clearform()
    End Sub

    'cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call Clearform()
    End Sub

    'nightzz
    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)
        txtbxNights.Text = ts.Days
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If String.IsNullOrEmpty(txtbxNights.Text) Then
            MsgBox("Pick a check-in and check-out date first!", vbExclamation, "Sheeesh, mate!")
        ElseIf RadioButton1.Checked = True Then
        roomtype = "Single" 'roomtype
            price = txtbxNights.Text * 75 'price
            txtbxPricebox.Text = price 'display the price
        Else
            txtbxPricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If String.IsNullOrEmpty(txtbxNights.Text) Then
            MsgBox("Pick a check-in and check-out date first!", vbExclamation, "Sheeesh, mate!")
        ElseIf RadioButton2.Checked = True Then
            roomtype = "Twin" 'roomtype
            price = txtbxNights.Text * 95 'price
            txtbxPricebox.Text = price 'display the price
        Else
            txtbxPricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If String.IsNullOrEmpty(txtbxNights.Text) Then
            MsgBox("Pick a check-in and check-out date first!", vbExclamation, "Sheeesh, mate!")
        ElseIf RadioButton3.Checked = True Then
        roomtype = "Studio" 'roomtype
            price = txtbxNights.Text * 125 'price
            txtbxPricebox.Text = price 'display the price
        Else
            txtbxPricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If String.IsNullOrEmpty(txtbxNights.Text) Then
            MsgBox("Pick a check-in and check-out date first!", vbExclamation, "Sheeesh, mate!")
        ElseIf RadioButton4.Checked = True Then
        roomtype = "Deluxe" 'roomtype
            price = txtbxNights.Text * 237 'price
            txtbxPricebox.Text = price 'display the price
        Else
            txtbxPricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If String.IsNullOrEmpty(txtbxNights.Text) Then
            MsgBox("Pick a check-in and check-out date first!", vbExclamation, "Sheeesh, mate!")
        ElseIf RadioButton5.Checked = True Then
        roomtype = "Penthouse" 'roomtype
            price = txtbxNights.Text * 345 'price
            txtbxPricebox.Text = price 'display the price
        Else
            txtbxPricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If String.IsNullOrEmpty(txtbxNights.Text) Then
            MsgBox("Pick a check-in and check-out date first!", vbExclamation, "Sheeesh, mate!")
        ElseIf RadioButton6.Checked = True Then
        roomtype = "Presidential" 'roomtype
            price = txtbxNights.Text * 520 'price
            txtbxPricebox.Text = price 'display the price
        Else
            txtbxPricebox.Clear()
        End If
    End Sub

End Class
