Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Public Class CustomerHome
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB") 'do this for eXISTING
    Dim table As New DataTable()
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand
    Dim command3 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim reader2 As MySqlDataReader
    Dim reader3 As MySqlDataReader
    Dim CarIDint As Integer
    Public Property stringpass


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

    Private Sub CustomerHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Try

            MakeDropDown.Items.Clear()
            ModelDrop.Items.Clear()
            ColorDrop.Items.Clear()
            LotDropDown.Items.Clear()


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

            Dim adapter As New MySqlDataAdapter("SELECT `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture`,
            `Lot Name` FROM `product` LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON
             `colorinfo`.`ColorinfoID` = `product`.`ColorID` LEFT JOIN  `lotcarinfo` on `lotcarinfo`.`CarInLotID` = `product`.`CarID` LEFT JOIN 
             `lot info` ON `lot info`.`Lot ID` = `lotcarinfo`.`CarLotID` WHERE `lotcarinfo`.`CarLotID` = `lot info`.`Lot ID`", connection)

            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
            DataGridView1.Columns(0).Visible = False
        Catch ex As System.Exception

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
            Me.MakeDropDown.Text = DataGridView1.Item(1, i).Value.ToString()
            Me.ModelDrop.Text = DataGridView1.Item(2, i).Value.ToString()
            Me.YearTextBox.Text = DataGridView1.Item(3, i).Value.ToString()
            Me.BodyStyleDropDown.Text = DataGridView1.Item(4, i).Value.ToString()
            Me.MileageTextBox.Text = DataGridView1.Item(5, i).Value.ToString()
            Me.ColorDrop.Text = DataGridView1.Item(6, i).Value.ToString()
            Me.NewVinBox.Text = DataGridView1.Item(8, i).Value.ToString()
            Me.CarPicTextBox.Text = DataGridView1.Item(9, i).Value.ToString()
            Me.LotDropDown.Text = DataGridView1.Item(10, i).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("Error, nothing in fields")
        End Try

    End Sub

    Private Sub LookUpPotSales_Click(sender As Object, e As EventArgs) Handles LookUpPotSales.Click
        Dim potpur = New PotPurchase()
        potpur.stringpass = Me.stringpass
        potpur.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prevpur = New PrevPurch()
        prevpur.stringpass = Me.stringpass
        prevpur.Show()
    End Sub


    Private Sub MilageNA_CheckedChanged(sender As Object, e As EventArgs)
        If MilageNA.Checked = True Then
            MileageTextBox.Enabled = False
            MileageTextBox.Clear()
        Else
            MileageTextBox.Enabled = True
        End If
    End Sub

    Private Sub MMNA_CheckedChanged(sender As Object, e As EventArgs) Handles MMNA.CheckedChanged
        If MMNA.Checked = True Then
            MakeDropDown.Enabled = False
            MakeDropDown.Text = ""
        Else
            MakeDropDown.Enabled = True
        End If
    End Sub

    Private Sub YearNA_CheckedChanged(sender As Object, e As EventArgs) Handles YearNA.CheckedChanged
        If YearNA.Checked = True Then
            YearTextBox.Enabled = False
            YearTextBox.Clear()
        Else
            YearTextBox.Enabled = True
        End If
    End Sub

    Private Sub BodyStyleNA_CheckedChanged(sender As Object, e As EventArgs) Handles BodyStyleNA.CheckedChanged
        If BodyStyleNA.Checked = True Then
            BodyStyleDropDown.Enabled = False
            BodyStyleDropDown.Text = ""
        Else
            BodyStyleDropDown.Enabled = True
        End If
    End Sub

    Private Sub ColorNA_CheckedChanged(sender As Object, e As EventArgs) Handles ColorNA.CheckedChanged
        If ColorNA.Checked = True Then
            ColorDrop.Enabled = False
            ColorDrop.Text = ""
        Else
            ColorDrop.Enabled = True
        End If
    End Sub

    Private Sub ViNNA_CheckedChanged(sender As Object, e As EventArgs) Handles ViNNA.CheckedChanged
        If ViNNA.Checked = True Then
            NewVinBox.Enabled = False
            NewVinBox.Clear()
        Else
            NewVinBox.Enabled = True
        End If
    End Sub

    Private Sub CarPicNA_CheckedChanged(sender As Object, e As EventArgs) Handles CarPicNA.CheckedChanged
        If CarPicNA.Checked = True Then
            CarPicTextBox.Enabled = False
            CarPicTextBox.Clear()
        Else
            CarPicTextBox.Enabled = True
        End If
    End Sub

    Private Sub LotNA_CheckedChanged(sender As Object, e As EventArgs) Handles LotNA.CheckedChanged
        If LotNA.Checked = True Then
            LotDropDown.Enabled = False
            LotDropDown.Text = ""
        Else
            LotDropDown.Enabled = True
        End If
    End Sub

    Private Sub PriceMinNA_CheckedChanged(sender As Object, e As EventArgs) Handles PriceMinNA.CheckedChanged
        If PriceMinNA.Checked = True Then
            PriceMinTextBox.Enabled = False
        Else
            PriceMinTextBox.Enabled = True
        End If


    End Sub

    Private Sub PriceMaxNA_CheckedChanged(sender As Object, e As EventArgs) Handles PriceMaxNA.CheckedChanged
        If PriceMaxNA.Checked = True Then
            PriceMaxTextBox.Enabled = False
        Else
            PriceMaxTextBox.Enabled = True
        End If
    End Sub

    Private Sub RefreshTable_Click(sender As Object, e As EventArgs) Handles RefreshTable.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Try

            MakeDropDown.Items.Clear()
            ModelDrop.Items.Clear()
            ColorDrop.Items.Clear()
            LotDropDown.Items.Clear()


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

            Dim adapter As New MySqlDataAdapter("SELECT `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture`,
         `Lot Name` FROM `product` LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON
         `colorinfo`.`ColorinfoID` = `product`.`ColorID` LEFT JOIN  `lotcarinfo` on `lotcarinfo`.`CarInLotID` = `product`.`CarID` LEFT JOIN 
         `lot info` ON `lot info`.`Lot ID` = `lotcarinfo`.`CarLotID` WHERE `lotcarinfo`.`CarLotID` = `lot info`.`Lot ID`", connection)


            Dim table As New DataTable()
            adapter.Fill(table)


            DataGridView1.DataSource = table
            DataGridView1.Columns(0).Visible = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub SearchCarButton_Click(sender As Object, e As EventArgs) Handles SearchCarButton.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Refresh table
        table.Clear()
        DataGridView1.DataSource = Nothing

        Dim AndNeeded As Boolean = False

        Dim Search As String = "SELECT `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture`,`Lot Name` FROM `product` LEFT JOIN
        `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON `colorinfo`.`ColorinfoID` = `product`.`ColorID` 
        LEFT JOIN  `lotcarinfo` on `lotcarinfo`.`CarInLotID` = `product`.`CarID` LEFT JOIN 
         `lot info` ON `lot info`.`Lot ID` = `lotcarinfo`.`CarLotID` WHERE `lotcarinfo`.`CarLotID` = `lot info`.`Lot ID` AND "

        Using connection
            Using command As New MySqlCommand()
                'If make & model text boxes are NOT empty
                Try
                    If MakeDropDown.Text <> "" And ModelDrop.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Dim selectcommand As MySqlCommand
                        Dim Query2 As String
                        Dim MMID As Integer

                        Query2 = "Select `MMinfoID` FROM `makemodelinfo` WHERE Make= '" & MakeDropDown.Text & "' AND Model= '" & ModelDrop.Text & "'"
                        selectcommand = New MySqlCommand(Query2, connection)

                        selectcommand.Parameters.AddWithValue("@MakeText", MakeDropDown.Text)
                        selectcommand.Parameters.AddWithValue("@ModelText", ModelDrop.Text)
                        MMID = selectcommand.ExecuteScalar()
                        Search &= "`MMID` = '" & MMID & "'"

                        command.Parameters.Add("@MMID", MMID)
                        AndNeeded = True

                    ElseIf MakeDropDown.Text <> "" And ModelDrop.Text = "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Make` =  @Make"
                        command.Parameters.AddWithValue("@Make", MakeDropDown.Text)

                        AndNeeded = True
                    End If

                    'If year is not empty
                    If YearTextBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Year` =  @Year"
                        command.Parameters.AddWithValue("@Year", YearTextBox.Text)
                        AndNeeded = True
                    End If

                    'If body is not empty
                    If BodyStyleDropDown.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Body Style` =  @BodyStyle"
                        command.Parameters.AddWithValue("@BodyStyle", BodyStyleDropDown.Text)
                        AndNeeded = True
                    End If

                    'Milage
                    If MileageTextBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Milage` =  @Milage"
                        command.Parameters.AddWithValue("@Milage", MileageTextBox.Text)
                        AndNeeded = True
                    End If

                    'Color
                    If ColorDrop.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Dim selectcommand As MySqlCommand
                        Dim Query2 As String
                        Dim CID As Integer


                        Query2 = "SELECT `ColorinfoID` FROM `colorinfo` WHERE Color= '" & ColorDrop.Text & "'"
                        selectcommand = New MySqlCommand(Query2, connection)
                        selectcommand.Parameters.AddWithValue("@ColorinfoID", ColorDrop.Text)
                        CID = selectcommand.ExecuteScalar()
                        Search &= "`ColorID` = '" & CID & "'"

                        command.Parameters.Add("@Color", CID)
                        AndNeeded = True

                    End If

                    'Vin
                    If NewVinBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`VinNum` =  @Vin"
                        command.Parameters.AddWithValue("@Vin", NewVinBox.Text)
                        AndNeeded = True
                    End If

                    'Car Pics
                    If CarPicTextBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Car Picture` =  @CarPicture"
                        command.Parameters.AddWithValue("@CarPicture", CarPicTextBox.Text)
                        AndNeeded = True
                    End If

                    'Lot name
                    If LotDropDown.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Dim selectcommand As MySqlCommand
                        Dim Query2 As String
                        Dim LID As Integer


                        Query2 = "SELECT `Lot ID` FROM `lot info` WHERE `Lot Name`= '" & LotDropDown.Text & "'"
                        selectcommand = New MySqlCommand(Query2, connection)

                        selectcommand.Parameters.AddWithValue("@LotName", LotDropDown.Text)
                        LID = selectcommand.ExecuteScalar()

                        Search &= "`Lot ID` = '" & LID & "'"

                        command.Parameters.Add("@LotID", LID)
                        AndNeeded = True
                    End If

                    'If price min and max are filled in
                    If PriceMinTextBox.Text <> "" And PriceMaxTextBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Price` > @PriceMin AND `Price` < @PriceMax"
                        command.Parameters.AddWithValue("@PriceMin", PriceMinTextBox.Text)
                        command.Parameters.AddWithValue("@PriceMax", PriceMaxTextBox.Text)
                        AndNeeded = True

                        'If only price min is filled in 
                    ElseIf PriceMinTextBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Price` > @Price"
                        command.Parameters.AddWithValue("@Price", PriceMinTextBox.Text)
                        AndNeeded = True

                        'If only price max is filled in
                    ElseIf PriceMaxTextBox.Text <> "" Then
                        If AndNeeded Then
                            Search &= " And "
                        End If

                        Search &= "`Price` < @Price"
                        command.Parameters.AddWithValue("@Price", PriceMaxTextBox.Text)
                        AndNeeded = True
                    End If

                    'Finish command
                    Search = Search.Trim & ";"
                    'Debug.Print(Search)
                    command.CommandText = Search
                    command.Connection = connection


                    table.Load(command.ExecuteReader)

                Catch ex As Exception
                    MessageBox.Show("You need to insert at least one of the text boxes")

                End Try
            End Using
        End Using


        DataGridView1.DataSource = table
        DataGridView1.Columns(0).Visible = False

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub ClearSearch_Click(sender As Object, e As EventArgs) Handles ClearSearch.Click
        MakeDropDown.Text = ""
        ModelDrop.Text = ""
        BodyStyleDropDown.Text = ""
        YearTextBox.Text = ""
        ColorDrop.Text = ""
        MileageTextBox.Text = ""
        NewVinBox.Text = ""
        CarPicTextBox.Text = ""
        PriceMaxTextBox.Text = ""
        PriceMinTextBox.Text = ""
        LotDropDown.Text = ""

    End Sub

    Private Sub MakeDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MakeDropDown.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        ModelDrop.Items.Clear()

        Dim Query As String
        Query = "SELECT * FROM `makemodelinfo` WHERE `Make`= '" & MakeDropDown.Text & "'"
        command = New MySqlCommand(Query, connection)

        reader = command.ExecuteReader

        While reader.Read
            Dim ModID = reader.GetString("Model")
            ModelDrop.Items.Add(ModID)

        End While

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub ModelNA_CheckedChanged(sender As Object, e As EventArgs) Handles ModelNA.CheckedChanged
        If ModelNA.Checked = True Then
            ModelDrop.Enabled = False
            ModelDrop.Text = ""
        Else
            ModelDrop.Enabled = True
        End If
    End Sub

    Private Sub MilageNA_CheckedChanged_1(sender As Object, e As EventArgs) Handles MilageNA.CheckedChanged
        If MilageNA.Checked = True Then
            MileageTextBox.Text = ""
            MileageTextBox.Enabled = False
        Else
            MileageTextBox.Enabled = True
        End If
    End Sub

    Private Sub EditSubmitButton_Click(sender As Object, e As EventArgs) Handles EditSubmitButton.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim Query As String
        Query = "UPDATE `customer` SET `CustomerLastName`=@CLN WHERE `CustomerUsername`=@CUser"
        command = New MySqlCommand(Query, connection)
        command.Parameters.AddWithValue("@CUser", stringpass)
        command.Parameters.AddWithValue("@CLN", EditLName.Text)

        If ExecCommand(command) Then
            MessageBox.Show("Last Name updated")

        Else
            MessageBox.Show("Last Name NOT updated")
        End If


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub AddToPotSaleButton_Click(sender As Object, e As EventArgs) Handles AddToPotSaleButton.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim command2 As New MySqlCommand("SELECT `CustomerID` FROM `customer` WHERE `CustomerUserName`=@CUser", connection)
        command2.Parameters.AddWithValue("@CUser", stringpass)
        Dim CustID As Integer
        CustID = command2.ExecuteScalar

        Dim command0 As New MySqlCommand("SELECT * FROM `salespotpurchase` WHERE `SalesCarID`=@SCID AND `SalesCustID`=@SCUSTID", connection)
        command0.Parameters.AddWithValue("@SCID", CarIDint)
        command0.Parameters.AddWithValue("@SCUSTID", CustID)

        reader = command0.ExecuteReader()

        If (reader.HasRows) Then
            MessageBox.Show("Error, car is already in your potential purchase list!")
        Else
            reader.Close()

            Dim command As New MySqlCommand("INSERT INTO `salespotpurchase` (`SalesCarID`,`SalesCustID`)
        VALUES (@SalesCarID, @SalesCustID)", connection)


            command.Parameters.AddWithValue("@SalesCarID", CarIDint)
            command.Parameters.AddWithValue("@SalesCustID", CustID)


            If ExecCommand(command) Then
                MessageBox.Show("Data entered successfuly")
            End If
        End If

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

End Class