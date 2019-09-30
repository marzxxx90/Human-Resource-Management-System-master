Public Class Branch
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

    Private _companyName As String
    Public Property CompanyName() As String
        Get
            Return _companyName
        End Get
        Set(ByVal value As String)
            _companyName = value
        End Set
    End Property

    Private _branchName As String
    Public Property BranchName() As String
        Get
            Return _branchName
        End Get
        Set(ByVal value As String)
            _branchName = value
        End Set
    End Property

    Private _branchCode As String
    Public Property BranchCode() As String
        Get
            Return _branchCode
        End Get
        Set(ByVal value As String)
            _branchCode = value
        End Set
    End Property

    Private _branchArea As String
    Public Property BranchArea() As String
        Get
            Return _branchArea
        End Get
        Set(ByVal value As String)
            _branchArea = value
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
    Friend Sub SaveBranch()
        Dim mysql As String = "Select * From tbl_Branch Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("CompanyName") = _companyName
            .Item("BranchName") = _branchName
            .Item("BranchCode") = _branchCode
            .Item("BranchArea") = _branchArea
            .Item("Remarks") = _remarks
            .Item("Status") = _status
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub UpdateBranch()
        Dim mysql As String = "Select * From tbl_Branch Where ID = '" & _id & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        With ds.Tables(0).Rows(0)
            .Item("BranchCode") = _branchCode
            .Item("BranchArea") = _branchArea
            .Item("Remarks") = _remarks
            .Item("Status") = _status
        End With
        SaveEntry(ds, False)
    End Sub

    Friend Sub LoadBranch(ByVal idx As String)
        Dim mysql As String = "Select * From tbl_Branch Where ID = '" & idx & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        For Each dr In ds.Tables(0).Rows
            LoadByRows(dr)
        Next
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _companyName = .Item("CompanyName")
            _branchName = .Item("BranchName")
            _branchCode = .Item("BranchCode")
            _branchArea = .Item("BranchArea")
            _remarks = .Item("Remarks")
            _status = .Item("Status")
        End With
    End Sub
#End Region
End Class
