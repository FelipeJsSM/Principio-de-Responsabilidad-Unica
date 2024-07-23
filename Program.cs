// Clase Persona centrada en la representación de datos
public class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string direccion { get; set; }
    public string correoElectronico { get; set; }
}

// Clase ServicioCorreo para la responsabilidad de enviar correos electrónicos
public class ServicioCorreo
{
    public void EnviarCorreo(Persona destinatario, string mensaje)
    {
        // Lógica para enviar correo electrónico
    }
}

// Clase Utilidad para la responsabilidad de imprimir datos
public static class Utilidad
{
    public static void ImprimirDatos(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.nombre}");
        Console.WriteLine($"Edad: {persona.edad}");
        Console.WriteLine($"Dirección: {persona.direccion}");
        Console.WriteLine($"Correo Electrónico: {persona.correoElectronico}");
    }
}