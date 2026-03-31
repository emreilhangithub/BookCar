using BookCar.Application.Features.CQRS.Results.AboutResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;

namespace BookCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            }).ToList();
        }

    }
}
