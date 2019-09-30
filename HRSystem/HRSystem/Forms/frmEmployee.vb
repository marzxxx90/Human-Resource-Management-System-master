Public Class frmEmployee
    Private tmpPresentAdd As Address
    Private tmpPermanentAdd As Address
    Private tmpEmployee As Employee
    Private PresentAddressID As Integer = 0
    Private PermanentAddressID As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtBioID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBioID.KeyPress
        DigitOnly(e)
    End Sub

    Private Sub txtContactNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNum.KeyPress
        DigitOnly(e)
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAddressPro()
    End Sub

    Private Sub LoadAddressPro()
        Dim mysql As String = "Select DISTINCT(Province) From tbl_Address"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPermanentPro.Items.Clear()
        cboPresentPro.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            cboPermanentPro.Items.Add(dr.item("Province"))
            cboPresentPro.Items.Add(dr.item("Province"))
        Next

    End Sub

    Private Sub cboPresentPro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPresentPro.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(CityMun) From tbl_Address Where Province = '" & cboPresentPro.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPresentCityMun.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPresentCityMun.Items.Add(dr.item("CityMun"))
        Next

    End Sub

    Private Sub cboPresentCityMun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPresentCityMun.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(Barangay) From tbl_Address Where CityMun = '" & cboPresentCityMun.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPresentBar.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPresentBar.Items.Add(dr.item("Barangay"))
        Next
    End Sub

    Private Sub cboPermanentPro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPermanentPro.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(CityMun) From tbl_Address Where Province = '" & cboPermanentPro.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPermanentCityMun.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPermanentCityMun.Items.Add(dr.item("CityMun"))
        Next
    End Sub

    Private Sub cboPermanentCityMun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPermanentCityMun.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(Barangay) From tbl_Address Where CityMun = '" & cboPermanentCityMun.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPermanentBar.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPermanentBar.Items.Add(dr.item("Barangay"))
        Next
    End Sub

    Private Sub cboPresentBar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPresentBar.SelectedIndexChanged
        Dim mysql As String = "Select * From tbl_Address Where Province = '" & cboPresentPro.Text & "' And CityMun = '" & cboPresentCityMun.Text & "' And Barangay = '" & cboPresentBar.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        For Each dr In ds.Tables(0).Rows
            PresentAddressID = dr.item("ID")
        Next
    End Sub

    Private Sub cboPermanentBar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPermanentBar.SelectedIndexChanged
        Dim mysql As String = "Select * From tbl_Address Where Province = '" & cboPermanentPro.Text & "' And CityMun = '" & cboPermanentCityMun.Text & "' And Barangay = '" & cboPermanentBar.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        For Each dr In ds.Tables(0).Rows
            PermanentAddressID = dr.item("ID")
        Next
    End Sub

    Private Sub Label12_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.DoubleClick
        cboPermanentPro.Text = cboPresentPro.Text
        cboPermanentCityMun.Text = cboPresentCityMun.Text
        cboPermanentBar.Text = cboPresentBar.Text
        txtPermanentStreet.Text = txtPresentStreet.Text
        PermanentAddressID = PresentAddressID
    End Sub

    Private Sub ClearText()
        txtFirstname.Clear()
        txtMidname.Clear()
        txtLastName.Clear()
        txtSuffix.Clear()
        dtpDateofBirth.Value = Today
        dtpDateOfHired.Value = Today
        txtPermanentStreet.Clear()
        txtPresentStreet.Clear()
        txtBioID.Clear()
        txtContactNum.Clear()
        txtEmailAddress.Clear()
        txtSssNum.Clear()
        txtPhilHealth.Clear()
        txtTinNum.Clear()
        cboGender.SelectedIndex = -1
        cboPresentPro.Text = ""
        cboPresentCityMun.Text = ""
        cboPresentBar.Text = ""
        cboPermanentPro.Text = ""
        cboPermanentCityMun.Text = ""
        cboPermanentBar.Text = ""
        cboStatus.SelectedIndex = -1
    End Sub

    Private Sub txtClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClear.Click
        ClearText()
    End Sub

    Private Function isValidSave()
        If txtFirstname.Text = "" Then MsgBox("Invalid Firstname", MsgBoxStyle.Critical, "Error") : Return False
        If txtLastName.Text = "" Then MsgBox("Invalid Lastname", MsgBoxStyle.Critical, "Error") : Return False
        If txtBioID.Text = "" Then MsgBox("Invalid Biometric ID", MsgBoxStyle.Critical, "Error") : Return False
        If cboGender.Text = "" Then MsgBox("Invalid Gender", MsgBoxStyle.Critical, "Error") : Return False
        If txtEmailAddress.Text <> "" Then
            If Not (txtEmailAddress.Text.Contains("@") And txtEmailAddress.Text.Contains(".")) Then MsgBox("Invalid Email Address", MsgBoxStyle.Critical, "Error") : Return False
        End If
        'If cboPresentPro.Text <> "" Then
        '    If PresentAddressID = 0 Then MsgBox("Invalid Present Address", MsgBoxStyle.Critical, "Error") : Return False
        'End If

        If cboPermanentPro.Text <> "" Then
            If PermanentAddressID = 0 Then MsgBox("Invalid Permanent Address", MsgBoxStyle.Critical, "Error") : Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim tmpStatus As String = String.Empty
        Select Case cboStatus.Text
            Case "Probationary"
                tmpStatus = "RPO"
            Case "Regular"
                tmpStatus = "REG"
            Case "Awol"
                tmpStatus = "AWO"
            Case "Resigned"
                tmpStatus = "RES"
            Case "Terminated"
                tmpStatus = "TER"
            Case "Suspended"
                tmpStatus = "SUS"
            Case "Appointed"
                tmpStatus = "APP"
            Case "End of Probationary"
                tmpStatus = "END"
        End Select

        If btnSave.Text = "&Save" Then
            If Not isValidSave() Then Exit Sub
            tmpEmployee = New Employee
            With tmpEmployee
                .FirstName = txtFirstname.Text.ToUpper
                .MiddleName = txtMidname.Text.ToUpper
                .LastName = txtLastName.Text.ToUpper
                .Suffix = txtSuffix.Text.ToUpper
                .DateofBirth = dtpDateofBirth.Value
                .PresentAddressID = PresentAddressID
                .PresentStreet = txtPresentStreet.Text.ToUpper
                .PermanentAddressID = PermanentAddressID
                .PermanentStreet = txtPermanentStreet.Text.ToUpper
                .Sex = cboGender.Text
                .EmailAddress = txtEmailAddress.Text
                .DateHired = dtpDateOfHired.Value
                .BiometricID = txtBioID.Text
                .ContactNumber = txtContactNum.Text
                .SSSNumber = txtSssNum.Text
                .PhilhealthNumber = txtPhilHealth.Text
                .TINNumber = txtTinNum.Text
                .Remarks = txtRemarks.Text
                .Status = tmpStatus
                .SaveEmployee()
            End With
            ClearText()
            MsgBox("New Record Added", MsgBoxStyle.Information, "Information")
        Else
            With tmpEmployee
                .LastName = txtLastName.Text.ToUpper
                .PresentAddressID = PresentAddressID
                .PresentStreet = txtPresentStreet.Text.ToUpper
                .PermanentAddressID = PermanentAddressID
                .PermanentStreet = txtPermanentStreet.Text.ToUpper
                .EmailAddress = txtEmailAddress.Text
                .ContactNumber = txtContactNum.Text
                .SSSNumber = txtSssNum.Text
                .PhilhealthNumber = txtPhilHealth.Text
                .TINNumber = txtTinNum.Text
                .Remarks = txtRemarks.Text
                .Status = tmpStatus
                .UpdateEmployee()
            End With
            ClearText()
            MsgBox("Record Updated", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub dtpDateofBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateofBirth.ValueChanged
        ComputeBirthday()
    End Sub

    Private Sub ComputeBirthday()
        lblAge.Text = "N/A"
        lblAge.Text = GetCurrentAge(dtpDateofBirth.Value) & " years old"
    End Sub

    Friend Sub LoadEmployeeItem(ByVal emp As Employee)
        txtFirstname.Text = emp.FirstName
        txtMidname.Text = emp.MiddleName
        txtLastName.Text = emp.LastName
        txtSuffix.Text = emp.Suffix
        txtContactNum.Text = emp.ContactNumber
        dtpDateofBirth.Value = emp.DateofBirth
        dtpDateOfHired.Value = emp.DateHired
        cboGender.Text = emp.Sex
        txtEmailAddress.Text = emp.EmailAddress
        txtSssNum.Text = emp.SSSNumber
        txtPhilHealth.Text = emp.PhilhealthNumber
        txtTinNum.Text = emp.TINNumber
        txtBioID.Text = emp.BiometricID

        If Not emp.PresendAddress Is Nothing Then
            cboPresentPro.Text = IIf(emp.PresendAddress.Province = "", "", emp.PresendAddress.Province)
            cboPresentCityMun.Text = IIf(emp.PresendAddress.CityMun = "", "", emp.PresendAddress.CityMun)
            cboPresentBar.Text = IIf(emp.PresendAddress.Barangay = "", "", emp.PresendAddress.Barangay)
        End If
        txtPresentStreet.Text = emp.PresentStreet

        If Not emp.PermanentAddress Is Nothing Then
            cboPermanentPro.Text = IIf(emp.PermanentAddress.Province = "", "", emp.PermanentAddress.Province)
            cboPermanentCityMun.Text = IIf(emp.PermanentAddress.CityMun = "", "", emp.PermanentAddress.CityMun)
            cboPermanentBar.Text = IIf(emp.PermanentAddress.Barangay = "", "", emp.PermanentAddress.Barangay)
        End If
        txtPermanentStreet.Text = emp.PermanentStreet

        lblAge.Text = GetCurrentAge(dtpDateofBirth.Value) & " years old"

        tmpPermanentAdd = emp.PermanentAddress
        tmpPresentAdd = emp.PresendAddress
        Select Case emp.Status
            Case "RPO"
                cboStatus.Text = "Probationary"
            Case "REG"
                cboStatus.Text = "Regular"
            Case "AWO"
                cboStatus.Text = "Awol"
            Case "RES"
                cboStatus.Text = "Resigned"
            Case "TER"
                cboStatus.Text = "Terminated"
            Case "SUS"
                cboStatus.Text = "Suspended"
            Case "APP"
                cboStatus.Text = "Appointed"
            Case "END"
                cboStatus.Text = "End of Probationary"
        End Select

        tmpEmployee = emp

        Disable(False)
        btnSave.Text = "&Update"
    End Sub

    Private Sub Disable(ByVal st As Boolean)
        txtFirstname.Enabled = st
        txtMidname.Enabled = st
        txtSuffix.Enabled = st
        dtpDateofBirth.Enabled = st
        dtpDateOfHired.Enabled = st
        txtBioID.Enabled = st
        cboGender.Enabled = st
    End Sub
End Class