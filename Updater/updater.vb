﻿Imports System.IO
Imports System.Net
Imports System.Security.Principal

Public Class updater
    Dim downloader As New WebClient

    Public Function isAdmin()
        Try
            Dim user As WindowsIdentity = WindowsIdentity.GetCurrent
            Dim principal As WindowsPrincipal = New WindowsPrincipal(user)
            Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If File.Exists("Installer.exe") Then
            File.Delete("Installer.exe")
        End If

        downloader.DownloadFile("http://tiny.cc/ytwidlatest", "Installer.exe")

        Try
            Process.GetProcessesByName("YouTube Analytics Widget")(0).Kill()
        Catch ex As Exception

        End Try

        Process.Start("Installer.exe")
        Process.GetCurrentProcess.Kill()
    End Sub
End Class