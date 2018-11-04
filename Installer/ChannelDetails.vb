Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Public Class ChannelDetails
    Dim ChannelLogo As Bitmap = Nothing
    Dim link As String
    Dim json_script As String
    Dim stream_reader As StreamReader
    Dim web_requester As WebRequest
    Dim web_responsed As WebResponse
    Dim reg_path As String = "HKEY_CURRENT_USER\Software\Varun\YouTube Analytics Widget"
    Dim user_id As String = "UCyq7mspndOnlqR41axhhT8A"
    Dim id_correct As Int16 = 0

    Private Sub Id_set_Click(sender As Object, e As EventArgs) Handles id_set.Click
        user_id = id.Text
        Get_update()
        If id_correct = 1 Then
            nextform.Visible = True
        Else
            nextform.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nextform.Click
        Me.Hide()
        settings.Show()

    End Sub

    Public Sub Get_update()
        Try
            Get_snip()
            Get_stat()
            id_correct = 1
        Catch ex As Exception
            id.Text = Nothing
            id_correct = 0
            MsgBox("Oops! Incorrect Channel ID")
        End Try
    End Sub

    Public Sub Get_snip()
        link = "https://www.googleapis.com/youtube/v3/channels?part=snippet&id=" + user_id + "&key=AIzaSyDDom7eBozF_WF0N1XyNTZtDGXBb6Tffs8"
        web_requester = WebRequest.Create(link)
        web_responsed = web_requester.GetResponse
        stream_reader = New StreamReader(web_responsed.GetResponseStream)
        json_script = stream_reader.ReadToEnd
        Dim SnipJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(json_script)
        Dim channel_title = SnipJson("items")(0)("snippet")("title")
        Dim logo_link = SnipJson("items")(0)("snippet")("thumbnails")("default")("url")
        gbox.Text = channel_title
        If File.Exists("logo.jpg") Then
            File.Delete("logo.jpg")
        End If
        My.Computer.Network.DownloadFile(logo_link, "logo.jpg")
        Using img As Image = Image.FromFile("logo.jpg")
            logo.Image = New Bitmap(img)
        End Using
    End Sub

    Public Sub Get_stat()
        link = "https://www.googleapis.com/youtube/v3/channels?part=statistics&id=" + user_id + "&key=AIzaSyDDom7eBozF_WF0N1XyNTZtDGXBb6Tffs8"
        web_requester = WebRequest.Create(link)
        web_responsed = web_requester.GetResponse
        stream_reader = New StreamReader(web_responsed.GetResponseStream)
        json_script = stream_reader.ReadToEnd
        Dim StatJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(json_script)
        Dim subs As ULong = StatJson("items")(0)("statistics")("subscriberCount")
        Dim views As ULong = StatJson("items")(0)("statistics")("viewCount")
        Dim video As ULong = StatJson("items")(0)("statistics")("videoCount")

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
    End Sub

    Private Sub ChannelDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Get_stat()
            Get_snip()
        Catch ex As Exception
            MsgBox("Oops Check Your Internet Connection")
            Process.GetCurrentProcess.Kill()
        End Try
    End Sub

    Private Sub ChannelDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub
End Class