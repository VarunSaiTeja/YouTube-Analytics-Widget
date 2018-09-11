Imports System.ComponentModel

Public Class settings
    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub Nextform_Click(sender As Object, e As EventArgs) Handles nextform.Click
        If formatting.Text = Nothing Then
            MsgBox("Select Required Settings")
        ElseIf Duration.Text = Nothing Then
            MsgBox("Select Required Settings")
        Else
            Me.Hide()
            installation.Show()
        End If
    End Sub
End Class