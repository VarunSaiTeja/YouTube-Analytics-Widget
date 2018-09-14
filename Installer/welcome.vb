Imports System.Security.Principal

Public Class welcome
    Dim p As New Process
    Public Function IsAdmin()
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

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
New_process:
        If Not (IsAdmin()) Then
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
