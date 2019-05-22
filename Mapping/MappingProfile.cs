using AutoMapper;
using VegaCS.Controllers.Resources;
using VegaCS.Models;

namespace VegaCS.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>().ReverseMap();
            CreateMap<Model, ModelResource>().ReverseMap();
        }
    }
}