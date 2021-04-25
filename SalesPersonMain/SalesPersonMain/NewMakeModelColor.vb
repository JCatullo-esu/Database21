Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class NewMakeModelColor
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")

    Function ExecCommand(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Function

    Private Sub AddNewMakeModel_Click(sender As Object, e As EventArgs) Handles AddNewMakeModel.Click

        If MakeText.Text = "" Or ModelText.Text = "" Then
            MessageBox.Show("Error, you need to fill out both make and model text boxes to insert into database")
        Else
            Dim command As New MySqlCommand("INSERT INTO makemodelinfo (`Make`,`Model`) VALUES 
         (@MakeText,@ModelText)", connection)

            command.Parameters.AddWithValue("@MakeText", MakeText.Text)
            command.Parameters.AddWithValue("@ModelText", ModelText.Text)

            If ExecCommand(command) Then
                MessageBox.Show("Data Inserted")

            Else
                MessageBox.Show("Data NOT Inserted")
            End If

            MakeText.Text = ""
            ModelText.Text = ""
        End If
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        If ColorText.Text = "" Then
            MessageBox.Show("Error, you need to fill in the color box")
        Else
            Dim command As New MySqlCommand("INSERT INTO colorinfo (`Color`) VALUES 
         (@ColorText)", connection)

            command.Parameters.AddWithValue("@ColorText", ColorText.Text)


            If ExecCommand(command) Then
                MessageBox.Show("Data Inserted")

            Else
                MessageBox.Show("Data NOT Inserted")
            End If

            ColorText.Text = ""
        End If
    End Sub
End Class