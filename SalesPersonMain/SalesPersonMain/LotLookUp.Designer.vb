<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotCityLook
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LotStreetNumAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LotStreetAdd = New System.Windows.Forms.TextBox()
        Me.LotCityAdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LotZipAdd = New System.Windows.Forms.TextBox()
        Me.AddLotButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LotInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDBDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDBDS = New SalesPersonMain.SalesDBDS()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorLabelStreetNum = New System.Windows.Forms.Label()
        Me.ErrorLabelZipCode = New System.Windows.Forms.Label()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.ProductTableAdapter = New SalesPersonMain.SalesDBDSTableAdapters.productTableAdapter()
        Me.LotName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDBDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 32)
        Me.Label8.TabIndex = 221
        Me.Label8.Text = "Lot Tools"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Add A New Lot"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 224
        Me.Label1.Text = "Lot Street Num"
        '
        'LotStreetNumAdd
        '
        Me.LotStreetNumAdd.Location = New System.Drawing.Point(32, 218)
        Me.LotStreetNumAdd.Name = "LotStreetNumAdd"
        Me.LotStreetNumAdd.Size = New System.Drawing.Size(104, 20)
        Me.LotStreetNumAdd.TabIndex = 225
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Lot Street Name"
        '
        'LotStreetAdd
        '
        Me.LotStreetAdd.Location = New System.Drawing.Point(170, 218)
        Me.LotStreetAdd.Name = "LotStreetAdd"
        Me.LotStreetAdd.Size = New System.Drawing.Size(104, 20)
        Me.LotStreetAdd.TabIndex = 227
        '
        'LotCityAdd
        '
        Me.LotCityAdd.Location = New System.Drawing.Point(32, 290)
        Me.LotCityAdd.Name = "LotCityAdd"
        Me.LotCityAdd.Size = New System.Drawing.Size(104, 20)
        Me.LotCityAdd.TabIndex = 228
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Lot City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Lot Zip Code"
        '
        'LotZipAdd
        '
        Me.LotZipAdd.Location = New System.Drawing.Point(170, 290)
        Me.LotZipAdd.Name = "LotZipAdd"
        Me.LotZipAdd.Size = New System.Drawing.Size(104, 20)
        Me.LotZipAdd.TabIndex = 231
        '
        'AddLotButton
        '
        Me.AddLotButton.Location = New System.Drawing.Point(117, 339)
        Me.AddLotButton.Name = "AddLotButton"
        Me.AddLotButton.Size = New System.Drawing.Size(75, 23)
        Me.AddLotButton.TabIndex = 232
        Me.AddLotButton.Text = "Add Lot"
        Me.AddLotButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(834, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(252, 16)
        Me.Label13.TabIndex = 264
        Me.Label13.Text = "Look up individual cars in associated lots"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(400, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1098, 306)
        Me.DataGridView1.TabIndex = 266
        '
        'LotInfoBindingSource
        '
        Me.LotInfoBindingSource.DataMember = "lot info"
        Me.LotInfoBindingSource.DataSource = Me.SalesDBDSBindingSource
        '
        'SalesDBDSBindingSource
        '
        Me.SalesDBDSBindingSource.DataSource = Me.SalesDBDS
        Me.SalesDBDSBindingSource.Position = 0
        '
        'SalesDBDS
        '
        Me.SalesDBDS.DataSetName = "SalesDBDS"
        Me.SalesDBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me.SalesDBDSBindingSource
        '
        'ErrorLabelStreetNum
        '
        Me.ErrorLabelStreetNum.AutoSize = True
        Me.ErrorLabelStreetNum.Location = New System.Drawing.Point(31, 241)
        Me.ErrorLabelStreetNum.Name = "ErrorLabelStreetNum"
        Me.ErrorLabelStreetNum.Size = New System.Drawing.Size(0, 13)
        Me.ErrorLabelStreetNum.TabIndex = 267
        '
        'ErrorLabelZipCode
        '
        Me.ErrorLabelZipCode.AutoSize = True
        Me.ErrorLabelZipCode.Location = New System.Drawing.Point(167, 313)
        Me.ErrorLabelZipCode.Name = "ErrorLabelZipCode"
        Me.ErrorLabelZipCode.Size = New System.Drawing.Size(0, 13)
        Me.ErrorLabelZipCode.TabIndex = 268
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(848, 384)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(188, 40)
        Me.Refresh.TabIndex = 269
        Me.Refresh.Text = "Refresh Table"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'LotName
        '
        Me.LotName.Location = New System.Drawing.Point(106, 159)
        Me.LotName.Name = "LotName"
        Me.LotName.Size = New System.Drawing.Size(104, 20)
        Me.LotName.TabIndex = 271
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 270
        Me.Label5.Text = "Lot Name"
        '
        'LotCityLook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 436)
        Me.Controls.Add(Me.LotName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.ErrorLabelZipCode)
        Me.Controls.Add(Me.ErrorLabelStreetNum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AddLotButton)
        Me.Controls.Add(Me.LotZipAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LotCityAdd)
        Me.Controls.Add(Me.LotStreetAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LotStreetNumAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Name = "LotCityLook"
        Me.Text = "LotLookUp"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDBDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LotStreetNumAdd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LotStreetAdd As TextBox
    Friend WithEvents LotCityAdd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LotZipAdd As TextBox
    Friend WithEvents AddLotButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SalesDBDS As SalesDBDS
    Friend WithEvents LotInfoBindingSource As BindingSource
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SalesDBDSTableAdapters.productTableAdapter
    Friend WithEvents SalesDBDSBindingSource As BindingSource
    Friend WithEvents ErrorLabelStreetNum As Label
    Friend WithEvents ErrorLabelZipCode As Label
    Friend WithEvents Refresh As Button
    Friend WithEvents LotName As TextBox
    Friend WithEvents Label5 As Label
End Class
