Imports Microsoft.Win32

Public Class settings
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Varun\YouTube Analytics Widget"

    Private Sub Update_id_Click(sender As Object, e As EventArgs) Handles update_id.Click
        Registry.SetValue(reg_path, "Channel ID", id_textbox.Text)
        Try
            widget.Get_snip()
            widget.Get_stat()
        Catch ex As Exception
            MsgBox("Check Your Internet Connection")
        End Try
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_textbox.Text = Registry.GetValue(reg_path, "Channel ID", "UCyq7mspndOnlqR41axhhT8A")
        Duration.Text = Registry.GetValue(reg_path, "Interval", "1 Hour")
        If Registry.GetValue(reg_path, "Format", "number") = "number" Then
            formatting.Text = "Numbers With Comma"
        ElseIf Registry.GetValue(reg_path, "Format", "bmk") = "bmk" Then
            formatting.Text = "Shortcuts B/M/K"
        End If
        logo_task.Text = Registry.GetValue(reg_path, "Logo Task", "Update Analytics")
    End Sub

    Private Sub Duration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Duration.SelectedIndexChanged
        If Duration.Text = "1 Hour" Then
            Registry.SetValue(reg_path, "Interval", "1 Hour")
        ElseIf Duration.Text = "3 Hours" Then
            Registry.SetValue(reg_path, "Interval", "3 Hour")
        ElseIf Duration.Text = "6 Hours" Then
            Registry.SetValue(reg_path, "Interval", "6 Hour")
        ElseIf Duration.Text = "12 Hours" Then
            Registry.SetValue(reg_path, "Interval", "12 Hour")
        ElseIf Duration.Text = "1 Day" Then
            Registry.SetValue(reg_path, "Interval", "1 Day")
        End If
    End Sub

    Private Sub Formatting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formatting.SelectedIndexChanged
        If formatting.Text = "Numbers with comma" Then
            Registry.SetValue(reg_path, "Format", "number")
        ElseIf formatting.Text = "Shortcuts B/M/K" Then
            Registry.SetValue(reg_path, "Format", "bmk")
        End If
    End Sub

    Private Sub Startup_CheckedChanged(sender As Object, e As EventArgs) Handles startup.CheckedChanged
        If startup.Checked = True Then
            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "YouTube Analytics Widget", install_path + "\YouTube Analytics Widget.exe")
        Else
            Dim regkey As Microsoft.Win32.RegistryKey
            regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regkey.DeleteValue(Application.ProductName, False)
        End If
    End Sub

    Private Sub Logo_task_SelectedIndexChanged(sender As Object, e As EventArgs) Handles logo_task.SelectedIndexChanged
        If logo_task.Text = "Update Analytics" Then
            Registry.SetValue(reg_path, "Logo Task", "Update Analytics")
        ElseIf logo_task.Text = "Open Analytics" Then
            Registry.SetValue(reg_path, "Logo Task", "Open Analytics")
        ElseIf logo_task.Text = "Open Creator Studio" Then
            Registry.SetValue(reg_path, "Logo Task", "Open Creator Studio")
        ElseIf logo_task.Text = "Open Channel" Then
            Registry.SetValue(reg_path, "Logo Task", "Open Channel")
        ElseIf logo_task.Text = "Nothing" Then
            Registry.SetValue(reg_path, "Logo Task", "Nothing")
        End If
    End Sub
End Class