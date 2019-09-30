Public Class frmEmployeeList
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As formSwitch.FormName

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadEmployee(txtSearch.Text)
    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str <> "" Then
            mysql = "Select * From tbl_Employee Where "
            For Each name In strWords
                mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If
            Next
        Else
            mysql = "Select * From tbl_Employee Rows 25"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Employee")

        lvEmployee.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            AddItem(dr)
        Next
    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID"))
            lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))
            lv.SubItems.Add(.Item("ContactNo"))
            lv.SubItems.Add(.Item("EmailAdd"))
            lv.ImageKey = "imgMale"
            If .Item("Gender") = "Female" Then
                lv.ImageKey = "imgFemale"
            End If
        End With
    End Sub

    Private Sub frmEmployeeList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEmployee()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        mod_system.OpenWindowsForm("frmEmployee")
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If lvEmployee.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvEmployee.FocusedItem.Text

        Dim tmpEmp As Employee
        tmpEmp = New Employee
        tmpEmp.LoadEmployee(idx)
        OpenEmployee("frmEmployee", tmpEmp)
    End Sub

    Private Sub OpenEmployee(ByVal FormName As String, ByVal Emp As Employee)
        Dim instForm As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = FormName).SingleOrDefault()
        If instForm Is Nothing Then
            Dim frm As New frmEmployee
            'frm = DirectCast(CreateObjectInstance(FormName), Form)
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.LoadEmployeeItem(Emp)
            frm.Show()
            frm.BringToFront()
        Else
            'instForm.Select()
            'instForm.WindowState = FormWindowState.Maximized
            instForm.BringToFront()
        End If
    End Sub

    Private Sub lvEmployee_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvEmployee.DoubleClick
        If Not fromOtherForm Then
            btnView.PerformClick()
        Else
            btnSelect.PerformClick()
        End If
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As formSwitch.FormName)
        fromOtherForm = True
        btnSelect.Visible = True
        txtSearch.Text = src
        frmOrig = frmOrigin

        btnAdd.Visible = False
        btnView.Visible = False
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = CInt(lvEmployee.FocusedItem.Text)
        Dim tmpEmp As Employee
        tmpEmp = New Employee
        tmpEmp.LoadEmployee(idx)

        formSwitch.ReloadFormFromSearch(frmOrig, tmpEmp)

        Me.Close()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If isEnter(e) Then btnSearch.PerformClick()
    End Sub
End Class