Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class customerreg
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Dim usernamebool As New Boolean

    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Function Encrypt(ByVal Stringinput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(Stringinput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

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

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"

        If PassBox.Text = "" Or RePassBox.Text = "" Then
            MessageBox.Show("One or more password boxes are empty")

        ElseIf PassBox.Text = RePassBox.Text Then

            If FNameBox.Text = "" Or LNameBox.Text = "" Or UserBox.Text = "" Then
                MessageBox.Show("One or more fields are empty")
            Else
                If usernamebool = False Then
                    MessageBox.Show("Username not checked or has been taken!")

                ElseIf usernamebool = True Then
                    Dim command As New MySqlCommand("INSERT INTO `customer` (`CustomerFirstName`,`CustomerLastName`,`CustomerUsername`,`CustomerPassWord`)
                    VALUES(@FNameBox,@LNameBox,@UNameBox,@PassBox)", connection)

                    command.Parameters.AddWithValue("@FNameBox", FNameBox.Text)
                    command.Parameters.AddWithValue("@LNameBox", LNameBox.Text)
                    command.Parameters.AddWithValue("@UNameBox", UserBox.Text)
                    command.Parameters.AddWithValue("@PassBox", Encrypt(PassBox.Text, "datakey"))

                    If ExecCommand(command) Then
                        MessageBox.Show("User's information Inserted")

                    Else
                        MessageBox.Show("User's information NOT Inserted")
                    End If


                End If
            End If
        Else
            MessageBox.Show("Passwords don't match, re-enter your password")
            PassBox.Text = ""
            RePassBox.Text = ""
        End If
    End Sub

    Private Sub usernamecheck_Click(sender As Object, e As EventArgs) Handles usernamecheck.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim command As New MySqlCommand("SELECT `CustomerUsername` FROM `customer` WHERE CustomerUsername=@UNameBox", connection)

        If UserBox.Text = "" Then
            MessageBox.Show("Enter a username")
        Else
            command.Parameters.AddWithValue("@UNameBox", UserBox.Text)
            reader = command.ExecuteReader()

            While reader.Read
                MessageBox.Show("Username already taken")
                connection.Close()
                Exit Sub
            End While
            MessageBox.Show("Username available")
            usernamebool = True
        End If


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If


    End Sub
End Class