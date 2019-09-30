Public Class ManPower
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

    Private _emp As Employee
    Public Property Employee() As Employee
        Get
            Return _emp
        End Get
        Set(ByVal value As Employee)
            _emp = value
        End Set
    End Property

    Private _brnch As Branch
    Public Property Brnch() As Branch
        Get
            Return _brnch
        End Get
        Set(ByVal value As Branch)
            _brnch = value
        End Set
    End Property

    Private _empID As Integer
    Public Property EmpID() As Integer
        Get
            Return _empID
        End Get
        Set(ByVal value As Integer)
            _empID = value
        End Set
    End Property

    Private _branchID As Integer
    Public Property BranchID() As Integer
        Get
            Return _branchID
        End Get
        Set(ByVal value As Integer)
            _branchID = value
        End Set
    End Property

    Private _position As String
    Public Property Position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            _position = value
        End Set
    End Property

    Private _assignDate As Date
    Public Property AssignDate() As Date
        Get
            Return _assignDate
        End Get
        Set(ByVal value As Date)
            _assignDate = value
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

    Private _createdDate As DateTime
    Public Property CreatedDate() As DateTime
        Get
            Return _createdDate
        End Get
        Set(ByVal value As DateTime)
            _createdDate = value
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


#End Region

#Region "Procedures"
    Friend Sub SaveManPower()
        Dim mysql As String = "Select * From tblManning Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tblManning")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("Emp_ID") = _empID
            .Item("Emp_Position") = _position
            .Item("Branch_ID") = _branchID
            .Item("Assign_Date") = _assignDate
            .Item("Remarks") = _remarks
            .Item("Status") = 1
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub LoadManPower(ByVal idx As Integer)
        Dim mysql As String = "Select * From tblManning Where ID = '" & idx & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblManning")

        LoadByRows(ds.Tables(0).Rows(0))
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _empID = .Item("Emp_ID")
            _position = .Item("Emp_Position")
            _branchID = .Item("Branch_ID")
            _assignDate = .Item("Assign_Date")
            _remarks = .Item("Remarks")
            _status = .Item("Status")
        End With
    End Sub
#End Region
End Class
