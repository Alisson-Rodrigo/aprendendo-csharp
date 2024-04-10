using System;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {
            Menu();
        }
        static void Menu() {
            Console.WriteLine("Calculadora do Alisson\n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5: 
                    Environment.Exit(0);
                    break;
            }
        }
        static void Soma() {

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float resultado = valor1 + valor2;

            Console.WriteLine($"Resultado: {resultado}");

        }
        static void Subtracao() {

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float resultado = valor1 - valor2;

            Console.WriteLine($"Resultado: {resultado}");

        }
        static void Multiplicacao() {

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float resultado = valor1 * valor2;

            Console.WriteLine($"Resultado: {resultado}");

        }
        static void Divisao() {

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float resultado = valor1 / valor2;

            Console.WriteLine($"Resultado: {resultado}");

        }
    
    }
}