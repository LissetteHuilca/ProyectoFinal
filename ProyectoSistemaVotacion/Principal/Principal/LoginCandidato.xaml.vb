Imports System.Data
Imports System.Data.OleDb

Public Class LoginCandidato
    Private Sub btnStart_Click(sender As Object, e As RoutedEventArgs) Handles btnStart.Click

        Dim dbPath = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
        Dim strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; " &
            "Data Source=" & dbPath

        Using dbConexion As New OleDbConnection(strConexion)
            Dim strQuery As String = "SELECT * FROM Candidato"
            Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

            Dim dsCandidato As New DataSet("Datos")
            dbAdapter.Fill(dsCandidato, "Candidato")

            Dim encontrado As Boolean = False
            Dim nombre As String = ""
            Dim id As Integer

            For Each u As DataRow In dsCandidato.Tables("Candidato").Rows

                If u("Usuario") = txtUsuario.Text And u("Contraseña") = passwordBox.Password Then
                    nombre = u("nombre")
                    encontrado = True
                    id = u("Id")
                    Exit For
                End If
            Next
            If encontrado Then
                MessageBox.Show("Bienvenido " + nombre + "...!!")
                Dim venCandidato As New WinCandidato
                venCandidato.Owner = Me
                venCandidato.Show()
                Me.Hide()

            Else
                MessageBox.Show("Usuario y/o contraseña no coinciden con la base de datos")
                txtUsuario.Text = ""
                passwordBox.Password = ""
            End If

        End Using

        txtUsuario.Text = ""
        passwordBox.Password = ""

    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventanaPadre As WinPrincipal
        ventanaPadre = Me.Owner
        ventanaPadre.Show()
    End Sub

    Private Sub btnOut_Click(sender As Object, e As RoutedEventArgs) Handles btnOut.Click
        End
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        txtUsuario.Focus()
    End Sub
End Class
