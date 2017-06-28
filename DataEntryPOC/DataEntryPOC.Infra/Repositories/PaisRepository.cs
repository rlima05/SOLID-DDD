using DataEntryPOC.Domain.Entities;
using DataEntryPOC.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPOC.Infra.Repositories
{
    public class PaisRepository : RepositoryBase<Pais>, IPaisRepository
    {
    }
}
