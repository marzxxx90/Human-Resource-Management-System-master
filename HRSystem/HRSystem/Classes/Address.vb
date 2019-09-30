Public Class Address
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

    Private _province As String
    Public Property Province() As String
        Get
            Return _province
        End Get
        Set(ByVal value As String)
            _province = value
        End Set
    End Property

    Private _cityMun As String
    Public Property CityMun() As String
        Get
            Return _cityMun
        End Get
        Set(ByVal value As String)
            _cityMun = value
        End Set
    End Property

    Private _brgy As String
    Public Property Barangay() As String
        Get
            Return _brgy
        End Get
        Set(ByVal value As String)
            _brgy = value
        End Set
    End Property
#End Region

#Region "Procedures"
    Friend Sub SaveAddress()
        Dim mysql As String = "Select * From tbl_Address Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("Province") = _province
            .Item("CityMun") = _cityMun
            .Item("Barangay") = _brgy
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub UpdateAddress()
        Dim mysql As String = "Select * From tbl_Address Where ID = '" & _id & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        With ds.Tables(0).Rows(0)
            .Item("Province") = _province
            .Item("CityMun") = _cityMun
            .Item("Barangay") = _brgy
        End With
        SaveEntry(ds, False)
    End Sub

    Friend Sub LoadAddress(ByVal idx As Integer)
        Dim mysql As String = "Select * From tbl_Address Where ID = '" & idx & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        LoadByRows(ds.Tables(0).Rows(0))
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _province = .Item("Province")
            _cityMun = .Item("CityMun")
            _brgy = .Item("Barangay")
        End With
    End Sub
#End Region
End Class
