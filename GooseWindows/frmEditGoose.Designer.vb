<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditGoose
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtAge = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        rdoGender = New GroupBox()
        cboColor = New ComboBox()
        Label5 = New Label()
        txtId = New TextBox()
        txtName = New TextBox()
        Label6 = New Label()
        txtPhone = New MaskedTextBox()
        lblName = New Label()
        lblAge = New Label()
        lblColor = New Label()
        lblPhone = New Label()
        label = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        rdoGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 1
        Label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 2
        Label3.Text = "Color"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 3
        Label4.Text = "Gender"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(77, 64)
        txtAge.MaxLength = 2
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(184, 23)
        txtAge.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.DialogResult = DialogResult.OK
        btnSave.Enabled = False
        btnSave.Location = New Point(50, 277)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.Location = New Point(156, 277)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Checked = True
        rdoFemale.Location = New Point(21, 22)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(63, 19)
        rdoFemale.TabIndex = 10
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(115, 22)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(51, 19)
        rdoMale.TabIndex = 11
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' rdoGender
        ' 
        rdoGender.Controls.Add(rdoFemale)
        rdoGender.Controls.Add(rdoMale)
        rdoGender.Location = New Point(77, 122)
        rdoGender.Name = "rdoGender"
        rdoGender.Size = New Size(184, 70)
        rdoGender.TabIndex = 12
        rdoGender.TabStop = False
        ' 
        ' cboColor
        ' 
        cboColor.FormattingEnabled = True
        cboColor.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "White", "Black"})
        cboColor.Location = New Point(77, 93)
        cboColor.Name = "cboColor"
        cboColor.Size = New Size(184, 23)
        cboColor.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 15)
        Label5.TabIndex = 14
        Label5.Text = "ID"
        ' 
        ' txtId
        ' 
        txtId.Enabled = False
        txtId.Location = New Point(77, 6)
        txtId.Name = "txtId"
        txtId.Size = New Size(184, 23)
        txtId.TabIndex = 15
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(77, 35)
        txtName.MaxLength = 10
        txtName.Name = "txtName"
        txtName.Size = New Size(184, 23)
        txtName.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 217)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 17
        Label6.Text = "Phone Number"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(107, 214)
        txtPhone.Mask = "(999) 000-0000"
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(154, 23)
        txtPhone.TabIndex = 4
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = SystemColors.ControlLightLight
        lblName.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.ForeColor = Color.Firebrick
        lblName.Location = New Point(267, 38)
        lblName.Name = "lblName"
        lblName.Size = New Size(13, 20)
        lblName.TabIndex = 19
        lblName.Text = "!"
        lblName.Visible = False
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.BackColor = SystemColors.ControlLightLight
        lblAge.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lblAge.ForeColor = Color.Firebrick
        lblAge.Location = New Point(267, 67)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(13, 20)
        lblAge.TabIndex = 20
        lblAge.Text = "!"
        lblAge.Visible = False
        ' 
        ' lblColor
        ' 
        lblColor.AutoSize = True
        lblColor.BackColor = SystemColors.ControlLightLight
        lblColor.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lblColor.ForeColor = Color.Firebrick
        lblColor.Location = New Point(267, 96)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(13, 20)
        lblColor.TabIndex = 21
        lblColor.Text = "!"
        lblColor.Visible = False
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.BackColor = SystemColors.ControlLightLight
        lblPhone.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhone.ForeColor = Color.Firebrick
        lblPhone.Location = New Point(267, 217)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(13, 20)
        lblPhone.TabIndex = 22
        lblPhone.Text = "!"
        lblPhone.Visible = False
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(12, 248)
        label.Name = "label"
        label.Size = New Size(81, 15)
        label.TabIndex = 23
        label.Text = "Email Address"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(107, 245)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(154, 23)
        txtEmail.TabIndex = 5
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = SystemColors.ControlLightLight
        lblEmail.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.ForeColor = Color.Firebrick
        lblEmail.Location = New Point(267, 248)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(13, 20)
        lblEmail.TabIndex = 24
        lblEmail.Text = "!"
        lblEmail.Visible = False
        ' 
        ' frmEditGoose
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(314, 312)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(label)
        Controls.Add(lblPhone)
        Controls.Add(lblColor)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Controls.Add(txtPhone)
        Controls.Add(Label6)
        Controls.Add(txtName)
        Controls.Add(txtId)
        Controls.Add(Label5)
        Controls.Add(cboColor)
        Controls.Add(rdoGender)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtAge)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmEditGoose"
        Text = "frmEditGoose"
        rdoGender.ResumeLayout(False)
        rdoGender.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoGender As GroupBox
    Friend WithEvents cboColor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents label As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
End Class
