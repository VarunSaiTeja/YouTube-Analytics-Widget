Imports System.IO
Imports Microsoft.Win32
Imports System.Security.Principal

Public Class bye
    Dim p As New Process
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Varun\YouTube Analytics Widget"

    Public Function IsAdmin()
        Try
            Dim user As WindowsIdentity = WindowsIdentity.GetCurrent
            Dim principal As WindowsPrincipal = New WindowsPrincipal(user)
            Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles button.Click
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
                My.Computer.FileSystem.DeleteFile(install_path + "\Updater.exe")
                My.Computer.FileSystem.DeleteFile(install_path + "\Icon.ico")
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Channel Logo.jpg")
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Desktop + "\YT Widget.lnk")
            Catch ex As Exception

            End Try

            Try
                Dim regkey As Microsoft.Win32.RegistryKey
                regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regkey.DeleteValue("YouTube Analytics Widget", False)
                regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Varun", True)
                regkey.DeleteSubKey("YouTube Analytics Widget")
                regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", True)
                regkey.DeleteSubKey("YouTube Analytics Widget")
                regkey.Close()
            Catch ex As Exception

            End Try

            title.Text = "Uninstallation Done"
            tip.Text = "By clicking on finish" + Environment.NewLine + "My Google form will open" + Environment.NewLine + "Please give feedback via that form"
            button.Text = "Finish"
        End If
    End Sub

    Private Sub Bye_Load(sender As Object, e As EventArgs) Handles MyBase.Load

New_process:
        If (IsAdmin()) Then
            If Not (Application.ProductName = "Uninstaller") Then
                Process.Start(install_path + "/Uninstaller.exe")
                Process.GetCurrentProcess.Kill()
            End If
        Else
            Try
                p.StartInfo.FileName = Application.ExecutablePath
                p.StartInfo.Verb = "runas"
                p.Start()
                Process.GetCurrentProcess.Kill()
            Catch ex As Exception
                Dim oops As String
                oops = MsgBox("Need Admin Access", vbCritical + vbRetryCancel)
                If oops = vbRetry Then
                    GoTo New_process
                Else
                    Process.GetCurrentProcess.Kill()
                End If
            End Try
        End If
    End Sub
End Class
