Public Class FrmMain
    'Algorithm developed By Tafadzwa Munyuki
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Set username to admin,password to password
        If txtUser.Text = "admin" And txtPass.Text = "password" Then
            MsgBox("Successfully logged in", MsgBoxStyle.OkOnly, "Welcome to Fort User Data")
            'display Insert form window after veryifying user credentials
            FrmInsert.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username/Password", MsgBoxStyle.OkOnly, "Invalid")

        End If

    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter



    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'terminate window
        Application.Exit()
    End Sub
End Class