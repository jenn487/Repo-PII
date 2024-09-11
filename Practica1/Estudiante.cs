public class Estudiante : Persona
{
    public string NumeroUnico { get; set; }
    public string ClaseId { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Número Único: {NumeroUnico}");
    }
}
