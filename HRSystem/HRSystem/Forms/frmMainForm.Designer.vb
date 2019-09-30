<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.pNavigate = New System.Windows.Forms.Panel()
        Me.btnWorkManage = New System.Windows.Forms.Button()
        Me.btnManageEmployee = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManPowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbouUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ManPowerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManPowerActiveListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pNavigate
        '
        Me.pNavigate.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pNavigate.Location = New System.Drawing.Point(187, 40)
        Me.pNavigate.Name = "pNavigate"
        Me.pNavigate.Size = New System.Drawing.Size(1171, 698)
        Me.pNavigate.TabIndex = 1
        '
        'btnWorkManage
        '
        Me.btnWorkManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnWorkManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkManage.Image = CType(resources.GetObject("btnWorkManage.Image"), System.Drawing.Image)
        Me.btnWorkManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWorkManage.Location = New System.Drawing.Point(12, 122)
        Me.btnWorkManage.Name = "btnWorkManage"
        Me.btnWorkManage.Size = New System.Drawing.Size(169, 85)
        Me.btnWorkManage.TabIndex = 4
        Me.btnWorkManage.Text = "&Work Load"
        Me.btnWorkManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWorkManage.UseVisualStyleBackColor = False
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnManageEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageEmployee.Image = CType(resources.GetObject("btnManageEmployee.Image"), System.Drawing.Image)
        Me.btnManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageEmployee.Location = New System.Drawing.Point(12, 40)
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.Size = New System.Drawing.Size(169, 76)
        Me.btnManageEmployee.TabIndex = 2
        Me.btnManageEmployee.Text = "&Employee"
        Me.btnManageEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnManageEmployee.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AbouUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddressToolStripMenuItem, Me.BranchToolStripMenuItem, Me.UserManagementToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'AddressToolStripMenuItem
        '
        Me.AddressToolStripMenuItem.Name = "AddressToolStripMenuItem"
        Me.AddressToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddressToolStripMenuItem.Text = "&Address"
        '
        'BranchToolStripMenuItem
        '
        Me.BranchToolStripMenuItem.Name = "BranchToolStripMenuItem"
        Me.BranchToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BranchToolStripMenuItem.Text = "&Branch"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UserManagementToolStripMenuItem.Text = "&User Management"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportToolStripMenuItem, Me.MonthlyReportToolStripMenuItem, Me.ManPowerActiveListToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'DailyReportToolStripMenuItem
        '
        Me.DailyReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManPowerToolStripMenuItem})
        Me.DailyReportToolStripMenuItem.Name = "DailyReportToolStripMenuItem"
        Me.DailyReportToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DailyReportToolStripMenuItem.Text = "Daily Report"
        '
        'ManPowerToolStripMenuItem
        '
        Me.ManPowerToolStripMenuItem.Name = "ManPowerToolStripMenuItem"
        Me.ManPowerToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ManPowerToolStripMenuItem.Text = "Man Power"
        '
        'MonthlyReportToolStripMenuItem
        '
        Me.MonthlyReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManPowerToolStripMenuItem1})
        Me.MonthlyReportToolStripMenuItem.Name = "MonthlyReportToolStripMenuItem"
        Me.MonthlyReportToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MonthlyReportToolStripMenuItem.Text = "Monthly Report"
        '
        'AbouUsToolStripMenuItem
        '
        Me.AbouUsToolStripMenuItem.Name = "AbouUsToolStripMenuItem"
        Me.AbouUsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AbouUsToolStripMenuItem.Text = "About &Us"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 85)
        Me.Button1.TabIndex = 6
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(12, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 85)
        Me.Button2.TabIndex = 7
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(12, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 85)
        Me.Button3.TabIndex = 8
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 486)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(169, 85)
        Me.Button4.TabIndex = 9
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(12, 577)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(169, 85)
        Me.Button5.TabIndex = 10
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ManPowerToolStripMenuItem1
        '
        Me.ManPowerToolStripMenuItem1.Name = "ManPowerToolStripMenuItem1"
        Me.ManPowerToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ManPowerToolStripMenuItem1.Text = "Man Power"
        '
        'ManPowerActiveListToolStripMenuItem
        '
        Me.ManPowerActiveListToolStripMenuItem.Name = "ManPowerActiveListToolStripMenuItem"
        Me.ManPowerActiveListToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ManPowerActiveListToolStripMenuItem.Text = "Man Power Active List"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnWorkManage)
        Me.Controls.Add(Me.pNavigate)
        Me.Controls.Add(Me.btnManageEmployee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1386, 788)
        Me.MinimumSize = New System.Drawing.Size(1364, 736)
        Me.Name = "frmMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Human Resource Management System Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pNavigate As System.Windows.Forms.Panel
    Friend WithEvents btnManageEmployee As System.Windows.Forms.Button
    Friend WithEvents btnWorkManage As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbouUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DailyReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManPowerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManPowerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManPowerActiveListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
