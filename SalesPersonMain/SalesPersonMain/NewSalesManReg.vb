Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class NewSalesManReg
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Dim usernamebool As New Boolean
    Dim reader As MySqlDataReader


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
                    Dim command As New MySqlCommand("INSERT INTO salesperson (`SalesFirstName`,`SalesLastName`,`SalesUserName`,`SalesPassword`)
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

    Private Sub NewSalesManReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PassBox_TextChanged(sender As Object, e As EventArgs) Handles PassBox.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub UserBox_TextChanged(sender As Object, e As EventArgs) Handles UserBox.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LNameBox_TextChanged(sender As Object, e As EventArgs) Handles LNameBox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RePassBox_TextChanged(sender As Object, e As EventArgs) Handles RePassBox.TextChanged

    End Sub

    Private Sub FNameBox_TextChanged(sender As Object, e As EventArgs) Handles FNameBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Usernamecheck_Click(sender As Object, e As EventArgs) Handles usernamecheck.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"



        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim command As New MySqlCommand("SELECT `SalesUsername` FROM `salesperson` WHERE SalesUsername=@UNameBox", connection)

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