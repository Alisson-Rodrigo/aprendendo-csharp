using System;
using System.Threading;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {
            Menu();
            
        }
        
        static void Menu () {
            Console.Clear();
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option) {
                case 0: System.Environment.Exit(0); break;
                case 1: AbrirArq(); break;
                case 2: CriarArq(); break;
                default: Menu(); break;
            }
        }

        static void AbrirArq() {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            if (path == null) {
                Console.WriteLine("Caminho inválido!");
                Menu();
            }

            using (var file = new StreamReader(path)) {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void CriarArq() {
            Console.WriteLine("Digite o texto abaixo: (ESC para sair)\n");
            string text = "";

            do {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("Deseja salvar o arquivo? (S/N)");
            string opc = Console.ReadLine();

            switch(opc.ToUpper()) {
                case "S": Salvar(text); break;
                case "N": Menu(); break;
                default: CriarArq(); break;
            }
        }



        static void Salvar(string text) {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            if (path != null) {
                using (var file = new StreamWriter(path)) {
                    file.Write(text);
                }
            }

            Console.Write($"Arquivo {path} salvo com sucesso!", ConsoleColor.Green);
            Menu();
        }
    }
}