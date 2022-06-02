using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSegurosBrasil.Dominio.Enums
{
    public enum StatusSinistro
    {
        SolicitacaoEmAndamento,
        BuscaDoVeiculoIniciada,
        AnaliseDoVeiculoIniciada,
        AguardandoRessarcimento,
        AguardandoDevolução,
        AtendimentoFinalizado,
        AtendimentoCancelado
    }
}
