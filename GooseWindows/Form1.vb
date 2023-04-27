Imports System.IO
Imports System.Windows.Forms.ComboBox
Imports System.Xml

Public Class frmGooseMain

    Dim gooseList As New List(Of Goose)
    Dim isFirst As New Boolean

    Private Const Path As String = "..\..\Geese.xml"
    Private Sub frmGooseMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFirst = True
        ReadXml()
        'Dim gooseOne, gooseTwo, gooseThree As Goose
        'gooseOne = New Goose("Alfred", "12", "White", "M")
        'gooseTwo = New Goose("Bruce", "7", "Blue", "M")
        'gooseThree = New Goose("Damian", "5", "Red", "M")

        'gooseList.Add(gooseOne)
        'gooseList.Add(gooseTwo)
        'gooseList.Add(gooseThree)
        Refresh()
        'lstGeese.Items.Add(gooseOne.Display)
        'lstGeese.Items.Add(gooseTwo.Display)
        'lstGeese.Items.Add(gooseThree.Display)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim createForm As New frmEditGoose
        Dim newIndex As Decimal
        Dim indexes As New List(Of Decimal)
        newIndex = 0

        For Each g As Goose In gooseList
            indexes.Add(g.Id)
        Next
        If indexes.Count > 0 Then
            Do
                newIndex += 1
            Loop While indexes.Contains(newIndex)
        End If
        createForm.txtId.Text = newIndex
        createForm.ShowDialog()
        If createForm.DialogResult = DialogResult.Cancel Then
        Else
            gooseList.Add(createForm.Tag)
        End If
        Refresh()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedIndex = lstGeese.SelectedIndex
        'Me.Tag = gooseList.Item(selectedIndex)
        Dim editGoose = gooseList.Item(selectedIndex)
        gooseList.RemoveAt(selectedIndex)
        Dim colors As ObjectCollection
        Dim selectedColor As Double

        Dim editForm As New frmEditGoose
        colors = editForm.cboColor.Items
        selectedColor = colors.IndexOf(editGoose.Color)
        editForm.txtId.Text = editGoose.Id
        editForm.txtName.Text = editGoose.Name
        editForm.txtAge.Text = editGoose.Age
        editForm.cboColor.SelectedIndex = selectedColor
        If editGoose.Gender = "M" Then
            editForm.rdoFemale.Checked = False
            editForm.rdoMale.Checked = True

        End If
        editForm.ShowDialog()

        If editForm.DialogResult = DialogResult.Cancel Then
            gooseList.Add(editGoose)
        Else
            gooseList.Add(editForm.Tag)
        End If

        Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedIndex = lstGeese.SelectedIndex
        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you wish to delete this Goose?",
                "Delete Goose",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)

        If answer = DialogResult.Yes Then
            gooseList.RemoveAt(selectedIndex)
        End If
        Refresh()
    End Sub

    Private Sub ReadXml()
        Dim readSettings As New XmlReaderSettings
        readSettings.IgnoreWhitespace = True
        readSettings.IgnoreComments = True

        Dim xmlIn As XmlReader = XmlReader.Create(Path, readSettings)

        If xmlIn.ReadToDescendant("Goose") Then
            Do

                Dim goose As New Goose
                xmlIn.ReadStartElement("Goose")
                goose.Id = xmlIn.ReadElementContentAsDecimal
                goose.Name = xmlIn.ReadElementContentAsString
                goose.Age = xmlIn.ReadElementContentAsDecimal
                goose.Color = xmlIn.ReadElementContentAsString
                goose.Gender = xmlIn.ReadElementContentAsString
                'gooseList.Add(goose)
                lstGeese.Items.Add(goose.Display)
                If isFirst Then
                    gooseList.Add(goose)
                End If
            Loop While xmlIn.ReadToNextSibling("Goose")
        End If
        isFirst = False
        xmlIn.Close()
    End Sub

    Private Sub WriteXml()
        Dim settings As New XmlWriterSettings
        settings.Indent = True
        settings.IndentChars = ("     ")

        Dim xmlOut As XmlWriter = XmlWriter.Create(Path, settings)
        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("Geese")


        For Each g As Goose In gooseList
            xmlOut.WriteStartElement("Goose")
            xmlOut.WriteElementString("Id", g.Id)
            xmlOut.WriteElementString("Name", g.Name)
            xmlOut.WriteElementString("Age", g.Age)
            xmlOut.WriteElementString("Color", g.Color)
            xmlOut.WriteElementString("Gender", g.Gender)
            xmlOut.WriteEndElement()

            'lstGeese.Items.Add(g.Display)
        Next

        xmlOut.WriteEndElement()
        xmlOut.Close()
    End Sub

    Private Sub Refresh()
        lstGeese.Items.Clear()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        WriteXml()
        ReadXml()
    End Sub

    Private Sub lstGeese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGeese.SelectedIndexChanged
        btnEdit.Enabled = True
        btnDelete.Enabled = True

    End Sub
End Class
