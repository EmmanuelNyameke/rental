<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuDisplay = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        picApartment = New PictureBox()
        lblSelectCity = New Label()
        lstCities = New ListBox()
        lblMedianCost = New Label()
        btnCompute = New Button()
        lblAverageRental = New Label()
        MenuStrip1.SuspendLayout()
        CType(picApartment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.Brown
        lblHeading.Location = New Point(12, 24)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(622, 32)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Two-Bedroom Median Apartment Rental"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(635, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuDisplay, mnuClear, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "File"
        ' 
        ' mnuDisplay
        ' 
        mnuDisplay.Name = "mnuDisplay"
        mnuDisplay.Size = New Size(180, 22)
        mnuDisplay.Text = "Display City Rentals"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(180, 22)
        mnuClear.Text = "Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(180, 22)
        mnuExit.Text = "Exit"
        ' 
        ' picApartment
        ' 
        picApartment.Image = My.Resources.Resources.rental
        picApartment.Location = New Point(12, 107)
        picApartment.Name = "picApartment"
        picApartment.Size = New Size(336, 187)
        picApartment.SizeMode = PictureBoxSizeMode.StretchImage
        picApartment.TabIndex = 2
        picApartment.TabStop = False
        ' 
        ' lblSelectCity
        ' 
        lblSelectCity.AutoSize = True
        lblSelectCity.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectCity.Location = New Point(442, 94)
        lblSelectCity.Name = "lblSelectCity"
        lblSelectCity.Size = New Size(145, 25)
        lblSelectCity.TabIndex = 3
        lblSelectCity.Text = "Select City:"
        ' 
        ' lstCities
        ' 
        lstCities.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstCities.FormattingEnabled = True
        lstCities.ItemHeight = 23
        lstCities.Location = New Point(442, 122)
        lstCities.Name = "lstCities"
        lstCities.Size = New Size(193, 188)
        lstCities.TabIndex = 4
        ' 
        ' lblMedianCost
        ' 
        lblMedianCost.AutoSize = True
        lblMedianCost.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        lblMedianCost.Location = New Point(40, 323)
        lblMedianCost.Name = "lblMedianCost"
        lblMedianCost.Size = New Size(130, 23)
        lblMedianCost.TabIndex = 5
        lblMedianCost.Text = "XXXXXXXX"
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.Brown
        btnCompute.Font = New Font("Verdana", 14.25F)
        btnCompute.ForeColor = Color.White
        btnCompute.Location = New Point(183, 368)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(268, 42)
        btnCompute.TabIndex = 6
        btnCompute.Text = "Compute Average Rental"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' lblAverageRental
        ' 
        lblAverageRental.AutoSize = True
        lblAverageRental.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        lblAverageRental.Location = New Point(162, 432)
        lblAverageRental.Name = "lblAverageRental"
        lblAverageRental.Size = New Size(310, 23)
        lblAverageRental.TabIndex = 7
        lblAverageRental.Text = "XXXXXXXXXXXXXXXXXXXX"
        ' 
        ' frmRental
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(635, 456)
        Controls.Add(lblAverageRental)
        Controls.Add(btnCompute)
        Controls.Add(lblMedianCost)
        Controls.Add(lstCities)
        Controls.Add(lblSelectCity)
        Controls.Add(picApartment)
        Controls.Add(lblHeading)
        Controls.Add(MenuStrip1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Name = "frmRental"
        Text = "Apartment Rental By City"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(picApartment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picApartment As PictureBox
    Friend WithEvents lblSelectCity As Label
    Friend WithEvents lstCities As ListBox
    Friend WithEvents lblMedianCost As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblAverageRental As Label

End Class
