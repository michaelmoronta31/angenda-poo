
public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }

    public virtual void RegistrarMiembro(MiembroDeLaComunidad miembro)
    {
        Console.WriteLine($"Registrando Miembro: {miembro.Nombre}, Cedula: {miembro.Cedula}");
    }
}
public class Estudiantes : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
}
public class exAlumnos : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
    public int AnoGraduacion { get; set; }  
}
public class Empleado : MiembroDeLaComunidad
{
    public string departamento { get; set; }
}
public class Docente : Empleado
{
    public string Materia { get; set; }
}
public class Administrativo : Empleado
{
    public string Cargo { get; set; }
}
public class Administrador : Docente
{
     public string AreaAdministrativa { get; set; }
}
public class maestro : Docente
{
    public string Areadocente { get; set; }
}
class Program
{
     static void Main(string[]args)
    {
        MiembroDeLaComunidad estudiante = new Estudiantes

        {
            Nombre = "Arom mora",
            Cedula = "402-3009548-7",
            Carrera = "Ingenieria en sistemas"


        };
        MiembroDeLaComunidad exAlumno = new exAlumnos
        {
            Nombre = "Maria Lopez",
            Cedula = "001-4576543-3",
            Carrera = "Derecho",
            AnoGraduacion = 2020
        };
        MiembroDeLaComunidad empleado = new Empleado
        {
            Nombre = "Carlos Gomez",
            Cedula = "402-789612-3",
            departamento = "Recursos Humanos"
        };
        MiembroDeLaComunidad docente = new Docente
        {
            Nombre = "Ana Torres",
            Cedula = "001-654988-7",
            departamento = "Matemáticas",
            Materia= "Cálculo"
        };
        MiembroDeLaComunidad administrativo = new Administrativo
        {
            Nombre = "Luis Perez",
            Cedula = "402-123456-7",
            departamento = "Administracion",
            Cargo = "Gerente"
        };
        MiembroDeLaComunidad administrador = new Administrador
        {
            Nombre = "Sofia Ramirez",
            Cedula = "001-987654-3",
            departamento = "Administracion",
            Materia = "Gestion de Proyectos",
            AreaAdministrativa = "Finanzas"
        };
        MiembroDeLaComunidad maestro = new maestro
        {
            Nombre = "Juan Moronta",
            Cedula = "402-456789-1",
            departamento = "Ciencias",
            Materia = "Biologia",
            Areadocente = "Ciencias Naturales"
        };
        estudiante.RegistrarMiembro(estudiante);
        exAlumno.RegistrarMiembro(exAlumno);
        empleado.RegistrarMiembro(empleado);
        docente.RegistrarMiembro(docente);
        administrativo.RegistrarMiembro(administrativo);
        administrador.RegistrarMiembro(administrador);
        maestro.RegistrarMiembro(maestro);
    }
}
