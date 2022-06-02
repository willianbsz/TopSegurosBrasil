namespace TopSegurosBrasil.Dominio.Entidades.Bases
{
    public class  Pessoa
    {
        public Pessoa(string nome, string cPF, string email, DateTime dataNasc, Endereco endereco)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            DataNasc = dataNasc;
            Endereco = endereco;
        }

        public string Nome { get; }
        public string CPF { get; }
        public string Email { get; }
        public DateTime DataNasc { get; }
        public Endereco Endereco { get; }
    }
}
