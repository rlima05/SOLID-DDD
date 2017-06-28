using DataEntryPOC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Domain.Interfaces.Services
{
    public interface ISolicitacaoService : IServiceBase<Solicitacao>
    {
        IEnumerable<Solicitacao> ObterSolicitacoesEspeciais(IEnumerable<Solicitacao> solicitacoes);
    }
}
