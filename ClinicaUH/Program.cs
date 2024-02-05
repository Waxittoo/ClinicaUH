// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");
int tamano = 2;
String[] nombre = new string [tamano];
int[] edad = new int[tamano];
string[] cita = new string[tamano];
int opcion = 0;

menu();



void inicializar()
{
    nombre = Enumerable.Repeat("", tamano).ToArray<string>();
    cita = Enumerable.Repeat("", tamano).ToArray<string>();
    edad = Enumerable.Repeat(0, tamano).ToArray<int>();
    
    Console.WriteLine("los arreglos han sido inicializados ");
    Console.ReadKey();
    Console.Clear();
}


void AsignarCita()
{
    Console.WriteLine("Digite el nombre del paciente para asignar la cita: ");
    string nomb = Console.ReadLine();
    bool encontrado = false;

    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($"Ingrese la  fecha pra la cita de {nomb}: ");
            cita[i] = Console.ReadLine();
            encontrado = true;
            Console.WriteLine($"Cita asignada correctamente a {nomb}");
        }
    }

    if (!encontrado)
    {
        Console.WriteLine($"El paciente {nomb} no existe ");
    }

    Console.ReadKey();
    Console.Clear();
}



void Agregar() 
{
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine("ingrese el nombre : "); nombre[i] = Console.ReadLine();
        Console.WriteLine("ingrese la edad  : "); edad[i] =int.Parse(Console.ReadLine());
    }
    

}

void Consulta()
{
    bool encontrado = false;
    Console.WriteLine("Digite el nombre a buscar ");
    string nomb = Console.ReadLine();

    for (int i = 0;i < nombre.Length;i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($"La edad de {nomb} es de {edad[i]}");
            encontrado = true;
        }
    }
    if ( encontrado == false)
    {
        Console.WriteLine($"El cliente {nomb} no existe ");
    }
}

void Reporte ()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("nombre                       Edad");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("----------------           ------------");
    for (int i = 0; i < nombre.Length; i++)
    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nombre[i]} {edad[i]}");
    }
}

void menu()
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*****************Consultorio medico*************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1 - Inicializar arreglos");
        Console.WriteLine("2- ingresar paciente");
        Console.WriteLine("3- Consultar paciente");
        Console.WriteLine("4- Reporte");
        Console.WriteLine("5- Asiganar citas");
        Console.WriteLine("6- Salir");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine( "Digite una opcion...");
        opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1: inicializar(); break;
            case 2: Agregar(); break;
            case 3: Consulta(); break;
            case 4: Reporte(); break;
            case 5: AsignarCita(); break;
            default:
                break;
        }
    } while ( opcion!=6);
}
