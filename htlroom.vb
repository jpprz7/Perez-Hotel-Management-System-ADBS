'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS

Public Class htlroom
    Private Sub htlroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLink_Click(sender As Object, e As EventArgs) Handles btnLink.Click
        Process.Start("https://perez-hms-rooms.netlify.app/")
    End Sub
End Class
