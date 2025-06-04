// See https://aka.ms/new-console-template for more information
using ToDo;

List<Tarea> listaPendientes = new List<Tarea>();
List<Tarea> listaRealizadas = new List<Tarea>();


Console.WriteLine("Tarea pendiente - TareaID - Descripcion - Duracion");
for (int i = 0; i < 10; i++)
{
    Tarea T = new(1000 + i, $"tarea {1000 + i}", Random.Shared.Next(10, 100));
    listaPendientes.Add(T);
    Console.WriteLine($"                    {listaPendientes[i].TareaID}  - {listaPendientes[i].Descripcion}  - {listaPendientes[i].Duracion}s");
}

int opc = 0;
do
{
    Console.WriteLine("\n\tSeleccione una opción:");
    Console.WriteLine("1. Marcar tarea como realizada");
    Console.WriteLine("2. Buscar tarea pendiente por descripcion");
    Console.WriteLine("3. Ver tareas pendientes y realizadas");
    Console.WriteLine("4. Salir");
    Console.Write("Opción: ");
    opc = int.Parse(Console.ReadLine() ?? "0");
    switch (opc)
    {
        case 1:
            Console.Write("Ingrese el ID de la tarea a marcar como realizada(>= 1000):");
            int tareaID = int.Parse(Console.ReadLine() ?? "0");
            if (listaPendientes.Any(t => t.TareaID == tareaID))
            {
                Tarea tarea = listaPendientes.First(t => t.TareaID == tareaID);
                listaRealizadas.Add(tarea);
                listaPendientes.Remove(tarea);
                Console.WriteLine($"Tarea {tareaID} marcada como realizada.");
            }
            else
            {
                Console.WriteLine($"No se encontró la tarea con ID {tareaID}.");
            }
            break;
        case 2:
            Console.Write("Ingrese la descripcion de la tarea a buscar: ");
            string descripcion = Console.ReadLine() ?? string.Empty;
            if (listaPendientes.Any(t => t.Descripcion == descripcion))
            {
                Tarea tareaEncontrada = listaPendientes.First(t => t.Descripcion == descripcion);
                Console.WriteLine($"Tarea encontrada: ID {tareaEncontrada.TareaID}, Descripción: {tareaEncontrada.Descripcion}, Duración: {tareaEncontrada.Duracion}s");
            }
            else
            {
                Console.WriteLine($"No se encontró ninguna tarea con la descripción '{descripcion}'.");
            }
            break;
        case 3:
            Console.WriteLine("\n\tTareas pendientes:");
            listaPendientes.ForEach(t => Console.WriteLine($"\tID: {t.TareaID}, Descripción: {t.Descripcion}, Duración: {t.Duracion}s"));
            Console.WriteLine("\n\tTareas realizadas:");
            listaRealizadas.ForEach(t => Console.WriteLine($"\tID: {t.TareaID}, Descripción: {t.Descripcion}, Duración: {t.Duracion}s"));
            break;
        case 4:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }
} while (opc != 4);

