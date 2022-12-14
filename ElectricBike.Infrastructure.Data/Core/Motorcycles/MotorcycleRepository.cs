using ElectricBike.Domain.Core.Motorcycles;
using ElectricBike.Infrastructure.Data.Base;
using ElectricBike.Infrastructure.Data.Core.Context;

namespace ElectricBike.Infrastructure.Data.Core.Motorcycles;

public class MotorcycleRepository : BaseRepository<Motorcycle>, IMotorcycleRepository
{
    public MotorcycleRepository(ICoreDbContext unitOfWork) : base(unitOfWork) { }
}