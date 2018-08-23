Imports System.IO
Imports Microsoft.Win32
Imports System.Security.Principal

Public Class bye
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Varun\YouTube Analytics Widget"

    Public Function isAdmin()
        Try
            Dim user As WindowsIdentity = WindowsIdentity.GetCurrent
            Dim principal As WindowsPrincipal = New WindowsPrincipal(user)
            Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        If button.Text = "Finish" Then
            Process.Start("https://tiny.cc/ytwidun")
            Process.GetCurrentProcess.Kill()
        End If

        If button.Text = "Uninstall" Then
            title.Text = "Uninstalling"
            Try
                Process.GetProcessesByName("YouTube Analytics Widget")(0).Kill()
            Catch ex As Exception

            End Try

            Try
                My.Computer.FileSystem.DeleteFile(install_path + "\YouTube Analytics Widget.exe")
            Catch ex As Exception

            End Try

            Try
                Dim regkey As Microsoft.Win32.RegistryKey
                regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regkey.DeleteValue("YouTube Analytics Widget", False)
                regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Varun", True)
                regkey.DeleteSubKey("YouTube Analytics Widget")
                regkey.Close()
            Catch ex As Exception

            End Try

            title.Text = "Uninstallation Done"
            tip.Text = "By clicking on finish" + Environment.NewLine + "My Google form will open" + Environment.NewLine + "Please give feedback via that form"
            button.Text = "Finish"
        End If
    End Sub

    Private Sub bye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (isAdmin()) Then

        Else
            Try
                Dim p As New Process
                p.StartInfo.FileName = Application.ExecutablePath
                p.StartInfo.Verb = "runas"
                p.Start()
                Process.GetCurrentProcess.Kill()
            Catch ex As Exception
                MsgBox("Need Admin Access")
                Process.GetCurrentProcess.Kill()
            End Try

        End If
    End Sub
End Class
