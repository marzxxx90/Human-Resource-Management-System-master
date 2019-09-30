<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgClient = New System.Windows.Forms.ImageList(Me.components)
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Name"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(1123, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(18, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(996, 31)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1020, 63)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 35)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lvEmployee
        '
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.LargeImageList = Me.imgClient
        Me.lvEmployee.Location = New System.Drawing.Point(18, 104)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(1113, 513)
        Me.lvEmployee.SmallImageList = Me.imgClient
        Me.lvEmployee.TabIndex = 5
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fullname"
        Me.ColumnHeader2.Width = 347
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Contact Number"
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Email Address"
        Me.ColumnHeader4.Width = 239
        '
        'imgClient
        '
        Me.imgClient.ImageStream = CType(resources.GetObject("imgClient.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgClient.TransparentColor = System.Drawing.Color.Transparent
        Me.imgClient.Images.SetKeyName(0, "imgMale")
        Me.imgClient.Images.SetKeyName(1, "imgFemale")
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(1060, 634)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(99, 52)
        Me.btnView.TabIndex = 48
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(18, 634)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 52)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(955, 634)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(99, 52)
        Me.btnSelect.TabIndex = 50
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        Me.btnSelect.Visible = False
        '
        'frmEmployeeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 698)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeeList"
        Me.Text = "frmEmployeeList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lvEmployee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents imgClient As System.Windows.Forms.ImageList
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
End Class
