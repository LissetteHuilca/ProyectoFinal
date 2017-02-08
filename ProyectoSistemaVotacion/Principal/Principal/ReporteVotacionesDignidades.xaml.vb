Imports System.Data
Imports System.Data.OleDb

Public Class ReporteVotacionesDignidades
    Private dbPath As String = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim repVotos As ReporteVotaciones
        repVotos = Me.Owner
        repVotos.Show()

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
            Dim strQuery As String = "SELECT * FROM Dignidades"
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsMaster As New DataSet("Datos")
            dbAdapter.Fill(dsMaster, "Dignidades")

            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 35" Then
                    resultadoLenin += emp("Asambleistas")
                End If
            Next
            suma = (resultadoLenin / 100) * 100
            prgAsam35.Value = suma
            lblAsam35.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 35" Then
                    resultadoLenin += emp("Concejales")
                End If
            Next
            suma = (resultadoLenin / 100) * 100
            prgCon35.Value = suma
            lblConcejal35.Content = (suma & "%")




            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 23" Then
                    resultadoLasso += emp("Asambleistas")
                End If
            Next
            suma = (resultadoLasso / 100) * 100
            prgAsam23.Value = suma
            lblAsam23.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 23" Then
                    resultadoLasso += emp("Concejales")
                End If
            Next
            suma = (resultadoLasso / 100) * 100
            prgCon23.Value = suma
            lblConcejal23.Content = (suma & "%")




            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 10" Then
                    resultadoDalo += emp("Asambleistas")
                End If
            Next
            suma = (resultadoDalo / 100) * 100
            prgAsam10.Value = suma
            lblAsam10.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 10" Then
                    resultadoDalo += emp("Concejales")
                End If
            Next
            suma = (resultadoDalo / 100) * 100
            prgCon10.Value = suma
            lblConcejal10.Content = (suma & "%")





            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 6" Then
                    resultadoCynthia += emp("Asambleistas")
                End If
            Next
            suma = (resultadoCynthia / 100) * 100
            prgAsam6.Value = suma
            lblAsam6.Content = (suma & "%")

            For Each emp As DataRow In dsMaster.Tables("Dignidades").Rows
                If emp("Lista") = "Lista 6" Then
                    resultadoCynthia += emp("Concejales")
                End If
            Next
            suma = (resultadoCynthia / 100) * 100
            prgCon6.Value = suma
            lblConcejal6.Content = (suma & "%")

        End Using

    End Sub
End Class
