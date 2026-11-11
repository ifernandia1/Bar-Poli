using System.Diagnostics;

int pedidosTotales = 0;
double recaudacion = 0;
double pedidoMasCaro = 0;
string nombrePedidoMasCaro = "";
string? direccion = null;
string respuestaDomicilio = "";
int opcion = 0;


do
{
    bool extraLechugaEns = false;
    bool extraTomateEns = false;
    bool extraFrutosEns = false;
    double precioExtras = 0;
    bool extraLechugaHamb = false;
    bool extraCarne = false;
    bool tripleCarne = false;
    bool extraQueso = false;
    bool extraBacon = false;
    bool extraBacQue = false;

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
    Console.WriteLine("");

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
                Console.WriteLine("");
            }
        } while (nombreCliente == "");

        //Opciones de pedido 

        int opcionPedido = 0;
        Console.WriteLine("======================================");
        Console.WriteLine("Opción 1: Bocatas --- 7,50€");
        Console.WriteLine("Opción 2: Hamburguesas --- 10,00€");
        Console.WriteLine("Opción 3: Ensaladas --- 9,50€");
        Console.WriteLine("======================================");
        Console.WriteLine("");

        do
        {

            Console.Write($"Hola {nombreCliente} que desea pedir: ");
            opcionPedido = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

        } while (opcionPedido < 1 || opcionPedido > 3);

        int opcionExtra = 0;

        switch (opcionPedido)
        {
            // Caso de los bocatas
            case 1:
                recaudacion += 7.50;

                // extras de los bocatas

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Has elegido un bocata, quieres algún extra?");
                    Console.WriteLine("1. Extra queso --- 1€");
                    Console.WriteLine("2. Extra Bacon --- 2€");
                    Console.WriteLine("3. Extra Bacon + queso --- 2,50€");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("");

                    Console.Write("Introduce el número del extra: ");
                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra == 1)
                    {
                        if (extraQueso)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraQueso = true;
                            precioExtras += 1;
                            Console.WriteLine("Has añadido extra de queso.");
                        }

                    }
                    else if (opcionExtra == 2)
                    {
                        if (extraBacon)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraBacon = true;
                            precioExtras += 2;
                            Console.WriteLine("Has añadido extra de bacon.");
                        }

                    }
                    else if (opcionExtra == 3)
                    {
                        if (extraBacQue)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraBacQue = true;
                            precioExtras += 2.50;
                            Console.WriteLine("Has añadido extra de queso y bacon.");
                        }

                    }
                    else if (opcionExtra != 4)
                    {
                        Console.WriteLine("Elije una opción entre 1 y 4");
                    }
                } while (opcionExtra != 4);
                break;
            // caso de las hamburguesas
            case 2:
                recaudacion += 10;

                //extras de las hamburguesas
                do
                {
                    Console.WriteLine("Has elegido una hamburguesa, quieres algún extra?");
                    Console.WriteLine("1. Extra lechuga --- 0.50€");
                    Console.WriteLine("2. Extra carne --- 2€");
                    Console.WriteLine("3. Extra triple carne --- 3€");
                    Console.WriteLine("4. Salir");
                    Console.Write("Introduce el número del extra: ");

                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra == 1)
                    {
                        if (extraLechugaHamb)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraLechugaHamb = true;
                            precioExtras += 0.5;
                            Console.WriteLine("Has añadido extra de lechuga.");
                        }
                    }
                    else if (opcionExtra == 2)
                    {
                        if (extraCarne)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraCarne = true;
                            precioExtras += 2;
                            Console.WriteLine("Has añadido doble carne.");
                        }

                    }
                    else if (opcionExtra == 3)
                    {
                        if (tripleCarne)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            tripleCarne = true;
                            precioExtras += 3;
                            Console.WriteLine("Has añadido triple carne.");
                        }

                    }
                    else if (opcionExtra != 4)
                    {
                        Console.WriteLine("Elije una opción entre 1 y 4");
                    }
                } while (opcionExtra != 4);
                break;
            //caso de las ensaladas
            case 3:

                //extras de las ensaladas
                recaudacion += 9.50;

                do
                {

                    Console.WriteLine("");
                    Console.WriteLine("Has elegido una ensalada, quieres algún extra?");
                    Console.WriteLine("1. Extra lechuga --- 0.50€");
                    Console.WriteLine("2. Extra Tomate --- 1€");
                    Console.WriteLine("3. Extra de Frutos secos --- 2€");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("");
                    Console.Write("Introduce el número del extra: ");
                    opcionExtra = int.Parse(Console.ReadLine()!);

                    if (opcionExtra == 1)
                    {
                        if (extraLechugaEns)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraLechugaEns = true;
                            precioExtras += 0.5;
                            Console.WriteLine("Has añadido extra de lechuga.");
                        }
                    }
                    else if (opcionExtra == 2)
                    {
                        if (extraTomateEns)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraTomateEns = true;
                            precioExtras += 1;
                            Console.WriteLine("Has añadido extra de tomate.");
                        }
                    }
                    else if (opcionExtra == 3)
                    {
                        if (extraFrutosEns)
                        {
                            Console.WriteLine("Ya tienes este extra");
                        }
                        else
                        {
                            extraFrutosEns = true;
                            precioExtras += 2;
                            Console.WriteLine("Has añadido extra de frutos secos.");
                        }
                    }
                    else if (opcionExtra != 4)
                    {
                        Console.WriteLine("Elije una opción entre 1 y 4");
                    }
                } while (opcionExtra != 4);

                break;
        }
        do
        {
            Console.WriteLine("");
            Console.Write("¿Quieres el pedido a domicilio? 3€ extra (s/n)");
            respuestaDomicilio = (Console.ReadLine()!).Trim().ToLower();
            if (respuestaDomicilio == "" || (respuestaDomicilio[0] != 's' && respuestaDomicilio[0] != 'n'))
            {
                Console.WriteLine("Contesta solo con s (si) o n (no)");
            }
        } while (respuestaDomicilio == "" || (respuestaDomicilio[0] != 's' && respuestaDomicilio[0] != 'n'));
        bool aDomicilio = respuestaDomicilio[0] == 's';
        if (aDomicilio)
        {
            recaudacion += 3;
            Console.Write("Escribe tu direccion: ");
            direccion = (Console.ReadLine()!);
            pedidosTotales += 1;
        }
        else
        {
            pedidosTotales += 1;
        }

        double preciototal = recaudacion + precioExtras;
        Console.WriteLine("");
        Console.WriteLine("========================");
        Console.WriteLine("     TOTAL SESIÓN");
        Console.WriteLine("========================");
        Console.WriteLine("");
        Console.WriteLine($"Precio ensalada: {recaudacion}");
        Console.WriteLine($"Precio extras: {precioExtras}");
        Console.WriteLine($"Precio total: {preciototal}");
    }
    else if (opcion == 2)
    {

        Console.WriteLine("===============================");
        Console.WriteLine("            CAJA");
        Console.WriteLine("===============================");
        Console.WriteLine("");
        if (pedidosTotales == 0)
        {
            Console.WriteLine("No hay pedidos");
        }
        else
        {
            double mediaDinero = recaudacion / pedidosTotales;
            Console.WriteLine($"pedidos totales: {pedidosTotales}");
            Console.WriteLine($"Recaudación: {recaudacion:F2}");
            Console.WriteLine($"Media dinero: {mediaDinero:F2}");
        }
        Console.WriteLine("");


    }
} while (opcion != 3);

Console.WriteLine("");
