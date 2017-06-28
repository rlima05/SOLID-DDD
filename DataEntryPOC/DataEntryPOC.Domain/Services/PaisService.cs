

using DataEntryPOC.Domain.Entities;
using DataEntryPOC.Domain.Interfaces.Repositories;
using DataEntryPOC.Domain.Interfaces.Services;
namespace DataEntryPOC.Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisService(IPaisRepository paisRepository)
            : base(paisRepository)
        {
            _paisRepository = paisRepository;
        }
    }
}
