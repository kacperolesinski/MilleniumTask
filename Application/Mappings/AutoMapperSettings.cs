using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public static class AutoMapperSettings
    {
        public static IMapper Initialize()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<Person, PersonDto>();
            });
            return mapperConfiguration.CreateMapper();
        }
    }
}
