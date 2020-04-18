<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("New", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCarInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colprice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblErrorBox = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(42, 13)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(46, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.ttpCarInventory.SetToolTip(Me.lblMake, "Enter Make of car.")
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(42, 55)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Mo&del:"
        Me.ttpCarInventory.SetToolTip(Me.lblModel, "Enter model of car.")
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(42, 107)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.ttpCarInventory.SetToolTip(Me.lblYear, "Select year of manufacturing of car.")
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(42, 157)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.ttpCarInventory.SetToolTip(Me.lblPrice, "Enter price of car.")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Audi", "BMW", "Bentley", "Cadillac", "Chevrolet", "Dodge", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Jaguar", "Jeep", "Kia", "Land Rover", "Lincoln", "Maserati", "Mazda", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Polestar", "Porsche", "Rolls-Royce", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMake.Location = New System.Drawing.Point(129, 13)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 24)
        Me.cmbMake.TabIndex = 1
        Me.ttpCarInventory.SetToolTip(Me.cmbMake, "Enter Make of car.")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(129, 55)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 3
        Me.ttpCarInventory.SetToolTip(Me.txtModel, "Enter model of car.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(129, 157)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(130, 22)
        Me.txtPrice.TabIndex = 7
        Me.ttpCarInventory.SetToolTip(Me.txtPrice, "Enter price of car.")
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(45, 198)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(104, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.ttpCarInventory.SetToolTip(Me.chkNew, "Select if the car is new.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCarInventory
        '
        Me.lvwCarInventory.CheckBoxes = True
        Me.lvwCarInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colprice})
        Me.lvwCarInventory.FullRowSelect = True
        ListViewGroup1.Header = "New"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.lvwCarInventory.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvwCarInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarInventory.HideSelection = False
        Me.lvwCarInventory.Location = New System.Drawing.Point(45, 242)
        Me.lvwCarInventory.MultiSelect = False
        Me.lvwCarInventory.Name = "lvwCarInventory"
        Me.lvwCarInventory.Size = New System.Drawing.Size(408, 179)
        Me.lvwCarInventory.TabIndex = 9
        Me.ttpCarInventory.SetToolTip(Me.lvwCarInventory, "Select a car's information.")
        Me.lvwCarInventory.UseCompatibleStateImageBehavior = False
        Me.lvwCarInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colId
        '
        Me.colId.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colprice
        '
        Me.colprice.Text = "Price"
        '
        'lblErrorBox
        '
        Me.lblErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorBox.Location = New System.Drawing.Point(45, 424)
        Me.lblErrorBox.Name = "lblErrorBox"
        Me.lblErrorBox.Size = New System.Drawing.Size(408, 63)
        Me.lblErrorBox.TabIndex = 10
        Me.ttpCarInventory.SetToolTip(Me.lblErrorBox, "Error display box.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(45, 518)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 31)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventory.SetToolTip(Me.btnEnter, "Click to perform calculations.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(201, 517)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventory.SetToolTip(Me.btnReset, "Click to reset the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(362, 519)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.ttpCarInventory.SetToolTip(Me.btnExit, "Click to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbYear.Location = New System.Drawing.Point(129, 107)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 24)
        Me.cmbYear.TabIndex = 14
        Me.ttpCarInventory.SetToolTip(Me.cmbYear, "Select the year of manufacturing.")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(481, 552)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblErrorBox)
        Me.Controls.Add(Me.lvwCarInventory)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ttpCarInventory.SetToolTip(Me, "Car inventory form.")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents ttpCarInventory As ToolTip
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCarInventory As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colprice As ColumnHeader
    Friend WithEvents lblErrorBox As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbYear As ComboBox
End Class
