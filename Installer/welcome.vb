Imports System.Security.Principal

Public Class welcome
    Public Function isAdmin()
        Try
            Dim user As WindowsIdentity = WindowsIdentity.GetCurrent
            Dim principal As WindowsPrincipal = New WindowsPrincipal(user)
            Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nextform.Click
        Me.Hide()
        ChannelDetails.Show()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
