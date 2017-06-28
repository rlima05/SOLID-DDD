using DataEntryPOC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Application.Interfaces
{
    public interface ISolicitacaoAppService : IAppServiceBase<Solicitacao>
    {
        IEnumerable<Solicitacao> ObterSolicitacoesEspeciais(IEnumerable<Solicitacao> solicitacoes);
    }
}
