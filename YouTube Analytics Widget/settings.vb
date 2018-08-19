Imports Microsoft.Win32

Public Class settings
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Varun\YouTube Analytics Widget"

    Private Sub update_id_Click(sender As Object, e As EventArgs) Handles update_id.Click
        Registry.SetValue(reg_path, "Channel ID", id_textbox.Text)
        widget.update_now()
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_textbox.Text = Registry.GetValue(reg_path, "Channel ID", "UCyq7mspndOnlqR41axhhT8A")
        Duration.Text = Registry.GetValue(reg_path, "Interval", "1 Hour")
        If Registry.GetValue(reg_path, "Format", "number") = "number" Then
            formatting.Text = "Numbers With Comma"
        ElseIf Registry.GetValue(reg_path, "Format", "bmk") = "bmk" Then
            formatting.Text = "Shortcuts B/M/K"
        End If
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

    Private Sub formatting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formatting.SelectedIndexChanged
        If formatting.Text = "Numbers with comma" Then
            Registry.SetValue(reg_path, "Format", "number")
        ElseIf formatting.Text = "Shortcuts B/M/K" Then
            Registry.SetValue(reg_path, "Format", "bmk")
        End If
    End Sub

    Private Sub startup_CheckedChanged(sender As Object, e As EventArgs) Handles startup.CheckedChanged
        If startup.Checked = True Then
            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "YouTube Analytics Widget", install_path + "\YouTube Analytics Widget.exe")
        Else
            Dim regkey As Microsoft.Win32.RegistryKey
            regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regkey.DeleteValue(Application.ProductName, False)
        End If
    End Sub

End Class