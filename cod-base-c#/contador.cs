using System;
using System.Threading;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {
            Menu();
            
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S - Segundo");
            Console.WriteLine("M - Minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção:");
            string data = Console.ReadLine()?.ToLower();
            char opcaoData = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0,data.Length - 1));

            switch (opcaoData) {
                case 's':
                    StartTime(time);
                    break;
                case 'm':
                    StartTime(time * 60);
                    break;
                case '0':
                    break;
                default:
                    Menu();
                    break;
            }



        }

        static void StartTime(int time) {
            int currentTime = 0;

            while (currentTime <= time) {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Acabou o tempo!");
        }
    }
}