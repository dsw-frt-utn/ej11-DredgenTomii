using Dsw2026Ej11.Domain;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList 
{
    private readonly List<Alumno> listaAlumnos = new List<Alumno>();

    public void Agregar(Alumno alumno)
    {
        listaAlumnos.Add(alumno);
    }

    public List<Alumno> ObtenerLista()
    {
        return listaAlumnos;
    }

    public Alumno BuscarAlumnoPorNombre(string nombreBuscado)
    {
        Alumno alumnoEncontrado = listaAlumnos.Find(a => a.Nombre == nombreBuscado);
    
        return alumnoEncontrado;
    }

    public void RemoverAlumno(Alumno alumno)
    {
        listaAlumnos.Remove(alumno);
    }

    public void EliminarPorPosicion(int pocision)
    {
        listaAlumnos.RemoveAt(pocision);
    }
}
