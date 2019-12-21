Imports MySql.Data.MySqlClient
'Algorithm developed By Tafadzwa Munyuki
'User searches records by user id
Public Class FrmSearch

    Dim connection As New MySqlConnection

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'initiate db connection
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=students"
        'query db
        Dim command As New MySqlCommand("select * from `details` where `id`= @id", connection)

        command.Parameters.Add("@id", MySqlDbType.Int64).Value = txtUID.Text

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()
        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                'populate text fields
                txtUFname.Text = table(0)(1)
                txtMName.Text = table(0)(2)
                txtUSurname.Text = table(0)(3)
                txtUEmail.Text = table(0)(4)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try


    End Sub



    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class