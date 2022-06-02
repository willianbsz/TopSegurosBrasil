using TopSegurosBrasil.Dominio.Enums;

namespace TopSegurosBrasil.Dominio.Entidades
{
    public class Chamado
    {
        public Chamado(Cliente requisitante, Endereco local)
        {
            if (!requisitante.PodeFazerChamado)
                throw new ArgumentException("Requisição negada. Motivo: Pagamento em atraso.");

            Requisitante = requisitante;
            DataSolicitacao = DateTime.UtcNow;
            Status = StatusChamado.SolicitacaoEmAndamento;
            LocalOcorrencia = local;
        }

        public Cliente Requisitante { get; }
        public Endereco LocalOcorrencia { get; }
        public Guincho? Guincho { get; private set; }
        public StatusChamado Status { get; private set; }
        public DateTime DataSolicitacao { get; }
        public DateTime DataResgate { get; private set; }
        public DateTime DataFinalizacao { get; private set; }


        public void AtribuirGuincho(Guincho guincho)
        {
            Guincho = guincho;
            Status = StatusChamado.AguardandoGuincho;
        }
        public void Cancelar()
        {
            DataFinalizacao = DateTime.UtcNow;
            Status = StatusChamado.AtendimentoCancelado;
        }
        public void ResgatarVeiculo()
        {
            DataResgate = DateTime.UtcNow;
            Status = StatusChamado.VeiculoResgatado;
        }
        public void FinalizarAtendimento()
        {
            DataFinalizacao = DateTime.UtcNow;
            Status = StatusChamado.AtendimentoFinalizado;
        }
    }
}
