Public Class C_Trabajador
    Inherits C_Persona

    Private AFP As Double
    Private salario As Double
    Private contratar As String

    Public Sub New(nom As String, ape As String, du As String, est As String, fecha As String, se As String, afp As Double, sal As Double, cont As String)
        MyBase.New(nom, ape, du, est, fecha, se)
        PAfp = afp
        salario = sal
        contratar = cont

    End Sub

    Public Property PAfp As Double
        Get
            Return AFP
        End Get
        Set(value As Double)
            AFP = value
        End Set
    End Property

    Public Property PSalario As Double
        Get
            Return salario
        End Get
        Set(value As Double)
            salario = value
        End Set
    End Property

    Public Property PContratar As String
        Get
            Return contratar
        End Get
        Set(value As String)
            contratar = value
        End Set
    End Property


    Public Overrides Sub MostrarDatos()
        Console.WriteLine("")
        Console.WriteLine("     DATOS DEL TRABAJADOR")
        Console.WriteLine("")
        Console.WriteLine("Nombre: " & PNombre)
        Console.WriteLine("Apellido: " & PApellido)
        Console.WriteLine("DUI: " & PDui & " " & " " & "Sexo: " & PSexo)
        Console.WriteLine("Estado: " & PEstado)
        Console.WriteLine("Fecha de inicio: " & PFechaInicio)
        Console.WriteLine("AFP: " & PAfp)
        Console.WriteLine("Descuento del salario: " & PSalario)
        Console.WriteLine("Contratado: " & PContratar)
        Console.WriteLine("")

    End Sub
End Class
