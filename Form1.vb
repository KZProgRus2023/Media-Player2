Imports WMPLib
Public Class Form1

    'Написал и забыл
    Private wmp As New WindowsMediaPlayer
    Private ofd As New OpenFileDialog With {.Title = "Media File Browser", .Filter = "wmv Files (*.wmv)|*.wmv|mp3 Files (*.mp3)|*.mp3"}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With ofd
            If .ShowDialog() = DialogResult.Cancel Then Exit Sub
            If .FileName IsNot Nothing Then wmp.URL = .FileName
        End With
    End Sub
End Class