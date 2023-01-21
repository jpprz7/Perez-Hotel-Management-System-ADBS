'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS - Group 3

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Public Class emprecords

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
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        'lagay ng message pag ok sql sabay clear ng textbox
        Call Clr()
    End Sub

    Private Sub btnUpdEmp_Click(sender As Object, e As EventArgs) Handles btnUpdEmp.Click
        Call Clr()
    End Sub

    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Call Clr()
    End Sub
End Class
