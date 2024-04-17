using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
    class Program {
        static void Main() {
            var pagBoleto = new Pagamento();
            pagBoleto.vencimento = DateTime.Now;
            Console.WriteLine(pagBoleto.vencimento);

        }

        class Pagamento : IDisposable {

            //Propriedades
            public DateTime vencimento { get; set; }

            //Construtor
            public Pagamento() {
                vencimento = DateTime.Now;
            }

            //Metodos
            private void Pagar() {
                Console.WriteLine("Pagamento efetuado");
            }

            //modificadores de acesso private, protected, public, internal
            //private: só pode ser acessado dentro da classe
            //protected: só pode ser acessado dentro da classe e suas subclasses
            //public: pode ser acessado de qualquer lugar
            //internal: pode ser acessado apenas dentro do mesmo assembly
            //virtual: pode ser sobrescrito
            //override: sobrescreve um método virtual
            //sealed: impede que um método seja alterado


            public virtual void Cancelar() {
                Console.WriteLine("Pagamento cancelado");
            }
            
            //garantir que o metodo será fechado após o seu uso.
            public void Dispose(){
                Console.WriteLine("Objeto destruído");
            }
        }

        class Pagamento_boleto : Pagamento {
            public string? banco;

            public void Pagar() {
                Console.WriteLine("Pagamento via boleto efetuado");
            }

            public override void Cancelar() {
                Console.WriteLine("Pagamento via boleto cancelado");



        }

    
    }
}
}