Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Public Class PotPurchase
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")
    Dim command As New MySqlCommand
    Dim table As New DataTable()
    Dim reader As MySqlDataReader
    Dim Caridint, Yearint, Milageint, Priceint, VinNumint As Integer
    Dim MakeString, ModelString, BodyStyleString, ColorString, CarPictureString, LotNameString As String

    Public Property stringpass

    Private Sub PotPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Try
            Dim query As String = "SELECT `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture`,
            `Lot Name` FROM `salespotpurchase` LEFT JOIN `product` ON `product`.`CarID` = `salespotpurchase`.`SalesCarID`
            LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON 
            `colorinfo`.`ColorinfoID` = `product`.`ColorID` LEFT JOIN `lotcarinfo` ON `lotcarinfo`.`CarInLotID` = `product`.`CarID`
            LEFT JOIN `lot info` ON `lot info`.`Lot ID` = `lotcarinfo`.`CarLotID` WHERE `SalesCustID`=@CID"

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
            DataGridView1.Columns(0).Visible = False

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub



    Private Sub RemovePurchaseButton_Click(sender As Object, e As EventArgs) Handles RemovePurchaseButton.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try

            Dim query2 As String = "SELECT `CustomerID` FROM `customer` WHERE `CustomerUsername` = '" & stringpass & "'"
            Dim command2 = New MySqlCommand(query2, connection)


            Dim username As Integer
            username = command2.ExecuteScalar

            Debug.Print(Caridint)
            Debug.Print(username)

            Dim query As String = "DELETE FROM `salespotpurchase` WHERE `SalesCarID`= @CarID AND `SalesCustID`= @CustID"
            Dim delete As New MySqlCommand(query, connection)
            delete.Parameters.AddWithValue("@CarID", Caridint)
            delete.Parameters.AddWithValue("@CustID", username)


            reader = delete.ExecuteReader
            MessageBox.Show("Data Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            CarIDint = DataGridView1.Item(0, i).Value
            MakeString = DataGridView1.Item(1, i).Value.ToString()
            ModelString = DataGridView1.Item(2, i).Value.ToString()
            Yearint = DataGridView1.Item(3, i).Value.ToString()
            BodyStyleString = DataGridView1.Item(4, i).Value.ToString()
            Milageint = DataGridView1.Item(5, i).Value.ToString()
            ColorString = DataGridView1.Item(6, i).Value.ToString()
            VinNumint = DataGridView1.Item(8, i).Value.ToString()
            CarPictureString = DataGridView1.Item(9, i).Value.ToString()
            LotNameString = DataGridView1.Item(10, i).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("Error, nothing in fields")
        End Try
    End Sub
End Class