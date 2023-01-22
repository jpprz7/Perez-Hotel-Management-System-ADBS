'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Runtime.Remoting.Contexts

Public Class emprecords
    Dim conn As SqlConnection
    Dim cnstr As String = "data source = PEREZ; user = perez; password = perez; database = Perez - HMS database"
    Dim itemcol(999) As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Public Sub EmpInfo()
        Try
            ListView1.Items.Clear()
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * from emp_record"
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

    Public Sub Clr()
        txtbxFrstname.Clear()
        txtbxMidname.Clear()
        txtbxSurname.Clear()
        txtbxContNum.Clear()
        txtbxEmpNo.Clear()
        txtbxEmail.Clear()
        combGender.SelectedIndex = -1
    End Sub
    Private Sub emprecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Call EmpInfo()
    End Sub

    'add emp
    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Try
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim SQL As String =
                "INSERT INTO emp_record (efirstname, emiddlename, elastname, gender, contact_num, email) 
                values(
                '" & txtbxFrstname.Text & "',
                '" & txtbxMidname.Text & "',
                '" & txtbxSurname.Text & "',
                '" & combGender.Text & "',
                '" & txtbxContNum.Text & "',
                '" & txtbxEmail.Text & "'
                );
                "
            cmd = New SqlCommand(SQL, conn)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee info added!", vbInformation, "Admin")
            Else
                MsgBox("Failed to add info!", vbCritical, "Sheeesh, mate!")
            End If
            Call EmpInfo()
            Call Clr()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'update emp
    Private Sub btnUpdEmp_Click(sender As Object, e As EventArgs) Handles btnUpdEmp.Click
        Try
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim SQL As String =
                "UPDATE emp_record SET efirstname = '" & txtbxFrstname.Text & "',
                emiddlename = '" & txtbxMidname.Text & "',
                elastname = '" & txtbxSurname.Text & "',
                gender = '" & combGender.Text & "',
                contact_num= '" & txtbxContNum.Text & "',
                email ='" & txtbxEmail.Text & "'
               WHERE emp_id = '" & txtbxEmpNo.Text & "'"
            cmd = New SqlCommand(SQL, conn)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee info updated!", vbInformation, "Admin")
            Else
                MsgBox("Failed to update info!", vbCritical, "Sheesh, mate!")
            End If
            Call EmpInfo()
            Call Clr()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'delete emp
    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Try
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim SQL As String = "DELETE FROM emp_record WHERE emp_id = '" & txtbxEmpNo.Text & "' "
            cmd = New SqlCommand(SQL, conn)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee info deleted!", vbInformation, "Admin")
            Else
                MsgBox("Failed to delete info!", vbCritical, "Sheesh, mate!")
            End If
            Call EmpInfo()
            Call Clr()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtbxEmpNo.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtbxFrstname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtbxMidname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtbxSurname.Text = ListView1.SelectedItems(0).SubItems(3).Text
            combGender.SelectedItem = ListView1.SelectedItems(0).SubItems(4).Text
            txtbxContNum.Text = ListView1.SelectedItems(0).SubItems(5).Text
            txtbxEmail.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub
End Class
