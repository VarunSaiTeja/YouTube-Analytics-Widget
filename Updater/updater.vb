Imports System.IO
Imports System.Net

Public Class Updater
    Dim downloader As New WebClient
    Dim path As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\Installer.exe"

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_now.Start()
    End Sub

    Private Sub Update_now_Tick(sender As Object, e As EventArgs) Handles update_now.Tick
        update_now.Stop()
        Start_Update()
    End Sub

    Public Sub Start_Update()
        If File.Exists(path) Then
            File.Delete(path)
        End If

        downloader.DownloadFile("https://github.com/VarunSaiTeja/YouTube-Analytics-Widget/raw/master/Widget%20Installer.exe", path)

        Process.Start(path)
        Process.GetCurrentProcess.Kill()
    End Sub
End Class