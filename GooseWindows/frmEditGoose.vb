Public Class frmEditGoose

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim goose1 As New Goose
        Dim gender As String

        If (rdoFemale.Checked) Then
            gender = "F"
        Else
            gender = "M"
        End If

        goose1 = New Goose(txtId.Text, txtName.Text, txtAge.Text, cboColor.Text, gender)
        Me.Tag = goose1
        Me.Close()
    End Sub

    Private Sub frmEditGoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim editGoose As New Goose
        'editGoose.Name = frmGooseMain.

    End Sub
End Class