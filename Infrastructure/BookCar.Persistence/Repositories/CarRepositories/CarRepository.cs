using BookCar.Application.Interfaces.CarInterfaces;
using BookCar.Domain.Entities;
using BookCar.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BookCar.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly BookCarContext _context;

        public CarRepository(BookCarContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x=> x.Brand).ToList();
            return values;
        }
    }
}
