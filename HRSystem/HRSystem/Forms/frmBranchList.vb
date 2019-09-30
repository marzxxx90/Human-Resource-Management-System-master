Public Class frmBranchList
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As formSwitch.FormName

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If lvBranch.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = CInt(lvBranch.FocusedItem.Text)
        Dim tmpBranch As Branch
        tmpBranch = New Branch
        tmpBranch.LoadBranch(idx)

        formSwitch.ReloadFormBranch(frmOrig, tmpBranch)

        Me.Close()
    End Sub

    Private Sub LoadBranch(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String
        If str <> "" Then
            mysql = "Select * From tbl_Branch Where Upper(CompanyName) Like Upper('%" & secured_str & "%') OR Upper(BranchName) Like Upper('%" & secured_str & "%') And Status <> 0"
        Else
            mysql = "Select * From tbl_Branch Rows 20"
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadBranch(txtSearch.Text)
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As formSwitch.FormName)
        fromOtherForm = True
        btnSelect.Visible = True
        txtSearch.Text = src
        frmOrig = frmOrigin
    End Sub

    Private Sub lvBranch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBranch.DoubleClick
        btnSelect.PerformClick()
    End Sub

    Private Sub frmBranchList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBranch()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If isEnter(e) Then btnSearch.PerformClick()
    End Sub
End Class