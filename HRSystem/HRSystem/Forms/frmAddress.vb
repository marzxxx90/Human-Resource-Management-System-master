Public Class frmAddress
    Private tmpAddress As Address

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub ClearText()
        cboProvince.SelectedIndex = -1
        'cboCityMun.SelectedIndex = -1
        'cboBarangay.SelectedIndex = -1
        cboCityMun.Text = ""
        cboBarangay.Text = ""
        btnSave.Text = "&Save"
        txtSearch.Clear()
    End Sub

    Private Sub frmAddress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAddress()
        LoadProvinceCollection()
    End Sub

    Private Sub LoadAddress(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String


        If str <> "" Then
            mysql = "Select * From tbl_Address Where Upper(Province) like Upper('%" & secured_str & "%') "
            mysql &= "OR Upper(CityMun) Like Upper('%" & secured_str & "%') Or Upper(Barangay) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select * From tbl_Address Rows 30"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        lvAddress.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            LoadAddressItem(dr)
        Next
    End Sub

    Private Sub LoadAddressItem(ByVal dr As DataRow)

        With dr
            Dim lv As ListViewItem = lvAddress.Items.Add(.Item("ID"))
            lv.SubItems.Add(.Item("Province"))
            lv.SubItems.Add(.Item("CityMun"))
            lv.SubItems.Add(.Item("Barangay"))
        End With

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadAddress(txtSearch.Text)
    End Sub

    Private Sub LoadProvinceCollection()
        Dim mysql As String = "Select DISTINCT(Province) From tbl_Address Where Status"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboProvince.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboProvince.Items.Add(dr.item("Province"))
        Next
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(CityMun) From tbl_Address Where Province = '" & cboProvince.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboCityMun.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboCityMun.Items.Add(dr.item("CityMun"))
        Next
    End Sub

    Private Sub cboCityMun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCityMun.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(Barangay) From tbl_Address Where CityMun = '" & cboCityMun.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboBarangay.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboBarangay.Items.Add(dr.item("Barangay"))
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not isValid() Then Exit Sub
        If btnSave.Text = "&Save" Then
            tmpAddress = New Address
            With tmpAddress
                .Province = cboProvince.Text
                .CityMun = cboCityMun.Text
                .Barangay = cboBarangay.Text
                .SaveAddress()
            End With
            ClearText()
            MsgBox("New Address Added", MsgBoxStyle.Information, "Information")
        Else
            With tmpAddress
                .Province = cboProvince.Text
                .CityMun = cboCityMun.Text
                .Barangay = cboBarangay.Text
                .UpdateAddress()
            End With
            ClearText()
            MsgBox("Address Update", MsgBoxStyle.Information, "Information")
        End If
        LoadAddress()
    End Sub

    Private Function isValid()
        If cboProvince.Text = "" Then MsgBox("Invalid Province", MsgBoxStyle.Critical, "Error") : Return False
        If cboCityMun.Text = "" Then MsgBox("City / Municipality Province", MsgBoxStyle.Critical, "Error") : Return False
        If cboBarangay.Text = "" Then MsgBox("Barangay Province", MsgBoxStyle.Critical, "Error") : Return False

        Return True
    End Function

    Private Sub lvAddress_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAddress.DoubleClick
        If lvAddress.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvAddress.FocusedItem.Text
        Dim add As New Address
        add.LoadAddress(idx)
        LoadAddressInfo(add)
        btnSave.Text = "&Update"
    End Sub

    Private Sub LoadAddressInfo(ByVal Add As Address)
        With Add
            cboProvince.Text = .Province
            cboCityMun.Text = .CityMun
            cboBarangay.Text = .Barangay
        End With
        tmpAddress = Add
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If isEnter(e) Then btnSearch.PerformClick()
    End Sub
End Class