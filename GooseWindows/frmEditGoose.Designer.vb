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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditGoose))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoGender = New System.Windows.Forms.GroupBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.pctGooseImg = New System.Windows.Forms.PictureBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.OFGSelectImage = New System.Windows.Forms.OpenFileDialog()
        Me.rdoGender.SuspendLayout()
        CType(Me.pctGooseImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(73, 281)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(184, 23)
        Me.txtAge.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(46, 494)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(152, 494)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Checked = True
        Me.rdoFemale.Location = New System.Drawing.Point(21, 22)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(63, 19)
        Me.rdoFemale.TabIndex = 10
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(115, 22)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(51, 19)
        Me.rdoMale.TabIndex = 11
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdoGender
        '
        Me.rdoGender.Controls.Add(Me.rdoFemale)
        Me.rdoGender.Controls.Add(Me.rdoMale)
        Me.rdoGender.Location = New System.Drawing.Point(73, 339)
        Me.rdoGender.Name = "rdoGender"
        Me.rdoGender.Size = New System.Drawing.Size(184, 70)
        Me.rdoGender.TabIndex = 12
        Me.rdoGender.TabStop = False
        '
        'cboColor
        '
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "White", "Black"})
        Me.cboColor.Location = New System.Drawing.Point(73, 310)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(184, 23)
        Me.cboColor.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(73, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(184, 23)
        Me.txtId.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(73, 252)
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 23)
        Me.txtName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(103, 431)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(154, 23)
        Me.txtPhone.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.Firebrick
        Me.lblName.Location = New System.Drawing.Point(263, 255)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(13, 20)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "!"
        Me.lblName.Visible = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAge.ForeColor = System.Drawing.Color.Firebrick
        Me.lblAge.Location = New System.Drawing.Point(263, 284)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(13, 20)
        Me.lblAge.TabIndex = 20
        Me.lblAge.Text = "!"
        Me.lblAge.Visible = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblColor.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblColor.ForeColor = System.Drawing.Color.Firebrick
        Me.lblColor.Location = New System.Drawing.Point(263, 313)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(13, 20)
        Me.lblColor.TabIndex = 21
        Me.lblColor.Text = "!"
        Me.lblColor.Visible = False
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPhone.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPhone.Location = New System.Drawing.Point(263, 434)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(13, 20)
        Me.lblPhone.TabIndex = 22
        Me.lblPhone.Text = "!"
        Me.lblPhone.Visible = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(8, 465)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(81, 15)
        Me.label.TabIndex = 23
        Me.label.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(103, 462)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(154, 23)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEmail.ForeColor = System.Drawing.Color.Firebrick
        Me.lblEmail.Location = New System.Drawing.Point(263, 465)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(13, 20)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "!"
        Me.lblEmail.Visible = False
        '
        'pctGooseImg
        '
        Me.pctGooseImg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pctGooseImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctGooseImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctGooseImg.Image = CType(resources.GetObject("pctGooseImg.Image"), System.Drawing.Image)
        Me.pctGooseImg.Location = New System.Drawing.Point(73, 46)
        Me.pctGooseImg.Name = "pctGooseImg"
        Me.pctGooseImg.Size = New System.Drawing.Size(184, 186)
        Me.pctGooseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGooseImg.TabIndex = 25
        Me.pctGooseImg.TabStop = False
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(263, 121)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'OFGSelectImage
        '
        Me.OFGSelectImage.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP"
        '
        'frmEditGoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 529)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.pctGooseImg)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.rdoGender)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditGoose"
        Me.Text = "frmEditGoose"
        Me.rdoGender.ResumeLayout(False)
        Me.rdoGender.PerformLayout()
        CType(Me.pctGooseImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents pctGooseImg As PictureBox
    Friend WithEvents btnView As Button
    Friend WithEvents OFGSelectImage As OpenFileDialog
End Class
