<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSalesPersonHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.YearText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDrop = New System.Windows.Forms.ComboBox()
        Me.ColorinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NEWSALESDBDATASET = New SalesPersonMain.NEWSALESDBDATASET()
        Me.SalesdbDataSetFIXED = New SalesPersonMain.salesdbDataSetFIXED()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BodyStyleDrop = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MilageText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PriceText = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.VinText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CarPicText = New System.Windows.Forms.TextBox()
        Me.LotDropDown = New System.Windows.Forms.ComboBox()
        Me.LotInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDBDS = New SalesPersonMain.SalesDBDS()
        Me.Lot_infoTableAdapter = New SalesPersonMain.SalesDBDSTableAdapters.lot_infoTableAdapter()
        Me.SubmitCar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LotTools = New System.Windows.Forms.Button()
        Me.MakeModelNA = New System.Windows.Forms.CheckBox()
        Me.YearNA = New System.Windows.Forms.CheckBox()
        Me.BodyStyleNA = New System.Windows.Forms.CheckBox()
        Me.MilageNA = New System.Windows.Forms.CheckBox()
        Me.ColorNA = New System.Windows.Forms.CheckBox()
        Me.PriceNA = New System.Windows.Forms.CheckBox()
        Me.VinNA = New System.Windows.Forms.CheckBox()
        Me.CarPicNA = New System.Windows.Forms.CheckBox()
        Me.LotNA = New System.Windows.Forms.CheckBox()
        Me.CustomerCurrentGrid = New System.Windows.Forms.DataGridView()
        Me.SalespotpurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalespotpurchaseTableAdapter = New SalesPersonMain.SalesDBDSTableAdapters.salespotpurchaseTableAdapter()
        Me.PrevGrid = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MakemodelinfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MakemodelinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MakemodelinfoTableAdapter = New SalesPersonMain.salesdbDataSetFIXEDTableAdapters.makemodelinfoTableAdapter()
        Me.ColorinfoTableAdapter = New SalesPersonMain.salesdbDataSetFIXEDTableAdapters.colorinfoTableAdapter()
        Me.ColorinfoTableAdapter1 = New SalesPersonMain.NEWSALESDBDATASETTableAdapters.colorinfoTableAdapter()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SalesPersonMain.NEWSALESDBDATASETTableAdapters.productTableAdapter()
        Me.MakemodelinfoTableAdapter1 = New SalesPersonMain.NEWSALESDBDATASETTableAdapters.makemodelinfoTableAdapter()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MakeDropDown = New System.Windows.Forms.ComboBox()
        Me.ModelDropDown = New System.Windows.Forms.ComboBox()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.RefreshPrev = New System.Windows.Forms.Button()
        Me.RefreshSalesPrevPurc = New System.Windows.Forms.Button()
        CType(Me.ColorinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NEWSALESDBDATASET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesdbDataSetFIXED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerCurrentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespotpurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrevGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakemodelinfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakemodelinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Model"
        '
        'YearText
        '
        Me.YearText.Location = New System.Drawing.Point(256, 117)
        Me.YearText.Name = "YearText"
        Me.YearText.Size = New System.Drawing.Size(87, 20)
        Me.YearText.TabIndex = 230
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "Year"
        '
        'ColorDrop
        '
        Me.ColorDrop.FormattingEnabled = True
        Me.ColorDrop.Location = New System.Drawing.Point(616, 114)
        Me.ColorDrop.Name = "ColorDrop"
        Me.ColorDrop.Size = New System.Drawing.Size(80, 21)
        Me.ColorDrop.TabIndex = 232
        '
        'ColorinfoBindingSource
        '
        Me.ColorinfoBindingSource.DataMember = "colorinfo"
        Me.ColorinfoBindingSource.DataSource = Me.NEWSALESDBDATASET
        '
        'NEWSALESDBDATASET
        '
        Me.NEWSALESDBDATASET.DataSetName = "NEWSALESDBDATASET"
        Me.NEWSALESDBDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesdbDataSetFIXED
        '
        Me.SalesdbDataSetFIXED.DataSetName = "salesdbDataSetFIXED"
        Me.SalesdbDataSetFIXED.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(641, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 233
        Me.Label4.Text = "Color"
        '
        'BodyStyleDrop
        '
        Me.BodyStyleDrop.FormattingEnabled = True
        Me.BodyStyleDrop.Items.AddRange(New Object() {"Sedan", "Coupe"})
        Me.BodyStyleDrop.Location = New System.Drawing.Point(358, 116)
        Me.BodyStyleDrop.Name = "BodyStyleDrop"
        Me.BodyStyleDrop.Size = New System.Drawing.Size(99, 21)
        Me.BodyStyleDrop.TabIndex = 234
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 235
        Me.Label5.Text = "Body Style"
        '
        'MilageText
        '
        Me.MilageText.Location = New System.Drawing.Point(480, 116)
        Me.MilageText.Name = "MilageText"
        Me.MilageText.Size = New System.Drawing.Size(96, 20)
        Me.MilageText.TabIndex = 236
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(505, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 237
        Me.Label6.Text = "Milage"
        '
        'PriceText
        '
        Me.PriceText.Location = New System.Drawing.Point(723, 115)
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Size = New System.Drawing.Size(96, 20)
        Me.PriceText.TabIndex = 238
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(752, 90)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(31, 13)
        Me.Label.TabIndex = 239
        Me.Label.Text = "Price"
        '
        'VinText
        '
        Me.VinText.Location = New System.Drawing.Point(844, 115)
        Me.VinText.Name = "VinText"
        Me.VinText.Size = New System.Drawing.Size(96, 20)
        Me.VinText.TabIndex = 240
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(868, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "VinBox"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(973, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Car Picture"
        '
        'CarPicText
        '
        Me.CarPicText.Location = New System.Drawing.Point(962, 115)
        Me.CarPicText.Name = "CarPicText"
        Me.CarPicText.Size = New System.Drawing.Size(96, 20)
        Me.CarPicText.TabIndex = 243
        '
        'LotDropDown
        '
        Me.LotDropDown.FormattingEnabled = True
        Me.LotDropDown.Location = New System.Drawing.Point(1080, 114)
        Me.LotDropDown.Name = "LotDropDown"
        Me.LotDropDown.Size = New System.Drawing.Size(127, 21)
        Me.LotDropDown.TabIndex = 244
        '
        'LotInfoBindingSource
        '
        Me.LotInfoBindingSource.DataMember = "lot info"
        Me.LotInfoBindingSource.DataSource = Me.SalesDBDS
        '
        'SalesDBDS
        '
        Me.SalesDBDS.DataSetName = "SalesDBDS"
        Me.SalesDBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lot_infoTableAdapter
        '
        Me.Lot_infoTableAdapter.ClearBeforeFill = True
        '
        'SubmitCar
        '
        Me.SubmitCar.Location = New System.Drawing.Point(1225, 100)
        Me.SubmitCar.Name = "SubmitCar"
        Me.SubmitCar.Size = New System.Drawing.Size(136, 48)
        Me.SubmitCar.TabIndex = 246
        Me.SubmitCar.Text = "Submit new car"
        Me.SubmitCar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(402, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 29)
        Me.Label10.TabIndex = 247
        Me.Label10.Text = "SALESPERSON HOME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(419, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 20)
        Me.Label11.TabIndex = 248
        Me.Label11.Text = "Add a new car to the database"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 61)
        Me.Button1.TabIndex = 249
        Me.Button1.Text = "Edit Cars"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LotTools
        '
        Me.LotTools.Location = New System.Drawing.Point(644, 255)
        Me.LotTools.Name = "LotTools"
        Me.LotTools.Size = New System.Drawing.Size(162, 61)
        Me.LotTools.TabIndex = 250
        Me.LotTools.Text = "Lot Tools"
        Me.LotTools.UseVisualStyleBackColor = True
        '
        'MakeModelNA
        '
        Me.MakeModelNA.AutoSize = True
        Me.MakeModelNA.Location = New System.Drawing.Point(114, 155)
        Me.MakeModelNA.Name = "MakeModelNA"
        Me.MakeModelNA.Size = New System.Drawing.Size(46, 17)
        Me.MakeModelNA.TabIndex = 251
        Me.MakeModelNA.Text = "N/A"
        Me.MakeModelNA.UseVisualStyleBackColor = True
        '
        'YearNA
        '
        Me.YearNA.AutoSize = True
        Me.YearNA.Location = New System.Drawing.Point(265, 155)
        Me.YearNA.Name = "YearNA"
        Me.YearNA.Size = New System.Drawing.Size(46, 17)
        Me.YearNA.TabIndex = 253
        Me.YearNA.Text = "N/A"
        Me.YearNA.UseVisualStyleBackColor = True
        '
        'BodyStyleNA
        '
        Me.BodyStyleNA.AutoSize = True
        Me.BodyStyleNA.Location = New System.Drawing.Point(380, 155)
        Me.BodyStyleNA.Name = "BodyStyleNA"
        Me.BodyStyleNA.Size = New System.Drawing.Size(46, 17)
        Me.BodyStyleNA.TabIndex = 254
        Me.BodyStyleNA.Text = "N/A"
        Me.BodyStyleNA.UseVisualStyleBackColor = True
        '
        'MilageNA
        '
        Me.MilageNA.AutoSize = True
        Me.MilageNA.Location = New System.Drawing.Point(497, 155)
        Me.MilageNA.Name = "MilageNA"
        Me.MilageNA.Size = New System.Drawing.Size(46, 17)
        Me.MilageNA.TabIndex = 255
        Me.MilageNA.Text = "N/A"
        Me.MilageNA.UseVisualStyleBackColor = True
        '
        'ColorNA
        '
        Me.ColorNA.AutoSize = True
        Me.ColorNA.Location = New System.Drawing.Point(634, 155)
        Me.ColorNA.Name = "ColorNA"
        Me.ColorNA.Size = New System.Drawing.Size(46, 17)
        Me.ColorNA.TabIndex = 256
        Me.ColorNA.Text = "N/A"
        Me.ColorNA.UseVisualStyleBackColor = True
        '
        'PriceNA
        '
        Me.PriceNA.AutoSize = True
        Me.PriceNA.Location = New System.Drawing.Point(746, 155)
        Me.PriceNA.Name = "PriceNA"
        Me.PriceNA.Size = New System.Drawing.Size(46, 17)
        Me.PriceNA.TabIndex = 257
        Me.PriceNA.Text = "N/A"
        Me.PriceNA.UseVisualStyleBackColor = True
        '
        'VinNA
        '
        Me.VinNA.AutoSize = True
        Me.VinNA.Location = New System.Drawing.Point(871, 155)
        Me.VinNA.Name = "VinNA"
        Me.VinNA.Size = New System.Drawing.Size(46, 17)
        Me.VinNA.TabIndex = 258
        Me.VinNA.Text = "N/A"
        Me.VinNA.UseVisualStyleBackColor = True
        '
        'CarPicNA
        '
        Me.CarPicNA.AutoSize = True
        Me.CarPicNA.Location = New System.Drawing.Point(976, 155)
        Me.CarPicNA.Name = "CarPicNA"
        Me.CarPicNA.Size = New System.Drawing.Size(46, 17)
        Me.CarPicNA.TabIndex = 259
        Me.CarPicNA.Text = "N/A"
        Me.CarPicNA.UseVisualStyleBackColor = True
        '
        'LotNA
        '
        Me.LotNA.AutoSize = True
        Me.LotNA.Location = New System.Drawing.Point(1098, 157)
        Me.LotNA.Name = "LotNA"
        Me.LotNA.Size = New System.Drawing.Size(46, 17)
        Me.LotNA.TabIndex = 260
        Me.LotNA.Text = "N/A"
        Me.LotNA.UseVisualStyleBackColor = True
        '
        'CustomerCurrentGrid
        '
        Me.CustomerCurrentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerCurrentGrid.Location = New System.Drawing.Point(710, 368)
        Me.CustomerCurrentGrid.Name = "CustomerCurrentGrid"
        Me.CustomerCurrentGrid.Size = New System.Drawing.Size(485, 212)
        Me.CustomerCurrentGrid.TabIndex = 261
        '
        'SalespotpurchaseBindingSource
        '
        Me.SalespotpurchaseBindingSource.DataMember = "salespotpurchase"
        Me.SalespotpurchaseBindingSource.DataSource = Me.SalesDBDS
        '
        'SalespotpurchaseTableAdapter
        '
        Me.SalespotpurchaseTableAdapter.ClearBeforeFill = True
        '
        'PrevGrid
        '
        Me.PrevGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrevGrid.Location = New System.Drawing.Point(58, 368)
        Me.PrevGrid.Name = "PrevGrid"
        Me.PrevGrid.Size = New System.Drawing.Size(485, 212)
        Me.PrevGrid.TabIndex = 262
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(146, 329)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(268, 20)
        Me.Label12.TabIndex = 263
        Me.Label12.Text = "Salesperson and their previous sales"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(857, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 20)
        Me.Label13.TabIndex = 264
        Me.Label13.Text = "Customer's current sales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(52, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 265
        Me.Label14.Text = "Make"
        '
        'MakemodelinfoBindingSource1
        '
        Me.MakemodelinfoBindingSource1.DataMember = "makemodelinfo"
        Me.MakemodelinfoBindingSource1.DataSource = Me.NEWSALESDBDATASET
        '
        'MakemodelinfoBindingSource
        '
        Me.MakemodelinfoBindingSource.DataMember = "makemodelinfo"
        Me.MakemodelinfoBindingSource.DataSource = Me.SalesdbDataSetFIXED
        '
        'MakemodelinfoTableAdapter
        '
        Me.MakemodelinfoTableAdapter.ClearBeforeFill = True
        '
        'ColorinfoTableAdapter
        '
        Me.ColorinfoTableAdapter.ClearBeforeFill = True
        '
        'ColorinfoTableAdapter1
        '
        Me.ColorinfoTableAdapter1.ClearBeforeFill = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me.NEWSALESDBDATASET
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'MakemodelinfoTableAdapter1
        '
        Me.MakemodelinfoTableAdapter1.ClearBeforeFill = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(1225, 157)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(136, 44)
        Me.Refresh.TabIndex = 267
        Me.Refresh.Text = "Refresh "
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1108, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 271
        Me.Label16.Text = "Lot Name"
        '
        'MakeDropDown
        '
        Me.MakeDropDown.FormattingEnabled = True
        Me.MakeDropDown.Location = New System.Drawing.Point(30, 117)
        Me.MakeDropDown.Name = "MakeDropDown"
        Me.MakeDropDown.Size = New System.Drawing.Size(81, 21)
        Me.MakeDropDown.TabIndex = 272
        '
        'ModelDropDown
        '
        Me.ModelDropDown.FormattingEnabled = True
        Me.ModelDropDown.Location = New System.Drawing.Point(138, 117)
        Me.ModelDropDown.Name = "ModelDropDown"
        Me.ModelDropDown.Size = New System.Drawing.Size(89, 21)
        Me.ModelDropDown.TabIndex = 273
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseButton.Location = New System.Drawing.Point(1001, 601)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(171, 47)
        Me.PurchaseButton.TabIndex = 282
        Me.PurchaseButton.Text = "Sell car to customer"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'RefreshPrev
        '
        Me.RefreshPrev.Location = New System.Drawing.Point(766, 601)
        Me.RefreshPrev.Name = "RefreshPrev"
        Me.RefreshPrev.Size = New System.Drawing.Size(151, 46)
        Me.RefreshPrev.TabIndex = 283
        Me.RefreshPrev.Text = "Refresh "
        Me.RefreshPrev.UseVisualStyleBackColor = True
        '
        'RefreshSalesPrevPurc
        '
        Me.RefreshSalesPrevPurc.Location = New System.Drawing.Point(202, 601)
        Me.RefreshSalesPrevPurc.Name = "RefreshSalesPrevPurc"
        Me.RefreshSalesPrevPurc.Size = New System.Drawing.Size(151, 47)
        Me.RefreshSalesPrevPurc.TabIndex = 284
        Me.RefreshSalesPrevPurc.Text = "Refresh "
        Me.RefreshSalesPrevPurc.UseVisualStyleBackColor = True
        '
        'NewSalesPersonHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 704)
        Me.Controls.Add(Me.RefreshSalesPrevPurc)
        Me.Controls.Add(Me.RefreshPrev)
        Me.Controls.Add(Me.PurchaseButton)
        Me.Controls.Add(Me.ModelDropDown)
        Me.Controls.Add(Me.MakeDropDown)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PrevGrid)
        Me.Controls.Add(Me.CustomerCurrentGrid)
        Me.Controls.Add(Me.LotNA)
        Me.Controls.Add(Me.CarPicNA)
        Me.Controls.Add(Me.VinNA)
        Me.Controls.Add(Me.PriceNA)
        Me.Controls.Add(Me.ColorNA)
        Me.Controls.Add(Me.MilageNA)
        Me.Controls.Add(Me.BodyStyleNA)
        Me.Controls.Add(Me.YearNA)
        Me.Controls.Add(Me.MakeModelNA)
        Me.Controls.Add(Me.LotTools)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SubmitCar)
        Me.Controls.Add(Me.LotDropDown)
        Me.Controls.Add(Me.CarPicText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.VinText)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.PriceText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MilageText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BodyStyleDrop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ColorDrop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.YearText)
        Me.Controls.Add(Me.Label2)
        Me.Name = "NewSalesPersonHome"
        Me.Text = "NewSalesPersonHome"
        CType(Me.ColorinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NEWSALESDBDATASET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesdbDataSetFIXED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerCurrentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespotpurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrevGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakemodelinfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakemodelinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents YearText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColorDrop As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BodyStyleDrop As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MilageText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PriceText As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents VinText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CarPicText As TextBox
    Friend WithEvents LotDropDown As ComboBox
    Friend WithEvents SalesDBDS As SalesDBDS
    Friend WithEvents LotInfoBindingSource As BindingSource
    Friend WithEvents Lot_infoTableAdapter As SalesDBDSTableAdapters.lot_infoTableAdapter
    Friend WithEvents SubmitCar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LotTools As Button
    Friend WithEvents MakeModelNA As CheckBox
    Friend WithEvents YearNA As CheckBox
    Friend WithEvents BodyStyleNA As CheckBox
    Friend WithEvents MilageNA As CheckBox
    Friend WithEvents ColorNA As CheckBox
    Friend WithEvents PriceNA As CheckBox
    Friend WithEvents VinNA As CheckBox
    Friend WithEvents CarPicNA As CheckBox
    Friend WithEvents LotNA As CheckBox
    Friend WithEvents CustomerCurrentGrid As DataGridView
    Friend WithEvents SalespotpurchaseBindingSource As BindingSource
    Friend WithEvents SalespotpurchaseTableAdapter As SalesDBDSTableAdapters.salespotpurchaseTableAdapter
    Friend WithEvents PrevGrid As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SalesdbDataSetFIXED As salesdbDataSetFIXED
    Friend WithEvents MakemodelinfoBindingSource As BindingSource
    Friend WithEvents MakemodelinfoTableAdapter As salesdbDataSetFIXEDTableAdapters.makemodelinfoTableAdapter
    Friend WithEvents ColorinfoTableAdapter As salesdbDataSetFIXEDTableAdapters.colorinfoTableAdapter
    Friend WithEvents NEWSALESDBDATASET As NEWSALESDBDATASET
    Friend WithEvents ColorinfoBindingSource As BindingSource
    Friend WithEvents ColorinfoTableAdapter1 As NEWSALESDBDATASETTableAdapters.colorinfoTableAdapter
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As NEWSALESDBDATASETTableAdapters.productTableAdapter
    Friend WithEvents MakemodelinfoBindingSource1 As BindingSource
    Friend WithEvents MakemodelinfoTableAdapter1 As NEWSALESDBDATASETTableAdapters.makemodelinfoTableAdapter
    Friend WithEvents Refresh As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents MakeDropDown As ComboBox
    Friend WithEvents ModelDropDown As ComboBox
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents RefreshPrev As Button
    Friend WithEvents RefreshSalesPrevPurc As Button
End Class
