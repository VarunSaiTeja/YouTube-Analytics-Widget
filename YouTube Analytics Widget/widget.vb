﻿Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports Microsoft.Win32

Public Class widget
    Dim ChannelLogo As Bitmap = Nothing
    Dim link As String
    Dim json_script As String
    Dim stream_reader As StreamReader
    Dim web_requester As WebRequest
    Dim web_responsed As WebResponse
    Dim time_taken As Long = 0
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim logo_path As String = My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Channel Logo.jpg"
    Dim logo_task As String
    ' format "number" to diplay number with commas
    ' format "bmk" to display number in m/k

    Private Sub Widget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(My.Settings.widget_location.X, My.Settings.widget_location.Y)
        Using img As Image = Image.FromFile(logo_path)
            Channel_logo.Image = New Bitmap(img)
        End Using
        channel_name.Text = Registry.GetValue(reg_path, "Channel Name", "Varun Teja")
        statistics_updater.Start()
        check_update.Start()
    End Sub

    Private Sub Widget_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.widget_location = New System.Drawing.Point(Me.Location.X, Me.Location.Y)
        My.Settings.Save()
    End Sub

    Public Sub Update_registry()
        Registry.SetValue(reg_path, "Subscribers", sub_count.Text)
        Registry.SetValue(reg_path, "Views", view_count.Text)
        Registry.SetValue(reg_path, "Videos", videos_count.Text)
    End Sub

    Private Sub ChangeLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeLocationToolStripMenuItem.Click
        If ChangeLocationToolStripMenuItem.Checked = True Then
            FormBorderStyle = FormBorderStyle.FixedToolWindow
        End If
        If ChangeLocationToolStripMenuItem.Checked = False Then
            FormBorderStyle = FormBorderStyle.None
        End If
    End Sub

    Private Sub UpdateNowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateNowToolStripMenuItem.Click
        update_now()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub Update_now()
        Try
            Get_stat()
            Update_registry()
        Catch ex As Exception
            sub_count.Text = Registry.GetValue(reg_path, "Subscribers", "0")
            view_count.Text = Registry.GetValue(reg_path, "Views", "0")
            videos_count.Text = Registry.GetValue(reg_path, "Videos", "0")
            Using img As Image = Image.FromFile(logo_path)
                Channel_logo.Image = New Bitmap(img)
            End Using
        End Try
    End Sub

    Public Sub Get_snip()
        link = "https://www.googleapis.com/youtube/v3/channels?part=snippet&id=" + Registry.GetValue(reg_path, "Channel ID", "UCyq7mspndOnlqR41axhhT8A") + "&key=AIzaSyDDom7eBozF_WF0N1XyNTZtDGXBb6Tffs8"
        web_requester = WebRequest.Create(link)
        web_responsed = web_requester.GetResponse
        stream_reader = New StreamReader(web_responsed.GetResponseStream)
        json_script = stream_reader.ReadToEnd
        Dim SnipJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(json_script)
        Dim channel_title = SnipJson("items")(0)("snippet")("title")
        Dim logo_link = SnipJson("items")(0)("snippet")("thumbnails")("default")("url")
        channel_name.Text = channel_title
        If File.Exists(logo_path) Then
            File.Delete(logo_path)
        End If
        My.Computer.Network.DownloadFile(logo_link, logo_path)
        Using img As Image = Image.FromFile(logo_path)
            Channel_logo.Image = New Bitmap(img)
        End Using
        Registry.SetValue(reg_path, "Channel Name", channel_name.Text)
    End Sub

    Public Sub Get_stat()
        link = "https://www.googleapis.com/youtube/v3/channels?part=statistics&id=" + Registry.GetValue(reg_path, "Channel ID", "UCyq7mspndOnlqR41axhhT8A") + "&key=AIzaSyDDom7eBozF_WF0N1XyNTZtDGXBb6Tffs8"
        web_requester = WebRequest.Create(link)
        web_responsed = web_requester.GetResponse
        stream_reader = New StreamReader(web_responsed.GetResponseStream)
        json_script = stream_reader.ReadToEnd
        Dim StatJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(json_script)
        Dim subs As ULong = StatJson("items")(0)("statistics")("subscriberCount")
        Dim views As ULong = StatJson("items")(0)("statistics")("viewCount")
        Dim video As ULong = StatJson("items")(0)("statistics")("videoCount")

        If (Registry.GetValue(reg_path, "Format", "number") = "number") Then
            sub_count.Text = subs.ToString("N0")
            view_count.Text = views.ToString("N0")
            videos_count.Text = video.ToString("N0")
        End If

        If (Registry.GetValue(reg_path, "Format", "number") = "bmk") Then
            Dim count As String = 0
            If (subs > 1000000000) Then
                count = (subs / 1000000000).ToString("N") + "B"
            ElseIf (subs > 1000000) Then
                count = (subs / 1000000).ToString("N") + "M"
            ElseIf (subs > 1000) Then
                count = (subs / 1000).ToString("N") + "K"
            Else
                count = subs
            End If
            sub_count.Text = count

            If (views > 1000000000) Then
                count = (views / 1000000000).ToString("N") + "B"
            ElseIf (views > 1000000) Then
                count = (views / 1000000).ToString("N") + "M"
            ElseIf (views > 1000) Then
                count = (views / 1000).ToString("N") + "K"
            Else
                count = views
            End If
            view_count.Text = count

            If (video > 1000000000) Then
                count = (video / 1000000000).ToString("N") + "B"
            ElseIf (video > 1000000) Then
                count = (video / 1000000).ToString("N") + "M"
            ElseIf (video > 1000) Then
                count = (video / 1000).ToString("N") + "K"
            Else
                count = video
            End If
            videos_count.Text = count

        End If
    End Sub

    Private Sub Statistics_updater_Tick(sender As Object, e As EventArgs) Handles statistics_updater.Tick
        If time_taken = 0 Then
            update_now()
        ElseIf time_taken = 1 And Registry.GetValue(reg_path, "Interval", "0 Hour") = "1 Hour" Then
            update_now()
            time_taken = 0
        ElseIf time_taken = 2 And Registry.GetValue(reg_path, "Interval", "0 Hour") = "3 Hour" Then
            update_now()
            time_taken = 0
        ElseIf time_taken = 3 And Registry.GetValue(reg_path, "Interval", "0 Hour") = "6 Hour" Then
            update_now()
            time_taken = 0
        ElseIf time_taken = 4 And Registry.GetValue(reg_path, "Interval", "0 Hour") = "12 Hour" Then
            update_now()
            time_taken = 0
        ElseIf time_taken = 5 And Registry.GetValue(reg_path, "Interval", "0 Hour") = "1 Day" Then
            update_now()
            time_taken = 0
        End If
        statistics_updater.Interval = 3600000
        time_taken = time_taken + 1
    End Sub

    Public Sub Check_app_update()
        Try
            Dim current As String = Application.ProductVersion
            Dim latest As String
            link = "http://tiny.cc/ytwidver"
            web_requester = WebRequest.Create(link)
            web_responsed = web_requester.GetResponse
            stream_reader = New StreamReader(web_responsed.GetResponseStream)
            latest = stream_reader.ReadToEnd
            If (latest.Contains(current)) Then
                MsgBox("Up To Date")
            Else
                Select Case MsgBox("Update Avilable for Widget" + vbNewLine + "Latest Version : " + latest + vbNewLine + "Current Version : " + current + vbNewLine + "Do you want to update now", vbCritical + vbYesNo)
                    Case vbYes
                        Process.Start("Updater.exe")
                        Process.GetCurrentProcess.Kill()
                    Case vbNo
                        MsgBox("You will notify later regarding this update")
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Check_update_Tick(sender As Object, e As EventArgs) Handles check_update.Tick
        check_update.Stop()
        Check_app_update()
    End Sub

    Private Sub Channel_logo_Click(sender As Object, e As EventArgs) Handles Channel_logo.Click
        If Registry.GetValue(reg_path, "Logo Task", Nothing) = "Nothing" Then

        ElseIf Registry.GetValue(reg_path, "Logo Task", Nothing) = "Update Analytics" Then
            Update_now()
        ElseIf Registry.GetValue(reg_path, "Logo Task", Nothing) = "Open Analytics" Then
            Process.Start("https://www.youtube.com/analytics?o=U")
        ElseIf Registry.GetValue(reg_path, "Logo Task", Nothing) = "Open Creator Studio" Then
            Process.Start("https://www.youtube.com/dashboard?o=U")
        ElseIf Registry.GetValue(reg_path, "Logo Task", Nothing) = "Open Channel" Then
            Process.Start("https://www.youtube.com/channel/" + Registry.GetValue(reg_path, "Channel ID", "UCyq7mspndOnlqR41axhhT8A"))
        End If
    End Sub
End Class
