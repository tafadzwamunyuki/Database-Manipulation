Imports MySql.Data.MySqlClient
'Algorithm developed By Tafadzwa Munyuki
Public Class frmDelete
    'deletes user records by id
    'declare var
    Dim connection As New MySqlConnection
    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'initiate db connection
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=students"
        'delete data
        Dim command As New MySqlCommand("delete from `students`.`details` where `id`=@id", connection)

        command.Parameters.Add("@id", MySqlDbType.Int64).Value = txtDID.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            'display success msg
            MessageBox.Show("Data deleted")

        Else
            'display failure msg
            MessageBox.Show("Data not deleted or nothing to delete")

        End If
        'terminate db connection
        connection.Close()
        'close delete window
        Me.Close()

    End Sub
End Class

