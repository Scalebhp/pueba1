using System;
using System.Collections;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
         ArrayList _motocicletas = new ArrayList();

 

            Console.WriteLine("Bienvenido a mi app de motocicletas, elija una opcion:");
            Console.WriteLine("1. Ingresar motocicleta.");
            Console.WriteLine("2. Listar motocicletas.");
            Console.WriteLine("3. Salir.");

 

            int opcion;
            string input = Console.ReadLine();
            if (int.TryParse(input, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese numero de motor:");
                        string idMotor = Console.ReadLine();

 

                        Console.WriteLine("Ingrese el tipo de motor:");
                        Console.WriteLine("1. Cuatro tiempos.");
                        Console.WriteLine("2. Dos tiempos.");

 

                        TipoMotor tipoMotor = Console.ReadLine() == "2" ? 
                        TipoMotor.DOS_TIEMPOS : TipoMotor.CUATRO_TIEMPOS;

 

                        Console.WriteLine("Ingrese la cilindrada:");
                        int cilindrada = int.Parse(Console.ReadLine());

 

                        Console.WriteLine("Ingrese el año:");
                        int ano = int.Parse(Console.ReadLine());

 

                        Console.WriteLine("Ingrese la marca:");
                        string marca = Console.ReadLine();

 

                        Console.WriteLine("Ingrese el kilometraje:");
                        int kilometraje = int.Parse(Console.ReadLine());

 

                        Motocicleta motocicleta = new Motocicleta(idMotor, tipoMotor, cilindrada,
                                                                  marca, ano, kilometraje);

 

                        _motocicletas.Add(motocicleta);
                        break;

 

                    case 2:
                        break;

 

                    case 3:

 

                        break;

 

                    default:
                        break;
                }
            }
            else Console.WriteLine("Opcion no valida");
            }

            

        }
    }

