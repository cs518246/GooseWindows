Public Class frmEditGoose
    Dim valid As New Validation
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim goose1 As New Goose
        Dim gender As String

        If (rdoFemale.Checked) Then
            gender = "F"
        Else
            gender = "M"
        End If

        goose1 = New Goose(txtId.Text, txtName.Text, txtAge.Text, cboColor.Text, gender, txtPhone.Text)
        Me.Tag = goose1
        Me.Close()

    End Sub

    Private Sub frmEditGoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim editGoose As New Goose
        'txtName.ValidatingType = GetType(Decimal)
        'editGoose.Name = frmGooseMain.

    End Sub


    Private Sub InputValid(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtAge.TextChanged, cboColor.SelectedIndexChanged, txtPhone.TextChanged, txtEmail.TextChanged
        'Can this be better?
        Dim flagName As Boolean = False
        Dim flagAge As Boolean = False
        Dim flagColor As Boolean = False
        Dim flagPhone As Boolean = False
        Dim flagEmail As Boolean = False

        If valid.IsPresent(txtName, lblName) AndAlso valid.IsString(txtName, lblName) Then
            flagName = True
        Else
            flagName = False

        End If

        If valid.IsPresent(txtAge, lblAge) AndAlso valid.IsDecimal(txtAge, lblAge) AndAlso valid.IsWithinRange(txtAge, lblAge, 1, 20) Then
            flagAge = True
        Else
            flagAge = False
        End If

        If cboColor.SelectedIndex >= 0 Then
            flagColor = True
            lblColor.Visible = False
        Else
            flagColor = False
            lblColor.Visible = True
        End If

        If txtPhone.MaskCompleted Then
            flagPhone = True
            lblPhone.Visible = False
        Else
            flagPhone = False
            lblPhone.Visible = True
        End If

        If valid.IsPresent(txtEmail, lblEmail) AndAlso valid.IsValidEmail(txtEmail, lblEmail) Then
            flagEmail = True
            lblEmail.Visible = False
        Else
            flagEmail = False
            lblEmail.Visible = True
        End If

        If flagName = False Or flagAge = False Or flagColor = False Or flagPhone = False Or flagEmail = False Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
End Class