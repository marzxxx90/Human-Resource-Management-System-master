Public Class frmManpower
    Private tmpEmployee As Employee
    Private tmpBranch As Branch
    Private tmpManPower As ManPower

    Private Sub btnSearchName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchName.Click
        Dim secured_str As String = txtName.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.SearchSelect(secured_str, FormName.Employee)
            frm.Show()
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If isEnter(e) Then btnSearchName.PerformClick()

    End Sub

    Friend Sub LoadEmployeeInfo(ByVal emp As Employee)
        txtName.Text = emp.FirstName & " " & emp.LastName
        txtAddress.Text = String.Format("{0} {1} {2}", emp.PresentStreet, emp.PresendAddress.Barangay, emp.PresendAddress.CityMun)
        txtContactNo.Text = emp.ContactNumber
        txtSex.Text = emp.Sex

        tmpEmployee = emp
    End Sub

    Friend Sub LoadBranchInfo(ByVal brnch As Branch)
        txtBranch.Text = brnch.BranchName
        txtCode.Text = brnch.BranchCode
        txtArea.Text = brnch.BranchArea
        txtCompany.Text = brnch.CompanyName

        tmpBranch = brnch
    End Sub

    Private Sub btnSearchBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBranch.Click
        Dim secured_str As String = txtBranch.Text
        secured_str = DreadKnight(secured_str)

        If frmBranchList Is Nothing Then
            Dim frm As New frmBranchList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.SearchSelect(secured_str, FormName.Branch)
            frm.Show()
            frm.BringToFront()
        Else
            frmBranchList.BringToFront()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not isValid() Then Exit Sub
        tmpManPower = New ManPower
        With tmpManPower
            .EmpID = tmpEmployee.ID
            .Position = cboPosition.Text.ToUpper
            .BranchID = tmpBranch.ID
            .AssignDate = dtpAssignDate.Value
            .Remarks = txtRemarks.Text.ToUpper
            .SaveManPower()
        End With
        ClearText()
        MsgBox("New Record Added", MsgBoxStyle.Information, "Information")
        Me.Close()
    End Sub

    Private Function isValid()
        If tmpEmployee Is Nothing Then MsgBox("Invalid Employee", MsgBoxStyle.Critical, "Error") : Return False
        If tmpBranch Is Nothing Then MsgBox("Invalid Branch", MsgBoxStyle.Critical, "Error") : Return False
        If cboPosition.Text = "" Then MsgBox("Invalid Position", MsgBoxStyle.Critical, "Error") : Return False

        Return True
    End Function

    Private Sub ClearText()
        tmpBranch = Nothing
        tmpEmployee = Nothing

        txtName.Clear()
        txtAddress.Clear()
        txtSex.Clear()
        txtCompany.Clear()
        txtBranch.Clear()
        txtCode.Clear()
        txtArea.Clear()
        txtCompany.Clear()
        txtRemarks.Clear()
        txtContactNo.Clear()
        cboPosition.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmManpower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPosition()
    End Sub

    Private Sub LoadPosition()
        Dim mysql As String = "Select Distinct(Emp_Position) From tblManning"
        Dim ds As DataSet = LoadSQL(mysql, "tblManning")

        cboPosition.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPosition.Items.Add(dr.item("Emp_Position"))
        Next
    End Sub
End Class