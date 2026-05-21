using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList gestor = new CasoList();

        Alumno alumno1 = new Alumno(101, "Selena", 8.5);
        Alumno alumno2 = new Alumno(102, "Carlos", 7.3);
        Alumno alumno3 = new Alumno(103, "Miguel", 6.8);

        gestor.Agregar(alumno1);
        gestor.Agregar(alumno2);
        gestor.Agregar(alumno3);

        Console.WriteLine("--- Lista de Alumnos Inicial ---");
        foreach (Alumno alu in gestor.ObtenerLista())
        {
            Console.WriteLine($"Nombre: {alu.Nombre} | Id: {alu.Id} | Promedio: {alu.Promedio}");
        }

        Console.WriteLine("\n--- Buscando a Miguel ---");
        Alumno encontrado = gestor.BuscarAlumnoPorNombre("Miguel");
        if (encontrado != null)
        {
            Console.WriteLine($"El alumno es: {encontrado.Nombre}");
        }

        Console.WriteLine("\n--- Buscando a Juan ---");
        Alumno noEncontrado = gestor.BuscarAlumnoPorNombre("Juan");
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n--- Eliminando a Miguel ---");
        gestor.RemoverAlumno(alumno3);

        foreach (Alumno alu in gestor.ObtenerLista())
        {
            Console.WriteLine($"Nombre: {alu.Nombre}");
        }

        Console.WriteLine("\n--- Eliminando el primer elemento (Posición 0) ---");
        gestor.EliminarPorPosicion(0);
        foreach (Alumno alu in gestor.ObtenerLista())
        {
            Console.WriteLine($"Nombre: {alu.Nombre}");
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary gestor = new CasoDictionary();

        Alumno alumno1 = new Alumno(213, "Francisco", 7.5);
        Alumno alumno2 = new Alumno(214, "Gonzales", 6.5);
        Alumno alumno3 = new Alumno(215, "Agustin", 9.3);

        gestor.AgregarAlumno(213, alumno1);
        gestor.AgregarAlumno(214, alumno2);
        gestor.AgregarAlumno(215, alumno3);

        Console.WriteLine("--- Lista de Alumnos Inicial ---");
        foreach (KeyValuePair<int, Alumno> par in gestor.ObtenerDicionario())
        {
            Console.WriteLine($"Legajo: {par.Key} | Nombre:{par.Value.Nombre} ");
        }

        Console.WriteLine("\n--- Buscando legajo 213 ---");
        Alumno buscado = gestor.BuscarAlumno(213);

        if (buscado != null)
        {
            Console.WriteLine($"El alumno es: {buscado.Nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n--- Buscando Legajo 255---");
        Alumno noEncontrado = gestor.BuscarAlumno(255);

        if (noEncontrado != null)
        {
            Console.WriteLine($"El alumno es: {noEncontrado.Nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine("\n--- Eliminando legajo 215 ---");
        gestor.EliminarAlumno(215);

        Console.WriteLine("\n--- Lista Final ---");
        foreach (KeyValuePair<int, Alumno> par in gestor.ObtenerDicionario())
        {
            Console.WriteLine($"Legajo: {par.Key} | Nombre:{par.Value.Nombre} ");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
