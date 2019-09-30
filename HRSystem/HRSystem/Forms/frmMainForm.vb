Imports System.Reflection

Public Class frmMainForm

    Private Sub btnManageEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageEmployee.Click
        mod_system.OpenWindowsForm("frmEmployeeList")
    End Sub

    Private Sub frmMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " | Version " & Me.GetType.Assembly.GetName.Version.ToString
        NotYetLogin(False)
    End Sub

    Private Sub AddressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressToolStripMenuItem.Click
        mod_system.OpenWindowsForm("frmAddress")
    End Sub

    Private Sub btnWorkManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkManage.Click
        mod_system.OpenWindowsForm("frmManpower")
    End Sub

    Private Sub BranchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchToolStripMenuItem.Click
        mod_system.OpenWindowsForm("frmBranch")
    End Sub

    Private Sub AbouUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbouUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub ManPowerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManPowerToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.Manpower
        frmGenerate.Show()
    End Sub

    Friend Sub NotYetLogin(ByVal st As Boolean)
        btnManageEmployee.Enabled = st
        btnWorkManage.Enabled = st
        MaintenanceToolStripMenuItem.Enabled = st
        ReportsToolStripMenuItem.Enabled = st
        If Not st Then
            LoginToolStripMenuItem.Text = "&Login"
        Else
            LoginToolStripMenuItem.Text = "&Logout"
        End If

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "&Login" Then
            frmLogin.Show()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManagementToolStripMenuItem.Click
        mod_system.OpenWindowsForm("frmUser")
    End Sub

    Private Sub ManPowerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManPowerToolStripMenuItem1.Click
        frmGenerate.FormType = frmGenerate.ReportType.ManpowerMonthly
        frmGenerate.Show()
    End Sub

    Private Sub ManPowerActiveListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManPowerActiveListToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.ActiveList
        frmGenerate.Show()
    End Sub

End Class