using AutoMapper;
using ElectricBike.Application.Core.Services.EngineSuppliers;

namespace ElectricBike.Application.Core.Services.Persons;

public class PersonMapperProfile  : Profile
{
    public PersonMapperProfile()
    {
        CreateMap<Domain.Core.EngineSuppliers.EngineSupplier, EngineSupplierDto>().ReverseMap();
    }
}