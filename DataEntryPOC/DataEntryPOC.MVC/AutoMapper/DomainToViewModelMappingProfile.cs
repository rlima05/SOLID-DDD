

using AutoMapper;
using DataEntryPOC.Domain.Entities;
using DataEntryPOC.MVC.ViewModels;
namespace DataEntryPOC.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile :  Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<PaisViewModel, Pais>();
        }
    }
}