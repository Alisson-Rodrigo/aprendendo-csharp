using System;

namespace MeuApp
{
   
    class Program {
        static void Main() {
            var array = new int[5];
            for (int i=0;i<array.Length;i++) {
                Console.WriteLine("Digite um número:");
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach(var item in array) {
                Console.WriteLine(item);
            }

            var funcionarios = new Funcionarios[3] {
                new Funcionarios {Nome = "Maria"},
                new Funcionarios {Nome = "João"},
                new Funcionarios {Nome = "José"}
            };

            foreach(var funcionario in funcionarios) {
                Console.WriteLine(funcionario.Nome);
            }

        }

        struct Funcionarios {
            public string Nome;

        }
    }
}