﻿using System;

namespace ejercicioguithub
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do
            {
                Console.Clear();
                Marco();
                Console.SetCursorPosition(50, 5); Console.Write("1.) Quienes somos ? ");
                Console.SetCursorPosition(50, 6); Console.Write("2.) Menu Aplicacion ");
                Console.SetCursorPosition(50, 7); Console.Write("0.) Salir ");
                Console.SetCursorPosition(50, 8); Console.Write("Digite una opcion. ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        QuienesSomos();
                        break;
                    case 2:
                        MenuAplicacion();
                        break;
                    case 0:
                        Console.WriteLine("Lo Intentamos Profe !!!!!  ");
                        break;
                    default:
                        Console.WriteLine("opcion invalida  !!!!");
                        break;
                }

            } while (opcion > 0);



        }

        static void QuienesSomos()
        {
            Console.Clear();
            Marco();
            Console.SetCursorPosition(50, 5); Console.Write("Este es el codigo de quienes somos ....");
            Console.SetCursorPosition(50, 23); Console.Write("Presiona cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static void MenuAplicacion()
        {
            Console.Clear();
            Marco();
            Console.SetCursorPosition(50, 5); Console.WriteLine("Este es el codigo de menu aplicacion ....");
            Console.SetCursorPosition(50, 23); Console.WriteLine("Presiona cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static void Marco()
        {
            for (int i = 1; i <= 110; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 25); Console.Write("═");
            }

            for (int i = 1; i <= 25; i++)
            {
                Console.SetCursorPosition(1, i); Console.Write("║");
                Console.SetCursorPosition(110, i); Console.Write("║");
            }

            Console.SetCursorPosition(1, 1); Console.Write("╔");
            Console.SetCursorPosition(110, 1); Console.Write("╗");
            Console.SetCursorPosition(1, 25); Console.Write("╚");
            Console.SetCursorPosition(110, 25); Console.Write("╝");


        }

    }
    
}
