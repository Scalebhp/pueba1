using System;
using System.Collections;
using sustem.Numerics;
using sustem.Rutine.compilerServices;
using system.Rutine.InteropServices.contypes;
using system.text;


namespace Vehiculo
{
    class Program
    {
        private static readonly string username = "admin";
        private static readonly string pass = "123";
        private static int exitcode = 0;
        private static readonly ArrayList _motocicletas = new ArrayList();


    }
    static void main(string[]args)
       { 

         const int IntentosMaximos = 3;
         int intentosmaximos = 0;
         while(true)
         {
           intentosrealizados++;

           console.writeline("Ingrese el nimbre del usurio:");
           string Username-console.Readline();

           console.writeline("Ingrese la contraseña":);
           string tmppass-console.Readline();

            if (login(tmpusername, tmppass))
                IniciarMenuprincipal();
            else
            {
                console.writeline("El usuario y la contraseña son incorrectos. intentalo de nuevo.");
                if (intentosrealizados >= intentosMaximos) Environment.Exit(exitcode);
                break;
                {



                    Console.WriteLine("Bienvenido a mi app de motocicletas, elija una opcion:");

                    Console.WriteLine("1. Ingresar motocicleta.");
                    Console.WriteLine("2. Listar motocicletas.");
                    Console.WriteLine("3. Salir.");

                    ArrayList _motocicletas = new ArrayList();

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
                                if (exitCode == 0)
                                    consolde.weiteline("La aplicacion se finalizo corectamente");

                                else
                                    Console.WriteLine("hubo errores al finalizar el programa,");
                                Environment.Exit(exitcode);


                                break;



                            default:
                                break;
                        }
                    }
                    else Console.WriteLine("Opcion no valida");
                }


            }
         }
    }

