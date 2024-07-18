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
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.Detail = command.Detail;
            values.City = command.City;
            values.District = command.District;
            values.UserId = command.UserId;
            values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
