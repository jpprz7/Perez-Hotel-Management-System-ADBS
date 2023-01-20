'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS - Group 3

Public Class adminpage
    'user controls reference
    Dim emprec = New emprecords
    Dim logs = New trlogs
    Dim rooms = New htlroom
    Dim about = New abouthms

    Private Sub adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the panel
        Panel1.Controls.Add(emprec)
        Panel1.Controls.Add(logs)
        Panel1.Controls.Add(rooms)
        Panel1.Controls.Add(about)
    End Sub

    'logout button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        hmslogin.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnEmpRecords.Click
        emprec.BringToFront()
    End Sub

    Private Sub btnCheckin_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        logs.bringtofront()
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        rooms.BringToFront()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        about.BringToFront()
    End Sub
End Class