using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.AddressCommands;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAddressCommand command)
        {
            await _repository.CreateAsync(new Address
            {
                City = command.City,
                Detail = command.Detail,
                District = command.District,
                Name = command.Name,
                UserId = command.UserId
            });
        }
    }
}
