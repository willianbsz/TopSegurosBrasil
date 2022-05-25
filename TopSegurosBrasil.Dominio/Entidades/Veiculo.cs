namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Veiculo
    {
        public Veiculo(string placa, long renavan, string chassi, string cor, string modelo, int ano)
        {
            Placa = placa;
            Renavan = renavan;
            Chassi = chassi;
            Cor = cor;
            Modelo = modelo;
            Ano = ano;
        }

        public string Placa { get; }
		public long Renavan { get; }
		public string Chassi { get; }
		public string Cor { get; }
		public string Modelo { get; }
		public int Ano { get; }
	}
}