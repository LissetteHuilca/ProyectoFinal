Imports System.Data
Imports System.Data.OleDb

Public Class Login
    Private Sub btnIngresar_Click(sender As Object, e As RoutedEventArgs) Handles btnIngresar.Click

        Dim dbPath = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
        Dim strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; " &
            "Data Source=" & dbPath

        Using dbConexion As New OleDbConnection(strConexion)
            'Console.WriteLine("Conexion exitosa")
            'Dim ventanaPrincipal As WinPrincipal

            Dim strQuery As String = "SELECT * FROM Administrador"
                Dim dbAdapter As New OleDbDataAdapter(strQuery, dbConexion)

                Dim dsAdmin As New DataSet("Datos")
                dbAdapter.Fill(dsAdmin, "Administrador")

                Dim encontrado As Boolean = False
                Dim nombre As String = ""
                Dim id As Integer

                For Each u As DataRow In dsAdmin.Tables("Administrador").Rows

                    If u("Usuario") = txtUser.Text And u("Contraseña") = password.Password Then
                        nombre = u("nombre")
                        encontrado = True
                        id = u("Id")
                        Exit For
                    End If
                Next
            If encontrado Then
                MessageBox.Show("Bienvenido " + nombre + "...!!")
                Dim venAdministrador As New WinAdministrador
                venAdministrador.Owner = Me
                venAdministrador.Show()
                Me.Hide()

            Else
                MessageBox.Show("Usuario y/o contraseña no coinciden con la base de datos")
                    txtUser.Text = ""
                    password.Password = ""
                End If

            txtUser.Text = ""
            password.Password = ""

        End Using

    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventanaPadre As WinPrincipal
        ventanaPadre = Me.Owner
        ventanaPadre.Show()
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        txtUser.Focus()
    End Sub
End Class
