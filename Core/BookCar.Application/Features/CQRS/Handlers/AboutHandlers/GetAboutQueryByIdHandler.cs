using BookCar.Application.Features.CQRS.Queries.AboutQueries;
using BookCar.Application.Features.CQRS.Results.AboutResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;

namespace BookCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryByIdHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryByIdHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title
            };
        }
    }
}
