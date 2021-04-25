Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class CustomerLogin
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")



    Private Sub CustomerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Function Encrypt(ByVal Stringinput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(Stringinput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT `CustomerUsername`, `CustomerPassWord` FROM `customer` WHERE `CustomerUsername`=@username AND `CustomerPassWord`=@password ", connection)
            command.Parameters.AddWithValue("@username", CUserName.Text)
            command.Parameters.AddWithValue("@password", Encrypt(CPassword.Text, "datakey"))
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then

                MessageBox.Show("Connected to Customer page")
                Dim menu = New CustomerHome()
                menu.stringpass = CUserName.Text
                menu.Show()
                Me.Close()
            ElseIf count > 1 Then
                MessageBox.Show("Error logging in: duplicate information")
            Else
                MessageBox.Show("Username or password is not correct")
            End If

            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show("Invalid Username or Password")

        End Try
    End Sub


    Private Sub NewSalesMan_Click(sender As Object, e As EventArgs) Handles NewSalesMan.Click
        Dim chome = New customerreg()
        chome.Show()
        Me.Close()
    End Sub
End Class