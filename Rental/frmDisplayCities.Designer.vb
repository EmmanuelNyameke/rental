<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayCities
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
        lstDisplayCitites = New ListBox()
        lstDisplayCosts = New ListBox()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' lstDisplayCitites
        ' 
        lstDisplayCitites.Font = New Font("Verdana", 14.25F)
        lstDisplayCitites.FormattingEnabled = True
        lstDisplayCitites.ItemHeight = 23
        lstDisplayCitites.Location = New Point(0, 0)
        lstDisplayCitites.Name = "lstDisplayCitites"
        lstDisplayCitites.Size = New Size(164, 234)
        lstDisplayCitites.TabIndex = 0
        ' 
        ' lstDisplayCosts
        ' 
        lstDisplayCosts.Font = New Font("Verdana", 14.25F)
        lstDisplayCosts.FormattingEnabled = True
        lstDisplayCosts.ItemHeight = 23
        lstDisplayCosts.Location = New Point(192, 0)
        lstDisplayCosts.Name = "lstDisplayCosts"
        lstDisplayCosts.Size = New Size(164, 234)
        lstDisplayCosts.TabIndex = 1
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Brown
        btnReturn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(44, 256)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(290, 69)
        btnReturn.TabIndex = 2
        btnReturn.Text = "Return to Rental Cities"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' frmDisplayCities
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 363)
        Controls.Add(btnReturn)
        Controls.Add(lstDisplayCosts)
        Controls.Add(lstDisplayCitites)
        Name = "frmDisplayCities"
        Text = "City Rentals"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstDisplayCitites As ListBox
    Friend WithEvents lstDisplayCosts As ListBox
    Friend WithEvents btnReturn As Button
End Class
