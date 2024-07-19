using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Queries.OrderDetailQueries;
using TakeAwayNight.Application.Features.CQRS.Results.OrderDetailResults;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;
        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetOrderDetailByIdQueryResult
            {
                Amount = values.Amount,
                OrderDetailId = values.OrderDetailId,
                OrderingId = values.OrderingId,
                Price = values.Price,
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                TotalPrice = values.TotalPrice
            };
        }
    }
}
