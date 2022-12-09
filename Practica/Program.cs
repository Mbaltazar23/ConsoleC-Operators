using System;

namespace Practica
{
    class Program
    {

        static int num1 = 0, num2 = 0;
        static void Main(string[] args)
        {
            string res = "si";
            int opcion = 0;

            while (res.Equals("si"))
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Operaciones Aritmeticas");
                Console.WriteLine("=======================");
                Console.WriteLine("   1-Suma ");
                Console.WriteLine("   2-Resta");
                Console.WriteLine("   3-Multiplicacion");
                Console.WriteLine("   4-Division");
                Console.WriteLine("=======================");
                Console.WriteLine();
                do
                {
                    try
                    {
                        Console.Write("Digite una opcion : ");
                        opcion = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Opcion no Valida !!");
                    }
                } while (!(opcion >= 1 && opcion <= 4));

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Esta Sumando.......");
                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el primer numero : ");
                                num1 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num1 >= 1 && num1 <= 10000));

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el segundo numero : ");
                                num2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num2 >= 1 && num2 <= 10000));
                        Console.WriteLine("La suma de los 2 numeros es : {0}", suma(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Esta Restando.......");
                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el primer numero : ");
                                num1 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num1 >= 1 && num1 <= 10000));

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el segundo numero : ");
                                num2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num2 >= 1 && num2 <= 10000));
                        Console.WriteLine("La resta de los 2 numeros es : {0}", resta(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Esta Multiplicando.......");
                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el primer numero : ");
                                num1 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num1 >= 1 && num1 <= 10000));

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el segundo numero : ");
                                num2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num2 >= 1 && num2 <= 10000));
                        Console.WriteLine("La multiplicacion de los 2 numeros es : {0}", multiplicar(num1, num2));
                        break;

                    case 4:
                        Console.WriteLine("Esta Dividiendo.......");
                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el primer numero : ");
                                num1 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num1 >= 1 && num1 <= 10000));

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el segundo numero : ");
                                num2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Numero no valido !!");
                            }
                        } while (!(num2 >= 1 && num2 <= 10000));
                        Console.WriteLine("La division de los 2 numeros es : {0}", dividir(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Programa Cerrandose");
                        Console.ReadKey();
                        break;
                }
                do
                {
                    Console.WriteLine("Desea ejercutar mas acciones ? ");
                    res = Console.ReadLine();
                } while (!res.Equals("si"));


            }
        }


        static int suma(int a, int b)
        {
            return a + b;
        }

        static int resta(int a, int b)
        {
            return a - b;
        }

        static int multiplicar(int a, int b)
        {
            return a * b;
        }

        static int dividir(int a, int b)
        {
            return a / b;
        }
    }
}
