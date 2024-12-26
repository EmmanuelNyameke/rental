Public Class frmDisplayCities
    Private Sub frmDisplayCities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strCities As String
        Dim decCost As Decimal
        For Each strCities In frmRental._strCities
            If strCities IsNot Nothing Then
                lstDisplayCitites.Items.Add(strCities)
            End If
        Next
        For Each decCost In frmRental._decCosts
            lstDisplayCosts.Items.Add(decCost.ToString("C"))
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim frmFirst As New frmRental
        Close()
        frmFirst.Show()
    End Sub
End Class