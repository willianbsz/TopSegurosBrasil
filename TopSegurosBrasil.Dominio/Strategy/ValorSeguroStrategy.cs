using TopSegurosBrasil.Dominio.Enums;

namespace TopSegurosBrasil.Dominio.Strategy
{
    public static class CoberturaSeguroStrategy
    {
        static readonly Dictionary<TipoSeguro, List<string>> CoberturaPorSeguro = new()
        {
                {TipoSeguro.Basico,new List<string>(){"Vidros", "Assitencia 24h" } },
                {TipoSeguro.Intermdiario,new List<string>(){"Vidros", "Assitencia 24h", "Colisão", "Roubo e furto(80% da tabela)" } },
                {TipoSeguro.Total,new List<string>(){"Vidros", "Assitencia 24h", "Colisão", "Roubo e furto(100% da tabela)", "Terceiros" } },
        };
        public static List<string> ObterCoberturaSeguro(TipoSeguro Seguro) { return CoberturaPorSeguro[Seguro]; }
    }
}
