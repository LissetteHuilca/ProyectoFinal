Imports System.Data
Imports System.Data.OleDb

Public Class LogInVotante
    Private Sub btnEntrar_Click(sender As Object, e As RoutedEventArgs) Handles btnEntrar.Click

        Dim dbPath = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
        Dim strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; " &
            "Data Source=" & dbPath

        Using dbConexion As New OleDbConnection(strConexion)

            Dim strQuery As String = "SELECT * FROM Votante"
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsAdmin As New DataSet("Datos")
            dbAdapter.Fill(dsAdmin, "Votante")

            Dim encontrado As Boolean = False
            Dim nombre As String = ""
            Dim id As Integer

            For Each u As DataRow In dsAdmin.Tables("Votante").Rows

                If u("Cedula") = txtCedula.Text Then
                    nombre = u("nombre")
                    encontrado = True
                    id = u("Id")
                    Exit For
                End If
            Next
            If encontrado Then
                'Abrir ventana principal de la aplicación
                MessageBox.Show("Bienvenido " + nombre + "...!!")
                Dim venVotante As New WinVotantes
                venVotante.Owner = Me
                venVotante.Show()
                Me.Hide()

            Else
                MessageBox.Show("Cédula no coincide con la base de datos")
                txtCedula.Text = ""
            End If

            txtCedula.Text = ""

        End Using

    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventanaPrincipal As WinPrincipal
        ventanaPrincipal = Me.Owner
        ventanaPrincipal.Show()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        txtCedula.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
