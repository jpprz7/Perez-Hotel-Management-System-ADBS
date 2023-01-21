'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS - Group 3

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class adminpage
    'user controls reference
    Dim emprec = New emprecords
    Dim logs = New trlogs
    Dim rooms = New htlroom
    Dim about = New abouthms
    Dim reserv = New reservations

    Private Sub adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the panel
        Panel1.Controls.Add(emprec)
        Panel1.Controls.Add(logs)
        Panel1.Controls.Add(rooms)
        Panel1.Controls.Add(about)
        Panel1.Controls.Add(reserv)

    End Sub

    'logout button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        hmslogin.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnEmpRecords_Click(sender As Object, e As EventArgs) Handles btnEmpRecords.Click
        emprec.BringToFront()
    End Sub

    Private Sub btnAdmLogs_Click(sender As Object, e As EventArgs) Handles btnAdmLogs.Click
        logs.bringtofront()
    End Sub

    Private Sub btnAdmRooms_Click(sender As Object, e As EventArgs) Handles btnAdmRooms.Click
        rooms.BringToFront()
    End Sub

    Private Sub btnAdmAbout_Click(sender As Object, e As EventArgs) Handles btnAdmAbout.Click
        about.BringToFront()
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        reserv.bringtofront()

    End Sub
End Class