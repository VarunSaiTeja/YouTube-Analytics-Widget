Imports Microsoft.Win32
Imports System.IO

Public Class installation
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Varun\YouTube Analytics Widget"
    Dim logo_path As String = My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Channel Logo.jpg"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Finish" Then
            Process.Start(install_path + "\YouTube Analytics Widget.exe")
            Process.GetCurrentProcess.Kill()
        End If

        If Button1.Text = "Install" Then
            Button1.Visible = False
            title.Text = "Installing"

            My.Computer.FileSystem.CopyDirectory(Application.StartupPath, install_path, True)
            My.Computer.FileSystem.CopyFile(Application.StartupPath + "\logo.jpg", logo_path)

            Registry.SetValue(reg_path, "Channel ID", ChannelDetails.id.Text)
            Registry.SetValue(reg_path, "Channel Name", ChannelDetails.gbox.Text)
            Registry.SetValue(reg_path, "Subscribers", ChannelDetails.sub_count.Text)
            Registry.SetValue(reg_path, "Views", ChannelDetails.view_count.Text)
            Registry.SetValue(reg_path, "Videos", ChannelDetails.videos_count.Text)

            If settings.formatting.Text = "Numbers with comma" Then
                Registry.SetValue(reg_path, "Format", "number")
            ElseIf settings.formatting.Text = "Shortcuts B/M/K" Then
                Registry.SetValue(reg_path, "Format", "bmk")
            End If

            If settings.Duration.Text = "1 Hour" Then
                Registry.SetValue(reg_path, "Interval", "1 Hour")
            ElseIf settings.Duration.Text = "3 Hours" Then
                Registry.SetValue(reg_path, "Interval", "3 Hour")
            ElseIf settings.Duration.Text = "6 Hours" Then
                Registry.SetValue(reg_path, "Interval", "6 Hour")
            ElseIf settings.Duration.Text = "12 Hours" Then
                Registry.SetValue(reg_path, "Interval", "12 Hour")
            ElseIf settings.Duration.Text = "1 Day" Then
                Registry.SetValue(reg_path, "Interval", "1 Day")
            End If

            If settings.startup.Checked = True Then
                reg_path = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
                Registry.SetValue(reg_path, "YouTube Analytics Widget", install_path + "\YouTube Analytics Widget.exe")
            End If

            reg_path = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\YouTube Analytics Widget"
            Registry.SetValue(reg_path, "Publisher", "Varun")
            Registry.SetValue(reg_path, "DisplayName", "YouTube Analytics Widget")
            Registry.SetValue(reg_path, "DisplayVersion", "1.0")
            Registry.SetValue(reg_path, "DisplayIcon", install_path + "\icon.ico")
            Registry.SetValue(reg_path, "UninstallString", install_path + "Uninstaller.exe")
            Registry.SetValue(reg_path, "URLInfoAbout", "https://YouTube.com/VarunTeja")

            title.Text = "Installation Done"
            Button1.Visible = True
            Button1.Text = "Finish"
        End If

    End Sub
End Class