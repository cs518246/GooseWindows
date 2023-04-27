<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGooseMain
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
        Label1 = New Label()
        lstGeese = New ListBox()
        btnCreate = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 0
        Label1.Text = "List of Geese"
        ' 
        ' lstGeese
        ' 
        lstGeese.FormattingEnabled = True
        lstGeese.ItemHeight = 15
        lstGeese.Location = New Point(12, 96)
        lstGeese.Name = "lstGeese"
        lstGeese.Size = New Size(776, 139)
        lstGeese.TabIndex = 1
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(12, 241)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(75, 23)
        btnCreate.TabIndex = 2
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(93, 241)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = False
        btnDelete.Location = New Point(174, 241)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' frmGooseMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnCreate)
        Controls.Add(lstGeese)
        Controls.Add(Label1)
        Name = "frmGooseMain"
        Text = "Goose Application"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstGeese As ListBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
