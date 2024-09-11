class Program
{
    static void Main(string[] args)
    {
        // instancias y probar métodos
        Estudiante estudiante = new Estudiante { Nombre = "Jennifer", NumeroUnico = "20231411" };
        estudiante.MostrarInfo();

        Curso curso = new Curso { Nombre = "Programación II", RecuentoClases = 8, RecuentoEjercicios = 1 };
        curso.MostrarDetalles();
    }
}
