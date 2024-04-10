using System;
using System.Text;
using com.ibm.icu.impl;
using org.apache.pdfbox;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {

            string nome = "alisson";
            var textoIncorp = $"Ola meu grande amigo, {nome}";

            //testando comparações de strings
            var texto = "testando meu programa de C#";
            Console.WriteLine(texto.Contains("testando"));
            Console.WriteLine(texto.Contains("Testando", StringComparison.OrdinalIgnoreCase));

            //começa com, ou termina com.
            Console.WriteLine(texto.StartsWith("testando"));
            Console.WriteLine(texto.EndsWith("c#", StringComparison.OrdinalIgnoreCase));

            //comparar varios objetos, string, double, int...
            Console.WriteLine(texto.Equals("testando meu programa de C#"));

            //index em strings
            Console.WriteLine(texto[0]);
            Console.WriteLine(texto.IndexOf('t'));

            //adicionar texto, remover, ler tamanho e trocar texto.
            Console.WriteLine(texto.Insert(0, "Teste"));
            Console.WriteLine(texto.Remove(0, 7));
            Console.WriteLine(texto.Length);
            Console.WriteLine(texto.Replace("C#", "Java"));

            //dividir um texto
            var divisao = texto.Split(" ");
            var i=0;
            for (i=0;i<divisao.Length;i++){
                Console.WriteLine(divisao[i]);
            }

            //substrings
            var resultado = texto.Substring(0, 9);
            Console.WriteLine(resultado);

            //trim remove espaços no começo e no final
            var texto2 = "   Testando meu programa de C#   ";
            Console.WriteLine(texto2.Trim());

            //string builder - para manipular strings de forma mais eficiente que o string normal

            var txt = new StringBuilder();
            txt.Append("Teste");
            txt.Append(" ");
            txt.Append("de");
            txt.Append(" ");
            txt.Append("string");
            Console.WriteLine(txt);
            
        }
    }
}