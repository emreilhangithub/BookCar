using BookCar.Application.Features.CQRS.Queries.CarQueries;
using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                CarID = values.CarID,
                BrandID = values.BrandID,
                BigImageUrl = values.BigImageUrl,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,                
                Transmission = values.Transmission,
                Seat = values.Seat,
                Model = values.Model,
                Km = values.Km,
                Luggage = values.Luggage                
            };
        }
    }
}
