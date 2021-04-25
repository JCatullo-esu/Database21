Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class NewEditCar
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand
    Dim command3 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim reader2 As MySqlDataReader
    Dim reader3 As MySqlDataReader

    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")

    Private Sub DataGridView1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NEWSALESDBDATASET.makemodelinfo' table. You can move, or remove it, as needed.
        Me.MakemodelinfoTableAdapter.Fill(Me.NEWSALESDBDATASET.makemodelinfo)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim adapter As New MySqlDataAdapter("SELECT `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture`,
        `Lot Name` FROM `product` LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON
        `colorinfo`.`ColorinfoID` = `product`.`ColorID` LEFT JOIN  `lotcarinfo` on `lotcarinfo`.`CarInLotID` = `product`.`CarID` LEFT JOIN 
         `lot info` ON `lot info`.`Lot ID` = `lotcarinfo`.`CarLotID` WHERE `lotcarinfo`.`CarInLotID` = `product`.`CarID`", connection)

        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub NewEditCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Clear then repopulate
        MakeText.Items.Clear()
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

            If Not MakeText.Items.Contains(MaID) Then
                MakeText.Items.Add(MaID)
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

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            Me.CarIDText.Text = DataGridView1.Item(0, i).Value.ToString()
            Me.MakeText.Text = DataGridView1.Item(1, i).Value.ToString()
            Me.ModelText.Text = DataGridView1.Item(2, i).Value.ToString()
            Me.YearText.Text = DataGridView1.Item(3, i).Value.ToString()
            Me.BodyStyleDrop.Text = DataGridView1.Item(4, i).Value.ToString()
            Me.MilageText.Text = DataGridView1.Item(5, i).Value.ToString()
            Me.ColorDrop.Text = DataGridView1.Item(6, i).Value.ToString()
            Me.PriceText.Text = DataGridView1.Item(7, i).Value.ToString()
            Me.VinText.Text = DataGridView1.Item(8, i).Value.ToString()
            Me.CarPicText.Text = DataGridView1.Item(9, i).Value.ToString()
            Me.LotDropDown.Text = DataGridView1.Item(10, i).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("Error, nothing in fields")
        End Try

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim cmd As New MySqlCommand("UPDATE PRODUCT SET `MMID`=@MMID,`Year`=@CarYear,`Body Style`=@BodyStyle,`Milage`=@CarMilage,
        `ColorID`=@CarColor, `Price`=@CarPrice, `VinNum`=@CarVinNum, `Car Picture`=@CarPicture WHERE `CarID`=@CarID", connection)

        cmd.Parameters.AddWithValue("@CarID", CarIDText.Text)

        Dim Query As String
        Dim selectcommand As MySqlCommand
        Query = "SELECT `MMinfoID` FROM `makemodelinfo` WHERE Make= '" & MakeText.Text & "' AND Model= '" & ModelText.Text & "'"
        selectcommand = New MySqlCommand(Query, connection)

        Dim Query2 As String
        Query2 = "SELECT `ColorinfoID` FROM `colorinfo` WHERE Color= '" & ColorDrop.Text & "'"
        Dim selectcommand2 As MySqlCommand
        selectcommand2 = New MySqlCommand(Query2, connection)


        Dim Query3 As String
        Query3 = "SELECT `Lot ID` FROM `lot info` WHERE `Lot Name`= '" & LotDropDown.Text & "'"
        Dim selectcommand3 As MySqlCommand
        selectcommand3 = New MySqlCommand(Query3, connection)


        If MakeText.Text = "" Or ModelText.Text = "" Then
            cmd.Parameters.AddWithValue("@MMID", DBNull.Value)
        Else
            Dim MMIDstring As Integer

            selectcommand.Parameters.AddWithValue("@MakeText", MakeText.Text)
            selectcommand.Parameters.AddWithValue("@ModelText", ModelText.Text)

            MMIDstring = selectcommand.ExecuteScalar()

            cmd.Parameters.AddWithValue("@MMID", MMIDstring)
        End If

        If YearText.Text = "" Then
            cmd.Parameters.AddWithValue("@CarYear", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CarYear", YearText.Text)
        End If

        cmd.Parameters.AddWithValue("@BodyStyle", BodyStyleDrop?.Text)

        If MilageText.Text = "" Then
            cmd.Parameters.AddWithValue("@CarMilage", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CarMilage", MilageText.Text)
        End If

        If ColorDrop.Text = "" Then
            cmd.Parameters.AddWithValue("@CarColor", DBNull.Value)
        Else
            Dim SelectColorID As Integer

            selectcommand2.Parameters.AddWithValue("@Color", ColorDrop.Text)
            SelectColorID = selectcommand2.ExecuteScalar()

            cmd.Parameters.AddWithValue("@CarColor", SelectColorID)
        End If

        If PriceText.Text = "" Then
            cmd.Parameters.AddWithValue("@CarPrice", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CarPrice", PriceText.Text)
        End If

        If VinText.Text = "" Then
            cmd.Parameters.AddWithValue("@CarVinNum", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CarVinNum", VinText.Text)
        End If

        If CarPicText.Text = "" Then
            cmd.Parameters.AddWithValue("@CarPicture", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CarPicture", CarPicText.Text)
        End If

        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE `lotcarinfo` SET `CarLotID`=@CarLotID WHERE `CarInLotID`=@CarID"

        If LotDropDown.Text = "" Then
            cmd.Parameters.AddWithValue("@CarLotID", DBNull.Value)
        Else
            Dim LotIDstring As Integer

            selectcommand3.Parameters.AddWithValue("@LotName", LotDropDown.Text)

            LotIDstring = selectcommand3.ExecuteScalar()

            cmd.Parameters.AddWithValue("@CarLotID", LotIDstring)
        End If

        If ExecCommand(cmd) Then
                MessageBox.Show("Data updated")

            Else
                MessageBox.Show("Data NOT updated")
            End If


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Dim adapter As New MySqlDataAdapter("SELECT `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture`,
        `Lot Name` FROM `product` LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON
        `colorinfo`.`ColorinfoID` = `product`.`ColorID` LEFT JOIN  `lotcarinfo` on `lotcarinfo`.`CarInLotID` = `product`.`CarID` LEFT JOIN 
         `lot info` ON `lot info`.`Lot ID` = `lotcarinfo`.`CarLotID` WHERE `lotcarinfo`.`CarInLotID` = `product`.`CarID`", connection)

            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub LotNA_CheckedChanged(sender As Object, e As EventArgs) Handles LotNA.CheckedChanged
        If LotNA.Checked = True Then
            LotDropDown.Enabled = False
            LotDropDown.Text = ""
        Else
            LotDropDown.Enabled = True
        End If
    End Sub

    Private Sub AddNewMakeModelColor_Click(sender As Object, e As EventArgs) Handles AddNewMakeModelColor.Click
        Dim NewOptions = New NewMakeModelColor()
        NewOptions.Show()
    End Sub



    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Clear then repopulate
        MakeText.Items.Clear()
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

            If Not MakeText.Items.Contains(MaID) Then
                MakeText.Items.Add(MaID)
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

    Private Sub MakeModelNA_CheckedChanged(sender As Object, e As EventArgs) Handles MakeModelNA.CheckedChanged
        If MakeModelNA.Checked = True Then
            MakeText.Enabled = False
            MakeText.Text = ""
        Else
            MakeText.Enabled = True
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

    Private Sub BodystyleNA_CheckedChanged(sender As Object, e As EventArgs) Handles BodystyleNA.CheckedChanged
        If BodystyleNA.Checked = True Then
            BodyStyleDrop.Enabled = False
            BodyStyleDrop.Text = ""
        Else
            BodyStyleDrop.Enabled = True
        End If
    End Sub

    Private Sub ModelNA_CheckedChanged(sender As Object, e As EventArgs) Handles ModelNA.CheckedChanged
        If ModelNA.Checked = True Then
            ModelText.Enabled = False
            ModelText.Text = ""
        Else
            ModelText.Enabled = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            Dim query As String = "DELETE FROM `product` WHERE `CarID` ='" & CarIDText.Text & "'"
            Dim delete As New MySqlCommand(query, connection)

            reader = delete.ExecuteReader
            MessageBox.Show("Data Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub MakeText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MakeText.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        ModelText.Items.Clear()

        Dim Query As String
        Query = "SELECT * FROM `makemodelinfo` WHERE `Make`= '" & MakeText.Text & "'"
        command = New MySqlCommand(Query, connection)

        reader = command.ExecuteReader

        While reader.Read
            Dim ModID = reader.GetString("Model")
            ModelText.Items.Add(ModID)

        End While

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class