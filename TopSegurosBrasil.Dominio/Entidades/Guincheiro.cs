using TopSegurosBrasil.Dominio.Entidades.Bases;

namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Guincheiro : Motorista
    {
        public Guincheiro(Pessoa dadosPessoais, Veiculo veiculo, ContaBancaria dadosbancarios, double saldoareceber) : base(dadosPessoais, veiculo)
        {
            DadosBancarios = dadosbancarios;
            SaldoAReceber = saldoareceber;
        }

        public double SaldoAReceber { get; private set; }
        public ContaBancaria DadosBancarios { get; }

        public void Receber(double valor)
        {
            if (SaldoAReceber < valor)
                throw new ArgumentException("Valor pago é maior que o saldo a receber");
            SaldoAReceber -= valor;
        }

        public void InserirSaldo(double valor)
        {
            SaldoAReceber += valor;
        }
    }
}
