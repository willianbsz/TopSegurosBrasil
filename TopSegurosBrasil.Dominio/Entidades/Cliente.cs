using TopSegurosBrasil.Dominio.Entidades.Bases;

namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Cliente : Motorista
    {
        public Cliente(Pessoa dadosPessoais, Veiculo veiculo, double saldoapagar, Seguro? seguro) : base(dadosPessoais, veiculo)
        {
            SaldoAPagar = saldoapagar;
            Seguro = seguro;
        }
        public Seguro? Seguro { get; private set; }

        public bool PodeFazerChamado => SaldoAPagar == 0;
        public double SaldoAPagar { get; private set; }

        public void Pagar(double valor)
        {
            if (SaldoAPagar < valor)
                throw new ArgumentException("Valor pago é maior que o saldo a pagar");
            SaldoAPagar -= valor;
        }

        public void InserirSaldo(double valor)
        {
            
            if (Seguro.Valor != valor)
                throw new ArgumentException("Cobrança indevida");
            
            SaldoAPagar += valor;
        }
        public void EscolherSeguro(Seguro seguro)
        {
            Seguro = seguro;
        }
    }
}
