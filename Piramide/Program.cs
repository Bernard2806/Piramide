using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            Console.WriteLine("Alto: " + Console.WindowHeight);
            Console.WriteLine("Ancho: " + Console.WindowWidth);
            Console.ReadKey();
            CrearPiramide();
        }

        static void MostrarMenu() {
            string ASCIIArtMenu = @"
   ___ _                     _     _      
  / _ (_)_ __ __ _ _ __ ___ (_) __| | ___ 
 / /_)/ | '__/ _` | '_ ` _ \| |/ _` |/ _ \
/ ___/| | | | (_| | | | | | | | (_| |  __/
\/    |_|_|  \__,_|_| |_| |_|_|\__,_|\___|
                                          
";
            Console.WriteLine(ASCIIArtMenu);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void CrearPiramide() {
            Console.Clear();
            Console.WriteLine("Ingrese el largo inicial de la piramide:");
            int LargoPIni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el espacio entre (*) de la piramide:");
            MostarPiramide(LargoPIni, int.Parse(Console.ReadLine()));
            Console.ReadKey();

        }
        static void MostarPiramide(int Inicial, int Espaciado) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            int Salto = (Console.WindowHeight - Inicial) / 2;
            CrearSalto(Salto);
            for (int x = 0; x <= Inicial; x++) MostarFila(x, Espaciado);
            CrearSalto(Salto);
        }
        static void MostarFila(int caracteres, int separacion) {
            int espacio = (Console.WindowWidth - (caracteres * (separacion + 1))) / 2;
            CrearEspacios(espacio);
            for (int i = 0; i < caracteres; i++) {
                Console.Write("*");
                for (int sep = 0; sep < separacion; sep++) {
                    Console.Write(" ");
                }
            }
            CrearEspacios(espacio);
        }
        static void CrearEspacios(int e) {
            for (int x = 0; x < e; x++) Console.Write(" ");
        }
        static void CrearSalto(int s) {
            for (int l = 0; l < s; l++) Console.WriteLine("");
        }
    }
}
