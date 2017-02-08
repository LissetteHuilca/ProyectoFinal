Imports System.Data
Imports System.Data.OleDb

Public Class WinCandidato

    Private dbPath As String = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim winLogin As LoginCandidato
        winLogin = Me.Owner
        winLogin.Show()

        Me.Hide()

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As RoutedEventArgs) Handles btnVerificar.Click
        Dim resultadoBinomio As Integer
        Dim resultadoAsambleistas As Integer
        Dim resultadoConcejales As Integer
        Dim suma As Integer

        If comboListas.Text = "Lista 35" Then
            Dim uri As Uri = New Uri("Resources/alianzaPais.jpg", UriKind.Relative)
            image.Source = New BitmapImage(uri)
        End If

        If comboListas.Text = "Lista 23" Then
            Dim uri23 As Uri = New Uri("Resources/creoSuma.jpg", UriKind.Relative)
            image.Source = New BitmapImage(uri23)
        End If

        If comboListas.Text = "Lista 10" Then
            Dim uri10 As Uri = New Uri("Resources/FUERZA.jpg", UriKind.Relative)
            image.Source = New BitmapImage(uri10)
        End If

        If comboListas.Text = "Lista 6" Then
            Dim uri6 As Uri = New Uri("Resources/socialCristiano.png", UriKind.Relative)
            image.Source = New BitmapImage(uri6)
        End If






            Using dbConexion As New OleDbConnection(strConexion)
            Dim strQuery1 As String = "SELECT * FROM ListasPoliticas"
            Dim dbAdapter1 As New OleDbDataAdapter(strQuery1, dbConexion)

            Dim dsMaster1 As New DataSet("Datos")
            dbAdapter1.Fill(dsMaster1, "ListasPoliticas")

            For Each emp As DataRow In dsMaster1.Tables("ListasPoliticas").Rows
                resultadoBinomio += emp(comboListas.Text)
            Next
            suma = (resultadoBinomio / 100) * 100
            prgBinomio.Value = suma
            lblBinomio.Content = (suma & "%")



            Dim strQuery As String = "SELECT * FROM Dignidades"
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsMaster As New DataSet("Datos")
            dbAdapter.Fill(dsMaster, "Dignidades")

            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = comboListas.Text Then
                    resultadoAsambleistas += emp("Asambleistas")

                    resultadoConcejales += emp("Concejales")
                End If
            Next
            suma = (resultadoAsambleistas / 100) * 100
            prgAsambleistas.Value = suma
            lblAsambleistas.Content = (suma & "%")

            suma = (resultadoConcejales / 100) * 100
            prgConcejales.Value = suma
            lblConcejales.Content = (suma & "%")
        End Using
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        comboListas.SelectedIndex = 0
    End Sub
End Class
