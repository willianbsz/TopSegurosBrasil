using TopSegurosBrasil.Dominio.Enums;
using TopSegurosBrasil.Dominio.Strategy;

namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Seguro
    {
        public Seguro(TipoSeguro tipo)
        {
            Tipo = tipo;
        }

        public TipoSeguro Tipo { get; }
        public List<string> Coberturas => CoberturaSeguroStrategy.ObterCoberturaSeguro(Tipo);

        public double Valor => ValorSeguroStrategy.ObterValorSeguro(Tipo);
    }
}
