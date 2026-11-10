int pedidosTotales = 0;
double recaudacion = 0;
double pedidoMasCaro = 0;
string nombrePedidoMasCaro = "";

int opcion = 0;

do
{
    Console.WriteLine("");
Console.WriteLine("--------------------");
Console.WriteLine("      BAR POLI");
Console.WriteLine("--------------------");
Console.WriteLine("");
Console.WriteLine("Opción 1: Pedir");
Console.WriteLine("Opción 2: Consultar Caja");
Console.WriteLine("Opción 3: Salir");
Console.Write("Elige una opción: ");
opcion = int.Parse(Console.ReadLine()!);

if (opcion == 1)
    {
        string nombreCliente = "";
        Console.Write("Introduce tu nombre: ");
        nombreCliente = (Console.ReadLine()!);
    }
    

} while (opcion != 0);




Console.WriteLine("");
