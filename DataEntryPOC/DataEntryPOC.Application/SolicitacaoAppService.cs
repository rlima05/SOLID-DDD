using DataEntryPOC.Application.Interfaces;
using DataEntryPOC.Domain.Entities;
using DataEntryPOC.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Application
{
    public class SolicitacaoAppService : AppServiceBase<Solicitacao>, ISolicitacaoAppService
    {
         private readonly ISolicitacaoService _solicitacaoService;

         public SolicitacaoAppService(ISolicitacaoService solicitacaoService)
             : base(solicitacaoService)
        {
            _solicitacaoService = solicitacaoService;
        }


        public IEnumerable<Solicitacao> ObterSolicitacoesEspeciais(IEnumerable<Solicitacao> solicitacoes)
        {
            return _solicitacaoService.ObterSolicitacoesEspeciais(_solicitacaoService.GetAll());
        }
    }
}
