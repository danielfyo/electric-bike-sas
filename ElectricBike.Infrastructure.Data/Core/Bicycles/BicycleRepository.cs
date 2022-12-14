using ElectricBike.Domain.Core.Bicycles;
using ElectricBike.Infrastructure.Data.Base;
using ElectricBike.Infrastructure.Data.Core.Context;

namespace ElectricBike.Infrastructure.Data.Core.Bicycles;

public class BicycleRepository : BaseRepository<Bicycle>, IBicycleRepository
{
    public BicycleRepository(ICoreDbContext unitOfWork) : base(unitOfWork) { }
}