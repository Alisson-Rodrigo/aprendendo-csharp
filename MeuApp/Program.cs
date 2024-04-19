using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
 
    class Program {
        static void Main() {
            var banco = new PagamentoBoleto(DateTime.Now, 1000, "123", "123456789");
            banco.imprimir();
        }

        abstract public class Pagamento : IPagamento {
            protected DateTime DataPagamento { get; set; }
            public decimal Valor { get; set; }
            public string CodigoPagamento { get; set; }

            public Pagamento(DateTime dataPagamento, decimal valor, string codigoPagamento) {
                DataPagamento = dataPagamento;
                Valor = valor;
                CodigoPagamento = codigoPagamento;
            }

            public void Pagar() {
                Console.WriteLine("Pagamento efetuado com sucesso!");
            }

            public void Cancelar() {
                Console.WriteLine("Pagamento cancelado com sucesso!");
            }
        }

        class PagamentoBoleto : Pagamento {
            public string CodigoBarras { get; set; }

            public PagamentoBoleto(DateTime dataPagamento, decimal valor, string codigoPagamento, string codigoBarras) : base(dataPagamento, valor, codigoPagamento) {
                this.CodigoBarras = codigoBarras;
            }

            public void imprimir() {
                Console.WriteLine($"o cod {this.CodigoBarras} foi pago com sucesso!");
            }
        }

        public interface IPagamento {
            void Pagar();
            void Cancelar();
        }


    }
}