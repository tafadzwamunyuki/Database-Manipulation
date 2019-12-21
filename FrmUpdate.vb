Imports MySql.Data.MySqlClient
'Algorithm developed By Tafadzwa Munyuki
Public Class FrmUpdate
    'update records by id
    'declare var
    Dim connection As New MySqlConnection
    Dim Str As String

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'initiate db connection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=students"

        Try

            Str = "Update `students`.`details` SET fname='" & txtUpfname.Text & "',mname='" & txtupmname.Text & "',lname='" & txtuplname.Text & "',email='" & txtupemail.Text & "' WHERE `id`= '" & txtupid.Text & "' "
            connection.Open()
            Dim mysc2 As New MySqlCommand(Str, connection)
            mysc2.ExecuteNonQuery()
            MsgBox("Successfully updated", MsgBoxStyle.Information)
            connection.Close()
            'exit update window upon click of ok button
            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            connection.Close()


        End Try

    End Sub
End Class



