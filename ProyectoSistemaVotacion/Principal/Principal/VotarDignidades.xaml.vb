Imports System.Data
Imports System.Data.OleDb

Public Class VotarDignidades

    Private dbPath As String = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Dim votoLista As Integer = 1
    Dim conectar As OleDb.OleDbConnection
    Dim cmd As OleDbCommand

    Dim cont As Integer = 0
    Dim cont35 As Integer = 0
    Dim cont23 As Integer = 0
    Dim cont10 As Integer = 0
    Dim cont6 As Integer = 0


    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        conectar = New OleDb.OleDbConnection(strConexion)
        Using dbConexion As New OleDbConnection(strConexion)
            Dim strQuery As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 35') AND (Dignidad = 'Asambleista' OR Dignidad = 'Concejal')")
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsCandidato35 As New DataSet("Datos")
            dbAdapter.Fill(dsCandidato35, "Lista35")
            GridLista35.DataContext = dsCandidato35


            Dim strQuery2 As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 23') AND (Dignidad = 'Asambleista' OR Dignidad = 'Concejal')")
            Dim dbAdapter2 As New OleDbDataAdapter(strQuery2, dbConexion)

            Dim dsCandidato23 As New DataSet("Datos")
            dbAdapter2.Fill(dsCandidato23, "Lista23")
            GridLista23.DataContext = dsCandidato23


            Dim strQuery3 As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 10') AND (Dignidad = 'Asambleista' OR Dignidad = 'Concejal')")
            Dim dbAdapter3 As New OleDbDataAdapter(strQuery3, dbConexion)

            Dim dsCandidato10 As New DataSet("Datos")
            dbAdapter3.Fill(dsCandidato10, "Lista10")
            GridLista10.DataContext = dsCandidato10

            Dim strQuery4 As String = ("SELECT Dignidad, Nombre, Apellido FROM Candidato WHERE (Lista = 'lista 6') AND (Dignidad = 'Asambleista' OR Dignidad = 'Concejal')")
            Dim dbAdapter4 As New OleDbDataAdapter(strQuery4, dbConexion)

            Dim dsCandidato6 As New DataSet("Datos")
            dbAdapter4.Fill(dsCandidato6, "Lista6")
            GridLista6.DataContext = dsCandidato6


        End Using
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        End
    End Sub



    Private Sub GridLista35_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles GridLista35.SelectionChanged
        cont35 = cont35 + 1
        cont = cont + 1
        votos(cont)

        If cont35 = 2 Then
            GridLista35.IsEnabled = False
        End If

        Dim fila As DataRowView = sender.SelectedItem

        MessageBox.Show("Usted votó por un: " & fila("Dignidad") & " de la Lista 35")

        conectarBase()
        If fila("Dignidad") = "Asambleista" Then
            cmd.CommandText = "INSERT INTO Dignidades(Asambleistas, Lista) VALUES ('" & votoLista & "', 'Lista 35')"
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Dignidades(Concejales, Lista) VALUES ('" & votoLista & "', 'Lista 35')"
            cmd.ExecuteNonQuery()

        End If

        conectar.Close()

    End Sub

    Private Sub conectarBase()
        conectar.Open()
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conectar
    End Sub


    Private Sub GridLista23_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles GridLista23.SelectionChanged
        cont23 = cont23 + 1
        cont = cont + 1

        votos(cont)
        Dim fila As DataRowView = sender.SelectedItem

        If cont23 = 2 Then
            GridLista23.IsEnabled = False
        End If

        MessageBox.Show("Usted voto por un: " & fila("Dignidad") & " de la Lista 23")

        conectarBase()
        If fila("Dignidad") = "Asambleista" Then
            cmd.CommandText = "INSERT INTO Dignidades(Asambleistas, Lista) VALUES ('" & votoLista & "', 'Lista 23')"
            cmd.ExecuteNonQuery()

        Else
            cmd.CommandText = "INSERT INTO Dignidades(Concejales, Lista) VALUES ('" & votoLista & "', 'Lista 23')"
            cmd.ExecuteNonQuery()
        End If

        conectar.Close()


    End Sub


    Private Sub GridLista10_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles GridLista10.SelectionChanged
        cont10 = cont10 + 1
        cont = cont + 1

        votos(cont)

        Dim fila As DataRowView = sender.SelectedItem

        If cont10 = 2 Then
            GridLista10.IsEnabled = False
        End If



        MessageBox.Show("Usted voto por un: " & fila("Dignidad") & " de la Lista 10")
        conectarBase()
        If fila("Dignidad") = "Asambleista" Then
            cmd.CommandText = "INSERT INTO Dignidades(Asambleistas, Lista) VALUES ('" & votoLista & "', 'Lista 10')"
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Dignidades(Concejales, Lista) VALUES ('" & votoLista & "', 'Lista 10')"
            cmd.ExecuteNonQuery()
        End If

        conectar.Close()
    End Sub


    Private Sub GridLista6_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles GridLista6.SelectionChanged
        cont6 = cont6 + 1
        cont = cont + 1
        votos(cont)

        Dim fila As DataRowView = sender.SelectedItem

        If cont6 = 2 Then
            GridLista6.IsEnabled = False
        End If


        MessageBox.Show("Usted voto por un: " & fila("Dignidad") & " de la Lista 6")
        conectarBase()
        If fila("Dignidad") = "Asambleista" Then
            cmd.CommandText = "INSERT INTO Dignidades(Asambleistas, Lista) VALUES ('" & votoLista & "', 'Lista 6')"
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Dignidades(Concejales, Lista) VALUES ('" & votoLista & "', 'Lista 6')"
            cmd.ExecuteNonQuery()
        End If

        conectar.Close()
    End Sub

    Private Sub votos(cont As Integer)
        If cont = 4 Then
            MessageBox.Show("Ha cumplido con los votos requeridos.. Gracias!")
            Me.Close()
        End If
    End Sub



End Class



