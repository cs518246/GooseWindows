Public Class Goose

    Private m_Id As Decimal
    Private m_Name As String
    Private m_Age As Decimal
    Private m_Color As String
    Private m_Gender As String
    Private m_Phone As String

    'Private m_CreatedByUser As String

    Public Sub New()

    End Sub

    Public Sub New(id As Decimal, name As String, age As Decimal, color As String, gender As String, phone As String)
        Me.Id = id
        Me.Name = name
        Me.Age = age
        Me.Color = color
        Me.Gender = gender
        Me.Phone = phone
    End Sub

    Public Property Id As Decimal
        Get
            Return m_Id
        End Get
        Set(value As Decimal)
            m_Id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property Age As Decimal
        Get
            Return m_Age
        End Get
        Set(value As Decimal)
            m_Age = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return m_Color
        End Get
        Set(value As String)
            m_Color = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return m_Gender
        End Get
        Set(value As String)
            m_Gender = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return m_Phone
        End Get
        Set(value As String)
            m_Phone = value
        End Set
    End Property

    Public Function Display() As String
        Dim text As String = Id & " " & Name & " " & Age & " " & Color & " " & Gender & " " & Phone
        Return text
    End Function
End Class
