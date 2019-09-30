Public Class EmpUser
#Region "Properties"
    Private _id As Integer
    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _userName As String
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Private _userPass As String
    Public Property UserPass() As String
        Get
            Return _userPass
        End Get
        Set(ByVal value As String)
            _userPass = value
        End Set
    End Property

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _middleName As String
    Public Property MiddleName() As String
        Get
            Return _middleName
        End Get
        Set(ByVal value As String)
            _middleName = value
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Private _status As Integer
    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property

    Private _createdDate As DateTime
    Public Property CreatedDate() As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal value As DateTime)
            _createdDate = value
        End Set
    End Property
#End Region

#Region "Procedures"
    Friend Sub SaveUser()
        Dim mysql As String = "Select * From tblUser Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tblUser")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("UserName") = _userName
            .Item("UserPass") = _userPass
            .Item("FirstName") = _firstName
            .Item("MiddleName") = _middleName
            .Item("LastName") = _lastName
            .Item("Status") = 1
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub LoadUser(ByVal idx As Integer)
        Dim mysql As String = "Select * From tblUser Where ID = '" & idx & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblUser")

        For Each dr In ds.Tables(0).Rows
            LoadByRows(dr)
        Next
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _userName = .Item("UserName")
            _userPass = .Item("UserPass")
            _firstName = .Item("FirstName")
            _middleName = .Item("MiddleName")
            _lastName = .Item("LastName")
            _status = .Item("Status")
            _createdDate = .Item("Createdate")
        End With
    End Sub

    Friend Function LoginUser(ByVal tmpUser As String, ByVal tmpPass As String) As Boolean
        Dim mysql As String = "Select * From tblUser Where Upper(UserName) = Upper('" & tmpUser & "') And UserPass = '" & EncryptString(tmpPass) & "' And Status <> 0"
        Dim ds As DataSet = LoadSQL(mysql, "tblUser")

        If ds.Tables(0).Rows.Count = 0 Then Return False

        LoadUser(ds.Tables(0).Rows(0).Item("ID"))
        Return True
    End Function

    Friend Sub UpdateUser()
        Dim mysql As String = "Select * From tblUser Where ID = '" & _id & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblUser")
        With ds.Tables(0).Rows(0)
            .Item("UserPass") = _userPass
            .Item("Status") = _status
        End With
        SaveEntry(ds, False)
    End Sub
#End Region
End Class
