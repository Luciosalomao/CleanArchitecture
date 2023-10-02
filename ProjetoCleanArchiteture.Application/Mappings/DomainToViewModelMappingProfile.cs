using AutoMapper;
using ProjetoCleanArchiteture.Application.ViewModels;
using ProjetoCleanArchiteture.Domain.Entities;

namespace ProjetoCleanArchiteture.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
