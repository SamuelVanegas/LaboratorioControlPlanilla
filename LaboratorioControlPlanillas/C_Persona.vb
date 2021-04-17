Public Class C_Persona
    Protected nombre, apellido, dui, estado, fecha_inicio, sexo As String

    Public Sub New()

    End Sub

    Public Sub New(nom As String, ape As String, du As String, est As String, fecha As String, se As String)
        nombre = nom
        apellido = ape
        dui = du
        estado = est
        fecha_inicio = fecha
        sexo = se

    End Sub

    Public Property PNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property PApellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property PDui As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    Public Property PEstado As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property PFechaInicio As String
        Get
            Return fecha_inicio
        End Get
        Set(value As String)
            fecha_inicio = value
        End Set
    End Property

    Public Property PSexo As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property


    Public Overridable Sub MostrarDatos()
        Console.WriteLine("")
        Console.WriteLine("     DATOS DE LA PERSONA")
        Console.WriteLine("")
        Console.WriteLine("Nombre: " & PNombre)
        Console.WriteLine("Apellido: " & PApellido)
        Console.WriteLine("DUI: " & PDui)
        Console.WriteLine("Sexo: " & PSexo)
        Console.WriteLine("Estado: " & PEstado)
        Console.WriteLine("Fecha de inicio: " & PFechaInicio)
        Console.WriteLine("")

    End Sub
End Class
