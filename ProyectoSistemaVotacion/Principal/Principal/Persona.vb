Public Class Persona
    Private _nombre As String

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property
    Private _cedula As String
    Public Property Lugar() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
        End Set
    End Property

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _contraseña As String
    Public Property Contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property

    Sub New(id As Integer, nombre As String, apellido As String, cedula As String, usuario As String, contraseña As String)
        _id = id
        _nombre = nombre
        _apellido = apellido
        _cedula = cedula
        _usuario = usuario
        _contraseña = contraseña
    End Sub

    Sub New(id As Integer, nombre As String, apellido As String, cedula As String)
        _id = id
        _nombre = nombre
        _apellido = apellido
        _cedula = cedula
    End Sub

    Sub New(nombre As String, apellido As String, cedula As String)
        _nombre = nombre
        _apellido = apellido
        _cedula = cedula
    End Sub


End Class
