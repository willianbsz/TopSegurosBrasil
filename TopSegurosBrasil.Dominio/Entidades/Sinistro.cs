using TopSegurosBrasil.Dominio.Enums;

namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Sinistro
    {
        public Sinistro(Cliente requisitante)
        {
            if (!requisitante.PodeFazerChamado)
                throw new ArgumentException("Requisição negada. Motivo: Pagamento em atraso.");

            Requisitante = requisitante;
            DataSolicitacao = DateTime.UtcNow;
            Status = StatusSinistro.SolicitacaoEmAndamento;
        }

        public Cliente Requisitante { get; }
        public Documento? BoletimOcorrencia { get; private set; }
        public Documento? AnaliseDoVeiculo { get; private set; }
        public StatusSinistro Status { get; private set; }
        public DateTime DataSolicitacao { get; }
        public DateTime DataInicioBusca { get; private set; }
        public DateTime DataInicioAnalise { get; private set; }
        public DateTime DataFimAnalise { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public bool PrazoEmAtraso => VerificarPrazoEmAtraso();

        private bool VerificarPrazoEmAtraso()
        {
            if (Status == StatusSinistro.SolicitacaoEmAndamento && DataInicioBusca == default)
                return true;

            else if (Status == StatusSinistro.BuscaDoVeiculoIniciada && DataInicioBusca.AddDays(2) > DateTime.UtcNow)
                return true;

            return false;
        }

        public void RealizarDevoluçãoVeiculo() { }

        public void RealizarRessarcimento() { }

        public void IniciarBuscaDoVeiculo()
        {
            DataInicioBusca = DateTime.UtcNow;
            Status = StatusSinistro.AnaliseDoVeiculoIniciada;
        }

        public void AdicionarBoletimDeOcorrencia(Documento documento)
        {
            BoletimOcorrencia = documento;
            DataInicioBusca = DateTime.UtcNow;
            Status = StatusSinistro.BuscaDoVeiculoIniciada;
        }

        public void AdicionarAnaliseDoVeiculo(Documento documento, bool veiculoEmBomEstado)
        {
            AnaliseDoVeiculo = documento;

            if (veiculoEmBomEstado)
            {
                DataFimAnalise = DateTime.UtcNow;
                Status = StatusSinistro.AguardandoRessarcimento;
            }

            else
            {
                DataFimAnalise = DateTime.UtcNow;
                Status = StatusSinistro.AguardandoDevolução;
            }
        }

        public void Cancelar()
        {
            DataFinalizacao = DateTime.UtcNow;
            Status = StatusSinistro.AtendimentoCancelado;
        }

        public void FinalizarAtendimento()
        {
            DataFinalizacao = DateTime.UtcNow;
            Status = StatusSinistro.AtendimentoFinalizado;
        }
    }
}
