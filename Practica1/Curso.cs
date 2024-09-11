public class Curso
{
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Curso: {Nombre}, Clases: {RecuentoClases}, Ejercicios: {RecuentoEjercicios}");
    }
}