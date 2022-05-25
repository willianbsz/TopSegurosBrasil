namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Endereco
    {
        public Endereco(string longadura, int cep, string numero, string complemento, string bairro, string cidade, string uf)
        {
            Longadura = longadura;
            CEP = cep;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
        }

        public string Longadura { get; }
        public int CEP { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string UF { get; }
    }
}
