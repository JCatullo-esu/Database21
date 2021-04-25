Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class LotCityLook
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB")
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub LotIDAdd_TextChanged(sender As Object, e As EventArgs)

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



    Private Sub AddLotButton_Click(sender As Object, e As EventArgs) Handles AddLotButton.Click
        Dim command As New MySqlCommand("INSERT INTO `lot info` (`Lot Name`,`Lot Street Num`,`Lot Street Name`,`Lot City`,`Lot Zip code`)
        VALUES (@LotName,@LotStreetNumAdd, @LotStreetAdd, @LotCityAdd, @LotZipAdd)", connection)

        Dim checkStreetNum As Boolean
        Dim checkZip As Boolean

        If IsNumeric(LotStreetNumAdd.Text) Then
            ErrorLabelStreetNum.Text = ""
            checkStreetNum = True

        Else
            'Exception Check, clears if not int
            ErrorLabelStreetNum.Text = "Error, enter integer value"
            LotStreetNumAdd.Clear()
        End If

        If IsNumeric(LotZipAdd.Text) Then
            ErrorLabelZipCode.Text = ""
            checkZip = True
        Else
            ErrorLabelZipCode.Text = "Error, enter integer value"
            LotZipAdd.Clear()
        End If

        If checkStreetNum = True And checkZip = True Then
            command.Parameters.AddWithValue("@LotName", LotName.Text)
            command.Parameters.AddWithValue("@LotStreetNumAdd", LotStreetNumAdd.Text)
            command.Parameters.AddWithValue("@LotStreetAdd", LotStreetAdd.Text)
            command.Parameters.AddWithValue("@LotCityAdd", LotCityAdd.Text)
            command.Parameters.AddWithValue("@LotZipAdd", LotZipAdd.Text)

            If ExecCommand(command) Then
                MessageBox.Show("Data Inserted")

            Else
                MessageBox.Show("Data NOT Inserted")
            End If
        Else
            MessageBox.Show("ERROR, check value(s)!")
        End If



    End Sub

    Private Sub LotCityLook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If


        Dim adapter As New MySqlDataAdapter("SELECT `Lot ID`, `Lot Name`,`Lot Street Num`, `Lot Street Name`, `Lot city`, `Lot Zip code`,
            `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture` FROM `lot info` LEFT JOIN `lotcarinfo` ON `lotcarinfo`.`CarLotID` =  `lot info`.`Lot ID` 
            LEFT JOIN `product` ON `product`.`CarID` = `lotcarinfo`.`CarInLotID` LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON `colorinfo`.`ColorInfoID` = `product`.`ColorID`", connection)

        '  Dim adapter As New MySqlDataAdapter("SELECT `CarID`,`MMID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`ColorInfoID` `Color`,`Price`,`VinNum`,`Car Picture`,
        '`Car Lot ID` FROM `product` LEFT JOIN `makemodelinfo` on `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON
        ' `colorinfo`.`ColorinfoID` = `product`.`ColorID`", connection)




        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table


        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Try
            Dim adapter As New MySqlDataAdapter("SELECT `Lot ID`, `Lot Name`,`Lot Street Num`, `Lot Street Name`, `Lot city`, `Lot Zip code`,
            `CarID`,`Make`,`Model`,`Year`,`Body Style`,`Milage`,`Color`,`Price`,`VinNum`,`Car Picture` FROM `lot info` LEFT JOIN `lotcarinfo` ON `lotcarinfo`.`CarLotID` =  `lot info`.`Lot ID` 
            LEFT JOIN `product` ON `product`.`CarID` = `lotcarinfo`.`CarInLotID` LEFT JOIN `makemodelinfo` ON `makemodelinfo`.`MMinfoID` = `product`.`MMID` LEFT JOIN `colorinfo` ON `colorinfo`.`ColorInfoID` = `product`.`ColorID`", connection)


            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Prevent special chars
    Private Sub LotName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LotName.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
    End Sub
End Class