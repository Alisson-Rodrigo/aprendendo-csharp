using System;
using System.Text;

namespace MeuApp {
    public static class Editor {
        public static void Show() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo EDITOR");
            Console.WriteLine("============");
            Start();

        }

        public static void Start() {
            var file = new StringBuilder();
            
            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());

        }


    }
}