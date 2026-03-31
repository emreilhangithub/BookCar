using BookCar.Application.Features.CQRS.Commands.AboutCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;

namespace BookCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public RemoveAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }

    }
}
