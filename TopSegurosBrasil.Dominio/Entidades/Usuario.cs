namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Usuario
    {
        public Usuario(string nome, string email, string senha)
        {
            if (senha.Length < 6)
                throw new ArgumentException("Senha precisa ter 6 caracteres");
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public string Nome { get; }
        public string Email { get; }
        public string Senha { get; }
    }
}
