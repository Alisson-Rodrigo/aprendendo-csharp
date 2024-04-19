using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
 
    class Program {
        static void Main() {
            var pessoa = new Pessoa();
            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();

        }
        public class Pessoa {
            public string pessoa {get; set;}

        }

        public class PessoaFisica : Pessoa {
            public string CPF { get; set; }
        }

        public class PessoaJuridica : Pessoa {
            public string CNPJ { get; set; }
        }



    }
}