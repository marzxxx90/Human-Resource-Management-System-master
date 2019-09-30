Public Class Employee

#Region "Properties"
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Private _suffix As String
    Public Property Suffix() As String
        Get
            Return _suffix
        End Get
        Set(ByVal value As String)
            _suffix = value
        End Set
    End Property

    Private _dob As Date
    Public Property DateofBirth() As Date
        Get
            Return _dob
        End Get
        Set(ByVal value As Date)
            _dob = value
        End Set
    End Property

    Private _sex As String
    Public Property Sex() As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property

    Private _presentAddressID As Integer
    Public Property PresentAddressID() As Integer
        Get
            Return _presentAddressID
        End Get
        Set(ByVal value As Integer)
            _presentAddressID = value
        End Set
    End Property

    Private _permanentAddressID As Integer
    Public Property PermanentAddressID() As Integer
        Get
            Return _permanentAddressID
        End Get
        Set(ByVal value As Integer)
            _permanentAddressID = value
        End Set
    End Property

    Private _presentAddress As Address
    Public Property PresendAddress() As Address
        Get
            Return _presentAddress
        End Get
        Set(ByVal value As Address)
            _presentAddress = value
        End Set
    End Property

    Private _permanentAddress As Address
    Public Property PermanentAddress() As Address
        Get
            Return _permanentAddress
        End Get
        Set(ByVal value As Address)
            _permanentAddress = value
        End Set
    End Property

    Private _presentStreet As String
    Public Property PresentStreet() As String
        Get
            Return _presentStreet
        End Get
        Set(ByVal value As String)
            _presentStreet = value
        End Set
    End Property

    Private _permanentStreet As String
    Public Property PermanentStreet() As String
        Get
            Return _permanentStreet
        End Get
        Set(ByVal value As String)
            _permanentStreet = value
        End Set
    End Property

    Private _emailAdd As String
    Public Property EmailAddress() As String
        Get
            Return _emailAdd
        End Get
        Set(ByVal value As String)
            _emailAdd = value
        End Set
    End Property

    Private _dateHired As Date
    Public Property DateHired() As Date
        Get
            Return _dateHired
        End Get
        Set(ByVal value As Date)
            _dateHired = value
        End Set
    End Property

    Private _bioID As Integer
    Public Property BiometricID() As Integer
        Get
            Return _bioID
        End Get
        Set(ByVal value As Integer)
            _bioID = value
        End Set
    End Property

    Private _contactNum As String
    Public Property ContactNumber() As String
        Get
            Return _contactNum
        End Get
        Set(ByVal value As String)
            _contactNum = value
        End Set
    End Property

    Private _sssNum As String
    Public Property SSSNumber() As String
        Get
            Return _sssNum
        End Get
        Set(ByVal value As String)
            _sssNum = value
        End Set
    End Property

    Private _philHealthNum As String
    Public Property PhilhealthNumber() As String
        Get
            Return _philHealthNum
        End Get
        Set(ByVal value As String)
            _philHealthNum = value
        End Set
    End Property

    Private _tinNum As String
    Public Property TINNumber() As String
        Get
            Return _tinNum
        End Get
        Set(ByVal value As String)
            _tinNum = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Private _remarks As String
    Public Property Remarks() As String
        Get
            Return _remarks
        End Get
        Set(ByVal value As String)
            _remarks = value
        End Set
    End Property
#End Region

#Region "Procedures"
    Friend Sub SaveEmployee()
        Dim mysql As String = "Select * From tbl_Employee Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Employee")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("FirstName") = _firstName
            .Item("MiddleName") = _middleName
            .Item("LastName") = _lastName
            .Item("Suffix") = _suffix
            .Item("DateOfBirth") = _dob
            .Item("Gender") = _sex
            .Item("PERMANENT_ADDID") = _permanentAddressID
            .Item("Permanent_Street") = _permanentStreet
            .Item("PRESENT_ADDID") = _presentAddressID
            .Item("Present_Street") = _presentStreet
            .Item("EmailAdd") = _emailAdd
            .Item("DateHired") = _dateHired
            .Item("BiometricID") = _bioID
            .Item("ContactNo") = _contactNum
            .Item("SSSNo") = _sssNum
            .Item("PHILHEALTHNO") = _philHealthNum
            .Item("TinNo") = _tinNum
            .Item("Status") = _status
            .Item("Remarks") = _remarks
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub UpdateEmployee()
        Dim mysql As String = "Select * From tbl_Employee Where ID = '" & _id & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Employee")

        With ds.Tables(0).Rows(0)
            .Item("LastName") = _lastName
            .Item("PERMANENT_ADDID") = _permanentAddressID
            .Item("Permanent_Street") = _permanentStreet
            .Item("PRESENT_ADDID") = _presentAddressID
            .Item("Present_Street") = _presentStreet
            .Item("EmailAdd") = _emailAdd
            .Item("ContactNo") = _contactNum
            .Item("SSSNo") = _sssNum
            .Item("PHILHEALTHNO") = _philHealthNum
            .Item("TinNo") = _tinNum
            .Item("Status") = _status
            .Item("Remarks") = _remarks
        End With
        SaveEntry(ds, False)
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _firstName = .Item("FirstName")
            _middleName = .Item("Middlename")
            _lastName = .Item("LastName")
            _suffix = IIf(IsDBNull(.Item("Suffix")), "", .Item("Suffix"))
            _dob = .Item("DateofBirth")
            _sex = .Item("GENDER")

            If .Item("Present_ADDID") <> 0 Then
                _presentAddress = New Address
                _presentAddress.LoadAddress(.Item("Present_ADDID"))
            Else
                _presentAddress = Nothing
            End If
           
            If .Item("PERMANENT_ADDID") <> 0 Then
                _permanentAddress = New Address
                _permanentAddress.LoadAddress(.Item("PERMANENT_ADDID"))
            Else
                _permanentAddress = Nothing
            End If
           
            _presentStreet = .Item("PERMANENT_STREET")
            _presentStreet = .Item("Present_STREET")
            _emailAdd = .Item("EmailAdd")
            _dateHired = .Item("DateHired")
            _bioID = .Item("BiometricID")
            _contactNum = .Item("ContactNo")
            _sssNum = .Item("SSSNo")
            _philHealthNum = .Item("PhilhealthNo")
            _tinNum = .Item("TinNo")
            _status = .Item("Status")
            _remarks = .Item("Remarks")
        End With
    End Sub

    Friend Sub LoadEmployee(ByVal idx As Integer)
        Dim mysql As String = "Select * From tbl_Employee Where ID = '" & idx & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Employee")

        LoadByRows(ds.Tables(0).Rows(0))
    End Sub
#End Region
End Class
