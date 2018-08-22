Public Class nuevaven
    Public link As String
    Private Sub nuevaven_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        browser.Navigate(link)
    End Sub

    Private Sub browser_Navigated(sender As System.Object, e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles browser.Navigated
        If BuscarTexto("TIP_Documento=3", link) = True Then
            Me.Dispose()
        End If
    End Sub
End Class