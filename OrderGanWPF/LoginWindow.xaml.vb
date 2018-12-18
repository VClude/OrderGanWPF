Imports MahApps.Metro.Controls
Imports MahApps.Metro.Controls.Dialogs
Imports System.Net
Imports System.Text
Imports System.IO

Class LoginWindow
    Inherits MetroWindow

    Private Sub btLogin_Click(sender As Object, e As RoutedEventArgs) Handles btLogin.Click

    End Sub

    Private Async Sub btCancel_Click(sender As Object, e As RoutedEventArgs) Handles btCancel.Click
        Lowi.Width = 357
        Belur.Radius = 5
        Dim result As Integer = Await ShowMessageAsync("Exit", "Are You sure ?", MessageDialogStyle.AffirmativeAndNegative)
        If result = MessageDialogResult.Affirmative Then
            End
        ElseIf result = MessageDialogResult.Negative Then
            Lowi.Width = 272
            Belur.Radius = 0

        End If
    End Sub

    Private Sub LoginWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

    End Sub
End Class
