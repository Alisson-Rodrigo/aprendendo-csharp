using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
    class Program {
        static void Main() {
            int[,] numeros = new int[10, 10];

            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    numeros[i, j] = i + j;
                }
            }

            for (int i = 0;i<10;i++) {
                for (int j=0;j<10;j++) {
                    Console.Write(numeros[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
