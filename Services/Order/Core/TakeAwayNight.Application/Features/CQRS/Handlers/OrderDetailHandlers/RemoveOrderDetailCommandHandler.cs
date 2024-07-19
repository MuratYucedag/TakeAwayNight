using TakeAwayNight.Application.Features.CQRS.Commands.OrderDetailCommands;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;
        public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderDetailCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}
