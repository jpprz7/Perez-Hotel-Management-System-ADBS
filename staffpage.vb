'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS - Group 3

Public Class staffpage
    'user controls reference
    Dim checkin = New checkio
    Dim logs = New trlogs
    Dim rooms = New htlroom
    Dim about = New abouthms
    Dim reserv = New reservations

    Private Sub adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the panel
        Panel1.Controls.Add(checkin)
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

    Private Sub btnCheckIO_Click(sender As Object, e As EventArgs) Handles btnCheckIO.Click
        checkin.BringToFront()
    End Sub

    Private Sub btnStfRooms_Click(sender As Object, e As EventArgs) Handles btnStfRooms.Click
        rooms.BringToFront()
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        reserv.bringtofront()
    End Sub

    Private Sub btnStfLogs_Click(sender As Object, e As EventArgs) Handles btnStfLogs.Click
        logs.bringtofront()
    End Sub

    Private Sub btnStfAbout_Click(sender As Object, e As EventArgs) Handles btnStfAbout.Click
        about.BringToFront()
    End Sub

End Class