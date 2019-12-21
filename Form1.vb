Imports MySql.Data.MySqlClient
'Algorithm developed By Tafadzwa Munyuki
Public Class FrmInsert
    'declare var
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Private Sub lblInsert_Click(sender As Object, e As EventArgs) Handles lblInsert.Click
        'initiate db connection
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=students"

        Try

            connection.Open()
            'show success message after successfully connecting to db
            MessageBox.Show("Connected to database!")
            'list db name and table to input data
            insertString = "insert into students.details(`id`, `fname`, `mname`, `lname`, `email`)values('" & txtID.Text & "','" & txtFname.Text & "','" & txtMname.Text & "','" & txtLname.Text & "','" & txtEmail.Text & "')"

            command = New MySqlCommand(insertString, connection)
            reader = command.ExecuteReader
            'Display success message
            MessageBox.Show("Successfully entered data")
            'terminate any pending transactions
            connection.Close()


        Catch ex As Exception

        Finally
            'free the pc RAM
            connection.Dispose()

        End Try


    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Upon pressing btn SEARCH show the form!
        FrmSearch.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Display delete window separately
        frmDelete.Show()

    End Sub

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click
        FrmUpdate.Show()
    End Sub
End Class





