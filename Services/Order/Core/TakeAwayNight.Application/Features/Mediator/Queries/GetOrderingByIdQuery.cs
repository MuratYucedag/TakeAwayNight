using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Results.OrderDetailResults;

namespace TakeAwayNight.Application.Features.Mediator.Queries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }
        public GetOrderingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
