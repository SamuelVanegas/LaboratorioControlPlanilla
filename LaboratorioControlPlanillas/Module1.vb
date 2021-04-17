Module Module1

    Sub Main()
        Dim persona As New C_Persona("Samuel", "Vanegas", "145856", "Empleado", "16/04/2021", "M")
        persona.MostrarDatos()

        Dim trabajador As New C_Trabajador("Samuel", "Vanegas", "145856", "Empleado", "16/04/2021", "M", (0.0725 * 500), 500, "Sí")
        trabajador.MostrarDatos()

        'Dim obrero As New C_Obrero("Edgardo", "Ruano", "789562", "Empleado", "16/04/2021", "M", , , ) 'Faltó el cálculo de las horas'
        'obrero.MostrarDatos()


    End Sub

End Module
