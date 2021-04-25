Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class PrevPurch
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")
    Dim command As New MySqlCommand
    Dim table As New DataTable()
    Dim reader As MySqlDataReader
    Public Property stringpass

    Private Sub DataGridView1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            Dim query As String = "SELECT `Make`,`Model`,`Year`,`Price` FROM `custsold`
            LEFT JOIN `product` ON `product`.`CarID` = `custsold`.`CarID`
            LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID` WHERE `CustID`=@CID"

            Dim query2 As String = "SELECT `CustomerID` FROM `customer` WHERE `CustomerUsername` = '" & stringpass & "'"
            command = New MySqlCommand(query2, connection)


            Dim username As Integer
            username = command.ExecuteScalar

            Dim command2

            command2 = New MySqlCommand(query, connection)
            command2.Parameters.AddWithValue("@CID", username)
            Debug.Print(query)


            table.Load(command2.ExecuteReader)

            DataGridView1.DataSource = table

            SumLabel.Text = (From row As DataGridViewRow In DataGridView1.Rows
                             Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(3).FormattedValue)).Sum().ToString()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Refreshb_Click(sender As Object, e As EventArgs) Handles Refreshb.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            Dim query As String = "SELECT `Make`,`Model`,`Year`,`Price` FROM `custsold`
            LEFT JOIN `product` ON `product`.`CarID` = `custsold`.`CarID`
            LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID` WHERE `CustID`=@CID"

            Dim query2 As String = "SELECT `CustomerID` FROM `customer` WHERE `CustomerUsername` = '" & stringpass & "'"
            command = New MySqlCommand(query2, connection)


            Dim username As Integer
            username = command.ExecuteScalar

            Dim command2

            command2 = New MySqlCommand(query, connection)
            command2.Parameters.AddWithValue("@CID", username)
            Debug.Print(query)


            table.Load(command2.ExecuteReader)

            DataGridView1.DataSource = table

            SumLabel.Text = (From row As DataGridViewRow In DataGridView1.Rows
                             Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(3).FormattedValue)).Sum().ToString()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class