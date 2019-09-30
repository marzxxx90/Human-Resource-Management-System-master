Public Class frmGenerate

    Enum ReportType As Integer
        Manpower = 0
        ManpowerMonthly = 1
        ActiveList = 2
    End Enum
    Friend FormType As ReportType = ReportType.Manpower

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If cboCompany.SelectedIndex = -1 Then Exit Sub
        Select Case FormType
            Case ReportType.Manpower
                ManPowerReport()
            Case ReportType.ManpowerMonthly
                ManPowerReportMonthly()
            Case ReportType.ActiveList
                ManPowerActiveList()
        End Select

    End Sub

    Private Sub ManPowerReport()
        Dim dsName As String, rptPath As String
        dsName = "dsManpower"
        rptPath = "Reports\rptManpower.rdlc"

        Dim mysql As String = "Select M.ID, E.FirstName ||' ' || E.Lastname as EmpName, M.Emp_Position as EmpPosition, "
        mysql &= "B.CompanyName, B.BranchName, M.Assign_Date, M.Remarks, "
        mysql &= "Case E.Status "
        mysql &= "When 'PRO' Then 'Probationary' "
        mysql &= "When 'REG' Then 'Regular' "
        mysql &= "When 'AWO' Then 'Awol' "
        mysql &= "When 'RES' Then 'Resigned' "
        mysql &= "When 'TER' Then 'Terminated' "
        mysql &= "When 'SUS' Then 'Suspended' "
        mysql &= "When 'APP' Then 'Appointed' "
        mysql &= "When 'END' Then 'End of Probationary' End as Status,"
        mysql &= "E.DateHired, B.Brancharea, B.BranchCode "
        mysql &= "From tblManning M "
        mysql &= "Inner Join tbl_Employee E ON E.ID = M.EMP_ID "
        mysql &= "Inner Join tbl_Branch B On B.ID = M.Branch_ID "
        mysql &= "Where M.Assign_Date = '" & monCal.SelectionStart.ToShortDateString & "' And B.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub ManPowerReportMonthly()
        Dim dsName As String, rptPath As String
        dsName = "dsManpower"
        rptPath = "Reports\rptManpower.rdlc"
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)

        Dim mysql As String = "Select M.ID, E.FirstName ||' ' || E.Lastname as EmpName, M.Emp_Position as EmpPosition, "
        mysql &= "B.CompanyName, B.BranchName, M.Assign_Date, M.Remarks, "
        mysql &= "Case E.Status "
        mysql &= "When 'PRO' Then 'Probationary' "
        mysql &= "When 'REG' Then 'Regular' "
        mysql &= "When 'AWO' Then 'Awol' "
        mysql &= "When 'RES' Then 'Resigned' "
        mysql &= "When 'TER' Then 'Terminated' "
        mysql &= "When 'SUS' Then 'Suspended' "
        mysql &= "When 'APP' Then 'Appointed' "
        mysql &= "When 'END' Then 'End of Probationary' End as Status,"
        mysql &= "E.DateHired, B.Brancharea, B.BranchCode "
        mysql &= "From tblManning M "
        mysql &= "Inner Join tbl_Employee E ON E.ID = M.EMP_ID "
        mysql &= "Inner Join tbl_Branch B On B.ID = M.Branch_ID "
        mysql &= "Where M.Assign_Date Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "' And B.CompanyName = '" & cboCompany.Text & "' "
        mysql &= "And (M.Status <> 'PRO' OR M.Status <> 'REG' OR M.Status <> 'APP' OR M.Status <> 'SUS')"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub ManPowerActiveList()
        Dim dsName As String, rptPath As String
        dsName = "dsManpower"
        rptPath = "Reports\rptManpower.rdlc"
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)

        Dim mysql As String = "Select M.ID, E.FirstName ||' ' || E.Lastname as EmpName, M.Emp_Position as EmpPosition, "
        mysql &= "B.CompanyName, B.BranchName, M.Assign_Date, M.Remarks, "
        mysql &= "Case E.Status "
        mysql &= "When 'PRO' Then 'Probationary' "
        mysql &= "When 'REG' Then 'Regular' "
        mysql &= "When 'AWO' Then 'Awol' "
        mysql &= "When 'RES' Then 'Resigned' "
        mysql &= "When 'TER' Then 'Terminated' "
        mysql &= "When 'SUS' Then 'Suspended' "
        mysql &= "When 'APP' Then 'Appointed' "
        mysql &= "When 'END' Then 'End of Probationary' End as Status,"
        mysql &= "E.DateHired, B.Brancharea, B.BranchCode "
        mysql &= "From tblManning M "
        mysql &= "Inner Join tbl_Employee E ON E.ID = M.EMP_ID "
        mysql &= "Inner Join tbl_Branch B On B.ID = M.Branch_ID "
        mysql &= "Where M.Assign_Date Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "' And B.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub frmGenerate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCompany()
        If NoFilter() Then
            monCal.Enabled = False
        Else
            monCal.Enabled = True
        End If

    End Sub

    Private Function NoFilter() As Boolean
        Select Case FormType
            Case ReportType.ActiveList
                Return True
        End Select

        Return False
    End Function

    Private Sub LoadCompany()
        Dim mysql As String = "Select Distinct(CompanyName) From tbl_Branch"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        cboCompany.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboCompany.Items.Add(dr.item("CompanyName"))
        Next
    End Sub
End Class