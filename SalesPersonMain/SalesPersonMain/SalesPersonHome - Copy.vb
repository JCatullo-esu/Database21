Imports System
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB") 'do this for eXISTING
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim connectionString = "server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=SalesDB"
    Dim table As New DataTable()

    Private Sub LotLookButton_Click(sender As Object, e As EventArgs) Handles LotLookButton.Click
        Dim lot = New LotCityLook()
        lot.Show()
    End Sub

    Private Sub SalePersonNamePot_TextChanged(sender As Object, e As EventArgs) Handles SalePersonFNamePot.TextChanged

    End Sub

    Private Sub PreviousSaleButton_Click(sender As Object, e As EventArgs) Handles PreviousSaleButton.Click
        Dim sales = New PreviousSales()
        sales.Show()
    End Sub

    Private Sub SalesDeclinedButton_Click(sender As Object, e As EventArgs) Handles SalesDeclinedButton.Click

    End Sub

    'VVV'
    Private Sub LookupCustDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LookupCustDrop.SelectedIndexChanged

    End Sub

    Private Sub BodyStyleDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BodyStyleDropDown.SelectedIndexChanged

    End Sub

    Private Sub NewColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NewColorDrop.SelectedIndexChanged

    End Sub

    Private Sub MakeTextBox_TextChanged(sender As Object, e As EventArgs) Handles MakeTextBox.TextChanged

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



    'ADD CAR TO THE DATABASE'
    Private Sub SubmitCarToDatabaseButton_Click(sender As Object, e As EventArgs) Handles SubmitCarToDatabaseButton.Click
        'If connection.State = ConnectionState.Closed Then
        'connection.Open()
        'End If

        'command = New MySqlCommand(insertString, connection)
        Dim command As New MySqlCommand("INSERT INTO product (`Make`,`Model`,`Year`,`Body Style`, 
        `Milage`,`Color`,`Price`,`VinNum`, `Car Picture`, `Car Lot ID`) VALUES 
         (@MakeTextBox, @ModelTextBox, @YearTextBox, @BodyStyleDropDown, @MileageTextBox, @NewColorDrop, @PriceTextBox, 
         @NewVinBox, @CarPicTextBox, @LotDropDown)", connection)
        'Using connection As New MySqlConnection(connectionString)
        'Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@MakeTextBox", MakeTextBox.Text)
        command.Parameters.AddWithValue("@ModelTextBox", ModelTextBox.Text)
        command.Parameters.AddWithValue("@YearTextBox", YearTextBox.Text)


        command.Parameters.AddWithValue("@BodyStyleDropDown", BodyStyleDropDown.Text)


        command.Parameters.AddWithValue("@MileageTextBox", MileageTextBox.Text)


        command.Parameters.AddWithValue("@NewColorDrop", NewColorDrop.Text)


        command.Parameters.AddWithValue("@PriceTextBox", PriceTextBox.Text)
        command.Parameters.AddWithValue("@NewVinBox", NewVinBox.Text)
        command.Parameters.AddWithValue("@CarPicTextBox", CarPicTextBox.Text)


        'ERROR WITH FOREIGN KEY, MAKE IT LINK WITH LOT ID'S'
        command.Parameters.AddWithValue("@LotDropDown", LotDropDown.Text)


        If ExecCommand(command) Then
                MessageBox.Show("Data Inserted")

            Else
                MessageBox.Show("Data NOT Inserted")
            End If



        'End Using
        'connection.Close()
    End Sub


    ''' '''''''''''''''''''

    Private Sub Display_Data_From_MySQL_Depending_On_Combobox_Value_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesdbDataSet.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.SalesdbDataSet.product)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim adapter As New MySqlDataAdapter("SELECT * FROM product", connection)

        adapter.Fill(table)

        'EditCarIDDrop.DataSource = table

        'EditCarIDDrop.DisplayMember = "CarID"
        'EditCarIDDrop.ValueMember = "CarID"


    End Sub

    Private Sub LookUp_Click(sender As Object, e As EventArgs)
        'Dim adapter2 As New MySqlDataAdapter("SELECT `CarID`, `Make`, `Model`, `Year`,
        '`Body Style`, `Milage`, `Color`, `Price`, `VinNum`, `Car Picture`,
        '`Car Lot ID` FROM product WHERE CarID=" & EditCarIDDrop.SelectedValue, connection)
        'Dim table As New DataTable()

        'adapter2.Fill(table)

        'EditMakeBox.Text = table(0)(1)
        ' EditModelBox.Text = table(0)(2)
        ' EditYearBox.Text = table(0)(3)
        ' BodyStyleDisplay.Text = table(0)(4)
        ' EditMileageBox.Text = table(0)(5)
        ' ColorDisplay.Text = table(0)(6)
        ' EditPrice.Text = table(0)(7)
        ' EditVinBox.Text = table(0)(8)
        '  EditCarPic.Text = table(0)(9)
        '  LotIDDisplay.Text = table(0)(10)



    End Sub


    Private Sub EditCarIDDrop_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditMileageBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalesmanDropDownPot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SalesmanDropDownPot.SelectedIndexChanged

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.ProductTableAdapter.FillBy(Me.SalesdbDataSet.product)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim editcar = New EditCarViewer()
        editcar.Show()
    End Sub

    Private Sub EditLotDropBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
