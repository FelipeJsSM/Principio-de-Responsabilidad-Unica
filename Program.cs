public class Persona
{
    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public void EnviarCorreoElectronico(string mensaje)
    {
        //Lógica para enviar correo electrónico
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Correo Electrónico: {correoElectronico}");
    }
}