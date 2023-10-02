using AutoMapper;
using ProjetoCleanArchiteture.Application.ViewModels;
using ProjetoCleanArchiteture.Domain.Entities;

namespace ProjetoCleanArchiteture.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}
