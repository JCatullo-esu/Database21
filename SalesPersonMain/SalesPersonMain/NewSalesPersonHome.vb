Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Public Class NewSalesPersonHome
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB") 'do this for eXISTING
    Dim selectcommand As MySqlCommand
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand
    Dim command3 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim reader2 As MySqlDataReader
    Dim reader3 As MySqlDataReader
    Public Property sstringpass

    Dim CarIDint, CustID, Priceint As Integer
    Dim insertString As String
    Dim connectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"
    Dim table As New DataTable()



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
            MessageBox.Show(ex.Message)
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Function

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub NewSalesPersonHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Clear then repopulate
        MakeDropDown.Items.Clear()
        ColorDrop.Items.Clear()
        LotDropDown.Items.Clear()

        Dim Query As String
        Query = "SELECT `Make` FROM `makemodelinfo`"

        Dim Query2 As String
        Query2 = "SELECT `Color` FROM `colorinfo`"

        Dim Query3 As String
        Query3 = "SELECT `Lot Name` FROM `lot info`"


        command = New MySqlCommand(Query, connection)
        command2 = New MySqlCommand(Query2, connection)
        command3 = New MySqlCommand(Query3, connection)

        reader = command.ExecuteReader

        While reader.Read
            Dim MaID = reader.GetString("Make")

            If Not MakeDropDown.Items.Contains(MaID) Then
                MakeDropDown.Items.Add(MaID)
            End If
        End While

        reader.Close()
        reader2 = command2.ExecuteReader

        While reader2.Read
            Dim Cid = reader2.GetString("Color")
            ColorDrop.Items.Add(Cid)
        End While

        reader2.Close()
        reader3 = command3.ExecuteReader

        While reader3.Read
            Dim Lid = reader3.GetString("Lot Name")
            LotDropDown.Items.Add(Lid)
        End While

        reader3.Close()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

    Private Sub SubmitCar_Click(sender As Object, e As EventArgs) Handles SubmitCar.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim command As New MySqlCommand("INSERT INTO product (`MMID`,`Year`,`Body Style`, 
        `Milage`,`ColorID`,`Price`,`VinNum`, `Car Picture`) VALUES 
         (@MMID,@YearTextBox, @BodyStyleDropDown, @MileageTextBox, @NewColorDrop, @PriceTextBox, 
         @NewVinBox, @CarPicTextBox);SELECT LAST_INSERT_ID()", connection)

        Dim Query As String
        Query = "SELECT `MMinfoID` FROM `makemodelinfo` WHERE Make= '" & MakeDropDown.Text & "' AND Model= '" & ModelDropDown.Text & "'"
        selectcommand = New MySqlCommand(Query, connection)

        Dim Query2 As String
        Query2 = "SELECT `ColorinfoID` FROM `colorinfo` WHERE Color= '" & ColorDrop.Text & "'"
        Dim selectcommand2 As MySqlCommand
        selectcommand2 = New MySqlCommand(Query2, connection)

        Dim Query3 As String
        Query3 = "SELECT `Lot ID` FROM `lot info` WHERE `Lot Name`= '" & LotDropDown.Text & "'"
        Dim selectcommand3 As MySqlCommand
        selectcommand3 = New MySqlCommand(Query3, connection)

        If MakeModelNA.Checked = False Then
            Dim MMIDstring As Integer

            selectcommand.Parameters.AddWithValue("@MakeText", MakeDropDown.Text)
            selectcommand.Parameters.AddWithValue("@ModelText", ModelDropDown.Text)

            MMIDstring = selectcommand.ExecuteScalar()

            command.Parameters.AddWithValue("@MMID", MMIDstring)
        Else
            command.Parameters.AddWithValue("@MMID", DBNull.Value)
        End If

        If YearNA.Checked = False Then
            command.Parameters.AddWithValue("@YearTextBox", YearText.Text)
        Else
            command.Parameters.AddWithValue("@YearTextBox", DBNull.Value)
        End If

        If BodyStyleNA.Checked = False Then
            command.Parameters.AddWithValue("@BodyStyleDropDown", BodyStyleDrop.Text)
        Else
            command.Parameters.AddWithValue("@BodyStyleDropDown", DBNull.Value)
        End If

        If MilageNA.Checked = False Then
            command.Parameters.AddWithValue("@MileageTextBox", MilageText.Text)
        Else
            command.Parameters.AddWithValue("@MileageTextBox", DBNull.Value)
        End If

        If ColorNA.Checked = False Then
            Dim SelectColorID As Integer

            selectcommand2.Parameters.AddWithValue("@Color", ColorDrop.Text)
            SelectColorID = selectcommand2.ExecuteScalar()

            command.Parameters.AddWithValue("@NewColorDrop", SelectColorID)
        Else
            command.Parameters.AddWithValue("@NewColorDrop", DBNull.Value)
        End If

        If PriceNA.Checked = False Then
            command.Parameters.AddWithValue("@PriceTextBox", PriceText.Text)
        Else
            command.Parameters.AddWithValue("@PriceTextBox", DBNull.Value)
        End If

        If VinNA.Checked = False Then
            command.Parameters.AddWithValue("@NewVinBox", VinText.Text)
        Else
            command.Parameters.AddWithValue("@NewVinBox", DBNull.Value)
        End If

        If CarPicNA.Checked = False Then
            command.Parameters.AddWithValue("@CarPicTextBox", CarPicText.Text)
        Else
            command.Parameters.AddWithValue("@CarPicTextBox", DBNull.Value)
        End If

        Dim newID As Integer = command.ExecuteScalar()

        Dim command2 As New MySqlCommand("INSERT INTO `lotcarinfo` (`CarLotID`) VALUES 
         (@LotDropDown)", connection)

        If LotNA.Checked = False Then
            Dim LotIDstring As Integer

            selectcommand3.Parameters.AddWithValue("@LotName", LotDropDown.Text)

            LotIDstring = selectcommand3.ExecuteScalar()

            command2.Parameters.AddWithValue("@LotDropDown", LotIDstring)
        Else
            command2.Parameters.AddWithValue("@LotDropDown", DBNull.Value)
        End If

        If ExecCommand(command2) Then
            MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EditCar = New NewEditCar()
        NewEditCar.Show()
    End Sub

    Private Sub LotTools_Click(sender As Object, e As EventArgs) Handles LotTools.Click
        Dim lot = New LotCityLook()
        lot.Show()
    End Sub


    Private Sub MakeModelNA_CheckedChanged(sender As Object, e As EventArgs) Handles MakeModelNA.CheckedChanged
        If MakeModelNA.Checked = True Then
            MakeDropDown.Enabled = False
            ModelDropDown.Enabled = False
        Else
            MakeDropDown.Enabled = True
            ModelDropDown.Enabled = True
        End If

    End Sub



    Private Sub YearNA_CheckedChanged(sender As Object, e As EventArgs) Handles YearNA.CheckedChanged
        If YearNA.Checked = True Then
            YearText.Enabled = False
            YearText.Clear()
        Else
            YearText.Enabled = True
        End If
    End Sub

    Private Sub BodyStyleNA_CheckedChanged(sender As Object, e As EventArgs) Handles BodyStyleNA.CheckedChanged
        If BodyStyleNA.Checked = True Then
            BodyStyleDrop.Enabled = False

        Else
            BodyStyleDrop.Enabled = True
        End If


    End Sub

    Private Sub MilageNA_CheckedChanged(sender As Object, e As EventArgs) Handles MilageNA.CheckedChanged
        If MilageNA.Checked = True Then
            MilageText.Enabled = False
            MilageText.Clear()
        Else
            MilageText.Enabled = True
        End If
    End Sub

    Private Sub ColorNA_CheckedChanged(sender As Object, e As EventArgs) Handles ColorNA.CheckedChanged
        If ColorNA.Checked = True Then
            ColorDrop.Enabled = False
        Else
            ColorDrop.Enabled = True
        End If
    End Sub

    Private Sub PriceNA_CheckedChanged(sender As Object, e As EventArgs) Handles PriceNA.CheckedChanged
        If PriceNA.Checked = True Then
            PriceText.Enabled = False
            PriceText.Clear()
        Else
            PriceText.Enabled = True
        End If
    End Sub

    Private Sub VinNA_CheckedChanged(sender As Object, e As EventArgs) Handles VinNA.CheckedChanged
        If VinNA.Checked = True Then
            VinText.Enabled = False
            VinText.Clear()
        Else
            VinText.Enabled = True
        End If
    End Sub

    Private Sub CarPicNA_CheckedChanged(sender As Object, e As EventArgs) Handles CarPicNA.CheckedChanged
        If CarPicNA.Checked = True Then
            CarPicText.Enabled = False
            CarPicText.Clear()
        Else
            CarPicText.Enabled = True
        End If
    End Sub

    Private Sub LotNA_CheckedChanged(sender As Object, e As EventArgs) Handles LotNA.CheckedChanged
        If LotNA.Checked = True Then
            LotDropDown.Enabled = False

        Else
            LotDropDown.Enabled = True
        End If
    End Sub

    Private Sub SalesPersonGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'pot sales
        Dim adapter As New MySqlDataAdapter("SELECT `CustomerID`,`CustomerFirstName`,`CustomerLastName`,`CarID`,`Make`,`Model`,`Year`,`Color`,`Price`
        FROM `customer` LEFT JOIN `salespotpurchase` ON `salespotpurchase`.`SalesCustID` = `customer`.`CustomerID`
         LEFT JOIN `product` ON `product`.`CarID` = `salespotpurchase`.`SalesCarID`    
        LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` 
        LEFT JOIN `colorinfo` ON `colorinfo`.`ColorinfoID` = `product`.`ColorID` WHERE `customer`.`CustomerID` = `salespotpurchase`.`SalesCustID`", connection)




        Dim table As New DataTable()
        adapter.Fill(table)

        CustomerCurrentGrid.DataSource = table
        CustomerCurrentGrid.Columns(0).Visible = False


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    'PREVIOUS SALES FOR CUSTOMER' 
    Private Sub PrevGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim adapter As New MySqlDataAdapter("SELECT `SalesFirstName`,`SalesLastName`,`CustomerFirstName`,`CustomerLastName`,`Make`,`Model`,
        `Year`,`Milage`,`Color`,`Price` FROM `salesperson` LEFT JOIN `custsold` ON `custsold`.`SalesPersonID` = `salesperson`.`SalesID`
         LEFT JOIN `customer` ON `customer`.`CustomerID` = `custsold`.`CustID`
         LEFT JOIN `product` ON `product`.`CarID` = `custsold`.`CarID` 
         LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID`
         LEFT JOIN `colorinfo` ON `colorinfo`.`ColorinfoID` = `product`.`ColorID`", connection)

        Dim table As New DataTable()
        adapter.Fill(table)

        PrevGrid.DataSource = table


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub



    Private Sub ColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColorDrop.SelectedIndexChanged

    End Sub

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If


        Dim command As New MySqlCommand("INSERT INTO `custsold` (`CustID`,`CarID`,`SoldPrice`,`SalesPersonID`) VALUES 
         (@CustID,@CarID,@SoldPrice,@SalesPersonID)", connection)

        Dim useridcommand As New MySqlCommand("SELECT `SalesID` FROM `salesperson` WHERE `SalesUserName`=@UserName", connection)
        useridcommand.Parameters.AddWithValue("@Username", sstringpass)

        Dim salesIDint As Integer
        salesIDint = useridcommand.ExecuteScalar


        command.Parameters.AddWithValue("@CustID", CustID)
        command.Parameters.AddWithValue("@CarID", CarIDint)
        command.Parameters.AddWithValue("@SoldPrice", Priceint)
        command.Parameters.AddWithValue("@SalesPersonID", salesIDint)

        Dim command3 As New MySqlCommand("", connection)

        If ExecCommand(command) Then
            MessageBox.Show("Data Inserted")
            Try
                Dim query As String = "Delete FROM `salespotpurchase` WHERE `SalesCarID`=@SalesCarID AND `SalesCustID`=@SalesCustID"
                Dim deletepot As New MySqlCommand(query, connection)
                deletepot.Parameters.AddWithValue("@SalesCarID", CarIDint)
                deletepot.Parameters.AddWithValue("@SalesCustID", CustID)

                reader = deletepot.ExecuteReader
                reader.Close()

                Dim query2 As String = "Delete FROM `lotcarinfo` WHERE `CarInLotID` = @CarInLotID"
                Dim deletecar As New MySqlCommand(query2, connection)
                deletecar.Parameters.AddWithValue("@CarInLotID", CarIDint)
                reader = deletecar.ExecuteReader
                reader.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("Data NOT Inserted")
        End If


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Clear then repopulate
        MakeDropDown.Items.Clear()
        ColorDrop.Items.Clear()
        LotDropDown.Items.Clear()

        Dim Query As String
        Query = "SELECT `Make` FROM `makemodelinfo`"

        Dim Query2 As String
        Query2 = "SELECT `Color` FROM `colorinfo`"

        Dim Query3 As String
        Query3 = "SELECT `Lot Name` FROM `lot info`"


        command = New MySqlCommand(Query, connection)
        command2 = New MySqlCommand(Query2, connection)
        command3 = New MySqlCommand(Query3, connection)

        reader = command.ExecuteReader

        While reader.Read
            Dim MaID = reader.GetString("Make")

            If Not MakeDropDown.Items.Contains(MaID) Then
                MakeDropDown.Items.Add(MaID)
            End If
        End While

        reader.Close()
        reader2 = command2.ExecuteReader

        While reader2.Read
            Dim Cid = reader2.GetString("Color")
            ColorDrop.Items.Add(Cid)
        End While

        reader2.Close()
        reader3 = command3.ExecuteReader

        While reader3.Read
            Dim Lid = reader3.GetInt32("Lot Name")
            LotDropDown.Items.Add(Lid)
        End While

        reader3.Close()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub RefreshPrev_Click(sender As Object, e As EventArgs) Handles RefreshPrev.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'pot sales
        Dim adapter As New MySqlDataAdapter("SELECT `CustomerID`,`CustomerFirstName`,`CustomerLastName`,`CarID`,`Make`,`Model`,`Year`,`Color`,`Price`
        FROM `customer` LEFT JOIN `salespotpurchase` ON `salespotpurchase`.`SalesCustID` = `customer`.`CustomerID`
         LEFT JOIN `product` ON `product`.`CarID` = `salespotpurchase`.`SalesCarID`    
        LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` 
        LEFT JOIN `colorinfo` ON `colorinfo`.`ColorinfoID` = `product`.`ColorID` WHERE `customer`.`CustomerID` = `salespotpurchase`.`SalesCustID`", connection)


        Dim table As New DataTable()
        adapter.Fill(table)

        CustomerCurrentGrid.DataSource = table
        CustomerCurrentGrid.Columns(0).Visible = False


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub RefreshSalesPrevPurc_Click(sender As Object, e As EventArgs) Handles RefreshSalesPrevPurc.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim adapter As New MySqlDataAdapter("SELECT `SalesFirstName`,`SalesLastName`,`CustomerFirstName`,`CustomerLastName`,`Make`,`Model`,
        `Year`,`Milage`,`Color`,`Price` FROM `salesperson` LEFT JOIN `custsold` ON `custsold`.`SalesPersonID` = `salesperson`.`SalesID`
         LEFT JOIN `customer` ON `customer`.`CustomerID` = `custsold`.`CustID`
         LEFT JOIN `product` ON `product`.`CarID` = `custsold`.`CarID` 
         LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID`
         LEFT JOIN `colorinfo` ON `colorinfo`.`ColorinfoID` = `product`.`ColorID`", connection)

        Dim table As New DataTable()
        adapter.Fill(table)

        PrevGrid.DataSource = table


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub MakeDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MakeDropDown.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        ModelDropDown.Items.Clear()

        Dim Query As String
        Query = "SELECT * FROM `makemodelinfo` WHERE `Make`= '" & MakeDropDown.Text & "'"
        command = New MySqlCommand(Query, connection)

        reader = command.ExecuteReader

        While reader.Read
            Dim ModID = reader.GetString("Model")
            ModelDropDown.Items.Add(ModID)

        End While

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub CustomerCurrentGrid_MouseClick(sender As Object, e As MouseEventArgs) Handles CustomerCurrentGrid.MouseClick

        Try
            Dim i As Integer
            i = CustomerCurrentGrid.CurrentRow.Index
            CustID = CustomerCurrentGrid.Item(0, i).Value
            CarIDint = CustomerCurrentGrid.Item(3, i).Value
            Priceint = CustomerCurrentGrid.Item(8, i).Value

        Catch ex As Exception
            MessageBox.Show("Error, nothing in fields")
        End Try

    End Sub

End Class