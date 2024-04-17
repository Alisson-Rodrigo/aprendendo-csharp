using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
    class Program {
        static void Main() {


        }

        class Pag() {
            public DateTime vencimento { get; set; }
            public DateTime pagamento { get; set; }

            public Pag(DateTime vencimento, DateTime pagamento){
                this.vencimento = vencimento;
                this.pagamento = pagamento;
            }
        }
    }
}