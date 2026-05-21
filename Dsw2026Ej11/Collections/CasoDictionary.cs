using Dsw2026Ej11.Domain;
using System.Reflection;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> DicionarioAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        DicionarioAlumnos.Add(legajo, alumno);
    }

    public Alumno BuscarAlumno(int legajoBuscado)
    {
        if (DicionarioAlumnos.TryGetValue(legajoBuscado, out Alumno alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        else
        {
            return null;
        }
    }

    public Dictionary<int, Alumno> ObtenerDicionario()
    {
        return DicionarioAlumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        DicionarioAlumnos.Remove(legajo);
    }
}
