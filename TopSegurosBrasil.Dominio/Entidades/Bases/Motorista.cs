namespace TopSegurosBrasil.Dominio.Entidades.Bases
{
    public class Motorista
    {
        public Motorista(Pessoa dadosPessoais, Veiculo veiculo)
        {
            DadosPessoais = dadosPessoais;
            Veiculo = veiculo;
        }

        public Pessoa DadosPessoais { get; }
        public Veiculo Veiculo { get; }
    }
}