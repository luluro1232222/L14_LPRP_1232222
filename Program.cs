using System;

string option;

Console.WriteLine("Bienvenido al menú. Selecciona una opción");
Console.WriteLine("Presione 1: -----> Calcular años de un empleado");
Console.WriteLine("Presione 2: -----> Puesto vs Salario");
Console.WriteLine("Presione 3: -----> Salir");

option = Console.ReadLine();

switch (option)
{
    case "1":
        string[] nombres = new string[5];
        int[] añoNací = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Nombre de la persona");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Año de nacimiento de la persona");
            añoNací[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < 5; i++)
        {
            int año;
            año = 2022 - añoNací[i];
            Console.WriteLine(nombres[i]);
            Console.WriteLine(año);
        }
        break;

    case "2":
        string[] carreras = new string[5];
        int[] aPagar = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Profesion: ");
            carreras[i] = Console.ReadLine();
            Console.Write("Monto a pagar: ");
            aPagar[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(carreras[i]);
            Console.WriteLine(aPagar[i]);
        }
        break;

    case "3":
        Console.WriteLine("Gracias por visitarnos!");
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Ups!");
        break;
}
