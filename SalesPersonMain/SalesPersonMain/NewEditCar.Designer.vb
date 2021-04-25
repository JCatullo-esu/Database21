<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEditCar
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BodyStyleDrop = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YearText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VinText = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.PriceText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MilageText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LotDropDown = New System.Windows.Forms.ComboBox()
        Me.LotInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDBDS1 = New SalesPersonMain.SalesDBDS()
        Me.CarPicText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDBDS = New SalesPersonMain.SalesDBDS()
        Me.ProductTableAdapter = New SalesPersonMain.SalesDBDSTableAdapters.productTableAdapter()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Lot_infoTableAdapter = New SalesPersonMain.SalesDBDSTableAdapters.lot_infoTableAdapter()
        Me.SalesDBDS2 = New SalesPersonMain.SalesDBDS()
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CarIDText = New System.Windows.Forms.TextBox()
        Me.LotNA = New System.Windows.Forms.CheckBox()
        Me.NEWSALESDBDATASET = New SalesPersonMain.NEWSALESDBDATASET()
        Me.MakemodelinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MakemodelinfoTableAdapter = New SalesPersonMain.NEWSALESDBDATASETTableAdapters.makemodelinfoTableAdapter()
        Me.AddNewMakeModelColor = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.ColorDrop = New System.Windows.Forms.ComboBox()
        Me.ColorNA = New System.Windows.Forms.CheckBox()
        Me.MakeModelNA = New System.Windows.Forms.CheckBox()
        Me.BodystyleNA = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ModelText = New System.Windows.Forms.ComboBox()
        Me.MakeText = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ModelNA = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LotInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDBDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.SalesDBDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NEWSALESDBDATASET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakemodelinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(660, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 243
        Me.Label5.Text = "Body Style"
        '
        'BodyStyleDrop
        '
        Me.BodyStyleDrop.FormattingEnabled = True
        Me.BodyStyleDrop.Items.AddRange(New Object() {"Sedan", "Coupe"})
        Me.BodyStyleDrop.Location = New System.Drawing.Point(641, 78)
        Me.BodyStyleDrop.Name = "BodyStyleDrop"
        Me.BodyStyleDrop.Size = New System.Drawing.Size(99, 21)
        Me.BodyStyleDrop.TabIndex = 242
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(555, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 241
        Me.Label3.Text = "Year"
        '
        'YearText
        '
        Me.YearText.Location = New System.Drawing.Point(527, 79)
        Me.YearText.Name = "YearText"
        Me.YearText.Size = New System.Drawing.Size(96, 20)
        Me.YearText.TabIndex = 240
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(516, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 251
        Me.Label7.Text = "VinBox"
        '
        'VinText
        '
        Me.VinText.Location = New System.Drawing.Point(487, 151)
        Me.VinText.Name = "VinText"
        Me.VinText.Size = New System.Drawing.Size(96, 20)
        Me.VinText.TabIndex = 250
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(400, 129)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(31, 13)
        Me.Label.TabIndex = 249
        Me.Label.Text = "Price"
        '
        'PriceText
        '
        Me.PriceText.Location = New System.Drawing.Point(366, 151)
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Size = New System.Drawing.Size(96, 20)
        Me.PriceText.TabIndex = 248
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 247
        Me.Label6.Text = "Milage"
        '
        'MilageText
        '
        Me.MilageText.Location = New System.Drawing.Point(145, 149)
        Me.MilageText.Name = "MilageText"
        Me.MilageText.Size = New System.Drawing.Size(96, 20)
        Me.MilageText.TabIndex = 246
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Color"
        '
        'LotDropDown
        '
        Me.LotDropDown.FormattingEnabled = True
        Me.LotDropDown.Location = New System.Drawing.Point(719, 150)
        Me.LotDropDown.Name = "LotDropDown"
        Me.LotDropDown.Size = New System.Drawing.Size(85, 21)
        Me.LotDropDown.TabIndex = 254
        '
        'LotInfoBindingSource
        '
        Me.LotInfoBindingSource.DataMember = "lot info"
        Me.LotInfoBindingSource.DataSource = Me.SalesDBDS1
        '
        'SalesDBDS1
        '
        Me.SalesDBDS1.DataSetName = "SalesDBDS"
        Me.SalesDBDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarPicText
        '
        Me.CarPicText.Location = New System.Drawing.Point(601, 151)
        Me.CarPicText.Name = "CarPicText"
        Me.CarPicText.Size = New System.Drawing.Size(96, 20)
        Me.CarPicText.TabIndex = 253
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(617, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 252
        Me.Label8.Text = "Car Picture"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1145, 393)
        Me.DataGridView1.TabIndex = 256
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me.SalesDBDS
        '
        'SalesDBDS
        '
        Me.SalesDBDS.DataSetName = "SalesDBDS"
        Me.SalesDBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(883, 127)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(166, 60)
        Me.Submit.TabIndex = 257
        Me.Submit.Text = "Submit Change(s)"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(402, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 25)
        Me.Label10.TabIndex = 258
        Me.Label10.Text = "Edit Car Values"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(438, 596)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(176, 37)
        Me.FillBy1ToolStrip.TabIndex = 259
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(164, 34)
        Me.FillBy1ToolStripButton.Text = "REFRESH TABLE"
        '
        'Lot_infoTableAdapter
        '
        Me.Lot_infoTableAdapter.ClearBeforeFill = True
        '
        'SalesDBDS2
        '
        Me.SalesDBDS2.DataSetName = "SalesDBDS"
        Me.SalesDBDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "product"
        Me.ProductBindingSource1.DataSource = Me.SalesDBDS2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 260
        Me.Label11.Text = "Car ID"
        '
        'CarIDText
        '
        Me.CarIDText.Enabled = False
        Me.CarIDText.Location = New System.Drawing.Point(223, 80)
        Me.CarIDText.Name = "CarIDText"
        Me.CarIDText.Size = New System.Drawing.Size(63, 20)
        Me.CarIDText.TabIndex = 261
        '
        'LotNA
        '
        Me.LotNA.AutoSize = True
        Me.LotNA.Location = New System.Drawing.Point(721, 177)
        Me.LotNA.Name = "LotNA"
        Me.LotNA.Size = New System.Drawing.Size(46, 17)
        Me.LotNA.TabIndex = 262
        Me.LotNA.Text = "N/A"
        Me.LotNA.UseVisualStyleBackColor = True
        '
        'NEWSALESDBDATASET
        '
        Me.NEWSALESDBDATASET.DataSetName = "NEWSALESDBDATASET"
        Me.NEWSALESDBDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MakemodelinfoBindingSource
        '
        Me.MakemodelinfoBindingSource.DataMember = "makemodelinfo"
        Me.MakemodelinfoBindingSource.DataSource = Me.NEWSALESDBDATASET
        '
        'MakemodelinfoTableAdapter
        '
        Me.MakemodelinfoTableAdapter.ClearBeforeFill = True
        '
        'AddNewMakeModelColor
        '
        Me.AddNewMakeModelColor.Location = New System.Drawing.Point(883, 20)
        Me.AddNewMakeModelColor.Name = "AddNewMakeModelColor"
        Me.AddNewMakeModelColor.Size = New System.Drawing.Size(166, 48)
        Me.AddNewMakeModelColor.TabIndex = 269
        Me.AddNewMakeModelColor.Text = "Add New Make/Model or Color"
        Me.AddNewMakeModelColor.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(883, 74)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(166, 47)
        Me.Refresh.TabIndex = 270
        Me.Refresh.Text = "Refresh "
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'ColorDrop
        '
        Me.ColorDrop.FormattingEnabled = True
        Me.ColorDrop.Location = New System.Drawing.Point(260, 149)
        Me.ColorDrop.Name = "ColorDrop"
        Me.ColorDrop.Size = New System.Drawing.Size(81, 21)
        Me.ColorDrop.TabIndex = 271
        '
        'ColorNA
        '
        Me.ColorNA.AutoSize = True
        Me.ColorNA.Location = New System.Drawing.Point(273, 178)
        Me.ColorNA.Name = "ColorNA"
        Me.ColorNA.Size = New System.Drawing.Size(46, 17)
        Me.ColorNA.TabIndex = 274
        Me.ColorNA.Text = "N/A"
        Me.ColorNA.UseVisualStyleBackColor = True
        '
        'MakeModelNA
        '
        Me.MakeModelNA.AutoSize = True
        Me.MakeModelNA.Location = New System.Drawing.Point(322, 105)
        Me.MakeModelNA.Name = "MakeModelNA"
        Me.MakeModelNA.Size = New System.Drawing.Size(46, 17)
        Me.MakeModelNA.TabIndex = 275
        Me.MakeModelNA.Text = "N/A"
        Me.MakeModelNA.UseVisualStyleBackColor = True
        '
        'BodystyleNA
        '
        Me.BodystyleNA.AutoSize = True
        Me.BodystyleNA.Location = New System.Drawing.Point(663, 105)
        Me.BodystyleNA.Name = "BodystyleNA"
        Me.BodystyleNA.Size = New System.Drawing.Size(46, 17)
        Me.BodystyleNA.TabIndex = 276
        Me.BodystyleNA.Text = "N/A"
        Me.BodystyleNA.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(733, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 277
        Me.Label14.Text = "Lot Name"
        '
        'ModelText
        '
        Me.ModelText.FormattingEnabled = True
        Me.ModelText.Location = New System.Drawing.Point(420, 79)
        Me.ModelText.Name = "ModelText"
        Me.ModelText.Size = New System.Drawing.Size(89, 21)
        Me.ModelText.TabIndex = 282
        '
        'MakeText
        '
        Me.MakeText.FormattingEnabled = True
        Me.MakeText.Location = New System.Drawing.Point(312, 79)
        Me.MakeText.Name = "MakeText"
        Me.MakeText.Size = New System.Drawing.Size(81, 21)
        Me.MakeText.TabIndex = 281
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(334, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 280
        Me.Label15.Text = "Make"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(447, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 279
        Me.Label16.Text = "Model"
        '
        'ModelNA
        '
        Me.ModelNA.AutoSize = True
        Me.ModelNA.Location = New System.Drawing.Point(438, 105)
        Me.ModelNA.Name = "ModelNA"
        Me.ModelNA.Size = New System.Drawing.Size(46, 17)
        Me.ModelNA.TabIndex = 283
        Me.ModelNA.Text = "N/A"
        Me.ModelNA.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1068, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 284
        Me.Button1.Text = "Delete Car"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewEditCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 641)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ModelNA)
        Me.Controls.Add(Me.ModelText)
        Me.Controls.Add(Me.MakeText)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BodystyleNA)
        Me.Controls.Add(Me.MakeModelNA)
        Me.Controls.Add(Me.ColorNA)
        Me.Controls.Add(Me.ColorDrop)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.AddNewMakeModelColor)
        Me.Controls.Add(Me.LotNA)
        Me.Controls.Add(Me.CarIDText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LotDropDown)
        Me.Controls.Add(Me.CarPicText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.VinText)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.PriceText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MilageText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BodyStyleDrop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.YearText)
        Me.Name = "NewEditCar"
        Me.Text = "NewEditCar"
        CType(Me.LotInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDBDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.SalesDBDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NEWSALESDBDATASET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakemodelinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents BodyStyleDrop As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents YearText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents VinText As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents PriceText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MilageText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LotDropDown As ComboBox
    Friend WithEvents CarPicText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SalesDBDS As SalesDBDS
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SalesDBDSTableAdapters.productTableAdapter
    Friend WithEvents Submit As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents SalesDBDS1 As SalesDBDS
    Friend WithEvents LotInfoBindingSource As BindingSource
    Friend WithEvents Lot_infoTableAdapter As SalesDBDSTableAdapters.lot_infoTableAdapter
    Friend WithEvents SalesDBDS2 As SalesDBDS
    Friend WithEvents ProductBindingSource1 As BindingSource
    Friend WithEvents Label11 As Label
    Friend WithEvents CarIDText As TextBox
    Friend WithEvents LotNA As CheckBox
    Friend WithEvents NEWSALESDBDATASET As NEWSALESDBDATASET
    Friend WithEvents MakemodelinfoBindingSource As BindingSource
    Friend WithEvents MakemodelinfoTableAdapter As NEWSALESDBDATASETTableAdapters.makemodelinfoTableAdapter
    Friend WithEvents AddNewMakeModelColor As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents ColorDrop As ComboBox
    Friend WithEvents ColorNA As CheckBox
    Friend WithEvents MakeModelNA As CheckBox
    Friend WithEvents BodystyleNA As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ModelText As ComboBox
    Friend WithEvents MakeText As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ModelNA As CheckBox
    Friend WithEvents Button1 As Button
End Class
