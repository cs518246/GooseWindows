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
        txtName = New TextBox()
        txtAge = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        rdoGender = New GroupBox()
        cboColor = New ComboBox()
        Label5 = New Label()
        txtId = New TextBox()
        rdoGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 1
        Label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 2
        Label3.Text = "Color"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 3
        Label4.Text = "Gender"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(77, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(166, 23)
        txtName.TabIndex = 4
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(77, 118)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(166, 23)
        txtAge.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.DialogResult = DialogResult.OK
        btnSave.Location = New Point(50, 277)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.Location = New Point(156, 277)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 9
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
        rdoMale.Location = New Point(103, 22)
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
        rdoGender.Location = New Point(77, 176)
        rdoGender.Name = "rdoGender"
        rdoGender.Size = New Size(166, 70)
        rdoGender.TabIndex = 12
        rdoGender.TabStop = False
        ' 
        ' cboColor
        ' 
        cboColor.FormattingEnabled = True
        cboColor.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "White", "Black"})
        cboColor.Location = New Point(77, 147)
        cboColor.Name = "cboColor"
        cboColor.Size = New Size(166, 23)
        cboColor.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 15)
        Label5.TabIndex = 14
        Label5.Text = "ID"
        ' 
        ' txtId
        ' 
        txtId.Enabled = False
        txtId.Location = New Point(77, 60)
        txtId.Name = "txtId"
        txtId.Size = New Size(166, 23)
        txtId.TabIndex = 15
        ' 
        ' frmEditGoose
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(255, 312)
        Controls.Add(txtId)
        Controls.Add(Label5)
        Controls.Add(cboColor)
        Controls.Add(rdoGender)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtAge)
        Controls.Add(txtName)
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
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoGender As GroupBox
    Friend WithEvents cboColor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
End Class
