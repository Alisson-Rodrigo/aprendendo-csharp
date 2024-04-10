using System;
using org.apache.pdfbox.util.@operator;

namespace MeuApp {
        public static class Menu {
            public static void Show() {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seja bem-vindo ao MeuApp");

                DrawScreen();
                WriteOptions();
                short opcao = short.Parse(Console.ReadLine());
                HandleMenuOption(opcao);


            }

            public static void DrawScreen() {
                barraHorizontal();
                barrasVerticais();
                barraHorizontal();

            }

            public static void barrasVerticais() {
                for (int i = 0; i < 10; i++) {
                Console.Write("|");
                    for (int j = 0; j < 30; j++) {
                        Console.Write(" ");
                    }
                Console.WriteLine("|");
                }
            }

            public static void barraHorizontal() {
                Console.Write("+");
                for (int i = 0; i < 30; i++) {
                    Console.Write("-");
                }
                Console.Write("+");
                Console.Write("\n");
            }

            public static void WriteOptions() {
                Console.SetCursorPosition(3,2);
                Console.WriteLine("Editor HTML");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("============");
                Console.SetCursorPosition(3, 5); 
                Console.WriteLine("1 - Novo arquivo");
                Console.SetCursorPosition(3, 7); 
                Console.WriteLine("2 - Abrir arquivo");
                Console.SetCursorPosition(3, 9); 
                Console.WriteLine("3 - Sair");
                Console.SetCursorPosition(3, 11); 
                Console.Write("Escolha uma opção: ");
            }

            public static void HandleMenuOption(short option) {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Editor HTML");
                        Editor.Show();
                        break;
                    case 2:
                        Console.WriteLine("Abrir arquivo");
                        break;
                    case 3:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Show();
                        break;
                }
            }


        }
}   