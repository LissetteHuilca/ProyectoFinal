
Public Class WinAdministrador

    Private Sub btnRegistrar_Click(sender As Object, e As RoutedEventArgs) Handles btnRegistrar.Click
        Dim winRegistro As New RegistroDeCandidatos
        winRegistro.Owner = Me
        winRegistro.Show()
        Me.Hide()

    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventanaAdmin As Login
        ventanaAdmin = Me.Owner
        ventanaAdmin.Show()

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As RoutedEventArgs) Handles btnGenerar.Click
        Dim reporte As New ReporteVotaciones
        reporte.Owner = Me
        reporte.Show()
        Me.Hide()

    End Sub



End Class
