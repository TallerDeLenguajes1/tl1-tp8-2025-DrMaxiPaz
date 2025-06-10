using EspacioCalculadora;
Calculadora c = new();
int opc, entrada;
do
{
    Console.Clear();
    if (c.Historial.Count > 0)
    {
        Console.WriteLine("Historial de operaciones:");
        foreach (var operacion in c.Historial)
        {
            Console.WriteLine($"Resultado Anterior: {operacion.ResultadoAnterior}, Nuevo Valor: {operacion.NuevoValor}, Operación: {operacion.Operando}");
        }

    }
    Console.WriteLine("\n\t\tCalculadora\n\t1. Sumar\n\t2. Restar\n\t3. Multiplicar\n\t4. Dividir\n\t5. Limpiar\n\t6. Salir");
    Console.Write("Ingrese una opcion: ");
    if (int.TryParse(Console.ReadLine(), out opc))
    {
        switch (opc)
        {
            case 1:
                Console.Write("Ingrese el valor a sumar: ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Sumar(entrada);
                break;
            case 2:
                Console.Write("Ingrese el valor a restar : ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Restar(entrada);
                break;
            case 3:
                Console.Write("Ingrese el valor a multiplicar: ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Multiplicar(entrada);
                break;
            case 4:
                Console.Write("Ingrese el valor a dividir: ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Dividir(entrada);
                break;
            case 5:
                Console.WriteLine("Limpiando...");
                c.Limpiar();
                break;
            case 6:
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Opcion incorrecta...");
                break;
        }
    }
    Console.WriteLine($"El resultado es: {c.Resultado}");
} while (opc != 6);
