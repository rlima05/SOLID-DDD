using DataEntryPOC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Domain.Entities
{
    public class Solicitacao
    {
        public int SolicitacaoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int TipoSolicitacaoId { get; set; }
        public int StatusId { get; set; }
        public int UsuarioId { get; set; }        
        public DateTime DataUltimaAtualizacao { get; set; }
        public virtual TipoSolicitacao TipoSolicitacao { get; set; }
        public virtual Status Status { get; set; }
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// MÉTODO DE TESTE PARA MOSTRAR QUE ENTIDADE TEM MÉTODOS
        /// </summary>
        /// <param name="solicitacao"></param>
        /// <returns></returns>
        public bool SolicitacaoEspecial(Solicitacao solicitacao)
        {
            return solicitacao.StatusId == 1 && DateTime.Now.Year == DataCadastro.Year;
        }

    }
}
