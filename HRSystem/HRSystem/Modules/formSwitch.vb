Module formSwitch
    
    Friend Enum FormName As Integer
        Employee = 0
        Branch = 1

    End Enum

    Friend Sub ReloadFormFromSearch(ByVal gotoForm As FormName, ByVal cus As Employee)
        Select Case gotoForm
            Case FormName.Employee
                'Dim frm As frmManpower
                frmManpower.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmManpower)
                frmMainForm.pNavigate.Tag = frmManpower
                frmManpower.LoadEmployeeInfo(cus)
                frmManpower.Show()
                frmManpower.BringToFront()
               
        End Select
    End Sub

    Friend Sub ReloadFormBranch(ByVal gotoForm As FormName, ByVal brnch As Branch)
        Select Case gotoForm
            Case FormName.Branch
                frmManpower.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmManpower)
                frmMainForm.pNavigate.Tag = frmManpower
                frmManpower.LoadBranchInfo(brnch)
                frmManpower.Show()
                frmManpower.BringToFront()

                'frmManpower.LoadBranchInfo(brnch)
        End Select
    End Sub
End Module