using System;

namespace MeuApp
{
   
    class Program {
        static void Main() {
            var array = new int[3];

            try {
                for (int i=0;i<5;i++) {
                    array[i] = i;
                }
            }
            catch (IndexOutOfRangeException e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("Índice fora do intervalo");
            }
            catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("Valor inválido");
            }
            //sempre vai acontecer
            finally {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Fim do programa");
            } 

            var texto = "";
            Salvar(texto);

        }

        static void Salvar(string texto) {
            if (string.IsNullOrEmpty(texto)) {
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
            }
        }
    }
}