'created by: Perez, John Patrick A.
'BSIT-3C
'ADBS - Group 3

Public Class hmslogin


    'show/hide password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            pword.UseSystemPasswordChar = False
        Else
            pword.UseSystemPasswordChar = True
        End If
    End Sub

    'Log in button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If uname.Text = "admin" And pword.Text = "admin" Then
            adminpage.Show()
            Me.Hide()

            'para mareset mga textbox
            user.Visible = True
            pass.Visible = True
            uname.Clear()
            pword.Clear()

        End If



    End Sub

    'info button
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        info.Show()
        Me.Hide()

    End Sub

    'username textbox
    Private Sub uname_TextChanged(sender As Object, e As EventArgs) Handles uname.TextChanged
        user.Visible = False

    End Sub

    'password textbox
    Private Sub pword_TextChanged(sender As Object, e As EventArgs) Handles pword.TextChanged
        pass.Visible = False

    End Sub

    'para mahide yung label pagclick
    Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click
        uname.Visible = True
        user.Visible = False
    End Sub

    Private Sub pass_Click(sender As Object, e As EventArgs) Handles pass.Click
        pass.Visible = False
        pword.Visible = True
    End Sub
End Class
