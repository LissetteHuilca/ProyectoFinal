Class WinPrincipal
    Private Sub btnAdministrador_Click(sender As Object, e As RoutedEventArgs) Handles btnAdministrador.Click
        Dim administrador As New Login
        administrador.Owner = Me
        administrador.Show()
        Me.Hide()
    End Sub

    Private Sub btnCandidato_Click(sender As Object, e As RoutedEventArgs) Handles btnCandidato.Click
        Dim candidato As New LoginCandidato
        candidato.Owner = Me
        candidato.Show()
        Me.Hide()

    End Sub

    Private Sub btnVotante_Click(sender As Object, e As RoutedEventArgs) Handles btnVotante.Click
        Dim votante As New LogInVotante
        votante.Owner = Me
        votante.Show()
        Me.Hide()

    End Sub

End Class
