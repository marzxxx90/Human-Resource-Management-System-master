<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManpower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManpower))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnSearchBranch = New System.Windows.Forms.Button()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpAssignDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(1123, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 35)
        Me.btnClose.TabIndex = 4
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Man Power Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSex)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtContactNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSearchName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 228)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'txtSex
        '
        Me.txtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(80, 186)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.ReadOnly = True
        Me.txtSex.Size = New System.Drawing.Size(117, 26)
        Me.txtSex.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Sex"
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(298, 186)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(349, 26)
        Me.txtContactNo.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contact No"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(80, 65)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(569, 109)
        Me.txtAddress.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Address"
        '
        'btnSearchName
        '
        Me.btnSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchName.Location = New System.Drawing.Point(599, 23)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(50, 26)
        Me.btnSearchName.TabIndex = 9
        Me.btnSearchName.Text = ". . ."
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(80, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(513, 26)
        Me.txtName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboPosition)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCompany)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtArea)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.btnSearchBranch)
        Me.GroupBox2.Controls.Add(Me.txtBranch)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(688, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 231)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Area of Responsibility"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Position"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(92, 151)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(358, 26)
        Me.txtCompany.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Company"
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(92, 108)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(358, 26)
        Me.txtArea.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Area"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(92, 65)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(358, 26)
        Me.txtCode.TabIndex = 16
        '
        'btnSearchBranch
        '
        Me.btnSearchBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBranch.Location = New System.Drawing.Point(400, 27)
        Me.btnSearchBranch.Name = "btnSearchBranch"
        Me.btnSearchBranch.Size = New System.Drawing.Size(50, 26)
        Me.btnSearchBranch.TabIndex = 14
        Me.btnSearchBranch.Text = ". . ."
        Me.btnSearchBranch.UseVisualStyleBackColor = True
        '
        'txtBranch
        '
        Me.txtBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.Location = New System.Drawing.Point(92, 27)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(302, 26)
        Me.txtBranch.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Branch"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRemarks)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpAssignDate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(18, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1141, 330)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Effectivity "
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(129, 81)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(991, 230)
        Me.txtRemarks.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Remarks"
        '
        'dtpAssignDate
        '
        Me.dtpAssignDate.Location = New System.Drawing.Point(129, 29)
        Me.dtpAssignDate.Name = "dtpAssignDate"
        Me.dtpAssignDate.Size = New System.Drawing.Size(313, 26)
        Me.dtpAssignDate.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Assign Date"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1060, 634)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 52)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(946, 634)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 52)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(92, 193)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(358, 26)
        Me.cboPosition.TabIndex = 22
        '
        'frmManpower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 698)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManpower"
        Me.Text = "frmManpower"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearchBranch As System.Windows.Forms.Button
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtpAssignDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
End Class
