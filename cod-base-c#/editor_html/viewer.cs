using System;
using System.Text.RegularExpressions;


namespace MeuApp {
    public static class Viewer {
        public static void Show(string text) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo VISUALIZADOR");
            Console.WriteLine("------------------");
            Replace(text);
            Console.WriteLine("------------------");

        }

        public static void Replace(string text) {
            var strong = new Regex("<strong>(.*?)</strong>");
            var words = text.Split(" ");
            for (var i=0;i<words.Length;i++) {
                if (strong.IsMatch(words[i])) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(words[i].Replace("<strong>", "").Replace("</strong>", ""));
                    Console.Write(" ");
                } else {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
            }

                
            }
        }
    }
}