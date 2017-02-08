Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports Microsoft.Win32

Public Class RegistroDeCandidatos

    Private dbPath As String = "C:\Users\Eduardo\Desktop\ProyectoSistemaVotacion\usuarios.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsPersonas As DataSet

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        End
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As RoutedEventArgs) Handles btnRegresar.Click
        Dim winAdmin As WinAdministrador
        winAdmin = Me.Owner
        winAdmin.Show()

        Me.Hide()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As RoutedEventArgs) Handles btnGuardar.Click
        Dim id = 0
        Try
            id = Me.DataContext.Id()
        Catch ex As Exception

        End Try
        UpdatePersona(id, comboLista.Text, comboDignidad.Text, txtNom.Text, txtApellido.Text, txtCedula.Text, txtUsuario.Text, txtContraseña.Text)
        'Me.Close()
    End Sub

    Public Sub UpdatePersona(id As Integer, organizacion As String, dignidad As String, nombre As String, apellido As String, cedula As String, usuario As String, contraseña As String)
        If id = 0 Then
            Me.dsPersonas.Tables("Candidato").Rows.Add(organizacion, id, dignidad, nombre, apellido, cedula, usuario, contraseña)
        Else
            For Each persona As DataRow In Me.dsPersonas.Tables("Candidato").Rows
                If persona("Id") = id Then
                    persona("Lista") = organizacion
                    persona("Dignidad") = dignidad
                    persona("Nombre") = nombre
                    persona("Apellido") = apellido
                    persona("Cedula") = cedula
                    persona("Usuario") = usuario
                    persona("Contraseña") = contraseña
                End If
            Next
        End If


        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "Select * FROM Candidato;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)

            Try
                adapter.Update(dsPersonas.Tables("Candidato"))
            Catch ex As Exception
                MessageBox.Show("Error al guardar")
            End Try

        End Using

        MessageBox.Show("Candidato guardado")

        comboLista.Text = ""
        comboDignidad.Text = ""
        txtNom.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""


    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        txtNom.Focus()
        comboLista.SelectedIndex = 0
        comboDignidad.SelectedIndex = 0

        Using conexion As New OleDbConnection(strConexion)

            Dim consulta As String = "Select * FROM Candidato;"

            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            dsPersonas = New DataSet("Candidato")
            adapter.FillSchema(dsPersonas, SchemaType.Source)

            adapter.Fill(dsPersonas, "Candidato")
        End Using

    End Sub


End Class
