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
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {

        private readonly IPaisService _paisService;

        public PaisAppService(IPaisService paisService)
            : base(paisService)
        {
            _paisService = paisService;
        }
    }
}
