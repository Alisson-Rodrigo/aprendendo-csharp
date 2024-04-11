using System;
using System.Globalization;

namespace MeuApp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Moedas, preço, salario - usar DECIMAL
            decimal valor = 10.50m;
            Console.WriteLine(valor.ToString("C", new CultureInfo("en-US")));
            Console.WriteLine(valor.ToString("C", new CultureInfo("pt-BR")));
            Console.WriteLine(valor.ToString("C", new CultureInfo("de-DE")));

            //Porcentagem - usar DECIMAL
            decimal porcentagem = 0.5m;
            Console.WriteLine(porcentagem.ToString("P", new CultureInfo("en-US")));

            //arrerondamento - usar DECIMAL
            decimal valorArredondado = Math.Round(10.5m);
            Console.WriteLine(valorArredondado);

            //arrerondamento pra cima
            decimal valorArredondadoCima = Math.Ceiling(10.1m);

            //arrerondamento pra baixo
            decimal valorArredondadoBaixo = Math.Floor(10.9m);

            //formatação de numeros - usar DECIMAL
            decimal numero = 1000.50m;
            Console.WriteLine(numero.ToString("N", new CultureInfo("en-US")));







        }
    }
    
}