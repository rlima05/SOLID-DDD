using AutoMapper;
using DataEntryPOC.Domain.Entities;
using DataEntryPOC.MVC.ViewModels;
namespace DataEntryPOC.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }


        protected override void Configure()
        {
            CreateMap<Pais, PaisViewModel>();
        }
    }
}