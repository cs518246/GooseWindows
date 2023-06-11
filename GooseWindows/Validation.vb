Imports System.Text.RegularExpressions
Public Class Validation

    Public Sub New()

    End Sub
    Public Function IsPresent(textBox As TextBox, label As Label) As Boolean
        If textBox.Text = "" Then
            label.Visible = True
            Return False
        Else
            label.Visible = False
            Return True
        End If

    End Function

    Public Function IsString(textBox As TextBox, label As Label) As Boolean

        If IsNumeric(textBox.Text) Then
            label.Visible = True
            Return False
        Else
            label.Visible = False
            Return True
        End If

    End Function

    Public Function IsDecimal(textBox As TextBox, label As Label) As Boolean
        Dim number As Decimal = 0

        If Decimal.TryParse(textBox.Text, number) Then
            label.Visible = False
            Return True
        Else
            label.Visible = True
            Return False
        End If

    End Function

    Public Function IsWithinRange(textBox As TextBox, label As Label, minRange As Decimal, maxRange As Decimal) As Boolean
        If textBox.Text >= minRange AndAlso textBox.Text <= maxRange Then
            label.Visible = False
            Return True
        Else
            label.Visible = True
            Return False
        End If
    End Function

    Public Function IsValidEmail(textBox As TextBox, label As Label)
        Dim format As String = "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"

        If Regex.IsMatch(textBox.Text, format) Then
            label.Visible = False
            Return True
        Else
            label.Visible = True
            Return False
        End If
    End Function
End Class
