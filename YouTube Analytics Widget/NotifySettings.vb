Imports Microsoft.Win32

Public Class NotifySettings
    Dim loading_settings As Boolean
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"

    Private Sub WhatsappToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsappToolStripMenuItem.Click
        Process.Start("https://api.whatsapp.com/send?phone=919010075670")
    End Sub

    Private Sub TelegramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TelegramToolStripMenuItem.Click
        Process.Start("https://t.me/VarunSaiTeja")
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        Process.Start("https://www.youtube.com/VarunTeja")
    End Sub

    Private Sub PaytmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaytmToolStripMenuItem.Click
        Process.Start("http://tiny.cc/varunpaytm")
    End Sub

    Private Sub UPIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPIToolStripMenuItem.Click
        Process.Start("http://tiny.cc/varunupi")
    End Sub

    Private Sub PayPalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayPalToolStripMenuItem.Click
        Process.Start("https://www.paypal.me/varunsaiteja")
    End Sub

    Private Sub NotifySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading_settings = True
        title.Select()
        Icon_click_combobox.Text = Registry.GetValue(reg_path, "Notify Icon Click", "Update Analytics")
        Notification_click_combobox.Text = Registry.GetValue(reg_path, "Notification Click", "Nothing")

        If (Registry.GetValue(reg_path, "Update Notification", "True")) Then
            Update_Notification_Checkbox.Checked = CheckState.Checked
        Else
            Update_Notification_Checkbox.Checked = CheckState.Unchecked
        End If

        If (Registry.GetValue(reg_path, "Subs In Notification", "True")) Then
            Subs_checkbox.Checked = CheckState.Checked
        Else
            Subs_checkbox.Checked = CheckState.Unchecked
        End If

        If (Registry.GetValue(reg_path, "Views In Notification", "True")) Then
            Views_checkbox.Checked = CheckState.Checked
        Else
            Views_checkbox.Checked = CheckState.Unchecked
        End If

        If (Registry.GetValue(reg_path, "Videos In Notification", "True")) Then
            Videos_checkbox.Checked = CheckState.Checked
        Else
            Videos_checkbox.Checked = CheckState.Unchecked
        End If

        loading_settings = False
    End Sub

    Private Sub Update_Notification_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Update_Notification_Checkbox.CheckedChanged
        If Not (loading_settings) Then
            Registry.SetValue(reg_path, "Update Notification", Update_Notification_Checkbox.Checked)
        End If

        If (Update_Notification_Checkbox.Checked) Then
            in_notify.Visible = True
        Else
            in_notify.Visible = False
        End If
    End Sub

    Private Sub Subs_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Subs_checkbox.CheckedChanged
        If Not (loading_settings) Then
            Registry.SetValue(reg_path, "Subs In Notification", Subs_checkbox.Checked)
        End If
    End Sub

    Private Sub Views_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Views_checkbox.CheckedChanged
        If Not (loading_settings) Then
            Registry.SetValue(reg_path, "Views In Notification", Views_checkbox.Checked)
        End If
    End Sub

    Private Sub Videos_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Videos_checkbox.CheckedChanged
        If Not (loading_settings) Then
            Registry.SetValue(reg_path, "Videos In Notification", Videos_checkbox.Checked)
        End If
    End Sub

    Private Sub Notification_click_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Notification_click_combobox.SelectedIndexChanged
        If Not (loading_settings) Then
            Registry.SetValue(reg_path, "Notification Click", Notification_click_combobox.SelectedItem)
        End If
    End Sub

    Private Sub Icon_click_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Icon_click_combobox.SelectedIndexChanged
        If Not (loading_settings) Then
            Registry.SetValue(reg_path, "Notify Icon Click", Icon_click_combobox.SelectedItem)
        End If
    End Sub
End Class