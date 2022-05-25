using TopSegurosBrasil.Dominio.Enums;

namespace TopSegurosBrasil.Dominio.Entidades
{
    public class ContaBancaria
    {
        public ContaBancaria(int agencia, TipoConta tipo, int conta, int codBanco)
        {
            Agencia = agencia;
            Tipo = tipo;
            Conta = conta;
            CodBanco = codBanco;
        }

        public int Agencia { get; }
        public TipoConta Tipo { get; }
        public int Conta { get; }
        public int CodBanco { get; }
    }
}
