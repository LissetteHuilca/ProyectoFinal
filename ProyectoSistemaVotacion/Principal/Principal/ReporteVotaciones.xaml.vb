Imports System.Data
Imports System.Data.OleDb

Public Class ReporteVotaciones

    Private dbPath As String = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub ProgressLenin_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles ProgressLenin.ValueChanged
    End Sub


    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim administrador As WinAdministrador
        administrador = Me.Owner
        administrador.Show()

        Me.Hide()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        Dim resultadoLenin As Integer
        Dim resultadoLasso As Integer
        Dim resultadoDalo As Integer
        Dim resultadoCynthia As Integer
        Dim resultadoNulo As Integer
        Dim resultadoBlanco As Integer

        Dim resultado As Integer

        Dim suma As Integer


        Using dbConexion As New OleDbConnection(strConexion)
            'Console.WriteLine("Conexion exitosa")
            Dim strQuery As String = "SELECT * FROM ListasPoliticas"
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsMaster As New DataSet("Datos")
            dbAdapter.Fill(dsMaster, "ListasPoliticas")

            For Each emp As DataRow In dsMaster.Tables("ListasPoliticas").Rows
                resultadoLenin += emp("Lista 35")
            Next
            suma = (resultadoLenin / 100) * 100
            ProgressLenin.Value = suma
            labelPlennin.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("ListasPoliticas").Rows
                resultadoLasso += emp("Lista 23")
            Next
            suma = (resultadoLasso / 100) * 100
            ProgressLasso.Value = suma
            labelPlasso.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("ListasPoliticas").Rows
                resultadoDalo += emp("Lista 10")
            Next
            suma = (resultadoDalo / 100) * 100
            ProgressDalo.Value = suma
            labelPdalo.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("ListasPoliticas").Rows
                resultadoCynthia += emp("Lista 6")
            Next
            suma = (resultadoCynthia / 100) * 100
            ProgressCynthia.Value = suma
            labelPcynthia.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("ListasPoliticas").Rows
                resultadoNulo += emp("Nulo")
            Next
            suma = (resultadoNulo / 100) * 100
            ProgressNulo.Value = suma
            lblNulo.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("ListasPoliticas").Rows
                resultadoBlanco += emp("Blanco")
            Next
            suma = (resultadoBlanco / 100) * 100
            ProgressBlanco.Value = suma
            lblBlanco.Content = (suma & "%")



        End Using

    End Sub

    Private Sub btnNext_Click(sender As Object, e As RoutedEventArgs) Handles btnNext.Click
        Dim reporteDignidades As New ReporteVotacionesDignidades
        reporteDignidades.Owner = Me
        reporteDignidades.Show()
        Me.Hide()

    End Sub

End Class
