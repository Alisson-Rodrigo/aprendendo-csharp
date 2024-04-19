namespace {
    public abstract class Pagamento {
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

    public class PagamentoBoleto : Pagamento {
        public string CodigoBarras { get; set; }

        public PagamentoBoleto(DateTime dataPagamento, decimal valor, string codigoPagamento, string codigoBarras) : base(dataPagamento, valor, codigoPagamento) {
            CodigoBarras = codigoBarras;
        }
    }

    public interface IPagamento {
        void Pagar();
        void Cancelar();
    }
}