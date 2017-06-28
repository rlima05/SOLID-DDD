using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Domain.Entities
{
    public class SolicitacaoCriacaoItem
    {
        public int SolicitacaoCriacaoItemId { get; set; }
        public int CodItem { get; set; }
        public int SolicitacaoId { get; set; }
        public int MotivoId { get; set; }
        public virtual Solicitacao Solicitacao { get; set; }
        public virtual Motivo Motivo { get; set; }
    }
}
