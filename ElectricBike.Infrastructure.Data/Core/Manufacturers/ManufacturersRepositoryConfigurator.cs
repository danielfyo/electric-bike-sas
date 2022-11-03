﻿using ElectricBike.Domain.Core.Manufacturers;
using Microsoft.Extensions.DependencyInjection;

namespace ElectricBike.Infrastructure.Data.Core.Manufacturers;

public static class ManufacturersRepositoryConfigurator
{
    public static void ConfigureManufacturersRepository(this IServiceCollection services) =>
        services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
}