using DataEntryPOC.Domain.Entities;
using DataEntryPOC.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Domain.Services
{
    public class SolicitacaoService : ServiceBase<Solicitacao> , ISolicitacaoService
    {
        
        //COMENTADO PORQUE NAO CRIEI O REPOSITÓRIO DE SOLICITACAO AINDA, APENAS DEMONSTRAÇÃO
        //private readonly ISolicitacaoRepository _solicitacaoRepository;

        //public ClienteService(ISolicitacaoRepository solicitacaoRepository)
        //    : base(solicitacaoRepository)
        //{
        //    _solicitacaoRepository = solicitacaoRepository;
        //}


        public IEnumerable<Solicitacao> ObterSolicitacoesEspeciais(IEnumerable<Solicitacao> solicitacoes)
        {
            return solicitacoes.Where(c => c.SolicitacaoEspecial(c));
        }
    }
}
