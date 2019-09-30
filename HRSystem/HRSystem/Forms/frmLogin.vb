Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Static wrongLogin As Integer

        Dim user As String = DreadKnight(txtUsername.Text)
        'Dim user As String = txtUser.Text
        Dim pass As String = txtPassword.Text

        Dim loginUser As New EmpUser
        If Not loginUser.LoginUser(user, pass) Then
            wrongLogin += 1
            If wrongLogin >= 3 Then
                MsgBox("You have reached the MAXIMUM logins. This is a recording.", MsgBoxStyle.Critical, "WARNING")
                End
            End If
            MsgBox("Invalid Username and password", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        ' Success!
        ComUser = loginUser
        MsgBox(loginUser.FirstName & " " & loginUser.LastName, MsgBoxStyle.Information, "WELCOME")

        'frmMain.Show()
        'frmMain.NotYetLogin(False)
        'frmMain.CheckStoreStatus()

        frmMainForm.NotYetLogin(True)
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " | Version " & Me.GetType.Assembly.GetName.Version.ToString
    End Sub
End Class
