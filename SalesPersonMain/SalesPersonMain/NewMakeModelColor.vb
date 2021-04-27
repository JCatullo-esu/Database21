Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class NewMakeModelColor
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")
    Dim ds As New DataSet

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If


        Dim fd As OpenFileDialog = New OpenFileDialog()
            Dim strFileName As String

            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "C:\"
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            fd.FilterIndex = 2
        fd.RestoreDirectory = True

        Dim make, model As String

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim NewXDoc As XDocument = XDocument.Load(strFileName)

            ds.ReadXml(strFileName)
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                make = ds.Tables(0).Rows(i).Item(0)
                model = ds.Tables(0).Rows(i).Item(1)
                Dim Sql As String = "INSERT INTO `makemodelinfo` (`Make`,`Model`) VALUES('" & make & "','" & model & "')"
                Dim adapter As MySqlDataAdapter
                adapter = New MySqlDataAdapter(Sql, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                MessageBox.Show("Data inserted")
            Next


        End If


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class