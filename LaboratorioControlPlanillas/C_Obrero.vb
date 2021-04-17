Public Class C_Obrero
    Inherits C_Persona

    Private CostoPorHora As Double
    Private CostoHoraExtra As Double
    Private Hora_Extra As Double
    Private Horas As Integer

    Public Sub New(nom As String, ape As String, du As String, est As String, fecha As String, se As String, costHora As Double, costHoraExtra As Double, hExtra As Double, Hora As Integer)
        MyBase.New(nom, ape, du, est, fecha, se)
        CostoPorHora = costHora
        CostoHoraExtra = costHoraExtra
        Hora_Extra = hExtra
        Horas = Hora

    End Sub

    Public Property PCostoPorHora As Double
        Get
            Return CostoPorHora
        End Get
        Set(value As Double)
            CostoPorHora = value
        End Set
    End Property

    Public Property PCostoHoraExtra As Double
        Get
            Return CostoHoraExtra
        End Get
        Set(value As Double)
            CostoHoraExtra = value
        End Set
    End Property

    Public Property PHoraExtra As Double
        Get
            Return Hora_Extra
        End Get
        Set(value As Double)
            Hora_Extra = value
        End Set
    End Property

    Public Property PHoras As Integer
        Get
            Return Horas
        End Get
        Set(value As Integer)
            Horas = value
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
