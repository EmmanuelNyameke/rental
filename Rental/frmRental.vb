' Program Name: Apartment Rental by City
' Date: December 21, 2024
' Author: K Bola
' Purpose: This application uses a text file of median rental costs of two-bedroom apartment in 10 major cities to find the average rental cost
Option Strict On
Public Class frmRental
    Public Shared _intSizeOfArray As Integer = 9
    Public Shared _strCities(_intSizeOfArray) As String
    Public Shared _decCosts(_intSizeOfArray) As Decimal
    Private Sub frmRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "C:\Users\HELLO\Source\Repos\Rental\rental.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "File does not exist. Click Ok to close the application"
        ' Verifying if the file exists
        If IO.File.Exists(strFileLocation) Then
            objReader = IO.File.OpenText(strFileLocation)
            ' Read the file line by line until it is completed
            Do While objReader.Peek <> -1
                _strCities(intCount) = objReader.ReadLine()
                _decCosts(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            ' Filling the listbox objects
            lstCities.Items.Clear()
            For intFill = 0 To (_strCities.Length - 1)
                If (_strCities(intFill) IsNot Nothing) Then
                    lstCities.Items.Add(_strCities(intFill))
                End If
            Next
        Else
            MsgBox(strFileError, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
            Close()
        End If
        lblMedianCost.Text = ""
        lblAverageRental.Text = ""
    End Sub

    Private Sub lstCities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCities.SelectedIndexChanged
        Dim intSelectedCity As Integer = lstCities.SelectedIndex
        Dim strMedianCostText As String = "The selected rental's median costs "
        Select Case intSelectedCity
            Case 0
                lblMedianCost.Text = strMedianCostText & _decCosts(0).ToString("C")
            Case 1
                lblMedianCost.Text = strMedianCostText & _decCosts(1).ToString("C")
            Case 2
                lblMedianCost.Text = strMedianCostText & _decCosts(2).ToString("C")
            Case 3
                lblMedianCost.Text = strMedianCostText & _decCosts(3).ToString("C")
            Case 4
                lblMedianCost.Text = strMedianCostText & _decCosts(4).ToString("C")
            Case 5
                lblMedianCost.Text = strMedianCostText & _decCosts(5).ToString("C")
            Case 6
                lblMedianCost.Text = strMedianCostText & _decCosts(6).ToString("C")
            Case 7
                lblMedianCost.Text = strMedianCostText & _decCosts(7).ToString("C")
            Case 8
                lblMedianCost.Text = strMedianCostText & _decCosts(8).ToString("C")
            Case 9
                lblMedianCost.Text = strMedianCostText & _decCosts(9).ToString("C")
        End Select
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim decTotal As Decimal
        Dim decAVG As Decimal
        For Each cost In _decCosts
            decTotal += cost
        Next
        decAVG = (decTotal / 10)
        lblAverageRental.Text = "Average Cost of Rental is " & decAVG.ToString("C")
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim frmSecond As New frmDisplayCities
        Hide()
        frmSecond.ShowDialog()
    End Sub
End Class
