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

        // Pedir nombre al cliente

        string nombreCliente = "";
        Console.Write("Introduce tu nombre: ");

        do
        {
            nombreCliente = (Console.ReadLine()!);
            if (nombreCliente == "")
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                Console.Write("Introduce tu nombre: ");
            }
        } while (nombreCliente == "");

        //Opciones de pedido 

        int opcionPedido = 0;
        Console.WriteLine("Opción 1: Bocatas --- 7,50€");
        Console.WriteLine("Opción 2: Hamburguesas --- 10,00€");
        Console.WriteLine("Opción 3: Ensaladas --- 9,50€");
        Console.WriteLine("");

        do
        {
            Console.Write($"Hola {nombreCliente} que desea pedir: ");
            opcionPedido = int.Parse(Console.ReadLine()!);
        } while (opcionPedido < 1 || opcionPedido > 3);

        switch (opcionPedido)
        {
            // Caso de los bocatas
            case 1:
                recaudacion += 7.50;
                int opcionExtra = 0;
                do
                {
                    Console.WriteLine("Has elegido un bocata, quieres algún extra?");
                    Console.WriteLine("1. Extra queso --- 1€");
                    Console.WriteLine("2. Extra Bacon --- 2€");
                    Console.WriteLine("3. Extra Bacon + queso --- 2,50€");
                    Console.Write("Introduce el número del extra: ");
                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra < 1 || opcionExtra > 3)
                    {
                        Console.WriteLine("Elige una opción entre 1 y 3");
                        Console.WriteLine("");
                    }
                } while (opcionExtra < 1 || opcionExtra > 3);

                    if (opcionExtra == 1)
                    {
                        recaudacion += 1;
                        Console.WriteLine("Has añadido extra de queso.");
                        break;
                    }
                    else if (opcionExtra == 2)
                    {
                        recaudacion += 2;
                        Console.WriteLine("Has añadido extra de bacon.");
                        break;
                    }
                    else if (opcionExtra == 3)
                    {
                        recaudacion += 2.50;
                        Console.WriteLine("Has añadido extra de queso y bacon.");
                        break;
                    }break;
                
            case 2:
                do
                {
                    Console.WriteLine("Has elegido una hamburguesa, quieres algún extra?");
                    Console.WriteLine("1. Extra lechuga --- 1€");
                    Console.WriteLine("2. Extra carne --- 2€");
                    Console.WriteLine("3. Extra triple carne --- 3€");
                    Console.Write("Introduce el número del extra: ");
                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra < 1 || opcionExtra > 3)
                    {
                        Console.WriteLine("Elige una opción entre 1 y 3");
                        Console.WriteLine("");
                    }
                } while (opcionExtra < 1 || opcionExtra > 3);

                    if (opcionExtra == 1)
                    {
                        recaudacion += 1;
                        Console.WriteLine("Has añadido extra de queso.");
                        break;
                    }
                    else if (opcionExtra == 2)
                    {
                        recaudacion += 2;
                        Console.WriteLine("Has añadido extra de bacon.");
                        break;
                    }
                    else if (opcionExtra == 3)
                    {
                        recaudacion += 2.50;
                        Console.WriteLine("Has añadido extra de queso y bacon.");
                        break;
                    }break;
            case 3:

                break;
        }

    }
} while (opcion != 0);




Console.WriteLine("");
