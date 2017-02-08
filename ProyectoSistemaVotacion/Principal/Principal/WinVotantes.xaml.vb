Imports System.Data
Imports System.Data.OleDb
Imports System.Media

Public Class WinVotantes
    Private dbPath As String = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Dim votoLista As Integer = 1
    Private dsVotos As DataSet

    Dim conectar As OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand


    Private Sub dtgBinomio35_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dtgBinomio35.SelectionChanged

    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim winLogin As LogInVotante
        winLogin = Me.Owner
        winLogin.Show()

        Me.Hide()

    End Sub

    Private Sub btnVotar23_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar23.Click
        conectarBase()
        cmd.CommandText = "INSERT INTO ListasPoliticas([Lista 23]) VALUES('" & votoLista & "')"
        cerrarBase()
    End Sub

    Private Sub btnVotar35_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar35.Click
        conectarBase()
        cmd.CommandText = "INSERT INTO ListasPoliticas([Lista 35]) VALUES('" & votoLista & "')"
        cerrarBase()
    End Sub

    Private Sub btnVotar6_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar6.Click
        conectarBase()
        cmd.CommandText = "INSERT INTO ListasPoliticas([Lista 6]) VALUES('" & votoLista & "')"
        cerrarBase()

    End Sub

    Private Sub btnVotar10_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar10.Click
        conectarBase()
        cmd.CommandText = "INSERT INTO ListasPoliticas([Lista 10]) VALUES('" & votoLista & "')"
        cerrarBase()

    End Sub

    Private Sub btnVotarBanco_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarBanco.Click
        conectarBase()
        cmd.CommandText = "INSERT INTO ListasPoliticas(Blanco) 
        VALUES ('" & votoLista & "')"
        cmd.ExecuteNonQuery()
        conectar.Close()
        End
        MessageBox.Show("Gracias por su voto")

    End Sub

    Private Sub btnVotarNulo_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarNulo.Click
        conectarBase()
        cmd.CommandText = "INSERT INTO ListasPoliticas(Nulo) 
        VALUES ('" & votoLista & "')"
        cmd.ExecuteNonQuery()
        conectar.Close()
        MessageBox.Show("Gracias por su voto")
        End
    End Sub

    Private Sub cerrarBase()
        cmd.ExecuteNonQuery()
        conectar.Close()
        mostrarDignidades()
    End Sub

    Private Sub conectarBase()
        conectar.Open()
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conectar
        My.Computer.Audio.Stop()
    End Sub

    Private Sub mostrarDignidades()
        btnVotar35.IsEnabled = False
        btnVotar23.IsEnabled = False
        btnVotar10.IsEnabled = False
        btnVotar6.IsEnabled = False
        btnVotarNulo.IsEnabled = False
        btnVotarBanco.IsEnabled = False

        Dim dignidades As New VotarDignidades
        dignidades.Owner = Me
        dignidades.Show()
        Me.Hide()
    End Sub

    Private WithEvents Player As New SoundPlayer

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        My.Computer.Audio.Play(My.Resources.Sonido, AudioPlayMode.Background)

        Using dbConexion As New OleDbConnection(strConexion)

            conectar = New OleDb.OleDbConnection(strConexion)

            Dim strQuery As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 35') AND (Dignidad = 'Presidente' OR Dignidad = 'Vicepresidente')")
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsCandidato35 As New DataSet("Datos")
            dbAdapter.Fill(dsCandidato35, "Candidato")
            dtgBinomio35.DataContext = dsCandidato35


            Dim strQuery2 As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 23') AND (Dignidad = 'Presidente' OR Dignidad = 'Vicepresidente')")
            Dim dbAdapter2 As New OleDbDataAdapter(strQuery2, dbConexion)

            Dim dsCandidato23 As New DataSet("Datos")
            dbAdapter2.Fill(dsCandidato23, "Candidato23")
            dtgBinomio23.DataContext = dsCandidato23


            Dim strQuery3 As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 10') AND (Dignidad = 'Presidente' OR Dignidad = 'Vicepresidente')")
            Dim dbAdapter3 As New OleDbDataAdapter(strQuery3, dbConexion)

            Dim dsCandidato10 As New DataSet("Datos")
            dbAdapter3.Fill(dsCandidato10, "Candidato10")
            dtgBinomio10.DataContext = dsCandidato10

            Dim strQuery4 As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 6') AND (Dignidad = 'Presidente' OR Dignidad = 'Vicepresidente')")
            Dim dbAdapter4 As New OleDbDataAdapter(strQuery4, dbConexion)

            Dim dsCandidato6 As New DataSet("Datos")
            dbAdapter4.Fill(dsCandidato6, "Candidato6")
            dtgBinomio6.DataContext = dsCandidato6


        End Using

    End Sub

    Private Sub mediaElement_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles mediaElement.MouseDown

    End Sub

End Class
