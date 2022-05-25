using TopSegurosBrasil.Dominio.Enums;

namespace TopSegurosBrasil.Dominio.Strategy
{
    public static class ValorSeguroStrategy
    {
        static readonly Dictionary<TipoSeguro, double> ValorPorSeguro = new()
        {
                {TipoSeguro.Basico, 150},
                {TipoSeguro.Intermdiario, 300 },
                {TipoSeguro.Total, 600},
        };
        public static double ObterValorSeguro(TipoSeguro Seguro) { return ValorPorSeguro[Seguro]; }
    }
}
