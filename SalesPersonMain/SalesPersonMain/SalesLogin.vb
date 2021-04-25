Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class SalesLogin
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider


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
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"
        ' Dim connectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"

        'Dim command As New MySqlCommand("SELECT `SalesUserName`, `SalesPassword` FROM `salesperson` WHERE `SalesUserName`=@username AND `SalesPassword`=@password ", connection)

        Dim reader As MySqlDataReader


        'ALSO USE THE TRY/CATCHES'
        Try

            connection.Open()
            Dim command As New MySqlCommand("SELECT `SalesUserName`, `SalesPassword` FROM `salesperson` WHERE `SalesUserName`=@username AND `SalesPassword`=@password ", connection)
            command.Parameters.AddWithValue("@username", SUserName.Text)
            command.Parameters.AddWithValue("@password", Encrypt(SPassword.Text, "datakey"))
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Connected to Salesperson page")
                Dim menu = New NewSalesPersonHome()
                menu.sstringpass = SUserName.Text
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
        'CONNECTION END'
    End Sub

    Private Sub NewSalesMan_Click(sender As Object, e As EventArgs) Handles NewSalesMan.Click
        Dim salesmanreg = New NewSalesManReg()
        NewSalesManReg.Show()
    End Sub

    Private Sub SalesLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SUserName_TextChanged(sender As Object, e As EventArgs) Handles SUserName.TextChanged

    End Sub
End Class