Public Class frmBranch
    Private tmpBranch As Branch

    Private Sub frmBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCompany()
        LoadBranch()
    End Sub

    Private Sub LoadCompany()
        Dim mysql As String = "Select DISTINCT(CompanyName) From tbl_Branch"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        cboCompany.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboCompany.Items.Add(dr.item("CompanyName"))
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "&Save" Then
            If Not isValid() Then Exit Sub
            If Not BranchisValid() Then MsgBox("Invalid Branch", MsgBoxStyle.Critical, "Error") : Exit Sub
            tmpBranch = New Branch
            With tmpBranch
                .CompanyName = cboCompany.Text.ToUpper
                .BranchName = txtName.Text.ToUpper
                .BranchCode = txtCode.Text.ToUpper
                .BranchArea = txtArea.Text.ToUpper
                .Remarks = txtRemarks.Text.ToUpper
                .Status = IIf(cbStatus.Checked = True, 1, 0)
                .SaveBranch()
            End With
            ClearText()
            MsgBox("New Branch Added", MsgBoxStyle.Information, "Information")
        Else
            With tmpBranch
                .CompanyName = cboCompany.Text.ToUpper
                .BranchName = txtName.Text.ToUpper
                .BranchCode = txtCode.Text.ToUpper
                .BranchArea = txtArea.Text.ToUpper
                .Remarks = txtRemarks.Text.ToUpper
                .Status = IIf(cbStatus.Checked = True, 1, 0)
                .UpdateBranch()
            End With
            ClearText()
            MsgBox("Branch Updated", MsgBoxStyle.Information, "Information")
        End If
        LoadBranch()
    End Sub

    Private Function isValid()
        If cboCompany.Text = "" Then MsgBox("Invalid Company Name", MsgBoxStyle.Critical, "Error") : Return False
        If txtName.Text = "" Then MsgBox("Invalid Branch Name", MsgBoxStyle.Critical, "Error") : Return False
        If txtCode.Text = "" Then MsgBox("Invalid Branch Code", MsgBoxStyle.Critical, "Error") : Return False
        If txtArea.Text = "" Then MsgBox("Invalid Branch Area", MsgBoxStyle.Critical, "Error") : Return False

        Return True
    End Function

    Private Sub LoadBranch(Optional ByVal str As String = "")
        Dim mysql As String
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        If str <> "" Then
            mysql = "Select * From tbl_Branch Where Upper(BranchName) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select * From tbl_Branch"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        lvBranch.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            AddItem(dr)
        Next

    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvBranch.Items.Add(.Item("ID"))
            lv.SubItems.Add(.Item("CompanyName"))
            lv.SubItems.Add(.Item("BranchName"))
            lv.SubItems.Add(.Item("BranchCode"))
            lv.SubItems.Add(.Item("BranchArea"))
        End With
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub ClearText()
        cboCompany.Text = ""
        txtName.Clear()
        txtArea.Clear()
        txtCode.Clear()
        txtRemarks.Clear()
        cbStatus.Checked = True
    End Sub

    Private Sub LoadBranchInfo(ByVal brnch As Branch)
        With brnch
            cboCompany.Text = .CompanyName
            txtName.Text = .BranchName
            txtCode.Text = .BranchCode
            txtArea.Text = .BranchArea
            txtRemarks.Text = .Remarks
            cbStatus.Checked = IIf(.Status = 1, True, False)
        End With
        DisableFields(False)
        btnSave.Text = "&Update"
        tmpBranch = brnch
    End Sub

    Private Sub DisableFields(ByVal st As Boolean)
        cboCompany.Enabled = st
        txtName.Enabled = st
        txtCode.Enabled = st
    End Sub

    Private Sub lvBranch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBranch.DoubleClick
        If lvBranch.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvBranch.FocusedItem.Text
        Dim tmp As New Branch
        tmp.LoadBranch(idx)
        LoadBranchInfo(tmp)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadBranch(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If isEnter(e) Then btnSearch.PerformClick()
    End Sub

    Private Function BranchisValid()
        Dim mysql As String = "Select * From tbl_Branch Where Upper(BranchName) = Upper('" & txtName.Text & "')"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        If ds.Tables(0).Rows.Count = 0 Then Return True

        Return False
    End Function
End Class